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
            Active(btMenu);
            cbTheme.SelectedIndex = 0;
            UpdateStyles();
            Focus();
            BringToFront();

            btDiary.Text = "☆ " +
                username +
                "'s diary";

            pic.BackgroundImage = Properties.Resources.US2;
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
            if (btToDo.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btToDo);
                ToDo lisa = new ToDo();
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
            if (bt != btMenu)
                pic.Visible = false;
            else
                pic.Visible = true;

            DefaultColor();

            if(bt != btDiary)
                pic.BackgroundImage = Properties.Resources.US2;

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

            btToDo.FlatAppearance.BorderColor = corB;
            btToDo.ForeColor = cor;
            btToDo.FlatAppearance.BorderSize = 1;
            btToDo.Text = "☆ To do list";

            btShop.FlatAppearance.BorderColor = corB;
            btShop.ForeColor = cor;
            btShop.FlatAppearance.BorderSize = 1;
            btShop.Text = "☆ Shop list";

            btBank.FlatAppearance.BorderColor = corB;
            btBank.ForeColor = cor;
            btBank.FlatAppearance.BorderSize = 1;
            btBank.Text = "☆ Mini bank";

            btDiary.FlatAppearance.BorderColor = corB;
            btDiary.ForeColor = cor;
            btDiary.FlatAppearance.BorderSize = 1;
            btDiary.Text = "☆ " +
                username +
                "'s diary";

            btAlbum.FlatAppearance.BorderColor = corB;
            btAlbum.ForeColor = cor;
            btAlbum.FlatAppearance.BorderSize = 1;
            btAlbum.Text = "☆ Album";

            btSite.FlatAppearance.BorderColor = corB;
            btSite.ForeColor = cor;
            btSite.FlatAppearance.BorderSize = 1;
            btSite.Text = "☆ amo6166.com";

            btNotes.FlatAppearance.BorderColor = corB;
            btNotes.ForeColor = cor;
            btNotes.FlatAppearance.BorderSize = 1;
            btNotes.Text = "☆ Notes";

            btCalendar.FlatAppearance.BorderColor = corB;
            btCalendar.ForeColor = cor;
            btCalendar.FlatAppearance.BorderSize = 1;
            btCalendar.Text = "☆ Calendar";

            btBirthdays.FlatAppearance.BorderColor = corB;
            btBirthdays.ForeColor = cor;
            btBirthdays.FlatAppearance.BorderSize = 1;
            btBirthdays.Text = "☆ Birthdays";

            btFireplace.FlatAppearance.BorderColor = corB;
            btFireplace.ForeColor = cor;
            btFireplace.FlatAppearance.BorderSize = 1;
            btFireplace.Text = "☆ ";

            btMenu.FlatAppearance.BorderColor = corB;
            btMenu.ForeColor = cor;
            btMenu.FlatAppearance.BorderSize = 1;
            btMenu.Text = "☆ Menu";

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
            if (btShop.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                btShop.Text = "Shop list";
                Active(btShop);
                Shop marco = new Shop();
                PanelShow(marco);
                //SelectText(btMarcoPage);
            }
        }

        private void btGame_Click(object sender, EventArgs e)
        {
            if (btBank.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btBank);
                Bank game = new Bank();
                PanelShow(game);
                //SelectText(btGame);
            }
        }

        private void btTerm_Click(object sender, EventArgs e)
        {
            if (btDiary.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btDiary);
                panel.BackgroundImage = Properties.Resources.diary;
                Diary term = new Diary(username);
                PanelShow(term);
                //SelectText(btTerm);
            }
        }

        private void btGallery_Click(object sender, EventArgs e)
        {
            if (btAlbum.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btAlbum);
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
            if (btNotes.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btNotes);
                Painting paint = new Painting();
                PanelShow(paint);
                //SelectText(btPainting);
            }
        }

        private void btMovie_Click(object sender, EventArgs e)
        {
            if (btCalendar.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btCalendar);
                Movie movie = new Movie();
                PanelShow(movie);
                //SelectText(btMovie);
            }
        }

        private void btLibrary_Click(object sender, EventArgs e)
        {
            if (btBirthdays.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                Active(btBirthdays);
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
            if (btMenu.FlatAppearance.BorderColor != Color.FromArgb(152, 63, 104))
            {
                btMenu.Text = "Menu";
                Active(btMenu);
                panel.Controls.Clear();
                //SelectText(btMain);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Active(btExit);
            //SelectText(btMain);
            DialogResult resultado = MessageBox.Show("Exit?", ":(", MessageBoxButtons.YesNo);
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

                btMenu.ForeColor = Color.FromArgb(31, 29, 39);
                btMenu.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btToDo.ForeColor = Color.FromArgb(31, 29, 39);
                btToDo.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btToDo.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btToDo.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btShop.ForeColor = Color.FromArgb(31, 29, 39);
                btShop.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btShop.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btShop.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btDiary.ForeColor = Color.FromArgb(31, 29, 39);
                btDiary.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btDiary.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btDiary.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btNotes.ForeColor = Color.FromArgb(31, 29, 39);
                btNotes.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btNotes.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btNotes.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btCalendar.ForeColor = Color.FromArgb(31, 29, 39);
                btCalendar.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btCalendar.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btCalendar.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btAlbum.ForeColor = Color.FromArgb(31, 29, 39);
                btAlbum.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btAlbum.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btAlbum.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btBank.ForeColor = Color.FromArgb(31, 29, 39);
                btBank.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btBank.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btBank.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btSite.ForeColor = Color.FromArgb(31, 29, 39);
                btSite.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btSite.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btSite.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

                btBirthdays.ForeColor = Color.FromArgb(31, 29, 39);
                btBirthdays.FlatAppearance.BorderColor = Color.FromArgb(45, 41, 56);
                btBirthdays.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 215, 255);
                btBirthdays.FlatAppearance.MouseDownBackColor = Color.FromArgb(199, 179, 187);

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
                pic.BackgroundImage = Properties.Resources.US2;
                //metroLabel1.ForeColor = Color.FromArgb(31, 29, 39);
                //metroLabel2.ForeColor = Color.FromArgb(31, 29, 39);
                metroLabel3.ForeColor = Color.FromArgb(64, 64, 64);
                metroLabel4.ForeColor = Color.FromArgb(183, 161, 255);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.FromArgb(183, 161, 255);
                label3.ForeColor = Color.DarkGray;

                btMenu.ForeColor = Color.FromArgb(224, 215, 255);
                btMenu.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btToDo.ForeColor = Color.FromArgb(224, 215, 255);
                btToDo.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btToDo.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btToDo.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btShop.ForeColor = Color.FromArgb(224, 215, 255);
                btShop.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btShop.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btShop.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btDiary.ForeColor = Color.FromArgb(224, 215, 255);
                btDiary.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btDiary.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btDiary.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btNotes.ForeColor = Color.FromArgb(224, 215, 255);
                btNotes.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btNotes.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btNotes.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btCalendar.ForeColor = Color.FromArgb(224, 215, 255);
                btCalendar.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btCalendar.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btCalendar.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btAlbum.ForeColor = Color.FromArgb(224, 215, 255);
                btAlbum.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btAlbum.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btAlbum.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btBank.ForeColor = Color.FromArgb(224, 215, 255);
                btBank.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btBank.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btBank.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btSite.ForeColor = Color.FromArgb(224, 215, 255);
                btSite.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btSite.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btSite.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

                btBirthdays.ForeColor = Color.FromArgb(224, 215, 255);
                btBirthdays.FlatAppearance.BorderColor = Color.FromArgb(183, 161, 255);
                btBirthdays.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 29, 39);
                btBirthdays.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 7, 16);

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

        private void pic_Click(object sender, EventArgs e)
        {

        }
    }
}
