using System.Collections.Generic;
using System.Text.Json;

namespace SWI.Logic
{
    public class JsonDeserialize
    {
        private string json;
        private Dictionary<string, Calculation> calculationDictionary = new Dictionary<string, Calculation>();
        public Dictionary<string, Calculation> ReturnDicrionary() { return calculationDictionary; }
        public JsonDeserialize(string json)
        {
            this.json = json;
            Deserialize();
        }

        private void Deserialize()
        {
            try { 
                CalculationDictionary cDictionary = JsonSerializer.Deserialize<CalculationDictionary>(json);
                foreach (KeyValuePair<string, JsonElement> c in cDictionary.Calculations)
                {
                    Calculation calc = TryDeserializeElement(c.Value);
                    if (calc != null)
                    {
                        calculationDictionary.Add(c.Key, calc);
                    }

                }
            }
            catch
            {
                System.Console.WriteLine("Json data wrong format");
            }
            



        }

        private Calculation TryDeserializeElement(JsonElement element)
        {

            if (element.Equals(null)) { return null; }


            if (element.ValueKind != JsonValueKind.Object)
            {
                return null;
            }

            if (element.TryGetProperty("operator", out var operatorType) && element.TryGetProperty("value1", out var value1)) // return false if operator or value1 dont exist
            {
                if (!operatorType.ToString().Equals("sqrt") && !element.TryGetProperty("value2", out var value2)) //return false if operator have one of value [add,sub,mull] but not have value2
                {
                    return null;
                }
            }
            else { return null; }

            try
            {
                Calculation calculation = JsonSerializer.Deserialize<Calculation>(element);
                if (calculation.OperationType == ENUM.OperationTypes.sqrt && calculation.value1 < 0)
                {
                    return null;
                }

                return calculation;
            }
            catch
            {
                return null;
            }



        }


    }
}
