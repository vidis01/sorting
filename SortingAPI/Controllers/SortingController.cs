using Microsoft.AspNetCore.Mvc;
using SortingAPI.Helpers;
using SortingAPI.Services;
using System.Threading.Tasks;

namespace SortingAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SortingController : ControllerBase
    {
        private readonly ISortingService _sortingService;
        private readonly IFileService _fileService;        

        public SortingController(ISortingService sortingService, IFileService fileService)
        {
            _sortingService = sortingService;
            _fileService = fileService;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            return await _fileService.ReadFromFile();
        }

        [HttpPost]
        public async Task Post([FromBody] string numbers)
        {
            var intNumbers = InputOutputHelper.GetInputAsIntNumbers(numbers);

            var sortedNumbers = _sortingService.SortNumbers(intNumbers as int[]);

            await _fileService.SeveToFile(string.Join(' ', sortedNumbers));
        }
    }
}
