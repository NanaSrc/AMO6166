using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace amo6166
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void lbSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descobriu um easter egg :eye:. A chave é seu niver + o meu...", "Surpresa!");
        }

        private void mtShow_CheckedChanged(object sender, EventArgs e)
        {
            if (mtShow.Checked)
            {
                tbSenha.PasswordChar = '\0';
            }
            else
            {
                tbSenha.PasswordChar = '♥';
            }
        }


    }
}
