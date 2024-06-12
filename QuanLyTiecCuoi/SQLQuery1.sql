--CREATE DATABASE QUANLYTIECCUOI
--USE QUANLYTIECCUOI
SET DATEFORMAT dmy
-- LOGIN --
CREATE TABLE USERS
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	USERNAME VARCHAR(50) NOT NULL,
	UPASS VARCHAR(20) NOT NULL,
)

INSERT INTO USERS VALUES(N'admin',N'Khongcho1')
SELECT * FROM USERS 
WHERE USERNAME = 'admin' and UPASS = 'Khongcho1'

-- THONG TIN SANH --
CREATE TABLE SANHINFOR
(
	ID INT IDENTITY(1,1)  PRIMARY KEY,
	TENSANH NVARCHAR(100) DEFAULT 'NO NAME',
	LOAISANH NVARCHAR(100),
	MAXTABLE INT NOT NULL,
	MINMONEY MONEY NOT NULL,
	TRANGTHAISANH BIT NOT NULL,
	NOTE NVARCHAR(100) DEFAULT N'EMPTY',
)
INSERT INTO SANHINFOR VALUES(DEFAULT,N'A',100,1000000,0,DEFAULT)
INSERT INTO SANHINFOR VALUES(DEFAULT,N'B',200,1100000,1,DEFAULT)
INSERT INTO SANHINFOR VALUES(DEFAULT,N'C',300,1200000,0,DEFAULT)
INSERT INTO SANHINFOR VALUES(DEFAULT,N'D',400,1400000,1,DEFAULT)
INSERT INTO SANHINFOR VALUES(DEFAULT,N'E',500,1600000,1,DEFAULT)

SELECT * FROM SANHINFOR




-- TIEC --
CREATE TABLE TIEC
(
	ID INT IDENTITY(1,1)  PRIMARY KEY,
	IDTHONGTINKHACHHANG INT FOREIGN KEY REFERENCES KHACHHANGINFOR(ID),
	IDLOAISANH INT FOREIGN KEY REFERENCES SANHINFOR(ID),
	CA NVARCHAR(100) NOT NULL,
)
SELECT * FROM TIEC
INSERT INTO TIEC
VALUES
(1,1,N'Sáng')







-- MENU --
CREATE TABLE FOOD
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	TENMONAN VARCHAR(100)NOT NULL,
	DONGIA MONEY NOT NULL,
	NOTE VARCHAR(100) DEFAULT N'EMPTY'
)
INSERT INTO FOOD 
VALUES
( 'Gỏi gà xé phay', 50000, DEFAULT),
('Nem chua rán', 40000, DEFAULT),
( 'Cá lóc kho tộ', 150000, DEFAULT),
('Thịt kho tàu', 120000, DEFAULT),
('Đùi gà tiềm sâm bổ lượng', 180000, DEFAULT),
( 'Rau xào thập cẩm', 50000, DEFAULT),
( 'Canh măng mọc', 50000, DEFAULT),
('Trái cây theo mùa', 50000, DEFAULT),
( 'Súp cua', 60000, DEFAULT),
( 'Chả giò tôm thịt', 60000, DEFAULT),
( 'Tôm sú nướng muối ớt', 200000, DEFAULT),
( 'Bò lúc lắc', 180000, DEFAULT),
( 'Gà ta hấp nấm hương', 150000, DEFAULT),
( 'Rau xào nấm đông cô', 60000, DEFAULT),
( 'Canh atiso hầm giò heo', 120000, DEFAULT),
( 'Chè hạt sen long nhãn', 50000, DEFAULT),
( 'Yến sào chưng hạt sen', 200000, DEFAULT),
( 'Tôm hùm đất rang muối', 300000, DEFAULT),
( 'Cá chình kho tộ', 250000, DEFAULT),
( 'Bò xào nấm tuyết', 200000, DEFAULT),
( 'Gà Đông Tảo luộc', 200000, DEFAULT),
( 'Rau cải bó xôi xào nấm', 70000, DEFAULT),
( 'Canh bào ngư tiềm gà', 250000, DEFAULT),
( 'Bánh mousse chocolate', 70000, DEFAULT),
( 'Salad cá ngừ đại dương', 80000, DEFAULT),
( 'Foie gras áp chảo', 250000, DEFAULT),
( 'Tôm sú hấp sả', 250000, DEFAULT),
( 'Bò Wagyu nướng', 400000, DEFAULT),
( 'Gà tiềm nhân sâm', 250000, DEFAULT),
( 'Rau asparagus xào tỏi', 80000, DEFAULT),
( 'Canh măng mọc cua bể', 200000, DEFAULT),
( 'Bánh kem hoa quả', 100000, DEFAULT),
( 'Súp bào ngư vi cá', 300000, DEFAULT),
( 'Cua huỳnh đế hấp', 500000, DEFAULT),
( 'Cá tầm nướng muối ớt', 350000, DEFAULT),
( 'Bò phi lê sốt đỏ', 450000, DEFAULT),
( 'Gà hầm sâm bổ lượng', 300000, DEFAULT),
( 'Rau mầm đá xào nấm', 90000, DEFAULT),
( 'Canh yến hầm hạt sen', 350000, DEFAULT),
( 'Bánh kem fondant', 150000, DEFAULT)

CREATE TABLE FOODINUSE
(
	IDTIEC INT FOREIGN KEY REFERENCES TIEC(ID),
	IDTHUCDON INT FOREIGN KEY REFERENCES FOOD(ID),
)

SELECT * FROM FOOD
WHERE TENMONAN = 'Bánh kem fondant'














-- DICH VU --
CREATE TABLE DICHVU
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	LOAIDICHVU  VARCHAR(100)NOT NULL,
	TENDICHVU VARCHAR(100)NOT NULL,
	GIADICHVU MONEY,
)
CREATE TABLE DICHVUINUSE
(
	IDTIEC INT FOREIGN KEY REFERENCES TIEC(ID),
	IDDICHVU INT FOREIGN KEY REFERENCES DICHVU(ID),
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
SELECT * FROM DICHVUINUSE
WHERE LOAIDICHVU = 'Ca sĩ'











-- KHACHHANG --
CREATE TABLE KHACHHANGINFOR
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
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









-- NHAN VIEN 
CREATE TABLE NHANVIEN
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	TENNHANVIEN NVARCHAR(100) NOT NULL,
	SODIENTHOAI NVARCHAR(100) NOT NULL,
	DIACHI NVARCHAR(100) NOT NULL,
	CHUCVU NVARCHAR(100) NOT NULL,
	CA NVARCHAR(100) NOT NULL,
	IDUSERS INT FOREIGN KEY REFERENCES USERS(ID) 
)
CREATE TABLE NHANVIENINUSE
(
	IDTIEC INT FOREIGN KEY REFERENCES TIEC(ID),
	IDNHANVIEN INT FOREIGN KEY REFERENCES NHANVIEN(ID),
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
INSERT INTO NHANVIENINUSE
VALUES
	(2,1)

















CREATE TABLE HOADON
(
	ID INT IDENTITY(1,1)  PRIMARY KEY,	
	IDNHANVIEN INT FOREIGN KEY REFERENCES NHANVIEN(ID),
	IDTIEC INT FOREIGN KEY REFERENCES TIEC(ID),
	TONGTIEN INT,
)





--DROP TABLE USERS
--DELETE FROM SANHINFOR
--DROP TABLE SANHINFOR
--DELETE FROM MENU
--DROP TABLE MENU
--DROP TABLE FOOD
--DROP TABLE SVCINUSE
--DROP TABLE KHACHHANGINFOR
--DROP TABLE NHANVIENINUSE

--DROP TABLE TIEC