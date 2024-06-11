CREATE DATABASE QUANLYTIECCUOI
USE QUANLYTIECCUOI
SET DATEFORMAT dmy
-- LOGIN --
CREATE TABLE USERS
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	USERNAME VARCHAR(50) NOT NULL,
	UPASS VARCHAR(20) NOT NULL,
)

INSERT INTO USERS VALUES(N'admin',N'Khongcho1')
INSERT INTO USERS VALUES(N'nhanvien',N'Khongcho1')
SELECT * FROM USERS 
WHERE USERNAME = 'admin' and UPASS = 'Khongcho1'

-- THONG TIN SANH --
CREATE TABLE SANHINFOR
(
	ID INT IDENTITY(1,1)  PRIMARY KEY,
	TENSANH NVARCHAR(100) ,
	LOAISANH NVARCHAR(100),
	MAXTABLE INT NOT NULL,
	MINMONEY MONEY NOT NULL, -- Tiền  Bàn Tối Thiểu
	TIENSANH MONEY NOT NULL, -- UPDATE 
	TRANGTHAISANH BIT NOT NULL,
	NOTE NVARCHAR(100) DEFAULT N' ',
	PICTURE Image NULL,

)
INSERT INTO SANHINFOR 
VALUES(N'Sảnh Violet',N'A',100,1000000,100000000,0,DEFAULT,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x));
INSERT INTO SANHINFOR VALUES(N'Sảnh Lavender',N'B',200,1100000,200000000,1,DEFAULT,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 2.jpg', SINGLE_BLOB) AS x))
INSERT INTO SANHINFOR VALUES(N'Sảnh Ruby',N'C',300,1200000,300000000,0,DEFAULT,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 3.jpg', SINGLE_BLOB) AS x))
INSERT INTO SANHINFOR VALUES(N'Sảnh Pearl',N'D',400,1400000,4000000,1,DEFAULT,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 4.jpg', SINGLE_BLOB) AS x))
INSERT INTO SANHINFOR VALUES(N'Sảnh Rose',N'E',500,1600000,50000000,1,DEFAULT,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 5.jpg', SINGLE_BLOB) AS x))

SELECT * FROM SANHINFOR

UPDATE SANHINFOR
SET TRANGTHAISANH = 1











-- MENU --
CREATE TABLE FOOD
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	TENMONAN VARCHAR(100)NOT NULL,
	DONGIA MONEY NOT NULL,
	PICTURE Image NULL,
	NOTE VARCHAR(100) DEFAULT N' ',
	TRANGTHAIMONAN BIT DEFAULT 1,
)
INSERT INTO FOOD 
VALUES
( 'Gỏi gà xé phay', 50000,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), DEFAULT,DEFAULT),
('Nem chua rán', 40000,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), DEFAULT,DEFAULT),
( 'Cá lóc kho tộ', 150000,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), DEFAULT,DEFAULT),
('Thịt kho tàu', 120000,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), DEFAULT,DEFAULT),
('Đùi gà tiềm sâm bổ lượng',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 180000, DEFAULT,DEFAULT),
( 'Rau xào thập cẩm',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 50000, DEFAULT,DEFAULT),
( 'Canh măng mọc',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 50000, DEFAULT),
('Trái cây theo mùa',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 50000, DEFAULT),
( 'Súp cua', 60000,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), DEFAULT),
( 'Chả giò tôm thịt',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 60000, DEFAULT),
( 'Tôm sú nướng muối ớt',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 200000, DEFAULT),
( 'Bò lúc lắc', 180000,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), DEFAULT),
( 'Gà ta hấp nấm hương',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 150000, DEFAULT),
( 'Rau xào nấm đông cô',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 60000, DEFAULT),
( 'Canh atiso hầm giò heo',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 120000, DEFAULT),
( 'Chè hạt sen long nhãn',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 50000, DEFAULT),
( 'Yến sào chưng hạt sen',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 200000, DEFAULT),
( 'Tôm hùm đất rang muối'	,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 300000, DEFAULT),
( 'Cá chình kho tộ',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 250000, DEFAULT),
( 'Bò xào nấm tuyết',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 200000, DEFAULT),
( 'Gà Đông Tảo luộc',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 200000, DEFAULT),
( 'Rau cải bó xôi xào nấm',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 70000, DEFAULT),
( 'Canh bào ngư tiềm gà',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 250000, DEFAULT),
( 'Bánh mousse chocolate',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 70000, DEFAULT),
( 'Salad cá ngừ đại dương',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 80000, DEFAULT),
( 'Foie gras áp chảo',(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), 250000, DEFAULT),
( 'Tôm sú hấp sả', 250000,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), DEFAULT),
( 'Bò Wagyu nướng', 400000,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), DEFAULT),
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

INSERT INTO FOODINUSE VALUES(1,1)
INSERT INTO FOODINUSE VALUES(1,2)
INSERT INTO FOODINUSE VALUES(1,3)
INSERT INTO FOODINUSE VALUES(1,4)
INSERT INTO FOODINUSE VALUES(1,5)
INSERT INTO FOODINUSE VALUES(1,6)

SELECT * FROM FOOD
WHERE TENMONAN = 'Bánh kem fondant'














-- DICH VU --
CREATE TABLE DICHVU
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	LOAIDICHVU  VARCHAR(100)NOT NULL,
	TENDICHVU VARCHAR(100)NOT NULL,
	GIADICHVU MONEY,
	PICTURE image NULL,
	TRANGTHAIDICHVU BIT DEFAULT 1
)
CREATE TABLE DICHVUINUSE
(
	IDTIEC INT FOREIGN KEY REFERENCES TIEC(ID),
	IDDICHVU INT FOREIGN KEY REFERENCES DICHVU(ID),
)
-- RƯỢU, BÁNH KEM, MC, BAN NHẠC, CA SĨ, DJ
INSERT INTO DICHVU
VALUES
	('Rượu', 'Chateau Musar Jeune Red', 850000,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), DEFAULT),
	('Rượu', 'Montes Alpha Cabernet Sauvignon', 650000,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), DEFAULT),
	('Rượu', 'Yellow Tail Shiraz', 380000,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), DEFAULT),
	('Rượu', 'Domaine Marcel Deiss Blanc de Blancs Alsace Grand Cru Altenberg de Bergheim', 1400000,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), DEFAULT),
	('Rượu', 'Cloudy Bay Sauvignon Blanc', 750000,(SELECT BulkColumn FROM OPENROWSET(BULK 'C:\TuyetMinh\QuanLyTiecCuoi\Venue - Image\sảnh tiệc cưới 1.jpg', SINGLE_BLOB) AS x), DEFAULT),
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


INSERT INTO DICHVUINUSE VALUES(1,1),
(1,2),
(1,3),
(2,4),
(3,5);
SELECT * FROM DICHVUINUSE
WHERE LOAIDICHVU = 'Ca sĩ'











-- KHACHHANG --
CREATE TABLE KHACHHANGINFOR
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	NGAYLAP DATE NOT NULL,
	TENKHACHHANG NVARCHAR(100) NOT NULL,
	DIACHI NVARCHAR(100) NOT NULL,
	DIENTHOAI NVARCHAR(100) NOT NULL,
	EMAIL NVARCHAR(100) NOT NULL,
)





INSERT INTO KHACHHANGINFOR (NGAYLAP, TENKHACHHANG,DIACHI, DIENTHOAI, EMAIL)
VALUES 
    ('2023-12-03', N'Nguyễn Văn A', N'123 Phan Châu Trinh, Đà Nẵng', '0905123456', 'abc@test.com'),
    ('2023-10-22', N'Trần Thị D', N'789 Lê Duẩn, Đà Nẵng', '0912654321', 'xyz@test.com'),
    ('2024-01-12', N'Lê Thị G', N'456 Nguyễn Văn Linh, Đà Nẵng', '0935987654', 'ghi@test.com'),
    ('2024-03-05', N'Phan Văn J',N'987 Hoàng Diệu, Đà Nẵng', '0966444333', 'jkl@test.com'),
    ('2024-06-19', N'Hồ Thị M', N'321 Hải Phòng, Đà Nẵng', '0987555444', 'mno@test.com'),
    ('2024-02-25', N'Trần Văn P',  N'654 Điện Biên Phủ, Đà Nẵng', '0911234321', 'pqr@test.com')
    

SELECT * FROM KHACHHANGINFOR









-- NHAN VIEN 
CREATE TABLE NHANVIEN
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	TENNHANVIEN NVARCHAR(100) NOT NULL,
	SODIENTHOAI NVARCHAR(100) NOT NULL,
	DIACHI NVARCHAR(100) NOT NULL,
	CHUCVU NVARCHAR(100) NOT NULL,
	IDUSERS INT FOREIGN KEY REFERENCES USERS(ID) 
)

ALTER TABLE NHANVIEN ADD TRANGTHAINHANVIEN BIT DEFAULT 1
CREATE TABLE NHANVIENINUSE
(
	IDTIEC INT FOREIGN KEY REFERENCES TIEC(ID),
	IDNHANVIEN INT FOREIGN KEY REFERENCES NHANVIEN(ID),
)

INSERT INTO NHANVIEN (TENNHANVIEN, SODIENTHOAI, DIACHI, CHUCVU)
VALUES
	(N'Nguyễn Văn A1', '0987654321', N'Đà Nẵng', 'Tiếp tân'),
	(N'Nguyễn Văn A2', '0987654322', N'Đà Nẵng', 'Quản lý sảnh'),
	(N'Nguyễn Văn A3', '0987654323', N'Đà Nẵng', 'Phục vụ'),
	(N'Nguyễn Văn A4', '0987654324', N'Đà Nẵng', 'Tiếp tân'),
	(N'Nguyễn Văn A5', '0987654325', N'Đà Nẵng', 'Quản lý sảnh'),
	(N'Nguyễn Văn A6', '0987654326', N'Đà Nẵng', 'Phục vụ'),
	(N'Nguyễn Văn A7', '0987654327', N'Đà Nẵng', 'Tiếp tân'),
	(N'Nguyễn Văn A8', '0987654328', N'Đà Nẵng', 'Quản lý sảnh'),
	(N'Nguyễn Văn A9', '0987654329', N'Đà Nẵng', 'Phục vụ'),
	(N'Nguyễn Văn A10', '0987654330', N'Đà Nẵng', 'Tiếp tân');
INSERT INTO NHANVIENINUSE
VALUES
	(1,3)













-- TIEC --
CREATE TABLE TIEC
(
	ID INT IDENTITY(1,1)  PRIMARY KEY,
	IDTHONGTINKHACHHANG INT FOREIGN KEY REFERENCES KHACHHANGINFOR(ID),
	IDLOAISANH INT FOREIGN KEY REFERENCES SANHINFOR(ID),
	CA NVARCHAR(100) NOT NULL,
	TENCHURE NVARCHAR(100) NOT NULL,
	TENCODAU NVARCHAR(100) NOT NULL,
	NGAYTOCHUC DATE NOT NULL,
	SOLUONGBAN INT NOT NULL,
	BANDUTRU INT NOT NULL,
	TIENCOC MONEY
)
INSERT INTO TIEC (IDTHONGTINKHACHHANG, IDLOAISANH, CA, TENCHURE, TENCODAU, NGAYTOCHUC, SOLUONGBAN, BANDUTRU, TIENCOC)
VALUES
(1, 1, N'Sáng', N'Tên chú rể 1', N'Tên cô dâu 1', '2024-04-27', 100, 80, 500000),
(2, 2, N'Tối', N'Tên chú rể 2', N'Tên cô dâu 2', '2024-04-28', 150, 120, 750000),
(3, 3, N'Sáng', N'Tên chú rể 3', N'Tên cô dâu 3', '2024-04-29', 120, 100, 600000),
(4, 4, N'Tối', N'Tên chú rể 4', N'Tên cô dâu 4', '2024-04-30', 200, 150, 1000000),
(5, 5, N'Sáng', N'Tên chú rể 5', N'Tên cô dâu 5', '2024-05-01', 80, 60, 400000)



CREATE TABLE HOADON
(
	ID INT IDENTITY(1,1)  PRIMARY KEY,	
	IDNHANVIEN INT FOREIGN KEY REFERENCES NHANVIEN(ID),
	IDTIEC INT FOREIGN KEY REFERENCES TIEC(ID),
	TONGTIEN MONEY,
	THUCTRA MONEY,
	GIAMGIA INT DEFAULT NULL,
	NGAYXUATHOADON DATETIME, --THEM O DAY
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