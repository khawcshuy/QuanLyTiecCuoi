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


