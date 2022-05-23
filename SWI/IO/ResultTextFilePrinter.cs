using SWI.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace SWI.IO
{
    public class ResultTextFilePrinter : IResultPrtinter
    {
        private readonly Uri _outputFilePath;

        public ResultTextFilePrinter(string outputFilePath)
        {
            _outputFilePath = new Uri(Path.GetFullPath(outputFilePath));
        }

        public void PrintResult(IDictionary<string, double> results)
        {
            using StreamWriter file = new(_outputFilePath.LocalPath, append: false);


            var sb = new StringBuilder();
            foreach (var result in results.OrderBy(key => key.Value))
            {
                sb.AppendLine($"{result.Key}: {result.Value}");
            }


            string output = sb.ToString();

            file.Write(output);
            file.Close();

        }
    }
}
