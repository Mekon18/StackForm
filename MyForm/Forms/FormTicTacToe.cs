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
        private Button[,] _buttonsTTT;
        private int _fieldSize;
        private bool _win;
        private int _countForWin;

        public FormTicTacToe(Player PlOne, Player PlSecond, int fieldSize, int countForWin)
        {
            InitializeComponent();
            _playerOne = PlOne;
            _playerSecond = PlSecond;
            labelPlayersName.Text = PlOne.Name + " VS " + PlSecond.Name;
            _switchstroke = 1;
            _fieldSize = fieldSize;
            _countForWin = countForWin;

            #region создание поля

            _buttonsTTT = new Button[fieldSize, fieldSize];
            pGameField.Height = (fieldSize + 1) * 30;
            pGameField.Width = (fieldSize + 1) * 30;
            this.Height = (68 + pGameField.Height);
            if (pGameField.Width < 290)
            {
                this.Width = 290;
            }
            else
            {
                this.Width = pGameField.Width + 5;
            }
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    Button but = new Button();

                    but.Width = 25;
                    but.Height = 25;
                    but.Location = new Point((j * 30), (i * 30));
                    but.Visible = true;
                    but.MouseClick += new MouseEventHandler(buttonTTT_Click);
                    pGameField.Controls.Add(but);
                    _buttonsTTT[j, i] = but;
                }
            }
            label2.Text = _playerOne.Name + "(X)";

            #endregion

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
            for (int i = 0; i < _fieldSize; i++)
            {
                for (int j = 0; j < _fieldSize; j++)
                {
                    int K = 0;
                    if (_buttonsTTT[j, i].Text == "X")
                    {

                        if (j != (_fieldSize - 1))
                        {

                            #region проверка по горизонтали


                            for (int k = j; k < (_fieldSize - 1); k++)
                            {
                                if ((k - j) < (_countForWin - 1))
                                {
                                    if (_buttonsTTT[k, i].Text != _buttonsTTT[k + 1, i].Text)
                                    {
                                        _win = false;
                                        break;
                                    }
                                    _win = true;
                                }
                                else break;
                                K = k;
                            }
                            if (((K + 1) - j) == (_countForWin - 1))
                            {
                                if (_win == true)
                                {
                                    MessageBox.Show(_playerOne.Name + " Win");
                                    break;
                                }
                            }
                            else _win = false;


                            #endregion

                            if (i != (_fieldSize - 1))
                            {

                                #region проверка по диогонали(слева направо)

                                if (_win == false)
                                {
                                    int m = i;
                                    for (int k = j; k < (_fieldSize - 1); k++)
                                    {
                                        if (((k - j) < (_countForWin - 1)) && ((m - i) < (_countForWin - 1)) && (m < (_fieldSize - 1)))
                                        {
                                            if (_buttonsTTT[k, m].Text != _buttonsTTT[k + 1, m + 1].Text)
                                            {
                                                _win = false;
                                                break;
                                            }
                                            _win = true;
                                        }
                                        else break;
                                        K = k;
                                        m++;
                                    }
                                    if ((((K + 1) - j) == (_countForWin - 1)) && ((m - i) == (_countForWin - 1)))
                                    {
                                        if (_win == true)
                                        {
                                            MessageBox.Show(_playerOne.Name + " Win");
                                            break;
                                        }
                                    }
                                    else _win = false;
                                }

                                #endregion

                            }
                        }
                        if (i != (_fieldSize - 1))
                        {

                            #region проверка по вертикали

                            if (_win == false)
                            {
                                for (int k = i; k < (_fieldSize - 1); k++)
                                {
                                    if ((k - i) < (_countForWin - 1))
                                    {
                                        if (_buttonsTTT[j, k].Text != _buttonsTTT[j, k + 1].Text)
                                        {
                                            _win = false;
                                            break;
                                        }
                                        _win = true;
                                    }
                                    K = k;
                                }
                                if (((K + 1) - i) == (_countForWin - 1))
                                {
                                    if (_win == true)
                                    {
                                        MessageBox.Show(_playerOne.Name + " Win");
                                        break;
                                    }
                                }
                                else _win = false;
                            }

                            #endregion

                            if (j >= (_countForWin - 1))
                            {

                                #region проверка по диогонали(справа налево)
                                if (_win == false)
                                {
                                    int m = i;
                                    for (int k = j; k > 0; k--)
                                    {
                                        if (((j - k) < (_countForWin - 1)) && ((m - i) < (_countForWin - 1)) && (m < (_fieldSize - 1)))
                                        {
                                            if (_buttonsTTT[k, m].Text != _buttonsTTT[k - 1, m + 1].Text)
                                            {
                                                _win = false;
                                                break;
                                            }
                                            _win = true;
                                        }
                                        else break;
                                        K = k;
                                        m++;
                                    }
                                    if (((j - (K - 1)) == (_countForWin - 1)) && ((m - i) == (_countForWin - 1)))
                                    {
                                        if (_win == true)
                                        {
                                            MessageBox.Show(_playerOne.Name + " Win");
                                            break;
                                        }
                                    }
                                    else _win = false;
                                }

                                #endregion

                            }
                        }
                    }
                    if (_buttonsTTT[j, i].Text == "O")
                    {
                        if (j != (_fieldSize - 1))
                        {

                            #region проверка по горизонтали


                            for (int k = j; k < (_fieldSize - 1); k++)
                            {
                                if ((k - j) < (_countForWin - 1))
                                {
                                    if (_buttonsTTT[k, i].Text != _buttonsTTT[k + 1, i].Text)
                                    {
                                        _win = false;
                                        break;
                                    }
                                    _win = true;
                                }
                                else break;
                                K = k;
                            }
                            if (((K + 1) - j) == (_countForWin - 1))
                            {
                                if (_win == true)
                                {
                                    MessageBox.Show(_playerSecond.Name + " Win");
                                    break;
                                }
                            }
                            else _win = false;


                            #endregion

                            if (i != (_fieldSize - 1))
                            {

                                #region проверка по диогонали(слева направо)

                                if (_win == false)
                                {
                                    int m = i;
                                    for (int k = j; k < (_fieldSize - 1); k++)
                                    {
                                        if (((k - j) < (_countForWin - 1)) && ((m - i) < (_countForWin - 1)) && (m < (_fieldSize - 1)))
                                        {
                                            if (_buttonsTTT[k, m].Text != _buttonsTTT[k + 1, m + 1].Text)
                                            {
                                                _win = false;
                                                break;
                                            }
                                            _win = true;
                                        }
                                        else break;
                                        K = k;
                                        m++;
                                    }
                                    if ((((K + 1) - j) == (_countForWin - 1)) && ((m - i) == (_countForWin - 1)))
                                    {
                                        if (_win == true)
                                        {
                                            MessageBox.Show(_playerSecond.Name + " Win");

                                            break;
                                        }
                                    }
                                    else _win = false;
                                }

                                #endregion
                            }

                        }
                        if (i != (_fieldSize - 1))
                        {

                            #region проверка по вертикали

                            if (_win == false)
                            {
                                for (int k = i; k < (_fieldSize - 1); k++)
                                {
                                    if ((k - i) < (_countForWin - 1))
                                    {
                                        if (_buttonsTTT[j, k].Text != _buttonsTTT[j, k + 1].Text)
                                        {
                                            _win = false;
                                            break;
                                        }
                                        _win = true;
                                    }
                                    K = k;
                                }
                                if (((K + 1) - i) == (_countForWin - 1))
                                {
                                    if (_win == true)
                                    {
                                        MessageBox.Show(_playerSecond.Name + " Win");

                                        break;
                                    }
                                }
                                else _win = false;
                            }

                            #endregion

                            if (j >= (_countForWin - 1))
                            {

                                #region проверка по диогонали(справа налево)

                                if (_win == false)
                                {
                                    int m = i;
                                    for (int k = j; k > 0; k--)
                                    {
                                        if (((j - k) < (_countForWin - 1)) && ((m - i) < (_countForWin - 1)) && (m < (_fieldSize - 1)))
                                        {
                                            if (_buttonsTTT[k, m].Text != _buttonsTTT[k - 1, m + 1].Text)
                                            {
                                                _win = false;
                                                break;
                                            }
                                            _win = true;
                                        }
                                        else break;
                                        K = k;
                                        m++;
                                    }
                                    if (((j - (K - 1)) == (_countForWin - 1)) && ((m - i) == (_countForWin - 1)))
                                    {
                                        if (_win == true)
                                        {
                                            MessageBox.Show(_playerSecond.Name + " Win");

                                            break;
                                        }
                                    }
                                    else _win = false;
                                }

                                #endregion

                            }
                        }
                    }
                }
                
                if (_win == true)
                {
                    ClearField();
                    break;
                }
            }
        }

        private void buttonTTT_Click(object sender, MouseEventArgs e)
        {
            if (_switchstroke == 1)
            {
                ((Button)sender).Text = "X";
                ((Button)sender).Enabled = false;
                _switchstroke = 2;
                label2.Text = _playerSecond.Name + "(O)";
                CheckWin();
                CheckDeadHeat();
            }
            else
            {
                ((Button)sender).Text = "O";
                ((Button)sender).Enabled = false;
                _switchstroke = 1;
                label2.Text = _playerOne.Name + "(X)";
                CheckWin();
                CheckDeadHeat();
            }
        }

        private void ClearField()
        {
            pGameField.Controls.Clear();
            for (int i = 0; i < _fieldSize; i++)
            {
                for (int j = 0; j < _fieldSize; j++)
                {
                    Button but = new Button();

                    but.Width = 25;
                    but.Height = 25;
                    but.Location = new Point((j * 30), (i * 30));
                    but.Visible = true;
                    but.MouseClick += new MouseEventHandler(buttonTTT_Click);
                    pGameField.Controls.Add(but);
                    _buttonsTTT[j, i] = but;
                }
            }
            _win = false;
            _switchstroke = 1;
            label2.Text = _playerOne.Name + "(X)";
        }

        private void CheckDeadHeat()
        {
            bool deadHeat = false;
            bool interrupted = false; 
            for (int i = 0; i < _fieldSize; i++)
            {
                for (int j = 0; j < _fieldSize; j++)
                {
                    if (_buttonsTTT[j, i].Enabled == false)
                    {
                        deadHeat = true;
                    }
                    else
                    {
                        deadHeat = false;
                        interrupted = true;
                        break;
                    }
                }
                if (interrupted == true) break;
            }
            if (deadHeat == true)
            {
                MessageBox.Show("Ничья");
                ClearField();
            }
        }
    }
}
