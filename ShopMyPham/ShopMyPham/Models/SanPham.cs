//------------------------------------------------------------------------------
// <none-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </none-generated>
//------------------------------------------------------------------------------

namespace ShopMyPham.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.SanPhamHinhs = new HashSet<SanPhamHinh>();
        }
    
        public int SanPhamID { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public decimal GiaBan { get; set; }
        public Nullable<byte> TrangThai { get; set; }
        public string Mota { get; set; }
        public Nullable<int> SoLanXem { get; set; }
        public System.DateTime NgayThem { get; set; }
        public Nullable<int> IDKhuyenMai { get; set; }
        public Nullable<int> IDThuongHieu { get; set; }
        public Nullable<int> IDLoai { get; set; }
        public Nullable<byte> Promotion { get; set; }
        public string SEO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPhamHinh> SanPhamHinhs { get; set; }
    }
}
