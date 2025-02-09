﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ITShop.Models
{
    public class LoaiSanPham
    {
        [DisplayName("Mã loại")]
        public int ID { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "Tên loại không được bỏ trống.")]
        [DisplayName("Tên loại")]
        public required string TenLoai { get; set; } 

        [StringLength(255)]
        [DisplayName("Tên loại không dấu")]
        public string? TenLoaiKhongDau { get; set; }

        public ICollection<SanPham>? SanPham { get; set; }
    }
}
