using DataStructures.Stack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StackForm
{
    public partial class Form1 : Form
    {

        MyStack a = new MyStack();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            a.Add(textBox1.Text);
            textBox1.Clear();
        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "<" + a.Remove() + "> ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }

}
