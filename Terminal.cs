using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace amo6166
{
    public partial class Terminal : MetroFramework.Forms.MetroForm
    {
        string username;
        public Terminal(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void tbTerminalzinho_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTerminalzinho_KeyPress(object sender, KeyPressEventArgs e)
        {
            string comando = tbTerminalzinho.Text;
            if (e.KeyChar == (char)13)
            {
                if (tbTerminalzinho.Text.Contains("/exit"))
                {
                    Application.Exit();
                }

                if (comando.Contains("/love"))
                {
                    tbTerminalzinho.Text = comando + string.Format("{0}I love you to the moon and back {0}Nana says:", Environment.NewLine);
                }

                if (comando.Contains("cls"))
                {
                    tbTerminalzinho.Text = "";
                }    
            }
        }

        private void Terminal_Load(object sender, EventArgs e)
        {
            if (username == "Nana")
            {
                tbTerminalzinho.BackColor = Color.FromArgb(31, 29, 39);
                tbTerminalzinho.ForeColor = Color.FromArgb(183, 161, 255); 
            }
        }
    }
}
