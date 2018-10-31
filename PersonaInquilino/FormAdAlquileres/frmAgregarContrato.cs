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
			Contrato contrato = new Contrato(dtpInicio.Value, dtpFin.Value, float.Parse(txtPrecio.Text), Int32.Parse(txtAumento.Text), inmueble, rtbNota.Text);
			Inquilino newInq = new Inquilino(nombreInq, apellidoInq, dniInq, telefonoInq, sexoInq, domicilioInq, emailInq, edadInq, garantia, contrato);
			inquilinos.Add(newInq);
			inmueble.Estado = EEstado.Alquilado;
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
