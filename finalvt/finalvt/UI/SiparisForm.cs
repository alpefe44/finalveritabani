using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using finalvt.UI;

namespace finalvt
{
	public partial class SiparisForm : Form
	{
		public SiparisForm()
		{
			InitializeComponent();
		}

		public Siparis siparis = new Siparis();
		public Musteri musteri;
		public Masa masa;
		public Urun urun;

		private void btnMüşteriSeç_Click(object sender, EventArgs e)
		{
			MasalarForm frm = new MasalarForm();

			if (frm.ShowDialog() == DialogResult.OK)
			{
				masa = frm.masa;
				txtMusteri.Text = frm.masa.MasaNo.ToString();
				textBox1.Text = frm.masa.Mid.ToString();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			UrunListele frm = new UrunListele();

			if (frm.ShowDialog() == DialogResult.OK)
			{
				urun = frm.urun;
				txtUrun.Text = frm.urun.UrunID.ToString();
				textBox2.Text = frm.urun.Fiyat.ToString();
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{

			txtID.Text = siparis.SiparisID.ToString();
			
			siparis.Tarih = dtTarih.Value;
			siparis.Fiyat = Int32.Parse(textBox2.Text);
			siparis.UrunID = Guid.Parse(txtUrun.Text);
			siparis.MusteriID = Guid.Parse(textBox1.Text);
			siparis.mNO = Int32.Parse(txtMusteri.Text);

			DialogResult = DialogResult.OK;



		}

		private void SiparisForm_Load(object sender, EventArgs e)
		{

		}
	}
}
