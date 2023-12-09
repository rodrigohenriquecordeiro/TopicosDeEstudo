namespace Gatos
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbox_Gatos = new PictureBox();
            lbl_Mensagem = new Label();
            ((System.ComponentModel.ISupportInitialize)pbox_Gatos).BeginInit();
            SuspendLayout();
            // 
            // pbox_Gatos
            // 
            pbox_Gatos.Location = new Point(65, 67);
            pbox_Gatos.Name = "pbox_Gatos";
            pbox_Gatos.Size = new Size(218, 154);
            pbox_Gatos.TabIndex = 0;
            pbox_Gatos.TabStop = false;
            pbox_Gatos.Click += pbox_Gatos_Click;
            // 
            // lbl_Mensagem
            // 
            lbl_Mensagem.Location = new Point(389, 79);
            lbl_Mensagem.Name = "lbl_Mensagem";
            lbl_Mensagem.Size = new Size(174, 118);
            lbl_Mensagem.TabIndex = 1;
            lbl_Mensagem.Click += lbl_Mensagem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(630, 322);
            Controls.Add(lbl_Mensagem);
            Controls.Add(pbox_Gatos);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fotos e Fatos sobre Gatos!";
            ((System.ComponentModel.ISupportInitialize)pbox_Gatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbox_Gatos;
        private Label lbl_Mensagem;
    }
}