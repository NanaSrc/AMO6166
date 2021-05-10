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
        //Seria bom fazer um botão de menu
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

        }

        private void btTerminal_Click(object sender, EventArgs e)
        {
            DefaultColor();
            btTerminal.BackColor = Color.FromArgb(45, 41, 56);
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
            DefaultColor();
            btNanaDiario.BackColor = Color.FromArgb(45, 41, 56);
        }

        private void btMarcoDiario_Click(object sender, EventArgs e)
        {
            DefaultColor();
            btMarcoDiario.BackColor = Color.FromArgb(45, 41, 56);
        }

        private void btAMO_Click(object sender, EventArgs e)
        {
            DefaultColor();
            btAMO.BackColor = Color.FromArgb(45, 41, 56);
            Profile profile = new Profile(username);
            PanelShow(profile);
        }

        private void btGaleria_Click(object sender, EventArgs e)
        {
            DefaultColor();
            btGaleria.BackColor = Color.FromArgb(45, 41, 56);
        }

        private void btSair_Click(object sender, EventArgs e)
        {
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
            DefaultColor();
            btMenu.BackColor = Color.FromArgb(45, 41, 56);

            panel.Controls.Clear();
        }
    }
}
