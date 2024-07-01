using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SellManager.Models;

[Table("SanPham")]
public partial class SanPham
{
    [Key]
    [Column("MaSP")]
    public int MaSp { get; set; }

    [Column("TenSP")]
    [StringLength(40)]
    public string TenSp { get; set; } = null!;

    [StringLength(50)]
    public string? DonViTinh { get; set; }

 
    public double? DonGia { get; set; }

    [StringLength(50)]
    public string? Hinh { get; set; }

    [InverseProperty("MaSpNavigation")]
    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();
}
