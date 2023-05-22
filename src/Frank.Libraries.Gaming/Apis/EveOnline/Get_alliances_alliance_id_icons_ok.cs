using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

/// <summary>
///     200 ok object
/// </summary>
[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Get_alliances_alliance_id_icons_ok
{
    [JsonConstructor]
    public Get_alliances_alliance_id_icons_ok(string? px128x128, string? px64x64)

    {
        Px128x128 = px128x128;

        Px64x64 = px64x64;
    }

    /// <summary>
    ///     px128x128 string
    /// </summary>

    [JsonPropertyName("px128x128")]
    public string? Px128x128 { get; init; }

    /// <summary>
    ///     px64x64 string
    /// </summary>

    [JsonPropertyName("px64x64")]
    public string? Px64x64 { get; init; }
}