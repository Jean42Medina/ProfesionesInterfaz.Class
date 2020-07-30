using System;
using System.Collections.Generic;
using System.Text;

namespace Profesiones.Interface
{
   public class CarpinteroMusical: ICarpintero
    {
        public string Diseñar()
        {
            return "Estoy diseñando con zuin";
        }
        public string Medir()
        {
            return "Estoy midiendo con musica ";
        }
        public string Serruchar()
        {
            return "Estoy serruchando con msucia Fm";
        }
        public string Clavar()
        {
            return "Estoy clavando con Flow";
        }
        public string Lijar()
        {
            return "Estoy lijando con musica romantica";
        }
        public string Lacar()
        {
            return "Estoy lacando con musica";
        }
    }
}
