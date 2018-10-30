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
		private int index;

        public frmModificarInquilino(List<Inquilino> inquilinos, int index)
		{
			InitializeComponent();
			this.inquilinos = inquilinos;
			this.index = index;
		}

		private void frmModificar_Load(object sender, EventArgs e)
		{
			txtNombre.Text = inquilinos[index].Nombre;
			txtApellido.Text = inquilinos[index].Apellido;
			txtDni.Text = inquilinos[index].Dni.ToString();
			txtTelefono.Text = inquilinos[index].Telefono.ToString();
			txtEmail.Text = inquilinos[index].Email;
			txtDomicilio.Text = inquilinos[index].Domicilio;
			nudEdad.Value = inquilinos[index].Edad;
			cbSexo.SelectedValue = inquilinos[index].Sexo.ToString();
			cbInmueble.SelectedValue = inquilinos[index].Contrato.Inmueble.Direccion;
		}

		private void txtNombre_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
