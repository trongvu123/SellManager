using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SellManager.Models;

[Table("KhachHang")]
public partial class KhachHang
{
    [Key]
    [Column("MaKH")]
    [StringLength(20)]
    public string MaKh { get; set; } = null!;

    [StringLength(50)]
    public string TenCty { get; set; } = null!;

    [StringLength(60)]
    public string? DiaChi { get; set; }

    [StringLength(24)]
    public string? DienThoai { get; set; }

    public int MaThanhPho { get; set; }

    [InverseProperty("MaKhNavigation")]
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    [ForeignKey("MaThanhPho")]
    [InverseProperty("KhachHangs")]
    public virtual ThanhPho MaThanhPhoNavigation { get; set; } = null!;
}
