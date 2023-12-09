namespace Gatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Carregar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new();
            form2.Show();
            this.Hide();
        }
    }
}
