namespace Tennis
{
    public class Player : IPlayer
    {
        private string _playerName;
        private int _playerPoints;
        private string[] tennisTerms = { "Love", "Fifteen", "Thirty", "Forty" };

        public Player(string playerName)
        {
            _playerName = playerName;
            _playerPoints = 0;
        }

        public string Name { get => _playerName; set => _playerName = value; }
        public int Points { get => _playerPoints; set => _playerPoints = value; }
        public bool HasTennisTerm
        {
            get => _playerPoints < 4;
        }

        public string GetCurrentTennisTerm
        {
            get
            {
                if (this.Points >= tennisTerms.Length)
                {
                    throw new System.Exception($"No Tennis Term found for player {this.Name} with points: {this.Points}.");
                }

                return this.tennisTerms[this.Points];
            }
        }
    }
}