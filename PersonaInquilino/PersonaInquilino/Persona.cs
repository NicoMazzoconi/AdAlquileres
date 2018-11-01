using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaInquilino
{
	public enum Sexo
	{
		Hombre,
		Mujer
	}
	public abstract class Persona
	{
		#region Atributos
		protected string nombre;
		protected string apellido;
		protected double dni;
		protected double telefono;
		protected Sexo sexo;
		protected string email;
		protected string domicilio;
		protected int edad;
		#endregion

		#region Constructores
		protected Persona(string nombre, string apellido, double dni, double telefono, Sexo sexo, string email, string domicilio, int edad)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.telefono = telefono;
			this.sexo = sexo;
			this.edad = edad;
			this.email = email;
			this.domicilio = domicilio;
		}
		#endregion

		#region Propiedades
		public abstract string Nombre
		{
			get;
			set;
		}

		public abstract string Apellido
		{
			get;
			set;
		}

		public abstract double Dni
		{
			get;
			set;
		}

		public abstract double Telefono
		{
			get;
			set;
		}

		public abstract Sexo Sexo
		{
			get;
			set;
		}

		public abstract string Email
		{
			get;
			set;
		}

		public abstract string Domicilio
		{
			get;
			set;
		}

		public abstract int Edad
		{
			get;
			set;
		}
		#endregion
	}
}
