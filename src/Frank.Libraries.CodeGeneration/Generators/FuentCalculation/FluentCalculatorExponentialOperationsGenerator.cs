using System;
using System.Collections.Generic;
using CodegenCS;

namespace Frank.Libraries.CodeGeneration.Generators.FuentCalculation
{
    public static class FluentCalculatorExponentialOperationsGenerator
    {
        public static string Generate(string namespaceName = "Frank.Libraries.Calculators.FluentCalculation", string className = "FluentCalculatorExponentialOperations")
        {
            var writer = new CodegenTextWriter();

            writer.WriteLine("using Frank.Libraries.Calculators;");
            writer.WriteLine("using System;");
            writer.WriteLine(" ");
            writer.WithCurlyBraces($"namespace {namespaceName}", () =>
            {
                writer.WithCurlyBraces($"public static class {className}", () =>
                {
                    foreach (var type in Types)
                    {
                        writer.WriteLine($"// {type}");
                        writer.WriteLine($"public static {type} Pow(this {type} source, int value) => PowerOf(source, value);");
                        writer.WriteLine($"public static {type} Sqrt(this {type} source) => SqrtOf(source);");

                        writer.WriteLine(" ");
                        writer.WithCurlyBraces($"private static {type} PowerOf({type} source, int value)", () =>
                        {
                            writer.WriteLine($"var result = new {type}();");
                            writer.WriteLine($"for (var i = 1; i < value; i++) result *= source;");
                            writer.WriteLine($"return result;");
                        });
                        writer.WithCurlyBraces($"private static {type} SqrtOf({type} source)", () =>
                        {
                            writer.WriteLine($"if (source is 0 or ({type})DecimalConstants.SmallestNonZeroDec) return 0;");

                            writer.WriteLine($"var halfS = source / ({type})2;");

                            writer.WriteLine(!type.StartsWith("u")
                                                 ? (FormattableString)$"var lastX = ({type})-1;"
                                                 : (FormattableString)$"var lastX = {type}.MinValue;");
                            writer.WriteLine($"{type} nextX;");
                            writer.WriteLine($"var x = ({type})Math.Sqrt(Convert.ToDouble(source));");

                            writer.WithCurlyBraces($"while (true)", () =>
                            {
                                writer.WriteLine(type is "ushort" or "short"
                                                     ? (FormattableString)$"nextX = ({type})(x / 2 + halfS / x);"
                                                     : (FormattableString)$"nextX = x / 2 + halfS / x;");
                                writer.WriteLine($"if (nextX == x || nextX == lastX) break;");
                                writer.WriteLine($"lastX = x;");
                                writer.WriteLine($"x = nextX;");
                            });
                            writer.WriteLine($"return nextX;");
                        });
                        writer.WriteLine(" ");
                    }
                });
            });

            return writer.GetContents();
        }

        private static List<string> Types => new()
        {
            "int",
            "uint",
            "short",
            "ushort",
            "long",
            "ulong",
            "float",
            "double",
            "decimal"
        };
    }
}