using System.Collections.Generic;
using Profesiones.Interface;

namespace Profesiones.Inplementacion
{
    public class  CarpinteroAntiguo : ICarpintero
    {
        // utilizamos sustantivos para definir atributos
        private List<string> materialesParaClavar; // Ejemplo: clavo, tachuelas => materiales para 
        private string nombre; // Ejemplo: Juan
        
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<string> MaterialesparaClavar { get { return materialesParaClavar; } set { materialesParaClavar = value;} }

        // Metodos 
        public string Clavar() 
        {
            return $" Mi nombre es {nombre} y estoy clavando {materialesParaClavar[0]}";
        }
        public string Diseñar()
        {
            return "Estoy diseñando ";
        }
        public string Medir()
        {
            return "Estoy midiendo ";
        }
        public string Serruchar()
        {
            return "Estoy serruchando ";
        }
        public string Lijar()
        {
            return "Estoy lijando ";
        }
        public string Lacar()
        {
            return "Estoy lacando ";
        }
    }
}
