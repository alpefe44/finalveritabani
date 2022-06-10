
namespace finalvt
{
	partial class SiparisForm
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
			this.components = new System.ComponentModel.Container();
			this.button2 = new System.Windows.Forms.Button();
			this.btnMüşteriSeç = new System.Windows.Forms.Button();
			this.dtTarih = new System.Windows.Forms.DateTimePicker();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMusteri = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUrun = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(285, 111);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(106, 23);
			this.button2.TabIndex = 44;
			this.button2.Text = "Ürün Seç";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnMüşteriSeç
			// 
			this.btnMüşteriSeç.Location = new System.Drawing.Point(285, 82);
			this.btnMüşteriSeç.Name = "btnMüşteriSeç";
			this.btnMüşteriSeç.Size = new System.Drawing.Size(106, 23);
			this.btnMüşteriSeç.TabIndex = 45;
			this.btnMüşteriSeç.Text = "Müşteri Seç";
			this.btnMüşteriSeç.UseVisualStyleBackColor = true;
			this.btnMüşteriSeç.Click += new System.EventHandler(this.btnMüşteriSeç_Click);
			// 
			// dtTarih
			// 
			this.dtTarih.Location = new System.Drawing.Point(53, 165);
			this.dtTarih.Name = "dtTarih";
			this.dtTarih.Size = new System.Drawing.Size(226, 20);
			this.dtTarih.TabIndex = 36;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(204, 201);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 38;
			this.btnCancel.Text = "İptal";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(123, 201);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 37;
			this.btnOK.Text = "Tamam";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 13);
			this.label5.TabIndex = 39;
			this.label5.Text = "Tarih";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 40;
			this.label4.Text = "Fiyat";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 41;
			this.label3.Text = "Ürün";
			// 
			// txtMusteri
			// 
			this.txtMusteri.Location = new System.Drawing.Point(53, 87);
			this.txtMusteri.Name = "txtMusteri";
			this.txtMusteri.ReadOnly = true;
			this.txtMusteri.Size = new System.Drawing.Size(226, 20);
			this.txtMusteri.TabIndex = 33;
			this.txtMusteri.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 42;
			this.label2.Text = "Masa";
			// 
			// txtUrun
			// 
			this.txtUrun.Location = new System.Drawing.Point(53, 113);
			this.txtUrun.Name = "txtUrun";
			this.txtUrun.ReadOnly = true;
			this.txtUrun.Size = new System.Drawing.Size(226, 20);
			this.txtUrun.TabIndex = 34;
			this.txtUrun.TabStop = false;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(53, 35);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(226, 20);
			this.txtID.TabIndex = 32;
			this.txtID.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 43;
			this.label1.Text = "ID";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(53, 61);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(226, 20);
			this.textBox1.TabIndex = 46;
			this.textBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 64);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 13);
			this.label6.TabIndex = 47;
			this.label6.Text = "Müşteri";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(53, 140);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(226, 20);
			this.textBox2.TabIndex = 48;
			// 
			// SiparisForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 258);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnMüşteriSeç);
			this.Controls.Add(this.dtTarih);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMusteri);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUrun);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label1);
			this.Name = "SiparisForm";
			this.Text = "SiparisForm";
			this.Load += new System.EventHandler(this.SiparisForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnMüşteriSeç;
		private System.Windows.Forms.DateTimePicker dtTarih;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMusteri;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUrun;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox2;
	}
}