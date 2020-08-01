using System.Collections.Generic;

namespace Profesiones.Entidad
{
    public class Carpintero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        //propiedad automatica
        public string Apellido{ get; set; }
        public List<string> MaterialesparaClavar { get; set; }

    }
}
