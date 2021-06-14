
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
            this.lbIdioma = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelIcon = new MetroFramework.Controls.MetroPanel();
            this.lbText = new MetroFramework.Controls.MetroLabel();
            this.lbLanguage = new MetroFramework.Controls.MetroLabel();
            this.cbLanguage = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbInfo.Location = new System.Drawing.Point(23, 114);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(827, 448);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbInfo.WrapToLine = true;
            // 
            // lbIdioma
            // 
            this.lbIdioma.AutoSize = true;
            this.lbIdioma.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbIdioma.Location = new System.Drawing.Point(562, 50);
            this.lbIdioma.Name = "lbIdioma";
            this.lbIdioma.Size = new System.Drawing.Size(125, 19);
            this.lbIdioma.TabIndex = 1;
            this.lbIdioma.Text = "Selecione o idioma:";
            this.lbIdioma.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(521, 575);
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
            // lbText
            // 
            this.lbText.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbText.Location = new System.Drawing.Point(23, 114);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(827, 448);
            this.lbText.TabIndex = 52;
            this.lbText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbText.Visible = false;
            this.lbText.WrapToLine = true;
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbLanguage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbLanguage.Location = new System.Drawing.Point(556, 50);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(131, 19);
            this.lbLanguage.TabIndex = 53;
            this.lbLanguage.Text = "Select the language:";
            this.lbLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbLanguage.UseCustomForeColor = true;
            this.lbLanguage.Visible = false;
            // 
            // cbLanguage
            // 
            this.cbLanguage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.ItemHeight = 23;
            this.cbLanguage.Items.AddRange(new object[] {
            "Português (Brasil)",
            "English"});
            this.cbLanguage.Location = new System.Drawing.Point(693, 44);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(157, 29);
            this.cbLanguage.Style = MetroFramework.MetroColorStyle.Red;
            this.cbLanguage.TabIndex = 54;
            this.cbLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbLanguage.UseSelectable = true;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 614);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.lbLanguage);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelIcon);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lbIdioma);
            this.Controls.Add(this.lbInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Info";
            this.Opacity = 0.95D;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbInfo;
        private MetroFramework.Controls.MetroLabel lbIdioma;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel panelIcon;
        private MetroFramework.Controls.MetroLabel lbText;
        private MetroFramework.Controls.MetroLabel lbLanguage;
        private MetroFramework.Controls.MetroComboBox cbLanguage;
    }
}