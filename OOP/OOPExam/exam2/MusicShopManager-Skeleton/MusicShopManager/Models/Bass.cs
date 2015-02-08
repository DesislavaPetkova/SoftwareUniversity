namespace MusicShop.Models
{
    using MusicShopManager.Interfaces;

    public class Bass : Guitar, IBassGuitar
    {
        public Bass(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood)
            : base(make, model, price, color, bodyWood, fingerboardWood)
        {
            this.IsElectronic = true;
            this.NumberOfStrings = 4;
        }
    }
}
