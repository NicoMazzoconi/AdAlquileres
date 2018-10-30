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
        private List<Inmueble> inmuebles;

        public frmModificarInquilino()
		{
			InitializeComponent();
		}

		private void frmModificar_Load(object sender, EventArgs e)
		{

		}
	}
}
