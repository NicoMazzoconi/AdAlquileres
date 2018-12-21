namespace InfoPacientes
{
	partial class frmListaPaciente
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listView1 = new System.Windows.Forms.ListView();
			this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Dni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Telefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Nombre,
            this.Apellido,
            this.Dni,
            this.Telefono,
            this.Direccion});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(568, 297);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// id
			// 
			this.id.Text = "ID";
			this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.id.Width = 35;
			// 
			// Nombre
			// 
			this.Nombre.Text = "Nombre";
			this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Nombre.Width = 86;
			// 
			// Apellido
			// 
			this.Apellido.Text = "Apellido";
			this.Apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Apellido.Width = 92;
			// 
			// Dni
			// 
			this.Dni.Text = "DNI";
			this.Dni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Dni.Width = 107;
			// 
			// Telefono
			// 
			this.Telefono.Text = "Telefono";
			this.Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Telefono.Width = 107;
			// 
			// Direccion
			// 
			this.Direccion.Text = "Direccion";
			this.Direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Direccion.Width = 137;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 303);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Cancelar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(429, 303);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(127, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Seleccionar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// frmListaPaciente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 333);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listView1);
			this.Name = "frmListaPaciente";
			this.Text = "frmListaPaciente";
			this.Load += new System.EventHandler(this.frmListaPaciente_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader id;
		private System.Windows.Forms.ColumnHeader Nombre;
		private System.Windows.Forms.ColumnHeader Apellido;
		private System.Windows.Forms.ColumnHeader Dni;
		private System.Windows.Forms.ColumnHeader Telefono;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ColumnHeader Direccion;
	}
}