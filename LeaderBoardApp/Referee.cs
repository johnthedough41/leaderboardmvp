namespace LeaderBoardApp
{
    public class Referee
    {
        const string RefPassword = "refAdmin"; //should be stored in DB

        public void Authenticate(string password)
        {
            if (!password.Equals(RefPassword))
            {
                throw new System.Security.Authentication.AuthenticationException("Invalid password");
            }
        }

        public void RegisterScore(Board oBoardToScore, int nH2HToScore, int nPlayer1Score, int nPlayer2Score )
        {
            oBoardToScore.Contest[nH2HToScore].Players[0].Points = nPlayer1Score;
            oBoardToScore.Contest[nH2HToScore].Players[1].Points = nPlayer2Score;
        }
    }
}
