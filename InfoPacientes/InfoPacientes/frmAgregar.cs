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
	public partial class frmAgregar : Form
	{
		private List<Persona> lsPersona;
		public frmAgregar(List<Persona> personas)
		{
			InitializeComponent();
			lsPersona = personas;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			bool respuesta = true;
			if(textBox1.Text.Length > 0)
				foreach(Char a in textBox1.Text)
				{
					if (char.IsLetter(a) || a == ' ')
					{
						respuesta = false;
					}
					else
					{
						respuesta = true;
						break;
					}
				}
			label6.Visible = respuesta;
			button1.Enabled = !(respuesta);
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			bool respuesta = true;
			if (textBox2.Text.Length > 0)
				foreach (Char a in textBox2.Text)
				{
					if (char.IsLetter(a) || a == ' ')
					{
						respuesta = false;
					}
					else
					{
						respuesta = true;
						break;
					}
				}
			label7.Visible = respuesta;
			button1.Enabled = !(respuesta);
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			bool respuesta = true;
			if (textBox3.Text.Length > 0)
			{
				if (double.TryParse(textBox3.Text, out double s))
					respuesta = false;
			}
			label8.Visible = respuesta;
			button1.Enabled = !(respuesta);
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			bool respuesta = true;
			if (textBox4.Text.Length > 0)
			{
				if(double.TryParse(textBox4.Text, out double d))
					respuesta = false;
			}
			label9.Visible = respuesta;
			button1.Enabled = !(respuesta);
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{
			bool respuesta = false;
			if (textBox5.Text is null || textBox5.Text.Length < 1)
				respuesta = true;
			label10.Visible = respuesta;
			button1.Enabled = !(respuesta);
		}

		private void frmAgregar_Load(object sender, EventArgs e)
		{
			textBox1_TextChanged(sender, e);
			textBox2_TextChanged(sender, e);
			textBox3_TextChanged(sender, e);
			textBox4_TextChanged(sender, e);
			textBox5_TextChanged(sender, e);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_EnabledChanged(object sender, EventArgs e)
		{
			if (label6.Visible == false && label7.Visible == false && label8.Visible == false && label9.Visible == false && label10.Visible == false)
			{
				button1.Enabled = true;
			}
			else
				button1.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Persona newPerson = new Persona(textBox1.Text, textBox2.Text, double.Parse(textBox3.Text), double.Parse(textBox4.Text), textBox5.Text);
			bool esta = false;
			foreach (Persona a in lsPersona)
			{
				if(a == newPerson)
				{
					esta = true;
					MessageBox.Show("Ya existe esta persona en la base de datos", "Paciente repetido", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
					break;
				}
			}

			if(!esta)
			{
				lsPersona.Add(newPerson);
				this.Close();
			}	
		}
	}
}
