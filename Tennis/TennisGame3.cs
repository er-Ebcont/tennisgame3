using System;

namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int _player2points;
        private int _player1points;
        private IPlayer _player1;
        private IPlayer _player2;
        private string[] tennisTerms = { "Love", "Fifteen", "Thirty", "Forty" };

        public TennisGame3(string player1Name, string player2Name)
        {
            this._player1 = new Player(player1Name, 0);
            this._player2 = new Player(player2Name, 0);
        }

        public string GetScore()
        {
            if ((_player1points < 4 && _player2points < 4) && (_player1points + _player2points < 6))
            {
                string tennisTermPlayer1 = tennisTerms[_player1points];
                string tennisTermPlayer2 = tennisTerms[_player2points];
                return (_player1points == _player2points) ? $"{tennisTermPlayer1}-All" : $"{tennisTermPlayer1}-{tennisTermPlayer2}";
            }

            if (_player1points == _player2points)
            {
                // Unentschieden
                return "Deuce";
            }
                
            string winningPlayerName = _player1points > _player2points ? _player1.PlayerName : _player2.PlayerName;
            return (Math.Abs(_player1points-_player2points) == 1) ? $"Advantage {winningPlayerName}" : $"Win for {winningPlayerName}";
        }

        public void WonPoint(string playerName)
        {
            if (playerName == this._player1.PlayerName)
            {
                this._player1points += 1;
            }

            if (playerName == this._player2.PlayerName)
            {
                this._player2points += 1;
            }
        }

    }
}