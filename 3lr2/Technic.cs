
using System.Collections.Generic;


namespace LabWork2Part2
{
    internal class Technic: Product
    {
        protected string color;
        protected int productionYear;
        protected double weight;
        private static readonly HashSet<string> colorsSet = new HashSet<string> {
            // Основные цвета
            "black", "white", "gray", "silver", "red", "blue", "green", "yellow",
            "orange", "purple", "pink", "brown", "gold", "navy", "teal", "maroon",
    
            // Технические/металлические
            "graphite", "charcoal", "slate", "steel", "aluminum", "titanium",
            "platinum", "chrome", "nickel", "copper", "bronze", "brass",
            "gunmetal", "pewter", "iron", "metallic gray",
    
            // Современные техно-цвета
            "space gray", "midnight", "starlight", "sierra blue", "deep purple",
            "phantom black", "aura glow", "prism", "crystal", "glacier",
            "polaris", "nebula", "cosmic", "lunar", "solar",
    
            // Природные оттенки
            "forest green", "olive", "sage", "mint", "emerald", "jade",
            "ocean blue", "sky blue", "azure", "cobalt", "sapphire",
            "burgundy", "ruby", "crimson", "scarlet", "coral",
    
            // Нейтральные и минималистичные
            "ivory", "cream", "beige", "sand", "taupe", "khaki",
            "ebony", "onyx", "obsidian", "carbon", "ash", "smoke",
    
            // Специальные техно-оттенки
            "cyber", "matrix", "holographic", "transparent", "frosted",
            "matte black", "glossy white", "brushed metal", "anodized",
            "electric blue", "neon green", "led red", "plasma purple",
    
            // Брендовые цвета техники
            "macbook silver", "imac blue", "surface platinum", "thinkpad black",
            "dell black", "hp blue", "samsung black", "sony black",
    
            // Дополнительные
            "lavender", "lilac", "mauve", "peach", "salmon", "terracotta",
            "turquoise", "aqua", "cyan", "magenta", "violet", "indigo",
            "amber", "mustard", "ochre", "rust", "bronze", "copper" };
        protected bool ColorValidation(string color)
        {
            return colorsSet.Contains(color.ToLowerInvariant().Trim());
        }
        protected bool ProductionYearValidation(int productionYear)
        {
            if (productionYear > 2025 || productionYear < 1950) return false;
            return true;
        }
        protected bool WeightValidation(double weight)
        {
            if(weight <= 0) return false;
            return true;
        }

        // Конструкторы
        public Technic():base()
        {
            this.Color = "";
            this.ProductionYear = 0;
            this.Weight = 0;
        }
        public Technic(decimal price, string name, 
            string color, int productionYear, double weight): 
            base(price, name) 
        {
            this.Color = color;
            this.ProductionYear = productionYear;
            this.Weight = weight;
        }
        public Technic(decimal price, string name, string description,
            string color, int productionYear, double weight) :
            base(price, name, description)
        {
            this.Color = color;
            this.ProductionYear = productionYear;
            this.Weight = weight;
        }
        // Свойства
        public string Color
        {
            get { return color; }
            set 
            {
                if (ColorValidation(value))
                    color = value;
                else
                    color = "Unknown";
            }
        }
        public int ProductionYear
        {
            get { return productionYear; }
            set 
            {
                if (ProductionYearValidation(value))
                    productionYear = value;
                else
                    productionYear = 2025;
            }
        }
        public double Weight
        {
            get { return weight; }
            set 
            {
                if (WeightValidation(value))
                    weight = value;
                else
                    weight = 0.1d;
            }
        }
        //Абстрактные методы
        public override string GetDeviceType()
        {
            return "Technic";
        }
        public override string GetWarrantyInfo()
        {
            return "Standard 12 month warranty";
        }
        public override string GetBasicInfo()
        {
            return $"{name}: {price}$ \nDescription: {description}";
        }
        //Виртуальные методы
        public override string GetSpecificInfo()
        {
            return $"Color: {color} \nProduction Year: {productionYear} \nWeight: {weight}kg";
        }

        // Доп методы
        public override string ToString()
        {
            return $"{name}: {price}$ \nDescription: {description} \nColor: {color} " +
                $"\nProduction Year: {productionYear} \nWeight: {weight}kg";
        }
    }
}
