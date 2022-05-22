using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SWI
{
    public class CalculationDictionary
    {
        [JsonExtensionData]
        public Dictionary<string, JsonElement> Calculations { get; set; }
    }
}