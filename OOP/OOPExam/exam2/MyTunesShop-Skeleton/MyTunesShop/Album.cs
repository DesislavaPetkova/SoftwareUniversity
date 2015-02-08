namespace MyTunesShop
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Album : IAlbum
    {
        private string title;

        private decimal price;

        private IPerformer performer;

        private string genre;

        private int year;

        private List<ISong> songs = new List<ISong>();

        public Album(string title, decimal price, IPerformer performer, string genre, int year)
        {
            this.Title = title;
            this.Price = price;
            this.Performer = performer;
            this.Genre = genre;
            this.Year = year;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Title is required!");
                }

                this.title = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price should be positive!");
                }
                this.price = value;
            }
        }

        public IPerformer Performer
        {
            get
            {
                return this.performer;
            }

            set
            {
                this.performer = value;
            }
        }

        public string Genre
        {
            get
            {
                return this.genre;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Genre is required.");
                }

                this.genre = value;
            }
        }

        public int Year
        {
            get
            {
                return this.year;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("year should be positive");
                }

                this.year = value;
            }
        }

        public IList<ISong> Songs
        {
            get
            {
                return this.songs;
            }
        }

        public void AddSong(ISong song)
        {
            this.Songs.Add(song);
        }

        //public override string ToString()
        //{
        //    var result = new StringBuilder();
        //    var header = string.Format(
        //        "{0} ({1}) by {2}\nGenre: {3}, Price: ${4:##.###}\nSupplies: {5}, Sold: {6}",
        //        this.Title, this.Year, this.Genre, this.Price, this.s
        //        );
        //    return base.ToString();
        //}
    }
}
