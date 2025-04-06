-- Tạo cơ sở dữ liệu
--drop database QUANLYKHENTHUONG
CREATE DATABASE QUANLYKHENTHUONG;
GO
-- Sử dụng cơ sở dữ liệu
USE QUANLYKHENTHUONG;
GO
SET DATEFORMAT DMY
GO

-- Bảng Users: Lưu thông tin đăng nhập
CREATE TABLE Users (
    UserID CHAR(6) PRIMARY KEY,              -- Mã người dùng
    Username NVARCHAR(50) UNIQUE NOT NULL,  -- Tên đăng nhập
    Password NVARCHAR(255) NOT NULL,        -- Mật khẩu (nên mã hóa)
    Role NVARCHAR(20) NOT NULL              -- Vai trò: "Admin", "Teacher"
);
GO



-- Bảng Class: Lưu lớp học
CREATE TABLE Class(
	ClassID CHAR(6) NOT NULL,
	ClassName NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_Class PRIMARY KEY(ClassID)
);
GO

-- Bảng Students: Lưu thông tin học sinh
CREATE TABLE Students (
    StudentID CHAR(6) PRIMARY KEY,      -- Mã học sinh
    FullName NVARCHAR(100) NOT NULL,   -- Họ và tên học sinh
    ClassID CHAR(6) NOT NULL,       -- Lớp học
    Gender NVARCHAR(10) NOT NULL,      -- Giới tính
    DateOfBirth DATE NOT NULL,          -- Ngày sinh
	CONSTRAINT FK_HV_LOP FOREIGN KEY(ClassID) REFERENCES Class(ClassID)
);
GO

-- Bảng Awards: Lưu thông tin về các phần thưởng
CREATE TABLE Awards (
    AwardID CHAR(6) PRIMARY KEY,       -- Mã phần thưởng
    AwardName NVARCHAR(100) NOT NULL, -- Tên phần thưởng
    Description NVARCHAR(255)         -- Mô tả phần thưởng
);
GO

-- Bảng StudentAwards: Lưu thông tin học sinh được khen thưởng
CREATE TABLE StudentAwards (
    StudentAwardID CHAR(6) PRIMARY KEY, -- Mã khen thưởng
    StudentID CHAR(6) NOT NULL,         -- Mã học sinh (khóa ngoại)
    AwardID CHAR(6) NOT NULL,           -- Mã phần thưởng (khóa ngoại)
    AwardDate DATE NOT NULL,            -- Ngày nhận thưởng
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (AwardID) REFERENCES Awards(AwardID)
);
GO

-- Bảng Subjects: Lưu thông tin các môn học
CREATE TABLE Subjects (
    SubjectsID CHAR(6) PRIMARY KEY,         -- Mã môn học
    SubjectsName NVARCHAR(50) UNIQUE NOT NULL -- Tên môn học
);
GO

-- Bảng Results: Lưu điểm của học sinh theo môn học
CREATE TABLE Results (
    SubjectsID CHAR(6) NOT NULL,    -- Mã môn học
    StudentID CHAR(6) NOT NULL,     -- Mã học sinh
    Score FLOAT NOT NULL,           -- Điểm số
    CONSTRAINT PK_Results PRIMARY KEY (SubjectsID, StudentID), -- Khóa chính tổ hợp
    CONSTRAINT FK_Results_Students FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    CONSTRAINT FK_Results_Subjects FOREIGN KEY (SubjectsID) REFERENCES Subjects(SubjectsID)
);
GO
-- Bảng Users: Tài khoản mẫu
INSERT INTO Users (UserID, Username, Password, Role)
VALUES
('U00001', 'admin', 'admin@123', 'Admin'),  -- Mật khẩu nên được mã hóa ở thực tế
('U00002', 'teacher1', 'teacher@123', 'Teacher'),
('U00003', 'teacher2', 'teacher@123', 'Teacher');

--Bảng Class: Thông tin lớp
INSERT INTO Class(ClassID,ClassName)
VALUES
('L00001',N'10A1'),
('L00002',N'10A2'),
('L00003',N'11B1'),
('L00004',N'11B2'),
('L00005',N'12C1')

-- Bảng Students: Thông tin học sinh
INSERT INTO Students (StudentID, FullName, ClassID, Gender, DateOfBirth)
VALUES
('S00001', N'Nguyen Van A', 'L00001', N'Nam', '15/05/2008'),
('S00002', N'Tran Thi B', 'L00002', N'Nữ', '20/08/2008'),
('S00003', N'Le Van C', 'L00003', N'Nam', '05/10/2007'),
('S00004', N'Pham Thi D', 'L00004', N'Nữ', '12/03/2007'),
('S00005', N'Hoang Van E', 'L00005', N'Nam', '25/09/2005');

-- Bảng Subjects: Thông tin môn học
INSERT INTO Subjects (SubjectsID, SubjectsName)
VALUES
('SUB001', 'Toán'),
('SUB002', 'Văn'),
('SUB003', 'Anh Văn'),
('SUB004', 'Vật Lý'),
('SUB005', 'Hóa Học');

-- Bảng Results: Điểm số học sinh
INSERT INTO Results (SubjectsID, StudentID, Score)
VALUES
('SUB001', 'S00001', 8.5), -- Toán - Nguyễn Văn A
('SUB002', 'S00001', 7.8), -- Văn - Nguyễn Văn A
('SUB003', 'S00001', 9.0), -- Anh Văn - Nguyễn Văn A
('SUB001', 'S00002', 6.5), -- Toán - Trần Thị B
('SUB002', 'S00002', 8.2), -- Văn - Trần Thị B
('SUB003', 'S00002', 7.5), -- Anh Văn - Trần Thị B
('SUB001', 'S00003', 9.5), -- Toán - Lê Văn C
('SUB002', 'S00003', 8.5), -- Văn - Lê Văn C
('SUB004', 'S00003', 8.8), -- Vật Lý - Lê Văn C
('SUB001', 'S00004', 7.0), -- Toán - Phạm Thị D
('SUB005', 'S00004', 8.0), -- Hóa Học - Phạm Thị D
('SUB003', 'S00005', 6.5); -- Anh Văn - Hoàng Văn E

-- Bảng Awards: Thông tin phần thưởng
INSERT INTO Awards (AwardID, AwardName, Description)
VALUES
('A0001', 'Học sinh giỏi', 'Thành tích học tập xuất sắc'),
('A0002', 'Học sinh tiến bộ', 'Nỗ lực trong học tập'),
('A0003', 'Học sinh toàn diện', 'Thành tích nổi bật trong nhiều lĩnh vực');

-- Bảng StudentAwards: Khen thưởng học sinh
INSERT INTO StudentAwards (StudentAwardID, StudentID, AwardID, AwardDate)
VALUES
('SA0001', 'S00001', 'A0001', '01/10/2024'), -- Nguyễn Văn A nhận Học sinh giỏi
('SA0002', 'S00003', 'A0001', '05/10/2024'), -- Lê Văn C nhận Học sinh giỏi
('SA0003', 'S00002', 'A0002', '10/10/2024'); -- Trần Thị B nhận Học sinh tiến bộ
GO