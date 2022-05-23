using SWI.Models;
using System.Collections.Generic;


namespace SWI.Logic
{
    public static class BatchCalculator
    {
        public static IDictionary<string, double> DoCalculate(IDictionary<string, Calculation> inputData)
        {
            var _outputData = new Dictionary<string, double>();

            foreach (var calc in inputData)
            {
                _outputData.Add(calc.Key, calc.Value.Calculate());
            }

            return _outputData;
        }
    }

}
