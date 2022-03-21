using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Services;

namespace WordCounter
{
    public static class DependencyInjection
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<Executor>();
            services.AddTransient<FileImportService>();
            services.AddTransient<CalculationService>();
        }
    }
}
