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
            Console.WriteLine("Hello World!");
            Constructora MiConstructora = new Constructora();

            MiConstructora.ContratarCarpintero(new CarpinteroEstandar());
            MiConstructora.ConstruirMesa();
            
            var carpintero1 = new CarpinteroModerno();
            MiConstructora.ContratarCarpintero(new CarpinteroModerno());
            MiConstructora.ConstruirMesa();

            var carpintero = new CarpinteroMusical();
            carpintero.Id = 1;

            MiConstructora.ContratarCarpintero(carpintero);
            MiConstructora.ConstruirMesa();

            AplicationDbContext aplicationDbContext = new AplicationDbContext();
            aplicationDbContext.Carpinteros.Add(new Carpintero ());
            aplicationDbContext.SaveChanges();
            Console.ReadKey();
        }
    }
}
