namespace Gotham
{
    internal class Thief : Person
    {

        public Inventory Inventory = new Inventory();

        public int TimeLeft { get; set; }
        public bool IsArrested  { get; set; }
        public Thief(int x, int y) : base(x, y)
        {
            Icon = 'T';
            
        }

        public void StartPrisonTime(int stolenItemCount)
        {
            if (IsArrested || stolenItemCount<=0)
            {
                return;
           }

            TimeLeft = stolenItemCount * 10;
            IsArrested = true;
      
        }

        public bool CountDownPrisonTime()
        {
            if (IsArrested==false)
            {
                return false;
            }

            if (TimeLeft > 0)
            {
                TimeLeft--;
            }

            return TimeLeft == 0;
        }


        public bool Release()
        {
            if (IsArrested == false || TimeLeft > 0)
            {
                return false;
            }

            while(Inventory.items.Count > 0)
            {
                Inventory.items.RemoveAt(0);
            }

            TimeLeft = 0;
            IsArrested = false;

            return true;
        }

    }
}
