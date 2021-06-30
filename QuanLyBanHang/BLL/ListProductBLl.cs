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
        private static readonly string[] VietNamChar = new string[]
        {
            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỵỷỹ",
            "ÝỲỴỶỸ"
        };
        public static string utf8Convert1(string str)
        {
            if (str == null)
                return "";
            //Thay thế và lọc dấu từng char      
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
            }
            return str;
        }


        public ListProductDAL lBLL;

        //public ListProductBLL(string searchString, int flat)
        //{
        //    List<int> delElement = new List<int>();
        //    Load(searchString, )
        //    searchString = utf8Convert1(searchString);
        //    foreach(var el in this.lBLL.lDAL)
        //    {
        //        if(!(utf8Convert1(el.PName).ToLower().Contains(searchString.ToLower())))
        //        {
        //            delElement.Add(Convert.ToInt32(el.PID));
        //        }
        //    }
        //    for (int k = 0; k < delElement.Count(); k++)
        //    {
        //        this.lBLL.lDAL.RemoveAt(delElement[k]-1);
        //        for (int i = 0; i < delElement.Count(); i++)
        //        {
                    
        //            delElement[i]--;
        //        }
        //    }
        //}

        public ListProductBLL(string searchtext, int skip, int take)
        {
            lBLL = new ListProductDAL(searchtext, skip, take);
        }
    }
}
