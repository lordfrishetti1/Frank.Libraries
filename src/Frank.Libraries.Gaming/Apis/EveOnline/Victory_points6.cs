using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Apis.EveOnline;

[GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
public record Victory_points6
{
    [JsonConstructor]
    public Victory_points6(int last_week, int total, int yesterday)

    {
        Last_week = last_week;

        Total = total;

        Yesterday = yesterday;
    }

    /// <summary>
    ///     Last week's victory points gained
    /// </summary>

    [JsonPropertyName("last_week")]
    public int Last_week { get; init; }

    /// <summary>
    ///     Total victory points gained since faction warfare began
    /// </summary>

    [JsonPropertyName("total")]
    public int Total { get; init; }

    /// <summary>
    ///     Yesterday's victory points gained
    /// </summary>

    [JsonPropertyName("yesterday")]
    public int Yesterday { get; init; }
}