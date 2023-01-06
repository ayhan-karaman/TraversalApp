using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System;

namespace Core.Utilities.UploadFile
{
    public static class UploadHelper
    {
        public static string AddFile(IFormFile files, string folderName)
        {
            var createPath = FolderAndFilePath(files, folderName);
            if(files.Length > 0)
            {
                if(!CreateFolder(createPath.folderPath))
                {
                    Directory.CreateDirectory(createPath.folderPath + folderName);
                }
                using (FileStream stream = File.Create(createPath.filePath))
                {
                    files.CopyTo(stream);
                    stream.Flush();
                    return "/"+folderName + createPath.fileName;
                }
            }
            return null;
        }

        private static (string extension, string fileName, string folderPath, string lowerFolderPath, string filePath) FolderAndFilePath(IFormFile files,string folderName)
        {
            string extension = Path.GetExtension(files.FileName);
            string fileName = Guid.NewGuid().ToString(format: "D") + extension;
            string folderPath = Environment.CurrentDirectory;
            string lowerFolderPath = Path.Combine(@"wwwroot/",  folderName );
            string filePath = Path.Combine(folderPath, lowerFolderPath, fileName);
            return (extension, fileName, folderPath, lowerFolderPath, filePath);
        }

        private static bool CreateFolder(string folderPath)
        {

            return Directory.Exists(folderPath);

        }

        public static bool Delete(string file)
        {
            string folderPath = Environment.CurrentDirectory + @"wwwroot\";

            DeleteOldImageFile((folderPath + file).Replace("/", "\\"));
            return true;
        }

        private static void DeleteOldImageFile(string filePath)
        {
            if (File.Exists(filePath.Replace("/", "\\")))
            {
                File.Delete(filePath.Replace("/", "\\"));
            }
        }
    }
}