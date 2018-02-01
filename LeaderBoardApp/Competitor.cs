namespace LeaderBoardApp
{
    public class Competitor
    {
        public string Name { get; set; }
        private int nPoints;
        public int Points
        {
            get { return nPoints; }
            set { nPoints += value; }
        }
    }
}
