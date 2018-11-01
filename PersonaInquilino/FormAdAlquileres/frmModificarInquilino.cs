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
			for(int i = 0; i < inquilinos.Count; i++)
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
			inquilinos[id].Nombre = txtNombre.Text;
			inquilinos[id].Apellido = txtApellido.Text;
			double dni;
			if (double.TryParse(txtDni.Text, out dni))
				inquilinos[id].Dni = dni;
			double tel;
			if (double.TryParse(txtTelefono.Text, out tel))
				inquilinos[id].Telefono = tel;
			inquilinos[id].Email = txtEmail.Text;
			inquilinos[id].Domicilio = txtDomicilio.Text;
			inquilinos[id].Edad = (int)nudEdad.Value;
			Sexo sex;
			Enum.TryParse<Sexo>(cbSexo.SelectedValue.ToString(), out sex);
			inquilinos[id].Sexo = sex;
		}
	}
}
