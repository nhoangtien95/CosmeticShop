﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShopMyPhamEntities : DbContext
    {
        public ShopMyPhamEntities()
            : base("name=ShopMyPhamEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Loai> Loais { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<SanPhamHinh> SanPhamHinhs { get; set; }
        public virtual DbSet<DonHangChiTiet> DonHangChiTiets { get; set; }
        public virtual DbSet<QuanTri> QuanTris { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<ThuongHieu> ThuongHieux { get; set; }
        public virtual DbSet<SalePromotion> SalePromotions { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
    }
}
