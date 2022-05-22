using SWI.INTERFACE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWI.IO
{
    public class JsonFileReader : IReader
    {
        Uri path = new Uri(Path.GetFullPath("input.json"));

        public string GetData()
        {
            try
            {
                string json = File.ReadAllText(path.LocalPath);
                return json;

            }
            catch 
            {
                return null;
            }

        }
    }
}
