using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2Part2
{
    internal class PrintingDevice : Technic
    {
        private string printTechnology; // "Laser", "Inkjet", "DotMatrix"
        private bool isColor;
        private int printSpeed; // количество страниц в минуту

        protected bool PrintTechnologyValidation(string technology)
        {
            string[] validTechnologies = { "Laser", "Inkjet", "DotMatrix", "Thermal", "Sublimation" };
            return validTechnologies.Contains(technology.ToLowerInvariant().Trim());
        }

        protected bool PrintSpeedValidation(int speed)
        {
            if (speed < 1 || speed > 1000) return false;
            return true;
        }

        // Конструкторы
        public PrintingDevice() : base()
        {
            this.PrintTechnology = "Laser";
            this.IsColor = false;
            this.PrintSpeed = 20;
        }

        public PrintingDevice(string printTechnology, bool isColor, int printSpeed,
            decimal price, string name, string color, int productionYear, double weight) :
            base(price, name, color, productionYear, weight)
        {
            this.PrintTechnology = printTechnology;
            this.IsColor = isColor;
            this.PrintSpeed = printSpeed;
        }

        public PrintingDevice(string printTechnology, bool isColor, int printSpeed,
            decimal price, string name, string description, string color,
            int productionYear, double weight) :
            base(price, name, description, color, productionYear, weight)
        {
            this.PrintTechnology = printTechnology;
            this.IsColor = isColor;
            this.PrintSpeed = printSpeed;
        }

        // Свойства
        public string PrintTechnology
        {
            get { return printTechnology; }
            set
            {
                if (PrintTechnologyValidation(value))
                    printTechnology = value.ToLowerInvariant().Trim();
                else
                    printTechnology = "Laser";
            }
        }

        public bool IsColor
        {
            get { return isColor; }
            set { isColor = value; }
        }

        public int PrintSpeed
        {
            get { return printSpeed; }
            set
            {
                if (PrintSpeedValidation(value))
                    printSpeed = value;
                else
                    printSpeed = 20;
            }
        }
        //Абстрактные методы
        public override string GetDeviceType()
        {
            return "Printing device";
        }
        public override string GetWarrantyInfo()
        {
            switch (PrintTechnology)
            {
                case "laser": return "Standard 24 month warranty";
                case "inkjet": return "Standard 12 month warranty";
                case "dotMatrix": return "Standard 36 month warranty";
                default: return "Standard 12 month warranty";
            }
        }
        public override string GetBasicInfo()
        {
            return $"{name}: {price}$ \nDescription: {description} \nColor: {color} " +
                $"\nProduction Year: {productionYear} \nWeight: {weight}kg";
        }
        //Виртуальные методы
        public override string GetSpecificInfo()
        {
            return $"\nPrint Technology: {printTechnology} \nPrint Speed: {printSpeed}sheets/min \nIs Color: " + (isColor ? "Yes" : "No");
        }
        // Доп методы
        public override string ToString()
        {
            return $"{name}: {price}$ \nDescription: {description} \nColor: {color} " +
                $"\nProduction Year: {productionYear} \nWeight: {weight}kg" +
                $"\nPrint Technology: {printTechnology} \nPrint Speed: {printSpeed}sheets/min \nIs Color: " + (isColor?"Yes":"No");
        }
    }
}
