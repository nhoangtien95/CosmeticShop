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
    
    public partial class QuanTri
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public Nullable<byte> Level { get; set; }
    }
}
