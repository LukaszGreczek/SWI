using SWI.ENUM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWI.Logic
{
    public class Calculete
    {
        public Dictionary<string, Calculation> Data = new Dictionary<string, Calculation>();
        public Dictionary<string, double> OutputData = new Dictionary<string, double>();

        public Calculete(Dictionary<string, Calculation> data)
        {
            Data = data;
        }

        public Dictionary<string, double> DoCalculate()
        {
            foreach (KeyValuePair<string, Calculation> calc in Data)
            {
                switch (calc.Value.OperationType)
                {
                    case OperationTypes.add:
                        OutputData.Add(calc.Key, (calc.Value.value1 + calc.Value.value2));
                        break;
                    case OperationTypes.sub:
                        OutputData.Add(calc.Key, (calc.Value.value1 + calc.Value.value2));
                        break;
                    case OperationTypes.mul:
                        OutputData.Add(calc.Key, (calc.Value.value1 * calc.Value.value2));
                        break;
                    case OperationTypes.sqrt:
                        OutputData.Add(calc.Key, Math.Sqrt(calc.Value.value1));
                        break;

                }

            }


            return OutputData;
        }
    }

}
