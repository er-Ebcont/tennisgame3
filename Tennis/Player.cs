﻿namespace Tennis
{
    public class Player : IPlayer
    {
        private string _playerName;
        private int _playerPoints;

        public Player(string playerName, int playerPoints)
        {
            _playerName = playerName;
            _playerPoints = playerPoints;
        }

        public string Name { get => _playerName; set => _playerName = value; }
        public int Points { get => _playerPoints; set => _playerPoints = value; }
    }
}