using System.Threading.Tasks;
using NUnit.Framework;
using PokeApi.Common.Models;

namespace PokeApi.DataAccess.Tests
{
    public class Tests
    {
        private readonly PokemonDA pokemonDA;

        public Tests()
        {
            pokemonDA = new PokemonDA();
        }

        //[SetUp]
        //public void Setup()
        //{

        //}

        [Test]
        public async Task GetPokemonTest()
        {
            Pokemon p = await pokemonDA.GetPokemon("ditto");
            Assert.AreEqual(p.Name, "ditto");
        }
    }
}