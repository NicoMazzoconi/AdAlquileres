using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaInquilino
{
	public class Garantia	:Persona
	{
		private string relacion;

		public Garantia(string nombre, string apellido, double dni, double telefono, Sexo sexo, string domicilio, string email, int edad, string relacion) : base(nombre, apellido, dni, telefono, sexo, email, domicilio, edad)
		{
			this.relacion = relacion;
		}

		public override string Nombre
		{
			get
			{
				return nombre;
			}
			set
			{
				if (value.Length > 2 && value.Length < 25)
				{
					foreach (char letra in value)
					{
						if ((letra > 'a' && letra < 'z') || (letra > 'A' && letra < 'Z'))
							nombre = value;
					}
				}
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
				if (value.Length > 2 && value.Length < 25)
				{
					foreach (char letra in value)
					{
						if ((letra > 'a' && letra < 'z') || (letra > 'A' && letra < 'Z'))
							nombre = value;
					}
				}
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
				if (dni > 1000000 && dni < 99999999)
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
				if (value.ToString().Length > 6) // ej 477344 && 02396546092 (convierto a string para ver la cantidad de letras y de ahi estimo las necesarios para que sea un numero valido)
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
				if (value.Length > 8)
				{
					domicilio = value;
				}
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
				if (value > 17)
					this.edad = value;
			}
		}

		public string Relacion
		{
			get
			{
				return this.relacion;
			}

			set
			{
				this.relacion = value;
			}
		}
	}
}

