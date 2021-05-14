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

            if(username == "Nana")
            {
                loading.Style = MetroFramework.MetroColorStyle.Red;
            }
            else if (username == "Marco")
            {
                loading.Style = MetroFramework.MetroColorStyle.Teal;
            }
            else
            {
                loading.Style = MetroFramework.MetroColorStyle.Purple;
            }
        }

        private void btTerminal_Click(object sender, EventArgs e)
        {
            Cor(btTerminal);
            Terminal term = new Terminal(username);
            PanelShow(term);
        }

        private void DefaultColor()
        {
            btTerminal.BackColor = Color.FromArgb(31, 29, 39);
            btNanaDiario.BackColor = Color.FromArgb(31, 29, 39);
            btMarcoDiario.BackColor = Color.FromArgb(31, 29, 39);
            btMenu.BackColor = Color.FromArgb(31, 29, 39);
            btAMO.BackColor = Color.FromArgb(31, 29, 39);
            btGaleria.BackColor = Color.FromArgb(31, 29, 39);
        }

        private void btNanaDiario_Click(object sender, EventArgs e)
        {
            
            loading.Value = 100;
            Cor(btNanaDiario);
            Nana nana = new Nana();
            PanelShow(nana);
        }

        private void btMarcoDiario_Click(object sender, EventArgs e)
        {
            Cor(btMarcoDiario);
            Marco marco = new Marco();
            PanelShow(marco);
        }

        private void btAMO_Click(object sender, EventArgs e)
        {
            Cor(btAMO);
            Profile profile = new Profile(username);
            PanelShow(profile);
        }

        private void btGaleria_Click(object sender, EventArgs e)
        {
            Cor(btMenu);
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Cor(btSair);
            Application.Exit();
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
            Cor(btMenu);
            panel.Controls.Clear();
        }

        private void Cor(Button bt)
        {
            DefaultColor();
            bt.BackColor = Color.FromArgb(45, 41, 56);
        }

        private void btInfo_Click(object sender, EventArgs e)
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
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
            this.Close();
        }
    }
}
