namespace FormAdAlquileres
{
	partial class frmAgregarContrato
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpInicio = new System.Windows.Forms.DateTimePicker();
			this.dtpFin = new System.Windows.Forms.DateTimePicker();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtAumento = new System.Windows.Forms.TextBox();
			this.rtbNota = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txtPorcentaje = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lblFechaInicioError = new System.Windows.Forms.Label();
			this.lblFechaFinError = new System.Windows.Forms.Label();
			this.lblPrecioError = new System.Windows.Forms.Label();
			this.lblAumentoError = new System.Windows.Forms.Label();
			this.lblPorcAumentoError = new System.Windows.Forms.Label();
			this.lblNotasError = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fecha Inicio";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.label2.Location = new System.Drawing.Point(12, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Fecha Fin";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.label3.Location = new System.Drawing.Point(12, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "Precio";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.label4.Location = new System.Drawing.Point(12, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(170, 29);
			this.label4.TabIndex = 3;
			this.label4.Text = "Mes Aumento";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.label5.Location = new System.Drawing.Point(12, 226);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(169, 29);
			this.label5.TabIndex = 4;
			this.label5.Text = "Nota Contrato";
			// 
			// dtpInicio
			// 
			this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.dtpInicio.Location = new System.Drawing.Point(229, 12);
			this.dtpInicio.Name = "dtpInicio";
			this.dtpInicio.Size = new System.Drawing.Size(468, 35);
			this.dtpInicio.TabIndex = 5;
			// 
			// dtpFin
			// 
			this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.dtpFin.Location = new System.Drawing.Point(229, 53);
			this.dtpFin.Name = "dtpFin";
			this.dtpFin.Size = new System.Drawing.Size(468, 35);
			this.dtpFin.TabIndex = 6;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.txtPrecio.Location = new System.Drawing.Point(229, 94);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(468, 35);
			this.txtPrecio.TabIndex = 7;
			// 
			// txtAumento
			// 
			this.txtAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.txtAumento.Location = new System.Drawing.Point(229, 135);
			this.txtAumento.Name = "txtAumento";
			this.txtAumento.Size = new System.Drawing.Size(468, 35);
			this.txtAumento.TabIndex = 8;
			// 
			// rtbNota
			// 
			this.rtbNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.rtbNota.Location = new System.Drawing.Point(229, 217);
			this.rtbNota.Name = "rtbNota";
			this.rtbNota.Size = new System.Drawing.Size(468, 162);
			this.rtbNota.TabIndex = 9;
			this.rtbNota.Text = "";
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.button1.Location = new System.Drawing.Point(573, 385);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(124, 39);
			this.button1.TabIndex = 10;
			this.button1.Text = "Terminar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.button2.Location = new System.Drawing.Point(17, 385);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(124, 39);
			this.button2.TabIndex = 11;
			this.button2.Text = "Cancelar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtPorcentaje
			// 
			this.txtPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.txtPorcentaje.Location = new System.Drawing.Point(229, 176);
			this.txtPorcentaje.Name = "txtPorcentaje";
			this.txtPorcentaje.Size = new System.Drawing.Size(468, 35);
			this.txtPorcentaje.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.label6.Location = new System.Drawing.Point(12, 182);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(144, 29);
			this.label6.TabIndex = 13;
			this.label6.Text = "% Aumento";
			// 
			// lblFechaInicioError
			// 
			this.lblFechaInicioError.AutoSize = true;
			this.lblFechaInicioError.ForeColor = System.Drawing.Color.Red;
			this.lblFechaInicioError.Location = new System.Drawing.Point(209, 18);
			this.lblFechaInicioError.Name = "lblFechaInicioError";
			this.lblFechaInicioError.Size = new System.Drawing.Size(14, 13);
			this.lblFechaInicioError.TabIndex = 54;
			this.lblFechaInicioError.Text = "X";
			this.lblFechaInicioError.Visible = false;
			// 
			// lblFechaFinError
			// 
			this.lblFechaFinError.AutoSize = true;
			this.lblFechaFinError.ForeColor = System.Drawing.Color.Red;
			this.lblFechaFinError.Location = new System.Drawing.Point(209, 63);
			this.lblFechaFinError.Name = "lblFechaFinError";
			this.lblFechaFinError.Size = new System.Drawing.Size(14, 13);
			this.lblFechaFinError.TabIndex = 53;
			this.lblFechaFinError.Text = "X";
			this.lblFechaFinError.Visible = false;
			// 
			// lblPrecioError
			// 
			this.lblPrecioError.AutoSize = true;
			this.lblPrecioError.ForeColor = System.Drawing.Color.Red;
			this.lblPrecioError.Location = new System.Drawing.Point(209, 104);
			this.lblPrecioError.Name = "lblPrecioError";
			this.lblPrecioError.Size = new System.Drawing.Size(14, 13);
			this.lblPrecioError.TabIndex = 52;
			this.lblPrecioError.Text = "X";
			this.lblPrecioError.Visible = false;
			// 
			// lblAumentoError
			// 
			this.lblAumentoError.AutoSize = true;
			this.lblAumentoError.ForeColor = System.Drawing.Color.Red;
			this.lblAumentoError.Location = new System.Drawing.Point(209, 145);
			this.lblAumentoError.Name = "lblAumentoError";
			this.lblAumentoError.Size = new System.Drawing.Size(14, 13);
			this.lblAumentoError.TabIndex = 51;
			this.lblAumentoError.Text = "X";
			this.lblAumentoError.Visible = false;
			// 
			// lblPorcAumentoError
			// 
			this.lblPorcAumentoError.AutoSize = true;
			this.lblPorcAumentoError.ForeColor = System.Drawing.Color.Red;
			this.lblPorcAumentoError.Location = new System.Drawing.Point(208, 186);
			this.lblPorcAumentoError.Name = "lblPorcAumentoError";
			this.lblPorcAumentoError.Size = new System.Drawing.Size(14, 13);
			this.lblPorcAumentoError.TabIndex = 50;
			this.lblPorcAumentoError.Text = "X";
			this.lblPorcAumentoError.Visible = false;
			// 
			// lblNotasError
			// 
			this.lblNotasError.AutoSize = true;
			this.lblNotasError.ForeColor = System.Drawing.Color.Red;
			this.lblNotasError.Location = new System.Drawing.Point(209, 227);
			this.lblNotasError.Name = "lblNotasError";
			this.lblNotasError.Size = new System.Drawing.Size(14, 13);
			this.lblNotasError.TabIndex = 49;
			this.lblNotasError.Text = "X";
			this.lblNotasError.Visible = false;
			// 
			// frmAgregarContrato
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(708, 430);
			this.Controls.Add(this.lblFechaInicioError);
			this.Controls.Add(this.lblFechaFinError);
			this.Controls.Add(this.lblPrecioError);
			this.Controls.Add(this.lblAumentoError);
			this.Controls.Add(this.lblPorcAumentoError);
			this.Controls.Add(this.lblNotasError);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtPorcentaje);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.rtbNota);
			this.Controls.Add(this.txtAumento);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.dtpFin);
			this.Controls.Add(this.dtpInicio);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmAgregarContrato";
			this.Text = "frmAgregarContrato";
			this.Load += new System.EventHandler(this.frmAgregarContrato_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpInicio;
		private System.Windows.Forms.DateTimePicker dtpFin;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtAumento;
		private System.Windows.Forms.RichTextBox rtbNota;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtPorcentaje;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblFechaInicioError;
		private System.Windows.Forms.Label lblFechaFinError;
		private System.Windows.Forms.Label lblPrecioError;
		private System.Windows.Forms.Label lblAumentoError;
		private System.Windows.Forms.Label lblPorcAumentoError;
		private System.Windows.Forms.Label lblNotasError;
	}
}