using Gatos.Modelos;
using System.Text.Json;

namespace Gatos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private async void lbl_Mensagem_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new())
            {
                try
                {
                    List<FatosSobreGatos> gatos = await ConectaAPIFatosSobreGatos(client);
                    Random numero = new();
                    lbl_Mensagem.Text = $"Fato: {gatos[numero.Next(gatos.Count)].Mensagem}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
            }
        }

        private static async Task<List<FatosSobreGatos>> ConectaAPIFatosSobreGatos(HttpClient client)
        {
            string resposta = await client.GetStringAsync("https://cat-fact.herokuapp.com/facts");
            var gatos = JsonSerializer.Deserialize<List<FatosSobreGatos>>(resposta)!;
            return gatos;
        }

        private void pbox_Gatos_Click(object sender, EventArgs e)
        {

        }
    }
}
