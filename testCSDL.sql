

SELECT DB_NAME() AS TenDatabaseHienTai;

USE QuanLyXemPhim;
GO
EXEC USP_layDanhSachCaChieu;

--SELECT * FROM FUNC_layCaChieuTheoTenPhim(N'Tết ở làng địa ngục')
SELECT TenPhim FROM Phim WHERE TenPhim LIKE N'%Tết%';

SELECT * FROM FUNC_layCaChieuTheoTenPhim(N'Tết ở làng địa ngục') --trong code

SELECT * FROM CaChieu WHERE MaPhim IN (
	SELECT MaPhim FROM Phim WHERE TenPhim LIKE N'%Tết ở làng địa ngục%'
)
exec USP_hienDanhSachPhim
SELECT * FROM dbo.FUNC_layCaChieuTheoTenPhim(N'%Tết ở làng địa ngục%');

EXEC USP_layDanhSachCaChieu;
exec USP_hienDanhSachPhim
SELECT * FROM dbo.FUNC_layPhimTheoNgayChieu('2025-05-01'); --error

SELECT * FROM dbo.FUNC_layPhimTheoThangChieu('2025-05-01');
--- fix lỗi tạo vé cho ca chiếu mới từ A1 thành A-1 để hiển thị danh sách ghế ngồi đúng
----1.hien thi ten rang buoc FK trong dbo VE
SELECT 
    f.name AS ConstraintName,
    OBJECT_NAME(f.parent_object_id) AS TableName,
    COL_NAME(fc.parent_object_id, fc.parent_column_id) AS ColumnName,
    OBJECT_NAME(f.referenced_object_id) AS ReferencedTable
FROM sys.foreign_keys AS f
JOIN sys.foreign_key_columns AS fc 
    ON f.object_id = fc.constraint_object_id
WHERE OBJECT_NAME(f.parent_object_id) = 'Ve';
---2. xoa FK tam thoi de xoa data bi error trong Ve
ALTER TABLE Ve DROP CONSTRAINT FK__Ve__MaCaChieu__656C112C;
-- Tạo lại với ON DELETE CASCADE
ALTER TABLE Ve
ADD CONSTRAINT FK_Ve_CaChieu FOREIGN KEY (MaCaChieu)
REFERENCES CaChieu(MaCaChieu) ON DELETE CASCADE;

DELETE FROM CaChieu WHERE MaCaChieu = 'MCC0008';

ALTER TABLE Ve 
ADD CONSTRAINT FK__Ve__MaCaChieu__656C112C FOREIGN KEY (MaCaChieu) 
REFERENCES CaChieu(MaCaChieu);