namespace FormAdAlquileres
{
	partial class frmMostrarInfoCompleta
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
			this.rtbInfo = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// rtbInfo
			// 
			this.rtbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbInfo.Location = new System.Drawing.Point(0, 0);
			this.rtbInfo.Name = "rtbInfo";
			this.rtbInfo.Size = new System.Drawing.Size(477, 450);
			this.rtbInfo.TabIndex = 0;
			this.rtbInfo.Text = "";
			this.rtbInfo.TextChanged += new System.EventHandler(this.rtbInfo_TextChanged);
			// 
			// frmMostrarInfoCompleta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(477, 450);
			this.Controls.Add(this.rtbInfo);
			this.Name = "frmMostrarInfoCompleta";
			this.Text = "Informacion Detallada";
			this.Load += new System.EventHandler(this.frmMostrarInfoCompleta_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbInfo;
	}
}