using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Services;

namespace WordCounter
{
    public class Executor
    {
        private readonly FileImportService _fileImportService;
        private readonly CalculationService _calculationService;

        public Executor(FileImportService fileImportService, CalculationService calculationService)
        {
            _fileImportService = fileImportService;
            _calculationService = calculationService;
        }

        public async Task ExecuteAsync()
        {
            string textFile = await _fileImportService.ImportFileAsync();
            int wordCount = _calculationService.CountWords(textFile);
            int charCount = _calculationService.CountChars(textFile);

            Console.WriteLine($"There are {wordCount} words and in total the file contains {charCount} characters");
        }
    }
}
