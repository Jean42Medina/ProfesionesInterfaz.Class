using System.Collections.Generic;
using Profesiones.Interface;

namespace Profesiones.Implementacion
{
    public class CarpinteroEstandar : ICarpintero
    {
        private List<string> materialesParaClavar; // Ejemplo: clavo, tachuelas => materiales para 
        private string nombre; // Ejemplo: Juan

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<string> MaterialesparaClavar { get { return materialesParaClavar; } set { materialesParaClavar = value; } }

        // Metodo
        public string Diseñar()
        {
            return "Estoy diseñando";
        }
        public string Medir()
        {
            return "Estoy midiendo con metro";
        }
        public string Serruchar()
        {
            return "Estoy serruchando";
        }
        public string Clavar()
        {
            return "Estoy clavando";
        }
        public string Lijar()
        {
            return "Estoy lijando";
        }
        public string Lacar()
        {
            return "Estoy lacando";
        }
    }
}
