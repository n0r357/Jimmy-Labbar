using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4
{
    public abstract class Vehicle
    {
        public List<Vehicle> AllStock { get; set; }
        public int Index { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return String.Format("{0,-6}\t{1,-6}\t{2,-6}\t{3,-20}\t{4,-10}\t{5,-6}\t{6,-10}\t{7,-10}\t{8,-6}", Index, Type, Status, Brand, Model, Year, Color, Price, Quantity);
        }
    }
}