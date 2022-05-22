using SWI.ENUM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SWI
{
    public class Calculation
    {
        [JsonPropertyName("operator")]
        public OperationTypes OperationType { get; set; }
        public int value1 { get; set; }
        public int value2 { get; set; }

    }
}
