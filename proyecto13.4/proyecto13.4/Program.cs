using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto13._4
{
    class Program
    {
        public class Cuadrados
        {
            private float lado { get; set; }
            
            public void Cargar()
            {
                Console.Write("Dame el lado del cuadrado: ");
                lado = float.Parse(Console.ReadLine());
            }

            public void Perimetro()
            {
                float perimetro = lado * 4;
                Console.WriteLine("Perimetro es "+perimetro);
            }

            public void Superficie()
            {
                float superficie = lado * lado;
                Console.WriteLine("Superficie es " + superficie);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Cuadrados cuadrado = new Cuadrados();
                cuadrado.Cargar();
                cuadrado.Perimetro();
                cuadrado.Superficie();
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");                
            }
            Console.ReadKey();
        }
    }
}
