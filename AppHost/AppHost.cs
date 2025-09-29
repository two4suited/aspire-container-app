using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddAzureContainerAppEnvironment("aca-env").WithAzdResourceNaming();

#pragma warning disable ASPIREAZURE002 // Type is for evaluation purposes only and is subject to change or removal in future updates
builder.AddProject<Projects.Job_DateInfo>("dateinfo-job")
    .PublishAsScheduledAzureContainerAppJob("0 */1 * * *");
#pragma warning restore ASPIREAZURE002

builder.Build().Run();
