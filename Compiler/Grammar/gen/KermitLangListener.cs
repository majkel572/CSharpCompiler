//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from f:/GitHubRepository/CSharpCompiler/Compiler/Grammar/KermitLang.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="KermitLangParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IKermitLangListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="KermitLangParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStart([NotNull] KermitLangParser.StartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KermitLangParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStart([NotNull] KermitLangParser.StartContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KermitLangParser.base_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBase_statement([NotNull] KermitLangParser.Base_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KermitLangParser.base_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBase_statement([NotNull] KermitLangParser.Base_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>declare</c>
	/// labeled alternative in <see cref="KermitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclare([NotNull] KermitLangParser.DeclareContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>declare</c>
	/// labeled alternative in <see cref="KermitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclare([NotNull] KermitLangParser.DeclareContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>assign</c>
	/// labeled alternative in <see cref="KermitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssign([NotNull] KermitLangParser.AssignContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>assign</c>
	/// labeled alternative in <see cref="KermitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssign([NotNull] KermitLangParser.AssignContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>print</c>
	/// labeled alternative in <see cref="KermitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrint([NotNull] KermitLangParser.PrintContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>print</c>
	/// labeled alternative in <see cref="KermitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrint([NotNull] KermitLangParser.PrintContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>read</c>
	/// labeled alternative in <see cref="KermitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRead([NotNull] KermitLangParser.ReadContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>read</c>
	/// labeled alternative in <see cref="KermitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRead([NotNull] KermitLangParser.ReadContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>if</c>
	/// labeled alternative in <see cref="KermitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIf([NotNull] KermitLangParser.IfContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>if</c>
	/// labeled alternative in <see cref="KermitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIf([NotNull] KermitLangParser.IfContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>while</c>
	/// labeled alternative in <see cref="KermitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhile([NotNull] KermitLangParser.WhileContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>while</c>
	/// labeled alternative in <see cref="KermitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhile([NotNull] KermitLangParser.WhileContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>function</c>
	/// labeled alternative in <see cref="KermitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction([NotNull] KermitLangParser.FunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>function</c>
	/// labeled alternative in <see cref="KermitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction([NotNull] KermitLangParser.FunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>struct</c>
	/// labeled alternative in <see cref="KermitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStruct([NotNull] KermitLangParser.StructContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>struct</c>
	/// labeled alternative in <see cref="KermitLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStruct([NotNull] KermitLangParser.StructContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KermitLangParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType([NotNull] KermitLangParser.TypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KermitLangParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType([NotNull] KermitLangParser.TypeContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expressionBaseAdd</c>
	/// labeled alternative in <see cref="KermitLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionBaseAdd([NotNull] KermitLangParser.ExpressionBaseAddContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionBaseAdd</c>
	/// labeled alternative in <see cref="KermitLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionBaseAdd([NotNull] KermitLangParser.ExpressionBaseAddContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expressionBaseSub</c>
	/// labeled alternative in <see cref="KermitLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionBaseSub([NotNull] KermitLangParser.ExpressionBaseSubContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionBaseSub</c>
	/// labeled alternative in <see cref="KermitLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionBaseSub([NotNull] KermitLangParser.ExpressionBaseSubContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expression1Empty</c>
	/// labeled alternative in <see cref="KermitLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression1Empty([NotNull] KermitLangParser.Expression1EmptyContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expression1Empty</c>
	/// labeled alternative in <see cref="KermitLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression1Empty([NotNull] KermitLangParser.Expression1EmptyContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expressionBaseMul</c>
	/// labeled alternative in <see cref="KermitLangParser.expression1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionBaseMul([NotNull] KermitLangParser.ExpressionBaseMulContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionBaseMul</c>
	/// labeled alternative in <see cref="KermitLangParser.expression1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionBaseMul([NotNull] KermitLangParser.ExpressionBaseMulContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expressionBaseDiv</c>
	/// labeled alternative in <see cref="KermitLangParser.expression1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionBaseDiv([NotNull] KermitLangParser.ExpressionBaseDivContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionBaseDiv</c>
	/// labeled alternative in <see cref="KermitLangParser.expression1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionBaseDiv([NotNull] KermitLangParser.ExpressionBaseDivContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expression2Empty</c>
	/// labeled alternative in <see cref="KermitLangParser.expression1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression2Empty([NotNull] KermitLangParser.Expression2EmptyContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expression2Empty</c>
	/// labeled alternative in <see cref="KermitLangParser.expression1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression2Empty([NotNull] KermitLangParser.Expression2EmptyContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>and</c>
	/// labeled alternative in <see cref="KermitLangParser.expression2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnd([NotNull] KermitLangParser.AndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>and</c>
	/// labeled alternative in <see cref="KermitLangParser.expression2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnd([NotNull] KermitLangParser.AndContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>or</c>
	/// labeled alternative in <see cref="KermitLangParser.expression2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOr([NotNull] KermitLangParser.OrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>or</c>
	/// labeled alternative in <see cref="KermitLangParser.expression2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOr([NotNull] KermitLangParser.OrContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>xor</c>
	/// labeled alternative in <see cref="KermitLangParser.expression2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXor([NotNull] KermitLangParser.XorContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>xor</c>
	/// labeled alternative in <see cref="KermitLangParser.expression2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXor([NotNull] KermitLangParser.XorContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>neg</c>
	/// labeled alternative in <see cref="KermitLangParser.expression2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNeg([NotNull] KermitLangParser.NegContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>neg</c>
	/// labeled alternative in <see cref="KermitLangParser.expression2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNeg([NotNull] KermitLangParser.NegContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expression3Empty</c>
	/// labeled alternative in <see cref="KermitLangParser.expression2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression3Empty([NotNull] KermitLangParser.Expression3EmptyContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expression3Empty</c>
	/// labeled alternative in <see cref="KermitLangParser.expression2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression3Empty([NotNull] KermitLangParser.Expression3EmptyContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>id</c>
	/// labeled alternative in <see cref="KermitLangParser.expression3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterId([NotNull] KermitLangParser.IdContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>id</c>
	/// labeled alternative in <see cref="KermitLangParser.expression3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitId([NotNull] KermitLangParser.IdContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>bool</c>
	/// labeled alternative in <see cref="KermitLangParser.expression3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBool([NotNull] KermitLangParser.BoolContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>bool</c>
	/// labeled alternative in <see cref="KermitLangParser.expression3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBool([NotNull] KermitLangParser.BoolContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>number</c>
	/// labeled alternative in <see cref="KermitLangParser.expression3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumber([NotNull] KermitLangParser.NumberContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>number</c>
	/// labeled alternative in <see cref="KermitLangParser.expression3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumber([NotNull] KermitLangParser.NumberContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="KermitLangParser.expression3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString([NotNull] KermitLangParser.StringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="KermitLangParser.expression3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString([NotNull] KermitLangParser.StringContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expressionInParens</c>
	/// labeled alternative in <see cref="KermitLangParser.expression3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionInParens([NotNull] KermitLangParser.ExpressionInParensContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionInParens</c>
	/// labeled alternative in <see cref="KermitLangParser.expression3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionInParens([NotNull] KermitLangParser.ExpressionInParensContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>functionCall</c>
	/// labeled alternative in <see cref="KermitLangParser.expression3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] KermitLangParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionCall</c>
	/// labeled alternative in <see cref="KermitLangParser.expression3"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] KermitLangParser.FunctionCallContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ifStatement</c>
	/// labeled alternative in <see cref="KermitLangParser.if_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] KermitLangParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ifStatement</c>
	/// labeled alternative in <see cref="KermitLangParser.if_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] KermitLangParser.IfStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>equal</c>
	/// labeled alternative in <see cref="KermitLangParser.compareStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqual([NotNull] KermitLangParser.EqualContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>equal</c>
	/// labeled alternative in <see cref="KermitLangParser.compareStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqual([NotNull] KermitLangParser.EqualContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>notEqual</c>
	/// labeled alternative in <see cref="KermitLangParser.compareStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotEqual([NotNull] KermitLangParser.NotEqualContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>notEqual</c>
	/// labeled alternative in <see cref="KermitLangParser.compareStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotEqual([NotNull] KermitLangParser.NotEqualContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>lessThan</c>
	/// labeled alternative in <see cref="KermitLangParser.compareStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLessThan([NotNull] KermitLangParser.LessThanContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>lessThan</c>
	/// labeled alternative in <see cref="KermitLangParser.compareStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLessThan([NotNull] KermitLangParser.LessThanContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>greaterThan</c>
	/// labeled alternative in <see cref="KermitLangParser.compareStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGreaterThan([NotNull] KermitLangParser.GreaterThanContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>greaterThan</c>
	/// labeled alternative in <see cref="KermitLangParser.compareStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGreaterThan([NotNull] KermitLangParser.GreaterThanContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>lessThanEqual</c>
	/// labeled alternative in <see cref="KermitLangParser.compareStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLessThanEqual([NotNull] KermitLangParser.LessThanEqualContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>lessThanEqual</c>
	/// labeled alternative in <see cref="KermitLangParser.compareStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLessThanEqual([NotNull] KermitLangParser.LessThanEqualContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>greaterThanEqual</c>
	/// labeled alternative in <see cref="KermitLangParser.compareStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGreaterThanEqual([NotNull] KermitLangParser.GreaterThanEqualContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>greaterThanEqual</c>
	/// labeled alternative in <see cref="KermitLangParser.compareStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGreaterThanEqual([NotNull] KermitLangParser.GreaterThanEqualContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>whileStatement</c>
	/// labeled alternative in <see cref="KermitLangParser.while_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileStatement([NotNull] KermitLangParser.WhileStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>whileStatement</c>
	/// labeled alternative in <see cref="KermitLangParser.while_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileStatement([NotNull] KermitLangParser.WhileStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>whileCondition</c>
	/// labeled alternative in <see cref="KermitLangParser.while_condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileCondition([NotNull] KermitLangParser.WhileConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>whileCondition</c>
	/// labeled alternative in <see cref="KermitLangParser.while_condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileCondition([NotNull] KermitLangParser.WhileConditionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>functionDef</c>
	/// labeled alternative in <see cref="KermitLangParser.function_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionDef([NotNull] KermitLangParser.FunctionDefContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionDef</c>
	/// labeled alternative in <see cref="KermitLangParser.function_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionDef([NotNull] KermitLangParser.FunctionDefContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>noParameters</c>
	/// labeled alternative in <see cref="KermitLangParser.parameter_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNoParameters([NotNull] KermitLangParser.NoParametersContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>noParameters</c>
	/// labeled alternative in <see cref="KermitLangParser.parameter_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNoParameters([NotNull] KermitLangParser.NoParametersContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>parameterList</c>
	/// labeled alternative in <see cref="KermitLangParser.parameter_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterList([NotNull] KermitLangParser.ParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parameterList</c>
	/// labeled alternative in <see cref="KermitLangParser.parameter_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterList([NotNull] KermitLangParser.ParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>parameterDeclare</c>
	/// labeled alternative in <see cref="KermitLangParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterDeclare([NotNull] KermitLangParser.ParameterDeclareContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parameterDeclare</c>
	/// labeled alternative in <see cref="KermitLangParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterDeclare([NotNull] KermitLangParser.ParameterDeclareContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>functionInvoke</c>
	/// labeled alternative in <see cref="KermitLangParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionInvoke([NotNull] KermitLangParser.FunctionInvokeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionInvoke</c>
	/// labeled alternative in <see cref="KermitLangParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionInvoke([NotNull] KermitLangParser.FunctionInvokeContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>argumentList</c>
	/// labeled alternative in <see cref="KermitLangParser.argument_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgumentList([NotNull] KermitLangParser.ArgumentListContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>argumentList</c>
	/// labeled alternative in <see cref="KermitLangParser.argument_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgumentList([NotNull] KermitLangParser.ArgumentListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="KermitLangParser.statement_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement_block([NotNull] KermitLangParser.Statement_blockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="KermitLangParser.statement_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement_block([NotNull] KermitLangParser.Statement_blockContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ifStatementBlock</c>
	/// labeled alternative in <see cref="KermitLangParser.statement_block_if"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatementBlock([NotNull] KermitLangParser.IfStatementBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ifStatementBlock</c>
	/// labeled alternative in <see cref="KermitLangParser.statement_block_if"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatementBlock([NotNull] KermitLangParser.IfStatementBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>whileStatementBlock</c>
	/// labeled alternative in <see cref="KermitLangParser.statement_block_while"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileStatementBlock([NotNull] KermitLangParser.WhileStatementBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>whileStatementBlock</c>
	/// labeled alternative in <see cref="KermitLangParser.statement_block_while"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileStatementBlock([NotNull] KermitLangParser.WhileStatementBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>structDef</c>
	/// labeled alternative in <see cref="KermitLangParser.struct_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStructDef([NotNull] KermitLangParser.StructDefContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>structDef</c>
	/// labeled alternative in <see cref="KermitLangParser.struct_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStructDef([NotNull] KermitLangParser.StructDefContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>structMembers</c>
	/// labeled alternative in <see cref="KermitLangParser.struct_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStructMembers([NotNull] KermitLangParser.StructMembersContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>structMembers</c>
	/// labeled alternative in <see cref="KermitLangParser.struct_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStructMembers([NotNull] KermitLangParser.StructMembersContext context);
}
