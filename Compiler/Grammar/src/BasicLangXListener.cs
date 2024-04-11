using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

namespace Compiler.Grammar.src;

public class BasicLangXListener : KermitLangBaseListener
{
    private readonly Dictionary<string, Variable> _variables = new Dictionary<string, Variable>();
    private readonly Stack<Variable> _stack = new Stack<Variable>();
    private List<string> errors = new List<string>();

    public virtual void ExitStart([NotNull] KermitLangParser.StartContext context)
    {
        ReportErrors();
    }
    public virtual void ExitBase_statement([NotNull] KermitLangParser.Base_statementContext context) { }

    public override void ExitDeclare(KermitLangParser.DeclareContext context)
    {
        var id = context.ID().GetText();

        if (_variables.ContainsKey(id))
        {
            AddError(context.Start.Line, $"Variable {id} is already defined in this scope.");
        }

        if (context.INTEGER_NAME() != null && context.INTEGER() == null)
        {
            AddError(context.Start.Line, $"Value is not an integer.");
        }

        if (context.REAL_NAME() != null && context.REAL() == null)
        {
            AddError(context.Start.Line, $"Value is not a real.");
        }

        if (context.BOOL_NAME() != null && context.BOOL() == null)
        {
            AddError(context.Start.Line, $"Value is not a bool.");
        }

        if (context.STRING_NAME() != null && context.STRING() == null)
        {
            AddError(context.Start.Line, $"Value is not a string.");
        }

        if (context.NUMBER_NAME() != null && context.NUMBER() == null)
        {
            AddError(context.Start.Line, $"Value is not a number.");
        }

        if (context.INTEGER() != null)
        {
            var newVar = new Variable(id, VariableType.INT);
            _variables.Add(id, newVar);
            Generator.AllocateInteger(newVar.Value);
            Generator.AssignInteger(newVar.Value, context.INTEGER().GetText());
        }

        if (context.REAL() != null)
        {
            var newVar = new Variable(id, VariableType.REAL);
            _variables.Add(id, newVar);
            Generator.AllocateDouble(newVar.Value);
            Generator.AssignDouble(newVar.Value, context.REAL().GetText());
        }

        if (context.BOOL() != null)
        {
            var newVar = new Variable(id, VariableType.BOOL);
            _variables.Add(id, newVar);
            Generator.AllocateBool(newVar.Value);
            Generator.AssignBool(newVar.Value, context.BOOL().GetText());
        }

        if (context.STRING() != null)
        {
            var stringValue = id.Substring(1, id.Length - 2);
            var newVar = new StringVariable(stringValue, stringValue.Length);
            if (_variables.ContainsKey(stringValue))
            {
                AddError(context.Start.Line, $"Variable already declared in this scope."); // wrocic do tego
            }

            _variables.Add(id, newVar);
            Generator.AllocateString(newVar.Value, newVar.Length);
            Generator.AssignString(newVar.Value, context.STRING().GetText());
        }

        if (context.NUMBER() != null)
        {
            var newVar = new Variable(id, VariableType.NUMBER);
            _variables.Add(id, newVar);
            // TODO Implement number allocation
            //Generator.AllocateNumber(newVar.Name);
            //Generator.AssignNumber(newVar.Name, context.NUMBER().GetText());
        }
    }

    public override void ExitAssign(KermitLangParser.AssignContext context)
    {
        var id = context.ID(0).GetText();
        if (!_variables.ContainsKey(id))
        {
            AddError(context.Start.Line, $"Variable {id} is not declared in this scope.");
        }

        var variable = _variables[id];
        if (variable.Type == VariableType.INT && context.INTEGER() == null)
        {
            var actualType = GetActualType(context);
            AddError(context.Start.Line, $"Expected a value of type INT for variable {id} but found {actualType}");
        }
        if (variable.Type == VariableType.REAL && context.REAL() == null)
        {
            var actualType = GetActualType(context);
            AddError(context.Start.Line, $"Expected a value of type REAL for variable {id} but found {actualType}");
        }
        if (variable.Type == VariableType.BOOL && context.BOOL() == null)
        {
            var actualType = GetActualType(context);
            AddError(context.Start.Line, $"Expected a value of type BOOL for variable {id} but found {actualType}");
        }
        if (variable.Type == VariableType.STRING && context.STRING() == null)
        {
            var actualType = GetActualType(context);
            AddError(context.Start.Line, $"Expected a value of type STRING for variable {id} but found {actualType}");
        }
        if (variable.Type == VariableType.NUMBER && context.NUMBER() == null)
        {
            var actualType = GetActualType(context);
            AddError(context.Start.Line, $"Expected a value of type NUMBER for variable {id} but found {actualType}");
        }
        if (context.ID(1) != null && !_variables.ContainsKey(context.ID(1).GetText()))
        {
            var secondId = context.ID(1).GetText();
            AddError(context.Start.Line, $"Variable {secondId} is not declared in this scope.");
        }
        if (context.ID(1) != null && _variables[context.ID(1).GetText()].Type != variable.Type)
        {
            var secondId = context.ID(1).GetText();
            var actualTypeSecond = GetActualType(context);
            AddError(context.Start.Line, $"Variable {secondId} ({actualTypeSecond}) type does not match variable {id} type.");
        }

        if (variable.Type == VariableType.INT)
        {
            Generator.AssignInteger(variable.Value, context.INTEGER().GetText());
        }
        if (variable.Type == VariableType.REAL)
        {
            Generator.AssignDouble(variable.Value, context.REAL().GetText());
        }
        if (variable.Type == VariableType.BOOL)
        {
            Generator.AssignBool(variable.Value, context.BOOL().GetText());
        }
        if (variable.Type == VariableType.STRING)
        {
            // TODO Implement string assignment
            //Generator.AssignString(variable.Name, context.STRING().GetText());
        }
        if (variable.Type == VariableType.NUMBER)
        {
            // TODO Implement number assignment
            //Generator.AssignNumber(variable.Name, context.NUMBER().GetText());
        }
    }

    public override void ExitPrint(KermitLangParser.PrintContext context)
    {
        var variable = _stack.Pop();

        if (variable.Type == VariableType.INT)
        {
            Generator.PrintIntegerValue(variable.Value);
        }
        if (variable.Type == VariableType.REAL)
        {
            Generator.PrintReal(variable.Value);
        }
        if (variable.Type == VariableType.BOOL)
        {
            Generator.PrintBool(variable.Value);
        }
        if (variable.Type == VariableType.STRING)
        {
            Generator.PrintString(variable.Value);
        }
        if (variable.Type == VariableType.NUMBER)
        {
            Generator.PrintNumber(variable.Value);
        }
    }

    public override void ExitRead(KermitLangParser.ReadContext context)
    {
        var id = context.ID().GetText();

        if (!_variables.ContainsKey(id))
        {
            AddError(context.Start.Line, $"Variable is not defined in this scope.");
        }

        var variable = _variables[id];
        if (variable.Type == VariableType.INT)
        {
            Generator.ReadInteger(variable.Value);
        }
        if (variable.Type == VariableType.REAL)
        {
            Generator.ReadReal(variable.Value);
        }
        if (variable.Type == VariableType.BOOL)
        {
            Generator.ReadBool(variable.Value);
        }
        if (variable.Type == VariableType.STRING)
        {
            Generator.ReadString(variable.Value);
        }
        if (variable.Type == VariableType.NUMBER)
        {
            Generator.ReadNumber(variable.Value);
        }
    }

    public override void ExitExpression_base_add(KermitLangParser.Expression_base_addContext context)
    {
        base.ExitExpression_base_add(context);
    }

    public override void ExitExpression_base_sub(KermitLangParser.Expression_base_subContext context)
    {
        base.ExitExpression_base_sub(context);
    }
    public virtual void ExitExpression1Empty([NotNull] KermitLangParser.Expression1EmptyContext context) { }

    public override void ExitExpression_base_mul(KermitLangParser.Expression_base_mulContext context)
    {
        base.ExitExpression_base_mul(context);
    }

    public override void ExitExpression_base_div(KermitLangParser.Expression_base_divContext context)
    {
        base.ExitExpression_base_div(context);
    }
    public virtual void ExitExpression2Empty([NotNull] KermitLangParser.Expression2EmptyContext context) { }

    public override void ExitAnd(KermitLangParser.AndContext context)
    {
        base.ExitAnd(context);
    }

    public override void ExitOr(KermitLangParser.OrContext context)
    {
        base.ExitOr(context);
    }

    public override void ExitXor(KermitLangParser.XorContext context)
    {
        base.ExitXor(context);
    }

    public override void ExitNeg(KermitLangParser.NegContext context)
    {
        base.ExitNeg(context);
    }
    public virtual void ExitExpression4Empty([NotNull] KermitLangParser.Expression4EmptyContext context) { }

    public override void ExitInt(KermitLangParser.IntContext context)
    {
        _stack.Push(new Variable(context.INTEGER().GetText(), VariableType.INT));
    }

    public override void ExitFloat(KermitLangParser.FloatContext context)
    {
        _stack.Push(new Variable(context.REAL().GetText(), VariableType.REAL));
    }

    public override void ExitId(KermitLangParser.IdContext context)
    {
        var id = context.ID().GetText();
        if (!_variables.ContainsKey(id))
        {
            // error
        }
        _stack.Push(_variables[id]);
    }

    public override void ExitBool(KermitLangParser.BoolContext context)
    {
        _stack.Push(new Variable(context.BOOL().GetText(), VariableType.BOOL));
    }
    public virtual void ExitNumber([NotNull] KermitLangParser.NumberContext context) { }
    public virtual void ExitExpressionInParens([NotNull] KermitLangParser.ExpressionInParensContext context) { }
    public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
    public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
    public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
    public virtual void VisitErrorNode([NotNull] IErrorNode node) { }

    private void AddError(int line, string msg)
    {
        errors.Add($"Error in line {line}: {msg}");
    }

    private void ReportErrors()
    {
        if (errors.Any())
        {
            foreach (var error in errors)
            {
                Console.Error.WriteLine(error);
            }
            Environment.Exit(1);
        }
    }

    private string GetActualType(KermitLangParser.AssignContext context)
    {
        if (context.INTEGER() != null)
        {
            return "int";
        }
        else if (context.REAL() != null)
        {
            return "real";
        }
        else if (context.BOOL() != null)
        {
            return "bool";
        }
        else if (context.STRING() != null)
        {
            return "string";
        }
        else if (context.ID().Length > 1)
        {
            String secondId = context.ID(1).GetText();
            if (_variables.ContainsKey(secondId))
            {
                VariableType type = _variables[secondId].Type;
                return type.ToString().ToLower();
            }
        }
        else if (context.expression() != null)
        {
            return "expression";
        }
        return "unknown";
    }
}