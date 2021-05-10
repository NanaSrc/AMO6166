
namespace amo6166
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(love));
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.btNanaDiario = new MetroFramework.Controls.MetroButton();
            this.btMarcoDiario = new MetroFramework.Controls.MetroButton();
            this.btGaleria = new MetroFramework.Controls.MetroButton();
            this.btNotas = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.btTerminal = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.HorizontalScrollbarBarColor = true;
            this.panel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel.HorizontalScrollbarSize = 10;
            this.panel.Location = new System.Drawing.Point(187, 68);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(744, 581);
            this.panel.Style = MetroFramework.MetroColorStyle.Purple;
            this.panel.TabIndex = 0;
            this.panel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel.UseStyleColors = true;
            this.panel.VerticalScrollbarBarColor = true;
            this.panel.VerticalScrollbarHighlightOnWheel = false;
            this.panel.VerticalScrollbarSize = 10;
            // 
            // btNanaDiario
            // 
            this.btNanaDiario.Location = new System.Drawing.Point(23, 152);
            this.btNanaDiario.Name = "btNanaDiario";
            this.btNanaDiario.Size = new System.Drawing.Size(158, 78);
            this.btNanaDiario.TabIndex = 2;
            this.btNanaDiario.Text = "Diário da Nana";
            this.btNanaDiario.UseSelectable = true;
            // 
            // btMarcoDiario
            // 
            this.btMarcoDiario.Location = new System.Drawing.Point(23, 236);
            this.btMarcoDiario.Name = "btMarcoDiario";
            this.btMarcoDiario.Size = new System.Drawing.Size(158, 78);
            this.btMarcoDiario.TabIndex = 3;
            this.btMarcoDiario.Text = "Diário do Marco";
            this.btMarcoDiario.UseSelectable = true;
            // 
            // btGaleria
            // 
            this.btGaleria.Location = new System.Drawing.Point(23, 320);
            this.btGaleria.Name = "btGaleria";
            this.btGaleria.Size = new System.Drawing.Size(158, 78);
            this.btGaleria.TabIndex = 4;
            this.btGaleria.Text = "Galeria";
            this.btGaleria.UseSelectable = true;
            // 
            // btNotas
            // 
            this.btNotas.Location = new System.Drawing.Point(23, 404);
            this.btNotas.Name = "btNotas";
            this.btNotas.Size = new System.Drawing.Size(158, 78);
            this.btNotas.TabIndex = 5;
            this.btNotas.Text = "Notas";
            this.btNotas.UseSelectable = true;
            // 
            // metroButton7
            // 
            this.metroButton7.Location = new System.Drawing.Point(23, 488);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(158, 78);
            this.metroButton7.TabIndex = 7;
            this.metroButton7.Text = "amo6166.com";
            this.metroButton7.UseSelectable = true;
            // 
            // metroButton8
            // 
            this.metroButton8.Location = new System.Drawing.Point(23, 572);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(158, 77);
            this.metroButton8.TabIndex = 8;
            this.metroButton8.Text = "Sair";
            this.metroButton8.UseSelectable = true;
            // 
            // btTerminal
            // 
            this.btTerminal.ActiveControl = null;
            this.btTerminal.Location = new System.Drawing.Point(23, 68);
            this.btTerminal.Name = "btTerminal";
            this.btTerminal.Size = new System.Drawing.Size(158, 78);
            this.btTerminal.Style = MetroFramework.MetroColorStyle.Purple;
            this.btTerminal.TabIndex = 2;
            this.btTerminal.Text = "Terminal";
            this.btTerminal.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btTerminal.UseSelectable = true;
            // 
            // love
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 672);
            this.Controls.Add(this.btTerminal);
            this.Controls.Add(this.metroButton8);
            this.Controls.Add(this.metroButton7);
            this.Controls.Add(this.btNotas);
            this.Controls.Add(this.btGaleria);
            this.Controls.Add(this.btMarcoDiario);
            this.Controls.Add(this.btNanaDiario);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "love";
            this.Opacity = 0.96D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "AMO6166™";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.love_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panel;
        private MetroFramework.Controls.MetroButton btNanaDiario;
        private MetroFramework.Controls.MetroButton btMarcoDiario;
        private MetroFramework.Controls.MetroButton btGaleria;
        private MetroFramework.Controls.MetroButton btNotas;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroTile btTerminal;
    }
}