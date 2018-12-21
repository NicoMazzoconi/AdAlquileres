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
namespace InfoPacientes
{
	public partial class frmInfoPaciente : Form
	{
		private Persona paciente;

		public frmInfoPaciente(Persona paciente)
		{
			InitializeComponent();
			this.paciente = paciente;
		}

		private void frmInfoPaciente_Load(object sender, EventArgs e)
		{
			richTextBox1.ReadOnly = true;
			richTextBox1.Text = VerDatos(paciente);
		}

		private static string VerDatos(Persona paciente)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Paciente: {0} {1}\n", paciente.Nombre, paciente.Apellido);
			sb.AppendLine("DNI: " + paciente.Dni);
			sb.AppendLine("Telefono: " + paciente.Telefono);
			sb.AppendLine("Direccion: " + paciente.Direccion);
			return sb.ToString();
		}
	}
}
