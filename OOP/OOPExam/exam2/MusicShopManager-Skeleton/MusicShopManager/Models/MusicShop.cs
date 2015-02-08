namespace MusicShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using MusicShopManager.Interfaces;

    public class MusicShop : IMusicShop
    {
        private string name;

        private List<IArticle> articles = new List<IArticle>();

        public MusicShop(string name)
        {
            this.Name = name;
           
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public IList<IArticle> Articles
        {
            get
            {
                return this.articles;
            }
        }

        public void AddArticle(IArticle article)
        {
            this.articles.Add(article);
        }

        public void RemoveArticle(IArticle article)
        {
            this.articles.Remove(article);
        }

        public string ListArticles()
        {
            StringBuilder result = new StringBuilder();

            var header = string.Format("===== {0} =====\n", this.Name);
            result.Append(header);

            if (this.Articles.Count == 0)
            {
                result.AppendLine("The shop is empty. Come back soon.");
                return result.ToString();
            }
            
            var orderedArticles = this.articles.OrderBy(a => a.GetType() == typeof(Microphone))
                .ThenBy(a => a.GetType() == typeof(Drums))
                .ThenBy(a => a.GetType() == typeof(Electric))
                .ThenBy(a => a.GetType() == typeof(Acoustic))
                .ThenBy(a => a.GetType() == typeof(Bass));

            var microphones = new List<IArticle>();
            var drums = new List<IArticle>();
            var electric = new List<IArticle>();
            var acoustic = new List<IArticle>();
            var bass = new List<IArticle>();
            

            foreach (var article in orderedArticles)
            {
                if (article.GetType() == typeof(Microphone))
                {
                    microphones.Add(article);
                }
            }

            microphones.OrderBy(a => a.Make).ThenBy(a => a.Model);
            if (microphones.Count > 0)
            {
               result.AppendLine("----- Microphones -----");
                foreach (var microphone in microphones)
                {
                    result.AppendLine(microphone.ToString());
                }
                
            }

            foreach (var article in orderedArticles)
            {
                if (article.GetType() == typeof(Drums))
                {
                    drums.Add(article);
                }
            }

            drums.OrderBy(a => a.Make).ThenBy(a => a.Model);
            if (drums.Count > 0)
            {
                result.AppendLine("----- Drums -----");
                foreach (var drum in drums)
                {
                    result.AppendLine(drum.ToString());
                }

            }

            foreach (var article in orderedArticles)
            {
                if (article.GetType() == typeof(Electric))
                {
                    electric.Add(article);
                }
            }

            electric.OrderBy(a => a.Make).ThenBy(a => a.Model);
            if (electric.Count > 0)
            {
                result.AppendLine("----- Electric guitars -----");
                foreach (var el in electric)
                {
                    result.AppendLine(el.ToString());
                }

            }

            foreach (var article in orderedArticles)
            {
                if (article.GetType() == typeof(Acoustic))
                {
                    acoustic.Add(article);
                }
            }

            acoustic.OrderBy(a => a.Make).ThenBy(a => a.Model);
            if (acoustic.Count > 0)
            {
                result.AppendLine("----- Acoustic guitars -----");
                foreach (var ac in acoustic)
                {
                    result.AppendLine(ac.ToString());
                }

            }

            foreach (var article in orderedArticles)
            {
                if (article.GetType() == typeof(Bass))
                {
                    bass.Add(article);
                }
            }

            bass.OrderBy(a => a.Make).ThenBy(a => a.Model);
            if (bass.Count > 0)
            {
                result.AppendLine("----- Bass guitars -----");
                foreach (var bas in bass)
                {
                    result.AppendLine(bas.ToString());
                }

            }
            return result.ToString();
        }

    }
}
