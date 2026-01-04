// os imports/usings
using DemoVsCode;

// Configuração do Builder
var builder = WebApplication.CreateBuilder(args); // linha obrigatoria

// Configuração do Pepiline

// Midlewares
builder.AddSerilog();
// Services

// COnfiguração do App
var app = builder.Build(); // linha obrigatoria

app.UseLogTempo();

// Configuração do comportamento da App
app.MapGet("/", () => "Hello World!");
app.MapGet("/test", () =>
{
    Thread.Sleep(1500);
    return "Teste, pam pam queijo queijo - Teste Sleep";
});

app.Run(); // linha obrigatoria
