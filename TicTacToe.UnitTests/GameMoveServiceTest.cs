using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Services;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    class GameMoveServiceTest
    {
        private IGameMoveService _gameMoveService;
        private char[,] _gameBoard;

        [SetUp]
        public void SetUpUnitTests()
        {
            _gameMoveService = new GameMoveService();
            _gameBoard = new char[3, 3]
            {{' ', ' ', ' '},
            {' ', ' ', ' '},
            {' ', ' ', ' '}
            };
        }

        [Test]
        public void CanSaveMove()
        {
            const char expected = 'X';
            _gameBoard = new char[3, 3] {{expected, ' ', ' '},
                                            {' ', ' ', ' '},
                                            {' ', ' ', ' '}};

            _gameMoveService.AddGameBoardToList(_gameBoard);

            List<char[,]> gameBoardList = _gameMoveService.GetGameBoardList();
            
            var actual = _gameMoveService.CheckBoardList(gameBoardList, expected);

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

    }
}

    

