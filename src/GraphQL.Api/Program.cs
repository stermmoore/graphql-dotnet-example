using GraphQL;
using GraphQL.Api.Data.Repositories;
using GraphQL.Api.GraphQL;
using GraphQL.Api.GraphQL.Types;
using GraphQL.Server;
using GraphQL.SystemTextJson;
using GraphQL.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
builder.Services.AddSingleton<IDocumentWriter, DocumentWriter>();
builder.Services.AddSingleton<DeviceRepository>();
builder.Services.AddSingleton<DeviceQuery>();
builder.Services.AddSingleton<DeviceType>();
builder.Services.AddSingleton<ISchema, DeviceSchema>();


builder.Services.AddHttpContextAccessor();

builder.Services.AddGraphQL(options =>
{
    options.EnableMetrics = true;
})
.AddErrorInfoProvider(opt => opt.ExposeExceptionStackTrace = true)
.AddSystemTextJson();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHealthChecks("/health");
app.UseGraphQL<ISchema>();
app.UseGraphQLPlayground(new GraphQL.Server.Ui.Playground.GraphQLPlaygroundOptions { });

app.Run();
