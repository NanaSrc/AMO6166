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
        int error = 0;
        string username;
        int hint = 1;
        public love lov;
        public Login log;
        ProgressBar pog;
        public Login(Login log)
        {
            InitializeComponent();
            this.log = log;
        }
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            tbNome.Focus();
            Focus();
            BringToFront();

            if (Properties.Settings.Default.lembrar)
            {
                tbNome.Text = Properties.Settings.Default.user;
                tbSenha.Text = Properties.Settings.Default.password;
                cbLembrar.Checked = true;

                if (VerificarAMO() == "Nana")
                    lbAcesso.Text = "Acessando como: Nana";
                else
                    lbAcesso.Text = "Acessando como: Marco";
            }

        }

        private void lbSenha_Click(object sender, EventArgs e)
        {
            if (hint >= 1)
            {
                if (VerificarAMO() == "Marco")
                {
                    MessageBox.Show("N + M . AMO " +
                    Environment.NewLine +
                    "Vê se não esquece na próxima, seu desgraçadinho!", ":eye:");
                    hint--;
                }
                else if (VerificarAMO() == "Nana")
                {
                    MessageBox.Show("N + M . AMO " +
                    Environment.NewLine +
                    "Como assim você não lembra? Foi você que programou isso, Anna", ":rage:");
                    hint--;
                }
                else
                {
                    MessageBox.Show("Nada aqui pra você! Tente novamente sendo o Marco ou a Nana talvez?", ";_;");
                }
            }
            else
                MessageBox.Show("Você já pegou sua dica!", ">)");
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

        private void btLogin_Click(object sender, EventArgs e)
        {
            user user = new user();
            user.Nome = tbNome.Text;
            user.Key = tbSenha.Text;
            string nome = VerificarAMO();


            if (VerificarAMO().Equals("Nana") || VerificarAMO().Equals("Marco"))
                user.Nomec = true;

            if (user.Key == "12080405.AMO" || user.Key == "04051208.AMO" || user.Key == ".")
                user.Keyc = true;

            if ((rbMoon.Checked && VerificarAMO() == "Marco") || (rbSummer.Checked && VerificarAMO() == "Nana"))
            {
                if (nome == "Nana" && rbSummer.Checked)
                    MessageBox.Show("Essa é a frase do Marco...", "Error 666");
                else if (nome == "Marco" && rbMoon.Checked)
                    MessageBox.Show("Essa é a frase da Nana...", "Error 444");

                user.Ama = false;
            }
            else if ((rbMoon.Checked && VerificarAMO() == "Nana") || (rbSummer.Checked && VerificarAMO() == "Marco"))
            {
                if (VerificarAMO() == "Nana")
                {
                    lbAcesso.Text = "Acessando como: Nana";

                    if (Properties.Settings.Default.lembrar)
                        rbMoon.Checked = true;
                }
                    
                else
                {
                    lbAcesso.Text = "Acessando como: Marco";

                    if (Properties.Settings.Default.lembrar)
                        rbSummer.Checked = true;
                }

                user.Ama = true;
            }

            if (user.Ama && user.Nomec && user.Keyc)
            {
                this.Hide();
                //lov = new love(username, user.Nome);
                pog = new ProgressBar(username, user.Nome);
                pog.ShowDialog();
                //lov.ShowDialog();
                this.Close();
            }
            else
            {
                if (tbNome.Text == "" && tbSenha.Text == "" && (!user.Ama || user.Ama))
                {
                    MessageBox.Show("Você não vai a lugar algum se deixar os campos em branco...", "Uh?");
                }
                else
                {
                     if (!rbMoon.Checked && !rbSummer.Checked)
                    {
                        MessageBox.Show("Esqueceu de algo?", ":eye:");
                    }
                    else
                    {
                        if (!user.Nomec)
                        {
                            MessageBox.Show("Apenas Marco e Naninha podem acessar.", "Vá embora");
                        }
                        else if (user.Keyc == false )
                        {
                            switch (error)
                            {
                                //Isso é pra você não errar muito  
                                case 0:
                                    MessageBox.Show("Acho que você escreveu errado. Tente novamente.", "Error 1");
                                    break;
                                case 1:
                                    MessageBox.Show("Continua errado... Presta atenção no que digita.", "Error 2");
                                    break;
                                case 2:
                                    MessageBox.Show("É, " + username + ", presumo que suas mãos estejam furadas hoje, uh? ", "Error 3");
                                    break;
                                case 3:
                                    if(username == "Nana")
                                        MessageBox.Show("Ok, se você continuar errando eu vou assumir que você não seja a " + username, ":rage: 4");
                                    if(username == "Marco")
                                        MessageBox.Show("Ok, se você continuar errando eu vou assumir que você não seja o " + username, ":rage: 4");
                                    break;
                                case 4:
                                    MessageBox.Show("Você não é nenhum dos AMO6166, desligue o programa antes que ele exploda.", "Autodestruição em 1");
                                    break;
                                case 5:
                                    if (username == "Nana")
                                        MessageBox.Show("Definitivamente você não é a " + username + ". Ao dar OK você morrerá instantaneamente. (Você foi avisado)", "Sequência de autodestruição iniciada");
                                    if (username == "Marco")
                                        MessageBox.Show("Definitivamente você não é o " + username + ". Ao dar OK você morrerá instantaneamente. (Você foi avisado)", "Sequência de autodestruição iniciada");
                                    Application.Exit();
                                    break;
                            }
                            error += 1;
                        }
                    }
                }
            }
        }

        private void rbSummer_CheckedChanged(object sender, EventArgs e)
        {
            if ((VerificarAMO() == "Marco") && rbSummer.Checked)
            {
                lbAcesso.Text = "Acessando como: Marco";
            }
            else
                lbAcesso.Text = "Acessando como: Anônimo";
            //username = "Marco";
        }

        private void rbMoon_CheckedChanged(object sender, EventArgs e)
        {
            if ((VerificarAMO() == "Nana") && rbMoon.Checked)
            {
                lbAcesso.Text = "Acessando como: Nana";
            }
            else
                lbAcesso.Text = "Acessando como: Anônimo";
            /*lbAcesso.Text = "Acessando como: Nana";
            username = "Nana";*/
        }

        private string VerificarAMO()
        {
            if (tbNome.Text == "nokia1666" || tbNome.Text == "Nokia1666" || tbNome.Text == "LisA" || tbNome.Text == "nana1666" || tbNome.Text == "Nana1666" || tbNome.Text == "Naninha1")
                return "Nana";
            if (tbNome.Text == "marco1666" || tbNome.Text == "Marco1666" || tbNome.Text == "IAmHated" || tbNome.Text == "hated1666" || tbNome.Text == "Hated1666" || tbNome.Text == "MarcoT")
                return "Marco";
            else
                return "Anônimo";
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            /*DialogResult resultado = MessageBox.Show("Deseja sair do nosso programinha?", ":(", MessageBoxButtons.YesNo);
            //I love you to the moon and back
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("That's all folks!", ">(");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Isso nunca é um adeus", ":)");
            }*/
            Application.Exit();
        }

        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btLogin_Click(sender, e);
            }
        }

        private void tbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btLogin_Click(sender, e);
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btLogin_Click(sender, e);
            }
        }

        private void rbMoon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btLogin_Click(sender, e);
            }
        }

        private void rbSummer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btLogin_Click(sender, e);
            }
        }

        private void lbAcesso_TextChanged(object sender, EventArgs e)
        {
            if (lbAcesso.Text == "Acessando como: Nana")
                username = "Nana";
            else if (lbAcesso.Text == "Acessando como: Marco")
                username = "Marco";
            else
                username = "pessoa anônima";
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            if (VerificarAMO() == "Marco")
            {
                lbAcesso.Text = "Acessando como: Marco";
            }
            else if(VerificarAMO() == "Nana")
            {
                lbAcesso.Text = "Acessando como: Nana";
            }
            else
                lbAcesso.Text = "Acessando como: Anônimo";
        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lbInfo_Click(object sender, EventArgs e)
        {
            //Abrir form de info
            Info info = new Info();
            info.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            //Teste1
            System.Diagnostics.Process start = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C start https://github.com/AMO6166";
            start.StartInfo = startInfo;
            start.Start();
        }

        private void cbLembrar_CheckedChanged(object sender, EventArgs e)
        {   

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cbLembrar.Checked)
            {
                Properties.Settings.Default.lembrar = true;
                Properties.Settings.Default.user = tbNome.Text;
                Properties.Settings.Default.password = tbSenha.Text;
            }
            else
            {
                Properties.Settings.Default.lembrar = false;
            }
        }
    }
}
