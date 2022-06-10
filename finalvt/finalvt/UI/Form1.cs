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
using finalvt.DL;
using finalvt.UI;

namespace finalvt
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MusteriForm frmMusteri = new MusteriForm()
			{
				Text = "Müşteri Ekle",
				musteri = new Musteri() { MusteriID = Guid.NewGuid() },
			};

		tekrar:
			var sonuc = frmMusteri.ShowDialog();
			if (sonuc == DialogResult.OK)
			{
				bool b = BLogic.MüşteriEkle(frmMusteri.musteri);

				if (b)
				{
					DataSet ds = BLogic.MüşteriGetir("");
					if (ds != null)
						dataGridView1.DataSource = ds.Tables[0];
						
				}
				else
					goto tekrar;

			}
		}


		private void button2_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = dataGridView1.SelectedRows[0];
			var ID = row.Cells[0].Value.ToString();

			var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			if (sonuc == DialogResult.OK)
			{
				bool b = BLogic.MüşteriSil(ID);

				if (b)
				{

					DataSet ds = BLogic.MüşteriGetir("");
					if (ds != null)
						dataGridView1.DataSource = ds.Tables[0];
				}

			}
		}


		private void Form1_Load_1(object sender, EventArgs e)
		{
			DataSet ds1 = BLogic.MüşteriGetir("");
			if (ds1 != null)
				dataGridView1.DataSource = ds1.Tables[0];

			DataSet ds2 = BLogic.UrunGetir("");
			if (ds2 != null)
				dataGridView2.DataSource = ds2.Tables[0];

			DataSet ds3 = BLogic.MasaGetir("");
			if (ds3 != null)
				dataGridView4.DataSource = ds3.Tables[0];

			DataSet ds4 = BLogic.SiparisGetir("");
			if (ds4 != null)
				dataGridView3.DataSource = ds4.Tables[0];

		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			DataSet ds = BLogic.MüşteriGetir(toolStripTextBox2.Text);
			if (ds != null)
				dataGridView1.DataSource = ds.Tables[0];
		}

		private void button8_Click(object sender, EventArgs e)
		{
			UrunForm frmUrun = new UrunForm()
			{
				Text = "Urun Ekle",
				urun = new Urun() { UrunID = Guid.NewGuid() },
			};

		tekrar:
			var sonuc = frmUrun.ShowDialog();
			if (sonuc == DialogResult.OK)
			{
				bool b = BLogic.UrunEkle(frmUrun.urun);

				if (b)
				{
					DataSet ds = BLogic.UrunGetir("");
					if (ds != null)
						dataGridView2.DataSource = ds.Tables[0];

				}
				else
					goto tekrar;

			}
		}


		private void tabPage2_Click(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = dataGridView2.SelectedRows[0];
			var ID = row.Cells[0].Value.ToString();


			var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			if (sonuc == DialogResult.OK)
			{
				bool b = BLogic.UrunSil(ID);

				if (b)
				{
					DataSet ds = BLogic.UrunGetir("");
					if (ds != null)
						dataGridView2.DataSource = ds.Tables[0];
				}

			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			DataSet ds = BLogic.UrunGetir(toolStripTextBox1.Text);
			if (ds != null)
				dataGridView2.DataSource = ds.Tables[0];
		}

		private void toolStripButton5_Click(object sender, EventArgs e)
		{
			MasaForm frmMasa = new MasaForm()
			{
				Text = "Masa Ekle",
				masa = new Masa()
				
			};

		tekrar:
			var sonuc = frmMasa.ShowDialog();
			if (sonuc == DialogResult.OK)
			{
				bool b = BLogic.MasaEkle(frmMasa.masa);

				if (b)
				{
					DataSet ds = BLogic.MasaGetir("");
					if (ds != null)
						dataGridView4.DataSource = ds.Tables[0];

				}
				else
					goto tekrar;

			}
		}

		private void toolStripButton6_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = dataGridView4.SelectedRows[0];
			var ID = row.Cells[0].Value.ToString();


			var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			if (sonuc == DialogResult.OK)
			{
				bool b = BLogic.MasaSil(ID);

				if (b)
				{
					DataSet ds = BLogic.MasaGetir("");
					if (ds != null)
						dataGridView4.DataSource = ds.Tables[0];
				}

			}
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			SiparisForm frmSip = new SiparisForm()
			{
				Text = "Sipariş Ekle",
				siparis = new Siparis() { SiparisID= Guid.NewGuid() }

			};

		tekrar:
			var sonuc = frmSip.ShowDialog();
			if (sonuc == DialogResult.OK)
			{
				bool b = BLogic.SiparisEkle(frmSip.siparis);

				if (b)
				{
					DataSet ds = BLogic.SiparisGetir("");
					if (ds != null)
						dataGridView3.DataSource = ds.Tables[0];

				}
				else
					goto tekrar;

			}
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = dataGridView3.SelectedRows[0];
			var ID = row.Cells[0].Value.ToString();


			var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			if (sonuc == DialogResult.OK)
			{
				bool b = BLogic.SiparisSil(ID);

				if (b)
				{
					DataSet ds = BLogic.SiparisGetir("");
					if (ds != null)
						dataGridView3.DataSource = ds.Tables[0];
				}

			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = dataGridView2.SelectedRows[0];

			UrunForm frm = new UrunForm()
			{
				Text = "Ürün Güncelle",
				Güncelle = true,
				urun = new Urun()
				{
					UrunID = Guid.Parse(row.Cells[0].Value.ToString()),
					Ad = row.Cells[1].Value.ToString(),
					Kategori = row.Cells[2].Value.ToString(),
					Fiyat = Int32.Parse(row.Cells[3].Value.ToString())

				},
			};

			var sonuc = frm.ShowDialog();
			if (sonuc == DialogResult.OK)
			{
				bool b = BLogic.UrunGüncelle(frm.urun);

				if (b)
				{
					row.Cells[0].Value = frm.urun.UrunID;
					row.Cells[1].Value = frm.urun.Ad;
					row.Cells[2].Value = frm.urun.Kategori;
					row.Cells[3].Value = frm.urun.Fiyat;

				}

			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = dataGridView1.SelectedRows[0];

			MusteriForm frm = new MusteriForm()
			{
				Text = "Müşteri Güncelle",
				Güncelle = true,
				musteri = new Musteri()
				{
					MusteriID = Guid.Parse(row.Cells[0].Value.ToString()),
					Ad = row.Cells[1].Value.ToString(),
					Soyad = row.Cells[2].Value.ToString(),
					Telefon = row.Cells[3].Value.ToString()
				},
			};

			var sonuc = frm.ShowDialog();
			if (sonuc == DialogResult.OK)
			{
				bool b = BLogic.MüşteriGüncelle(frm.musteri);

				if (b)
				{
					row.Cells[0].Value = frm.musteri.MusteriID;
					row.Cells[1].Value = frm.musteri.Ad;
					row.Cells[2].Value = frm.musteri.Soyad;
					row.Cells[3].Value = frm.musteri.Telefon;

				}

			}
		}

		private void toolStripButton7_Click(object sender, EventArgs e)
		{
			
		}

		private void button4_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}

