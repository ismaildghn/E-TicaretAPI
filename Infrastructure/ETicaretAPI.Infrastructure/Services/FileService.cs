
using ETicaretAPI.Infrastructure.Operations;
using Microsoft.AspNetCore.Hosting;


namespace ETicaretAPI.Infrastructure.Services
{
    public class FileService
    {
        readonly IWebHostEnvironment _webHostEnvironment;
        public FileService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            
        }
        async Task<string> FileRenameAsync(string path, string fileName, bool first = true)
        {
            string extension = Path.GetExtension(fileName);
            string oldFileName = Path.GetFileNameWithoutExtension(fileName);
            string newFileName = $"{NameOperation.CharacterRegulatory(oldFileName)}{DateTime.Now.ToString("yyyyMMdd_HHmmssfff")}{extension}";

            return newFileName;
        }
    }
}

