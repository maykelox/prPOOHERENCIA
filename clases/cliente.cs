using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
        public class cliente:persona
        {
        //Atributos propio de esta clase
        private string categoria;
        private string codigo;

        //Propiedades
        public string Cogido { get => codigo; set => codigo = value; }
        public string Categoria { get => categoria; set => categoria = value; }

        public void generarCodigo()
        {
            this.codigo = "C" + this.Apellidos.Substring(0, 3) + 16;

        }
    }
}
