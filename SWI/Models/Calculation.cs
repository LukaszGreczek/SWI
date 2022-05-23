using SWI.Enums;
using System;
using System.Text.Json.Serialization;

namespace SWI.Models
{
    public class Calculation
    {


        [JsonPropertyName("operator")]
        public OperationType Operation { get; set; }
        public int value1 { get; set; }
        public int value2 { get; set; }


        public double Calculate()
        {
            switch (this.Operation)
            {
                case OperationType.Add:
                    return this.value1 + this.value2;
                case OperationType.Sub:
                    return this.value1 - this.value2;
                case OperationType.Mul:
                    return this.value1 * this.value2;
                case OperationType.Sqrt:
                    return Math.Sqrt(value1);
                default:
                    return double.NaN;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType())
            {
                Calculation testing = (Calculation)obj;
                if (testing.Operation == this.Operation && 
                    testing.value1 == this.value1 && 
                    testing.value2 == testing.value2)
                {
                    return true;
                }else if(testing.Operation == this.Operation &&
                    testing.value1 == this.value1 &&
                    testing.Operation == OperationType.Sqrt)
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
