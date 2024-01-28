using System.Text.Json;
using ConselheiroTech.v1.InitialMetods;
using ConselhereiroTech.v1.Models;


string apiUrlGet = "https://api.adviceslip.com/advice";
using (HttpClient client = new HttpClient())
{
    // MenuMetods menu = new MenuMetods();
    // menu.AbrirMenu();
    try
    {
        string response = await client.GetStringAsync(apiUrlGet);
        var conselhoObj = JsonSerializer.Deserialize<Conselho>(response);
        conselhoObj!.ExibirConselho();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Algo deu errado --> {ex.Message}");
    }
}

