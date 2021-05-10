using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace amo6166
{
    public partial class Profile : MetroFramework.Forms.MetroForm
    {
        string username;
        public Profile(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            lbNome.Text = username;
        }
    }
}
