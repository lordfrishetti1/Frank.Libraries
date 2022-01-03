namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_bookmarks_folders_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_bookmarks_folders_200_ok(int? @creator_id, int @folder_id, string @name)

        {

            this.Creator_id = @creator_id;

            this.Folder_id = @folder_id;

            this.Name = @name;

        }    /// <summary>
        /// creator_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("creator_id")]
        public int? Creator_id { get; init; }

        /// <summary>
        /// folder_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public int Folder_id { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

    }