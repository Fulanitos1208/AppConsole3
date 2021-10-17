using System;

namespace AppConsole3
{
    class Program
    {
         static void Main(string[] args)
        {
            Punto2D a;
            a = new Punto2D(0, 1);
            Console.WriteLine(a.ToString());

            Punto2D b;
            b = new Punto2D(0, 2);
            Console.WriteLine(b.ToString());

            double d = a.Distancia(b);
            Console.WriteLine(d);

            Punto3D c;
            c = new Punto3D(1,2,1);
            Console.WriteLine(c.ToString());
            
            Punto3D e;
            e = new Punto3D(1, 2,1 );
            Console.WriteLine(e.ToString());
            
            Punto3D f;
            f = new Punto3D(1, 2, 1);
            Console.WriteLine(f.ToString());

            double di = c.Distancia(f);
            Console.WriteLine(di);
            Console.ReadKey();

        }
    }
}
