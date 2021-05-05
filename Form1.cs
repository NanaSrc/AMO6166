using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marco
{
    public partial class Form1 : Form
    {
        //love m = new love();
        int error = 0;
        //Eu te amo mais que a luz que vem da careca do Zyon
        public Form1()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            user user = new user();
            user.Nome = tbNome.Text;
            user.Key = tbKey.Text;
            
            
            if (rbNao.Checked != true)
                user.Ama = true;

            if (user.Nome == "Marco" || user.Nome == "marco" || user.Nome == "Joselito" || user.Nome == "joselito" || user.Nome == "macaco")
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
                if (tbNome.Text == "" && tbKey.Text == "" && (!user.Ama || user.Ama))
                {
                    MessageBox.Show("Não acredito que tu duvidou que eu tivesse programado essa parte", "Sério?");
                }
                else
                {
                    //Isso é pra prevenir que outros Marcos do mal tentem acessar o nosso programinha :rage:
                    if (rbNao.Checked == true)
                        MessageBox.Show("Você não me ama? :rage:");
                    else if (!rbClaro.Checked && !rbMuito.Checked && !rbNao.Checked && !rbSim.Checked)
                    {
                        MessageBox.Show("Pode responder a pergunta...", "Eu sou uma piada pra você?");
                    }
                    else
                    {
                        if (!user.Nomec)
                        {
                            MessageBox.Show("Apenas Marcos são bem vindos.", "SAIA");
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

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descobriu um easter egg :eye:. A chave é seu niver + o meu...", "Surpresa!");
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você tem certeza de que vai me abandonar ? :(","Nãããõ", MessageBoxButtons.YesNo);
            //I love you to the moon and back
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Ok... Adeus", "Poxa");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Ufa, ainda bem :)", "Pensei");
            }
          
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Eu queria muito fazer uma coisa aqui mas eu não descobri como, por isso comentei e desisti 
            /*
            Form1 form2 = new Form1();
            form2.Width = 555;
            form2.Height = 633;*/

            MessageBox.Show("Ok, a senha também pode ser o grito de um MACACO", "Easter Egg 2");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btVer_Click(object sender, EventArgs e)
        {
            
        }

        private void btVer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Misslick
        }

        private void btVer_MouseDown(object sender, MouseEventArgs e)
        {
            //Confundi com ...
        }

        private void cbVer_CheckedChanged(object sender, EventArgs e)
        {
            string a = Convert.ToString(tbKey.Text);
            if (cbVer.Checked)
            {
                tbKey.PasswordChar = '\0';
            }
            else
            {
                tbKey.PasswordChar = '♥';
            }
        }

        private void tbKey_Enter(object sender, EventArgs e)
        {
            //Confundi com a tecla enter
        }

        private void tbKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btLogin_Click(sender, e);
            }
        }

        private void rbNao_CheckedChanged(object sender, EventArgs e)
        {
            Terminal term = new Terminal();
            term.Show();
        }
    }
}
