using System;

namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private IPlayer _player1;
        private IPlayer _player2;

        public TennisGame3(string player1Name, string player2Name)
        {
            this._player1 = new Player(player1Name);
            this._player2 = new Player(player2Name);
        }

        public string GetScore()
        {
            if ((this._player1.HasTennisTerm && this._player2.HasTennisTerm) && (this._player1.Points + this._player2.Points < 6))
            {
                return (this._player1.Points == this._player2.Points) ? 
                    $"{this._player1.GetCurrentTennisTerm}-All" : 
                    $"{this._player1.GetCurrentTennisTerm}-{this._player2.GetCurrentTennisTerm}";
            }

            if (this._player1.Points == this._player2.Points)
            {
                // Unentschieden
                return "Deuce";
            }
                
            string winningPlayerName = this._player1.Points > this._player2.Points ? _player1.Name : _player2.Name;
            return (Math.Abs(this._player1.Points -this._player2.Points) == 1) ? $"Advantage {winningPlayerName}" : $"Win for {winningPlayerName}";
        }

        public void WonPoint(string playerName)
        {
            if (playerName == this._player1.Name)
            {
                this._player1.Points += 1;
            }

            if (playerName == this._player2.Name)
            {
                this._player2.Points += 1;
            }
        }

    }
}