﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Services
{
    public interface IGameWinnerService
    {
        char Validate(char[,] gameBoard);
    }

    public class GameWinnerService : IGameWinnerService
    {
        private const char SymbolForNoWinner = ' ';

        public char Validate(char[,] gameBoard)
        {
            
            var currentWinningSymbol = CheckForThreeInARowInHorizontalRow(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
            {
                return currentWinningSymbol;
            }
            currentWinningSymbol = CheckForThreeInARowInVertivalColumn(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
            {
                return currentWinningSymbol;
            }
            currentWinningSymbol = CheckForThreeInARowDiagonally(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
            {
                return currentWinningSymbol;
            }
            currentWinningSymbol = CheckForThreeInARowMiddleColumn(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
            {
                return currentWinningSymbol;
            }
            currentWinningSymbol = CheckForThreeInARowLeftColumn(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
            {
                return currentWinningSymbol;
            }
            currentWinningSymbol = CheckForThreeInARowInHorizontalRowBottom(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
            {
                return currentWinningSymbol;
            }
            currentWinningSymbol = CheckForThreeInARowInHorizontalRowMiddle(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
            {
                return currentWinningSymbol;
            }
            currentWinningSymbol = CheckForThreeInARowDiagonallyDownToLeft(gameBoard);
            return currentWinningSymbol;
        }
        private static char CheckForThreeInARowInHorizontalRow(char[,] gameBoard)
        {
            var columnOneChar = gameBoard[0, 0];
            var columnTwoChar = gameBoard[0, 1];
            var columnThreeChar = gameBoard[0, 2];
            if (columnOneChar == columnTwoChar && columnTwoChar == columnThreeChar)
            {
                return columnOneChar;
            }
            return ' ';
        }
        private static char CheckForThreeInARowInHorizontalRowBottom(char[,] gameBoard)
        {
            var columnOneChar = gameBoard[2, 0];
            var columnTwoChar = gameBoard[2, 1];
            var columnThreeChar = gameBoard[2, 2];
            if (columnOneChar == columnTwoChar && columnTwoChar == columnThreeChar)
            {
                return columnOneChar;
            }
            return ' ';
        }

        private static char CheckForThreeInARowInHorizontalRowMiddle(char[,] gameBoard)
        {
            var columnOneChar = gameBoard[1, 0];
            var columnTwoChar = gameBoard[1, 1];
            var columnThreeChar = gameBoard[1, 2];
            if (columnOneChar == columnTwoChar && columnTwoChar == columnThreeChar)
            {
                return columnOneChar;
            }
            return ' ';
        }

        private static char CheckForThreeInARowInVertivalColumn(char[,] gameBoard)
        {
            var rowOneChar = gameBoard[0, 0];
            var rowTwoChar = gameBoard[1, 0];
            var rowThreeChar = gameBoard[2, 0];
            if (rowOneChar == rowTwoChar && rowTwoChar == rowThreeChar)
            {
                return rowOneChar;
            }
            return ' ';
        }

        private static char CheckForThreeInARowMiddleColumn(char[,] gameBoard)
        {
            var rowOneChar = gameBoard[0, 1];
            var rowTwoChar = gameBoard[1, 1];
            var rowThreeChar = gameBoard[2, 1];
            if (rowOneChar == rowTwoChar && rowTwoChar == rowThreeChar)
            {
                return rowOneChar;
            }
            return SymbolForNoWinner;
        }

        private static char CheckForThreeInARowLeftColumn(char[,] gameBoard)
        {
            var rowOneChar = gameBoard[0, 2];
            var rowTwoChar = gameBoard[1, 2];
            var rowThreeChar = gameBoard[2, 2];
            if (rowOneChar == rowTwoChar && rowTwoChar == rowThreeChar)
            {
                return rowOneChar;
            }
            return SymbolForNoWinner;
        }

        private static char CheckForThreeInARowDiagonally(char[,] gameBoard)
        {
            var cellOneChar = gameBoard[0, 0];
            var cellTwoChar = gameBoard[1, 1];
            var cellThreeChar = gameBoard[2, 2];
            if (cellOneChar == cellTwoChar && cellTwoChar == cellThreeChar)
            {
                return cellOneChar;
            }
            return SymbolForNoWinner;
        }

        private static char CheckForThreeInARowDiagonallyDownToLeft(char[,] gameBoard)
        {
            var cellOneChar = gameBoard[0, 2];
            var cellTwoChar = gameBoard[1, 1];
            var cellThreeChar = gameBoard[2, 0];
            if (cellOneChar == cellTwoChar && cellTwoChar == cellThreeChar)
            {
                return cellOneChar;
            }
            return SymbolForNoWinner;
        }
    }
}
