namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int _player2points;
        private int _player1points;
        private string _player1Name;
        private string _player2Name;

        public TennisGame3(string player1Name, string player2Name)
        {
            this._player1Name = player1Name;
            this._player2Name = player2Name;
        }

        public string GetScore()
        {
            if ((_player1points < 4 && _player2points < 4) && (_player1points + _player2points < 6))
            {
                string[] tennisTerms = { "Love", "Fifteen", "Thirty", "Forty" };
                string tennisTermPlayer1 = tennisTerms[_player1points];
                string tennisTermPlayer2 = tennisTerms[_player2points];
                return (_player1points == _player2points) ? tennisTermPlayer1 + "-All" : tennisTermPlayer1 + "-" + tennisTermPlayer2;
            }

            if (_player1points == _player2points)
                return "Deuce";
            string s = _player1points > _player2points ? _player1Name : _player2Name;
            return ((_player1points - _player2points) * (_player1points - _player2points) == 1) ? "Advantage " + s : "Win for " + s;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                this._player1points += 1;
            else
                this._player2points += 1;
        }

    }
}