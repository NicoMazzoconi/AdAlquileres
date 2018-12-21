using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paciente
{
	[Serializable]
    public class Persona
	{
		public static int idSiguiente;
		private int id;
		private string nombre;
		private string apellido;
		private double dni;
		private double telefono;
		private string direccion;
		
		static Persona()
		{
			idSiguiente = 0;
		}

		public Persona()
		{ }

		public Persona(string nombre, string apellido, double dni, double telefono, string direccion)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.telefono = telefono;
			this.direccion = direccion;
			id = idSiguiente;
			idSiguiente++;
		}

		public int ID
		{
			get
			{
				return id;
			}
			set
			{
				id = value;
			}
		}

		public string Nombre
		{
			get
			{
				return nombre;
			}
			set
			{
				nombre = value;
			}
		}

		public string Apellido
		{
			get
			{
				return apellido;
			}
			set
			{
				apellido = value;
			}
		}

		public double Dni
		{
			get
			{
				return dni;
			}
			set
			{
				dni = value;
			}
		}

		public double Telefono
		{
			get
			{
				return telefono;
			}
			set
			{
				telefono = value;
			}
		}

		public string Direccion
		{
			get
			{
				return direccion;
			}
			set
			{
				direccion = value;
			}
		}

		public static bool operator ==(Persona a, Persona b)
		{
			if (a.Dni == b.Dni)
				return true;
			return false;
		}

		public static bool operator !=(Persona a, Persona b)
		{
			return !(a == b);
		}
    }
}
