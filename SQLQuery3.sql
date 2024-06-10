CREATE TABLE KH (
    MaKH VARCHAR(20) NOT NULL PRIMARY KEY,
    TenKH VARCHAR(50) NOT NULL ,
    GT VARCHAR(10),
    SDT INT NOT NULL,
    CCCD INT NOT NULL,
    DiaChi text NOT NULL,
    QuocTich VARCHAR(20) NOT NULL
);

CREATE TABLE HeThong (
    TK VARCHAR(20)  PRIMARY KEY,
    MK TEXT
);

CREATE TABLE NV (
    MaNV VARCHAR(20) NOT NULL PRIMARY KEY,
    TenNV VARCHAR(50) NOT NULL,
    GT VARCHAR(10),
    ChucDanh VARCHAR(30) NOT NULL,
    SDT INT NOT NULL,
    DiaChi TEXT NOT NULL,
    Email TEXT NOT NULL,
    TK VARCHAR(20) ,
    FOREIGN KEY (TK) REFERENCES HeThong (TK)
);

CREATE TABLE DatPhong (
    MaDat VARCHAR(20) NOT NULL PRIMARY KEY,
    Cach_dat VARCHAR(20) NOT NULL,
    Ngay_dat VARCHAR(20) NOT NULL,
    Ngay_nhan VARCHAR(20) NOT NULL,
    Ngay_tra VARCHAR(20) NOT NULL,
    MaKH VARCHAR(20) NOT NULL,
    MaNV VARCHAR(20) NOT NULL,
    FOREIGN KEY (MaKH) REFERENCES KH (MaKH),
    FOREIGN KEY (MaNV) REFERENCES NV (MaNV)
);
create table LoaiPhong (
    MaLoaiPhong varchar(20) not null primary key ,
	TenLoaiPhong varchar(50) not null,
	DonGia int not null,
	SoNguoi int not null,
	SoGiuong int not null
);
CREATE TABLE Phong (
    SoPhong INT NOT NULL PRIMARY KEY,
    TrangThai VARCHAR(50),
    MaKH VARCHAR(20),
    MaDat VARCHAR(20),
    FOREIGN KEY (MaKH) REFERENCES KH (MaKH),
    FOREIGN KEY (MaDat) REFERENCES DatPhong (MaDat)
);

CREATE TABLE DichVu (
    MaDV VARCHAR(20) NOT NULL PRIMARY KEY,
    LoaiDV VARCHAR(50),
    GiaDV INT
);

CREATE TABLE KhachHang_DichVu (
    MaKH VARCHAR(20) NOT NULL,
    MaDV VARCHAR(20) NOT NULL,
    PRIMARY KEY (MaKH, MaDV),
    FOREIGN KEY (MaKH) REFERENCES KH (MaKH),
    FOREIGN KEY (MaDV) REFERENCES DichVu (MaDV)
);

CREATE TABLE HoaDon (
    MaHD VARCHAR(20) NOT NULL PRIMARY KEY,
    PTTT VARCHAR(20),
    NgayTT VARCHAR(20),
    MaKH VARCHAR(20),
    MaDV VARCHAR(20),
	MaNV VARCHAR(20),
    FOREIGN KEY (MaKH) REFERENCES KH (MaKH),
    FOREIGN KEY (MaDV) REFERENCES DichVu (MaDV),
	FOREIGN KEY (MaNV) REFERENCES Nv (MaNV)
);
create table HoaDon_DichVu(
    MaHD VARCHAR(20) NOT NULL,
    MaDV VARCHAR(20) NOT NULL,
    -- Add additional columns if necessary

    PRIMARY KEY (MaHD, MaDV),
    FOREIGN KEY (MaHD) REFERENCES HoaDon (MaHD),
    FOREIGN KEY (MaDV) REFERENCES DichVu (MaDV)
);
CREATE TABLE DanhGia (
    MaDG VARCHAR(20) PRIMARY KEY,
    MucDG INT,
    MaHD VARCHAR(20),
    FOREIGN KEY (MaHD) REFERENCES HoaDon (MaHD)
);
INSERT INTO KH (MaKH, TenKH, GT, SDT, CCCD, DiaChi, QuocTich)
VALUES 
('KH001', 'Nguyễn Văn C', 'Nam', 123456780, 981654321, '356 Đường Hoa, Thành phố', 'Việt Nam'),
('KH002', 'Nguyễn Văn B', 'Nam', 123456770, 988654321, '156 Đường Hoa, Thành phố', 'Việt Nam'),
('KH003', 'Nguyễn Văn A', 'Nam', 123456789, 987654321, '456 Đường Hoa, Thành phố', 'Việt Nam'),
('KH004', 'Trần Thị B', 'Nữ', 987654321, 123456789, '789 Đường Lan, Thị trấn', 'Việt Nam'),
('KH005', 'Lê Văn C', 'Nam', 111222333, 444555666, '101 Đường Sen, Xóm', 'Việt Nam'),
('KH006', 'Phạm Thị D', 'Nữ', 777888999, 111223344, '222 Đường Cúc, Thị trấn', 'Việt Nam'),
('KH007', 'Hoàng Văn E', 'Nam', 555666777, 999888777, '333 Đường Hồng, Thành phố', 'Việt Nam'),
('KH008', 'Mai Thị F', 'Nữ', 333222111, 666555444, '444 Đường Đỏ, Xóm', 'Việt Nam'),
('KH009', 'Đỗ Văn G', 'Nam', 111333555, 777999000, '555 Đường Trắng, Thị trấn', 'Việt Nam'),
('KH010', 'Vũ Thị H', 'Nữ', 444666888, 222444666, '666 Đường Xanh, Xóm', 'Việt Nam'),
('KH011', 'Trần Văn I', 'Nam', 999888777, 555666777, '777 Đường Lam, Thành phố', 'Việt Nam'),
('KH012', 'Nguyễn Thị K', 'Nữ', 777999000, 111333555, '888 Đường Cam, Xóm', 'Việt Nam'),
('KH013', 'Lê Văn L', 'Nam', 222444666, 444666888, '999 Đường Vàng, Thành phố', 'Việt Nam'),
('KH014', 'Phạm Thị M', 'Nữ', 666555444, 333222111, '123 Đường Đen, Thị trấn', 'Việt Nam'),
('KH015', 'Hoàng Văn N', 'Nam', 222333444, 888999000, '456 Đường Tím, Xóm', 'Việt Nam'),
('KH016', 'Mai Thị O', 'Nữ', 555444666, 111222333, '789 Đường Hồng, Xóm', 'Việt Nam'),
('KH017', 'Đỗ Văn P', 'Nam', 111222333, 777999000, '101 Đường Lục, Thị trấn', 'Việt Nam'),
('KH018', 'Vũ Thị Q', 'Nữ', 444555666, 999888777, '202 Đường Nâu, Thành phố', 'Việt Nam'),
('KH019', 'Trần Văn R', 'Nam', 777999000, 333222111, '303 Đường Lam, Xóm', 'Việt Nam'),
('KH020', 'Nguyễn Thị S', 'Nữ', 333222111, 666555444, '404 Đường Tím, Thành phố', 'Việt Nam');

INSERT INTO HeThong (TK, MK)
VALUES 
('user1', 'password1'),
('user2', 'password2'),
('user3', 'password3'),
('user4', 'password4'),
('user5', 'password5');

INSERT INTO NV (MaNV, TenNV, GT, ChucDanh, SDT, DiaChi, Email, TK)
VALUES 
('NV001', 'Nguyễn Văn B', 'Nam', 'Quản lý dịch vụ ', 123456789, '587 Đường Đỏ, Thành phố', 'nguyen.x@email.com', NULL),
('NV002', 'Nguyễn Văn C', 'Nam', 'Nhân viên phục vụ', 123456789, '127 Đường Đỏ, Thành phố', 'nguyen.x@email.com', NULL),
('NV003', 'Nguyễn Văn X', 'Nam', 'Nhân viên lễ tân', 123456789, '567 Đường Đỏ, Thành phố', 'nguyen.x@email.com', NULL),
('NV004', 'Trần Thị Y', 'Nữ', 'Quản lý phòng', 987654321, '789 Đường Lam, Xóm', 'tran.y@email.com', 'user2'),
('NV005', 'Lê Văn Z', 'Nam', 'Nhân viên dịch vụ', 111222333, '101 Đường Hồng, Thị trấn', 'le.z@email.com', NULL),
('NV006', 'Phạm Thị W', 'Nữ', 'Nhân viên phục vụ', 777888999, '202 Đường Lam, Thành phố', 'pham.w@email.com', NULL),
('NV007', 'Hoàng Văn U', 'Nam', 'Quản lý nhà hàng', 555666777, '303 Đường Đen, Xóm', 'hoang.u@email.com', 'user5'),
('NV008', 'Mai Thị V', 'Nữ', 'Nhân viên bảo vệ', 333222111, '404 Đường Xanh, Xóm', 'mai.v@email.com', NULL),
('NV009', 'Đỗ Văn K', 'Nam', 'Nhân viên lễ tân', 111333555, '505 Đường Hồng, Thị trấn', 'do.k@email.com', NULL),
('NV010', 'Vũ Thị L', 'Nữ', 'Nhân viên dịch vụ', 444666888, '606 Đường Đỏ, Xóm', 'vu.l@email.com', NULL),
('NV011', 'Trần Văn M', 'Nam', 'Quản lý phòng', 999888777, '707 Đường Hồng, Thành phố', 'tran.m@email.com', 'user4'),
('NV012', 'Nguyễn Thị N', 'Nữ', 'Nhân viên phục vụ', 777999000, '808 Đường Vàng, Xóm', 'nguyen.n@email.com', NULL),
('NV013', 'Lê Văn P', 'Nam', 'Nhân viên lễ tân', 222444666, '909 Đường Cam, Thị trấn', 'le.p@email.com', NULL),
('NV014', 'Phạm Thị Q', 'Nữ', 'Quản lý nhà hàng', 666555444, '123 Đường Đen, Thành phố', 'pham.q@email.com', 'user2'),
('NV015', 'Hoàng Văn R', 'Nam', 'Nhân viên bảo vệ', 222333444, '456 Đường Hồng, Xóm', 'hoang.r@email.com', NULL),
('NV016', 'Mai Thị S', 'Nữ', 'Nhân viên dịch vụ', 555444666, '789 Đường Cam, Thị trấn', 'mai.s@email.com', NULL),
('NV017', 'Đỗ Văn T', 'Nam', 'Quản lý phòng', 111222333, '101 Đường Lục, Xóm', 'do.t@email.com', 'user5'),
('NV018', 'Vũ Thị U', 'Nữ', 'Nhân viên phục vụ', 444555666, '202 Đường Nâu, Thành phố', 'vu.u@email.com', NULL),
('NV019', 'Trần Văn V', 'Nam', 'Nhân viên bảo vệ', 777999000, '303 Đường Lam, Xóm', 'tran.v@email.com', NULL),
('NV020', 'Nguyễn Thị X', 'Nữ', 'Quản lý nhà hàng', 333222111, '404 Đường Tím, Thị trấn', 'nguyen.x@email.com', 'user3');

INSERT INTO DatPhong (MaDat, Cach_dat, Ngay_dat, Ngay_nhan, Ngay_tra, MaKH, MaNV)
VALUES 
('DP001', 'Online', '2024-01-03', '2024-01-05', '2024-01-07', 'KH001', 'NV003'),
('DP002', 'Trực tiếp', '2024-01-04', '2024-01-06', '2024-01-08', 'KH002', 'NV009'),
('DP003', 'Online', '2024-01-10', '2024-01-12', '2024-01-15', 'KH003', 'NV013'),
('DP004', 'Trực tiếp', '2024-01-11', '2024-01-13', '2024-01-16', 'KH004', 'NV003'),
('DP005', 'Online', '2024-01-12', '2024-01-14', '2024-01-17', 'KH005', 'NV009'),
('DP006', 'Trực tiếp', '2024-01-13', '2024-01-15', '2024-01-18', 'KH006', 'NV013'),
('DP007', 'Online', '2024-01-14', '2024-01-16', '2024-01-19', 'KH007', 'NV003'),
('DP008', 'Trực tiếp', '2024-01-15', '2024-01-17', '2024-01-20', 'KH008', 'NV009'),
('DP009', 'Online', '2024-01-16', '2024-01-18', '2024-01-21', 'KH009', 'NV013'),
('DP010', 'Trực tiếp', '2024-01-17', '2024-01-19', '2024-01-22', 'KH010', 'NV003'),
('DP011', 'Online', '2024-01-18', '2024-01-20', '2024-01-23', 'KH011', 'NV009'),
('DP012', 'Trực tiếp', '2024-01-19', '2024-01-21', '2024-01-24', 'KH012', 'NV013'),
('DP013', 'Online', '2024-01-20', '2024-01-22', '2024-01-25', 'KH013', 'NV003'),
('DP014', 'Trực tiếp', '2024-01-21', '2024-01-23', '2024-01-26', 'KH014', 'NV009'),
('DP015', 'Online', '2024-01-22', '2024-01-24', '2024-01-27', 'KH015', 'NV013'),
('DP016', 'Trực tiếp', '2024-01-23', '2024-01-25', '2024-01-28', 'KH016', 'NV003'),
('DP017', 'Online', '2024-01-24', '2024-01-26', '2024-01-29', 'KH017', 'NV009'),
('DP018', 'Trực tiếp', '2024-01-25', '2024-01-27', '2024-01-30', 'KH018', 'NV013'),
('DP019', 'Online', '2024-01-26', '2024-01-28', '2024-01-31', 'KH019', 'NV003'),
('DP020', 'Trực tiếp', '2024-01-27', '2024-01-29', '2024-02-01', 'KH020', 'NV009');

INSERT INTO LoaiPhong (MaLoaiPhong, TenLoaiPhong, DonGia, SoNguoi, SoGiuong)
VALUES 
('LP001', 'Phòng Đơn', 100000, 1, 1),
('LP002', 'Phòng Đôi', 150000, 2, 1),
('LP003', 'Phòng Gia Đình', 200000, 4, 2),
('LP004', 'Suite', 250000, 2, 1),
('LP005', 'Phòng Deluxe', 180000, 2, 1),
('LP006', 'Phòng VIP', 300000, 2, 1) ;


INSERT INTO Phong (SoPhong, TrangThai, MaKH, MaDat)
VALUES 
(121, 'Trống', NULL, NULL),
(122, 'Đã Đặt', 'KH011', 'DP011'),
(123, 'Trống', NULL, NULL),
(124, 'Đã Đặt', 'KH012', 'DP012'),
(125, 'Trống', NULL, NULL),
(126, 'Trống', NULL, NULL),
(127, 'Đã Đặt', 'KH013', 'DP013'),
(128, 'Trống', NULL, NULL),
(129, 'Đã Đặt', 'KH014', 'DP014'),
(130, 'Trống', NULL, NULL),
(131, 'Đã Đặt', 'KH015', 'DP015'),
(132, 'Trống', NULL, NULL),
(133, 'Đã Đặt', 'KH016', 'DP016'),
(134, 'Trống', NULL, NULL),
(135, 'Đã Đặt', 'KH017', 'DP017'),
(136, 'Trống', NULL, NULL),
(137, 'Đã Đặt', 'KH018', 'DP018'),
(138, 'Trống', NULL, NULL),
(139, 'Đã Đặt', 'KH019', 'DP019'),
(140, 'Trống', NULL, NULL),
(141, 'Đã Đặt', 'KH020', 'DP020'),
(142, 'Trống', NULL, NULL),
(143, 'Đã Đặt', 'KH002', 'DP001'),
(144, 'Trống', NULL, NULL),
(145, 'Đã Đặt', 'KH001', 'DP002');
-- Thêm các dòng khác tương ứng với yêu cầu của bạn

INSERT INTO DichVu (MaDV, LoaiDV, GiaDV)
VALUES
    ('DV001', 'Spa', 500000),
    ('DV002', 'Gym', 300000),
    ('DV003', 'Buffet', 200000),
    ('DV004', 'Dịch vụ giặt ủi', 150000),
    ('DV005', 'Dịch vụ đưa đón sân bay', 400000),
    ('DV006', 'Tour tham quan thành phố', 250000),
    ('DV007', 'Cho thuê xe', 350000),
    ('DV008', 'Phòng họp', 600000),
    ('DV009', 'Dịch vụ đỗ xe', 100000),
    ('DV010', 'Dich vu phục vụ phòng', 180000);

INSERT INTO KhachHang_DichVu (MaKH, MaDV)
VALUES 
('KH001', 'DV001'),
('KH002', 'DV002'),
('KH003', 'DV003'),
('KH004', 'DV004'),
('KH005', 'DV005'),
('KH006', 'DV006'),
('KH007', 'DV007'),
('KH008', 'DV008'),
('KH009', 'DV009'),
('KH010', 'DV010'),
('KH011', 'DV001'),
('KH012', 'DV002'),
('KH013', 'DV003'),
('KH014', 'DV004'),
('KH015', 'DV005'),
('KH016', 'DV006'),
('KH017', 'DV007'),
('KH018', 'DV008'),
('KH019', 'DV009'),
('KH020', 'DV010');

INSERT INTO HoaDon (MaHD, PTTT, NgayTT, MaKH, MaDV, MaNV)
VALUES 
('HD001', 'Tiền Mặt', '2024-01-03', 'KH001', 'DV001', 'NV003'),
('HD002', 'Thẻ Tín Dụng', '2024-01-04', 'KH002', 'DV002', 'NV009'),
('HD003', 'Chuyển Khoản', '2024-01-05', 'KH003', 'DV003', 'NV013'),
('HD004', 'Tiền Mặt', '2024-01-06', 'KH004', 'DV004', 'NV003'),
('HD005', 'Thẻ Tín Dụng', '2024-01-07', 'KH005', 'DV005', 'NV009'),
('HD006', 'Chuyển Khoản', '2024-01-08', 'KH006', 'DV006', 'NV013'),
('HD007', 'Tiền Mặt', '2024-01-09', 'KH007', 'DV007', 'NV003'),
('HD008', 'Thẻ Tín Dụng', '2024-01-10', 'KH008', 'DV008', 'NV009'),
('HD009', 'Chuyển Khoản', '2024-01-11', 'KH009', 'DV009', 'NV013'),
('HD010', 'Tiền Mặt', '2024-01-12', 'KH010', 'DV010', 'NV003'),
-- Thêm các dòng khác tương ứng với yêu cầu của bạn
('HD011', 'Thẻ Tín Dụng', '2024-01-13', 'KH011', 'DV001', 'NV009'),
('HD012', 'Chuyển Khoản', '2024-01-14', 'KH012', 'DV002', 'NV013'),
('HD013', 'Tiền Mặt', '2024-01-15', 'KH013', 'DV003', 'NV003'),
('HD014', 'Thẻ Tín Dụng', '2024-01-16', 'KH014', 'DV004', 'NV009'),
('HD015', 'Chuyển Khoản', '2024-01-17', 'KH015', 'DV005', 'NV013'),
('HD016', 'Tiền Mặt', '2024-01-18', 'KH016', 'DV006', 'NV003'),
('HD017', 'Thẻ Tín Dụng', '2024-01-19', 'KH017', 'DV007', 'NV009'),
('HD018', 'Chuyển Khoản', '2024-01-20', 'KH018', 'DV008', 'NV003'),
('HD019', 'Tiền Mặt', '2024-01-21', 'KH019', 'DV009', 'NV009'),
('HD020', 'Thẻ Tín Dụng', '2024-01-22', 'KH020', 'DV010', 'NV013');

INSERT INTO DanhGia (MaDG, MucDG, MaHD)
VALUES 
('DG001', 4, 'HD001'),
('DG002', 5, 'HD002'),
('DG003', 3, 'HD003'),
('DG004', 4, 'HD004'),
('DG005', 5, 'HD005'),
('DG006', 3, 'HD006'),
('DG007', 4, 'HD007'),
('DG008', 5, 'HD008'),
('DG009', 3, 'HD009'),
('DG010', 4, 'HD010'),
-- Thêm các dòng khác tương ứng với yêu cầu của bạn
('DG011', 5, 'HD011'),
('DG012', 3, 'HD012'),
('DG013', 4, 'HD013'),
('DG014', 5, 'HD014'),
('DG015', 3, 'HD015'),
('DG016', 4, 'HD016'),
('DG017', 5, 'HD017'),
('DG018', 3, 'HD018'),
('DG019', 4, 'HD019'),
('DG020', 5, 'HD020');

