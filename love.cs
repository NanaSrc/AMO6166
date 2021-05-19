using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace amo6166
{
    public partial class love : MetroFramework.Forms.MetroForm
    {
        string username;
        string login;
        public love()
        {
            InitializeComponent();
        }
        public love(string nome, string login)
        {
            InitializeComponent();
            username = nome;
            this.login = login;
        }

        private void love_Load(object sender, EventArgs e)
        {
            lbUser.Text = username;
            lbLogin.Text = login;
            Active(btMain);
            cbTheme.SelectedIndex = 0;
        }

        /*
        private void DefaultColor()
        {
            btTerminal.BackColor = Color.FromArgb(31, 29, 39);
            btNanaDiario.BackColor = Color.FromArgb(31, 29, 39);
            btMarcoDiario.BackColor = Color.FromArgb(31, 29, 39);
            btMenu.BackColor = Color.FromArgb(31, 29, 39);
            btAMO.BackColor = Color.FromArgb(31, 29, 39);
            btGaleria.BackColor = Color.FromArgb(31, 29, 39);
            btSite.BackColor = Color.FromArgb(31, 29, 39);
            btGame.BackColor = Color.FromArgb(31, 29, 39);
        }
        */

        private void btSair_Click(object sender, EventArgs e)
        {
            //Cor(btSair);
            DialogResult resultado = MessageBox.Show("Deseja sair do nosso programinha?", ":(", MessageBoxButtons.YesNo);
            //I love you to the moon and back
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("That's all folks!", ">(");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Isso nunca é um adeus", ":)");
            }
        }

        private void PanelShow(Form form)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            this.panel.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            //Cor(btMenu);
            panel.Controls.Clear();
        }

        /*
        private void Cor(Button bt)
        {
            DefaultColor();
            bt.BackColor = Color.FromArgb(45, 41, 56);
        }
        */

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
            this.Close();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process start = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C start https://github.com/AMO6166";
            start.StartInfo = startInfo;
            start.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }

        private void lbInfo_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }

        private void btNanaPage_Click(object sender, EventArgs e)
        {
            Active(btNanaPage);
            Nana nana = new Nana();
            PanelShow(nana);
        }

        /*private void btInfo_Click(object sender, EventArgs e)
        {
            Cor(btInfo);
            Info info = new Info();
            info.Movable = false;
            info.MaximizeBox = false;
            info.MinimizeBox = false;
            info.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            info.Style = MetroFramework.MetroColorStyle.Purple;
            info.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            info.ControlBox = false;
            PanelShow(info);
        }*/

        private void Active(Button bt)
        {
            DefaultColor();
            bt.FlatAppearance.BorderColor = Color.FromArgb(152, 63, 104);
            bt.ForeColor = Color.FromArgb(183, 161, 255);
            bt.FlatAppearance.BorderSize = 2;

        }

        private void DefaultColor()
        {
            Color cor = new Color();
            cor = Color.FromArgb(206, 191, 255);
            Color corB = new Color();
            corB = Color.FromArgb(183, 161, 255);

            btNanaPage.FlatAppearance.BorderColor = corB;
            btNanaPage.ForeColor = cor;
            btNanaPage.FlatAppearance.BorderSize = 1;

            btMarcoPage.FlatAppearance.BorderColor = corB;
            btMarcoPage.ForeColor = cor;
            btMarcoPage.FlatAppearance.BorderSize = 1;

            btGame.FlatAppearance.BorderColor = corB;
            btGame.ForeColor = cor;
            btGame.FlatAppearance.BorderSize = 1;

            btTerm.FlatAppearance.BorderColor = corB;
            btTerm.ForeColor = cor;
            btTerm.FlatAppearance.BorderSize = 1;

            btGallery.FlatAppearance.BorderColor = corB;
            btGallery.ForeColor = cor;
            btGallery.FlatAppearance.BorderSize = 1;

            btSite.FlatAppearance.BorderColor = corB;
            btSite.ForeColor = cor;
            btSite.FlatAppearance.BorderSize = 1;

            btPainting.FlatAppearance.BorderColor = corB;
            btPainting.ForeColor = cor;
            btPainting.FlatAppearance.BorderSize = 1;

            btMovie.FlatAppearance.BorderColor = corB;
            btMovie.ForeColor = cor;
            btMovie.FlatAppearance.BorderSize = 1;

            btLibrary.FlatAppearance.BorderColor = corB;
            btLibrary.ForeColor = cor;
            btLibrary.FlatAppearance.BorderSize = 1;

            btFireplace.FlatAppearance.BorderColor = corB;
            btFireplace.ForeColor = cor;
            btFireplace.FlatAppearance.BorderSize = 1;

            btMain.FlatAppearance.BorderColor = corB;
            btMain.ForeColor = cor;
            btMain.FlatAppearance.BorderSize = 1;

            btExit.FlatAppearance.BorderColor = corB;
            btExit.ForeColor = cor;
            btExit.FlatAppearance.BorderSize = 1;

            btProfile.FlatAppearance.BorderColor = cor;
            btProfile.ForeColor = corB;
            btExit.FlatAppearance.BorderSize = 1;
        }

        private void btMarcoPage_Click(object sender, EventArgs e)
        {
            Active(btMarcoPage);
            Marco marco = new Marco();
            PanelShow(marco);
        }

        private void btGame_Click(object sender, EventArgs e)
        {
            Active(btGame);
            Game game = new Game();
            PanelShow(game);
        }

        private void btTerm_Click(object sender, EventArgs e)
        {
            Active(btTerm);
            Terminal term = new Terminal(username);
            PanelShow(term);
        }

        private void btGallery_Click(object sender, EventArgs e)
        {
            Active(btGallery);
            Galeria gallery = new Galeria();
            PanelShow(gallery);
        }

        private void btSite_Click(object sender, EventArgs e)
        {
            Active(btSite);
            Site site = new Site();
            PanelShow(site);
        }

        private void btPainting_Click(object sender, EventArgs e)
        {
            Active(btPainting);
            panel.Controls.Clear();
        }

        private void btMovie_Click(object sender, EventArgs e)
        {
            Active(btMovie);
            panel.Controls.Clear();
        }

        private void btLibrary_Click(object sender, EventArgs e)
        {
            Active(btLibrary);
            panel.Controls.Clear();
        }

        private void btFireplace_Click(object sender, EventArgs e)
        {
            Active(btFireplace);
            panel.Controls.Clear();
        }

        private void btMain_Click(object sender, EventArgs e)
        {
            Active(btMain);
            panel.Controls.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Active(btExit);
            DialogResult resultado = MessageBox.Show("Deseja sair do nosso programinha?", ":(", MessageBoxButtons.YesNo);
            //I love you to the moon and back
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("That's all folks!", ">(");
                Application.Exit();
            }
        }

        private void btProfile_Click(object sender, EventArgs e)
        {
            Active(btProfile);
            Profile profile = new Profile(username);
            PanelShow(profile);
        }

        private void cbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string theme = cbTheme.Text;
            DetectStyle(theme);
            UpdateStyles();
        }
        public void DetectStyle(string theme)
        {
            switch (theme)
            {
                case "Green":
                    Style = MetroFramework.MetroColorStyle.Green;
                    break;
                case "Black":
                    Style = MetroFramework.MetroColorStyle.Black;
                    break;
                case "White":
                    Style = MetroFramework.MetroColorStyle.White;
                    break;
                case "Blue":
                    Style = MetroFramework.MetroColorStyle.Blue;
                    break;
                case "Yellow":
                    Style = MetroFramework.MetroColorStyle.Yellow;
                    break;
                case "Red":
                    Style = MetroFramework.MetroColorStyle.Red;
                    break;
                case "Orange":
                    Style = MetroFramework.MetroColorStyle.Orange;
                    break;
                case "Teal":
                    Style = MetroFramework.MetroColorStyle.Teal;
                    break;
                case "Lime":
                    Style = MetroFramework.MetroColorStyle.Lime;
                    break;
                case "Silver":
                    Style = MetroFramework.MetroColorStyle.Magenta;
                    break;
                case "Pink":
                    Style = MetroFramework.MetroColorStyle.Pink;
                    break;
                case "Brown":
                    Style = MetroFramework.MetroColorStyle.Brown;
                    break;
                case "Purple":
                    Style = MetroFramework.MetroColorStyle.Purple;
                    break;
                case "Magenta":
                    Style = MetroFramework.MetroColorStyle.Magenta;
                    break;
            }
        }

        private void rbDark_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTheme(MetroFramework.MetroThemeStyle.Dark);
        }

        private void ChangeTheme(MetroFramework.MetroThemeStyle theme)
        {
            Theme = theme;
            rbDark.Theme = theme;
            rbLight.Theme = theme;
            metroLabel1.Theme = theme;
            metroLabel2.Theme = theme;
            metroLabel3.Theme = theme;
            metroLabel4.Theme = theme;
            lbLogin.Theme = theme; ;
            lbUser.Theme = theme;
            cbTheme.Theme = theme;
            UpdateStyles();
        }

        private void rbLight_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTheme(MetroFramework.MetroThemeStyle.Light);
        }
    }
}
