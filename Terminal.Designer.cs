
namespace marco
{
    partial class Terminal
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbComandos = new System.Windows.Forms.TextBox();
            this.tbTerminalzinho = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbComandos);
            this.groupBox2.Controls.Add(this.tbTerminalzinho);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 590);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Terminalzinho";
            // 
            // tbComandos
            // 
            this.tbComandos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbComandos.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbComandos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(212)))), ((int)(((byte)(163)))));
            this.tbComandos.Location = new System.Drawing.Point(17, 33);
            this.tbComandos.Multiline = true;
            this.tbComandos.Name = "tbComandos";
            this.tbComandos.ReadOnly = true;
            this.tbComandos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbComandos.Size = new System.Drawing.Size(555, 91);
            this.tbComandos.TabIndex = 16;
            this.tbComandos.Text = "Lista de comandos do terminalzinho:\r\ninfo\r\nlove\r\nnana\r\nmarco\r\ncls\r\nsay\r\nplaylist\r" +
    "\n";
            // 
            // tbTerminalzinho
            // 
            this.tbTerminalzinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.tbTerminalzinho.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTerminalzinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbTerminalzinho.Location = new System.Drawing.Point(17, 130);
            this.tbTerminalzinho.Multiline = true;
            this.tbTerminalzinho.Name = "tbTerminalzinho";
            this.tbTerminalzinho.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTerminalzinho.Size = new System.Drawing.Size(555, 414);
            this.tbTerminalzinho.TabIndex = 9;
            this.tbTerminalzinho.Text = "Nana says: TIJOLO";
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 579);
            this.Controls.Add(this.groupBox2);
            this.Name = "Terminal";
            this.Text = "Terminal";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbComandos;
        private System.Windows.Forms.TextBox tbTerminalzinho;
    }
}