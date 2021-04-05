﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class DangKyBLL
	{
		DangKyDAL data = DangKyDAL.get();

		public DataTable loadKhachThueChuaCoPhong() 
		{
        return data.loadKhachThueChuaCoPhong();
    }

	public DataTable LoadPhongChuaCOKhach() 
	{
        return data.LoadPhongChuaCOKhach();
	}

	public DataTable LoadPhongDaCoKhach()
	{
        return data.LoadPhongDaCoKhach();
	}

	public DataTable loadChiTietKhachThue(DangKy dangKyPhong) 
	{
        return data.loadChiTietKhachThue(dangKyPhong);
	}

	//Thêm khách ở ghép
	public bool ThemKhachOghep(DangKy dangKyPhong)
	{
        return data.ThemKhachOghep(dangKyPhong);
	}

	//Thêm khách ở phòng mới
	public bool ThemKhachThueVaoPhongMoi(DangKy dangKyPhong) 
	{
        return data.ThemKhachThueVaoPhongMoi(dangKyPhong);
	}

	//Load danh sách phòng có thể ở ghép
	public DataTable loadMaPhongOGhep()
	{
        return data.loadMaPhongOGhep();
	}

	//Load danh sách phòng có thể thuê mới
	public DataTable LoadMaPhongMoi()
	{
        return data.LoadMaPhongMoi();
	}

	
}
}