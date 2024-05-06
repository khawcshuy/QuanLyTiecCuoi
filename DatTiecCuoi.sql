CREATE DATABASE DATTIECUOI
USE DATTIECUOI

CREATE TABLE THONGTINKHACHHANG
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	TENCHURE NVARCHAR(100),
	TENCODAU NVARCHAR(100),
	DIENTHOAI CHAR(15),
	NGAYDAITIEC SMALLDATETIME,
	CA NVARCHAR(10),
	SANH CHAR(5),
	TIENDATCOC MONEY,
	SOLUONGBAN INT,
	SOBANDUTRU INT
)

CREATE TABLE MONAN
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	TENMONAN NVARCHAR(100),
	DONGIA MONEY,
	NOTE NVARCHAR(100),
)

CREATE TABLE MONANINUSE
(
	IDINUSE INT IDENTITY(1,1) PRIMARY KEY,
	MONANINUSE INT,    
    CONSTRAINT FK_Monan FOREIGN KEY (MONANINUSE) REFERENCES MONAN (ID),
)

CREATE TABLE DICHVU
(
	ID INT PRIMARY KEY,
	TENDICHVU NVARCHAR(100),
	SOLUONG INT,
	DONGIA MONEY,
)

CREATE TABLE DICHVUINUSE
(
	IDDV INT IDENTITY(1,1) PRIMARY KEY,
	DICHVUINUSE INT,    
    CONSTRAINT FK_DichVu FOREIGN KEY (DICHVUINUSE) REFERENCES DICHVU (ID),
	SLDVINUSE INT
)

INSERT INTO DICHVU VALUES(1,'Rượu Vang Trắng',0,300000),
						 (2,'Rượu Vang Đỏ',0,400000),
						 (3,'Pháo Hoa',0,100000),
						 (4,'Bánh Kem',0,1000000),
						 (5,'Hoa Cưới Cầm Tay', 0, 2000000),
						 (6,'Hoa Cưới Cài Áo', 0, 500000),
						 (7,'Hoa Cưới Cài Tóc', 0, 1000000),
						 (8,'Hoa Cưới Dạng Vòng Hoa', 0, 3000000),
						 (9,'Hoa Cưới Dạng Bó Hoa', 0, 1500000),
						 (10,'Xe Hoa',0,450000),
						 (11,'Thuê Lễ Phục',0,1500000),
						 (12,'Mua Lễ Phục',0,5000000),
						 (13,'Ca Sĩ',0,500000),
						 (14,'Vũ Công',0,350000),
						 (15,'MC',0,1000000),
						 (16,'Tháp Ly',0,400000),
						 (17,'Bong bóng',0,10000),
						 (18,'Đèn Chiếu',0,50000),
						 (19,'Lễ Tân',0,100000),
						 (20,'Chụp Ảnh',0,5000);
INSERT INTO MONAN 
VALUES
( 'Goi ga xe phay', 50000, ''),
('Nem chua ran', 40000, ''),
( 'Ca loc kho to', 150000, ''),
('Thit kho tau', 120000, ''),
('Dui ga tiem sam bo luong', 180000, ''),
( 'Rau xao thap cam', 50000, ''),
( 'Canh mang moc', 50000, ''),
('Trai cay theo mua', 50000, ''),
( 'Sup cua', 60000, ''),
( 'Cha gio tom thit', 60000, ''),
( 'Tom su nuong muoi ot', 200000, ''),
( 'Bo luc lac', 180000, ''),
( 'Ga ta hap nam huong', 150000, ''),
( 'Rau xao nam dong co', 60000, ''),
( 'Canh atiso ham gio heo', 120000, ''),
( 'Che hat sen long nhan', 50000, ''),
( 'Yen sao chung hat sen', 200000, ''),
( 'Tom hum dat rang muoi', 300000, ''),
( 'Ca chinh kho to', 250000, ''),
( 'Bo xao nam tuyet', 200000, ''),
( 'Ga Dong Tao luoc', 200000, ''),
( 'Rau cai bo xoi xao nam', 70000, ''),
( 'Canh bao ngu tiem ga', 250000, ''),
( 'Banh mousse chocolate', 70000, ''),
( 'Salad ca ngu dai duong', 80000, ''),
( 'Foie gras ap chao', 250000, ''),
( 'Tom su hap sa', 250000, ''),
( 'Bo Wagyu nuong', 400000, ''),
( 'Ga tiem nhan sam', 250000, ''),
( 'Rau asparagus xao toi', 80000, ''),
( 'Canh mang moc cua be', 200000, ''),
( 'Banh kem hoa qua', 100000, ''),
( 'Sup bao ngu vi ca', 300000, ''),
( 'Cua huynh de hap', 500000, ''),
( 'Ca tam nuong muoi ot', 350000, ''),
( 'Bo phi le sot đo', 450000, ''),
( 'Ga ham sam bo luong', 300000, ''),
( 'Rau mam đa xao nam', 90000, ''),
( 'Canh yen ham hat sen', 350000, ''),
( 'Banh kem fondant', 150000, ''),
('Ca Hoi Nuong', 250000, ''),
('Salad Caesar', 150000, ''),
('Pizza Margherita', 180000, ''),
('My y Xao Thit Ga', 200000, ''),
('Burger Bo', 180000, ''),
('Ca Chien Gion', 220000, ''),
('Xao Rau Cai', 150000, ''),
('Sushi Hai San', 300000, ''),
('Com Hop Ga Teriyaki', 160000, ''),
('Paella Hai San', 280000, ''),
('Salad Ca Chua Pho Mai', 120000, ''),
('Steak Kem Khoai Tay', 260000, ''),
('Tom Sot Bo', 220000, ''),
('Goi Cuon Rau', 100000, ''),
('Tacos Thit Bo', 180000, ''),
('Risotto Nam', 190000, ''),
('Pho Xao', 170000, ''),
('Suon Nuong BBQ', 240000, ''),
('Quesadilla Ga', 160000, ''),
('Sup Cua', 220000, ''),
('Thit Bo Nuong', 350000, ''),
('My y Xanh Xao Rau', 170000, ''),
('Tom Cocktail', 200000, ''),
('California Roll', 150000, ''),
('Banh My Ga Xao Caesar', 140000, ''),
('Sup Rau', 120000, ''),
('Đo An Pho Mai', 180000, ''),
('Muc Chien Gion', 160000, ''),
('Ca Tim Sot Pho Mai', 190000, ''),
('Tuna Tartare', 210000, ''),
('Wrap Falafel', 130000, ''),
('Bo Sot Kem', 220000, ''),
('My Pho Mai Gourmet', 150000, ''),
('Banh My Toi', 80000, ''),
('Canh Ga Xao Uop Cay', 160000, ''),
('Ravioli Rau Cai', 200000, ''),
('Dui Ga Nuong Xi Muoi', 150000, ''),
('Sup So', 180000, ''),
('BAnh My Nuong Ca Chua', 120000, ''),
('Bo Carpaccio', 230000, ''),
('Sup Miso', 90000, ''),
('Banh Cua', 250000, ''),
('Pizza Chay', 170000, ''),
('Banh Mi Gion Nhan Thit', 180000, ''),
('Tiramisu', 120000, ''),
('Salad Hoa Qua', 100000, ''),
('Banh Xop', 150000, ''),
('Sup Hanh', 160000, ''),
('Ceviche', 190000, ''),
('Thit Ga Xao Uot Chanh', 170000, ''),
('Brownie SoCoLa', 80000, ''),
('Cocktail Margarita', 180000, ''),
('Mojito', 160000, ''),
('Mai Tai', 200000, ''),
('White Russian', 220000, ''),
('Bloody Mary', 150000, ''),
('Tournedos Bo', 300000, ''),
('My Y Hai San', 280000, ''),
('Suon Cuu Nuong', 350000, ''),
('Lasagna Chay', 220000, '');
DBCC CHECKIDENT ('MONAN', RESEED, 0);
DELETE FROM MONAN
SELECT * FROM MONAN
SELECT * FROM MONANINUSE
DELETE FROM MONANINUSE
SELECT * FROM THONGTINKHACHHANG
SELECT * FROM DICHVUINUSE


SELECT * FROM THONGTINKHACHHANG
