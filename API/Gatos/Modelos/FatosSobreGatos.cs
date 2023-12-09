using System.Text.Json.Serialization;

namespace Gatos.Modelos;

public class FatosSobreGatos
{
    [JsonPropertyName("text")]
    public string? Mensagem { get; set; }
}