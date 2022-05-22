using SWI.INTERFACE;
using SWI.IO;
using SWI.Logic;
using System;
using System.Collections.Generic;

namespace SWI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IReader iReader = new JsonFileReader();
            ResultOutput output = new ResultOutput();
            
            if(iReader.GetData() != null)
            {
                JsonDeserialize jsonDeserialize = new JsonDeserialize(iReader.GetData());
                Dictionary<string,Calculation> ab = jsonDeserialize.ReturnDicrionary();
                Calculete calc = new Calculete(ab);
                output.PrintResult(calc.DoCalculate());
            }
            else
            {
                Console.WriteLine("File not found.");
            }

        }
    }
}
