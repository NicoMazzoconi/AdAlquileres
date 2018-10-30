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
	public partial class frmMain : Form
	{
		private List<Inquilino> inquilinos;
		private List<Inmueble> inmuebles;

        

		public frmMain()
		{
			InitializeComponent();
			inquilinos = new List<Inquilino>();
			inmuebles = new List<Inmueble>();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
            //Inmueble newInm = new Inmueble("ssss");
        }

		private void button1_Click(object sender, EventArgs e)
		{
			frmAgregarInquilino agrInq = new frmAgregarInquilino(inquilinos, inmuebles);
			agrInq.Show();
		}

        private void btn_Propiedad_Click(object sender, EventArgs e)
        {
            //frmAgregarInmueble agrInm = new frmAgregarInmueble()
        }

		private void lbl_fecha_Click(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lbl_fecha.Text = "Fecha: " + DateTime.Now.ToString();
		}
	}
}
