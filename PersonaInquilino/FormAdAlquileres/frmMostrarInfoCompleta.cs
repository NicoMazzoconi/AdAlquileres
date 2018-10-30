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
	public partial class frmMostrarInfoCompleta : Form
	{
		private Inquilino inquilino;
		private Inmueble inmueble;
		private Contrato contrato;

		public frmMostrarInfoCompleta(Inquilino inquilino, Inmueble inmueble, Contrato contrato)
		{
			InitializeComponent();
			this.inquilino = inquilino;
			this.inmueble = inmueble;
			this.contrato = contrato;
		}

		private void frmMostrarInfoCompleta_Load(object sender, EventArgs e)
		{

		}

		private void rtbInfo_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
