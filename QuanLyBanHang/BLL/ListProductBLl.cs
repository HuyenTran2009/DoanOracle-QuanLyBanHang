using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAL;


namespace QuanLyBanHang.BLL
{
    public class ListProductBLL
    {
        public ListProductDAL lBLL;

        public ListProductBLL(string searchtext, int skip, int take, string loadSp = "")
        {
            lBLL = new ListProductDAL(searchtext, skip, take, loadSp);
        }
    }
}
