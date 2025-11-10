

namespace LabWork2Part2
{
    // сделать абстрактным
    internal abstract class Product
    {
        protected decimal price; // в $
        protected string name; // название товара
        protected string description; // описание товара
        protected bool PriceValidation(decimal price)
        {
            
            if (price <= 0) return false;
            return true;
        }
        protected bool NameValidation(string name)
        {
            
            if (name.Length <= 2 || string.IsNullOrEmpty(name))
                return false;
            return true;
        }
        protected bool DescriptionValidation(string description)
        {
            if (description.Length <= 2 || string.IsNullOrEmpty(description))
                return false;
            return true;
        }
        public Product()
        {
            this.Price = 1;
            this.Name = "Unknown";
            this.Description = "Unknown";
        }
        public Product(decimal price, string name)
        {
            this.Price = price;
            this.Name = name;
            this.Description = "Unknown";
        }
        public Product(decimal price, string name, string description)
        {
            this.Price = price;
            this.Name = name;
            this.Description = description;
        }
        // Свойства
        public decimal Price
        {
            get { return price; }
            set 
            { 
                if (PriceValidation(value)) 
                    price = value;
                else 
                    price = 0.1m; 
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (NameValidation(value))
                    name = value;
                else
                    name = "Unknown";
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (DescriptionValidation(value))
                    description = value;
                else
                    description = "Unknown";
            }
        }
        //Абстрактные классы
        public abstract string GetDeviceType();
        public abstract string GetWarrantyInfo();
        public abstract string GetBasicInfo();
        //Виртуальные методы
        public virtual string GetSpecificInfo()
        {
            return $"{name}: {price}$ \nDescription: {description}";
        }
        // Доп методы Object(ToString(), Equals(Product a, Product b), GetHashCode())
        public override string ToString()
        {
            return $"{name}: {price}$ \nDescription: {description}";
        }
        public static bool Equals(Product a, Product b)
        {
            if (a == null || b == null) return false;
            return a.Equals(b) ;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Product product) || obj == null) return false;
            return product.Price == this.Price && product.Name == this.Name && product.Description == this.Description;
        }
        public override int GetHashCode()
        {
            return price.GetHashCode() ^ ((name == null) ? 0:name.GetHashCode()) ^ ((description == null) ? 0 : description.GetHashCode());
        }
    }
}
