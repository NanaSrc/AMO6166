
namespace marco
{
    partial class love
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbText = new System.Windows.Forms.Label();
            this.pnFoto = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnFoto);
            this.groupBox1.Controls.Add(this.lbText);
            this.groupBox1.Controls.Add(this.lbNome);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(24, 32);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(40, 15);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // lbText
            // 
            this.lbText.Location = new System.Drawing.Point(24, 145);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(264, 133);
            this.lbText.TabIndex = 1;
            this.lbText.Text = "Se você conseguiu entrar aqui, significa que você é o Marco, o que também signifi" +
    "ca que você é o motivo pelo qual esse programa existe.";
            // 
            // pnFoto
            // 
            this.pnFoto.BackgroundImage = global::marco.Properties.Resources._13;
            this.pnFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnFoto.Location = new System.Drawing.Point(343, 32);
            this.pnFoto.Name = "pnFoto";
            this.pnFoto.Size = new System.Drawing.Size(142, 134);
            this.pnFoto.TabIndex = 2;
            // 
            // love
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 306);
            this.Controls.Add(this.groupBox1);
            this.Name = "love";
            this.Text = "love.exe";
            this.Load += new System.EventHandler(this.love_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnFoto;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label lbNome;
    }
}