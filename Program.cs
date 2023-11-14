using API.Library.Repository;
using API.Library;
using GraphQL.AspNet.Configuration;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGraphQL();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSingleton<IFileManager, FileManager>();
builder.Services.AddSingleton<IImageUtility,ImageUtilities>();

WebApplication? app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseGraphQLAltair();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseGraphQL();
app.MapControllers();
app.Run();
