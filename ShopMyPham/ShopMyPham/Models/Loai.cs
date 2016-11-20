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
    
    public partial class Loai
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public Nullable<int> ChungLoaiID { get; set; }
        public string SEO { get; set; }
    }
}
