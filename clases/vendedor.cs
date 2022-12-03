using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class vendedor:persona
    {
        //Atributos
        private string tipoContrato;
        private string sueldo;

        //Propiedades
        public string Sueldo { get => sueldo; set => sueldo = value; }
        public string TipoContrato { get => tipoContrato; set => tipoContrato = value; }
        //Operaciones

        public void calcularSueldo(double sueldoBase)
        {
            if (this.TipoContrato == "C")
            {
                this.Sueldo = sueldoBase + 350;
            }
            else if (this.tipoContrato == "N")
            {
                this.Sueldo = sueldoBase + 750;
            }
            else
            {
                this.Sueldo = 0;
            }
        }
    }
}
