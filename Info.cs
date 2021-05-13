using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace amo6166
{
    public partial class Info : MetroFramework.Forms.MetroForm
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {

        }

        private void cbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIdioma.Text == "English")
            {
                lbText.Visible = true;
                lbInfo.Visible = false;
                lbIdioma.Visible = false;
                lbLanguage.Visible = true;
            }
            else if (cbIdioma.Text == "Português (Brasil)")
            {
                lbText.Visible = false;
                lbInfo.Visible = true;
                lbIdioma.Visible = true;
                lbLanguage.Visible = false;
            }
        }
    }
}
