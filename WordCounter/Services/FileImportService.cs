using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Services
{
    public class FileImportService
    {
        public async Task<string> ImportFileAsync()
        {
            var file = await File.ReadAllTextAsync("Data/Input.txt");
            return file;
        }
    }
}
