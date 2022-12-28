using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace UIApp
{
    public static class FileHelper
    {
        public static async Task<string> UploadFile(IFormFile formFile)
        {
            var resource = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(formFile.FileName);
            var imageName = Guid.NewGuid() + extension;
            var location = $"{resource}/wwwroot/userImages/{imageName}";
            var stream = new FileStream(location, FileMode.Create);
            await formFile.CopyToAsync(stream);
            return $"/userImages/{imageName}";
        }
    }
}