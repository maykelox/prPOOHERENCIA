using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clases;

namespace clases
{
    public class persona
    {
        //atributos
        private string apellidos;
        private string nombres;
        private string documento;
        private string tipo;
        
        //Propiedades
        public string Tipo { get => tipo; set => tipo = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
    }
}
