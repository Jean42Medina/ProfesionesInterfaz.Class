using Profesiones.Interface;
using Profesiones.Entidad;
using System;
using System.Diagnostics.CodeAnalysis;


namespace Profesiones.Implementacion
{
    // intefaz por herencia => : Carpintero
        public class CarpinteroModerno: Carpintero, ICarpintero, IEquatable<CarpinteroModerno>
        {
        
          // meto
            public string Diseñar()
            {
                return "Estoy diseñando con AutoCad";
            }
            public string Medir()
            {
                return "Estoy midiendo con laser";
            }
            public string Serruchar()
            {
                return "Estoy serruchando con maquina";
            }
            public string Clavar()
            {
                return "Estoy clavando con pistola de aire comprimido";
            }
            public string Lijar()
            {
                return "Estoy lijando con lijado de absorcion";
            }
            public string Lacar()
            {
                return "Estoy lacando con secado instantaneo";
            }

        public bool Equals([AllowNull] CarpinteroModerno other)
        {
            return this.Id == other.Id;
        }
    }
}
