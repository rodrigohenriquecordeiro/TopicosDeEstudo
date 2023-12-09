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
            components = new System.ComponentModel.Container();
            lbl_MensagemFato = new Label();
            pictureBox_Gatos = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Gatos).BeginInit();
            SuspendLayout();
            // 
            // lbl_MensagemFato
            // 
            lbl_MensagemFato.Font = new Font("Rockwell", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_MensagemFato.Location = new Point(503, 48);
            lbl_MensagemFato.Name = "lbl_MensagemFato";
            lbl_MensagemFato.Size = new Size(272, 350);
            lbl_MensagemFato.TabIndex = 0;
            // 
            // pictureBox_Gatos
            // 
            pictureBox_Gatos.Location = new Point(62, 48);
            pictureBox_Gatos.Name = "pictureBox_Gatos";
            pictureBox_Gatos.Size = new Size(380, 350);
            pictureBox_Gatos.TabIndex = 1;
            pictureBox_Gatos.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(884, 461);
            Controls.Add(pictureBox_Gatos);
            Controls.Add(lbl_MensagemFato);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fotos e Fatos sobre Gatos!";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Gatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_MensagemFato;
        private PictureBox pictureBox_Gatos;
        private System.Windows.Forms.Timer timer1;
    }
}