using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWI.IO
{
    public class ResultOutput
    {
        Uri path = new Uri(Path.GetFullPath("output.txt"));
        public void PrintResult(Dictionary<string, double> results)
        {
            using StreamWriter file = new(path.LocalPath, append: false);


            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, double> result in results.OrderBy(key => key.Value))
            {
                sb.AppendLine($"{result.Key}: {result.Value}");
            }


            string output = sb.ToString();

            file.Write(output);
            file.Close();

        }
    }
}
