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
	public partial class frmModificarInquilino : Form
	{
        private List<Inquilino> inquilinos;
		private int id;

		public frmModificarInquilino(List<Inquilino> inquilinos, int index)
		{
			InitializeComponent();
			this.inquilinos = inquilinos;
			for(int i = 0; i < inquilinos.Count; i++)           //BUSCA INDEX DE LA LISTA INQUILINO EN BASE AL ID
			{
				if(inquilinos[i].ID == index)
				{
					id = index;
				}
			}
		}

		private void frmModificar_Load(object sender, EventArgs e)
		{
			cbSexo.DataSource = Enum.GetValues(typeof(Sexo));
			txtNombre.Text = inquilinos[id].Nombre;
			txtApellido.Text = inquilinos[id].Apellido;
			txtDni.Text = inquilinos[id].Dni.ToString();
			txtTelefono.Text = inquilinos[id].Telefono.ToString();
			txtEmail.Text = inquilinos[id].Email;
			txtDomicilio.Text = inquilinos[id].Domicilio;
			nudEdad.Value = inquilinos[id].Edad;
			cbSexo.Text = inquilinos[id].Sexo.ToString();
		}

		private void txtNombre_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtDomicilio_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_ok_Click(object sender, EventArgs e)
		{
			string mensajeError = "";

			if (txtNombre.Text != "")
				inquilinos[id].Nombre = txtNombre.Text;
			else
			{
				lblNombreError.Visible = true;
				mensajeError = mensajeError + "Nombre invalido, ";
			}

			if (txtApellido.Text != "")
				inquilinos[id].Apellido = txtApellido.Text;
			else
			{
				lblApellidoError.Visible = true;
				mensajeError = mensajeError + "Apellido invalido, ";
			}

			double dni;
			if (double.TryParse(txtDni.Text, out dni))
				inquilinos[id].Dni = dni;
			else
			{
				lblEdadError.Visible = true;
				mensajeError = mensajeError + "Dni invalido, ";
			}

			double tel;
			if (double.TryParse(txtTelefono.Text, out tel) && txtTelefono.Text != "")
				inquilinos[id].Telefono = tel;
			else
			{
				lblTelefonoError.Visible = true;
				mensajeError = mensajeError + "Telefono invalido, ";
			}

			if (!(txtEmail.Text is null))
				inquilinos[id].Email = txtEmail.Text;
			else
			{
				lblEmailError.Visible = true;
				mensajeError = mensajeError + "Email invalido";
			}

			if (txtDomicilio.Text != "" && !(txtDomicilio.Text is null))
				inquilinos[id].Domicilio = txtDomicilio.Text;
			else
			{
				lblDomicilioError.Visible = true;
				mensajeError = mensajeError + "Domicilio invalido";
			}

			int edad;
			if (int.TryParse(nudEdad.Value.ToString(), out edad))
				inquilinos[id].Edad = edad;
			else
			{
				lblEdadError.Visible = true;
				mensajeError = mensajeError + "Edad invalida, ";
			}

			Sexo sex;
			if (Enum.TryParse<Sexo>(cbSexo.SelectedValue.ToString(), out sex))
				inquilinos[id].Sexo = sex;
			else
			{
				lblSexoError.Visible = true;
				mensajeError = mensajeError + "Sexo invalido.";
			}

			if (mensajeError != "")
				 MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); 
			else
				this.Close();
		}
	}
}
