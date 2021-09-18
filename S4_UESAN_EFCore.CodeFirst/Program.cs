using S4_UESAN_EFCore.CodeFirst.Models;
using System;
using System.Collections.Generic;

namespace S4_UESAN_EFCore.CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using var context = new MundialDBContext();

            //var position = new SoccerPosition()
            //{
            //    Description = "Portero",
            //    Code = "PT"
            //};

            //context.SoccerPosition.Add(position);
            //context.SaveChanges();

            var position1 = new SoccerPosition()
            {
                Description = "Lateral Izquierdo",
                Code = "LI"
            };

            var position2 = new SoccerPosition()
            {
                Description = "Lateral Derecho",
                Code = "LD"
            };

            var position3 = new SoccerPosition()
            {
                Description = "Mediocampista Ofensivo",
                Code = "MO"
            };

            var position4 = new SoccerPosition()
            {
                Description = "Gianluca Ladapula",
                Code = "CD"
            };
            var positionList = new List<SoccerPosition>();
            positionList.Add(position1);
            positionList.Add(position2);
            positionList.Add(position3);
            positionList.Add(position4);

            context.SoccerPosition.AddRange(positionList);
            context.SaveChanges();



        }
    }
}
