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
            UpdateStyles();
            Focus();
            BringToFront();

            if (username == "Marco")
                ChangeTheme(MetroFramework.MetroThemeStyle.Light);
            else if (username == "Lisa")
                ChangeTheme(MetroFramework.MetroThemeStyle.Dark);
        }

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

        /*private void btMenu_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
        }*/

        private void btLogout_Click(object sender, EventArgs e)
        {
            Hide();
            Login log = new Login();
            log.ShowDialog();
            log.BringToFront();
            Close();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process start = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C start https://github.com/Nanacore/";
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
            if (btLisaPage.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btLisaPage);
                Lisa lisa = new Lisa();
                PanelShow(lisa);
            }
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
            if(Theme == MetroFramework.MetroThemeStyle.Dark)
                bt.ForeColor = Color.FromArgb(183, 161, 255);
            bt.FlatAppearance.BorderSize = 2;
            bt.Text = bt.Text + " ☆";
        }

        private void DefaultColor()
        {
            Color cor = new Color();
            Color corB = new Color();

            if (Theme == MetroFramework.MetroThemeStyle.Light)
            {
                cor = Color.FromArgb(31, 29, 39);
                corB = Color.FromArgb(45, 41, 56);
            }
            else
            {
                cor = Color.FromArgb(206, 191, 255);
                corB = Color.FromArgb(183, 161, 255);
            }

            btLisaPage.FlatAppearance.BorderColor = corB;
            btLisaPage.ForeColor = cor;
            btLisaPage.FlatAppearance.BorderSize = 1;
            btLisaPage.Text = "☆ Lisa's computer";

            btMarcoPage.FlatAppearance.BorderColor = corB;
            btMarcoPage.ForeColor = cor;
            btMarcoPage.FlatAppearance.BorderSize = 1;
            btMarcoPage.Text = "☆ Marco's computer";

            btGame.FlatAppearance.BorderColor = corB;
            btGame.ForeColor = cor;
            btGame.FlatAppearance.BorderSize = 1;
            btGame.Text = "☆ A simple game";

            btTerm.FlatAppearance.BorderColor = corB;
            btTerm.ForeColor = cor;
            btTerm.FlatAppearance.BorderSize = 1;
            btTerm.Text = "☆ Console text";

            btGallery.FlatAppearance.BorderColor = corB;
            btGallery.ForeColor = cor;
            btGallery.FlatAppearance.BorderSize = 1;
            btGallery.Text = "☆ Wonderful gallery";

            btSite.FlatAppearance.BorderColor = corB;
            btSite.ForeColor = cor;
            btSite.FlatAppearance.BorderSize = 1;
            btSite.Text = "☆ amo6166.com";

            btPainting.FlatAppearance.BorderColor = corB;
            btPainting.ForeColor = cor;
            btPainting.FlatAppearance.BorderSize = 1;
            btPainting.Text = "☆ Painting room";

            btMovie.FlatAppearance.BorderColor = corB;
            btMovie.ForeColor = cor;
            btMovie.FlatAppearance.BorderSize = 1;
            btMovie.Text = "☆ Movie room";

            btLibrary.FlatAppearance.BorderColor = corB;
            btLibrary.ForeColor = cor;
            btLibrary.FlatAppearance.BorderSize = 1;
            btLibrary.Text = "☆ A library";

            btFireplace.FlatAppearance.BorderColor = corB;
            btFireplace.ForeColor = cor;
            btFireplace.FlatAppearance.BorderSize = 1;
            btFireplace.Text = "☆ Warm fireplace";

            btMain.FlatAppearance.BorderColor = corB;
            btMain.ForeColor = cor;
            btMain.FlatAppearance.BorderSize = 1;
            btMain.Text = "☆ Main hall";

            btExit.FlatAppearance.BorderColor = corB;
            btExit.ForeColor = cor;
            btExit.FlatAppearance.BorderSize = 1;
            btExit.Text = "☆ Exit light";

            btProfile.FlatAppearance.BorderColor = cor;
            btProfile.ForeColor = corB;
            btProfile.FlatAppearance.BorderSize = 1;
            btProfile.Text = "Profile";
        }

        private void btMarcoPage_Click(object sender, EventArgs e)
        {
            if (btMarcoPage.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                btMarcoPage.Text = "Marco's computer";
                Active(btMarcoPage);
                Marco marco = new Marco();
                PanelShow(marco);
                //SelectText(btMarcoPage);
            }
        }

        private void btGame_Click(object sender, EventArgs e)
        {
            if (btGame.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btGame);
                Game game = new Game();
                PanelShow(game);
                //SelectText(btGame);
            }
        }

        private void btTerm_Click(object sender, EventArgs e)
        {
            if (btTerm.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btTerm);
                Terminal term = new Terminal(username);
                PanelShow(term);
                //SelectText(btTerm);
            }
        }

        private void btGallery_Click(object sender, EventArgs e)
        {
            if (btGallery.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btGallery);
                Galeria gallery = new Galeria();
                PanelShow(gallery);
                //SelectText(btGallery);
            }
        }

        private void btSite_Click(object sender, EventArgs e)
        {
            if (btSite.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btSite);
                Site site = new Site();
                PanelShow(site);
                //SelectText(btSite);
            }
        }

        private void btPainting_Click(object sender, EventArgs e)
        {
            if (btPainting.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btPainting);
                Painting paint = new Painting();
                PanelShow(paint);
                //SelectText(btPainting);
            }
        }

        private void btMovie_Click(object sender, EventArgs e)
        {
            if (btMovie.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btMovie);
                Movie movie = new Movie();
                PanelShow(movie);
                //SelectText(btMovie);
            }
        }

        private void btLibrary_Click(object sender, EventArgs e)
        {
            if (btLibrary.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btLibrary);
                Library lib = new Library();
                PanelShow(lib);
                //SelectText(btLibrary);
            }
        }

        private void btFireplace_Click(object sender, EventArgs e)
        {
            if (btFireplace.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btFireplace);
                Fireplace fire = new Fireplace();
                PanelShow(fire);
                //SelectText(btFireplace);
            }
        }

        private void btMain_Click(object sender, EventArgs e)
        {
            if (btMain.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                btMain.Text = "Main hall";
                Active(btMain);
                panel.Controls.Clear();
                //SelectText(btMain);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Active(btExit);
            //SelectText(btMain);
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
            if (btProfile.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btProfile);
                Profile profile = new Profile(username);
                PanelShow(profile);
            }
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
            //if (!rbDark.Checked)
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

            if(theme == MetroFramework.MetroThemeStyle.Light)
            {
                panel.BackgroundImage = Properties.Resources.Light_Theme;
                metroLabel3.ForeColor = Color.Black;
                metroLabel4.ForeColor = Color.FromArgb(31, 29, 39);
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.FromArgb(31, 29, 39);
                label3.ForeColor = Color.Black;

                btMain.ForeColor = Color.FromArgb(31, 29, 39);
                btMain.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btMain.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btMain.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btLisaPage.ForeColor = Color.FromArgb(31, 29, 39);
                btLisaPage.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btLisaPage.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btLisaPage.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btMarcoPage.ForeColor = Color.FromArgb(31, 29, 39);
                btMarcoPage.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btMarcoPage.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btMarcoPage.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btTerm.ForeColor = Color.FromArgb(31, 29, 39);
                btTerm.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btTerm.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btTerm.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btPainting.ForeColor = Color.FromArgb(31, 29, 39);
                btPainting.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btPainting.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btPainting.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btMovie.ForeColor = Color.FromArgb(31, 29, 39);
                btMovie.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btMovie.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btMovie.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btGallery.ForeColor = Color.FromArgb(31, 29, 39);
                btGallery.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btGallery.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btGallery.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btGame.ForeColor = Color.FromArgb(31, 29, 39);
                btGame.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btGame.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btGame.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btSite.ForeColor = Color.FromArgb(31, 29, 39);
                btSite.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btSite.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btSite.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btLibrary.ForeColor = Color.FromArgb(31, 29, 39);
                btLibrary.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btLibrary.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btLibrary.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btFireplace.ForeColor = Color.FromArgb(31, 29, 39);
                btFireplace.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btFireplace.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btFireplace.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btExit.ForeColor = Color.FromArgb(31, 29, 39);
                btExit.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btProfile.ForeColor = Color.FromArgb(31, 29, 39);
                btProfile.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                lbUser.ForeColor = Color.FromArgb(31, 29, 39);
                lbLogin.ForeColor = Color.FromArgb(31, 29, 39);
                lbInfo.ForeColor = Color.Black;
                btLogout.ForeColor = Color.FromArgb(152, 32, 250);

                //Light theme
            }
            else if (theme == MetroFramework.MetroThemeStyle.Dark)
            {
                panel.BackgroundImage = Properties.Resources.US2;
                //metroLabel1.ForeColor = Color.FromArgb(31, 29, 39);
                //metroLabel2.ForeColor = Color.FromArgb(31, 29, 39);
                metroLabel3.ForeColor = Color.FromArgb(64, 64, 64);
                metroLabel4.ForeColor = Color.FromArgb(183, 161, 255);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.FromArgb(183, 161, 255);
                label3.ForeColor = Color.DarkGray;

                btMain.ForeColor = Color.FromArgb(224, 215, 255);
                btMain.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btMain.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btMain.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btLisaPage.ForeColor = Color.FromArgb(224, 215, 255);
                btLisaPage.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btLisaPage.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btLisaPage.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btMarcoPage.ForeColor = Color.FromArgb(224, 215, 255);
                btMarcoPage.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btMarcoPage.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btMarcoPage.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btTerm.ForeColor = Color.FromArgb(224, 215, 255);
                btTerm.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btTerm.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btTerm.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btPainting.ForeColor = Color.FromArgb(224, 215, 255);
                btPainting.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btPainting.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btPainting.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btMovie.ForeColor = Color.FromArgb(224, 215, 255);
                btMovie.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btMovie.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btMovie.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btGallery.ForeColor = Color.FromArgb(224, 215, 255);
                btGallery.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btGallery.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btGallery.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btGame.ForeColor = Color.FromArgb(224, 215, 255);
                btGame.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btGame.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btGame.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btSite.ForeColor = Color.FromArgb(224, 215, 255);
                btSite.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btSite.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btSite.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btLibrary.ForeColor = Color.FromArgb(224, 215, 255);
                btLibrary.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btLibrary.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btLibrary.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btFireplace.ForeColor = Color.FromArgb(224, 215, 255);
                btFireplace.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btFireplace.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btFireplace.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btExit.ForeColor = Color.FromArgb(224, 215, 255);
                btExit.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btProfile.ForeColor = Color.FromArgb(183, 161, 255);
                btProfile.FlatAppearance.BorderColor = Color.FromArgb(206, 191, 255);
                btProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                lbUser.ForeColor = Color.White;
                lbLogin.ForeColor = Color.White;
                lbInfo.ForeColor = Color.DarkGray;
                btLogout.ForeColor = Color.FromArgb(183, 161, 255);

                //Dark theme
            }
        }

        private void rbLight_CheckedChanged(object sender, EventArgs e)
        {
            //if (!rbLight.Checked)
                ChangeTheme(MetroFramework.MetroThemeStyle.Light);

        }

        private void SelectText(Button bt)
        {
            bt.Text = bt.Text + " ☆";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelIcon_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
