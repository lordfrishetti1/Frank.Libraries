namespace EveOnlineApi;

    /// <summary>
    /// link object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Links
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Links(long @destination_pin_id, int @link_level, long @source_pin_id)

        {

            this.Destination_pin_id = @destination_pin_id;

            this.Link_level = @link_level;

            this.Source_pin_id = @source_pin_id;

        }    /// <summary>
        /// destination_pin_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("destination_pin_id")]
        public long Destination_pin_id { get; init; }

        /// <summary>
        /// link_level integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("link_level")]
        public int Link_level { get; init; }

        /// <summary>
        /// source_pin_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("source_pin_id")]
        public long Source_pin_id { get; init; }

    }