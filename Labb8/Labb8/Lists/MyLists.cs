using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    class MyLists
    {
        public List<string> MyStrings { get; set; }
        public List<float> MyFloats { get; set; }
        public List<IProduct> ProductList { get; set; }

        public MyLists()
        {
            MyStrings = new List<string>()
            {
                "String 1",
                "String 2",
                "String 3",
                "String 4",
                "String 5",
                "String 6"
            };

            MyFloats = new List<float>()
            {
                1.1f,
                2.2f,
                3.3f,
                4.4f,
                5.5f
            };

            ProductList = new List<IProduct>()
            {
                new Product { Id = 1, Name = "NOCCO", Price = 25 },
                new Product { Id = 2, Name = "QuestBar", Price = 25 },
                new Product { Id = 3, Name = "FitClean", Price = 20 },
                new Product { Id = 4, Name = "BattleOats", Price = 20 },
                new Product { Id = 5, Name = "KettleBell", Price = 1200 },
                new Product { Id = 6, Name = "BarBell", Price = 2000 }
            };
        }
    }
}
