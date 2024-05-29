CREATE PROC BookingParty
@Customer nvarchar(100),@CreateDate date, @Adress nvarchar(100), @PhoneNumber nvarchar(100), @Email nvarchar(100), 
@GroomName nvarchar(100), @Bride nvarchar(100), @IdVenue int, @Shift nvarchar(100), @DueDate date, @NumberOfTable int, @ReserveTable int, @Deposit money,
 @ListIdFood nvarchar(max),
 @ListIdService nvarchar(max)
AS
BEGIN
IF @PhoneNumber NOT IN ( SELECT DIENTHOAI FROM KHACHHANGINFOR)
BEGIN
	Declare @CustomerId int
	IF NOT EXISTS (SELECT 1 FROM KHACHHANGINFOR WHERE DIENTHOAI = @PhoneNumber)
    BEGIN
        INSERT INTO KHACHHANGINFOR (NGAYLAP, TENKHACHHANG, DIACHI, DIENTHOAI, EMAIL)
        VALUES (@CreateDate, @Customer, @Adress, @PhoneNumber, @Email)

        SET @CustomerId = SCOPE_IDENTITY()
    END
    ELSE
    BEGIN
        SELECT @CustomerId = ID FROM KHACHHANGINFOR WHERE DIENTHOAI = @PhoneNumber
    END

    INSERT INTO TIEC (IDTHONGTINKHACHHANG, IDLOAISANH, CA, TENCHURE, TENCODAU, NGAYTOCHUC, SOLUONGBAN, BANDUTRU, TIENCOC)
    VALUES (@CustomerId, @IdVenue, @Shift, @GroomName, @Bride, @DueDate, @NumberOfTable, @ReserveTable, @Deposit)

    DECLARE @PartyId int
    SET @PartyId = SCOPE_IDENTITY()

	DECLARE @FoodTable TABLE (Id int)
    INSERT INTO @FoodTable (Id)
    SELECT value FROM STRING_SPLIT(@ListIdFood, ',')

    INSERT INTO FOODINUSE (IDTIEC, IDTHUCDON)
    SELECT @PartyId, Id FROM @FoodTable

    DECLARE @ServiceTable TABLE (Id int)
    INSERT INTO @ServiceTable (Id)
    SELECT value FROM STRING_SPLIT(@ListIdService, ',')

    INSERT INTO DICHVUINUSE (IDTIEC, IDDICHVU)
    SELECT @PartyId, Id FROM @ServiceTable
   END
END



SELECT DIENTHOAI FROM KHACHHANGINFOR


--detele sanh
GO
CREATE OR ALTER PROCEDURE CheckAndUpdateSanhStatus
    @IDSanh INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NgayToChuc DATE;
    DECLARE @Ca NVARCHAR(10);
    SELECT @NgayToChuc = NGAYTOCHUC
    FROM TIEC
    WHERE IDLOAISANH = @IDSanh;

    IF @NgayToChuc >= CONVERT(DATE, GETDATE())
    BEGIN
		RAISERROR (N'cant delete the venue',
           10, -- Severity,
           1, -- State,
           N'abcde');
        RETURN;
    END
    ELSE
    BEGIN
        IF EXISTS (SELECT 1 FROM TIEC WHERE IDLOAISANH = @IDSanh)
        BEGIN
            UPDATE SANHINFOR
            SET TRANGTHAISANH = 0
            WHERE ID = @IDSanh;
        END
        ELSE
        BEGIN
            DELETE FROM SANHINFOR
            WHERE ID = @IDSanh;
        END
    END
END


GO


CREATE OR ALTER PROCEDURE CheckAndUpdateFoodStatus
    @IDfood INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NgayToChuc DATE;
    
    IF EXISTS (SELECT 1 FROM FOODINUSE WHERE IDTHUCDON = @IDfood)
    BEGIN
        SELECT @NgayToChuc = NGAYTOCHUC
        FROM TIEC
        WHERE ID = (SELECT IDtiec FROM FOODINUSE WHERE IDTHUCDON = @IDfood);

        IF @NgayToChuc >= CONVERT(DATE, GETDATE())
        BEGIN
            RAISERROR (N'Cannot delete food, the party has not started yet',
               10, -- Severity,
               1 -- State
               );
            RETURN;
        END
        ELSE
        BEGIN
            UPDATE FOOD
            SET TRANGTHAIMONAN = 0
            WHERE ID = @IDfood;
        END
    END
    ELSE
    BEGIN
        DELETE FROM FOOD WHERE ID = @IDfood;
    END
END

GO

CREATE OR ALTER PROCEDURE CheckAndUpdateServiceStatus
    @IDDICHVU INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NgayToChuc DATE;
    
    IF EXISTS (SELECT 1 FROM DICHVUINUSE WHERE IDDICHVU = @IDDICHVU)
    BEGIN
        SELECT @NgayToChuc = NGAYTOCHUC
        FROM TIEC
        WHERE ID = (SELECT IDTIEC FROM DICHVUINUSE WHERE IDDICHVU = @IDDICHVU);

        IF @NgayToChuc >= CONVERT(DATE, GETDATE())
        BEGIN
            RAISERROR (N'Cannot delete food, the party has not started yet',
               10, -- Severity,
               1 -- State
               );
            RETURN;
        END
        ELSE
        BEGIN
            UPDATE DICHVU
            SET TRANGTHAIDICHVU = 0
            WHERE ID = @IDDICHVU;
        END
    END
    ELSE
    BEGIN
        DELETE FROM DICHVU WHERE ID = @IDDICHVU;
    END
END





-- báo cáo
GO
CREATE OR ALTER PROC ProdPeferiod
@NAM INT,
@THANG INT,
@TOTAL MONEY OUT,
@TOTALVENUE INT OUT,
@TOTALPARTY INT OUT,
@TOTALSERVICEUSED INT OUT,
@TOTALFOODUSED INT OUT,
@TOTALTABLEUSED INT OUT
AS 
BEGIN

BEGIN
	IF @NAM IS NULL  
		BEGIN
	SET @NAM = YEAR(GETDATE())
		END
END
	IF @THANG IS NULL
BEGIN
    SET @THANG = MONTH(GETDATE())
END
	 SELECT @TOTAL = SUM(TONGTIEN) FROM HOADON WHERE @THANG = MONTH(NGAYXUATHOADON) AND @NAM = YEAR(NGAYXUATHOADON);

	SELECT @TOTALVENUE = COUNT(DISTINCT T.IDLOAISANH)
FROM HOADON H
INNER JOIN TIEC T ON T.ID = H.IDTIEC
WHERE MONTH(H.NGAYXUATHOADON) = @THANG  AND @NAM = YEAR(NGAYXUATHOADON);

	SELECT @TOTALPARTY = COUNT(*) FROM HOADON WHERE @THANG = MONTH(NGAYXUATHOADON)  AND @NAM = YEAR(NGAYXUATHOADON);

	SELECT @TOTALSERVICEUSED = COUNT(*)
FROM HOADON H
INNER JOIN TIEC T ON H.IDTIEC = T.ID
INNER JOIN DICHVUINUSE DV ON T.ID = DV.IDTIEC
WHERE MONTH(H.NGAYXUATHOADON) = @THANG  AND @NAM = YEAR(NGAYXUATHOADON);

	SELECT @TOTALFOODUSED = COUNT(*)
FROM HOADON H
INNER JOIN TIEC T ON H.IDTIEC = T.ID
INNER JOIN FOODINUSE DV ON T.ID = DV.IDTIEC
WHERE MONTH(H.NGAYXUATHOADON) = @THANG  AND @NAM = YEAR(NGAYXUATHOADON);

	SELECT  @TOTALTABLEUSED = SUM(T.SOLUONGBAN + T.BANDUTRU)
FROM HOADON H
INNER JOIN TIEC T ON H.IDTIEC = T.ID
INNER JOIN FOODINUSE DV ON T.ID = DV.IDTIEC
WHERE MONTH(H.NGAYXUATHOADON) = @THANG  AND @NAM = YEAR(NGAYXUATHOADON);

END

GO
CREATE OR ALTER PROCEDURE GetNearest5month
    @THANG INT,
    @NAM INT,
    @DTThang5 MONEY OUT,
    @DTThang1 MONEY OUT,
    @DTThang2 MONEY OUT,
    @DTThang3 MONEY OUT,
    @DTThang4 MONEY OUT,
    @SoLuongTiec1 INT OUT,
    @SoLuongTiec2 INT OUT,
    @SoLuongTiec3 INT OUT,
    @SoLuongTiec4 INT OUT,
    @SoLuongTiec5 INT OUT,
    @Month1 INT OUT, 
    @Year1 INT OUT,
    @Month2 INT OUT, 
    @Year2 INT OUT,
    @Month3 INT OUT, 
    @Year3 INT OUT,
    @Month4 INT OUT, 
    @Year4 INT OUT,
    @Month5 INT OUT, 
    @Year5 INT OUT
AS
BEGIN
    IF @NAM IS NULL
        SET @NAM = YEAR(GETDATE());

    IF @THANG IS NULL
        SET @THANG = MONTH(GETDATE());

    -- Variables to hold month and year calculations
    DECLARE @Months TABLE (Thang INT, Nam INT);

    INSERT INTO @Months (Thang, Nam)
    SELECT TOP (5) MONTH(NGAYXUATHOADON) AS Thang, YEAR(NGAYXUATHOADON) AS Nam
    FROM [QUANLYTIECCUOI].[dbo].[HOADON]
    GROUP BY MONTH(NGAYXUATHOADON), YEAR(NGAYXUATHOADON)
    ORDER BY Nam DESC, Thang DESC;

    SELECT TOP 1 @Month1 = Thang, @Year1 = Nam FROM @Months;
    DELETE TOP(1) FROM @Months;
    SELECT TOP 1 @Month2 = Thang, @Year2 = Nam FROM @Months;
    DELETE TOP(1) FROM @Months;
    SELECT TOP 1 @Month3 = Thang, @Year3 = Nam FROM @Months;
    DELETE TOP(1) FROM @Months;
    SELECT TOP 1 @Month4 = Thang, @Year4 = Nam FROM @Months;
    DELETE TOP(1) FROM @Months;
    SELECT TOP 1 @Month5 = Thang, @Year5 = Nam FROM @Months;

    -- Calculate the sums and counts for each month
    IF @Month1 IS NOT NULL AND @Year1 IS NOT NULL
    BEGIN
        SELECT 
            @DTThang1 = ISNULL(SUM(TONGTIEN), 0),
            @SoLuongTiec1 = COUNT(IDTIEC)
        FROM HOADON
        WHERE MONTH(NGAYXUATHOADON) = @Month1 AND YEAR(NGAYXUATHOADON) = @Year1;
    END

    IF @Month2 IS NOT NULL AND @Year2 IS NOT NULL
    BEGIN
        SELECT 
            @DTThang2 = ISNULL(SUM(TONGTIEN), 0),
            @SoLuongTiec2 = COUNT(IDTIEC)
        FROM HOADON
        WHERE MONTH(NGAYXUATHOADON) = @Month2 AND YEAR(NGAYXUATHOADON) = @Year2;
    END

    IF @Month3 IS NOT NULL AND @Year3 IS NOT NULL
    BEGIN
        SELECT 
            @DTThang3 = ISNULL(SUM(TONGTIEN), 0),
            @SoLuongTiec3 = COUNT(IDTIEC)
        FROM HOADON
        WHERE MONTH(NGAYXUATHOADON) = @Month3 AND YEAR(NGAYXUATHOADON) = @Year3;
    END

    IF @Month4 IS NOT NULL AND @Year4 IS NOT NULL
    BEGIN
        SELECT 
            @DTThang4 = ISNULL(SUM(TONGTIEN), 0),
            @SoLuongTiec4 = COUNT(IDTIEC)
        FROM HOADON
        WHERE MONTH(NGAYXUATHOADON) = @Month4 AND YEAR(NGAYXUATHOADON) = @Year4;
    END

    IF @Month5 IS NOT NULL AND @Year5 IS NOT NULL
    BEGIN
        SELECT 
            @DTThang5 = ISNULL(SUM(TONGTIEN), 0),
            @SoLuongTiec5 = COUNT(IDTIEC)
        FROM HOADON
        WHERE MONTH(NGAYXUATHOADON) = @Month5 AND YEAR(NGAYXUATHOADON) = @Year5;
    END
END;








go
CREATE OR ALTER PROCEDURE CalculateDailyRevenueRatio
    @Month INT,
    @Year INT
AS
BEGIN
    -- Calculate total revenue for the month
    DECLARE @TotalRevenue DECIMAL(18, 2);
    SELECT @TotalRevenue = ISNULL(SUM(TONGTIEN), 0)
    FROM HOADON
    WHERE MONTH(NGAYXUATHOADON) = @Month AND YEAR(NGAYXUATHOADON) = @Year;

    -- Calculate daily revenue and ratio for each day of the month
    SELECT
        DAY(NGAYXUATHOADON) AS DayOfMonth,
        SUM(TONGTIEN) AS DailyRevenue,
        CASE
            WHEN @TotalRevenue = 0 THEN 0 -- To handle division by zero
            ELSE SUM(TONGTIEN) / @TotalRevenue
        END AS RevenueRatio
    FROM
        HOADON
    WHERE
        MONTH(NGAYXUATHOADON) = @Month AND YEAR(NGAYXUATHOADON) = @Year
    GROUP BY
        DAY(NGAYXUATHOADON)
    ORDER BY
        DayOfMonth;
END;

 
 ---THEM NHAN VIEN 
 GO
 CREATE OR ALTER PROC AddNhanVien
 @TENNHANVIEN nvarchar(100) ,
 @SODIENTHOAI nvarchar(100),
 @DIACHI nvarchar(100),
 @CHUCVU nvarchar(100),
 @TAIKHOAN varchar(20),
 @MATKHAU varchar(20)

AS 
BEGIN
IF @MATKHAU IS NOT NULL
BEGIN
 IF @TAIKHOAN NOT IN(SELECT USERNAME FROM USERS)
 BEGIN 

	  INSERT INTO USERS (UPASS, USERNAME) 
        VALUES (@MATKHAU, @TAIKHOAN);
		DECLARE @USERID INT;
		SET @USERID = SCOPE_IDENTITY();
		INSERT INTO NHANVIEN(TENNHANVIEN,SODIENTHOAI,DIACHI,CHUCVU,IDUSERS,TRANGTHAINHANVIEN) VALUES(@TENNHANVIEN,@SODIENTHOAI,@DIACHI,@CHUCVU,@USERID,1)
		END
ELSE 
BEGIN
 RAISERROR (N'Username already exists.', 16, 1);
 END

END
ELSE 
BEGIN
		INSERT INTO NHANVIEN(TENNHANVIEN,SODIENTHOAI,DIACHI,CHUCVU) VALUES(@TENNHANVIEN,@SODIENTHOAI,@DIACHI,@CHUCVU)
END
END 

--- XOA NHAN VIEN
GO
CREATE OR ALTER PROC deleteNV
@ID INT
AS
BEGIN
	DECLARE @USERID INT ;
	SELECT @USERID = IDUSERS FROM NHANVIEN WHERE ID = @ID;
	DECLARE @NgayToChuc DATE;
	IF EXISTS (SELECT 1 FROM NHANVIENINUSE WHERE IDNHANVIEN = @ID)
	BEGIN
  IF @NgayToChuc >= CONVERT(DATE, GETDATE())
        BEGIN
            RAISERROR (N'Cannot delete Employee, the party has not started yet',
               10, -- Severity,
               1 -- State
               );
            RETURN;
        END
	ELSE
	BEGIN
	UPDATE NHANVIEN SET TRANGTHAINHANVIEN = 0 WHERE ID = @ID
	END
	END
	ELSE
	BEGIN
	DELETE FROM NHANVIEN WHERE ID = @ID
	END
END

