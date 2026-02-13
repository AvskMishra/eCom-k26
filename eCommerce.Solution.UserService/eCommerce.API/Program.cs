
using eCommerce.API.Middlewares;
using eCommerce.Core;
using eCommerce.Core.Mappers;
using eCommerce.Infrastructure;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//Add Infrastructure Services 
builder.Services.AddInfrastructure();
builder.Services.AddCore();



// Add controllers to the service collection
builder.Services.AddControllers().AddJsonOptions(options => {
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

//Add AutoMapper and register mapping profiles
builder.Services.AddAutoMapper(typeof(ApplicationUserMappingProfile).Assembly);


//build the application
var app = builder.Build();

//added custom middlewares for global exception handling
app.UseExceptionHandlingMiddleware();


//routing
app.UseRouting();

//Auth
app.UseAuthorization();
app.UseAuthorization();


app.Run();
