using System.Collections.Generic;


namespace QuanLyBanHang.BLL
{
    public class GioHangBLL
    {
        public Dictionary<int, int> IdSL = new Dictionary<int, int>();
        private static GioHangBLL instance;
        public static GioHangBLL Instance
        {
            get
            {
                if (instance == null) instance = new GioHangBLL();
                return GioHangBLL.instance;
            }
            private set { GioHangBLL.instance = value; }
        }
        public void addGioHang(int Qty, int id)
        {
            if (!IdSL.ContainsKey(id))
            {
                IdSL.Add(id, Qty);
            }
            else
            {
                IdSL[id] += Qty;
            }
        }

        public bool checkId(int Qty, int id)
        {
            var check = IdSL.ContainsKey(id);

            addGioHang(Qty, id);
            return check;

        }

    }
}
