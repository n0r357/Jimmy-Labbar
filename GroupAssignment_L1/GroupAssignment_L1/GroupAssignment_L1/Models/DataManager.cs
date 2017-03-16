using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L1.Models
{
    public static class DataManager
    {

        public static List<Band> bands = new List<Band>()
        {
            new Band { Id = 1, Name = "Oasis",              Description = "Wonderwall",   ImgUrl = "oasis-cover-art.png"          },
            new Band { Id = 2, Name = "The Stone Roses",    Description = "Love Spreads", ImgUrl = "stone-roses-cover-art.jpg"    },
            new Band { Id = 3, Name = "The Arctic Monkeys", Description = "Dancefloor",   ImgUrl = "arctic-monkeys-cover-art.jpg" },
        };

        public static Band GetBand(int id)
        {
            return bands
                .SingleOrDefault(b => b.Id == id);
        }

        public static Band[] GetAllBands()
        {
            return bands.ToArray();
        }
    }
}
