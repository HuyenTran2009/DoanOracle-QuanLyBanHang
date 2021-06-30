using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DTO
{
    public class Product
    {
        private string pID;
        public string PID { get => pID; set => pID = value; }

        private string pName;
        public string PName { get => pName; set => pName = value; }

        private string pCategory;
        public string PCategory { get => pCategory; set => pCategory = value; }

        private string pCost;
        public string PCost { get => pCost; set => pCost = value; }

        private string pQty;
        public string PQty { get => pQty; set => pQty = value; }

        private string pImgUrl;
        public string PImgUrl { get => pImgUrl; set => pImgUrl = value; }

        private string pDetail;
        public string PDetail { get => pDetail; set => pDetail = value; }

        public Product() { }
    }
}
