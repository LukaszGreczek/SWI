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

        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType())
            {
                Calculation testing = (Calculation)obj;
                if (testing.OperationType == this.OperationType && testing.value1 == this.value1 && testing.value2 == testing.value2)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }

        }
    }
}
