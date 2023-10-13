namespace Tennis
{
    public interface IPlayer
    {
        string Name { get; set; }
        int Points { get; set; }
        bool HasTennisTerm { get;}
        string GetCurrentTennisTerm { get;}
    }
}