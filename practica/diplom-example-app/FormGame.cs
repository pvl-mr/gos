using Implement.Models;
using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace diplom_example_app
{
    public partial class FormGame : Form
    {
        List<Game> games = new List<Game>();
        List<Player> players = new List<Player>();

        public FormGame()
        {
            InitializeComponent();
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.GameName = textBoxGameName.Text;
            game.MasterName = textBoxMasterName.Text;
            game.DateGame = dateTimePickerDate.Value.ToLocalTime();
            List<Player> players = new List<Player>();
            foreach(ListViewItem item in listViewGamePlayers.Items)
            {
                players.Add(item.Tag as Player);
            }
            game.Players = players;

            ListViewItem listViewItem = new ListViewItem(game.GameName); 
            listViewItem.Tag = game; 

            listViewGames.Items.Add(listViewItem);
            games.Add(game);

        }
/*
        private void игрокиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var m = new FormPlayer();
            m.Show();
        }
*/
        private void buttonDeleteGame_Click(object sender, EventArgs e)
        {
            if (listViewGames.SelectedItems.Count == 1)
            {
                Game game = (Game)listViewGames.SelectedItems[0].Tag;
                games.Remove(game);
                listViewGames.Items.RemoveAt(listViewGames.SelectedItems[0].Index);
            }
        }

        private void buttonSavePlayer_Click(object sender, EventArgs e)
        {
            Player player = new Player(textBoxNickname.Text, 0, dateTimePickerDeath.Value);


            ListViewItem listViewItem = new ListViewItem(player.Nickname); 
            listViewItem.Tag = player; 

            listViewPlayers.Items.Add(listViewItem);
            players.Add(player);
            comboBoxPlayers.Items.Add(player);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player player = (Player)comboBoxPlayers.SelectedItem;

            ListViewItem listViewItem = new ListViewItem(player.Nickname);
            listViewItem.Tag = player; 
            if (!listViewGamePlayers.Items.Contains(listViewItem))
            {
                listViewGamePlayers.Items.Add(listViewItem);
            }

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewGamePlayers.SelectedItems.Count == 1)
            {
                Player player = (Player)listViewGamePlayers.SelectedItems[0].Tag;
                players.Remove(player);
                listViewGamePlayers.Items.RemoveAt(listViewGamePlayers.SelectedItems[0].Index);
            }
        }

        private void listViewGames_SelectedIndexChanged(object sender, EventArgs e)
        {


            listViewGamePlayers.Items.Clear();


            if (listViewGames.SelectedItems.Count == 1)
            {
                Game game = (Game)listViewGames.SelectedItems[0].Tag;

                if (game != null)
                {
                    textBoxGameName.Text = game.GameName;
                    textBoxMasterName.Text = game.MasterName;
                    dateTimePickerDate.Value = game.DateGame;
                    game.Players.ForEach(player => {
                        ListViewItem listViewItem = new ListViewItem(player.Nickname); 
                        listViewItem.Tag = player; 
                        listViewGamePlayers.Items.Add(listViewItem); 
                    });


                }
            }
        }

        private void listViewPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPlayers.SelectedItems.Count == 1)
            {
                Player player = (Player)listViewPlayers.SelectedItems[0].Tag;

                if (player != null)
                {
                    textBoxNickname.Text = player.Nickname;
                    numericUpDownScore.Text = player.Score.ToString();
                    dateTimePickerDeath.Value = player.DateDeath;

                }
            }
        }

        private void buttonDeletePlayer_Click(object sender, EventArgs e)
        {
            if (listViewPlayers.SelectedItems.Count == 1)
            {
                Player player = (Player)listViewPlayers.SelectedItems[0].Tag;
                players.Remove(player);
                listViewPlayers.Items.RemoveAt(listViewPlayers.SelectedItems[0].Index);
            }
        }

        private void buttonEditPlayer_Click(object sender, EventArgs e)
        {
            if (listViewPlayers.SelectedItems.Count == 1)
            {
                Player player = (Player)listViewPlayers.SelectedItems[0].Tag;
                if (player != null)
                {
                    player.Nickname = textBoxNickname.Text;
                    player.Score = (int)numericUpDownScore.Value;
                    player.DateDeath = DateTime.Now;
                    listViewPlayers.SelectedItems[0].Text = player.Nickname;
                    listViewPlayers.Refresh();
                    listViewPlayers.Update();
                }
            }
        }

        private void buttonEditGame_Click(object sender, EventArgs e)
        {
            if (listViewGames.SelectedItems.Count == 1)
            {
                Game game = (Game)listViewGames.SelectedItems[0].Tag;

                if (game != null)
                {
                    
                    game.GameName = textBoxGameName.Text;
                    game.MasterName = textBoxMasterName.Text;
                    game.DateGame = dateTimePickerDate.Value.ToLocalTime();
                    listViewGames.SelectedItems[0].Text = game.GameName;
                    List <Player> players = new List<Player>();
                    foreach (ListViewItem item in listViewGamePlayers.Items)
                    {
                        players.Add(item.Tag as Player);
                    }
                    game.Players = players;

                    ListViewItem listViewItem = new ListViewItem(game.GameName); 
                    listViewItem.Tag = game; 
             

                    listViewGames.Refresh();
                }

            }
        }

        private void buttonSerealize_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Game>));

            using (FileStream fs = new FileStream("Games.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, games);
            }

            serializer = new XmlSerializer(typeof(List<Player>));

            using (FileStream fs = new FileStream("Players.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, players);
            }
        }

        private void buttonDeserealize_Click(object sender, EventArgs e)
        {

            XmlSerializer xml = new XmlSerializer(typeof(List<Player>));
            using (FileStream fs = new FileStream("Players.xml", FileMode.OpenOrCreate))
            {
                List<Player> xmlPlayers = (List<Player>)xml.Deserialize(fs);
                players = xmlPlayers;
                players.ForEach(p =>
                {
                    ListViewItem listViewItem = new ListViewItem(p.Nickname); 
                    listViewItem.Tag = p; 
                    listViewPlayers.Items.Add(listViewItem);
                });
            }

            xml = new XmlSerializer(typeof(List<Game>));
            using (FileStream fs = new FileStream("Games.xml", FileMode.OpenOrCreate))
            {
                List<Game> xmlGames = (List<Game>)xml.Deserialize(fs);
                games = xmlGames;
                games.ForEach(game =>
                {
                    ListViewItem listViewItem = new ListViewItem(game.GameName); 
                    listViewItem.Tag = game; 
                    listViewGames.Items.Add(listViewItem);

                });

            }
        }
    }
}
