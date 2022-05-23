using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace SWI.Models
{
    public class CalculationDictionary
    {
        [JsonExtensionData]
        public Dictionary<string, JsonElement> Calculations { get; set; }
    }
}