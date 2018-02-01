namespace LeaderBoardApp
{
    public class H2H
    {
        public Competitor[] Players;
        public H2H(Competitor cPlayer1, Competitor cPlayer2)
        {
            Players = new Competitor[2];
            Players[0] = cPlayer1;
            Players[1] = cPlayer2;
        }
    }
}
