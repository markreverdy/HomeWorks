using Microsoft.Extensions.Configuration;
using Module2_Ex5.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Ex5.Services
{
    public class FileService : IFileService
    {
        private readonly string _folderPath = "Logs";
        private readonly IConfiguration _configuration;

        public FileService(IConfiguration configuration)
        {
            _configuration = configuration;
            Directory.CreateDirectory(_folderPath);
        }

        public void WriteToFile(string message)
        {
            string timestamp = DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss-fff");
            string filename = Path.Combine(_folderPath, $"{timestamp}.txt");

            File.WriteAllText(filename, message);

            // Get all files in the directory
            var files = Directory.GetFiles(_folderPath);

            // Check if we need to delete any
            if (files.Length > 3)
            {
                // Get the oldest file
                var oldestFile = files.OrderBy(f => File.GetCreationTime(f)).First();

                // Delete the oldest file
                File.Delete(oldestFile);
            }
        }
    }
}
