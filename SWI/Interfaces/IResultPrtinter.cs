using System.Collections.Generic;

namespace SWI.Interfaces
{
    public interface IResultPrtinter
    {
        void PrintResult(IDictionary<string, double> results);
    }
}
