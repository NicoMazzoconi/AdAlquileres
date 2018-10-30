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
			Sexo sexo;
			Enum.TryParse<Sexo>(cbSexo.SelectedValue.ToString(), out sexo);

			Garantia garantia = new Garantia(txtNombre.Text, txtApellido.Text, Double.Parse(txtDni.Text), Double.Parse(txtTelefono.Text), sexo, txtDomicilio.Text, txtEmail.Text, Int32.Parse(nudEdad.Value.ToString()), txtRelacion.Text);

			frmAgregarContrato contrato = new frmAgregarContrato(nombreInq, apellidoInq, dniInq, telefonoInq, sexoInq, emailInq, domicilioInq, edadInq, garantia, inquilinos, inmueble);
			contrato.Show();
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
