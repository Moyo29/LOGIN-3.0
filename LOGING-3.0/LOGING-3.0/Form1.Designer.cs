namespace LOGING_3._0
{
	partial class Form1
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
			this.btnSalir = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtContra = new System.Windows.Forms.TextBox();
			this.txtNomb = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnSalir.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnSalir.Location = new System.Drawing.Point(406, 230);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(81, 30);
			this.btnSalir.TabIndex = 9;
			this.btnSalir.Text = "INICIAR";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(225, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "Contraseña";
			this.label3.Click += new System.EventHandler(this.Label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(132, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(233, 25);
			this.label2.TabIndex = 11;
			this.label2.Text = "Nombre de usuario";
			this.label2.Click += new System.EventHandler(this.Label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(373, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 36);
			this.label1.TabIndex = 10;
			this.label1.Text = "Iniciar Sesión";
			this.label1.UseMnemonic = false;
			this.label1.Click += new System.EventHandler(this.Label1_Click);
			// 
			// txtContra
			// 
			this.txtContra.BackColor = System.Drawing.SystemColors.Menu;
			this.txtContra.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txtContra.Location = new System.Drawing.Point(379, 187);
			this.txtContra.Name = "txtContra";
			this.txtContra.PasswordChar = '*';
			this.txtContra.Size = new System.Drawing.Size(205, 20);
			this.txtContra.TabIndex = 8;
			this.txtContra.TextChanged += new System.EventHandler(this.TxtContra_TextChanged);
			// 
			// txtNomb
			// 
			this.txtNomb.AcceptsTab = true;
			this.txtNomb.BackColor = System.Drawing.SystemColors.Menu;
			this.txtNomb.Location = new System.Drawing.Point(379, 123);
			this.txtNomb.Name = "txtNomb";
			this.txtNomb.Size = new System.Drawing.Size(205, 20);
			this.txtNomb.TabIndex = 7;
			this.txtNomb.TextChanged += new System.EventHandler(this.TxtNomb_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtContra);
			this.Controls.Add(this.txtNomb);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtContra;
		private System.Windows.Forms.TextBox txtNomb;
	}
}

