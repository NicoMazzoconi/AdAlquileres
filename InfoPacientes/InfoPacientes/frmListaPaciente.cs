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
	public partial class frmListaPaciente : Form
	{
		private List<Persona> pacientes;
		public static int indexPaciente;

		static frmListaPaciente()
		{
			indexPaciente = -1;
		}

		public frmListaPaciente(List<Persona> pacientes)
		{
			InitializeComponent();
			this.pacientes = pacientes;

		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(listView1.SelectedItems.Count > 0)
			{
				ListViewItem item = listView1.SelectedItems[0];
				for(int i = 0; i < pacientes.Count; i++)
				{
					if(item.SubItems[0].Text.Trim() == pacientes[i].ID.ToString().Trim())
					{
						indexPaciente = i;
						break;
					}
				}
			}
		}

		private void frmListaPaciente_Load(object sender, EventArgs e)
		{
			foreach(Persona a in pacientes)
			{
				ListViewItem items = new ListViewItem(a.ID.ToString());
				items.SubItems.Add(a.Nombre);
				items.SubItems.Add(a.Apellido);
				items.SubItems.Add(a.Dni.ToString());
				items.SubItems.Add(a.Telefono.ToString());
				items.SubItems.Add(a.Direccion);
				listView1.Items.Add(items);
			}
		}

		private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column == 0)
			{
				if (listView1.Sorting == SortOrder.Descending)
					listView1.Sorting = SortOrder.Ascending;
				else
					listView1.Sorting = SortOrder.Descending;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			indexPaciente = -1;
			this.Close();
		}
	}
}
