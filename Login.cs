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
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbNome.Focus();
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

        private void btLogin_Click(object sender, EventArgs e)
        {
            user user = new user();
            user.Nome = tbNome.Text;
            user.Key = tbSenha.Text;
            string nome = VerificarAMO();

            if (VerificarAMO().Equals("Nana") || VerificarAMO().Equals("Marco"))
                user.Nomec = true;

            if (user.Key == "12080405" || user.Key == "04051208" || user.Key == ".")
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
                    lbAcesso.Text = "Acessando como: Nana";
                else
                    lbAcesso.Text = "Acessando como: Marco";

                user.Ama = true;
            }

            if (user.Ama && user.Nomec && user.Keyc)
            {
                love m = new love(username);
                m.Show();
            }
            else
            {
                if (tbNome.Text == "" && tbSenha.Text == "" && (!user.Ama || user.Ama))
                {
                    MessageBox.Show("Você não vai a lugar algum se deixar os campos em branco...", "Uhh??");
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
                                    MessageBox.Show("É, " + username + ", presumo que suas mãos estejam furadas hoje, uh? ", ":rage: 3");
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
            /*lbAcesso.Text = "Acessando como: Marco";
            username = "Marco";*/
        }

        private void rbMoon_CheckedChanged(object sender, EventArgs e)
        {
            /*lbAcesso.Text = "Acessando como: Nana";
            username = "Nana";*/
        }

        private string VerificarAMO()
        {
            if (tbNome.Text == "Nana" || tbNome.Text == "Naninha" || tbNome.Text == "nana" || tbNome.Text == "naninha" || tbNome.Text == "Anna" || tbNome.Text == "anna")
                return "Nana";
            if (tbNome.Text == "Marco" || tbNome.Text == "marco" || tbNome.Text == "MarcoT" || tbNome.Text == "marcot" || tbNome.Text == "marcoT" || tbNome.Text == "Marcot")
                return "Marco";
            else
                return "Anônimo";
        }
    }
}
