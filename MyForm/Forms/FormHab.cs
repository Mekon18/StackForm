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
    public partial class FormHab : Form
    {
        public FormHab()
        {
            InitializeComponent();
        }

        private void buttonOpenStackForm_Click(object sender, EventArgs e)
        {
            StackForm sf = new StackForm();
            sf.Show();
            this.Hide();
        }

        private void FormHab_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonOpenClicker_Click(object sender, EventArgs e)
        {
            FormClicker fc = new FormClicker();
            fc.Show();
            this.Hide();
        }
    }
}
