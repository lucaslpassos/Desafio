var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! Me chamo Lucas e fiz essa API minima usando .NET6!");
/*Fiz essa API minima usando os conhecimentos que consegui adquirir nesses dias 
 * usando o Visual Studio como ferramenta.*/
app.Run();