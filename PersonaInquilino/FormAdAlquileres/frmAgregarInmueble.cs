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
	public partial class frmAgregarInmueble : Form
	{
        public Departamento dep;
        public Casa cas;

		public frmAgregarInmueble()
		{
			InitializeComponent();
		}

       

        public frmAgregarInmueble(Departamento d)
        {
            this.dep = d;
            InitializeComponent();
        }

        private void frmAgregarInmueble_Load(object sender, EventArgs e)
		{

		}

        private void btn_listo_Click(object sender, EventArgs e)
        {
            //this.dep = new Departamento(txt_direccion.Text,txt_localidad.Text,dateTimePicker1.Value,)
        }
    }
}
