using System;
using System.Collections.Generic;
using System.Text;

namespace Profesiones.Interface
{
    class Constructora 
    {
        public ICarpintero Carpintero { get; set; }
        
        public string ContratarCarpintero() 
        {
            Carpintero = new Carpintero();
            return "Contrate un carpintero";
        }
        public string ContratarCarpinteroModerno()
        {
            Carpintero = new CarpinteroModerno();
            return "Contrate un carpintero Moderno";
        }
        
        public string ContratarOtroModerno()
        {
            Carpintero = new CarpinteroMusical();
            return "Contrate un carpintero Muscial";
        }
    }
}
