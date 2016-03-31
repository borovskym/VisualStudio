using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        private int counter;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String odpoved = "arpanet";

            if (odpoved.Equals(textBox1.Text.ToLower()))
            {
                counter++;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                counter++;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                counter++;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                counter++;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                counter++;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(3))
            {
                counter++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isGameOver())
            {
                MessageBox.Show("Gratulujeme! \n Pocet spravnych odpovedi:" + counter, "Score", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("Atleast something.\nPocet spravnych odpovedi:" + counter, "Score", MessageBoxButtons.OKCancel);
            }
        }

        private bool isGameOver()
        {
            if (counter == 5)
                 return true;
            else return false;
        }
    }
}
