using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionExamenCleanCode
{
    internal class EstablecimientoPublico:Establecimiento
    {
		private string numeroAutorizacion;
        private string serviciosAlimentacion;
        public string NumeroAutorizacion
        {
			get { return numeroAutorizacion; }
			set { numeroAutorizacion = value; }
		}
		
		public string ServiciosAlimentacion
        {
			get { return serviciosAlimentacion; }
			set { serviciosAlimentacion = value; }
		}


        public EstablecimientoPublico()
        {                
        }

        public EstablecimientoPublico(int nit, string razonSocial, char categoria, double arancelAnual, DateTime fechaRegistro, string numeroAutorizacion, string serviciosAlimentacion)
            :base(nit, razonSocial, categoria, arancelAnual, fechaRegistro)
        {
            NumeroAutorizacion=numeroAutorizacion;
            ServiciosAlimentacion=serviciosAlimentacion;
        }

        public override double CalcularArancelTotal()
        {
            return base.CalcularArancelTotal() + CalculoArancelAdicional(0.05);
        }
    }
}
