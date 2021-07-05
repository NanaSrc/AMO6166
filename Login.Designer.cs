
namespace amo6166
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbAcesso = new MetroFramework.Controls.MetroLabel();
            this.mtShow = new MetroFramework.Controls.MetroToggle();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbSenha = new MetroFramework.Controls.MetroLabel();
            this.lbNome = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btLogin = new MetroFramework.Controls.MetroButton();
            this.btCancel = new MetroFramework.Controls.MetroButton();
            this.tbSim = new MetroFramework.Controls.MetroRadioButton();
            this.rbMoon = new MetroFramework.Controls.MetroRadioButton();
            this.rbSummer = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.panelIcon = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLembrar = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // lbAcesso
            // 
            this.lbAcesso.AutoSize = true;
            this.lbAcesso.BackColor = System.Drawing.Color.Black;
            this.lbAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAcesso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(32)))), ((int)(((byte)(250)))));
            this.lbAcesso.Location = new System.Drawing.Point(4, 383);
            this.lbAcesso.Name = "lbAcesso";
            this.lbAcesso.Size = new System.Drawing.Size(170, 19);
            this.lbAcesso.Style = MetroFramework.MetroColorStyle.Purple;
            this.lbAcesso.TabIndex = 40;
            this.lbAcesso.Text = "Acessando como: Anônimo";
            this.lbAcesso.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbAcesso.UseStyleColors = true;
            this.lbAcesso.TextChanged += new System.EventHandler(this.lbAcesso_TextChanged);
            // 
            // mtShow
            // 
            this.mtShow.AutoSize = true;
            this.mtShow.Location = new System.Drawing.Point(479, 166);
            this.mtShow.Name = "mtShow";
            this.mtShow.Size = new System.Drawing.Size(80, 19);
            this.mtShow.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtShow.TabIndex = 37;
            this.mtShow.Tag = "";
            this.mtShow.Text = "Off";
            this.mtShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtShow.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtShow.UseSelectable = true;
            this.mtShow.UseStyleColors = true;
            this.mtShow.CheckedChanged += new System.EventHandler(this.mtShow_CheckedChanged);
            // 
            // tbSenha
            // 
            this.tbSenha.BackColor = System.Drawing.SystemColors.Window;
            this.tbSenha.Location = new System.Drawing.Point(151, 164);
            this.tbSenha.MaxLength = 30;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '♥';
            this.tbSenha.Size = new System.Drawing.Size(322, 23);
            this.tbSenha.TabIndex = 2;
            this.tbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSenha_KeyPress);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(151, 122);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(408, 23);
            this.tbNome.TabIndex = 1;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            this.tbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNome_KeyPress);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.Color.Black;
            this.lbSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSenha.Location = new System.Drawing.Point(69, 166);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(47, 19);
            this.lbSenha.TabIndex = 34;
            this.lbSenha.Text = "Senha:";
            this.lbSenha.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbSenha.Click += new System.EventHandler(this.lbSenha_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Black;
            this.lbNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNome.Location = new System.Drawing.Point(69, 122);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 19);
            this.lbNome.TabIndex = 33;
            this.lbNome.Text = "Nome:";
            this.lbNome.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Black;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel2.Location = new System.Drawing.Point(71, 208);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 43;
            this.metroLabel2.Text = "Are you:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btLogin
            // 
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Location = new System.Drawing.Point(173, 261);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(327, 36);
            this.btLogin.Style = MetroFramework.MetroColorStyle.Purple;
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Entrar";
            this.btLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btLogin.UseSelectable = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btCancel
            // 
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Location = new System.Drawing.Point(173, 303);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(327, 36);
            this.btCancel.Style = MetroFramework.MetroColorStyle.Purple;
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Cancelar";
            this.btCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btCancel.UseSelectable = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tbSim
            // 
            this.tbSim.AutoSize = true;
            this.tbSim.Location = new System.Drawing.Point(237, -542);
            this.tbSim.Name = "tbSim";
            this.tbSim.Size = new System.Drawing.Size(43, 15);
            this.tbSim.Style = MetroFramework.MetroColorStyle.Purple;
            this.tbSim.TabIndex = 41;
            this.tbSim.Text = "Sim";
            this.tbSim.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbSim.UseSelectable = true;
            // 
            // rbMoon
            // 
            this.rbMoon.AutoSize = true;
            this.rbMoon.Location = new System.Drawing.Point(173, 212);
            this.rbMoon.Name = "rbMoon";
            this.rbMoon.Size = new System.Drawing.Size(123, 15);
            this.rbMoon.Style = MetroFramework.MetroColorStyle.Red;
            this.rbMoon.TabIndex = 3;
            this.rbMoon.Text = "A robot, what else?";
            this.rbMoon.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbMoon.UseSelectable = true;
            this.rbMoon.CheckedChanged += new System.EventHandler(this.rbMoon_CheckedChanged);
            this.rbMoon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbMoon_KeyPress);
            // 
            // rbSummer
            // 
            this.rbSummer.AutoSize = true;
            this.rbSummer.Location = new System.Drawing.Point(381, 212);
            this.rbSummer.Name = "rbSummer";
            this.rbSummer.Size = new System.Drawing.Size(119, 15);
            this.rbSummer.Style = MetroFramework.MetroColorStyle.Blue;
            this.rbSummer.TabIndex = 4;
            this.rbSummer.Text = "A human (I guess)";
            this.rbSummer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbSummer.UseSelectable = true;
            this.rbSummer.CheckedChanged += new System.EventHandler(this.rbSummer_CheckedChanged);
            this.rbSummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbSummer_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Black;
            this.metroLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel3.Location = new System.Drawing.Point(484, 383);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(154, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel3.TabIndex = 46;
            this.metroLabel3.Text = "Developed by Nαnα™ ©";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // panelIcon
            // 
            this.panelIcon.BackgroundImage = global::amo6166.Properties.Resources.icon;
            this.panelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelIcon.HorizontalScrollbarBarColor = true;
            this.panelIcon.HorizontalScrollbarHighlightOnWheel = false;
            this.panelIcon.HorizontalScrollbarSize = 10;
            this.panelIcon.Location = new System.Drawing.Point(24, 29);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(65, 62);
            this.panelIcon.Style = MetroFramework.MetroColorStyle.Purple;
            this.panelIcon.TabIndex = 47;
            this.panelIcon.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelIcon.VerticalScrollbarBarColor = true;
            this.panelIcon.VerticalScrollbarHighlightOnWheel = false;
            this.panelIcon.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 49;
            this.label1.Text = "AMO6166™";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbInfo.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.lbInfo.Location = new System.Drawing.Point(614, 29);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(24, 21);
            this.lbInfo.TabIndex = 50;
            this.lbInfo.Text = "ⓘ";
            this.lbInfo.Click += new System.EventHandler(this.lbInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(516, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Version: BETA 2.1.3";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbLembrar
            // 
            this.cbLembrar.AutoSize = true;
            this.cbLembrar.Location = new System.Drawing.Point(72, 261);
            this.cbLembrar.Name = "cbLembrar";
            this.cbLembrar.Size = new System.Drawing.Size(67, 15);
            this.cbLembrar.Style = MetroFramework.MetroColorStyle.Purple;
            this.cbLembrar.TabIndex = 52;
            this.cbLembrar.Text = "Lembrar";
            this.cbLembrar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbLembrar.UseSelectable = true;
            this.cbLembrar.CheckedChanged += new System.EventHandler(this.cbLembrar_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 411);
            this.Controls.Add(this.cbLembrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelIcon);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.rbSummer);
            this.Controls.Add(this.rbMoon);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tbSim);
            this.Controls.Add(this.lbAcesso);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.mtShow);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Opacity = 0.96D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "6166";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbAcesso;
        private MetroFramework.Controls.MetroToggle mtShow;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbNome;
        private MetroFramework.Controls.MetroLabel lbSenha;
        private MetroFramework.Controls.MetroLabel lbNome;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btLogin;
        private MetroFramework.Controls.MetroButton btCancel;
        private MetroFramework.Controls.MetroRadioButton tbSim;
        private MetroFramework.Controls.MetroRadioButton rbMoon;
        private MetroFramework.Controls.MetroRadioButton rbSummer;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel panelIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroCheckBox cbLembrar;
    }
}