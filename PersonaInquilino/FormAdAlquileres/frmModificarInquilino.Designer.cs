﻿namespace FormAdAlquileres
{
	partial class frmModificarInquilino
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
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			this.lblSexoError = new System.Windows.Forms.Label();
			this.lblNombreError = new System.Windows.Forms.Label();
			this.lblApellidoError = new System.Windows.Forms.Label();
			this.lblDniError = new System.Windows.Forms.Label();
			this.lblTelefonoError = new System.Windows.Forms.Label();
			this.lblEmailError = new System.Windows.Forms.Label();
			this.lblDomicilioError = new System.Windows.Forms.Label();
			this.lblEdadError = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
			this.SuspendLayout();
			// 
			// cbSexo
			// 
			this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.cbSexo.FormattingEnabled = true;
			this.cbSexo.Location = new System.Drawing.Point(189, 308);
			this.cbSexo.Name = "cbSexo";
			this.cbSexo.Size = new System.Drawing.Size(443, 37);
			this.cbSexo.TabIndex = 34;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.label8.Location = new System.Drawing.Point(40, 316);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 29);
			this.label8.TabIndex = 33;
			this.label8.Text = "Sexo";
			// 
			// nudEdad
			// 
			this.nudEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.nudEdad.Location = new System.Drawing.Point(189, 267);
			this.nudEdad.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
			this.nudEdad.Name = "nudEdad";
			this.nudEdad.Size = new System.Drawing.Size(443, 35);
			this.nudEdad.TabIndex = 32;
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
			this.label7.Location = new System.Drawing.Point(40, 273);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 29);
			this.label7.TabIndex = 31;
			this.label7.Text = "Edad";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.label1.Location = new System.Drawing.Point(40, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 29);
			this.label1.TabIndex = 30;
			this.label1.Text = "Nombre";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(40, 232);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(114, 29);
			this.label6.TabIndex = 29;
			this.label6.Text = "Domicilio";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(40, 191);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 29);
			this.label5.TabIndex = 28;
			this.label5.Text = "Email";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(40, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 29);
			this.label4.TabIndex = 27;
			this.label4.Text = "Telefono";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(40, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 29);
			this.label3.TabIndex = 26;
			this.label3.Text = "DNI";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 29);
			this.label2.TabIndex = 25;
			this.label2.Text = "Apellido";
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDomicilio.Location = new System.Drawing.Point(189, 226);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(443, 35);
			this.txtDomicilio.TabIndex = 24;
			this.txtDomicilio.TextChanged += new System.EventHandler(this.txtDomicilio_TextChanged);
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(189, 185);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(443, 35);
			this.txtEmail.TabIndex = 23;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(189, 144);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(443, 35);
			this.txtTelefono.TabIndex = 22;
			// 
			// txtDni
			// 
			this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDni.Location = new System.Drawing.Point(189, 103);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(443, 35);
			this.txtDni.TabIndex = 21;
			// 
			// txtApellido
			// 
			this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellido.Location = new System.Drawing.Point(189, 62);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(443, 35);
			this.txtApellido.TabIndex = 20;
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(189, 21);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(443, 35);
			this.txtNombre.TabIndex = 19;
			this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.btn_cancelar.Location = new System.Drawing.Point(13, 372);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(138, 39);
			this.btn_cancelar.TabIndex = 37;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// btn_ok
			// 
			this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.btn_ok.Location = new System.Drawing.Point(496, 372);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(138, 39);
			this.btn_ok.TabIndex = 38;
			this.btn_ok.Text = "Guardar";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
			// 
			// lblSexoError
			// 
			this.lblSexoError.AutoSize = true;
			this.lblSexoError.ForeColor = System.Drawing.Color.Red;
			this.lblSexoError.Location = new System.Drawing.Point(169, 325);
			this.lblSexoError.Name = "lblSexoError";
			this.lblSexoError.Size = new System.Drawing.Size(14, 13);
			this.lblSexoError.TabIndex = 49;
			this.lblSexoError.Text = "X";
			this.lblSexoError.Visible = false;
			// 
			// lblNombreError
			// 
			this.lblNombreError.AutoSize = true;
			this.lblNombreError.ForeColor = System.Drawing.Color.Red;
			this.lblNombreError.Location = new System.Drawing.Point(169, 32);
			this.lblNombreError.Name = "lblNombreError";
			this.lblNombreError.Size = new System.Drawing.Size(14, 13);
			this.lblNombreError.TabIndex = 48;
			this.lblNombreError.Text = "X";
			this.lblNombreError.Visible = false;
			// 
			// lblApellidoError
			// 
			this.lblApellidoError.AutoSize = true;
			this.lblApellidoError.ForeColor = System.Drawing.Color.Red;
			this.lblApellidoError.Location = new System.Drawing.Point(169, 77);
			this.lblApellidoError.Name = "lblApellidoError";
			this.lblApellidoError.Size = new System.Drawing.Size(14, 13);
			this.lblApellidoError.TabIndex = 47;
			this.lblApellidoError.Text = "X";
			this.lblApellidoError.Visible = false;
			// 
			// lblDniError
			// 
			this.lblDniError.AutoSize = true;
			this.lblDniError.ForeColor = System.Drawing.Color.Red;
			this.lblDniError.Location = new System.Drawing.Point(169, 118);
			this.lblDniError.Name = "lblDniError";
			this.lblDniError.Size = new System.Drawing.Size(14, 13);
			this.lblDniError.TabIndex = 46;
			this.lblDniError.Text = "X";
			this.lblDniError.Visible = false;
			// 
			// lblTelefonoError
			// 
			this.lblTelefonoError.AutoSize = true;
			this.lblTelefonoError.ForeColor = System.Drawing.Color.Red;
			this.lblTelefonoError.Location = new System.Drawing.Point(169, 159);
			this.lblTelefonoError.Name = "lblTelefonoError";
			this.lblTelefonoError.Size = new System.Drawing.Size(14, 13);
			this.lblTelefonoError.TabIndex = 45;
			this.lblTelefonoError.Text = "X";
			this.lblTelefonoError.Visible = false;
			// 
			// lblEmailError
			// 
			this.lblEmailError.AutoSize = true;
			this.lblEmailError.ForeColor = System.Drawing.Color.Red;
			this.lblEmailError.Location = new System.Drawing.Point(168, 200);
			this.lblEmailError.Name = "lblEmailError";
			this.lblEmailError.Size = new System.Drawing.Size(14, 13);
			this.lblEmailError.TabIndex = 44;
			this.lblEmailError.Text = "X";
			this.lblEmailError.Visible = false;
			// 
			// lblDomicilioError
			// 
			this.lblDomicilioError.AutoSize = true;
			this.lblDomicilioError.ForeColor = System.Drawing.Color.Red;
			this.lblDomicilioError.Location = new System.Drawing.Point(169, 241);
			this.lblDomicilioError.Name = "lblDomicilioError";
			this.lblDomicilioError.Size = new System.Drawing.Size(14, 13);
			this.lblDomicilioError.TabIndex = 43;
			this.lblDomicilioError.Text = "X";
			this.lblDomicilioError.Visible = false;
			// 
			// lblEdadError
			// 
			this.lblEdadError.AutoSize = true;
			this.lblEdadError.ForeColor = System.Drawing.Color.Red;
			this.lblEdadError.Location = new System.Drawing.Point(169, 282);
			this.lblEdadError.Name = "lblEdadError";
			this.lblEdadError.Size = new System.Drawing.Size(14, 13);
			this.lblEdadError.TabIndex = 42;
			this.lblEdadError.Text = "X";
			this.lblEdadError.Visible = false;
			// 
			// frmModificarInquilino
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 420);
			this.Controls.Add(this.lblSexoError);
			this.Controls.Add(this.lblNombreError);
			this.Controls.Add(this.lblApellidoError);
			this.Controls.Add(this.lblDniError);
			this.Controls.Add(this.lblTelefonoError);
			this.Controls.Add(this.lblEmailError);
			this.Controls.Add(this.lblDomicilioError);
			this.Controls.Add(this.lblEdadError);
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.btn_cancelar);
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
			this.Name = "frmModificarInquilino";
			this.Text = "Modificar Inquilino";
			this.Load += new System.EventHandler(this.frmModificar_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion
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
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.Label lblSexoError;
		private System.Windows.Forms.Label lblNombreError;
		private System.Windows.Forms.Label lblApellidoError;
		private System.Windows.Forms.Label lblDniError;
		private System.Windows.Forms.Label lblTelefonoError;
		private System.Windows.Forms.Label lblEmailError;
		private System.Windows.Forms.Label lblDomicilioError;
		private System.Windows.Forms.Label lblEdadError;
	}
}