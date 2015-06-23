using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;

namespace StackForm.Forms
{
    public partial class FormTicTacToe : Form
    {
        public FormTicTacToe(Player PlayerOne, Player PlayerSecond)
        {
            InitializeComponent();
            labelPlayersName.Text = PlayerOne.Name + " VS " + PlayerSecond.Name;
        }

        private void buttonBackToHabfttt_Click(object sender, EventArgs e)
        {
            FormHab fh = new FormHab();
            fh.Show();
            this.Hide();
        }

        private void FormTicTacToe_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonSelectOther_Click(object sender, EventArgs e)
        {
            FormSelectPlayerForTTT fspttt = new FormSelectPlayerForTTT();
            fspttt.Show();
            this.Hide();
        }

    }
}
