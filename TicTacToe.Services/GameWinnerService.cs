using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Services
{
    public interface IGameWinnerService
    {
        object Validate(char[,] gameBoard);
    }

    public class GameWinnerService : IGameWinnerService
    {
        public object Validate(char[,] gameBoard)
        {
            return ' ';
        }
    }
}
