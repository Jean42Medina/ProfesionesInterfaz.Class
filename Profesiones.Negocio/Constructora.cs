using Profesiones.Interface;
namespace Profesiones.Negocio
{
    public class Constructora
    {
        public ICarpintero Carpintero { get; set; }
        public string ContratarCarpintero(ICarpintero carpintero )
        {
            Carpintero = carpintero;
            return " Contrate un Carpintero";
        }
        public string ConstruirMesa()
        {
            return Carpintero.Diseñar() + "mesa" + Carpintero.Medir() + "mesa" + Carpintero.Clavar() + "mesa" + Carpintero.Lijar() + "mesa";                     
        }
        public string ContratarCarpintero()
        {
            return " Contrate un Carpintero";
        }
     }
}