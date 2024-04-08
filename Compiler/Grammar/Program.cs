using System.Diagnostics;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using AntlrCSharp;

namespace Compiler.Grammar;

public class Program()
{
    public static void Main(string[] args)
    {
        var input = File.ReadAllText(args[0]);
        
        var inputStream = new AntlrInputStream(input);
        var lexer = new LangXLexer(inputStream);
        var commonTokenStream = new CommonTokenStream(lexer);
        var parser = new LangXParser(commonTokenStream);
        IParseTree parseTree = parser.start();
        
        var listener = new BasicLangXListener();
        ParseTreeWalker.Default.Walk(listener, parseTree);
        
        // create file from generated code
        // save the file as output.ll in Grammar directory
        var outputFile = @"C:\Users\jakub\Documents\CSharpCompiler\Compiler\Grammar\output.ll";
        File.WriteAllText(outputFile, listener.GenerateCode());
        Console.WriteLine("File generated successfully");
        
        // compile the file
        var process = new Process();
        process.StartInfo.FileName = @"C:\Program Files\LLVM\bin\clang++.exe";
        process.StartInfo.Arguments = $"-o {outputFile.Replace(".ll", ".exe")} {outputFile}";
        process.Start();
        process.WaitForExit();
    }   
}