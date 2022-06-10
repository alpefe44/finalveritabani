using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalvt
{
	public partial class UrunForm : Form
	{
		public UrunForm()
		{
			InitializeComponent();
		}

		public Urun urun = new Urun();
		public bool Güncelle { get; set; } = false;

		private void button1_Click(object sender, EventArgs e)
		{
			if (!ErrorControl(textBox2)) return;
			DialogResult = DialogResult.OK;
			textBox1.Text = urun.UrunID.ToString();
			urun.Ad = textBox2.Text;
			urun.Kategori = comboBox1.Text;
			urun.Fiyat = Int32.Parse(textBox4.Text);
		}

		private bool ErrorControl(Control c)
		{
			if (c is TextBox)
			{
				if (c.Text == "")
				{
					errorProvider1.SetError(c, "Eksik veya Hatalı Giriş");
					c.Focus();
					return false;
				}
				else
				{
					errorProvider1.SetError(c, "");
					return true;
				}

			}



			return true;
		}


	}
}
