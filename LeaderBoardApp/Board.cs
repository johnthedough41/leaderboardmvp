using System;

namespace LeaderBoardApp
{
    public class Board
    {
        public H2H[] Contest { get; }
        private string strBoardName;
        private Competitor[] Players;
        private bool bPrivacy;

        public Board(int nNumPlayers, bool bPrivacySetting, string strBoardName)
        {
            bPrivacy = bPrivacySetting; // true = public ; false = private
            Players = new Competitor[nNumPlayers];
            double dNumGames = ((double)nNumPlayers / 2) * (nNumPlayers - 1);
            Contest = new H2H[(int)dNumGames];
            this.strBoardName = strBoardName;
            //player names can be assigned as well, for this exercise I will hardcode it
            for (int ctr = 0; ctr < Players.Length;)
            {
                Players[ctr] = new Competitor()
                {
                    Points = 0,
                    Name = "Player " + ++ctr
                };
            }
            //round robin format
            int game = 0;
            for (int player = 0; player < Players.Length-1; player++)
            {
                for (int opponent = player+1; opponent < Players.Length; opponent++)
                    Contest[game++] = new H2H(Players[player], Players[opponent]);
            }
        }

        private void RankPlayers()
        {
            Array.Sort(Players, delegate (Competitor player1, Competitor player2) {
                return player1.Points.CompareTo(player2.Points);
            });
            Array.Reverse(Players);
        }

        private void Display()
        {
            Console.WriteLine(strBoardName);
            RankPlayers();
            foreach (var player in Players)
            {
                Console.WriteLine(player.Name + "\t" + player.Points);
            }
        }

        public void Display(bool bAuth)
        {
            if (bAuth)
                Display();
            else if (bPrivacy)
                Display();
        }
        public void ShowH2H()
        {
            int ctr = 1;
            foreach(var game in Contest)
            {
                Console.WriteLine("[" + ctr++ + "] " + game.Players[0].Name + " vs. " + game.Players[1].Name);
            }
        }
    }
}
