using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAL;


namespace QuanLyBanHang.BLL
{
    public class ListDanhMucSanPhamDLL
    {
        public ListDanhMucSanPhamDAL lBLL;
        public ListDanhMucSanPhamDLL()
        {
            lBLL = new ListDanhMucSanPhamDAL();
        }
    }
}
