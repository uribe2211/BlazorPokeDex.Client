﻿using Newtonsoft.Json;

namespace BlazorPokedex.Models
{
    public class Type
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }
        [JsonProperty("type")]
        public PokemonType PokemonType { get; set; }
    }

    public class PokemonType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}