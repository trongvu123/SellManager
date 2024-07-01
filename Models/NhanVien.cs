using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SellManager.Models;

[Table("NhanVien")]
public partial class NhanVien
{
    [Key]
    [Column("MaNV")]
    public int MaNv { get; set; }

    [StringLength(50)]
    public string? Ho { get; set; }

    [StringLength(50)]
    public string? Ten { get; set; }

    public bool? Nu { get; set; }

    [Column("NgayNV")]
    public DateOnly? NgayNv { get; set; }

    [StringLength(50)]
    public string? DiaChi { get; set; }

    [StringLength(50)]
    public string? DienThoai { get; set; }

    [StringLength(50)]
    public string? Hinh { get; set; }

    [Column("MaDN")]
    [StringLength(50)]
    public string MaDn { get; set; } = null!;

    [StringLength(50)]
    public string MatKhau { get; set; } = null!;

    [InverseProperty("MaNvNavigation")]
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
