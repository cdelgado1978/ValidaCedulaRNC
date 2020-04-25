using System;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
           



        }

        private static void MostrarMenu()
        {
            Console.WriteLine("Validador Cedula y RNC");
            Console.WriteLine("Que Desea Validar?");
            Console.WriteLine("1. Cedula");
            Console.WriteLine("2. RNC");

            var opcion = Console.ReadLine();

            if (int.Parse(opcion) == 1)
            {
                Console.WriteLine("Digite su Cedula: ");

                var _cedula = Console.ReadLine();

                var validador = new PG.Validador.Cedula(_cedula);
                var result = validador.Valida();

                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine("Digite su RNC: ");

                var _rnc = Console.ReadLine();

                var validador = new PG.Validador.RNC(_rnc);
                var result = validador.Valida();

                Console.WriteLine(result);

            }
            Console.WriteLine("");
            Console.WriteLine("Desea Realizar otra consulta?: S/N");
            var decision = Console.ReadLine();

            if (decision.ToLower() == "s")
            {
                Console.Clear();

                MostrarMenu();
            }

            Console.ReadLine();
        }
    }
}
