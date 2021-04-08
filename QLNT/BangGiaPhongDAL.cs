﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class BangGiaPhongDAL
	{
		private static BangGiaPhongDAL instance;
		private DBAccess manager;
		DBAccess data = new DBAccess();

		private BangGiaPhongDAL()
		{
			manager = new DBAccess();
			manager.open();
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		public static BangGiaPhongDAL getInstance()
		{
			if (instance == null)
			{
				instance = new BangGiaPhongDAL();
			}
			return instance;
		}

<<<<<<< HEAD
		[MethodImpl(MethodImplOptions.Synchronized)]
		public static BangGiaPhongDAL getInstance()
		{
			if (instance == null)
			{
				instance = new BangGiaPhongDAL();
			}
			return instance;
		}

=======
>>>>>>> c2b4d2cf83785b2ed29daeef0779744c5a1b5241
	
		public DataTable LoadThongTinGiaThue()
		{
			String sql = "select SoNguoi, PARSENAME(convert(varchar,convert(money,GiaTien),1),2 ) as giatien from GIA_THUE";
			DataTable table = manager.executeQuery(sql);
			return table;
		}

		//Thêm phòng mới vào bảng giá phòng
		public bool ThemPhong(BangGiaPhong banggia)
		{
			SqlParameter p1 = new SqlParameter("@songuoi", banggia.getSoNguoi());
			SqlParameter p2 = new SqlParameter("@giatien", banggia.getGiaTien());

			SqlParameter[] giatri = { p1, p2 };

			return manager.Update("ThemPhong", giatri);
		}

		public void SuaPhong(BangGiaPhong banggia)
		{
			SqlParameter p1 = new SqlParameter("@songuoi", banggia.getSoNguoi());
			SqlParameter p2 = new SqlParameter("@giatien", banggia.getGiaTien());

			SqlParameter[] giatri = { p1, p2 };

			data.Update("SuaPhong", giatri);
		}
	}
}
