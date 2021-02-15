using System;

namespace CellPhone {
    class Program {
        static void Main(string[] args) {

            var cp1 = new CellPhone {
                PhoneNumber = "513-555-1212",
                Serviceprovider = "Verizon",
                OperatingSystem = "iOS",
                Capacity = 128,
                Model = "iPhone X"
            };
            var cp2 = new CellPhone {
                PhoneNumber = "614-555--1212",
                Serviceprovider = "T-Mobile",
                OperatingSystem = "Android",
                Capacity = 64,
                Model = "Samsung s6"
            };


            var cellphones = new CellPhone[] { cp1, cp2 };

            foreach (var CP in cellphones) {
                Console.WriteLine($"Phone Number is {CP.PhoneNumber}");
            }
        }
    }
}
