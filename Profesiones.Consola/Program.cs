using System;
using Profesiones.Implementacion;
using Profesiones.Negocio;
using Profesiones.AccesoDatos;
using Profesiones.Entidad;

namespace Profesiones.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Amigos ");
            Constructora MiConstructora = new Constructora();

            var carpintero2 = new CarpinteroEstandar();
            MiConstructora.ContratarCarpintero(carpintero2);
            MiConstructora.ConstruirMesa();
            
            var carpintero1 = new CarpinteroModerno 
            {
                Nombre = "juan",
                Apellido = "Aguirre"
            };

            var carpinteroModerno = MiConstructora.ContratarCarpintero(carpintero1);
            var carpinModernoConstruir = MiConstructora.ConstruirMesa();

            var carpintero = new CarpinteroMusical();
            carpintero.Id = 1;

            MiConstructora.ContratarCarpintero(carpintero);
            MiConstructora.ConstruirMesa();

            Console.WriteLine($"Este carpintero {carpintero1.Nombre} {carpintero1.Apellido} {carpinteroModerno} {carpinModernoConstruir} ");
            Console.ReadKey();

        }
    }
}
