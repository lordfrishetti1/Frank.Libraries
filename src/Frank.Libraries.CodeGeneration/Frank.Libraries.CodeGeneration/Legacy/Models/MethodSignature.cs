using Frank.Libraries.CodeGeneration.Extensions;

namespace Frank.Libraries.CodeGeneration.Legacy.Models;

public record MethodSignature
{
    public readonly List<Argument>? Arguments;
    public readonly bool IsAsync;
    public readonly bool IsNullable;
    public readonly bool IsStatic;
    public readonly string Name;
    public readonly Type? ReturnType;

    public MethodSignature(string name, Type? returnType = null, List<Argument>? arguments = null, bool isAsync = false, bool isNullable = false, bool isStatic = false)
    {
        ReturnType = returnType;
        Name = name;
        IsAsync = isAsync;
        IsNullable = isNullable;
        Arguments = arguments;
    }

    /// <inheritdoc />
    public override string ToString() => new StringBuilder()
                                         .Append($"public{(IsStatic
                                             ? " static"
                                             : " ")}{(IsAsync
                                             ? "async "
                                             : "")}")
                                         .AppendIf(ReturnType?.Name ?? string.Empty, ReturnType != null, "void")
                                         .AppendIf("? ", IsNullable, " ")
                                         .Append(Name)
                                         .AppendSurroundedBy('(', string.Join(", ", Arguments.FallbackIfNull(new List<Argument>())
                                                                                             .Select(x => x.ToString())), ')')
                                         .ToString();
}