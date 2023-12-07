using System.Text.Json.Serialization;

namespace Gatos.Modelos;

internal class FatosSobreGatos
{
    [JsonPropertyName("text")]
    public string? Mensagem { get; set; }

    public void ExibirUmFatoSobreGato()
    {
        Console.WriteLine($"Fato: {Mensagem}");
    }
}
