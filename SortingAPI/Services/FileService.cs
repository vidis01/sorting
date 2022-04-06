using System.IO;
using System.Threading.Tasks;

namespace SortingAPI.Services
{
    public class FileService : IFileService
    {
        private readonly string _fileName;

        public FileService(string fileName)
        {
            _fileName = fileName;
        }

        public async Task<string> ReadFromFile()
        {
            return await File.ReadAllTextAsync(_fileName);
        }

        public async Task SeveToFile(string numbers)
        {
            await File.WriteAllTextAsync(_fileName, numbers);
        }
    }
}
