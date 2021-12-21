using System.Collections.Generic;
using System.Net.Http;
using System.Security.AccessControl;
using System.Threading.Tasks;
using BlazorPokedex.Models;
using Newtonsoft.Json;

namespace BlazorPokedex.Services
{
    public class PoketApiClient : IPokeApiClient
    {
        private readonly HttpClient _httpClient;
        public PoketApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Pokemon> GetPokemon(string name)
        {
            return JsonConvert.DeserializeObject<Pokemon>(await _httpClient.GetStringAsync($"pokemon/{name}"));
        }

        public async Task<IEnumerable<Pokemon>> GetAllPokemons()
        {
            var pokemonList = JsonConvert.DeserializeObject<ResultObject>(await _httpClient.GetStringAsync("pokemon?limit=100&offset=200"));

            var resulList = new List<Pokemon>();

            foreach (var item in pokemonList!.Pokemons)
            {
                resulList.Add(await GetPokemon(item.Name));
            }

            return resulList;
        }
    }
}