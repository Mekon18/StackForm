using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackForm.Forms
{
    public partial class FormAddPlayer : Form
    {
     
        public event NewPlayerHandler NewPlayerAdded;

        public FormAddPlayer()
        {
            InitializeComponent();
            textBox1.MaxLength = 12;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void FormAddPlayer_Closing(object sender, FormClosingEventArgs e)
        {
            
            this.Hide();
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != ""))
            {
                OnPlayerAdded();
                textBox1.Clear();
            }
        }

        private void OnPlayerAdded()
        {
            if (NewPlayerAdded != null)
            {
                NewPlayerAdded(textBox1.Text);
            }
        }

    }

    public delegate void NewPlayerHandler(string player);
}
