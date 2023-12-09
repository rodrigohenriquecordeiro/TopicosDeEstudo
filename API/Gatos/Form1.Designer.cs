namespace Gatos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lgl_Apresentacao = new Label();
            btn_Carregar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // lgl_Apresentacao
            // 
            resources.ApplyResources(lgl_Apresentacao, "lgl_Apresentacao");
            lgl_Apresentacao.Name = "lgl_Apresentacao";
            // 
            // btn_Carregar
            // 
            btn_Carregar.BackColor = SystemColors.ActiveCaption;
            resources.ApplyResources(btn_Carregar, "btn_Carregar");
            btn_Carregar.Name = "btn_Carregar";
            btn_Carregar.UseVisualStyleBackColor = false;
            btn_Carregar.Click += btn_Carregar_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(btn_Carregar);
            Controls.Add(lgl_Apresentacao);
            Controls.Add(pictureBox1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lgl_Apresentacao;
        private Button btn_Carregar;
    }
}
