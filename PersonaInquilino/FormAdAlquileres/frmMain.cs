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
			Departamento a = new Departamento("Sarandi 148", "CABA", DateTime.Now, EEstado.libre, 2, 35, false, false, false, 1, false, "Baño y concina nuevos", 5, 'A', true);
			Departamento a1 = new Departamento("Sarandi 148", "CABA", DateTime.Now, EEstado.libre, 2, 35, false, false, false, 1, false, "Baño y concina nuevos", 5, 'A', true);

			Departamento a2 = new Departamento("Sarandi 148", "CABA", DateTime.Now, EEstado.libre, 2, 35, false, false, false, 1, false, "Baño y concina nuevos", 5, 'A', true);

			Departamento a3 = new Departamento("Sarandi 148", "CABA", DateTime.Now, EEstado.libre, 2, 35, false, false, false, 1, false, "Baño y concina nuevos", 5, 'A', true);

			inmuebles.Add(a);
			inmuebles.Add(a1);

			inmuebles.Add(a2);

			inmuebles.Add(a3);
			timer2_Tick( sender,  e);
			//lvPropiedades.FocusedItem.Name;

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
			lblFecha.Text = "Fecha: " + DateTime.Now.ToString();
			label1.Text = inmuebles.Count.ToString();
			label2.Text = inquilinos.Count.ToString();
		}

		private void toolStripStatusLabel2_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			lvInquilino.Items.Clear();
			lvPropiedades.Items.Clear();
			foreach (Inmueble a in inmuebles)
			{
				ListViewItem item = new ListViewItem(a.Direccion);
				item.SubItems.Add(a.Estado.ToString());
				item.SubItems.Add("Proximamente");
				lvPropiedades.Items.Add(item);
			}

			foreach(Inquilino b in inquilinos)
			{
				ListViewItem item = new ListViewItem(b.Nombre);
				item.SubItems.Add(b.Apellido);
				item.SubItems.Add(b.Telefono.ToString());
				item.SubItems.Add(b.Contrato.Inmueble.Direccion);
				lvInquilino.Items.Add(item);
			}
		}

		private void listView2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
