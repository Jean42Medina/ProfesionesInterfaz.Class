namespace Profesiones.Interface 
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
            Carpintero = new Carpintero();
            return " Contrate un Carpintero";
        }
        public string ContratarCarpinteroModerno()
        {
            Carpintero = new CarpinteroModerno();
            return " Contrate un Carpintero Moderno";
        }
        public string ContratarOtroCarpintero()
        {
            Carpintero = new CarpinteroMusical();
           return " Contrate un Carpintero Musical";
        }
     }
}