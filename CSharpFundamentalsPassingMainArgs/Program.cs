using System;

namespace CSharpFundamentalsPassingMainArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. passing args by command line will be done by, dotnet run -- arg1 arg2 etc
            // 2. or by right click on project, at Debug section by providing Application Arguments.
            // 3. or at launchSettings.json file ( this file will be automatically generated after defining Application Arguments ).
            if (args.Length > 1)
            {
                Console.WriteLine($"Hello, {args[0]} {args[1]}");
            }
            else
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
