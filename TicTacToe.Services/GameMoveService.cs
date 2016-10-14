using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Services
{
    public interface IGameMoveService
    {
        List<char[,]> GetGameBoardList();
        void AddGameBoardToList(char[,] gameBoard);
        char CheckBoardList(List<char[,]> gameBoard, char expectedChar);
    }
    public class GameMoveService : IGameMoveService
    {
        string NL = Environment.NewLine;
        //private char[,] _gameBoard;
        List<char[,]> gameBoardList = new List<char[,]>();
        
        public List<char[,]> GetGameBoardList()
        {
            return gameBoardList;
        }

        public void AddGameBoardToList(char[,] gameBoard)
        {
            gameBoardList.Add(gameBoard);
        }

        public char CheckBoardList(List<char[,]> gameBoard, char expectedChar)
        {
            char fail = ' ';
            foreach (char[,] board in gameBoard)
            {
                var columnOneChar = board[0, 0];
                if (columnOneChar == expectedChar)
                {
                    return expectedChar;
                }
            }
            return fail;
        }

        public void ChoosePosition()
        {
            //string failMessage = "Wrong";
            string currentBoard = "";
            char xOrO;
            //bool bolleEllerKryds = false;
            Console.WriteLine("Enter the position");
            string choice = GetUserChoice();
            switch (choice)
                {
                    case "0.0":
                        xOrO = 'X';
                        currentBoard = "[" + xOrO + "] [ ] [ ]" + NL + "[ ] [ ] [ ]" + NL + "[ ] [ ] [ ]";
                        break;
                    case "0.1":
                        xOrO = 'X';
                        currentBoard = "[ ] [" + xOrO + "] [ ]" + NL + "[ ] [ ] [ ]" + NL + "[ ] [ ] [ ]";
                        break;
                    case "0.2":
                        xOrO = 'X';
                        currentBoard = "[ ] [ ] [" + xOrO + "]" + NL + "[ ] [ ] [ ]" + NL + "[ ] [ ] [ ]";
                        break;
                    case "1.0":
                        xOrO = 'X';
                        currentBoard = "[ ] [ ] [ ]" + NL + "[" + xOrO + "] [ ] [ ]" + NL + "[ ] [ ] [ ]";
                        break;
                    case "1.1":
                        xOrO = 'X';
                        currentBoard = "[ ] [ ] [ ]" + NL + "[ ] [" + xOrO + "] [ ]" + NL + "[ ] [ ] [ ]";
                        break;
                    case "1.2":
                        xOrO = 'X';
                        currentBoard = "[ ] [ ] [ ]" + NL + "[ ] [ ] [" + xOrO + "]" + NL + "[ ] [ ] [ ]";
                        break;
                    case "2.0":
                        xOrO = 'X';
                        currentBoard = "[ ] [ ] [ ]" + NL + "[ ] [ ] [ ]" + NL + "[" + xOrO + "] [ ] [ ]";
                        break;
                    case "2.1":
                        xOrO = 'X';
                        currentBoard = "[ ] [ ] [ ]" + NL + "[ ] [ ] [ ]" + NL + "[ ] [" + xOrO + "] [ ]";
                        break;
                    case "2.2":
                        xOrO = 'X';
                        currentBoard = "[ ] [ ] [ ]" + NL + "[ ] [ ] [ ]" + NL + "[ ] [ ] [" + xOrO + "]";
                        break;
                    default:
                        break;
                }
            Console.WriteLine(currentBoard);
            Console.ReadKey();
            Console.Clear();
        }
        public void GameMenu()
        {
            string gameBoard = "[0.0] [0.1] [0.2]" + NL + "[1.0] [1.1] [1.2]" + NL + "[2.0] [2.1] [2.2]";
            Console.WriteLine(gameBoard);
            Console.WriteLine("Write the number 1");
        }
        public string GetUserChoice()
        {
            string userChoice = Console.ReadLine();
            return userChoice;
        }
    }
}

