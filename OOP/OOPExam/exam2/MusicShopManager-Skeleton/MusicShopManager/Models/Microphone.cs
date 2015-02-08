namespace MusicShop.Models
{
    using MusicShopManager.Interfaces;

    public class Microphone : Article, IMicrophone
    {
        private bool hasCable;


        public Microphone(string make, string model, decimal price, bool hasCable)
            : base(make, model, price)
        {
            this.HasCable = hasCable;
        }
        public bool HasCable
        {
            get
            {
                return this.hasCable;
            }

            set
            {
                this.hasCable = value;
            }
        }

        public override string ToString()
        {
            var output = string.Format("= {0} {1} =\n"
                + "Price: ${2:0.00}\n"
                + "Cable: {3}", this.Make, this.Model, this.Price, this.HasCable ? "yes" : "no");
            return output;
        }
    }
}
