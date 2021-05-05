using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace marco
{
    public partial class Terminal : Form
    {
        public Terminal()
        {
            InitializeComponent();
        }

        private void tbTerminalzinho_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTerminalzinho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (tbComandos.Text.Contains("exit"))
                {
                    Application.Exit();
                }
            }
        }
    }
}
