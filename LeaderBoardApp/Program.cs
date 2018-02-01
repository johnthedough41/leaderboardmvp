using System;

namespace LeaderBoardApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //admin sets up the leaderboards
                Board oBoard1 = new Board(4, true, "Leaderboard [1]");
                Board oBoard2 = new Board(3, false, "Leaderboard [2]");
                Board[] oAvailableBoards = new Board[] { oBoard1, oBoard2 };

                while (true)
                {
                    Console.Write("Are you a [1]referee or a [2]subscriber? ");
                    int nAns;
                    Int32.TryParse(Console.ReadLine(), out nAns);
                    Console.Clear();
                    //for this exercise '0' will serve as exit
                    if (nAns == 0) break;
                    if (nAns == 1)
                    {
                        Console.Write("Please enter password: ");
                        string strPwd = Console.ReadLine();
                        Referee referee = new Referee();
                        referee.Authenticate(strPwd);
                        Console.Clear();
                        DisplayAll(oAvailableBoards);
                        while (true)
                        {
                            Console.Write("Select leaderboard to score: ");
                            int nBoardNum;
                            Int32.TryParse(Console.ReadLine(), out nBoardNum);
                            Console.Clear();
                            //for this exercise '0' will serve as exit
                            if (nBoardNum == 0) break;
                            //check for valid inputs
                            oAvailableBoards[nBoardNum - 1].ShowH2H();
                            Console.Write("Select H2H to score: ");
                            int nH2HNum;
                            Int32.TryParse(Console.ReadLine(), out nH2HNum);
                            referee.RegisterScore(oAvailableBoards[nBoardNum - 1], nH2HNum - 1, 5, 4);
                            Console.Clear();
                            DisplayAll(oAvailableBoards);
                        }
                    }
                    else if (nAns == 2)
                    {
                        Console.Write("Please enter password: ");
                        string strPwd = Console.ReadLine();
                        Subscriber subscriber = new Subscriber();

                        foreach (var board in oAvailableBoards)
                        {
                            board.Display(subscriber.Authenticate(strPwd));
                        }
                    }
                }
            }
            catch (System.Security.Authentication.AuthenticationException e)
            {
                if (e.Source != null)
                    Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
        static private void DisplayAll(Board[] oAvailableBoards)
        {
            foreach (var board in oAvailableBoards)
            {
                board.Display(true);
            }
        }
    }
}
