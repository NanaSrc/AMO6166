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

        private void btLogin_Click(object sender, EventArgs e)
        {
            user user = new user();
            user.Nome = tbNome.Text;
            user.Key = tbSenha.Text;

            if (user.Nome == "Nana" || user.Nome == "Marco" || user.Nome == "nana" || user.Nome == "marco" || user.Nome == "naninha" || 
                user.Nome == "Naninha" || user.Nome == "joselito" || user.Nome == "Joselito" || user.Nome == "Anna" || user.Nome == "MarcoT" || 
                user.Nome == "anna" || user.Nome == "marcot" || user.Nome == "marcoT")
                user.Nomec = true;

            if (user.Key == "12080405" || user.Key == "04051208" || user.Key == "MACACO")
                user.Keyc = true;

            if (user.Ama && user.Nomec && user.Keyc)
            {
                love m = new love(tbNome.Text);
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
                    //Isso é pra prevenir que outros Marcos e Nanas do mal tentem acessar o nosso programinha :rage:
                    /*if (rbNao.Checked == true)
                        MessageBox.Show("Você não me ama? :rage:");
                    else*/ if (!rbMoon.Checked && !rbSummer.Checked)
                    {
                        MessageBox.Show("Esqueceu de algo?", ":eye:");
                    }
                    else
                    {
                        if (!user.Nomec)
                        {
                            MessageBox.Show("Apenas Marco e Naninha podem acessar.", "Vá embora");
                        }
                        else if (user.Keyc == false)
                        {
                            switch (error)
                            {
                                //Isso é pra você não errar muito  
                                case 0:
                                    MessageBox.Show("Não consegue pensar na chave? É a chave do nosso inferninho, meu diabinho", "Não sabe a senha?");
                                    break;
                                case 1:
                                    MessageBox.Show("A nossa chave, sabe? A senha de pra entrar no servidor", "Pensa um pouco c:");
                                    break;
                                case 2:
                                    MessageBox.Show("Pensa, pensa, pensa :rage:", "Meu deus, Marco");
                                    break;
                                case 3:
                                    MessageBox.Show("Eu vou te bater, Marco", "Macaco do caralho");
                                    break;
                                case 4:
                                    MessageBox.Show("PQP eu vou fechar o programa se tu continuar errando a senha", ":rage:");
                                    break;
                                case 5:
                                    MessageBox.Show("Eu avisei", "Não creio");
                                    Application.Exit();
                                    break;
                            }
                            error += 1;
                        }
                    }

                }
            }
        }
    }
}
