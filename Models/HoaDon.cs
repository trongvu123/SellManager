using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SellManager.Models;

[Table("HoaDon")]
public partial class HoaDon
{
    [Key]
    [Column("MaHD")]
    public int MaHd { get; set; }

    [Column("MaKH")]
    [StringLength(20)]
    public string MaKh { get; set; } = null!;

    [Column("NgayLapHD", TypeName = "datetime")]
    public DateTime NgayLapHd { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime NgayNhanHang { get; set; }

    [Column("MaNV")]
    public int? MaNv { get; set; }


    [InverseProperty("MaHdNavigation")]
    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    [ForeignKey("MaKh")]
    [InverseProperty("HoaDons")]
    public virtual KhachHang MaKhNavigation { get; set; } = null!;

    [ForeignKey("MaNv")]
    [InverseProperty("HoaDons")]
    public virtual NhanVien? MaNvNavigation { get; set; }
}
