
namespace finalvt
{
	partial class MusteriForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.labelTel = new System.Windows.Forms.Label();
			this.textAd = new System.Windows.Forms.TextBox();
			this.textSoyad = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(55, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ad";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Soyad";
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(79, 29);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(142, 20);
			this.textBox1.TabIndex = 4;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(79, 140);
			this.maskedTextBox1.Mask = "\\0(599) 000-0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(142, 20);
			this.maskedTextBox1.TabIndex = 10;
			// 
			// labelTel
			// 
			this.labelTel.AutoSize = true;
			this.labelTel.Location = new System.Drawing.Point(38, 143);
			this.labelTel.Name = "labelTel";
			this.labelTel.Size = new System.Drawing.Size(43, 13);
			this.labelTel.TabIndex = 9;
			this.labelTel.Text = "Telefon";
			// 
			// textAd
			// 
			this.textAd.Location = new System.Drawing.Point(79, 66);
			this.textAd.Name = "textAd";
			this.textAd.Size = new System.Drawing.Size(142, 20);
			this.textAd.TabIndex = 11;
			// 
			// textSoyad
			// 
			this.textSoyad.Location = new System.Drawing.Point(79, 105);
			this.textSoyad.Name = "textSoyad";
			this.textSoyad.Size = new System.Drawing.Size(142, 20);
			this.textSoyad.TabIndex = 12;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(79, 180);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(142, 30);
			this.button1.TabIndex = 13;
			this.button1.Text = "Ekle";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(98, 216);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 24);
			this.button2.TabIndex = 14;
			this.button2.Text = "Çık";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// MusteriForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 299);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textSoyad);
			this.Controls.Add(this.textAd);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.labelTel);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MusteriForm";
			this.Text = "MusteriForm";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Label labelTel;
		private System.Windows.Forms.TextBox textAd;
		private System.Windows.Forms.TextBox textSoyad;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button button2;
	}
}