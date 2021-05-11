
namespace amo6166
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
            this.tbComandos = new System.Windows.Forms.TextBox();
            this.tbTerminalzinho = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbComandos
            // 
            this.tbComandos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tbComandos.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbComandos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(212)))), ((int)(((byte)(163)))));
            this.tbComandos.Location = new System.Drawing.Point(23, 353);
            this.tbComandos.Multiline = true;
            this.tbComandos.Name = "tbComandos";
            this.tbComandos.ReadOnly = true;
            this.tbComandos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbComandos.Size = new System.Drawing.Size(574, 100);
            this.tbComandos.TabIndex = 16;
            this.tbComandos.Text = "Lista de comandos do terminalzinho:\r\ninfo\r\nlove\r\nnana\r\nmarco\r\ncls\r\nsay\r\nplaylist\r" +
    "\n";
            // 
            // tbTerminalzinho
            // 
            this.tbTerminalzinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(199)))));
            this.tbTerminalzinho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTerminalzinho.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTerminalzinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbTerminalzinho.Location = new System.Drawing.Point(23, 19);
            this.tbTerminalzinho.Multiline = true;
            this.tbTerminalzinho.Name = "tbTerminalzinho";
            this.tbTerminalzinho.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTerminalzinho.Size = new System.Drawing.Size(916, 623);
            this.tbTerminalzinho.TabIndex = 9;
            this.tbTerminalzinho.Text = "Nana says: ";
            this.tbTerminalzinho.TextChanged += new System.EventHandler(this.tbTerminalzinho_TextChanged);
            this.tbTerminalzinho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTerminalzinho_KeyPress);
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 665);
            this.ControlBox = false;
            this.Controls.Add(this.tbTerminalzinho);
            this.Controls.Add(this.tbComandos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Terminal";
            this.Opacity = 0.9D;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Terminal";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(11)))), ((int)(((byte)(40)))));
            this.Load += new System.EventHandler(this.Terminal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbComandos;
        private System.Windows.Forms.TextBox tbTerminalzinho;
    }
}