
namespace FurnitureManufacturer.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using FurnitureManufacturer.Interfaces;

    public class Company : ICompany
    {
        private string name;

        private string registrationNumber;

        private List<IFurniture> furnitures = new List<IFurniture>();

        public Company(string name, string registrationNumber)
        {

            this.Name = name;
            this.RegistrationNumber = registrationNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            set
            {
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
            }

        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.Where(f => f.Model.ToLowerInvariant() == model.ToLowerInvariant()).FirstOrDefault();
        }

        public string Catalog() 
        {
            var result = new StringBuilder();
            string header = string.Format(
                "{0} - {1} - {2} {3}",
                this.Name,
                this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture");

            result.Append(header);

            var sortedFurnitures = this.furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model);
            foreach (var furniture in sortedFurnitures)
            {
                result.AppendLine();
                string furnitureStr = furniture.ToString();
                result.Append(furnitureStr);
            }
            return result.ToString();
        }
    }
}
