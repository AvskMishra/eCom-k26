
using eCommerce.Infrastructure;
using eCommerce.Core;
using eCommerce.API.Middlewares;

var builder = WebApplication.CreateBuilder(args);

//Add Infrastructure Services 
builder.Services.AddInfrastructure();
builder.Services.AddCore();



//add controllers to the service collection
builder.Services.AddControllers();


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
