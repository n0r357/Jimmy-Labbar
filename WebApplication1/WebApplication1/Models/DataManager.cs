using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public static class DataManager
    {
        static List<Band> bands = new List<Band>()
        {
            new Band { Id = 1, Name = "Leprous", Description = "Progressive Metal" },
            new Band { Id = 2, Name = "Tool", Description = "Metal" },
            new Band { Id = 3, Name = "Alice In Chains", Description = "Grunge Metal" },
            new Band { Id = 4, Name = "Living Colour", Description = "Progressive Rock" }
        };

        static List<Album> albums = new List<Album>()
        {
            new Album { Title = "Bilateral", Label = "Inside Out Music", ImgUrl = "leprous.jpg"},
            new Album { Title = "10.000 Days", Label = "Tool Dissectional", ImgUrl = "tool.jpg"},
            new Album { Title = "Dirt", Label = "Columbia", ImgUrl = "alice.jpg"},
            new Album { Title = "Vivid", Label = "Epic", ImgUrl = "living.jpg"}
        };

        internal static void AddBand(Band band)
        {
            band.Id = bands.Max(o => o.Id) + 1;
            bands.Add(band);
        }

        /*
        public static Band GetId(int id)
        {
           return bands.SingleOrDefault(b => b.Id == (id));
        }
        */
        public static Band GetBand(int id)
        {
            return bands.SingleOrDefault(b => b.Id == id);
        }
        public static Band[] GetAllBands()
        {
            return bands.ToArray();
        }
        public static Album[] GetAllAlbums()
        {
            return albums.ToArray();
        }
        public static BandsIndexVM[] GetIndexList()
        {
            return bands.Select(b => new BandsIndexVM
            {
                Id = b.Id,
                Name = b.Name,
                IsMetal = b.Name.StartsWith("tool", StringComparison.OrdinalIgnoreCase)
            }).ToArray();
        }
    }
}
