using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace marco
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
            Terminal term = new Terminal();
            love lo = new love();
            term.TopLevel = false;
            term.AutoScroll = true;
            lo.panel1.Controls.Add(term);
            term.FormBorderStyle = FormBorderStyle.None;
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
