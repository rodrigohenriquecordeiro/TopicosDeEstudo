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

        private async void Form2_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new())
            {
                #region Fatos
                try
                {
                    List<FatosSobreGatos> gatos = await ConectaAPIFatosSobreGatos(client);
                    Random numero = new();
                    lbl_MensagemFato.Text = $"Fato: {gatos[numero.Next(gatos.Count)].Mensagem}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}");
                }
                #endregion

                #region Fotos
                try
                {
                    await ConectaAPIFotosSobreGatos(client);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao baixar a imagem: " + ex.Message);
                }
                #endregion
            }
        }

        private async Task ConectaAPIFotosSobreGatos(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("https://cataas.com/cat");

            if (response.IsSuccessStatusCode)
            {
                using (HttpContent content = response.Content)
                {
                    byte[] imagemBytes = await content.ReadAsByteArrayAsync();
                    Image imagem = Image.FromStream(new MemoryStream(imagemBytes));
                    AjustarImagem(imagem);
                }
            }
            else
                MessageBox.Show("Falha ao baixar a imagem. Código de status: " + response.StatusCode);
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
            pictureBox_Gatos.Width = 300;
            pictureBox_Gatos.Height = 250;
            pictureBox_Gatos.Image = imagem;
        }
    }
}
