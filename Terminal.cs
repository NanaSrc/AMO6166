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
                path = "../../../notes/nana.txt";
            else
                path = "../../../notes/marco.txt";

            tbPath.Text = path;
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
            /*if (e.KeyChar == (char)13)
            {
                content += ((char)11);
                content.Replace(" ", "\t");
            }*/
        }

        private void Terminal_Load(object sender, EventArgs e)
        {
            tbTerminalzinho.Focus();

            if (username == "Nana")
            {
                tbTerminalzinho.BackColor = Color.FromArgb(31, 29, 39);
                tbTerminalzinho.ForeColor = Color.FromArgb(183, 161, 255); 
            }
            else
            {
                tbPath.BackColor = Color.FromArgb(251, 241, 199);
                tbPath.ForeColor = Color.FromArgb(40, 40, 40);
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

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            count--;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = tbPath.Text;
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.FilterIndex = 1;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.FileName;
                tbPath.Text = path;

                if (File.Exists(path))
                {
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
    }
}
