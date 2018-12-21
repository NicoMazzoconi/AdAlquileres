using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paciente;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace InfoPacientes
{
	public partial class frmMain : Form
	{
		private List<Persona> pacientes;
		private int indexActivo;
	
		public frmMain()
		{
			InitializeComponent();
			pacientes = new List<Persona>();
			indexActivo = -1;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			timer1_Tick(sender, e);
			try
			{
				XmlTextReader leer;
				XmlSerializer ser;
				leer = new XmlTextReader("Save\\backUp.xml");
				ser = new XmlSerializer(typeof(List<Persona>));
				pacientes = (List<Persona>)(ser.Deserialize(leer));
				Persona.idSiguiente = pacientes[pacientes.Count-1].ID + 1;
				leer.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			frmListaPaciente lst = new frmListaPaciente(pacientes);
			lst.Show();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void frmMain_Enter(object sender, EventArgs e)
		{

		}

		private void frmMain_VisibleChanged(object sender, EventArgs e)
		{
			
		}

		private void frmMain_Activated(object sender, EventArgs e)
		{
			if (frmListaPaciente.indexPaciente != -1)
			{
				indexActivo = frmListaPaciente.indexPaciente;
			}

			if (indexActivo != -1)
			{
				label1.Text = pacientes[indexActivo].Nombre + " " + pacientes[indexActivo].Apellido;
				label1.BackColor = Color.Green;
				button2.Enabled = true;
				button3.Enabled = true;
				button5.Enabled = true;
			}
			else
			{
				label1.Text = "Sin seleccionar";
				button2.Enabled = false;
				button3.Enabled = false;
				button5.Enabled = false;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			frmInfoPaciente info = new frmInfoPaciente(pacientes[indexActivo]);
			info.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			/*frmFactura fac = new frmFactura();
			fac.Show();*/
			Excel.Application excel = new Excel.Application();
			Excel.Workbook sheet = excel.Workbooks.Open("A:\\a");
			Excel.Worksheet x = excel.ActiveSheet as Excel.Worksheet;
			x.Cells[2, 8] = "Probando";
		//	sheet.SaveAs(pacientes[indexActivo].Nombre + " " + pacientes[indexActivo].Apellido + " factura", Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel2FarEast, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing, Type.Missing,  )
			sheet.Close(true, Type.Missing, Type.Missing);
			excel.Quit();
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				XmlTextWriter escribir = new XmlTextWriter("Save\\backUp.xml", Encoding.ASCII);
				XmlSerializer ser = new XmlSerializer(typeof(List<Persona>));
				ser.Serialize(escribir, pacientes);
				escribir.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			frmAgregar agregar = new frmAgregar(pacientes);
			agregar.Show();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblFecha.Text = "Fecha: " + DateTime.Now.ToString();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			frmModificar mod = new frmModificar(pacientes, pacientes[indexActivo]);
			mod.Show();
		}
	}
}
