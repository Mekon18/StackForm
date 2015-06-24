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
        private int _switchstroke;
        private Player _playerOne;
        private Player _playerSecond;
        private int _fieldSize;
        
        public FormTicTacToe(Player PlOne, Player PlSecond,int fieldSize)
        {
            InitializeComponent();
            _fieldSize = fieldSize;
            _playerOne = PlOne;
            _playerSecond = PlSecond;
            labelPlayersName.Text = PlOne.Name + " VS " + PlSecond.Name;
            _switchstroke = 1;
            pGameField.Controls.Add(new Button());
           
            
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

        private void CheckWin()
        {
            if (((button1.Text == button5.Text) && (button5.Text == button9.Text) && (button5.Text != "")) || ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (button5.Text != "")))
            {
                if (button5.Text == "X")
                {
                    MessageBox.Show(_playerOne.Name + " Win");
                }
                else
                {
                    MessageBox.Show(_playerSecond.Name + " Win");
                }
            }
            if (((button2.Text == button5.Text) && (button5.Text == button8.Text) && (button5.Text != "")) || ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (button4.Text != "")) || ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (button6.Text != "")))
            {
                if (button5.Text == "X")
                {
                    MessageBox.Show(_playerOne.Name + " Win");
                }
                else
                {
                    MessageBox.Show(_playerSecond.Name + " Win");
                }
                if (button4.Text == "X")
                {
                    MessageBox.Show(_playerOne.Name + " Win");
                }
                else
                {
                    MessageBox.Show(_playerSecond.Name + " Win");
                }
                if (button6.Text == "X")
                {
                    MessageBox.Show(_playerOne.Name + " Win");
                }
                else
                {
                    MessageBox.Show(_playerSecond.Name + " Win");
                }
            }
            if (((button1.Text == button2.Text) && (button2.Text == button3.Text) && (button2.Text != "")) || ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (button5.Text != "")) || ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (button8.Text != "")))
            {
                if (button5.Text == "X")
                {
                    MessageBox.Show(_playerOne.Name + " Win");
                }
                else
                {
                    MessageBox.Show(_playerSecond.Name + " Win");
                }
                if (button2.Text == "X")
                {
                    MessageBox.Show(_playerOne.Name + " Win");
                }
                else
                {
                    MessageBox.Show(_playerSecond.Name + " Win");
                }
                if (button8.Text == "X")
                {
                    MessageBox.Show(_playerOne.Name + " Win");
                }
                else
                {
                    MessageBox.Show(_playerSecond.Name + " Win");
                }
            }
        }

        private void buttonTTT_Click(object sender, MouseEventArgs e)
        {
            if (_switchstroke == 1)
            {
                ((Button)sender).Text = "X";
                CheckWin();
                _switchstroke = 2;
            }
            else
            {
                ((Button)sender).Text = "O";
                CheckWin();
                _switchstroke = 1;
            }
        }
    }
}
