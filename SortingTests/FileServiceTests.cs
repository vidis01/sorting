using SortingAPI.Services;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace SortingTests
{
    public class FileServiceTests
    {
        private readonly IFileService _fileService;
        private readonly string _fileName = "TestResults.txt";
        private readonly string _data = "1 2 3 4 5 6";

        public FileServiceTests()
        {
            _fileService = new FileService("TestResults.txt");
        }

        [Fact]
        public async Task SaveToFileTest()
        {
            await _fileService.SeveToFile(_data);

            var dataFromFile = await File.ReadAllTextAsync(_fileName);

            Assert.Equal(_data, dataFromFile);
        }

        [Fact]
        public async Task ReadFromFileTest()
        {

            await File.WriteAllTextAsync(_fileName, _data);

            var dataFromFile = await File.ReadAllTextAsync(_fileName);

            Assert.Equal(_data, dataFromFile);
        }
    }
}
