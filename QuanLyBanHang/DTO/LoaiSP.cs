using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DTO
{
    public class LoaiSP
    {
        private string _id;
        public string Id { get => _id; set => _id = value; }

        private string _name;
        public string Name { get => _name; set => _name = value; }

        public LoaiSP() { }
    }
}
