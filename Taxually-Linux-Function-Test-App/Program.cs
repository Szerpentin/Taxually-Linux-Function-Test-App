using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureAppConfiguration(builder =>builder.AddEnvironmentVariables()) // The AddEnvironmentVariables causing the error
    .Build();

host.Run();