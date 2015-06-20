using BusinessEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
using System.IO;


namespace StackForm.Forms
{
    public partial class FormClicker : Form
    {
        private int score = 0;
        private int _gameLenght;
        private bool _gameIsRunning = false;
        private Action _timer;
        private Task _myTimer;
        private List<Score> _highScore;
        List<string> _playersList;
        FormAddPlayer fa;
        private bool _nameRepeated;

        public FormClicker()
        {
            InitializeComponent();

            if (JsonFileHelper.JsonFileHelper.Read<List<Score>>("scoreFile.json") != null)
            {
                _highScore = JsonFileHelper.JsonFileHelper.Read<List<Score>>("scoreFile.json");

                listBoxHighScore.Items.AddRange(_highScore.Select(item => item.Player.Name + "  " + item.ScoreNum).ToArray());
            }
            else
            {
                _highScore = new List<Score>();
            }

            _playersList = new List<string>();

            if (JsonFileHelper.JsonFileHelper.Read<List<string>>("playersFile.json") != null)
            {
                _playersList = JsonFileHelper.JsonFileHelper.Read<List<string>>("playersFile.json");

               listBoxPlayers.Items.AddRange(_playersList.ToArray());
            }

            _gameLenght = 20;

            _timer = async () =>
        {
            int sec = 0;
            while (_gameLenght > sec)
            {
                await Task.Delay(1000);
                sec++;
                if ((_gameLenght - sec) < 10)
                {
                    lblTimer.Text = "00:0" + ((_gameLenght - sec).ToString());
                }
                else
                {
                    lblTimer.Text = "00:" + ((_gameLenght - sec).ToString());
                }
            }
            if (JsonFileHelper.JsonFileHelper.Read<List<Score>>("scoreFile.json") != null)
            {
                _highScore = JsonFileHelper.JsonFileHelper.Read<List<Score>>("scoreFile.json");
            }


            Score hs = new Score();
            hs.ScoreNum = score;

            (hs.Player = new Player()).Name = listBoxPlayers.SelectedItem.ToString();
            foreach (var it in _highScore)
            {
                if (it.Player.Name == hs.Player.Name)
                {
                    if (it.ScoreNum < hs.ScoreNum)
                    {
                    it.ScoreNum = hs.ScoreNum;
                    }
                    _nameRepeated = true;
                    break;
                }
                else
                {
                    _nameRepeated = false;
                }
            }
            if (_nameRepeated == false)
            {
                _highScore.Add(hs);
            }
            _highScore.Sort();
            JsonFileHelper.JsonFileHelper.Write<List<Score>>("scoreFile.json",_highScore);
            listBoxHighScore.Items.Clear();

            listBoxHighScore.Items.AddRange(_highScore.Select(item => item.Player.Name + "  " + item.ScoreNum).ToArray());

            _gameIsRunning = false;
            panelForClicks.Enabled = false;

            buttonDeletePlayer.Enabled = true;
            buttonAddPlayer.Enabled = true;
            buttonBackToHab_clicker.Enabled = true;
            buttonBegin.Enabled = true;
            buttonBegin.BackColor = Color.Teal;

            MessageBox.Show("Игра окончена. Ваш счёт - " + score);
            score = 0;
            labelScoreNumber.Text = "0";
        };

            panelForClicks.Enabled = false;

        }

        private void FormClicker_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBackToHab(object sender, EventArgs e)
        {
            FormHab fh = new FormHab();
            fh.Show();
            this.Hide();
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            fa = new FormAddPlayer();
            fa.NewPlayerAdded += fa_NewPlayerAdded;
            fa.Show();
        }

        private void fa_NewPlayerAdded(string player)
        {
            foreach(var it in _playersList)
            {
                if (it.ToString() == player)
                {
                    MessageBox.Show("Такое имя уже есть. Назовите другое имя или используйте уже существующее");
                    fa.Show();
                    _nameRepeated = true;
                    break;
                }
                else
                {
                    _nameRepeated = false;
                }
            }
            if (_nameRepeated == false)
            {
                _playersList.Add(player);
                listBoxPlayers.Items.Add(player);
                fa.Hide();
                JsonFileHelper.JsonFileHelper.Write<List<string>>("playersFile.json",_playersList);
            }
        }

        private void butttonDeletePlayer_Click(object sender, EventArgs e)
        {
            score = 0;
            labelScoreNumber.Text = score.ToString();
            if (listBoxPlayers.SelectedItem != null)
            {
                int a =  listBoxPlayers.SelectedIndex;
                _playersList.RemoveAt(listBoxPlayers.SelectedIndex);
                listBoxPlayers.Items.RemoveAt(listBoxPlayers.SelectedIndex);
                JsonFileHelper.JsonFileHelper.Write<List<string>>("playersFile.json", _playersList);
            }
        }

        private void lbp_IndexChenged(object sender, EventArgs e)
        {
            score = 0;
            labelScoreNumber.Text = score.ToString();
        }

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem != null)
            {
                buttonBegin.BackColor = Color.DarkGray;
                panelForClicks.Enabled = true;
                buttonDeletePlayer.Enabled = false;
                buttonAddPlayer.Enabled = false;
                buttonBackToHab_clicker.Enabled = false;
                buttonBegin.Enabled = false;
                lblTimer.Text = "00:" + _gameLenght;
                score = 0;
                labelScoreNumber.Text = score.ToString();
              
            }
        }

        private void panelForClick_MouseDown(object sender, MouseEventArgs e)
        {
            if (_gameIsRunning == false)
            {
                _myTimer = new Task(_timer);
                _myTimer.Start(TaskScheduler.FromCurrentSynchronizationContext());
                _gameIsRunning = true;
            }
            score++;
            labelScoreNumber.Text = score.ToString();

        }
    }
}
