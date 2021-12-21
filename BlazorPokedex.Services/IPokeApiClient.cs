using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPokedex.Models;

namespace BlazorPokedex.Services
{
    public interface IPokeApiClient
    {

        Task<IEnumerable<Pokemon>> GetAllPokemons();
        Task<Pokemon> GetPokemon(string name);

    }
}