namespace Compiler.Grammar.src.Variables;

public class DoubleGenerator
{
    public static string AllocateDouble(string id)
    {
        return id + " = alloca double\n";
    }
    
    public static string AssignDouble(string id, string value)
    {
        return "store double " + value + ", double* " + id + "\n";
    }
    
    public static string LoadDouble(string id)
    {
        return "%" + Generator.Reg++ + " = load double, double* " + id + "\n";
    }
    
    public static string PrintDouble(string id)
    {
        var res = "%" + Generator.Reg++ + " = call i32 (i8*, ...) @printf(i8* getelementptr inbounds ([5 x i8], [5 x i8]* @strplf, i64 0, i64 0), double " + id + ")\n";
        return res;
    }
    
    public static string ReadDouble(string id)
    {
        return "%" + Generator.Reg++ + " = call i32 (i8*, ...) @__isoc99_scanf(i8* getelementptr inbounds ([4 x i8], [4 x i8]* @strslf, i64 0, i64 0), double* " + id + ")\n";
    }
    
    public static string AddDouble(string id1, string id2)
    {
        return "%" + Generator.Reg++ + " = fadd double " + id1 + ", " + id2 + "\n";
    }
    
    public static string SubDouble(string id1, string id2)
    {
        return "%" + Generator.Reg++ + " = fsub double " + id1 + ", " + id2 + "\n";
    }
    
    public static string MulDouble(string id1, string id2)
    {
        return "%" + Generator.Reg++ + " = fmul double " + id1 + ", " + id2 + "\n";
    }
    
    public static string DivDouble(string id1, string id2)
    {
        return "%" + Generator.Reg++ + " = fdiv double " + id1 + ", " + id2 + "\n";
    }
    
    public static string EqualDouble(string id1, string id2)
    {
        return "%" + Generator.Reg++ + " = fcmp oeq double " + id1 + ", " + id2 + "\n";
    }
    
    public static string NeDouble(string id1, string id2)
    {
        return "%" + Generator.Reg++ + " = fcmp one double " + id1 + ", " + id2 + "\n";
    }
    
    public static string GtDouble(string id1, string id2)
    {
        return "%" + Generator.Reg++ + " = fcmp ogt double " + id1 + ", " + id2 + "\n";
    }
    
    public static string GeDouble(string id1, string id2)
    {
        return "%" + Generator.Reg++ + " = fcmp oge double " + id1 + ", " + id2 + "\n";
    }
    
    public static string LtDouble(string id1, string id2)
    {
        return "%" + Generator.Reg++ + " = fcmp olt double " + id1 + ", " + id2 + "\n";
    }
    
    public static string LeDouble(string id1, string id2)
    {
        return "%" + Generator.Reg++ + " = fcmp ole double " + id1 + ", " + id2 + "\n";
    }
}