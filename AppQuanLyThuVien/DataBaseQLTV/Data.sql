﻿﻿USE QuanLyThuVien
GO
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000001', N'Nguyễn Đức Mạnh', N'Nam', CAST(N'1996-04-19' AS Date), N'Quế Võ-Bắc Ninh', N'01627998425  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000002', N'Nguyễn Hải Ninh', N'Nam', CAST(N'1992-09-19' AS Date), N'Quế Võ-Bắc Ninh', N'01636571234  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000003', N'Vũ Viết Phúc', N'Nam', CAST(N'1996-07-19' AS Date), N'Gia Bình-Bắc Ninh', N'01656748321  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000004', N'Nguyễn Tùng Lâm', N'Nam', CAST(N'1996-01-19' AS Date), N'Gia Lâm-Hà Nội', N'01698218728  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000005', N'Nguyễn Đức Ninh', N'Nam', CAST(N'1996-07-19' AS Date), N'Lương Tài-Bắc Ninh', N'01623453453  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000006', N'Phan Kim Liên', N'Nữ', CAST(N'1994-04-19' AS Date), N'Lập Thạch-Vĩnh Phúc', N'01628765212  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000007', N'Ngô Thùy Dung', N'Nữ', CAST(N'1993-01-28' AS Date), N'Nghị Lộc-Thanh Hóa', N'01659876253  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000008', N'Nguyễn Thị Lan Anh', N'Nữ', CAST(N'1996-04-19' AS Date), N'Khoái Châu-Hưng Yên', N'01623657382  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000009', N'Nguyễn Đức Thiện', N'Nam', CAST(N'1990-03-20' AS Date), N'SaPa-Lào Cai', N'01637165234  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000010', N'Nguyễn Đức Mạnh', N'Nam', CAST(N'1996-01-29' AS Date), N'Nghi Xuân-Thanh Hóa', N'01672132131  ', N'Mượn/Đọc')
INSERT [dbo].[ThuThu] ([maTT], [tenTT], [gioiTinh], [ngaySinh], [diaChi], [SDT], [capBac]) VALUES (N'0000000001', N'Nguyễn Minh Triết', N'Nam', CAST(N'1982-12-12' AS Date), NULL, N'012156123213 ', NULL)
INSERT [dbo].[ThuThu] ([maTT], [tenTT], [gioiTinh], [ngaySinh], [diaChi], [SDT], [capBac]) VALUES (N'0000000002', N'Nguyễn Thị Na', N'Nữ', CAST(N'1971-08-18' AS Date), NULL, N'01624531234  ', NULL)
INSERT [dbo].[ThuThu] ([maTT], [tenTT], [gioiTinh], [ngaySinh], [diaChi], [SDT], [capBac]) VALUES (N'0000000003', N'Ngô Thị Lan', N'Nữ', CAST(N'1985-04-19' AS Date), NULL, N'01234567891  ', NULL)
INSERT [dbo].[ThuThu] ([maTT], [tenTT], [gioiTinh], [ngaySinh], [diaChi], [SDT], [capBac]) VALUES (N'0000000004', N'Nguyễn Thành Long', N'Nam', CAST(N'1985-03-28' AS Date), NULL, N'01237651234  ', NULL)
INSERT [dbo].[ThuThu] ([maTT], [tenTT], [gioiTinh], [ngaySinh], [diaChi], [SDT], [capBac]) VALUES (N'0000000005', N'Nguyễn Hà My', N'Nữ', CAST(N'1980-11-10' AS Date), NULL, N'01652123131  ', NULL)
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap],[ngayHTra],[ngayTra], [maDG], [maTT]) VALUES (N'0000000001', CAST(N'2016-10-01' AS Date),CAST(N'2016-10-03' AS Date),null, N'0000000001', N'0000000005')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap],[ngayHTra],[ngayTra], [maDG], [maTT]) VALUES (N'0000000002', CAST(N'2016-10-01' AS Date),CAST(N'2016-10-03' AS Date),null, N'0000000001', N'0000000001')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap],[ngayHTra],[ngayTra], [maDG], [maTT]) VALUES (N'0000000003', CAST(N'2016-10-01' AS Date),CAST(N'2016-10-03' AS Date),null, N'0000000002', N'0000000001')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap],[ngayHTra],[ngayTra], [maDG], [maTT]) VALUES (N'0000000004', CAST(N'2016-10-01' AS Date),CAST(N'2016-10-03' AS Date),null, N'0000000002', N'0000000001')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap],[ngayHTra],[ngayTra], [maDG], [maTT]) VALUES (N'0000000005', CAST(N'2016-10-01' AS Date),CAST(N'2016-10-03' AS Date),null, N'0000000003', N'0000000002')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap],[ngayHTra],[ngayTra], [maDG], [maTT]) VALUES (N'0000000006', CAST(N'2016-10-02' AS Date),CAST(N'2016-10-03' AS Date),null, N'0000000005', N'0000000003')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap],[ngayHTra],[ngayTra], [maDG], [maTT]) VALUES (N'0000000007', CAST(N'2016-10-02' AS Date),CAST(N'2016-10-03' AS Date),null, N'0000000002', N'0000000001')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap],[ngayHTra],[ngayTra], [maDG], [maTT]) VALUES (N'0000000008', CAST(N'2016-10-02' AS Date),CAST(N'2016-10-03' AS Date),null, N'0000000006', N'0000000004')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap],[ngayHTra],[ngayTra], [maDG], [maTT]) VALUES (N'0000000009', CAST(N'2016-10-01' AS Date),CAST(N'2016-10-03' AS Date),null, N'0000000002', N'0000000002')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap],[ngayHTra],[ngayTra], [maDG], [maTT]) VALUES (N'0000000010', CAST(N'2016-10-02' AS Date),CAST(N'2016-10-03' AS Date),null, N'0000000003', N'0000000004')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap],[ngayHTra],[ngayTra], [maDG], [maTT]) VALUES (N'0000000011', CAST(N'2016-10-20' AS Date),CAST(N'2016-10-03' AS Date),null, N'0000000010', N'0000000002')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap],[ngayHTra],[ngayTra], [maDG], [maTT]) VALUES (N'0000000012', CAST(N'2016-10-10' AS Date),CAST(N'2016-10-03' AS Date),null, N'0000000008', N'0000000001')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap],[ngayHTra],[ngayTra], [maDG], [maTT]) VALUES (N'0000000013', CAST(N'2016-10-15' AS Date),CAST(N'2016-10-03' AS Date),null, N'0000000005', N'0000000003')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap],[ngayHTra],[ngayTra], [maDG], [maTT]) VALUES (N'0000000014', CAST(N'2016-10-22' AS Date),CAST(N'2016-10-03' AS Date),null, N'0000000004', N'0000000001')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap],[ngayHTra],[ngayTra], [maDG], [maTT]) VALUES (N'0000000015', CAST(N'2016-11-02' AS Date),CAST(N'2016-10-03' AS Date),null, N'0000000003', N'0000000002')
INSERT [dbo].[NCC] ([maNCC], [tenNCC], [diaChi], [SDT], [email]) VALUES (N'0000000001', N'Hồng Hà', NULL, N'0419972837   ', NULL)
INSERT [dbo].[NCC] ([maNCC], [tenNCC], [diaChi], [SDT], [email]) VALUES (N'0000000002', N'Thanh Long', NULL, N'02418765433  ', NULL)
INSERT [dbo].[NCC] ([maNCC], [tenNCC], [diaChi], [SDT], [email]) VALUES (N'0000000003', N'Bạch Hổ', NULL, N'0435682121   ', NULL)
INSERT [dbo].[NCC] ([maNCC], [tenNCC], [diaChi], [SDT], [email]) VALUES (N'0000000004', N'Chu Tước', NULL, N'0497453234   ', NULL)
INSERT [dbo].[NCC] ([maNCC], [tenNCC], [diaChi], [SDT], [email]) VALUES (N'0000000005', N'Huyền Vũ', NULL, N'0412312392   ', NULL)
INSERT [dbo].[NCC] ([maNCC], [tenNCC], [diaChi], [SDT], [email]) VALUES (N'0000000006', N'Thiên Long', NULL, N'02418721532  ', NULL)
INSERT [dbo].[NCC] ([maNCC], [tenNCC], [diaChi], [SDT], [email]) VALUES (N'0000000007', N'Nam Hồng', NULL, N'04218549632  ', NULL)
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000001', CAST(N'2016-04-12' AS Date), N'0000000001', N'0000000001')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000002', CAST(N'2016-07-02' AS Date), N'0000000002', N'0000000002')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000003', CAST(N'2016-10-20' AS Date), N'0000000003', N'0000000003')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000004', CAST(N'2016-03-15' AS Date), N'0000000004', N'0000000004')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000005', CAST(N'2016-12-11' AS Date), N'0000000005', N'0000000005')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000006', CAST(N'2016-03-05' AS Date), N'0000000005', N'0000000006')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000007', CAST(N'2016-08-25' AS Date), N'0000000004', N'0000000005')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000008', CAST(N'2016-09-02' AS Date), N'0000000003', N'0000000004')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000009', CAST(N'2016-10-27' AS Date), N'0000000002', N'0000000003')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000010', CAST(N'2016-01-29' AS Date), N'0000000001', N'0000000002')
INSERT [dbo].[PhieuPhat] ([soPP], [ngayLap], [loiVP], [tienPhat], [tenSach], [soPMT]) VALUES (N'0000000001', CAST(N'2016-11-02' AS Date), N'Trả Muộn', 20000.0000, N'Yêu Em Từ Cái Nhìn Đầu Tiên', N'0000000001')
INSERT [dbo].[PhieuPhat] ([soPP], [ngayLap], [loiVP], [tienPhat], [tenSach], [soPMT]) VALUES (N'0000000002', CAST(N'2016-11-02' AS Date), N'Làm Mất', 50000.0000, N'Vẫn Cứ Thích Em', N'0000000001')
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000001', N'NXB Chính trị', NULL, N'0111222111   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000002', N'NXB Kim Đồng', NULL, N'0111222222   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000003', N'NXB Giáo dục', NULL, N'0111222333   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000004', N'NXB Tri thức', NULL, N'0111222444   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000005', N'NXB Trẻ', NULL, N'0111222555   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000006', N'NXB Khoa học kĩ thuật', NULL, N'0111222666   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000007', N'NXB Đại học sư phạm', NULL, N'0111222777   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000008', N'NXB Học viện kĩ thuật quân sự', NULL, N'0111222888   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000009', N'NXB Đại học bách khoa', NULL, N'0111222999   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000010', N'NXB Đại học nông nghiệp', NULL, N'0111333000   ', NULL)
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000001', N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh', 1969, 69000.0000, N'01-01-01', NULL, N'Tiếng Việt', N'0000000001')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000002', N'Vẫn Cứ Thích Em', 1976, 50000.0000, N'01-01-02', NULL, N'Tiếng Việt', N'0000000002')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000003', N'Yêu Em Từ Cái Nhìn Đầu Tiên', 1945, 60000.0000, N'01-01-03', NULL, N'Tiếng Việt', N'0000000003')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000004', N'Tắt Đèn', 1974, 39000.0000, N'01-01-04', NULL, N'Tiếng Việt', N'0000000004')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000005', N'Cô Gái Năm Âý Chúng Ta Cùng Theo Đuổi', 1979, 45000.0000, N'01-01-05', NULL, N'Tiếng Việt', N'0000000005')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000006', N'Chàng Trai Năm Âý', 2006, 70000.0000, N'01-01-06', NULL, N'Tiếng Việt', N'0000000006')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000007', N'Ngày Trôi Về Phía Cũ', 1978, 96000.0000, N'01-01-07', NULL, N'Tiếng Việt', N'0000000007')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000008', N'Chiêc Lá Cuối Cùng', 1993, 60000.0000, N'01-01-08', NULL, N'Tiếng Việt', N'0000000008')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000009', N'Chí Phèo', 1948, 45000.0000, N'01-01-09', NULL, N'Tiếng Việt', N'0000000009')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000010', N'Lão Hạc', 1954, 39000.0000, N'01-01-10', NULL, N'Tiếng Việt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000001', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000002', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000003', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000004', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000005', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000006', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000007', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000008', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000009', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000010', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000011', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000012', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000013', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000014', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000015', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000016', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000017', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000018', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000019', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000020', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000021', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000022', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000023', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000024', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000025', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000026', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000027', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000028', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000029', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000030', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000031', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000032', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000033', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000034', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000035', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000036', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000037', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000038', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000039', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000040', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000041', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000042', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000043', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000044', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000045', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000046', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000047', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000048', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000049', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000050', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000051', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000052', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000053', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000054', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000055', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000056', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000057', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000058', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000059', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000060', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000061', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000062', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000063', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000064', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000065', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000066', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000067', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000068', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000069', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000070', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000071', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000072', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000073', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000074', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000075', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000076', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000077', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000078', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000079', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000080', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000081', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000082', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000083', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000084', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000085', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000086', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000087', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000088', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000089', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000090', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000091', N'Tốt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000092', N'Tốt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000093', N'Tốt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000094', N'Tốt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000095', N'Tốt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000096', N'Tốt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000097', N'Tốt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000098', N'Tốt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000099', N'Tốt', N'0000000010')
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000001', N'0000000001', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000001', N'0000000011', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000001', N'0000000021', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000001', N'0000000031', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000001', N'0000000041',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000002', N'0000000002', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000002', N'0000000012',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000002', N'0000000022', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000002', N'0000000032',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000002', N'0000000042',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000003', N'0000000003',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000003', N'0000000013',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000003', N'0000000023',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000003', N'0000000033',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000003', N'0000000043',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000004', N'0000000004',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000004', N'0000000014', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000004', N'0000000024', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000004', N'0000000034',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000004', N'0000000044', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000005', N'0000000005',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000005', N'0000000015', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000005', N'0000000025',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000005', N'0000000035', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000005', N'0000000045', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000006', N'0000000006',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000006', N'0000000016',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000006', N'0000000026', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000006', N'0000000036', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000006', N'0000000046',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000007', N'0000000007',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000007', N'0000000017',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000007', N'0000000027',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000007', N'0000000037',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000007', N'0000000047', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000008', N'0000000008',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000008', N'0000000018',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000008', N'0000000028', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000008', N'0000000038', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000008', N'0000000048', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000009', N'0000000009',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000009', N'0000000019', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000009', N'0000000029',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000009', N'0000000039',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000009', N'0000000049',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000010', N'0000000010',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000010', N'0000000020',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000010', N'0000000030', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000010', N'0000000040', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000010', N'0000000050',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000011', N'0000000001',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000011', N'0000000011', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000011', N'0000000021',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000011', N'0000000031',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000011', N'0000000041', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000012', N'0000000002',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000012', N'0000000012', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000012', N'0000000022',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000012', N'0000000032', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000012', N'0000000042',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000013', N'0000000003', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000013', N'0000000013',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000013', N'0000000023',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000013', N'0000000033', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000013', N'0000000043',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000014', N'0000000004',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000014', N'0000000014',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000014', N'0000000024',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000014', N'0000000034',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000014', N'0000000044',  50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000015', N'0000000005',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000015', N'0000000015',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000015', N'0000000025',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000015', N'0000000035',  50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS],  [tienCoc], [tienTToan]) VALUES (N'0000000015', N'0000000045',  50000.0000, NULL)
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000001', N'Giáo trình')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000002', N'Thơ')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000003', N'Truyện ngắn')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000004', N'Truyện vừa')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000005', N'Tiểu thuyết')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000006', N'Ngôn tình')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000007', N'Khoa học-Kĩ thuật')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000008', N'Chính trị')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000009', N'Truyện cười')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000010', N'Kinh doanh')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000001', N'0000000001')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000001', N'0000000002')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000001', N'0000000003')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000001', N'0000000007')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000002', N'0000000001')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000002', N'0000000002')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000003', N'0000000003')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000004', N'0000000002')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000004', N'0000000005')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000006', N'0000000005')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000006', N'0000000006')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000007', N'0000000010')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000008', N'0000000001')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000008', N'0000000007')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000009', N'0000000008')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000009', N'0000000009')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000009', N'0000000010')
INSERT [dbo].[TacGia] ([maTG], [tenTG], [gioiTinh], [ngaySinh], [queQuan]) VALUES (N'0000000001', N'Xuân Diệu', N'Nam', CAST(N'1953-12-09' AS Date), N'Cẩm Giàng-Hải Dương')
INSERT [dbo].[TacGia] ([maTG], [tenTG], [gioiTinh], [ngaySinh], [queQuan]) VALUES (N'0000000002', N'Xuân Mai', N'Nữ', CAST(N'1963-11-09' AS Date), N'Quế Võ-Bắc Ninh')
INSERT [dbo].[TacGia] ([maTG], [tenTG], [gioiTinh], [ngaySinh], [queQuan]) VALUES (N'0000000003', N'Nguyễn Đình Phúc', N'Nam', CAST(N'1945-10-19' AS Date), N'Lương Tài-Bắc Ninh')
INSERT [dbo].[TacGia] ([maTG], [tenTG], [gioiTinh], [ngaySinh], [queQuan]) VALUES (N'0000000004', N'Văn Cao', N'Nam', CAST(N'1953-12-09' AS Date), N'Thọ Xuân-Thanh Hóa')
INSERT [dbo].[TacGia] ([maTG], [tenTG], [gioiTinh], [ngaySinh], [queQuan]) VALUES (N'0000000005', N'Chế Lan Viên', N'Nam', CAST(N'1934-04-18' AS Date), N'Khoái Châu-Hưng Yên')
INSERT [dbo].[TacGia] ([maTG], [tenTG], [gioiTinh], [ngaySinh], [queQuan]) VALUES (N'0000000006', N'Võ Trọng Phụng', N'Nam', CAST(N'1935-03-03' AS Date), N'Yên Phong-Bắc Ninh')
INSERT [dbo].[TacGia] ([maTG], [tenTG], [gioiTinh], [ngaySinh], [queQuan]) VALUES (N'0000000007', N'Thành Vũ', N'Nam', CAST(N'1927-12-12' AS Date), N'Từ Sơn-Bắc Ninh')
INSERT [dbo].[TacGia] ([maTG], [tenTG], [gioiTinh], [ngaySinh], [queQuan]) VALUES (N'0000000008', N'Thành Nam', N'Nam', CAST(N'1913-12-10' AS Date), N'Vĩnh Yên-Vĩnh Phúc')
INSERT [dbo].[TacGia] ([maTG], [tenTG], [gioiTinh], [ngaySinh], [queQuan]) VALUES (N'0000000009', N'Xuân Quỳnh', N'Nữ', CAST(N'1943-12-11' AS Date), N'Lập Thạch-Vĩnh Phúc')
INSERT [dbo].[TacGia] ([maTG], [tenTG], [gioiTinh], [ngaySinh], [queQuan]) VALUES (N'0000000010', N'Quang Lân', N'Nam', CAST(N'1953-12-12' AS Date), N'Nghị Lộc -Thanh Hóa')
INSERT [dbo].[Viet] ([maTS], [maTG]) VALUES (N'0000000001', N'0000000001')
INSERT [dbo].[Viet] ([maTS], [maTG]) VALUES (N'0000000002', N'0000000002')
INSERT [dbo].[Viet] ([maTS], [maTG]) VALUES (N'0000000003', N'0000000003')
INSERT [dbo].[Viet] ([maTS], [maTG]) VALUES (N'0000000004', N'0000000004')
INSERT [dbo].[Viet] ([maTS], [maTG]) VALUES (N'0000000005', N'0000000005')
INSERT [dbo].[Viet] ([maTS], [maTG]) VALUES (N'0000000006', N'0000000006')
INSERT [dbo].[Viet] ([maTS], [maTG]) VALUES (N'0000000007', N'0000000007')
INSERT [dbo].[Viet] ([maTS], [maTG]) VALUES (N'0000000008', N'0000000008')
INSERT [dbo].[Viet] ([maTS], [maTG]) VALUES (N'0000000009', N'0000000009')
INSERT [dbo].[Viet] ([maTS], [maTG]) VALUES (N'0000000010', N'0000000010')
INSERT [dbo].[ChiTietNhap] ([soPN], [maTS], [soLuong], [donGia]) VALUES (N'0000000001', N'0000000001', 10, 12000.0000)
INSERT [dbo].[ChiTietNhap] ([soPN], [maTS], [soLuong], [donGia]) VALUES (N'0000000002', N'0000000002', 10, 13000.0000)
INSERT [dbo].[ChiTietNhap] ([soPN], [maTS], [soLuong], [donGia]) VALUES (N'0000000003', N'0000000003', 10, 14000.0000)
INSERT [dbo].[ChiTietNhap] ([soPN], [maTS], [soLuong], [donGia]) VALUES (N'0000000004', N'0000000004', 10, 15000.0000)
INSERT [dbo].[ChiTietNhap] ([soPN], [maTS], [soLuong], [donGia]) VALUES (N'0000000005', N'0000000005', 10, 16000.0000)
INSERT [dbo].[ChiTietNhap] ([soPN], [maTS], [soLuong], [donGia]) VALUES (N'0000000006', N'0000000006', 10, 17000.0000)
INSERT [dbo].[ChiTietNhap] ([soPN], [maTS], [soLuong], [donGia]) VALUES (N'0000000007', N'0000000007', 10, 18000.0000)
INSERT [dbo].[ChiTietNhap] ([soPN], [maTS], [soLuong], [donGia]) VALUES (N'0000000008', N'0000000008', 10, 19000.0000)
INSERT [dbo].[ChiTietNhap] ([soPN], [maTS], [soLuong], [donGia]) VALUES (N'0000000009', N'0000000009', 10, 20000.0000)
INSERT [dbo].[ChiTietNhap] ([soPN], [maTS], [soLuong], [donGia]) VALUES (N'0000000010', N'0000000010', 9, 21000.0000)