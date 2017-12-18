using System.Collections.Generic;

namespace Tiqri.Training.TDD.NumberManager
{
    public interface IFileManager
    {
        List<string> ReadCsvFile(string filePath);
    }
}