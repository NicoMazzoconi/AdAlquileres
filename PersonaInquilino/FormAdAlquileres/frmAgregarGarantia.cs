﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonaInquilino;

namespace FormAdAlquileres
{
	public partial class frmAgregarGarantia : Form
	{
		private string nombreInq;
		private string apellidoInq;
		private double dniInq;
		private double telefonoInq;
		private Sexo sexoInq;
		private string emailInq;
		private string domicilioInq;
		private int edadInq;
		private List<Inquilino> inquilinos;
		private Inmueble inmueble;

		public frmAgregarGarantia(string nombre, string apellido, double dni, double tel, Sexo sexo, string email, string domicilio, int edad, List<Inquilino> inquilinos, Inmueble inmuebles)
		{
			InitializeComponent();
			this.nombreInq = nombre;
			this.apellidoInq = apellido;
			this.dniInq = dni;
			this.telefonoInq = tel;
			this.sexoInq = sexo;
			this.emailInq = email;
			this.domicilioInq = domicilio;
			this.edadInq = edad;
			this.inquilinos = inquilinos;
			this.inmueble = inmuebles;
		}

		private void frmAgregarGarantia_Load(object sender, EventArgs e)
		{
			cbSexo.DataSource = Enum.GetValues(typeof(Sexo));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string mensajeError = "";
			Sexo sexo;
			if (!(Enum.TryParse<Sexo>(cbSexo.SelectedValue.ToString(), out sexo)))
			{
				mensajeError = mensajeError + "Sexo invalido, ";
				lblSexoError.Visible = true;
			}

			double dni;
			double tel = 0;
			int edad;
			if (!(double.TryParse(txtDni.Text, out dni)))
			{
				mensajeError = mensajeError + "DNI invalido, ";
				lblDniError.Visible = true;
			}
			if (txtTelefono.Text != "")
				if (!(double.TryParse(txtTelefono.Text, out tel)))
				{
					mensajeError = mensajeError + "Telefono invalido, ";
					lblTelefonoError.Visible = true;
				}
			if (txtDomicilio.Text == "")
			{
				mensajeError = mensajeError + "Domicilio invalido, ";
				lblDomicilioError.Visible = true;
			}
			if (!(int.TryParse(nudEdad.Value.ToString(), out edad)))
			{
				mensajeError = mensajeError + "Edad invalida, ";
				lblEdadError.Visible = true;
			}
			if (txtNombre.Text == "")
			{
				mensajeError = mensajeError + "Nombre invalido, ";
				lblNombreError.Visible = true;
			}
			if (txtApellido.Text == "")
			{
				mensajeError = mensajeError + "Apellido invalido, ";
				lblApellidoError.Visible = true;
			}
			if(txtRelacion.Text is null)
			{
				mensajeError = mensajeError + "Relacion invalida";
				lblRelacionError.Visible = true;
			}
			if (txtEmail.Text is null)
			{
				mensajeError = mensajeError + "Email invalido.";
				lblEmailError.Visible = true;
			}
			if (mensajeError == "")
			{
				Garantia garantia = new Garantia(txtNombre.Text, txtApellido.Text, dni, tel, sexo, txtDomicilio.Text, txtEmail.Text, edad, txtRelacion.Text);
				frmAgregarContrato contrato = new frmAgregarContrato(nombreInq, apellidoInq, dniInq, telefonoInq, sexoInq, emailInq, domicilioInq, edadInq, garantia, inquilinos, inmueble);
				contrato.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
