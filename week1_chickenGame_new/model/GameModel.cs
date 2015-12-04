using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_chickenGame_new.model
{
    public class GameModel
    {
        public int     _xScreen;
        public int     _yScreen;
        public int     _playerScore;
        public int     _playerLifes;
        public bool    _gameOn;
        public bool _gameWait { get; set; } // pauze

        public GameModel(int setXScreen, int setYScreen, int setPlayerScore, int setPlayerLifes, Boolean setGameOn)
        {
            this.xScreen            = setXScreen;
            this.yScreen            = setYScreen;
            this.playerScore        = setPlayerScore;
            this.playerLifes        = setPlayerLifes;
            this.gameOn             = setGameOn;
            this._gameWait          = false;
        }

        // Getters & Setters
        public int xScreen { get { return this._xScreen; } set { _xScreen = value; } }
        public int yScreen { get { return this._yScreen; } set { _yScreen = value; } }
        public int playerScore { get { return this._playerScore; } set { _playerScore = value; } }
        public int playerLifes { get { return this._playerLifes; } set { _playerLifes = value; } }
        public Boolean gameOn { get { return this._gameOn; } set { _gameOn = value; } }

    }
}
