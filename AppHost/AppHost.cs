using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddAzureContainerAppEnvironment("aca-env").WithAzdResourceNaming();

builder.Build().Run();
