
using System;
using Newtonsoft.Json;

namespace TechnicalAxos_MarcosCasor.Models
{
	public class Country
	{
        [JsonProperty("name")]
        public Name Name { get; set; }

    }

    public class Name
    {
        [JsonProperty("common")]
        public string Common { get; set; }
    }

}

