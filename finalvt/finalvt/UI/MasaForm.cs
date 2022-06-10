using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalvt.UI
{
	public partial class MasaForm : Form
	{
		public MasaForm()
		{
			InitializeComponent();
		}

		public Masa masa;
		public Musteri musteri;
		

		
		private void button1_Click(object sender, EventArgs e)
		{
			if(!ErrorControl(comboBox1)) return;
			if (!ErrorControl(comboBox2)) return;
			masa.MasaNo = Int32.Parse(comboBox1.Text);
			masa.MasaKisi = Int32.Parse(comboBox2.Text);
			masa.Mid = musteri.MusteriID;
			DialogResult = DialogResult.OK;

		}

		private void btnMüşteriSeç_Click(object sender, EventArgs e)
		{
			MusteriListele frm = new MusteriListele();
			
			if(frm.ShowDialog() == DialogResult.OK)
			{
				musteri = frm.musteri;
				txtmid.Text = frm.musteri.Ad;
			}
			
		}

		private bool ErrorControl(Control c)
		{
			if (c is ComboBox)
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
