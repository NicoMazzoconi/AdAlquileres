using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaInquilino
{
	public class Inmueble
	{
		private string direccion;

		public Inmueble(string dir)
		{
			direccion = dir;
		}

		public string Direccion
		{
			get
			{
				return direccion;
			}
		}
	}
}
