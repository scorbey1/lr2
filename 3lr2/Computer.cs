using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2Part2
{
    internal class Computer : Technic
    {
        private string processor;
        private int ram; // GB
        private string graphicsCard;

        protected bool ProcessorValidation(string processor)
        {
            if (string.IsNullOrWhiteSpace(processor) || processor.Length < 2) return false;
            return true;
        }

        protected bool RAMValidation(int ram)
        {
            if (ram < 4 || ram > 1024 || (ram % 4 != 0)) return false; // от 4GB до 1TB RAM
            return true;
        }

        protected bool GraphicsCardValidation(string graphicsCard)
        {
            if (string.IsNullOrWhiteSpace(graphicsCard)) return false;
            return true;
        }

        // Конструкторы
        public Computer() : base()
        {
            this.Processor = "Unknown";
            this.RAM = 8;
            this.GraphicsCard = "Unknown";
        }

        public Computer(string processor, int ram, string graphicsCard,
            decimal price, string name, string color, int productionYear, double weight) :
            base(price, name, color, productionYear, weight)
        {
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
        }

        public Computer(string processor, int ram, string graphicsCard,
            decimal price, string name, string description, string color,
            int productionYear, double weight) :
            base(price, name, description, color, productionYear, weight)
        {
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
        }

        // Свойства
        public string Processor
        {
            get { return processor; }
            set
            {
                if (ProcessorValidation(value))
                    processor = value;
                else
                    processor = "Unknown";
            }
        }

        public int RAM
        {
            get { return ram; }
            set
            {
                if (RAMValidation(value))
                    ram = value;
                else
                    ram = 4;
            }
        }

        public string GraphicsCard
        {
            get { return graphicsCard; }
            set
            {
                if (GraphicsCardValidation(value))
                    graphicsCard = value;
                else
                    graphicsCard = "Unknown";
            }
        }
        //Абстрактные методы
        public override string GetDeviceType()
        {
            return "Computer";
        }
        public override string GetWarrantyInfo()
        {
            // Дорогие компьютеры = дольше гарантия
            if (price > 2000) return "Standard 36 month warranty";
            if (price > 1000) return "Standard 24 month warranty";
            return "Standard 12 month warranty"; // бюджетные модели
        }
        public override string GetBasicInfo()
        {
            return $"{name}: {price}$ \nDescription: {description} \nColor: {color} " +
                $"\nProduction Year: {productionYear} \nWeight: {weight}kg";
        }
        //Виртуальные методы
        public override string GetSpecificInfo()
        {
            return $"Processor: {processor} \nRAM: {ram}gb \nGraphics Card: {graphicsCard}";
        }
        // Доп методы
        public override string ToString()
        {
            return $"{name}: {price}$ \nDescription: {description} \nColor: {color} " +
                $"\nProduction Year: {productionYear} \nWeight: {weight}kg" +
                $"\nProcessor: {processor} \nRAM: {ram}gb \nGraphics Card: {graphicsCard}";
        }
    }
}
