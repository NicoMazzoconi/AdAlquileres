using System;
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
	public partial class frmAgregarContrato : Form
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
		private Garantia garantia;

		public frmAgregarContrato(string nombre, string apellido, double dni, double telefono, Sexo sexo, string email, string domicilio, int edad, Garantia garantia, List<Inquilino> inquilinos, Inmueble inmueble)
		{
			InitializeComponent();
			this.nombreInq = nombre;
			this.apellidoInq = apellido;
			this.dniInq = dni;
			this.telefonoInq = telefono;
			this.sexoInq = sexo;
			this.emailInq = email;
			this.domicilioInq = domicilio;
			this.edadInq = edad;
			this.inquilinos = inquilinos;
			this.inmueble = inmueble;
			this.garantia = garantia;
		}

		private void frmAgregarContrato_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string mensajeError = "";

			DateTime inicio = DateTime.Now;
			DateTime fin = DateTime.Now;
			if (dtpInicio.Value < dtpFin.Value)
			{
				inicio = dtpInicio.Value;
				fin = dtpFin.Value;
			}
			else
			{
				mensajeError = mensajeError + "Error en las fechas, ";
				lblFechaFinError.Visible = true;
				lblFechaInicioError.Visible = true;
			}

			float precio;
			if(!(float.TryParse(txtPrecio.Text, out precio)))
			{
				mensajeError = mensajeError + "Precio invalido, ";
				lblPrecioError.Visible = true;
			}

			int aumento;
			if(!(int.TryParse(txtAumento.Text, out aumento)))
			{
				mensajeError = mensajeError + "Aumento invalido, ";
				lblAumentoError.Visible = true;
			}

			int porcAumento;
			if(!(int.TryParse(txtPorcentaje.Text, out porcAumento)))
			{
				mensajeError = mensajeError + "Procentaje invalido, ";
				lblPorcAumentoError.Visible = true;
			}

			if(rtbNota.Text is null)
			{
				mensajeError = mensajeError + "Nota invalida";
				lblNotasError.Visible = true;
			}

			if(mensajeError == "")
			{
				Contrato contrato = new Contrato(inicio, fin, precio, aumento, inmueble, rtbNota.Text);
				Inquilino newInq = new Inquilino(nombreInq, apellidoInq, dniInq, telefonoInq, sexoInq, domicilioInq, emailInq, edadInq, garantia, contrato);
				inquilinos.Add(newInq);
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
