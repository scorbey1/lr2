using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2Part2
{
    internal sealed class Scanner : Technic
    {
        private string scanType; // "Flatbed", "Sheetfed", "Handheld"
        private int opticalResolution; // DPI
        private int scanSpeed;

        private bool ScanTypeValidation(string scanType)
        {
            string[] validTypes = { "flatbed", "sheetfed", "handheld", "drum", "portable" };
            return validTypes.Contains(scanType.ToLowerInvariant().Trim());
        }

        private bool OpticalResolutionValidation(int resolution)
        {
            if (resolution < 100 || resolution > 48000) return false;
            return true;
        }

        private bool ScanSpeedValidation(int speed)
        {
            if (speed < 1 || speed > 200) return false;
            return true;
        }

        // Конструкторы
        public Scanner() : base()
        {
            this.ScanType = "flatbed";
            this.OpticalResolution = 300;
            this.ScanSpeed = 1;
        }

        public Scanner(string scanType, int opticalResolution, int scanSpeed,
            decimal price, string name, string color, int productionYear, double weight) :
            base(price, name, color, productionYear, weight)
        {
            this.ScanType = scanType;
            this.OpticalResolution = opticalResolution;
            this.ScanSpeed = scanSpeed;
        }

        public Scanner(string scanType, int opticalResolution, int scanSpeed,
            decimal price, string name, string description, string color,
            int productionYear, double weight) :
            base(price, name, description, color, productionYear, weight)
        {
            this.ScanType = scanType;
            this.OpticalResolution = opticalResolution;
            this.ScanSpeed = scanSpeed;
        }

        // Свойства
        public string ScanType
        {
            get { return scanType; }
            set
            {
                if (ScanTypeValidation(value))
                    scanType = value.ToLowerInvariant().Trim();
                else
                    scanType = "flatbed";
            }
        }

        public int OpticalResolution
        {
            get { return opticalResolution; }
            set
            {
                if (OpticalResolutionValidation(value))
                    opticalResolution = value;
                else
                    opticalResolution = 300;
            }
        }

        public int ScanSpeed
        {
            get { return scanSpeed; }
            set
            {
                if (ScanSpeedValidation(value))
                    scanSpeed = value;
                else
                    scanSpeed = 1;
            }
        }
        //Абстрактные методы
        public override string GetDeviceType()
        {
            return "Scanner";
        }
        public override string GetWarrantyInfo()
        {
            switch (ScanType)
            {
                case "flatbed": return "Standard 18 month warranty";
                case "sheetfed": return "Standard 12 month warranty";
                case "handheld": return "Standard 6 month warranty";
                case "drum": return "Standard 36 month warranty";
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
            return $"\nScan Type: {scanType} \nOptical Resolution: {opticalResolution}dpi \nScan Speed: {scanSpeed} sheets/min";
        }
        // Доп методы
        public override string ToString()
        {
            return $"{name}: {price}$ \nDescription: {description} \nColor: {color} " +
                $"\nProduction Year: {productionYear} \nWeight: {weight}kg" +
                $"\nScan Type: {scanType} \nOptical Resolution: {opticalResolution}dpi \nScan Speed: {scanSpeed} sheets/min";
        }
    }
}
