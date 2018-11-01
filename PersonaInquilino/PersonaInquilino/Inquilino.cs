using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaInquilino
{
	public class Inquilino : Persona
	{
		private Garantia garantia;
		private Contrato contrato;
		private int id;
		private static int nextId;

		static Inquilino()
		{
			nextId = 0;
		}

		public Inquilino(string nombre, string apellido, double dni, double telefono, Sexo sexo, string domicilio, string email, int edad, Garantia garantia, Contrato contrato) : base(nombre, apellido, dni, telefono, sexo, email, domicilio, edad)
		{
			this.garantia = garantia;
			this.contrato = contrato;
			id = nextId;
			nextId++;
		}

		public int ID
		{
			get
			{
				return id;
			}
		}

		public override string Nombre
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

		public override string Apellido
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

		public override double Dni
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

		public override double Telefono
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

		public override Sexo Sexo
		{
			get
			{
				return sexo;
			}
			set
			{
				sexo = value;
			}
		}

		public override string Domicilio
		{
			get
			{
				return domicilio;
			}
			set
			{
				domicilio = value;
			}
		}

		public override string Email
		{
			get
			{
				return email;
			}
			set
			{
				email = value;
			}
		}

		public override int Edad
		{
			get
			{
				return this.edad;
			}
			set
			{
				this.edad = value;
			}
		}

		public Garantia Garantia
		{
			get
			{
				return garantia;
			}
			set
			{
				this.garantia = value;
			}
		}

		public Contrato Contrato
		{
			get
			{
				return contrato;
			}
			set
			{
				this.contrato = value;
			}
		}

		public static bool operator ==(Inquilino a, Inquilino b)
		{
			if (a.Dni == b.Dni)
				return true;
			return false;
		}

		public static bool operator !=(Inquilino a, Inquilino b)
		{
			return !(a == b);
		}
	}
}
