using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;
using System.Linq;

namespace GroupAssignment_L4.Models.Entities
{
    public partial class MotorbreathContext : DbContext
    {
        public MotorbreathContext(DbContextOptions<MotorbreathContext> options) : base(options)
        {
        }
        internal void AddCar(CarsCreateVM viewModel)
        { 
            Car car = new Car()
            { Brand = viewModel.Brand, Doors = viewModel.Doors, TopSpeed = viewModel.TopSpeed };
            Car.Add(car);
            SaveChanges();
        }
        internal CarsIndexVM[] ListCars()
        {
            return this.Car.Select(o => new CarsIndexVM
            {
                Brand = o.Brand,
                Doors = o.Doors,
                TopSpeed = o.TopSpeed,
                ShowAsFast = o.TopSpeed >= 250
            }).OrderBy(o => o.Brand).ToArray();
        }
    }
}