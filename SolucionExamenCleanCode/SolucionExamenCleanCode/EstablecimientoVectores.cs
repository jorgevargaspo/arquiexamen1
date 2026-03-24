using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionExamenCleanCode
{
    internal class EstablecimientoVectores: Establecimiento
    {
		private List<EquipoFumigacion> equipos;
        private string tipoTrabajo;
        private int cantidad;
           

        public List<EquipoFumigacion> Equipos
		{
			get { return equipos; }
			set { equipos = value; }
		}
		
		public string TipoTrabajo
        {
			get { return tipoTrabajo; }
			set { tipoTrabajo = value; }
		}
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public EstablecimientoVectores()
        {                
        }

        public EstablecimientoVectores(int nit, string razonSocial, char categoria, double arancelAnual, DateTime fechaRegistro, List<EquipoFumigacion> equipos, string tipoTrabajo, int cantidad)
            :base(nit, razonSocial, categoria, arancelAnual, fechaRegistro)
        {
            Equipos = equipos;
            TipoTrabajo=tipoTrabajo;
            Cantidad = cantidad;
        }

        public override double CalcularArancelTotal()
        {
            return base.CalcularArancelTotal() + CalculoArancelAdicional(0.02);
        }

    }
}
