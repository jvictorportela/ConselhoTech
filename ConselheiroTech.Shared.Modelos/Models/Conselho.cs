using System.Text.Json.Serialization;

namespace ConselhereiroTech.v1.Models;

public class Conselho
{
    //Campos do conselho {"slip": { "id": 7, "advice": "Make choices and dont look back."}}
    [JsonPropertyName("slip")]
    public Slip SlipConselho { get; set; }

    public class Slip
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("advice")]
        public string Advice { get; set; }
    }

    public void ExibirConselho()
    {
        Console.WriteLine($"Conselho --> {SlipConselho?.Advice}");
    }
}