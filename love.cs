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
        public love()
        {
            InitializeComponent();
        }
        public love(string nome)
        {
            InitializeComponent();
            //lbNome.Text = nome;
        }

        private void love_Load(object sender, EventArgs e)
        {
            
        }

        private void btTerminal_Click(object sender, EventArgs e)
        {
            /*PanelPrincipal.Controls.Clear();
            Carros novo = new Carros();
            novo.TopLevel = false;
            PanelPrincipal.Controls.Add(novo);
            novo.Show();*/

            //term.AutoScroll = true;
            //term.FormBorderStyle = FormBorderStyle.None;

            panel1.Controls.Clear();
            Terminal term = new Terminal();
            term.TopLevel = false;
            panel1.Controls.Add(term);
            term.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //panel1 = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile nanarco = new Profile();
            nanarco.Show();
        }
    }
}
