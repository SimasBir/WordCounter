using Microsoft.Extensions.DependencyInjection;
using WordCounter;

var services = new ServiceCollection();
services.ConfigureServices();

var serviceProvider = services.BuildServiceProvider();
var executor = serviceProvider.GetRequiredService<Executor>();

await executor.ExecuteAsync();
