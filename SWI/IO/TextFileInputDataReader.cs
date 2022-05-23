using SWI.Interfaces;
using System;
using System.IO;

namespace SWI.IO
{
    public class TextFileInputDataReader : IInputDataReader
    {
        private readonly Uri _inputFilePath;

        public TextFileInputDataReader(string inputFilePath)
        {
            _inputFilePath = new Uri(Path.GetFullPath(inputFilePath));

        }

        public string ReadData()
        {
            try
            {
                return File.ReadAllText(_inputFilePath.LocalPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return null;
            }
        }
    }
}
