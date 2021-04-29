
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
            this.lbMain = new System.Windows.Forms.Label();
            this.tbMemoria = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMemoria);
            this.groupBox1.Controls.Add(this.lbMain);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memórias";
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMain.Location = new System.Drawing.Point(15, 35);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(504, 30);
            this.lbMain.TabIndex = 0;
            this.lbMain.Text = "Se você conseguiu entrar aqui, significa que você é o Marco, o que também signifi" +
    "ca que você\r\n é o motivo pelo qual esse programa existe\r\n";
            // 
            // tbMemoria
            // 
            this.tbMemoria.Location = new System.Drawing.Point(15, 88);
            this.tbMemoria.Name = "tbMemoria";
            this.tbMemoria.Size = new System.Drawing.Size(349, 23);
            this.tbMemoria.TabIndex = 1;
            // 
            // love
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 545);
            this.Controls.Add(this.groupBox1);
            this.Name = "love";
            this.Text = "Entre, sente-se e relaxe...";
            this.Load += new System.EventHandler(this.love_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAlgumaCoisa;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.TextBox tbMemoria;
    }
}