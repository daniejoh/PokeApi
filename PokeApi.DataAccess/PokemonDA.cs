using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PokeApi.Common.Models;

namespace PokeApi.DataAccess
{
    public class PokemonDA
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = @"https://pokeapi.co/api/v2/pokemon/";


        public PokemonDA()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Gets a pokemon by name
        /// </summary>
        /// <param name="name">name of pokemon</param>
        /// <returns>Pokemon with the name given</returns>
        public async Task<Pokemon> GetPokemon(String name)
        {
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(_baseUrl + name),
                Method = HttpMethod.Get
            };
            string json;
            try
            {
                HttpResponseMessage response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                Console.WriteLine(response.Content);
                json = await response.Content.ReadAsStringAsync();

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message: {0}", e.Message);
                return null;
            }
            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(json);
            return pokemon;
        }


    }
}
