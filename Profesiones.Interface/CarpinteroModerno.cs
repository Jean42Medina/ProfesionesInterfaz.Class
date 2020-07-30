
namespace Profesiones.Interface
{
        public class CarpinteroModerno: ICarpintero
        {
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
        }
}
