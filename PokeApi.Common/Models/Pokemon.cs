using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PokeApi.Common.Models
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
