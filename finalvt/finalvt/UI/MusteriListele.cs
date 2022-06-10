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

namespace finalvt.UI
{
	public partial class MusteriListele : Form
	{
		public MusteriListele()
		{
			InitializeComponent();
		}

		public Musteri musteri { get; set; }

		private void button1_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = dataGridView1.SelectedRows[0];
			musteri = new Musteri
			{
				MusteriID = Guid.Parse(row.Cells[0].Value.ToString()),
				Ad = row.Cells[1].Value.ToString(),
				Soyad = row.Cells[2].Value.ToString(),
				Telefon = row.Cells[3].Value.ToString()
			};


			DialogResult = DialogResult.OK;
		}

		private void MusteriListele_Load(object sender, EventArgs e)
		{
			DataSet ds1 = BLogic.MüşteriGetir("");
			if (ds1 != null)
				dataGridView1.DataSource = ds1.Tables[0];
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}
	}
}
