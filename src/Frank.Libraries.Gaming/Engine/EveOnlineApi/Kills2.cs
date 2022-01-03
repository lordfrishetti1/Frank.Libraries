namespace EveOnlineApi;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Kills2
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Kills2(int @last_week, int @total, int @yesterday)

        {

            this.Last_week = @last_week;

            this.Total = @total;

            this.Yesterday = @yesterday;

        }    /// <summary>
        /// Last week's total number of kills by members of the given corporation against enemy factions
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("last_week")]
        public int Last_week { get; init; }

        /// <summary>
        /// Total number of kills by members of the given corporation against enemy factions since the corporation enlisted
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int Total { get; init; }

        /// <summary>
        /// Yesterday's total number of kills by members of the given corporation against enemy factions
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("yesterday")]
        public int Yesterday { get; init; }

    }