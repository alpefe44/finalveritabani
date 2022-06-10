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
	public partial class UrunListele : Form
	{
		public UrunListele()
		{
			InitializeComponent();
		}
		public Urun urun { get; set; }
		private void button1_Click(object sender, EventArgs e)
		{

			DataGridViewRow row = dataGridView1.SelectedRows[0];
			urun = new Urun
			{
				UrunID = Guid.Parse(row.Cells[0].Value.ToString()),
				Ad = row.Cells[1].Value.ToString(),
				Kategori = row.Cells[2].Value.ToString(),
				Fiyat = Int32.Parse(row.Cells[3].Value.ToString())
			};


			DialogResult = DialogResult.OK;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void UrunListele_Load(object sender, EventArgs e)
		{
			DataSet ds1 = BLogic.UrunGetir("");
			if (ds1 != null)
				dataGridView1.DataSource = ds1.Tables[0];
		}
	}
}
