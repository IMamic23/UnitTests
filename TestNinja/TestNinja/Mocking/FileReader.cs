using System.IO;
using TestNinja.Interfaces;

namespace TestNinja.Mocking
{
    public class FileReader : IFileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
