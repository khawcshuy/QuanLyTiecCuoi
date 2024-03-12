USE RestaurantManagement
SET DATEFORMAT dmy
-- LOGIN --
CREATE TABLE USERS
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	USERID  AS RIGHT('USER' + CAST(ID AS VARCHAR(7)), 7) PERSISTED ,
	USERNAME VARCHAR(50) NOT NULL,
	UPASS VARCHAR(20) NOT NULL,
)
INSERT INTO USERS VALUES(N'admin',N'Khongcho1')
SELECT * FROM USERS 
WHERE USERNAME = 'admin' and UPASS = 'Khongcho1'
DROP TABLE USERS

-- THONG TIN SANH --
CREATE TABLE SANHINFOR
(
	ID INT IDENTITY(1,1)  PRIMARY KEY,
	MASANH AS RIGHT('MS' + CAST(ID AS VARCHAR(7)), 7) PERSISTED,
	TENSANH NVARCHAR(100) DEFAULT 'NO NAME',
	SANHTYPE NVARCHAR(100),
	MAXTABLE INT NOT NULL,
	MINMONEY MONEY NOT NULL,
	SANHSTATE BIT NOT NULL,
	NOTE NVARCHAR(100) DEFAULT N'EMPTY',
)
INSERT INTO SANHINFOR VALUES(DEFAULT,N'A',100,1000000,0,DEFAULT)
INSERT INTO SANHINFOR VALUES(DEFAULT,N'B',200,1100000,1,DEFAULT)
INSERT INTO SANHINFOR VALUES(DEFAULT,N'C',300,1200000,0,DEFAULT)
INSERT INTO SANHINFOR VALUES(DEFAULT,N'D',400,1400000,1,DEFAULT)
INSERT INTO SANHINFOR VALUES(DEFAULT,N'E',500,1600000,1,DEFAULT)
SELECT * FROM SANHINFOR
DELETE FROM SANHINFOR
DROP TABLE SANHINFOR











-- MENU --
CREATE TABLE MENU
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	MATHUCDON AS RIGHT('TD' + CAST(ID AS VARCHAR(7)), 7) PERSISTED,
	LOAITHUCDON VARCHAR(100),
	TENMONAN VARCHAR(100)NOT NULL,
	DONGIA MONEY NOT NULL,
	NOTE VARCHAR(100) DEFAULT N'EMPTY'
)
INSERT INTO MENU 
VALUES

-- Thực đơn Bình dân
('Bình dân', 'Gỏi gà xé phay', 50000, DEFAULT),
('Bình dân', 'Nem chua rán', 40000, DEFAULT),
('Bình dân', 'Cá lóc kho tộ', 150000, DEFAULT),
('Bình dân', 'Thịt kho tàu', 120000, DEFAULT),
('Bình dân', 'Đùi gà tiềm sâm bổ lượng', 180000, DEFAULT),
('Bình dân', 'Rau xào thập cẩm', 50000, DEFAULT),
('Bình dân', 'Canh măng mọc', 50000, DEFAULT),
('Bình dân', 'Trái cây theo mùa', 50000, DEFAULT),

-- Thực đơn Trung bình
('Trung bình', 'Súp cua', 60000, DEFAULT),
('Trung bình', 'Chả giò tôm thịt', 60000, DEFAULT),
('Trung bình', 'Tôm sú nướng muối ớt', 200000, DEFAULT),
('Trung bình', 'Bò lúc lắc', 180000, DEFAULT),
('Trung bình', 'Gà ta hấp nấm hương', 150000, DEFAULT),
('Trung bình', 'Rau xào nấm đông cô', 60000, DEFAULT),
('Trung bình', 'Canh atiso hầm giò heo', 120000, DEFAULT),
('Trung bình', 'Chè hạt sen long nhãn', 50000, DEFAULT),

-- Thực đơn Cao cấp
('Cao cấp', 'Yến sào chưng hạt sen', 200000, DEFAULT),
('Cao cấp', 'Tôm hùm đất rang muối', 300000, DEFAULT),
('Cao cấp', 'Cá chình kho tộ', 250000, DEFAULT),
('Cao cấp', 'Bò xào nấm tuyết', 200000, DEFAULT),
('Cao cấp', 'Gà Đông Tảo luộc', 200000, DEFAULT),
('Cao cấp', 'Rau cải bó xôi xào nấm', 70000, DEFAULT),
('Cao cấp', 'Canh bào ngư tiềm gà', 250000, DEFAULT),
('Cao cấp', 'Bánh mousse chocolate', 70000, DEFAULT),

-- Thực đơn Sang trọng
('Sang trọng', 'Salad cá ngừ đại dương', 80000, DEFAULT),
('Sang trọng', 'Foie gras áp chảo', 250000, DEFAULT),
('Sang trọng', 'Tôm sú hấp sả', 250000, DEFAULT),
('Sang trọng', 'Bò Wagyu nướng', 400000, DEFAULT),
('Sang trọng', 'Gà tiềm nhân sâm', 250000, DEFAULT),
('Sang trọng', 'Rau asparagus xào tỏi', 80000, DEFAULT),
('Sang trọng', 'Canh măng mọc cua bể', 200000, DEFAULT),
('Sang trọng', 'Bánh kem hoa quả', 100000, DEFAULT),

-- Thực đơn Đẳng cấp
('Đẳng cấp', 'Súp bào ngư vi cá', 300000, DEFAULT),
('Đẳng cấp', 'Cua huỳnh đế hấp', 500000, DEFAULT),
('Đẳng cấp', 'Cá tầm nướng muối ớt', 350000, DEFAULT),
('Đẳng cấp', 'Bò phi lê sốt đỏ', 450000, DEFAULT),
('Đẳng cấp', 'Gà hầm sâm bổ lượng', 300000, DEFAULT),
('Đẳng cấp', 'Rau mầm đá xào nấm', 90000, DEFAULT),
('Đẳng cấp', 'Canh yến hầm hạt sen', 350000, DEFAULT),
('Đẳng cấp', 'Bánh kem fondant', 150000, DEFAULT)


SELECT * FROM MENU
WHERE LOAITHUCDON = 'Đẳng cấp'
DELETE FROM MENU
DROP TABLE MENU















-- DICH VU --
CREATE TABLE DICHVU
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	MADICHVU AS RIGHT('DV' + CAST(ID AS VARCHAR(7)), 7) PERSISTED,
	LOAIDICHVU  VARCHAR(100)NOT NULL,
	DICHVUNAME VARCHAR(100)NOT NULL,
	GIADICHVU MONEY,
)
-- RƯỢU, BÁNH KEM, MC, BAN NHẠC, CA SĨ, DJ
INSERT INTO DICHVU
VALUES
	('Rượu', 'Chateau Musar Jeune Red', 850000),
	('Rượu', 'Montes Alpha Cabernet Sauvignon', 650000),
	('Rượu', 'Yellow Tail Shiraz', 380000),
	('Rượu', 'Domaine Marcel Deiss Blanc de Blancs Alsace Grand Cru Altenberg de Bergheim', 1400000),
	('Rượu', 'Cloudy Bay Sauvignon Blanc', 750000),
	('Bánh kem', 'Bánh kem fondant', 1500000),
	('Bánh kem', 'Bánh kem buttercream', 1000000),
	('Bánh kem', 'Bánh kem macaron', 1800000),
	('Bánh kem', 'Bánh kem naked cake', 1200000),
	('Bánh kem', 'Bánh kem red velvet', 1300000),
	('MC', 'MC Trấn Thành', 20000000),
	('MC', 'MC Đại Nghĩa', 15000000),
	('MC', 'MC Quyền Linh', 10000000),
	('MC', 'MC Ngô Kiến Huy', 8000000),
	('MC', 'MC Sam', 5000000),
	('Band nhạc', 'The Light', 20000000),
	('Band nhạc', 'The Rooftop', 15000000),
	('Band nhạc', 'Bức Tường', 30000000),
	('Band nhạc', 'Ngũ Cung', 18000000),
	('Band nhạc', 'Oplus', 12000000),
	('Ca sĩ', 'Hà Anh Tuấn', 30000000),
	('Ca sĩ', 'Thu Phương', 25000000),
	('Ca sĩ', 'Mỹ Tâm', 35000000),
	('Ca sĩ', 'Noo Phước Thịnh', 20000000),
	('Ca sĩ', 'Sơn Tùng M-TP', 30000000),
	('Trang trí', 'Trang trí theo chủ đề', 2000000),
	('Trang trí', 'Trang trí theo màu sắc', 1500000),
	('Trang trí', 'Trang trí bằng hoa tươi', 3000000),
	('Trang trí', 'Trang trí bằng ánh sáng', 2500000),
	('Trang trí', 'Trang trí theo phong cách DIY', 1000000),
	('Chụp ảnh, quay phim', 'Chụp ảnh cưới truyền thống', 3000000),
	('Chụp ảnh, quay phim', 'Chụp ảnh cưới phóng sự', 4000000),
	('Chụp ảnh, quay phim', 'Quay phim cưới truyền thống', 5000000),
	('Chụp ảnh, quay phim', 'Quay phim cưới highlight', 6000000),
	('Chụp ảnh, quay phim', 'Quay phim cưới flycam', 7000000),
	('Hoa cưới', 'Hoa cưới cầm tay', 2000000),
	('Hoa cưới', 'Hoa cưới cài áo', 500000),
	('Hoa cưới', 'Hoa cưới cài tóc', 1000000),
	('Hoa cưới', 'Hoa cưới dạng vòng hoa', 3000000),
	('Hoa cưới', 'Hoa cưới dạng bó hoa', 1500000),
	('Xe hoa', 'Xe hoa sang trọng', 5000000),
	('Xe hoa', 'Xe hoa cổ điển', 4000000),
	('Xe hoa', 'Xe hoa thể thao', 3000000),
	('Xe hoa', 'Xe hoa limousine', 6000000),
	('Xe hoa', 'Xe hoa do bạn bè, người thân lái', 2000000),
	('Lễ phục', 'Lễ phục theo phong cách hiện đại', 3000000),
	('Lễ phục', 'Lễ phục theo chủ đề', 4000000),
	('Lễ phục', 'Lễ phục do chính tay cô dâu chú rể thiết kế', 2000000),
	('Lễ phục', 'Thuê lễ phục', 1500000),
	('Lễ phục', 'Mua lễ phục', 5000000)
;
SELECT * FROM DICHVU
WHERE LOAIDICHVU = 'Ca sĩ'
DROP TABLE DICHVU










-- KHACHHANG --
CREATE TABLE KHACHHANGINFOR
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	MAKHACHHANG AS RIGHT('KH' + CAST(ID AS VARCHAR(7)), 7) PERSISTED ,
	NGAYLAP DATE NOT NULL,
	TENKHACHHANG NVARCHAR(100) NOT NULL,
	TENCHURE NVARCHAR(100) NOT NULL,
	TENCODAU NVARCHAR(100) NOT NULL,
	DIACHI NVARCHAR(100) NOT NULL,
	DIENTHOAI NVARCHAR(100) NOT NULL,
	EMAIL NVARCHAR(100) NOT NULL,
	NGAYTOCHUC DATE NOT NULL,
	SOLUONGBAN INT NOT NULL,
	BANDUTRU INT NOT NULL,
	TIENCOC MONEY
)


INSERT INTO KHACHHANGINFOR (NGAYLAP, TENKHACHHANG, TENCHURE, TENCODAU, DIACHI, DIENTHOAI, EMAIL, NGAYTOCHUC, SOLUONGBAN, BANDUTRU, TIENCOC)
VALUES 
    ('2023-12-03', 'Nguyễn Văn A', 'Nguyễn Văn B', 'Trần Thị C', '123 Phan Châu Trinh, Đà Nẵng', '0905123456', 'abc@test.com', '2024-11-20', 10, 2, 5000000),
    ('2023-10-22', 'Trần Thị D', 'Trần Văn E', 'Nguyễn Thị F', '789 Lê Duẩn, Đà Nẵng', '0912654321', 'xyz@test.com', '2024-09-16', 15, 3, 7000000),
    ('2024-01-12', 'Lê Thị G', 'Lê Văn H', 'Hồ Thị I', '456 Nguyễn Văn Linh, Đà Nẵng', '0935987654', 'ghi@test.com', '2024-12-30', 8, 1, 3000000),
    ('2024-03-05', 'Phan Văn J', 'Phan Văn K', 'Trần Thị L', '987 Hoàng Diệu, Đà Nẵng', '0966444333', 'jkl@test.com', '2024-08-28', 12, 2, 4500000),
    ('2024-06-19', 'Hồ Thị M', 'Hồ Văn N', 'Nguyễn Thị O', '321 Hải Phòng, Đà Nẵng', '0987555444', 'mno@test.com', '2024-10-02', 20, 4, 8000000),
    ('2024-02-25', 'Trần Văn P', 'Trần Văn Q', 'Lê Thị R', '654 Điện Biên Phủ, Đà Nẵng', '0911234321', 'pqr@test.com', '2025-01-15', 10, 2, 5000000),
    ('2023-11-10', 'Nguyễn Thị S', 'Nguyễn Văn T', 'Phan Thị U', '111 Ông Ích Khiêm, Đà Nẵng', '0932555666', 'stu@test.com', '2024-08-06', 15, 3, 6000000),
    ('2024-04-20', 'Lê Văn V', 'Lê Văn X', 'Hồ Thị Y', '222 Hùng Vương, Đà Nẵng', '0901678543', 'vxy@test.com', '2024-12-31', 8, 1, 2500000),
    ('2024-01-01', 'Phan Thị Z', 'Phan Văn A1', 'Trần Thị B1', '444 Đống Đa, Đà Nẵng', '0987222111', 'za1b1@test.com', '2024-10-10', 12, 2, 5500000),
    ('2023-12-31', 'Nguyễn Văn C1', 'Nguyễn Văn D1', 'Lê Thị E1', '000 Trần Phú, Đà Nẵng', '0933678456', 'cde1@test.com', '2025-02-03', 7, 1, 2000000); 

SELECT * FROM KHACHHANGINFOR
DROP TABLE KHACHHANGINFOR








-- NHAN VIEN 
CREATE TABLE NHANVIEN
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	MANHANVIEN AS RIGHT('NV' + CAST(ID AS VARCHAR(7)), 7) PERSISTED,
	TENNHANVIEN NVARCHAR(100) NOT NULL,
	SODIENTHOAI NVARCHAR(100) NOT NULL,
	DIACHI NVARCHAR(100) NOT NULL,
	CHUCVU NVARCHAR(100) NOT NULL,
	CA NVARCHAR(100) NOT NULL,
)

INSERT INTO NHANVIEN (TENNHANVIEN, SODIENTHOAI, DIACHI, CHUCVU, CA)
VALUES
	(N'Nguyễn Văn A1', '0987654321', N'Đà Nẵng', 'Tiếp tân', N'Sáng'),
	(N'Nguyễn Văn A2', '0987654322', N'Đà Nẵng', 'Quản lý sảnh', N'Sáng'),
	(N'Nguyễn Văn A3', '0987654323', N'Đà Nẵng', 'Phục vụ', N'Sáng'),
	(N'Nguyễn Văn A4', '0987654324', N'Đà Nẵng', 'Tiếp tân', N'Chiều'),
	(N'Nguyễn Văn A5', '0987654325', N'Đà Nẵng', 'Quản lý sảnh', N'Chiều'),
	(N'Nguyễn Văn A6', '0987654326', N'Đà Nẵng', 'Phục vụ', N'Chiều'),
	(N'Nguyễn Văn A7', '0987654327', N'Đà Nẵng', 'Tiếp tân', N'Tối'),
	(N'Nguyễn Văn A8', '0987654328', N'Đà Nẵng', 'Quản lý sảnh', N'Tối'),
	(N'Nguyễn Văn A9', '0987654329', N'Đà Nẵng', 'Phục vụ', N'Tối'),
	(N'Nguyễn Văn A10', '0987654330', N'Đà Nẵng', 'Tiếp tân', N'Sáng');
SELECT * FROM NHANVIEN
DROP TABLE NHANVIEN



















-- TIEC --
CREATE TABLE TIEC
(
	ID INT IDENTITY(1,1) ,
	MADATTIEC  AS RIGHT('DT' + CAST(ID AS VARCHAR(7)), 7) PERSISTED PRIMARY KEY,
	IDNHANVIEN INT FOREIGN KEY REFERENCES NHANVIEN (ID),
	IDTHONGTINKHACHHANG INT FOREIGN KEY REFERENCES KHACHHANGINFOR(ID),
	IDLOAISANH INT FOREIGN KEY REFERENCES SANHINFOR(ID),
	IDDICHVU INT FOREIGN KEY REFERENCES DICHVU(ID),
	IDTHUCDON INT FOREIGN KEY REFERENCES MENU(ID),
	SOLUONGNHANVIEN INT NOT NULL,
	SOLUONGBAN INT,
	--TRANGTHAI NVARCHAR(100) NOT NULL, 
	CA NVARCHAR(100) NOT NULL,
)
SELECT * FROM TIEC
DROP TABLE TIEC
