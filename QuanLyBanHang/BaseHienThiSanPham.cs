using QuanLyBanHang.BLL;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public class BaseHienThiSanPham: BaseForm
    {
        protected string selectedLoaiSpId = string.Empty;
        protected static ListDanhMucSanPhamDLL _manHinhTimKiemListDanhMucSanPhamDLL = null;
        protected static Dictionary<string, string> _manHinhTimKiemListDanhMucSanPhamDLLMappings = null;

        private TreeView _danhMucSanPham = null;
        public BaseHienThiSanPham()
        {
            if (_manHinhTimKiemListDanhMucSanPhamDLL == null)
            {
                _manHinhTimKiemListDanhMucSanPhamDLL = new ListDanhMucSanPhamDLL();
                _manHinhTimKiemListDanhMucSanPhamDLLMappings = _manHinhTimKiemListDanhMucSanPhamDLL.lBLL.lspDAL.ToDictionary(d => d.Name, e => e.Id);
            }
        }

        protected void LoadDanhMucSanPham()
        {
            if(_danhMucSanPham == null)
            {
                return;
            }

            TreeNode rootNode = _danhMucSanPham.Nodes.Cast<TreeNode>().ToList().Find(n => n.Text.Equals("DANH MỤC SẢN PHẨM"));
            if (rootNode != null)
            {
                if (_manHinhTimKiemListDanhMucSanPhamDLL.lBLL.lspDAL.Any())
                {
                    foreach (var item in _manHinhTimKiemListDanhMucSanPhamDLL.lBLL.lspDAL)
                    {
                        rootNode.Nodes.Add(item.Name);
                    }

                    _danhMucSanPham.ExpandAll();
                }
            }
        }

        protected void SetInsanceDanhMucSanPham(TreeView _danhMucSanPham)
        {
            this._danhMucSanPham = _danhMucSanPham;
            this._danhMucSanPham.AfterSelect += _danhMucSanPham_AfterSelect;
        }

        private void _danhMucSanPham_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedLoaiSpId = _manHinhTimKiemListDanhMucSanPhamDLLMappings.ContainsKey(e.Node.Text) ?
                                _manHinhTimKiemListDanhMucSanPhamDLLMappings[e.Node.Text] :
                                string.Empty;
            LoadSPTheoLoai();
        }

        protected virtual void LoadSPTheoLoai(){}
    }
}
