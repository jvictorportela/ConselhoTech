using System.Text.Json;
using System.Text.Json.Serialization;
using ConselhereiroTech.v1.Models;
using ConselhereiroTech.v1.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options =>
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

app.MapGet("/", async (HttpContext context) =>
{
    using (HttpClient client = new HttpClient())
    {
        string apiUrlGet = "https://api.adviceslip.com/advice";
        try
        {
            string response = await client.GetStringAsync(apiUrlGet);
            var conselhoObj = JsonSerializer.Deserialize<Conselho>(response);
            await context.Response.WriteAsJsonAsync(conselhoObj);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Algo deu errado --> {ex.Message}");
        }
    }
});

app.Run();