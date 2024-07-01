using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SellManager.Models;

[Table("ThanhPho")]
public partial class ThanhPho
{
    [Key]
    public int MaThanhPho { get; set; }

    [StringLength(50)]
    public string? TenThanhPho { get; set; }

    [InverseProperty("MaThanhPhoNavigation")]
    public virtual ICollection<KhachHang> KhachHangs { get; set; } = new List<KhachHang>();
}
