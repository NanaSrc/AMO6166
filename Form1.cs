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
        love m = new love();
        int error = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string nome = tbNome.Text;
            string key = tbKey.Text;
            bool ama = false;
            bool nomec = false;
            bool keyc = false;

            if (rbNao.Checked != true)
                ama = true;

            if (nome == "Marco" || nome == "marco" || nome == "Joselito" || nome == "joselito" || nome == "macaco")
                nomec = true;

            if (key == "12080405" || key == "04051208")
                keyc = true;

            if (ama && nomec && keyc)
            {
                m.Show();
                
            }
            else
            {
                if (tbNome.Text == "" && tbKey.Text == "" && (!ama || ama))
                {
                    MessageBox.Show("Não acredito que tu duvidou que eu tivesse programado essa parte", "Sério?");
                }
                else
                {
                    //ta funcionando c:
                    if (rbNao.Checked == true)
                        MessageBox.Show("Você não me ama? :rage:");

                    if (!nomec)
                    {
                        MessageBox.Show("Apenas Marcos são bem vindos.", "SAIA");
                    }
                    else if (keyc == false)
                    {
                        switch (error)
                        {
                            case 0:
                                MessageBox.Show("É a chave do nosso inferninho, meu diabinho", "O que mais seria?");
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

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Descobriu um easter egg :eye:. A chave é seu niver + o meu...", "Surpresa!");
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você tem certeza de que vai me abandonar ? :(","Nãããõ", MessageBoxButtons.YesNo);
            //mds q burra
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
            Form1 form2 = new Form1();
            form2.Width = 555;
            form2.Height = 633;
        }
    }
}
