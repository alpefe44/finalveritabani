
namespace finalvt.UI
{
	partial class MasaForm
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
			this.btnMüşteriSeç = new System.Windows.Forms.Button();
			this.txtmid = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnMüşteriSeç
			// 
			this.btnMüşteriSeç.Location = new System.Drawing.Point(311, 39);
			this.btnMüşteriSeç.Name = "btnMüşteriSeç";
			this.btnMüşteriSeç.Size = new System.Drawing.Size(106, 23);
			this.btnMüşteriSeç.TabIndex = 57;
			this.btnMüşteriSeç.Text = "Müşteri Seç";
			this.btnMüşteriSeç.UseVisualStyleBackColor = true;
			this.btnMüşteriSeç.Click += new System.EventHandler(this.btnMüşteriSeç_Click);
			// 
			// txtmid
			// 
			this.txtmid.Location = new System.Drawing.Point(79, 39);
			this.txtmid.Name = "txtmid";
			this.txtmid.ReadOnly = true;
			this.txtmid.Size = new System.Drawing.Size(226, 20);
			this.txtmid.TabIndex = 47;
			this.txtmid.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 54;
			this.label2.Text = "Müşteri";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
			this.comboBox1.Location = new System.Drawing.Point(79, 66);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(226, 21);
			this.comboBox1.TabIndex = 58;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 59;
			this.label3.Text = "Masa";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(79, 138);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 42);
			this.button1.TabIndex = 60;
			this.button1.Text = "Ekle";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(211, 138);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 42);
			this.button2.TabIndex = 61;
			this.button2.Text = "Çık";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(50, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 13);
			this.label4.TabIndex = 63;
			this.label4.Text = "Kişi";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
			this.comboBox2.Location = new System.Drawing.Point(79, 93);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(226, 21);
			this.comboBox2.TabIndex = 62;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// MasaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 216);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.btnMüşteriSeç);
			this.Controls.Add(this.txtmid);
			this.Controls.Add(this.label2);
			this.Name = "MasaForm";
			this.Text = "MasaForm";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnMüşteriSeç;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox2;
		public System.Windows.Forms.TextBox txtmid;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}