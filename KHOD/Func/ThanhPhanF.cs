using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using KHOD.DAO;
namespace KHOD.Func
{
	class ThanhPhanF
	{
		MyDB db = new MyDB();
		private int Buoi;
		private DateTime Ngay;
		private string ThanhPhan;
		private float DinhLuong;
		public ThanhPhanF()
		{

		}
		/*public List<ThanhPhanF> ListAll()
		{
			List<ThanhPhanF> list = new List<ThanhPhanF>();
			
		}*/
	}
}
