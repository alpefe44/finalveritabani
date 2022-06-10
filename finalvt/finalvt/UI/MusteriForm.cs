using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using finalvt.BL;

namespace finalvt
{
	public partial class MusteriForm : Form
	{
		public MusteriForm()
		{
			InitializeComponent();
		}

		public Musteri musteri = new Musteri();
		public bool Güncelle { get; set; } = false;

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

			if (c is MaskedTextBox)
			{
				if (!((MaskedTextBox)c).MaskFull)
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

		private void button1_Click(object sender, EventArgs e)
		{
			if (!ErrorControl(textAd)) return;
			if (!ErrorControl(textSoyad)) return;
			if (!ErrorControl(maskedTextBox1)) return;
			DialogResult = DialogResult.OK;
			textBox1.Text = musteri.MusteriID.ToString();
			musteri.Ad = textAd.Text;
			musteri.Soyad = textSoyad.Text;
			musteri.Telefon = maskedTextBox1.Text;
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void MusteriForm_Load(object sender, EventArgs e)
		{
		
		}

		private void button3_Click(object sender, EventArgs e)
		{
			
		}

	

		
	}
}
