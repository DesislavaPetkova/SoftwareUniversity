namespace MusicShopManager.Engine.Factories
{
    using System;

    using MusicShop.Models;

    using MusicShopManager.Interfaces;
    using MusicShopManager.Interfaces.Engine;
    using MusicShopManager.Models;

    public class ArticleFactory : IArticleFactory
    {
        public IMicrophone CreateMirophone(string make, string model, decimal price, bool hasCable)
        {
            IMicrophone microphone = new Microphone(make, model, price, hasCable);
            return microphone;
        }

        public IDrums CreateDrums(string make, string model, decimal price, string color, int width, int height)
        {
            IDrums drums = new Drums(make, model, price, color, width, height);
            return drums;
        }

        public IElectricGuitar CreateElectricGuitar(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood, int numberOfAdapters, int numberOfFrets)
        {
            IElectricGuitar electricGuitar = new Electric(make, model, price, color,
            bodyWood, fingerboardWood, numberOfAdapters, numberOfFrets);
            return electricGuitar;
        }

        public IAcousticGuitar CreateAcousticGuitar(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood, bool caseIncluded, StringMaterial stringMaterial)
        {
            IAcousticGuitar acousticGuitar = new Acoustic(make, model, price, color,
            bodyWood, fingerboardWood, caseIncluded, stringMaterial);
            return acousticGuitar;
        }

        public IBassGuitar CreateBassGuitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood)
        {
            IBassGuitar bassGuitar = new Bass(make, model, price, color, bodyWood, fingerboardWood);
            return bassGuitar;
        }
    }
}
