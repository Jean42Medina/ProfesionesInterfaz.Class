using System;
using Profesiones.Interface;
using Profesiones.Entidad;

using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class CarpinteroMusical : ICarpintero, IEquatable<CarpinteroMusical>
    {
        //Encapsulando y implementando carpintero musical
        private Carpintero carpintero = new Carpintero();
        public int Id { get{ return carpintero.Id; } set { carpintero.Id = value; }}

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
        public string Clavar()
        {
            return "Estoy clavando con musica ";
        }
        public string Lijar()
        {
            return "Estoy lijando ";
        }
        public string Lacar()
        {
            return "Estoy lacando ";
        }
        
        // interfaz por interpolacion
        public bool Equals([AllowNull] CarpinteroMusical other)
        {
            return this.Id == other.Id;
        }
    }
}
