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
	public partial class MasalarForm : Form
	{
		public MasalarForm()
		{
			InitializeComponent();
		}

		public Masa masa { get; set; }

		private void button1_Click(object sender, EventArgs e)
		{
			DataGridViewRow row = dataGridView1.SelectedRows[0];
			masa = new Masa
			{
				MasaNo = Int32.Parse(row.Cells[0].Value.ToString()),
				MasaKisi = Int32.Parse(row.Cells[2].Value.ToString()),
				Mid = Guid.Parse(row.Cells[1].Value.ToString())


			};


			DialogResult = DialogResult.OK;
		}

		private void MasalarForm_Load(object sender, EventArgs e)
		{
			DataSet ds1 = BLogic.MasaGetir("");
			if (ds1 != null)
				dataGridView1.DataSource = ds1.Tables[0];
		}
	}
}
