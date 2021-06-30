using QuanLyBanHang.DAL;
using System.Collections.Generic;


namespace QuanLyBanHang.BLL
{
    public class GioHangBLL
    {
        private static int? processingHoaDonId = null;
        public bool HasHoaDonId => processingHoaDonId.HasValue;
        public int HoaDonId {
            get => processingHoaDonId.Value;
            set => processingHoaDonId = value;
        }

        public Dictionary<int, int> IdSL = new Dictionary<int, int>();
        private static GioHangBLL instance;
        private GioHangDAL gioHangDAL;
        private GioHangBLL()
        {
            gioHangDAL = new GioHangDAL();
        }

        public static GioHangBLL Instance
        {
            get
            {
                if (instance == null) instance = new GioHangBLL();
                return instance;
            }
        }

        public bool TryAddGioHang(int Qty, int id)
        {
            if (!IdSL.ContainsKey(id))
            {
                IdSL.Add(id, Qty);
            }
            else
            {
                IdSL[id] += Qty;
            }

            return gioHangDAL.GhiGioHang(instance);
        }


        public bool ThanhToan()
        {
            return new HoaDonDAL().ThanhToanHoaDon(instance);
        }

        public bool Check(int qty, int id)
        {
            var check = IdSL.ContainsKey(id);
            TryAddGioHang(qty, id);
            return check;
        }
    }
}
