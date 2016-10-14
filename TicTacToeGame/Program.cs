using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Services;

namespace TicTacToeGame
{
    public class Program
    {
        //public char[,] 
        //_gameBoard = new char[3, 3]
        //   {{' ', ' ', ' '},
        //    {' ', ' ', ' '},
        //    {' ', ' ', ' '}
        //   };

        public static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.run();
            
        }

        public void run()
        {

            GameMoveService access = new GameMoveService();
            

            string choice = "";

            bool running = true;

            do
            {
                access.GameMenu();
                choice = access.GetUserChoice();
                switch (choice)
                {
                    case "1": access.ChoosePosition(); break;
                    case "exit": running = false; break;
                }

            } while (running);
        }

        

    }
}
