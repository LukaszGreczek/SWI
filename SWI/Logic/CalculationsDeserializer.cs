using SWI.Enums;
using SWI.Models;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace SWI.Logic
{
    public static class CalculationsDeserializer
    {
        


        public static Dictionary<string,Calculation>  Deserialize(string json)
        {
            var calculationDictionary = new Dictionary<string, Calculation>();
            
            try { 
                var cDictionary = JsonSerializer.Deserialize<CalculationDictionary>(json);
                foreach (var c in cDictionary.Calculations)
                {
                    var calc = TryDeserializeElement(c.Value);
                    if (calc != null)
                    {
                        calculationDictionary.Add(c.Key, calc);
                    }
                    else
                    {
                        Console.WriteLine($"{c.Key} invalid data.");
                    }

                }
            }
            catch
            {
                System.Console.WriteLine("Json data wrong format.");
            }

            return calculationDictionary;


        }

        private static Calculation TryDeserializeElement(JsonElement element)
        {
            if (element.Equals(null)) { return null; }

            if (element.ValueKind != JsonValueKind.Object)
            {
                return null;
            }

            if (element.TryGetProperty("operator", out var operatorType) && 
                element.TryGetProperty("value1", out var value1)) // return false if operator or value1 dont exist
            {
                if (!operatorType.ToString().Equals("sqrt",StringComparison.OrdinalIgnoreCase) && 
                    !element.TryGetProperty("value2", out var value2)) //return false if operator have one of value [add,sub,mull] but not have value2
                {
                    return null;
                }
            }
            else { return null; }

            try
            {
                Calculation calculation = JsonSerializer.Deserialize<Calculation>(element);
                if (calculation.Operation == OperationType.Sqrt && calculation.value1 < 0)
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
