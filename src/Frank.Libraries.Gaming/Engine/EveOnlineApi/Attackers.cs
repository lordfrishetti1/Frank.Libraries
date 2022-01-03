namespace EveOnlineApi;

    /// <summary>
    /// attacker object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Attackers
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Attackers(int? @alliance_id, int? @character_id, int? @corporation_id, int @damage_done, int? @faction_id, bool @final_blow, float @security_status, int? @ship_type_id, int? @weapon_type_id)

        {

            this.Alliance_id = @alliance_id;

            this.Character_id = @character_id;

            this.Corporation_id = @corporation_id;

            this.Damage_done = @damage_done;

            this.Faction_id = @faction_id;

            this.Final_blow = @final_blow;

            this.Security_status = @security_status;

            this.Ship_type_id = @ship_type_id;

            this.Weapon_type_id = @weapon_type_id;

        }    /// <summary>
        /// alliance_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("alliance_id")]
        public int? Alliance_id { get; init; }

        /// <summary>
        /// character_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("character_id")]
        public int? Character_id { get; init; }

        /// <summary>
        /// corporation_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporation_id")]
        public int? Corporation_id { get; init; }

        /// <summary>
        /// damage_done integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("damage_done")]
        public int Damage_done { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("faction_id")]
        public int? Faction_id { get; init; }

        /// <summary>
        /// Was the attacker the one to achieve the final blow
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("final_blow")]
        public bool Final_blow { get; init; }

        /// <summary>
        /// Security status for the attacker
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("security_status")]
        public float Security_status { get; init; }

        /// <summary>
        /// What ship was the attacker flying
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ship_type_id")]
        public int? Ship_type_id { get; init; }

        /// <summary>
        /// What weapon was used by the attacker for the kill
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("weapon_type_id")]
        public int? Weapon_type_id { get; init; }

    }