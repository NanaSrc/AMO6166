using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace amo6166
{
    //Testing new local
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
        }

        private void lbSenha_Click(object sender, EventArgs e)
        {
            
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

            if (VerificarAMO().Equals("Lisa") || VerificarAMO().Equals("Marco"))
                user.Nomec = true;

            if (user.Key == "12080405.AMO" || user.Key == "04051208.AMO")
                user.Keyc = true;

            if ((rbMoon.Checked && VerificarAMO() == "Marco") || (rbSummer.Checked && VerificarAMO() == "Lisa"))
            {
                if (nome == "Lisa" && rbSummer.Checked)
                    MessageBox.Show("Essa é a frase do Marco...", "Error 666");
                else if (nome == "Marco" && rbMoon.Checked)
                    MessageBox.Show("Essa é a frase da Lisa...", "Error 444");

                user.Ama = false;
            }
            else if ((rbMoon.Checked && VerificarAMO() == "Lisa") || (rbSummer.Checked && VerificarAMO() == "Marco"))
            {
                if (VerificarAMO() == "Lisa")
                {
                    lbAcesso.Text = "Acessando como: Lisa";
                }
                    
                else
                {
                    lbAcesso.Text = "Acessando como: Marco";
                }

                user.Ama = true;
            }

            if (user.Ama && user.Nomec && user.Keyc)
            {

                Hide();
                //lov = new love(username, user.Nome);
                pog = new ProgressBar(username, user.Nome);
                pog.ShowDialog();
            
                //Remember();
                Close();
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
                            MessageBox.Show("Apenas Marco e Lisa podem acessar.", "Vá embora");
                        }
                        else if (user.Keyc == false )
                        {
                            switch (error)
                            {
                                //Isso é pra você não errar muito  
                                case 0:
                                    MessageBox.Show("Acho que você escreveu errado. Tente novamente.", "Error 1");
                                    Clean();
                                    break;
                                case 1:
                                    MessageBox.Show("Continua errado... Presta atenção no que digita.", "Error 2");
                                    Clean();
                                    break;
                                case 2:
                                    MessageBox.Show("É, " + username + ", presumo que suas mãos estejam furadas hoje, uh? ", "Error 3");
                                    Clean();
                                    break;
                                case 3:
                                    if(username == "Lisa")
                                        MessageBox.Show("Ok, se você continuar errando eu vou assumir que você não seja a " + username, ":rage: 4");
                                    if(username == "Marco")
                                        MessageBox.Show("Ok, se você continuar errando eu vou assumir que você não seja o " + username, ":rage: 4");
                                    Clean();
                                    break;
                                case 4:
                                    MessageBox.Show("Você não é nenhum dos AMO6166, desligue o programa antes que ele exploda.", "Autodestruição em 1");
                                    Clean();
                                    break;
                                case 5:
                                    if (username == "Lisa")
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

        private void Clean()
        {
            tbSenha.Text = "";
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
            if ((VerificarAMO() == "Lisa") && rbMoon.Checked)
            {
                lbAcesso.Text = "Acessando como: Lisa";
            }
            else
                lbAcesso.Text = "Acessando como: Anônimo";
            /*lbAcesso.Text = "Acessando como: Lisa";
            username = "Lisa";*/
        }

        private string VerificarAMO()
        {
            if (tbNome.Text == "Lisa1666" || tbNome.Text == "lisa1666")
                return "Lisa";
            if (tbNome.Text == "Marco6111" || tbNome.Text == "marco6111")
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
            if (lbAcesso.Text == "Acessando como: Lisa")
                username = "Lisa";
            else if (lbAcesso.Text == "Acessando como: Marco")
                username = "Marco";
            else
                username = "Pessoa Anônima";
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            if (VerificarAMO() == "Marco")
            {
                lbAcesso.Text = "Acessando como: Marco";
            }
            else if(VerificarAMO() == "Lisa")
            {
                lbAcesso.Text = "Acessando como: Lisa";
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
            startInfo.Arguments = "/C start https://github.com/Nanacore/";
            start.StartInfo = startInfo;
            start.Start();
        }

        private void cbLembrar_CheckedChanged(object sender, EventArgs e)
        {   
            /*if (cbLembrar.Checked)
            {
                Properties.Settings.Default.lembrar = true;
                Remember();
            }
            else
            {
                Remember();
            }*/
        }
                                
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Remember();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Remember();
        }
    }
}
