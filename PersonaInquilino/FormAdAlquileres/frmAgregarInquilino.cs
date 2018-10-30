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
				cbInmueble.Items.Add(a.Direccion);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Sexo sexo;
			Enum.TryParse<Sexo>(cbSexo.SelectedValue.ToString(), out sexo);
			Inmueble inm = null;
			foreach (Inmueble a in inmuebles)
			{
				if (cbInmueble.Text == a.Direccion)
				{
					inm = a;
					break;
				}
			}
			frmAgregarGarantia garantia = new frmAgregarGarantia(txtNombre.Text, txtApellido.Text, Double.Parse(txtDni.Text), Double.Parse(txtTelefono.Text), sexo, txtEmail.Text, txtDomicilio.Text, int.Parse(numericUpDown1.Value.ToString()), inquilinos, inm);
			garantia.Show();
			this.Close();
		}

		private void btCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
