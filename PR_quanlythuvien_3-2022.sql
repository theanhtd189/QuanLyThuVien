GO
CREATE DATABASE [PR_quanlythuvien_3-2022] 
GO
USE [PR_quanlythuvien_3-2022]
GO
/****** Object:  Table [dbo].[CTPM]    Script Date: 4/29/2022 5:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPM](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Maphieu] [int] NULL,
	[Masach] [int] NULL,
	[Tensach] [nvarchar](50) NULL,
	[Giatien] [float] NULL,
	[Theloai] [nvarchar](50) NULL,
	[Soluong] [int] NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_CTPM] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 4/29/2022 5:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[Madocgia] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Namsinh] [date] NULL,
	[Gioitinh] [bit] NULL,
	[Lop] [nvarchar](50) NULL,
	[Ngaytao] [date] NULL,
	[Manhanvien] [int] NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[Madocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiQuanLy]    Script Date: 4/29/2022 5:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiQuanLy](
	[Manguoiquanly] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_NguoiQuanLy] PRIMARY KEY CLUSTERED 
(
	[Manguoiquanly] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 4/29/2022 5:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Manhanvien] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Gioitinh] [bit] NULL,
	[Ngaysinh] [date] NULL,
	[Ngaytao] [date] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[Manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 4/29/2022 5:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[Maphieu] [int] IDENTITY(1,1) NOT NULL,
	[Manhanvien] [int] NULL,
	[Madocgia] [int] NOT NULL,
	[Ngaytao] [date] NULL,
	[Ngaytra] [date] NULL,
	[Trangthai] [bit] NULL,
 CONSTRAINT [PK_PhieuMuon] PRIMARY KEY CLUSTERED 
(
	[Maphieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sach]    Script Date: 4/29/2022 5:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[Masach] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[Tacgia] [nvarchar](50) NOT NULL,
	[NXB] [nvarchar](50) NOT NULL,
	[Namxuatban] [nvarchar](10) NOT NULL,
	[Matheloai] [int] NOT NULL,
	[Giatien] [float] NOT NULL,
	[Soluong] [int] NOT NULL,
	[Mota] [nvarchar](max) NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[Masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 4/29/2022 5:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[UserID] [nchar](10) NOT NULL,
	[Matkhau] [nvarchar](50) NULL,
	[Loai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 4/29/2022 5:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[Matheloai] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[Matheloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[CTPM] ON 

INSERT [dbo].[CTPM] ([ID], [Maphieu], [Masach], [Tensach], [Giatien], [Theloai], [Soluong], [TongTien]) VALUES (21, 13, 3, N'Sách 3', 56777, N'Truyện ', 6, 283885)
INSERT [dbo].[CTPM] ([ID], [Maphieu], [Masach], [Tensach], [Giatien], [Theloai], [Soluong], [TongTien]) VALUES (22, 13, 16, N'Làm giàu không khó', 54000, N'Truyện ', 3, 162000)
INSERT [dbo].[CTPM] ([ID], [Maphieu], [Masach], [Tensach], [Giatien], [Theloai], [Soluong], [TongTien]) VALUES (23, 13, 15, N'Năm ấy', 54000, N'Văn học nghệ thuật', 1, 54000)
INSERT [dbo].[CTPM] ([ID], [Maphieu], [Masach], [Tensach], [Giatien], [Theloai], [Soluong], [TongTien]) VALUES (24, 11, 9, N'Sach gkh', 2000, N'Toán học', 1, 2000)
INSERT [dbo].[CTPM] ([ID], [Maphieu], [Masach], [Tensach], [Giatien], [Theloai], [Soluong], [TongTien]) VALUES (25, 10, 16, N'Làm giàu không khó', 54000, N'Truyện ', 1, 54000)
INSERT [dbo].[CTPM] ([ID], [Maphieu], [Masach], [Tensach], [Giatien], [Theloai], [Soluong], [TongTien]) VALUES (26, 10, 14, N'Khi về già', 67706, N'Văn học nghệ thuật', 1, 67706)
INSERT [dbo].[CTPM] ([ID], [Maphieu], [Masach], [Tensach], [Giatien], [Theloai], [Soluong], [TongTien]) VALUES (27, 10, 7, N'Nhà giả kim', 55666, N'Sách giáo khoa', 1, 55666)
INSERT [dbo].[CTPM] ([ID], [Maphieu], [Masach], [Tensach], [Giatien], [Theloai], [Soluong], [TongTien]) VALUES (28, 10, 2, N'Sách 22', 2000, N'Toán học', 1, 2000)
INSERT [dbo].[CTPM] ([ID], [Maphieu], [Masach], [Tensach], [Giatien], [Theloai], [Soluong], [TongTien]) VALUES (29, 12, 1, N'Sách 111', 70000, N'Toán học', 1, 70000)
INSERT [dbo].[CTPM] ([ID], [Maphieu], [Masach], [Tensach], [Giatien], [Theloai], [Soluong], [TongTien]) VALUES (30, 12, 11, N'Toán nâng cao', 32660, N'Toán học', 1, 32660)
INSERT [dbo].[CTPM] ([ID], [Maphieu], [Masach], [Tensach], [Giatien], [Theloai], [Soluong], [TongTien]) VALUES (31, 14, 16, N'Làm giàu không khó', 54000, N'Truyện ', 1, 54000)
INSERT [dbo].[CTPM] ([ID], [Maphieu], [Masach], [Tensach], [Giatien], [Theloai], [Soluong], [TongTien]) VALUES (32, 14, 10, N'Test sách', 260000, N'Truyện ', 1, 260000)
SET IDENTITY_INSERT [dbo].[CTPM] OFF
SET IDENTITY_INSERT [dbo].[DocGia] ON 

INSERT [dbo].[DocGia] ([Madocgia], [Ten], [Namsinh], [Gioitinh], [Lop], [Ngaytao], [Manhanvien]) VALUES (8, N'The Anh1', CAST(N'2001-04-04' AS Date), 0, N'8A', CAST(N'2001-01-01' AS Date), 0)
INSERT [dbo].[DocGia] ([Madocgia], [Ten], [Namsinh], [Gioitinh], [Lop], [Ngaytao], [Manhanvien]) VALUES (9, N'Nam', CAST(N'2022-04-04' AS Date), 1, N'6A', CAST(N'2022-04-04' AS Date), 0)
INSERT [dbo].[DocGia] ([Madocgia], [Ten], [Namsinh], [Gioitinh], [Lop], [Ngaytao], [Manhanvien]) VALUES (11, N'Johnny', CAST(N'2000-04-10' AS Date), 1, N'5A', CAST(N'2022-04-10' AS Date), 0)
INSERT [dbo].[DocGia] ([Madocgia], [Ten], [Namsinh], [Gioitinh], [Lop], [Ngaytao], [Manhanvien]) VALUES (12, N'Melody Mark', CAST(N'1990-04-10' AS Date), 0, N'6E', CAST(N'2022-04-10' AS Date), 0)
SET IDENTITY_INSERT [dbo].[DocGia] OFF
SET IDENTITY_INSERT [dbo].[NguoiQuanLy] ON 

INSERT [dbo].[NguoiQuanLy] ([Manguoiquanly], [Ten]) VALUES (1, N'ADMIN')
INSERT [dbo].[NguoiQuanLy] ([Manguoiquanly], [Ten]) VALUES (2, N'Thầy Ba')
SET IDENTITY_INSERT [dbo].[NguoiQuanLy] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([Manhanvien], [Ten], [Gioitinh], [Ngaysinh], [Ngaytao]) VALUES (6, N'Nam NV', 1, CAST(N'2022-04-04' AS Date), CAST(N'2022-04-04' AS Date))
INSERT [dbo].[NhanVien] ([Manhanvien], [Ten], [Gioitinh], [Ngaysinh], [Ngaytao]) VALUES (8, N'Nhi ', 0, CAST(N'2022-04-04' AS Date), CAST(N'2022-04-04' AS Date))
INSERT [dbo].[NhanVien] ([Manhanvien], [Ten], [Gioitinh], [Ngaysinh], [Ngaytao]) VALUES (9, N'Lan', 0, CAST(N'2022-04-10' AS Date), CAST(N'2022-04-10' AS Date))
INSERT [dbo].[NhanVien] ([Manhanvien], [Ten], [Gioitinh], [Ngaysinh], [Ngaytao]) VALUES (10, N'Hùng', 1, CAST(N'1999-04-10' AS Date), CAST(N'2022-04-10' AS Date))
INSERT [dbo].[NhanVien] ([Manhanvien], [Ten], [Gioitinh], [Ngaysinh], [Ngaytao]) VALUES (11, N'Ngọc Nguyễn', 0, CAST(N'2001-10-10' AS Date), CAST(N'2022-04-29' AS Date))
INSERT [dbo].[NhanVien] ([Manhanvien], [Ten], [Gioitinh], [Ngaysinh], [Ngaytao]) VALUES (12, N'Nguyễn Thị Thu', 0, CAST(N'1996-07-24' AS Date), CAST(N'2022-04-29' AS Date))
INSERT [dbo].[NhanVien] ([Manhanvien], [Ten], [Gioitinh], [Ngaysinh], [Ngaytao]) VALUES (13, N'Nguyễn Anh Phú', 1, CAST(N'2001-11-10' AS Date), CAST(N'2022-04-29' AS Date))
INSERT [dbo].[NhanVien] ([Manhanvien], [Ten], [Gioitinh], [Ngaysinh], [Ngaytao]) VALUES (14, N'Trần Văn Hoàn ', 1, CAST(N'1993-06-26' AS Date), CAST(N'2022-04-29' AS Date))
INSERT [dbo].[NhanVien] ([Manhanvien], [Ten], [Gioitinh], [Ngaysinh], [Ngaytao]) VALUES (15, N'Đào Đức Long', 1, CAST(N'2003-04-29' AS Date), CAST(N'2022-04-29' AS Date))
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[PhieuMuon] ON 

INSERT [dbo].[PhieuMuon] ([Maphieu], [Manhanvien], [Madocgia], [Ngaytao], [Ngaytra], [Trangthai]) VALUES (10, 6, 9, CAST(N'2022-04-06' AS Date), CAST(N'2022-04-16' AS Date), 1)
INSERT [dbo].[PhieuMuon] ([Maphieu], [Manhanvien], [Madocgia], [Ngaytao], [Ngaytra], [Trangthai]) VALUES (11, 8, 8, CAST(N'2022-04-06' AS Date), CAST(N'2022-04-15' AS Date), 1)
INSERT [dbo].[PhieuMuon] ([Maphieu], [Manhanvien], [Madocgia], [Ngaytao], [Ngaytra], [Trangthai]) VALUES (12, 10, 8, CAST(N'2022-04-06' AS Date), CAST(N'2022-04-23' AS Date), 0)
INSERT [dbo].[PhieuMuon] ([Maphieu], [Manhanvien], [Madocgia], [Ngaytao], [Ngaytra], [Trangthai]) VALUES (13, 12, 9, CAST(N'2022-04-29' AS Date), CAST(N'2022-04-30' AS Date), 0)
INSERT [dbo].[PhieuMuon] ([Maphieu], [Manhanvien], [Madocgia], [Ngaytao], [Ngaytra], [Trangthai]) VALUES (14, 14, 12, CAST(N'2022-04-29' AS Date), CAST(N'2022-05-27' AS Date), 0)
SET IDENTITY_INSERT [dbo].[PhieuMuon] OFF
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([Masach], [Ten], [Tacgia], [NXB], [Namxuatban], [Matheloai], [Giatien], [Soluong], [Mota]) VALUES (1, N'Sách 111', N'TG1', N'NX1', N'2001', 1, 70000, 15, N'Không có')
INSERT [dbo].[Sach] ([Masach], [Ten], [Tacgia], [NXB], [Namxuatban], [Matheloai], [Giatien], [Soluong], [Mota]) VALUES (2, N'Sách 22', N'TG2', N'NX3', N'2010', 1, 2000, 49, N'Không có')
INSERT [dbo].[Sach] ([Masach], [Ten], [Tacgia], [NXB], [Namxuatban], [Matheloai], [Giatien], [Soluong], [Mota]) VALUES (3, N'Sách 3', N'TG3', N'nxb3', N'1999', 3, 56777, 1, N'Không có')
INSERT [dbo].[Sach] ([Masach], [Ten], [Tacgia], [NXB], [Namxuatban], [Matheloai], [Giatien], [Soluong], [Mota]) VALUES (7, N'Nhà giả kim', N'Noo', N'Kim đồng', N'2022', 5, 55666, 24, N'Không có')
INSERT [dbo].[Sach] ([Masach], [Ten], [Tacgia], [NXB], [Namxuatban], [Matheloai], [Giatien], [Soluong], [Mota]) VALUES (8, N'Sách 89', N'The ANh', N'Noo', N'2022', 4, 34234, 0, N'Không có')
INSERT [dbo].[Sach] ([Masach], [Ten], [Tacgia], [NXB], [Namxuatban], [Matheloai], [Giatien], [Soluong], [Mota]) VALUES (9, N'Sach gkh', N'TA', N'A', N'2022', 1, 2000, 2, N'Không có')
INSERT [dbo].[Sach] ([Masach], [Ten], [Tacgia], [NXB], [Namxuatban], [Matheloai], [Giatien], [Soluong], [Mota]) VALUES (10, N'Test sách', N'No', N'A', N'1234', 3, 260000, 64, N'Không có')
INSERT [dbo].[Sach] ([Masach], [Ten], [Tacgia], [NXB], [Namxuatban], [Matheloai], [Giatien], [Soluong], [Mota]) VALUES (11, N'Toán nâng cao', N'Jonny', N'NXB kim đồng', N'2021', 1, 32660, 14, N'Không có')
INSERT [dbo].[Sach] ([Masach], [Ten], [Tacgia], [NXB], [Namxuatban], [Matheloai], [Giatien], [Soluong], [Mota]) VALUES (12, N'Hình học lớp 12', N'Thùy Trang', N'NXB Kim đồng', N'2011', 1, 43000, 44, N'Không có')
INSERT [dbo].[Sach] ([Masach], [Ten], [Tacgia], [NXB], [Namxuatban], [Matheloai], [Giatien], [Soluong], [Mota]) VALUES (13, N'Giải tích 10', N'Ngô Bảo Châu', N'NXB tuổi trẻ', N'2018', 1, 36006, 5, N'Không có')
INSERT [dbo].[Sach] ([Masach], [Ten], [Tacgia], [NXB], [Namxuatban], [Matheloai], [Giatien], [Soluong], [Mota]) VALUES (14, N'Khi về già', N'Jun Phạm', N'NXB đồng nai', N'2018', 4, 67706, 17, N'Không có')
INSERT [dbo].[Sach] ([Masach], [Ten], [Tacgia], [NXB], [Namxuatban], [Matheloai], [Giatien], [Soluong], [Mota]) VALUES (15, N'Năm ấy', N'Đức Phúc', N'NXB HÀ NỘI', N'2001', 4, 54000, 16, N'Không có')
INSERT [dbo].[Sach] ([Masach], [Ten], [Tacgia], [NXB], [Namxuatban], [Matheloai], [Giatien], [Soluong], [Mota]) VALUES (16, N'Làm giàu không khó', N'Long Phạm ', N'NXB Tuổi trẻ', N'2008', 3, 54000, 172, N'Không có')
SET IDENTITY_INSERT [dbo].[Sach] OFF
INSERT [dbo].[TaiKhoan] ([UserID], [Matkhau], [Loai]) VALUES (N'DG11      ', N'123456789', N'docgia')
INSERT [dbo].[TaiKhoan] ([UserID], [Matkhau], [Loai]) VALUES (N'DG12      ', N'123456789', N'docgia')
INSERT [dbo].[TaiKhoan] ([UserID], [Matkhau], [Loai]) VALUES (N'DG8       ', N'123456789', N'docgia')
INSERT [dbo].[TaiKhoan] ([UserID], [Matkhau], [Loai]) VALUES (N'DG9       ', N'999999', N'docgia')
INSERT [dbo].[TaiKhoan] ([UserID], [Matkhau], [Loai]) VALUES (N'NV10      ', N'00000000', N'nhanvien')
INSERT [dbo].[TaiKhoan] ([UserID], [Matkhau], [Loai]) VALUES (N'NV11      ', N'123456', N'nhanvien')
INSERT [dbo].[TaiKhoan] ([UserID], [Matkhau], [Loai]) VALUES (N'NV12      ', N'123456', N'nhanvien')
INSERT [dbo].[TaiKhoan] ([UserID], [Matkhau], [Loai]) VALUES (N'NV13      ', N'123456', N'nhanvien')
INSERT [dbo].[TaiKhoan] ([UserID], [Matkhau], [Loai]) VALUES (N'NV14      ', N'123456', N'nhanvien')
INSERT [dbo].[TaiKhoan] ([UserID], [Matkhau], [Loai]) VALUES (N'NV15      ', N'123456', N'nhanvien')
INSERT [dbo].[TaiKhoan] ([UserID], [Matkhau], [Loai]) VALUES (N'NV6       ', N'1234567', N'nhanvien')
INSERT [dbo].[TaiKhoan] ([UserID], [Matkhau], [Loai]) VALUES (N'NV8       ', N'123456789', N'nhanvien')
INSERT [dbo].[TaiKhoan] ([UserID], [Matkhau], [Loai]) VALUES (N'NV9       ', N'123456', N'nhanvien')
INSERT [dbo].[TaiKhoan] ([UserID], [Matkhau], [Loai]) VALUES (N'QL1       ', N'admin', N'quanly')
INSERT [dbo].[TaiKhoan] ([UserID], [Matkhau], [Loai]) VALUES (N'QL2       ', N'admin', N'quanly')
SET IDENTITY_INSERT [dbo].[TheLoai] ON 

INSERT [dbo].[TheLoai] ([Matheloai], [Ten]) VALUES (1, N'Toán học')
INSERT [dbo].[TheLoai] ([Matheloai], [Ten]) VALUES (3, N'Truyện ')
INSERT [dbo].[TheLoai] ([Matheloai], [Ten]) VALUES (4, N'Văn học nghệ thuật')
INSERT [dbo].[TheLoai] ([Matheloai], [Ten]) VALUES (5, N'Sách giáo khoa')
INSERT [dbo].[TheLoai] ([Matheloai], [Ten]) VALUES (7, N'Lịch sử')
INSERT [dbo].[TheLoai] ([Matheloai], [Ten]) VALUES (8, N'Tạp chí')
SET IDENTITY_INSERT [dbo].[TheLoai] OFF
ALTER TABLE [dbo].[DocGia] ADD  CONSTRAINT [DF_DocGia_Ngaytao]  DEFAULT (getdate()) FOR [Ngaytao]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_NhanVien_Ngaytao]  DEFAULT (getdate()) FOR [Ngaytao]
GO
ALTER TABLE [dbo].[PhieuMuon] ADD  CONSTRAINT [DF_PhieuMuon_Ngaytao]  DEFAULT (getdate()) FOR [Ngaytao]
