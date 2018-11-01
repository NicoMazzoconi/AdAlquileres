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
		private int idInquilino;
        

		public frmMain()
		{
			InitializeComponent();
			inquilinos = new List<Inquilino>();
			inmuebles = new List<Inmueble>();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
            Departamento a = new Departamento("Sarandi 148", "CABA", DateTime.Now, EEstado.Libre, 2, 35, false, false, false, 1, false, "Baño y concina nuevos", 5, 'A', true);
			Departamento a1 = new Departamento("Hipolito 148", "CABA", DateTime.Now, EEstado.Libre, 2, 35, false, false, false, 1, false, "Baño y concina nuevos", 5, 'A', true);
			Departamento a2 = new Departamento("Alsina 148", "CABA", DateTime.Now, EEstado.Libre, 2, 35, false, false, false, 1, false, "Baño y concina nuevos", 5, 'A', true);
			Departamento a3 = new Departamento("Rivadabia 148", "CABA", DateTime.Now, EEstado.Libre, 2, 35, false, false, false, 1, false, "Baño y concina nuevos", 5, 'A', true);
			inmuebles.Add(a);
			inmuebles.Add(a1);
			inmuebles.Add(a2);
			inmuebles.Add(a3);

			Inquilino b = new Inquilino("Nico", "Mazzo", 1232, 123123, Sexo.Hombre, "ssssssssd", "asdasdsadas", 25, new Garantia("Nico", "Mazzo", 1232, 123123, Sexo.Hombre, "ssss", "ssss", 25, "ss"), new Contrato(DateTime.Now, DateTime.Now, 222, 12, a, "sss"));
			Inquilino b1 = new Inquilino("Nico", "Mazzo", 1232, 123123, Sexo.Hombre, "ssss", "ssss", 25, new Garantia("Nico", "Mazzo", 1232, 123123, Sexo.Hombre, "ssss", "ssss", 25, "ss"), new Contrato(DateTime.Now, DateTime.Now, 222, 12, a1, "sss"));
			Inquilino b2 = new Inquilino("Nico", "Mazzo", 1232, 123123, Sexo.Hombre, "ssss", "ssss", 25, new Garantia("Nico", "Mazzo", 1232, 123123, Sexo.Hombre, "ssss", "ssss", 25, "ss"), new Contrato(DateTime.Now, DateTime.Now, 222, 12, a2, "sss"));
			Inquilino b3 = new Inquilino("Nico", "Mazzo", 1232, 123123, Sexo.Hombre, "ssss", "ssss", 25, new Garantia("Nico", "Mazzo", 1232, 123123, Sexo.Hombre, "ssss", "ssss", 25, "ss"), new Contrato(DateTime.Now, DateTime.Now, 222, 12, a3, "sss"));
			inquilinos.Add(b);
			inquilinos.Add(b1);
			inquilinos.Add(b2);
			inquilinos.Add(b3);

			timer2_Tick( sender,  e);
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
				ListViewItem item = new ListViewItem(b.ID.ToString());
				item.SubItems.Add(b.Nombre);
				item.SubItems.Add(b.Apellido);
				item.SubItems.Add(b.Telefono.ToString());
				item.SubItems.Add(b.Contrato.Inmueble.Direccion);
				lvInquilino.Items.Add(item);
			}
		}

		private void listView2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lvInquilino.SelectedItems.Count > 0)
			{
				ListViewItem index = lvInquilino.SelectedItems[0];
				idInquilino = Convert.ToInt32(index.SubItems[0].Text);
			}
		}

        private void btn_agregarDepartamento_Click(object sender, EventArgs e)
        {

        }

		private void button2_Click_1(object sender, EventArgs e)
		{
			frmModificarInquilino modInq = new frmModificarInquilino(inquilinos, idInquilino);
			modInq.Show();
		}

		private void tpInquilino_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			timer2_Tick(sender, e);

		}

		private void tpInquilino_Resize(object sender, EventArgs e)
		{

		}

		private void frmMain_MaximumSizeChanged(object sender, EventArgs e)
		{

		}
	}
}
