using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionExamenCleanCode
{
    internal class  Establecimiento:IEstablecimiento
    {                        
		private int nit;
		private string razonSocial;
		private char categoria;
		private double arancelAnual;
        private DateTime fechaRegistro;

        public int Nit
        {
            get { return nit; }
            set { nit = value; }
        }
        public string RazonSocial
		{
			get { return razonSocial; }
			set { razonSocial = value; }
		}
        public char Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public double ArancelAnual
        {
            get { return arancelAnual; }
            set { arancelAnual = value; }
        }
        public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        public  Establecimiento() { }

        // Constructor principal
        public  Establecimiento(int nit, string razonSocial, char categoria, double arancelAnual, DateTime fechaRegistro)
        {
            Nit = nit;
            RazonSocial = razonSocial;
            Categoria = categoria;
            ArancelAnual = arancelAnual;
            FechaRegistro = fechaRegistro;
        }

        public int CalcularAntiguedad()
        {
            return DateTime.Now.Year-FechaRegistro.Year;
        }

        public virtual double CalcularArancelTotal()
        {
            return ArancelAnual;
        }

        public double CalculoArancelAdicional(double factor)
        {
            return CalcularAntiguedad() * factor * ArancelAnual;
        }

    }
}
