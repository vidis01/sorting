using System.Threading.Tasks;

namespace SortingAPI.Services
{
    public interface IFileService
    {
        Task SeveToFile(string numbers);
        Task<string> ReadFromFile();
    }
}
