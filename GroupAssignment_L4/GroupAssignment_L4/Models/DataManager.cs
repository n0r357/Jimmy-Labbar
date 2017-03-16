using GroupAssignment_L4.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L4.Models
{
    public class DataManager
    {
        /*
        static List<Car> cars = new List<Car>()
        {
            new Car { Id = 1, Brand = "Fiat", Doors = 4, TopSpeed = 150 },
            new Car { Id = 2, Brand = "Volvo", Doors = 5, TopSpeed = 200 },
            new Car { Id = 3, Brand = "Ferrari", Doors = 3, TopSpeed = 250 },
            new Car { Id = 4, Brand = "Koenigsegg", Doors = 3, TopSpeed = 300 }
        };
        internal static void AddCar(CarsCreateVM viewModel)
        {
            MotorbreathContext db = new MotorbreathContext();
            Car car = new Car()
            { Id = cars.Max(o => o.Id) + 1, Brand = viewModel.Brand, Doors = viewModel.Doors, TopSpeed = viewModel.TopSpeed };
            cars.Add(car);
        }
        internal static CarsIndexVM[] ListCars()
        {
            return cars.Select(o => new CarsIndexVM
            {
                Brand = o.Brand,
                Doors = o.Doors,
                TopSpeed = o.TopSpeed,
                ShowAsFast = o.TopSpeed >= 250
            }).ToArray();
        }
        */
        /*
        private static bool IsFast(int inputSpeed)
        {
            if (inputSpeed >= 250)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */
    }
}
