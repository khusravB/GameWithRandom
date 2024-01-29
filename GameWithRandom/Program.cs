using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameWithRandom
{
    internal class Program
    {
        
        static void Game(Player player1, Player player2) {
            
            Player gameWinner;
            int totalSwaps = 0;
            Random rnd = new Random();

            Start();

            int Swap()
            {
                
                totalSwaps++;
                  
                return rnd.Next(0, 2);
            }

            Player checkWinner(int swp) {
                
                if (swp == 0)  
                    return player2;
                else 
                    return player1;


            }

            
            void Checkout(Player winner) {
                
                if (player1.IsWinner(winner))
                {
                    player1.increment();
                    player2.deecrement();
                }
                else if(player2.IsWinner(winner)) {
                    player2.increment();
                    player1.deecrement();
                }
            }

            void Start() {
                
                while (player1.isNotBankrupt() && player2.isNotBankrupt()) {
                    int swap = Swap();
                    
                    Player winner = checkWinner(swap);
                    Checkout(winner);

                }
                
                PrintWinner();
            }

            void PrintWinner() {
                
                if (player1.GetScore() == 0)
                    gameWinner = player2;
                else
                    gameWinner = player1;

                Console.WriteLine($"{gameWinner.GetName()} is Winner");
                
                Console.WriteLine();
                
                Console.WriteLine($"Total Swaps Quantity: {totalSwaps}");
                
                Console.WriteLine();
                
                Console.WriteLine($"{player1.GetName()}: {player1.GetScore()}");
                Console.WriteLine($"{player2.GetName()}: {player2.GetScore()}");

            }

            
        }
        

        static void Main(string[] args)
        {
            Player Player1 = new Player("John", 100);
            Player Player2 = new Player("Lisa", 100);

            Game(Player1, Player2);
           
            
        }
    }
}
