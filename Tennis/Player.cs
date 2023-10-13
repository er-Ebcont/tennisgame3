namespace Tennis
{
    public class Player
    {
        private string _playerName;
        private int _playerPoints;

        public Player(string playerName, int playerPoints)
        {
            _playerName = playerName;
            _playerPoints = playerPoints;
        }

        public string PlayerName { get => _playerName; set => _playerName = value; }
        public int PlayerPoints { get => _playerPoints; set => _playerPoints = value; }
    }
}