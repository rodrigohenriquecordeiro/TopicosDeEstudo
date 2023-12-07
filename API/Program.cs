using Gatos.Modelos;
using System.Text.Json;

using (HttpClient client = new())
{
    try
    {
        string resposta = await client.GetStringAsync("https://cat-fact.herokuapp.com/facts");
        var gatos = JsonSerializer.Deserialize<List<FatosSobreGatos>>(resposta)!;

        Random numero = new Random();
        int sorteio = numero.Next(gatos.Count);

        Console.WriteLine(gatos[sorteio].Mensagem);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Erro: {e.Message}");
    }
}