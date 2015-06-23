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
    public partial class FormSelectPlayerForTTT : Form
    {
        private FormAddPlayer fa;
        private bool _nameRepeated;
        private List<string> _playersList;
        private Player[] _selectedPlayers;
        private int _selectedPlayerNum;
       

        public FormSelectPlayerForTTT()
        {
            InitializeComponent();
            _selectedPlayers = new Player[2];
            _selectedPlayers[0] = new Player();
            _selectedPlayers[1] = new Player();
            _selectedPlayerNum = 0;

            _playersList = new List<string>();

            if (JsonFileHelper.JsonFileHelper.Read<List<string>>("playersTicTacToeFile.json") != null)
            {
                _playersList = JsonFileHelper.JsonFileHelper.Read<List<string>>("playersTicTacToeFile.json");

                listBoxPlayersTicTacToe.Items.AddRange(_playersList.ToArray());
            }
            
        }

        private void buttonBackToHabTicTacToe_Click(object sender, EventArgs e)
        {
            FormHab fh = new FormHab();
            fh.Show();
            this.Hide();
        }

        private void FormTicTacToe_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddPlayerttt_Click(object sender, EventArgs e)
        {
            fa = new FormAddPlayer();
            fa.NewPlayerAdded += fa_NewPlayerAdded;
            fa.Show();
        }

        private void fa_NewPlayerAdded(string player)
        {
            foreach (var it in _playersList)
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
                listBoxPlayersTicTacToe.Items.Add(player);
                listBoxPlayersTicTacToe.SelectedIndex = _playersList.Count - 1;
                fa.Hide();
                JsonFileHelper.JsonFileHelper.Write<List<string>>("playersTicTacToeFile.json", _playersList);
            }
        }

        private void buttonRemovePlayerttt_Click(object sender, EventArgs e)
        {
            if (listBoxPlayersTicTacToe.SelectedItem != null)
            {
                int a = listBoxPlayersTicTacToe.SelectedIndex;
                _playersList.RemoveAt(listBoxPlayersTicTacToe.SelectedIndex);
                listBoxPlayersTicTacToe.Items.RemoveAt(listBoxPlayersTicTacToe.SelectedIndex);
                listBoxPlayersTicTacToe.SelectedIndex = _playersList.Count - 1;
                JsonFileHelper.JsonFileHelper.Write<List<string>>("playersFile.json", _playersList);
            }
        }

        private void buttonSelectPlayerttt_Click(object sender, EventArgs e)
        {
            if (listBoxPlayersTicTacToe.SelectedItem != null)
            {
                if (listBoxPlayersTicTacToe.SelectedItem.ToString() == _selectedPlayers[0].Name)
                {
                    MessageBox.Show("Игрок уже выбран. Выберите другого игрока");
                }
                else
                {
                    _selectedPlayers[_selectedPlayerNum].Name = listBoxPlayersTicTacToe.SelectedItem.ToString();
                    _selectedPlayerNum++;
                }
            }
            if (_selectedPlayerNum == 2)
            {
                FormTicTacToe fttt = new FormTicTacToe(_selectedPlayers[0], _selectedPlayers[1]);
                fttt.Show();
                this.Hide();
            }
        }
    }
}
