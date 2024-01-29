using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWithRandom
{
    internal class Player
    {
        protected string name;
        protected int score;

        public Player(string name, int score){
            this.name = name;  
            this.score = score; 
        }

        public bool isNotBankrupt() {
            if (this.score > 0)
                return true;
            else
                return false;
        }

        public void deecrement() {
            this.score--;
        }

        public void increment()
        {
            this.score++;
        }

        public bool IsWinner(Player player) {
            if (player == this)
            {
                return true;
            }
            else
                return false;
        }

        public int GetScore() { 
            return this.score;
        }

        public string GetName() { 
            return this.name; 
        }   

    }
}
