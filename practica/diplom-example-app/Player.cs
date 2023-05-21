using System;
using System.Collections.Generic;
using System.Text;

namespace Implement.Models
{
    public class Player
    {
        public int Id { get; set; }
        public int? GameId { get; set; }

        public int Score { get; set; }

        public string Nickname { get; set; }
        public DateTime DateDeath { get; set; }
        public Game Game { get; set; }

        public Player() { }

        public Player(string nickname, int score, DateTime dateDeath)
        {
            Score = score;
            Nickname = nickname;
            DateDeath = dateDeath;
        }

        public override string ToString() { 
            return Nickname;
        }
    }
}
