namespace LeaderBoardApp
{
    public class Subscriber
    {
        const string SubPassword = "subAdmin"; //should be stored in DB
        
        public bool Authenticate(string password)
        {
            return password.Equals(SubPassword);
        }
    }
}
