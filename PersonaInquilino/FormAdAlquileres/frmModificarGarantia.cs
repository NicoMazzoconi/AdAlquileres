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
	public partial class frmModificarGarantia : Form
	{
		private List<Inquilino> inquilinos;
		private int indexInq;
		public frmModificarGarantia(List<Inquilino> inquilinos, int index)
		{
			InitializeComponent();

			this.inquilinos = inquilinos;

			for (int i = 0; i < inquilinos.Count; i++)		//BUSCA INDEX DE LA LISTA INQUILINO EN BASE AL ID
			{
				if (inquilinos[i].ID == index)
				{
					indexInq = index;
				}
			}
		}

		private void frmModificarGarantia_Load(object sender, EventArgs e)
		{
			cbSexo.DataSource = Enum.GetValues(typeof(Sexo));
			txtNombre.Text = inquilinos[indexInq].Garantia.Nombre;
			txtApellido.Text = inquilinos[indexInq].Garantia.Apellido;
			txtEmail.Text = inquilinos[indexInq].Garantia.Email;
			txtDomicilio.Text = inquilinos[indexInq].Garantia.Domicilio;
			txtRelacion.Text = inquilinos[indexInq].Garantia.Relacion;
			txtDni.Text = inquilinos[indexInq].Garantia.Dni.ToString();
			txtTelefono.Text = inquilinos[indexInq].Garantia.Telefono.ToString();
			cbSexo.Text = inquilinos[indexInq].Garantia.Sexo.ToString();
			nudEdad.Value = inquilinos[indexInq].Garantia.Edad;
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
			if (txtRelacion.Text is null)
			{
				mensajeError = mensajeError + "Relacion invalida";
				lblRelacionError.Visible = true;
			}
			if (txtEmail.Text is null)
			{
				mensajeError = mensajeError + "Email invalido.";
				lblEmailError.Visible = true;
			}
			if (mensajeError == "")															//Si no hay error asiganmos
			{
				inquilinos[indexInq].Garantia.Nombre = txtNombre.Text;				
				inquilinos[indexInq].Garantia.Apellido = txtApellido.Text;
				inquilinos[indexInq].Garantia.Email = txtEmail.Text;
				inquilinos[indexInq].Garantia.Telefono = tel;
				inquilinos[indexInq].Garantia.Dni = dni;
				inquilinos[indexInq].Garantia.Edad = edad;
				inquilinos[indexInq].Garantia.Relacion = txtRelacion.Text;
				inquilinos[indexInq].Garantia.Sexo = sexo;
				inquilinos[indexInq].Garantia.Domicilio = txtDomicilio.Text;
				this.Close();
			}
			else																		//Si hay error mostramos messageBox
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
