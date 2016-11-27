using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopMyPham.Models;
namespace ShopMyPham.ViewModel
{
    public class SearchModel    {
        private readonly ShopMyPhamEntities db = new ShopMyPhamEntities();
        public List<SanPham> Search(string search)
        {
            return db.SanPhams.Where(x => x.TenSanPham.Contains(search)).ToList();
        }
    }
}