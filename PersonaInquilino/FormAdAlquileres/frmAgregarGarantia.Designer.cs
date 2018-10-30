namespace FormAdAlquileres
{
	partial class frmAgregarGarantia
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
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.cbSexo = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.nudEdad = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtDni = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtRelacion = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.button2.Location = new System.Drawing.Point(11, 394);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(129, 39);
			this.button2.TabIndex = 40;
			this.button2.Text = "Cancelar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.button1.Location = new System.Drawing.Point(473, 394);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 39);
			this.button1.TabIndex = 39;
			this.button1.Text = "Siguiente";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.label9.Location = new System.Drawing.Point(11, 348);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 29);
			this.label9.TabIndex = 37;
			this.label9.Text = "Relacion";
			// 
			// cbSexo
			// 
			this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.cbSexo.FormattingEnabled = true;
			this.cbSexo.Location = new System.Drawing.Point(160, 299);
			this.cbSexo.Name = "cbSexo";
			this.cbSexo.Size = new System.Drawing.Size(443, 37);
			this.cbSexo.TabIndex = 36;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.label8.Location = new System.Drawing.Point(11, 307);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 29);
			this.label8.TabIndex = 35;
			this.label8.Text = "Sexo";
			// 
			// nudEdad
			// 
			this.nudEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.nudEdad.Location = new System.Drawing.Point(160, 258);
			this.nudEdad.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
			this.nudEdad.Name = "nudEdad";
			this.nudEdad.Size = new System.Drawing.Size(443, 35);
			this.nudEdad.TabIndex = 34;
			this.nudEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.label7.Location = new System.Drawing.Point(11, 264);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 29);
			this.label7.TabIndex = 33;
			this.label7.Text = "Edad";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.label1.Location = new System.Drawing.Point(11, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 29);
			this.label1.TabIndex = 32;
			this.label1.Text = "Nombre";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(11, 223);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(114, 29);
			this.label6.TabIndex = 31;
			this.label6.Text = "Domicilio";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(11, 182);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 29);
			this.label5.TabIndex = 30;
			this.label5.Text = "Email";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(11, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 29);
			this.label4.TabIndex = 29;
			this.label4.Text = "Telefono";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 29);
			this.label3.TabIndex = 28;
			this.label3.Text = "DNI";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(11, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 29);
			this.label2.TabIndex = 27;
			this.label2.Text = "Apellido";
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDomicilio.Location = new System.Drawing.Point(160, 217);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(443, 35);
			this.txtDomicilio.TabIndex = 26;
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(160, 176);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(443, 35);
			this.txtEmail.TabIndex = 25;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(160, 135);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(443, 35);
			this.txtTelefono.TabIndex = 24;
			// 
			// txtDni
			// 
			this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDni.Location = new System.Drawing.Point(160, 94);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(443, 35);
			this.txtDni.TabIndex = 23;
			// 
			// txtApellido
			// 
			this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellido.Location = new System.Drawing.Point(160, 53);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(443, 35);
			this.txtApellido.TabIndex = 22;
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(160, 12);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(443, 35);
			this.txtNombre.TabIndex = 21;
			// 
			// txtRelacion
			// 
			this.txtRelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRelacion.Location = new System.Drawing.Point(160, 342);
			this.txtRelacion.Name = "txtRelacion";
			this.txtRelacion.Size = new System.Drawing.Size(443, 35);
			this.txtRelacion.TabIndex = 41;
			// 
			// frmAgregarGarantia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 441);
			this.Controls.Add(this.txtRelacion);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cbSexo);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.nudEdad);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtDomicilio);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtDni);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Name = "frmAgregarGarantia";
			this.Text = "frmAgregarGarantia";
			this.Load += new System.EventHandler(this.frmAgregarGarantia_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cbSexo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown nudEdad;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtDni;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtRelacion;
	}
}