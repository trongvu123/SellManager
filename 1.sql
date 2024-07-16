IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [NhanVien] (
    [MaNV] int NOT NULL IDENTITY,
    [Ho] nvarchar(50) NULL,
    [Ten] nvarchar(50) NULL,
    [Nu] bit NULL,
    [NgayNV] date NULL,
    [DiaChi] nvarchar(50) NULL,
    [DienThoai] nvarchar(50) NULL,
    [Hinh] nvarchar(50) NULL,
    [MaDN] nvarchar(50) NOT NULL,
    [isAdmin] bit NOT NULL,
    [MatKhau] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_NhanVien] PRIMARY KEY ([MaNV])
);
GO

CREATE TABLE [SanPham] (
    [MaSP] int NOT NULL IDENTITY,
    [TenSP] nvarchar(40) NOT NULL,
    [DonViTinh] nvarchar(50) NULL,
    [DonGia] float NULL DEFAULT 0.0E0,
    [Hinh] nvarchar(50) NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([MaSP])
);
GO

CREATE TABLE [ThanhPho] (
    [MaThanhPho] int NOT NULL IDENTITY,
    [TenThanhPho] nvarchar(50) NULL,
    CONSTRAINT [PK_ThanhPho] PRIMARY KEY ([MaThanhPho])
);
GO

CREATE TABLE [KhachHang] (
    [MaKH] nvarchar(20) NOT NULL,
    [TenCty] nvarchar(50) NOT NULL,
    [DiaChi] nvarchar(60) NULL,
    [DienThoai] nvarchar(24) NULL,
    [MaThanhPho] int NOT NULL DEFAULT 1,
    CONSTRAINT [PK_Customers] PRIMARY KEY ([MaKH]),
    CONSTRAINT [FK_KhachHang_ThanhPho] FOREIGN KEY ([MaThanhPho]) REFERENCES [ThanhPho] ([MaThanhPho]) ON DELETE CASCADE
);
GO

CREATE TABLE [HoaDon] (
    [MaHD] int NOT NULL IDENTITY,
    [MaKH] nvarchar(20) NOT NULL,
    [NgayLapHD] datetime NOT NULL DEFAULT ((getdate())),
    [NgayNhanHang] datetime NOT NULL DEFAULT ((((1)/(1))/(1900))),
    [MaNV] int NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY ([MaHD]),
    CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY ([MaNV]) REFERENCES [NhanVien] ([MaNV]) ON DELETE CASCADE,
    CONSTRAINT [FK_Orders_Customers] FOREIGN KEY ([MaKH]) REFERENCES [KhachHang] ([MaKH])
);
GO

CREATE TABLE [ChiTietHoaDon] (
    [MaHD] int NOT NULL,
    [MaSP] int NOT NULL,
    [SoLuong] int NOT NULL DEFAULT 1,
    CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY ([MaHD], [MaSP]),
    CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY ([MaHD]) REFERENCES [HoaDon] ([MaHD]) ON DELETE CASCADE,
    CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY ([MaSP]) REFERENCES [SanPham] ([MaSP])
);
GO

CREATE INDEX [IX_ChiTietHoaDon_MaSP] ON [ChiTietHoaDon] ([MaSP]);
GO

CREATE INDEX [IX_HoaDon_MaKH] ON [HoaDon] ([MaKH]);
GO

CREATE INDEX [IX_HoaDon_MaNV] ON [HoaDon] ([MaNV]);
GO

CREATE INDEX [IX_KhachHang_MaThanhPho] ON [KhachHang] ([MaThanhPho]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240716090022_v0', N'9.0.0-preview.5.24306.3');
GO

COMMIT;
GO

