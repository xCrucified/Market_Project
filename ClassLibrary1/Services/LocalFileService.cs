using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace BusinessLogic.Services
{
    public class LocalFileService : IFileService
    {
        private const string imageFolder = "images";
        private readonly IWebHostEnvironment environment;

        public LocalFileService(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        public Task DeleteProductImage(string path)
        {
            throw new NotImplementedException();
        }

        public async Task<string> SaveProductImage(IFormFile file)
        {
            // get image destination path
            string root = environment.WebRootPath;     
            string name = Guid.NewGuid().ToString();   
            string extension = Path.GetExtension(file.FileName); 
            string fullName = name + extension;         // full name: name.ext

            // create destination image file path
            string imagePath = Path.Combine(imageFolder, fullName);
            string imageFullPath = Path.Combine(root, imagePath);

            // save image on the folder
            using (FileStream fs = new FileStream(imageFullPath, FileMode.Create))
            {
                await file.CopyToAsync(fs);
            }

            // return image file path
            return Path.DirectorySeparatorChar + imagePath;
        }
    }
}
