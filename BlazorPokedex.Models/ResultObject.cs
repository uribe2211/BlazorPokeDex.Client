using System.Collections.Generic;
using Newtonsoft.Json;

namespace BlazorPokedex.Models
{
    public class ResultObject
    {
        [JsonProperty("results")]
        public IEnumerable<Pokemon> Pokemons { get; set; }
    }
}