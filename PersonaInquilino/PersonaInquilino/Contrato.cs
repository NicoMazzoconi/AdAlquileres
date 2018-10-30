using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaInquilino
{
	public class Contrato
	{
		private DateTime fechaInicio;
		private DateTime fechaFin;
		private float precio;
		private int mesesParaAumento;
		private Inmueble inmueble;
		private string notaContrato;

		public Contrato(DateTime inicio, DateTime fin, float precio, int mesesParaAumento, Inmueble inmueble, string notaContrato)
		{
			this.fechaInicio = inicio;
			this.fechaFin = fin;
			this.precio = precio;
			this.mesesParaAumento = mesesParaAumento;
			this.inmueble = inmueble;
			this.notaContrato = notaContrato;
		}

		public DateTime FechaInicio
		{
			get
			{
				return fechaInicio;
			}
			set
			{
				this.fechaInicio = value;
			}
		}

		public DateTime FechaFin
		{
			get
			{
				return fechaFin;
			}
			set
			{
				this.fechaFin = value;
			}
		}

		public float Precio
		{
			get
			{
				return precio;
			}
			set
			{
				this.precio = value;
			}
		}

		public int MesAumento
		{
			get
			{
				return mesesParaAumento;
			}
			set
			{
				mesesParaAumento = value;
			}
		}

		public Inmueble Inmueble
		{
			get
			{
				return inmueble;
			}
			set
			{
				inmueble = value;
			}
		}

		public string NotaContrato
		{
			get
			{
				return notaContrato;
			}
			set
			{
				notaContrato = value;
			}
		}
	}
}
