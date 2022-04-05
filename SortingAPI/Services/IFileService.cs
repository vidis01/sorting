namespace SortingAPI.Services
{
    public interface IFileService
    {
        void SeveToFile(string fileName, string numbers);
        string ReadFromFile(string fileName);
    }
}
