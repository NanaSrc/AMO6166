
namespace amo6166
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.lbInfo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbIdioma = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelIcon = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.Location = new System.Drawing.Point(23, 117);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(839, 480);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = resources.GetString("lbInfo.Text");
            this.lbInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbInfo.WrapToLine = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(540, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(125, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Selecione o idioma:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbIdioma
            // 
            this.cbIdioma.BackColor = System.Drawing.SystemColors.Window;
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Items.AddRange(new object[] {
            "Português (Brasil)",
            "English"});
            this.cbIdioma.Location = new System.Drawing.Point(671, 50);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(191, 23);
            this.cbIdioma.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(521, 626);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(341, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "By AMO6166™, we are hated but I feel loved with you. ©";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 51;
            this.label1.Text = "AMO6166™ - Info";
            // 
            // panelIcon
            // 
            this.panelIcon.BackgroundImage = global::amo6166.Properties.Resources.icon;
            this.panelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelIcon.HorizontalScrollbarBarColor = true;
            this.panelIcon.HorizontalScrollbarHighlightOnWheel = false;
            this.panelIcon.HorizontalScrollbarSize = 10;
            this.panelIcon.Location = new System.Drawing.Point(23, 23);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(65, 62);
            this.panelIcon.Style = MetroFramework.MetroColorStyle.Purple;
            this.panelIcon.TabIndex = 50;
            this.panelIcon.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelIcon.VerticalScrollbarBarColor = true;
            this.panelIcon.VerticalScrollbarHighlightOnWheel = false;
            this.panelIcon.VerticalScrollbarSize = 10;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelIcon);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbIdioma);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lbInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Info";
            this.Opacity = 0.95D;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbInfo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox cbIdioma;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel panelIcon;
    }
}