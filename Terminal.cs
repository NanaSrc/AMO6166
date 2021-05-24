using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace amo6166
{
    public partial class Terminal : MetroFramework.Forms.MetroForm
    {
        string username;
        string content;
        string path;
        int count = 0;
        public Terminal(string username)
        {
            InitializeComponent();
            this.username = username;

            if (username == "Nana")
                path = "C:/Users/annas/OneDrive/Documentos/slingshot/AMO6166/AMO6166/notes/nana.txt";
            else
                path = "C:/Users/annas/OneDrive/Documentos/slingshot/AMO6166/AMO6166/notes/marco.txt";
        }

        private void tbTerminalzinho_TextChanged(object sender, EventArgs e)
        {
            content = tbTerminalzinho.Text;

            if (count > 0)
            {
                if (File.Exists(path))
                {
                    File.WriteAllText(path, String.Empty);
                    FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);

                    //Fazer o file deletar tudo do arquivo 

                    sw.Write(content);

                    sw.Close();
                    fs.Close();
                }
            }

            

            /*try 
            {
                fs = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.Write(content);

                sw.Close();
                fs.Close();
            }
            catch (System.IO.IOException)
            {

            }
            finally
            {

            }*/

            //}
        }

        private void tbTerminalzinho_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string comando = tbTerminalzinho.Text;
            //if (e.KeyChar == (char)13)
            //{
                /*if (tbTerminalzinho.Text.Contains("/exit"))
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
                }*/

            //}
        }

        private void Terminal_Load(object sender, EventArgs e)
        {
            tbTerminalzinho.Focus();

            if (username == "Nana")
            {
                tbTerminalzinho.BackColor = Color.FromArgb(31, 29, 39);
                tbTerminalzinho.ForeColor = Color.FromArgb(183, 161, 255); 
            }

            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            if (sr.Peek() != -1)
            {
                content = sr.ReadToEnd();
            }

            tbTerminalzinho.Text = content;

            sr.Close();
            fs.Close();

            count++;
        }
    }
}
