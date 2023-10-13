using System;

namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {

        private IPlayer _player1;
        private IPlayer _player2;
        //private int _player2points;
        private string[] tennisTerms = { "Love", "Fifteen", "Thirty", "Forty" };

        public TennisGame3(string player1Name, string player2Name)
        {
            this._player1 = new Player(player1Name, 0);
            this._player2 = new Player(player2Name, 0);
        }

        public string GetScore()
        {
            if ((this._player1.PlayerPoints < 4 && this._player2.PlayerPoints < 4) && (this._player1.PlayerPoints + this._player2.PlayerPoints < 6))
            {
                string tennisTermPlayer1 = tennisTerms[this._player1.PlayerPoints];
                string tennisTermPlayer2 = tennisTerms[this._player2.PlayerPoints];
                return (this._player1.PlayerPoints == this._player2.PlayerPoints) ? $"{tennisTermPlayer1}-All" : $"{tennisTermPlayer1}-{tennisTermPlayer2}";
            }

            if (this._player1.PlayerPoints == this._player2.PlayerPoints)
            {
                // Unentschieden
                return "Deuce";
            }
                
            string winningPlayerName = this._player1.PlayerPoints > this._player2.PlayerPoints ? _player1.PlayerName : _player2.PlayerName;
            return (Math.Abs(this._player1.PlayerPoints -this._player2.PlayerPoints) == 1) ? $"Advantage {winningPlayerName}" : $"Win for {winningPlayerName}";
        }

        public void WonPoint(string playerName)
        {
            if (playerName == this._player1.PlayerName)
            {
                this._player1.PlayerPoints += 1;
            }

            if (playerName == this._player2.PlayerName)
            {
                this._player2.PlayerPoints += 1;
            }
        }

    }
}