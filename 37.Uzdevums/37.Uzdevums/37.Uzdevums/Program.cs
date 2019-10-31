using System;
using System.Collections.Generic;
using System.Linq;

namespace _37.Uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            var st1 = new StudyTabel()
            {
                Height = 90,
                Wight = 110,
                Legs = 4,
                Color = "white",
                Wood = "oak",
                Shelf = false
            };
            var st2 = new StudyTabel()
            {
                Height = 85,
                Wight = 115,
                Legs = 6,
                Color = "green",
                Wood = "oak",
                Shelf = true
            };
            var kt1 = new KitchenTabel()
            {
                Height = 100,
                Wight = 120,
                Legs = 3,
                Color = "blue",
                Wood = "oak"
            };
            var kt2 = new KitchenTabel()
            {
                Height = 95,
                Wight = 140,
                Legs = 5,
                Color = "red",
                Wood = "oak"
            };

            List<Tabel> tabelList = new List<Tabel>();
            tabelList.Add(st1);
            tabelList.Add(st2);
            tabelList.Add(kt1);
            tabelList.Add(kt2);

            var result = tabelList.Where(tl => tl.Height.Equals(95) || tl.Height.Equals(100));


            foreach (var item in result)
            {
                Console.WriteLine($"Height: {item.Height} || Wight: {item.Wight} || Legs: {item.Legs} || Color: {item.Color}");
            }
            Console.WriteLine($"Four persons: {kt1.PeopleExtend(4)}cm | Eight persons: {kt1.PeopleExtend(8)}cm");





        }
    }
}
