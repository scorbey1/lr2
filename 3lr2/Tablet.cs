using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2Part2
{
    internal class Tablet: Technic
    {
        private decimal screenSize;// дюймы
        private int storage; // GB
        private bool hasGPS;
        protected bool ScreenSizeValidation(decimal screenSize)
        {
            if(screenSize < 7.0m || screenSize > 15.0m) 
                return false;
            return true;
        }
        protected bool StorageValidation(int storage)
        {
            if (storage > 2048 || storage < 16 || (storage % 4 != 0)) return false;
            return true;
        }
        // Конструкторы
        public Tablet() : base()
        {
            this.ScreenSize = 0m;
            this.Storage = 0;
            this.HasGPS = false;
        }
        public Tablet(decimal screenSize, int storage, bool hasGPS, 
            decimal price, string name,
            string color, int productionYear, double weight) :
            base(price, name, color, productionYear, weight)
        {
            this.ScreenSize = screenSize;
            this.Storage = storage;
            this.HasGPS = hasGPS;
        }
        public Tablet(decimal screenSize, int storage, bool hasGPS, 
            decimal price, string name, string description,
            string color, int productionYear, double weight) :
            base(price, name, description, color, productionYear, weight)
        {
            this.ScreenSize = screenSize;
            this.Storage = storage;
            this.HasGPS = hasGPS;
        }
        // Свойства
        public decimal ScreenSize
        {
            get { return screenSize; }
            set
            {
                if (ScreenSizeValidation(value))
                    screenSize = value;
                else
                    screenSize = 7.0m;
            }
        }
        public int Storage
        {
            get { return storage; }
            set
            {
                if (StorageValidation(value))
                    storage = value;
                else
                    storage = 16;
            }
        }
        public bool HasGPS
        {
            get { return hasGPS; }
            set { hasGPS = value; }
        }
        //Абстрактные методы
        public override string GetDeviceType()
        {
            return "Tablet";
        }
        public override string GetWarrantyInfo()
        {
            if (name.Contains("Pro") || name.Contains("Premium"))
                return "Standard 24 month warranty";

            if (screenSize > 10.0m)
                return "Standard 18 month warranty"; // большие планшеты

            return "Standard 12 month warranty"; // стандартные
        }
        public override string GetBasicInfo()
        {
            return $"{name}: {price}$ \nDescription: {description} \nColor: {color}" +
                $"\nProduction Year: {productionYear} \nWeight: {weight}kg";
        }
        //Виртуальные методы
        public override string GetSpecificInfo()
        {
            return $"Screen size: {screenSize} \nStorage: {storage}gb \nHas GPS: " + (hasGPS ? "Yes" : "No");
        }
        // Доп методы
        public override string ToString()
        {
            return $"{name}: {price}$ \nDescription: {description} \nColor: {color} " +
                $"\nProduction Year: {productionYear} \nWeight: {weight}kg" +
                $"\nScreen size: {screenSize} \nStorage: {storage}gb \nHas GPS: " + (hasGPS ?"Yes":"No");
        }
    }
}

