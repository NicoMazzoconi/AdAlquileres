namespace FormAdAlquileres
{
	partial class frmMain
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btn_Propiedad = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_fecha = new System.Windows.Forms.Label();
			this.timerFecha = new System.Windows.Forms.Timer(this.components);
			this.statusFecha = new System.Windows.Forms.StatusStrip();
			this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
			this.timerPanel = new System.Windows.Forms.Timer(this.components);
			this.tpInquilino = new System.Windows.Forms.TabPage();
			this.btModCont = new System.Windows.Forms.Button();
			this.btModGara = new System.Windows.Forms.Button();
			this.btnModInq = new System.Windows.Forms.Button();
			this.lvInquilino = new System.Windows.Forms.ListView();
			this.colmnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Telefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Inmueble = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tbInmueble = new System.Windows.Forms.TabPage();
			this.btn_agregarDepartamento = new System.Windows.Forms.Button();
			this.lvPropiedades = new System.Windows.Forms.ListView();
			this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Inquilino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.statusFecha.SuspendLayout();
			this.tpInquilino.SuspendLayout();
			this.tbInmueble.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAgregar
			// 
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.btnAgregar.Location = new System.Drawing.Point(78, 95);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(187, 42);
			this.btnAgregar.TabIndex = 0;
			this.btnAgregar.Text = "Agregar Inquilino";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn_Propiedad
			// 
			this.btn_Propiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.btn_Propiedad.Location = new System.Drawing.Point(78, 95);
			this.btn_Propiedad.Name = "btn_Propiedad";
			this.btn_Propiedad.Size = new System.Drawing.Size(187, 42);
			this.btn_Propiedad.TabIndex = 1;
			this.btn_Propiedad.Text = "Agregar Casa";
			this.btn_Propiedad.UseVisualStyleBackColor = true;
			this.btn_Propiedad.Click += new System.EventHandler(this.btn_Propiedad_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.groupBox1.Location = new System.Drawing.Point(69, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(209, 64);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Propiedades Totales";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label1.Location = new System.Drawing.Point(72, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "NUMERO";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.groupBox2.Location = new System.Drawing.Point(69, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(209, 64);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Propiedades Alquiladas";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label2.Location = new System.Drawing.Point(72, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "NUMERO";
			// 
			// lbl_fecha
			// 
			this.lbl_fecha.AutoSize = true;
			this.lbl_fecha.Location = new System.Drawing.Point(734, 442);
			this.lbl_fecha.Name = "lbl_fecha";
			this.lbl_fecha.Size = new System.Drawing.Size(37, 13);
			this.lbl_fecha.TabIndex = 4;
			this.lbl_fecha.Text = "Fecha";
			this.lbl_fecha.Click += new System.EventHandler(this.lbl_fecha_Click);
			// 
			// timerFecha
			// 
			this.timerFecha.Enabled = true;
			this.timerFecha.Interval = 1000;
			this.timerFecha.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// statusFecha
			// 
			this.statusFecha.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFecha});
			this.statusFecha.Location = new System.Drawing.Point(0, 494);
			this.statusFecha.Name = "statusFecha";
			this.statusFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusFecha.Size = new System.Drawing.Size(1204, 22);
			this.statusFecha.TabIndex = 6;
			this.statusFecha.Text = "statusStrip1";
			// 
			// lblFecha
			// 
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFecha.RightToLeftAutoMirrorImage = true;
			this.lblFecha.Size = new System.Drawing.Size(38, 17);
			this.lblFecha.Text = "Fecha";
			this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// timerPanel
			// 
			this.timerPanel.Enabled = true;
			this.timerPanel.Interval = 60000;
			this.timerPanel.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// tpInquilino
			// 
			this.tpInquilino.Controls.Add(this.btModCont);
			this.tpInquilino.Controls.Add(this.btModGara);
			this.tpInquilino.Controls.Add(this.btnModInq);
			this.tpInquilino.Controls.Add(this.lvInquilino);
			this.tpInquilino.Controls.Add(this.btnAgregar);
			this.tpInquilino.Controls.Add(this.groupBox2);
			this.tpInquilino.Location = new System.Drawing.Point(4, 38);
			this.tpInquilino.Name = "tpInquilino";
			this.tpInquilino.Padding = new System.Windows.Forms.Padding(3);
			this.tpInquilino.Size = new System.Drawing.Size(1196, 452);
			this.tpInquilino.TabIndex = 1;
			this.tpInquilino.Text = "Inquilinos";
			this.tpInquilino.UseVisualStyleBackColor = true;
			this.tpInquilino.Click += new System.EventHandler(this.tpInquilino_Click);
			// 
			// btModCont
			// 
			this.btModCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.btModCont.Location = new System.Drawing.Point(78, 239);
			this.btModCont.Name = "btModCont";
			this.btModCont.Size = new System.Drawing.Size(187, 42);
			this.btModCont.TabIndex = 6;
			this.btModCont.Text = "Modificar Contrato";
			this.btModCont.UseVisualStyleBackColor = true;
			// 
			// btModGara
			// 
			this.btModGara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.btModGara.Location = new System.Drawing.Point(78, 191);
			this.btModGara.Name = "btModGara";
			this.btModGara.Size = new System.Drawing.Size(187, 42);
			this.btModGara.TabIndex = 5;
			this.btModGara.Text = "Modificar Garantia";
			this.btModGara.UseVisualStyleBackColor = true;
			// 
			// btnModInq
			// 
			this.btnModInq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.btnModInq.Location = new System.Drawing.Point(78, 143);
			this.btnModInq.Name = "btnModInq";
			this.btnModInq.Size = new System.Drawing.Size(187, 42);
			this.btnModInq.TabIndex = 4;
			this.btnModInq.Text = "Modificar Inquilino";
			this.btnModInq.UseVisualStyleBackColor = true;
			this.btnModInq.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// lvInquilino
			// 
			this.lvInquilino.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colmnId,
            this.Nombre,
            this.Apellido,
            this.Telefono,
            this.Inmueble});
			this.lvInquilino.Dock = System.Windows.Forms.DockStyle.Right;
			this.lvInquilino.FullRowSelect = true;
			this.lvInquilino.GridLines = true;
			this.lvInquilino.Location = new System.Drawing.Point(391, 3);
			this.lvInquilino.MultiSelect = false;
			this.lvInquilino.Name = "lvInquilino";
			this.lvInquilino.Size = new System.Drawing.Size(802, 446);
			this.lvInquilino.TabIndex = 0;
			this.lvInquilino.UseCompatibleStateImageBehavior = false;
			this.lvInquilino.View = System.Windows.Forms.View.Details;
			this.lvInquilino.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
			// 
			// colmnId
			// 
			this.colmnId.Text = "ID";
			this.colmnId.Width = 40;
			// 
			// Nombre
			// 
			this.Nombre.Text = "Nombre";
			this.Nombre.Width = 154;
			// 
			// Apellido
			// 
			this.Apellido.Text = "Apellido";
			this.Apellido.Width = 148;
			// 
			// Telefono
			// 
			this.Telefono.Text = "Telefono";
			this.Telefono.Width = 179;
			// 
			// Inmueble
			// 
			this.Inmueble.Text = "Inmueble";
			this.Inmueble.Width = 275;
			// 
			// tbInmueble
			// 
			this.tbInmueble.Controls.Add(this.btn_agregarDepartamento);
			this.tbInmueble.Controls.Add(this.lvPropiedades);
			this.tbInmueble.Controls.Add(this.btn_Propiedad);
			this.tbInmueble.Controls.Add(this.groupBox1);
			this.tbInmueble.Location = new System.Drawing.Point(4, 38);
			this.tbInmueble.Name = "tbInmueble";
			this.tbInmueble.Padding = new System.Windows.Forms.Padding(3);
			this.tbInmueble.Size = new System.Drawing.Size(1196, 452);
			this.tbInmueble.TabIndex = 0;
			this.tbInmueble.Text = "Propiedades";
			this.tbInmueble.UseVisualStyleBackColor = true;
			// 
			// btn_agregarDepartamento
			// 
			this.btn_agregarDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.btn_agregarDepartamento.Location = new System.Drawing.Point(78, 169);
			this.btn_agregarDepartamento.Name = "btn_agregarDepartamento";
			this.btn_agregarDepartamento.Size = new System.Drawing.Size(187, 42);
			this.btn_agregarDepartamento.TabIndex = 3;
			this.btn_agregarDepartamento.Text = "Agregar Departamento";
			this.btn_agregarDepartamento.UseVisualStyleBackColor = true;
			this.btn_agregarDepartamento.Click += new System.EventHandler(this.btn_agregarDepartamento_Click);
			// 
			// lvPropiedades
			// 
			this.lvPropiedades.BackColor = System.Drawing.SystemColors.Window;
			this.lvPropiedades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvPropiedades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Direccion,
            this.Estado,
            this.Inquilino});
			this.lvPropiedades.Dock = System.Windows.Forms.DockStyle.Right;
			this.lvPropiedades.FullRowSelect = true;
			this.lvPropiedades.GridLines = true;
			this.lvPropiedades.Location = new System.Drawing.Point(505, 3);
			this.lvPropiedades.MultiSelect = false;
			this.lvPropiedades.Name = "lvPropiedades";
			this.lvPropiedades.Size = new System.Drawing.Size(688, 446);
			this.lvPropiedades.TabIndex = 0;
			this.lvPropiedades.UseCompatibleStateImageBehavior = false;
			this.lvPropiedades.View = System.Windows.Forms.View.Details;
			// 
			// Direccion
			// 
			this.Direccion.Text = "Direccion";
			this.Direccion.Width = 258;
			// 
			// Estado
			// 
			this.Estado.Text = "Estado";
			this.Estado.Width = 135;
			// 
			// Inquilino
			// 
			this.Inquilino.Text = "Inquilino";
			this.Inquilino.Width = 290;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tbInmueble);
			this.tabControl1.Controls.Add(this.tpInquilino);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1204, 494);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabControl1.TabIndex = 5;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1204, 516);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusFecha);
			this.Controls.Add(this.lbl_fecha);
			this.Name = "frmMain";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "AdAlquileres";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.statusFecha.ResumeLayout(false);
			this.statusFecha.PerformLayout();
			this.tpInquilino.ResumeLayout(false);
			this.tbInmueble.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btn_Propiedad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_fecha;
		private System.Windows.Forms.Timer timerFecha;
		private System.Windows.Forms.StatusStrip statusFecha;
		private System.Windows.Forms.ToolStripStatusLabel lblFecha;
		private System.Windows.Forms.Timer timerPanel;
		private System.Windows.Forms.TabPage tpInquilino;
		private System.Windows.Forms.ListView lvInquilino;
		private System.Windows.Forms.ColumnHeader Nombre;
		private System.Windows.Forms.ColumnHeader Apellido;
		private System.Windows.Forms.ColumnHeader Telefono;
		private System.Windows.Forms.ColumnHeader Inmueble;
		private System.Windows.Forms.TabPage tbInmueble;
		private System.Windows.Forms.ListView lvPropiedades;
		private System.Windows.Forms.ColumnHeader Direccion;
		private System.Windows.Forms.ColumnHeader Estado;
		private System.Windows.Forms.ColumnHeader Inquilino;
		private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_agregarDepartamento;
		private System.Windows.Forms.Button btModCont;
		private System.Windows.Forms.Button btModGara;
		private System.Windows.Forms.Button btnModInq;
		private System.Windows.Forms.ColumnHeader colmnId;
	}
}

