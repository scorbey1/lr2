using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2Part2
{
    internal class Program
    {
        static void Main()
        {
            Technic technic = new Technic(
                price: 299.99m,
                name: "Universal Electronic Device",
                color: "Graphite",
                productionYear: 2024,
                weight: 2.5
            );
            Tablet tablet = new Tablet(
                screenSize: 10.9m,
                storage: 256,
                hasGPS: true,
                price: 799.99m,
                name: "SuperTab Pro",
                description: "Flagship tablet with OLED display",
                color: "Space Gray",
                productionYear: 2024,
                weight: 0.47
            );
            Computer computer = new Computer(
                processor: "Intel Core i7-13700K",
                ram: 32,
                graphicsCard: "NVIDIA RTX 4070",
                price: 1899.99m,
                name: "Gaming Beast Pro",
                description: "High-performance gaming PC",
                color: "Black",
                productionYear: 2024,
                weight: 8.2
            );
            Scanner scanner = new Scanner(
                scanType: "Flatbed",
                opticalResolution: 4800,
                scanSpeed: 15,
                price: 349.99m,
                name: "ScanMaster 4800",
                description: "Professional flatbed scanner",
                color: "White",
                productionYear: 2023,
                weight: 4.1
            );
            PrintingDevice printer = new PrintingDevice(
                printTechnology: "Laser",
                isColor: false,
                printSpeed: 35,
                price: 449.99m,
                name: "LaserJet Pro MFP",
                description: "Monochrome laser multifunction printer",
                color: "Silver",
                productionYear: 2024,
                weight: 12.7
            );


            Product[] products = {technic, tablet, computer, scanner, printer};
            // Виртуальные методы
            Console.WriteLine("=== " + products[0].GetDeviceType() + " ===");
            Console.WriteLine(products[0].ToString());
            Console.WriteLine(products[0].GetWarrantyInfo());
            Console.WriteLine();
            Console.WriteLine("=== Specific information ===");
            Console.WriteLine(products[0].GetSpecificInfo());
            Console.WriteLine();

            Console.WriteLine("=== " + products[1].GetDeviceType() + " ===");
            Console.WriteLine(products[1].ToString());
            Console.WriteLine(products[1].GetWarrantyInfo());
            Console.WriteLine();
            Console.WriteLine("=== Specific information ===");
            Console.WriteLine(products[1].GetSpecificInfo());
            Console.WriteLine();

            Console.WriteLine("=== " + products[2].GetDeviceType() + " ===");
            Console.WriteLine(products[2].ToString());
            Console.WriteLine(products[2].GetWarrantyInfo());
            Console.WriteLine();
            Console.WriteLine("=== Specific information ===");
            Console.WriteLine(products[2].GetSpecificInfo());
            Console.WriteLine();

            Console.WriteLine("=== " + products[3].GetDeviceType() + " ===");
            Console.WriteLine(products[3].ToString());
            Console.WriteLine(products[3].GetWarrantyInfo());
            Console.WriteLine();
            Console.WriteLine("=== Specific information ===");
            Console.WriteLine(products[3].GetSpecificInfo());
            Console.WriteLine();

            Console.WriteLine("=== " + products[4].GetDeviceType() + " ===");
            Console.WriteLine(products[4].ToString());
            Console.WriteLine(products[4].GetWarrantyInfo());
            Console.WriteLine();
            Console.WriteLine("=== Specific information ===");
            Console.WriteLine(products[4].GetSpecificInfo());
            Console.WriteLine();

        }
    }
}
