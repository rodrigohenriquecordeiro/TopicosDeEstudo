using Gatos.Modelos;
using System.Text.Json;

namespace Gatos
{
    public partial class Form2 : Form
    {
        private readonly HttpClient client = new();

        public Form2()
        {
            InitializeComponent();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                await ConectaAPIFotosSobreGatos(client);

                List<FatosSobreGatos> gatos = await ConectaAPIFatosSobreGatos(client);
                lbl_MensagemFato.Text = $"Fato nº {i + 1}: {gatos[i].Mensagem}";

                await Task.Delay(5000);
            }
        }

        private async Task ConectaAPIFotosSobreGatos(HttpClient client)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://cataas.com/cat/gif");

                if (response.IsSuccessStatusCode)
                {
                    using HttpContent content = response.Content;
                    byte[] imagemBytes = await content.ReadAsByteArrayAsync();
                    Image imagem = Image.FromStream(new MemoryStream(imagemBytes));
                    AjustarImagem(imagem);
                }
                else
                    MessageBox.Show("Falha ao baixar a imagem. Código de status: " + response.StatusCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao baixar a imagem: " + ex.Message);
            }
        }

        private static async Task<List<FatosSobreGatos>> ConectaAPIFatosSobreGatos(HttpClient client)
        {
            string resposta = await client.GetStringAsync("https://cat-fact.herokuapp.com/facts");
            var gatos = JsonSerializer.Deserialize<List<FatosSobreGatos>>(resposta)!;

            return gatos;
        }

        private void AjustarImagem(Image imagem)
        {
            pictureBox_Gatos.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox_Gatos.Width = 380;
            pictureBox_Gatos.Height = 350;
            pictureBox_Gatos.Image = imagem;
        }
    }
}
