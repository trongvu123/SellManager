using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SellManager.Models;

[PrimaryKey("MaHd", "MaSp")]
[Table("ChiTietHoaDon")]
public partial class ChiTietHoaDon
{
    [Key]
    [Column("MaHD")]
    public int MaHd { get; set; }

    [Key]
    [Column("MaSP")]
    public int MaSp { get; set; }

    public int SoLuong { get; set; }

    [ForeignKey("MaHd")]
    [InverseProperty("ChiTietHoaDons")]
    public virtual HoaDon MaHdNavigation { get; set; } = null!;

    [ForeignKey("MaSp")]
    [InverseProperty("ChiTietHoaDons")]
    public virtual SanPham MaSpNavigation { get; set; } = null!;
}
