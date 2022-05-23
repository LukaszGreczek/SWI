using SWI.Interfaces;
using SWI.IO;
using SWI.Logic;
using System;

namespace SWI
{
    internal class Program
    {
        const string inputFilePath = "input.json";
        const string outputFilePath = "output.txt";
        static void Main(string[] args)
        {

            string inputString;
            try
            {
                IInputDataReader iReader = new TextFileInputDataReader(inputFilePath);
                inputString = iReader.ReadData();
            }
            catch (UriFormatException)
            {
                Console.WriteLine("Invalid input path");
                return;
            }

            ResultTextFilePrinter output = new ResultTextFilePrinter(outputFilePath);
            
            if(inputString != null)
            {
                var calculations = CalculationsDeserializer.Deserialize(inputString);
                output.PrintResult(BatchCalculator.DoCalculate(calculations));
            }
            else
            {
                Console.WriteLine("Input file not found.");
            }

            
            Console.WriteLine("Press any key to close this window. . .");
            Console.Read();

        }
    }
}
