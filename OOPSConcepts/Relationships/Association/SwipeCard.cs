namespace OOPSConcepts.Association
{
    public class SwipeCard
    {
        private string madeOfCard;
        public SwipeCard(string madeOfCard)
        {
            this.madeOfCard = madeOfCard;
        }

       public string MadeOfCard
       {
           get { return madeOfCard; }
       }

        public void swipe(Manager mgr)
        {
            System.Console.WriteLine("Swipe the manager");          
        }
    }
}