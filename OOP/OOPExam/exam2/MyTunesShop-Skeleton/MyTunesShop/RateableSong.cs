namespace MyTunesShop
{
    using System.Collections.Generic;

    public class RateableSong : Song, IRateable
    {
        private List<int> ratings = new List<int>();  

        public RateableSong(string title, decimal price, IPerformer performer, string genre, int year, string duration)
            : base(title, price, performer, genre, year)
        {
        }

        public IList<int> Ratings
        {
            get
            {
                return this.ratings;
            }
        }

        public void PlaceRating(int rating)
        {
            this.Ratings.Add(rating);
        }
    }
}
