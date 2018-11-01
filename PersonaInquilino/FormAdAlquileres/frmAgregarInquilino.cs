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
	public partial class frmAgregarInquilino : Form
	{
		private List<Inquilino> inquilinos;
		private List<Inmueble> inmuebles;

		public frmAgregarInquilino(List<Inquilino> lsInq, List<Inmueble> lsInm)
		{
			InitializeComponent();
			inquilinos = lsInq;
			inmuebles = lsInm;
		}

		private void frmAgregarInquilino_Load(object sender, EventArgs e)
		{
			cbSexo.DataSource = Enum.GetValues(typeof(Sexo));
			foreach(Inmueble a in inmuebles)
			{
				if (a.Estado != EEstado.Alquilado)
					if (a is Departamento)
					{
						cbInmueble.Items.Add(a.Direccion + ", " + a.Localidad + ", " + a.Mostrar());
					}
					else
					{
						cbInmueble.Items.Add(a.Direccion + ", " + a.Localidad);
					}

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string mensajeError = "";
			Sexo sexo;
			Inmueble inm = null;
			foreach (Inmueble a in inmuebles)
			{
				if (a is Departamento)
				{
					if (cbInmueble.Text == a.Direccion + ", " + a.Localidad + ", " + a.Mostrar())
					{
						inm = a;
						break;
					}
				}
				else
				{
					if(cbInmueble.Text == a.Direccion + ", " + a.Localidad)
					{
						inm = a;
						break;
					}
				}
			}
			if (inm is null)
			{
				mensajeError = mensajeError + "Inmueble invalido, ";
				lblInmuebleError.Visible = true;
				
			}
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
			if(lblTelefono.Text != "")
				if (!(double.TryParse(txtTelefono.Text, out tel)))
				{
					mensajeError = mensajeError + "Telefono invalido, ";
					lblTelefonoError.Visible = true;
				}
			if(txtDomicilio.Text == "")
			{
				mensajeError = mensajeError + "Domicilio invalido, ";
				lblDomicilioError.Visible = true;
			}
			if(!(int.TryParse(numericUpDown1.Value.ToString(), out edad)))
			{
				mensajeError = mensajeError + "Edad invalida, ";
				lblEdadError.Visible = true;
			}
			if(txtNombre.Text == "")
			{
				mensajeError = mensajeError + "Nombre invalido, ";
				lblNombreError.Visible = true;
			}
			if(txtApellido.Text == "")
			{
				mensajeError = mensajeError + "Apellido invalido, ";
				lblApellidoError.Visible = true;
			}
			if(txtEmail.Text is null)
			{
				mensajeError = mensajeError + "Email invalido.";
				lblEmailError.Visible = true;
			}
			if (mensajeError == "")
			{
				frmAgregarGarantia garantia = new frmAgregarGarantia(txtNombre.Text, txtApellido.Text, dni, tel, sexo, txtEmail.Text, txtDomicilio.Text, edad, inquilinos, inm);
				garantia.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show(/*"Complete correctamente los campos"*/mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}
		}

		private void btCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbInmueble_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
