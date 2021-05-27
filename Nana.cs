using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace amo6166
{
    public partial class Nana : MetroFramework.Forms.MetroForm
    {
        int count = 0;
        //Eu amo o Marco
        public Nana()
        {
            InitializeComponent();
        }

        private void Nana_Load(object sender, EventArgs e)
        {
            
        }

        private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox6.Checked)
            {
                label6.Visible = false;
            }

        }

        private void metroCheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox11.Checked)
                label11.Visible = true;
            else
                label11.Visible = false;
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked)
                label1.Visible = true;
            else
                label1.Visible = false;

            if (label18.Visible)
                label18.Visible = false;
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox2.Checked)
                label2.Visible = true;
            else
                label2.Visible = false;
        }

        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox3.Checked)
                label3.Visible = true;
            else
                label3.Visible = false;
        }

        private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox4.Checked)
                label4.Visible = true;
            else
                label4.Visible = false;
        }

        private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox5.Checked)
            {
                label5.Visible = true;
                label6.Visible = true;
            }
            else
            {
                label5.Visible = false;
                label6.Visible = false;
            }
        }

        private void metroCheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox7.Checked)
                label7.Visible = true;
            else
                label7.Visible = false;
        }

        private void metroCheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox8.Checked)
                label8.Visible = true;
            else
                label8.Visible = false;
        }

        private void metroCheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox9.Checked)
                label9.Visible = true;
            else
                label9.Visible = false;
        }

        private void metroCheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox10.Checked)
                label10.Visible = true;
            else
                label10.Visible = false;
        }

        private void metroCheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox12.Checked)
                label12.Visible = true;
            else
                label12.Visible = false;
        }

        private void metroCheckBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox13.Checked)
                label13.Visible = true;
            else
                label13.Visible = false;
        }

        private void metroCheckBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox14.Checked)
            {
                if (AllChecked())
                {
                    Clear();

                    timer1.Enabled = true; // Enable the timer.
                    timer1.Start();//Strart it
                    timer1.Interval = 600; // The time per tick.
                    timer1.Tick += new EventHandler(timer1_Tick);
                }
            }
        }

        private void Clear()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            switch (count)
            {
                case 0:
                    label14.Visible = true;
                    break;
                case 1:
                    label14.Visible = false;
                    label15.Visible = true;
                    break;
                case 2:
                    label15.Visible = false;
                    label16.Visible = true;
                    break;
                case 3:
                    label16.Visible = false;
                    label17.Visible = true;
                    break;
                case 4:
                    label17.Visible = false;
                    label18.Visible = true;
                    Point ponto = new Point(221, 182);
                    label18.Location = ponto;
                    break;
                case 5:
                    Point ponto2 = new Point(201, 261);
                    label18.Location = ponto2;
                    break;
                case 6:
                    Point ponto3 = new Point(235, 187);
                    label18.Location = ponto3;
                    break;
                case 8:
                    Point ponto4 = new Point(235, 210);
                    label18.Location = ponto4;
                    break;
                case 9:
                    Point ponto5 = new Point(268, 261);
                    label18.Location = ponto5;
                    break;
                case 10:
                    Point ponto6 = new Point(233, 213);
                    label18.Location = ponto6;
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    timer1.Stop();
                    label18.Text = "GULUGULU";
                    break;
            }
        }
        private bool AllChecked()
        {
            if (metroCheckBox1.Checked && metroCheckBox2.Checked && metroCheckBox3.Checked &&
                metroCheckBox4.Checked && metroCheckBox5.Checked && metroCheckBox6.Checked &&
                metroCheckBox7.Checked && metroCheckBox8.Checked && metroCheckBox9.Checked &&
                metroCheckBox10.Checked && metroCheckBox11.Checked && metroCheckBox12.Checked)
                return true;
            else
                return false;
        }
    }
}
