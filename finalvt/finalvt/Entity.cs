using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalvt
{
	public class Musteri
	{
		public Guid MusteriID { get; set; }
		public string Ad { get; set; }

		public string Soyad { get; set; }

		public string Telefon { get; set; }


	}


	public class Urun
	{
		public Guid UrunID { get; set; }
		public string Ad { get; set; }
		public string Kategori { get; set;}
		public double Fiyat { get; set; }
	}

	public class Siparis
	{
		public Guid SiparisID { get; set; }

		public Guid UrunID { get; set; }
		public Guid MusteriID { get; set; }

		public int mNO { get; set; }

		public DateTime Tarih { get; set; }
		public double Fiyat { get; set; }
	}


	public class Masa
	{
		public int MasaNo { get; set; }

		public int MasaKisi { get; set; }

		public Guid Mid { get; set; }
	}


}
