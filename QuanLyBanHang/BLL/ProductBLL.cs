using QuanLyBanHang.DAL;
using System;

namespace QuanLyBanHang.BLL
{
    public class ProductBLL
    {
        public ProductDAL pBLL;

        public ProductBLL(int i)
        {
            this.pBLL = new ProductDAL(i);
        }

        public int checkQty(int iQty)
        {
            if (iQty > Convert.ToInt32(this.pBLL.pDAL.PQty))
                return 1;
            else if (iQty < 1)
                return -1;
            else if (Convert.ToInt32(this.pBLL.pDAL.PQty) == 0)
            { 
                return 2;
            }

            else return 0;

        }
    }
}
