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
	public partial class frmModificarContrato : Form
	{
		private List<Inquilino> inquilinos;
		private int indexId;

		public frmModificarContrato(List<Inquilino> inquilinos, int id)
		{
			InitializeComponent();
			this.inquilinos = inquilinos;

			for (int i = 0; i < inquilinos.Count; i++)      //BUSCA INDEX DE LA LISTA INQUILINO EN BASE AL ID
			{
				if (inquilinos[i].ID == id)
				{
					indexId = id;
				}
			}
		}

		private void frmModificarContrato_Load(object sender, EventArgs e)
		{
			dtpInicio.Value = inquilinos[indexId].Contrato.FechaInicio;
			dtpFin.Value = inquilinos[indexId].Contrato.FechaFin;
			txtPrecio.Text = inquilinos[indexId].Contrato.Precio.ToString();
			txtAumento.Text = inquilinos[indexId].Contrato.MesAumento.ToString();
			rtbNota.Text = inquilinos[indexId].Contrato.NotaContrato;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string mensajeError = "";

			DateTime inicio = DateTime.Now;
			DateTime fin = DateTime.Now;
			if (dtpInicio.Value < dtpFin.Value)
			{
				inicio = dtpInicio.Value;
				fin = dtpFin.Value;
			}
			else
			{
				mensajeError = mensajeError + "Error en las fechas, ";
				lblFechaFinError.Visible = true;
				lblFechaInicioError.Visible = true;
			}

			float precio;
			if (!(float.TryParse(txtPrecio.Text, out precio)))
			{
				mensajeError = mensajeError + "Precio invalido, ";
				lblPrecioError.Visible = true;
			}

			int aumento;
			if (!(int.TryParse(txtAumento.Text, out aumento)))
			{
				mensajeError = mensajeError + "Aumento invalido, ";
				lblAumentoError.Visible = true;
			}

			int porcAumento;
			if (!(int.TryParse(txtPorcentaje.Text, out porcAumento)))
			{
				mensajeError = mensajeError + "Procentaje invalido, ";
				lblPorcAumentoError.Visible = true;
			}

			if (rtbNota.Text is null)
			{
				mensajeError = mensajeError + "Nota invalida";
				lblNotasError.Visible = true;
			}

			if (mensajeError == "")
			{
				inquilinos[indexId].Contrato.FechaInicio = inicio;
				inquilinos[indexId].Contrato.FechaFin = fin;
				inquilinos[indexId].Contrato.Precio = precio;
				inquilinos[indexId].Contrato.MesAumento = aumento;
				inquilinos[indexId].Contrato.NotaContrato = rtbNota.Text;
				this.Close();
			}
			else
			{
				MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}
		}
	}
}
