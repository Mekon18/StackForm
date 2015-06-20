using DataStructures.Stack;
using StackForm.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackForm
{
    public partial class StackForm : Form
    {
        MyStack a = new MyStack();
        int _num;
        public StackForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonRemove.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                
                a.Add(textBox1.Text);
                textBox1.Clear();
                _num++;
                buttonRemove.Visible = true;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            buttonRemove.Visible = true;
            textBox1.Text = textBox1.Text + "<" + a.Remove() + ">";
            _num--;
            if (_num < 1)
            {
                buttonRemove.Visible = false;
            }
        }

        private void TextBox_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void StackForm_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBackToHab_Click(object sender, EventArgs e)
        {
            FormHab fh = new FormHab();
            fh.Show();
            this.Hide();
        }
    }
}
