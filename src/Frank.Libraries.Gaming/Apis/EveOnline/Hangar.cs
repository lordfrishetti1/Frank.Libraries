using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     hangar object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Hangar
{
    [JsonConstructor]
    public Hangar(int? division, string? name)

    {
        Division = division;

        Name = name;
    }

    /// <summary>
    ///     division integer
    /// </summary>

    [JsonPropertyName("division")]
    public int? Division { get; init; }

    /// <summary>
    ///     name string
    /// </summary>

    [JsonPropertyName("name")]
    public string? Name { get; init; }
}