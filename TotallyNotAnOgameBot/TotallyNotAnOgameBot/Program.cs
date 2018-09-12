using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotallyNotAnOgameBot.Data.Resource;

namespace TotallyNotAnOgameBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var Surowce = new Resources(1000, 5000, 300);
            var Surowce2 = new Resources(500, 1000, 1000);
            var Surowce3 = new Resources(300, 100, 5000);
            var Surowce4 = new Resources();
            var Surowiec = new Resource(Resource.Type.Metal, 500);
            Surowce4.add(Surowce);
            long a = Surowce4.getMetalQuantity();
            long b = Surowce4.getCrystalQuantity();
            long c = Surowce4.getDeuterQuantity();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
            Surowce4.substract(Surowce);
            a = Surowce4.getMetalQuantity();
            b = Surowce4.getCrystalQuantity();
            c = Surowce4.getDeuterQuantity();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
            Surowce4.addResource(Surowiec);
            a = Surowce4.getMetalQuantity();
            b = Surowce4.getCrystalQuantity();
            c = Surowce4.getDeuterQuantity();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
            Surowce4.substractResource(Surowiec);
            a = Surowce4.getMetalQuantity();
            b = Surowce4.getCrystalQuantity();
            c = Surowce4.getDeuterQuantity();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();


        }
    }
}
