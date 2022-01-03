using System.Collections.Generic;

namespace EveOnlineApi;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Kills5
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Kills5(IList<Active_total5> @active_total, IList<Last_week5> @last_week, IList<Yesterday5> @yesterday)

        {

            this.Active_total = @active_total;

            this.Last_week = @last_week;

            this.Yesterday = @yesterday;

        }    /// <summary>
        /// Top 10 ranking of corporations active in faction warfare by total kills. A corporation is considered "active" if they have participated in faction warfare in the past 14 days
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("active_total")]
        public IList<Active_total5> Active_total { get; init; }

        /// <summary>
        /// Top 10 ranking of corporations by kills in the past week
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("last_week")]
        public IList<Last_week5> Last_week { get; init; }

        /// <summary>
        /// Top 10 ranking of corporations by kills in the past day
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("yesterday")]
        public IList<Yesterday5> Yesterday { get; init; }

    }