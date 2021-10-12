using System;

namespace AppConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto3D a;
            a = new Punto3D(524,.255,564.25);
            Console.WriteLine(a.ToString());
            Console.ReadKey();
        }
    }
}
//Math.Sqrt(( x2-x)^2+(y2-y)^2) es la formula para calcular la distancia pero como
//no termine la clase no la agregue por que me aparecian mucjhos errores de compilación
