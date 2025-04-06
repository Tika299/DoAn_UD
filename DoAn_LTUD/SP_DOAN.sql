CREATE PROC SP_AddUsers
	@UserID CHAR(6),
    @Username NVARCHAR(50),
    @Password NVARCHAR(255),
    @Role NVARCHAR(20)
AS
BEGIN
	INSERT INTO Users(UserID,Username,Password,Role) 
	VALUES(@UserID,@Username,@Password,@Role)
END;
--EXEC SP_AddUsers 'U00001', 'admin', 'admin123', 'Admin';
--EXEC SP_AddUsers 'U00002', 'teacher1', 'teacher123', 'Teacher';
--EXEC SP_AddUsers 'D00003', 'username', 'password', 'ADMIN';
GO
CREATE PROCEDURE SP_DeleteUsers
    @UserID CHAR(6)
AS
BEGIN
    DELETE FROM Users
    WHERE UserID = @UserID;
END;
--EXEC SP_DeleteUser 'U00003';
GO
CREATE PROCEDURE SP_UpdateUsers
    @UserID CHAR(6),
    @Username NVARCHAR(50),
    @Password NVARCHAR(255),
    @Role NVARCHAR(20)
AS
BEGIN
    UPDATE Users
    SET Username = @Username,
        Password = @Password,
        Role = @Role
    WHERE UserID = @UserID;
END;
--EXEC SP_UpdateUser 'U00001', 'admin_updated', 'newpassword123', 'Admin';
GO
CREATE PROCEDURE SP_GetAllUsers
AS
BEGIN
    SELECT UserID, Username, Role
    FROM Users;
END;
GO
--EXEC SP_GetAllUsers;
CREATE PROCEDURE SP_AuthenticateUser
    @Username NVARCHAR(50),
    @Password NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) AS UserCount
    FROM Users
    WHERE Username = @Username AND Password = @Password;
END;
--EXEC SP_AuthenticateUser 'admin_updated', 'newpassword123';
GO
CREATE PROCEDURE SP_AddClass
    @Class CHAR(6),
	@ClassName NVARCHAR(50)
AS
BEGIN
    INSERT INTO Class(ClassID, ClassName)
    VALUES (@Class, @ClassName);
END;
--EXEC SP_AddUser 'L00006', '12A1';
--EXEC SP_AddUser 'L00007', '12A2';
GO
CREATE PROCEDURE SP_DeleteClass
    @Class CHAR(6)
AS
BEGIN
    DELETE FROM Class
    WHERE ClassID = @Class;
END;
--EXEC SP_DeleteClass 'L00001';
GO
CREATE PROCEDURE SP_UpdateClass
    @Class CHAR(6),
    @ClassName NVARCHAR(50)
AS
BEGIN
    UPDATE Class
    SET ClassID = @Class,
        ClassName = @ClassName
		WHERE ClassID = @Class;
END;
--EXEC SP_UpdateUser 'L00006', '12C2';
GO
CREATE PROCEDURE SP_GetAllClass
AS
BEGIN
    SELECT *
    FROM Class;
END;
--EXEC SP_GetAllClass
GO
CREATE PROC SP_TimClassMa(@Class char(6))
AS
	SELECT *
	FROM Class
	WHERE ClassID = @Class
--test thuc thi
--EXEC SP_TimClassMa 'L00006'
GO
--drop proc SP_TimClassTen
CREATE PROC SP_TimClassTen(@Class NVARCHAR(50))
AS
	SELECT *
	FROM Class
	WHERE ClassName like N'%'+@Class+'%'
--test thuc thi
--EXEC SP_TimClassTen '12C2'
GO
CREATE PROCEDURE SP_AddStudent
    @StudentID CHAR(6),
    @FullName NVARCHAR(100),
    @Class NVARCHAR(50),
    @Gender NVARCHAR(10),
    @DateOfBirth DATE
AS
BEGIN
    INSERT INTO Students (StudentID, FullName, ClassID, Gender, DateOfBirth)
    VALUES (@StudentID, @FullName, @Class, @Gender, @DateOfBirth);
END;
--EXEC SP_AddStudent 'S00001', 'Nguyen Van A', '10A1', 'Nam', '2008-06-15';
--EXEC SP_AddStudent 'S00002', 'Tran Thi B', '10A2', 'Nu', '2008-08-20';
GO
CREATE PROCEDURE SP_DeleteStudent
    @StudentID CHAR(6)
AS
BEGIN
    DELETE FROM Students
    WHERE StudentID = @StudentID;
END;
--EXEC SP_DeleteStudent 'S00002';
GO
CREATE PROCEDURE SP_UpdateStudent
    @StudentID CHAR(6),
    @FullName NVARCHAR(100),
    @Class NVARCHAR(50),
    @Gender NVARCHAR(10),
    @DateOfBirth DATE
AS
BEGIN
    UPDATE Students
    SET FullName = @FullName,
        ClassID = @Class,
        Gender = @Gender,
        DateOfBirth = @DateOfBirth
    WHERE StudentID = @StudentID;
END;
--EXEC SP_UpdateStudent 'S00001', 'Nguyen Van An', '10A1', 'Nam', '2008-06-15';
GO
CREATE PROCEDURE SP_GetAllStudents
AS
BEGIN
    SELECT StudentID, FullName, ClassID, Gender, DateOfBirth
    FROM Students;
END;
--EXEC SP_GetAllStudents;
GO
CREATE PROCEDURE SP_AddSubject
    @SubjectsID CHAR(6),
    @SubjectsName NVARCHAR(50)
AS
BEGIN
    INSERT INTO Subjects (SubjectsID, SubjectsName)
    VALUES (@SubjectsID, @SubjectsName);
END;
--EXEC SP_AddSubject 'SUB001', 'Math';
--EXEC SP_AddSubject 'SUB002', 'Literature';
GO
CREATE PROCEDURE SP_DeleteSubject
    @SubjectsID CHAR(6)
AS
BEGIN
    DELETE FROM Subjects
    WHERE SubjectsID = @SubjectsID;
END;
--EXEC SP_DeleteSubject 'SUB002';
GO
CREATE PROCEDURE SP_UpdateSubject
    @SubjectsID CHAR(6),
    @SubjectsName NVARCHAR(50)
AS
BEGIN
    UPDATE Subjects
    SET SubjectsName = @SubjectsName
    WHERE SubjectsID = @SubjectsID;
END;
--EXEC SP_GetAllSubjects;
GO
CREATE PROCEDURE SP_GetAllSubjects
AS
BEGIN
    SELECT SubjectsID, SubjectsName
    FROM Subjects;
END;
--EXEC SP_AddResult 'SUB001', 'S00001', 9.5;
--EXEC SP_AddResult 'SUB002', 'S00001', 8.0;
GO
CREATE PROCEDURE SP_AddResult
    @SubjectsID CHAR(6),
    @StudentID CHAR(6),
    @Score FLOAT
AS
BEGIN
    INSERT INTO Results (SubjectsID, StudentID, Score)
    VALUES (@SubjectsID, @StudentID, @Score);
END;
--EXEC SP_AddResult 'SUB001', 'S00001', 9.5;
--EXEC SP_AddResult 'SUB002', 'S00001', 8.0;
GO
CREATE PROCEDURE SP_DeleteResult
    @SubjectsID CHAR(6),
    @StudentID CHAR(6)
AS
BEGIN
    DELETE FROM Results
    WHERE SubjectsID = @SubjectsID AND StudentID = @StudentID;
END;
--EXEC SP_DeleteResult 'SUB002', 'S00001';
GO
CREATE PROCEDURE SP_UpdateResult
    @SubjectsID CHAR(6),
    @StudentID CHAR(6),
    @Score FLOAT
AS
BEGIN
    UPDATE Results
    SET Score = @Score
    WHERE SubjectsID = @SubjectsID AND StudentID = @StudentID;
END;
--EXEC SP_UpdateResult 'SUB002', 'S00001', 8.5;
GO
CREATE PROCEDURE SP_GetAllResults
AS
BEGIN
    SELECT r.SubjectsID, s.SubjectsName, st.StudentID, st.FullName, r.Score
    FROM Results r
    JOIN Subjects s ON r.SubjectsID = s.SubjectsID
    JOIN Students st ON r.StudentID = st.StudentID;
END;
--EXEC SP_GetAllResults;
GO
--drop proc SP_CalculateAverageScore
CREATE PROCEDURE SP_CalculateAverageScore
    @student CHAR(6)
AS
BEGIN
    -- Tính điểm trung bình của sinh viên dựa trên mã StudentID
    SELECT 
        StudentID,
        AVG(Score) AS AverageScore
    FROM Results
    WHERE StudentID = @student
    GROUP BY StudentID;
END;
--EXEC SP_CalculateAverageScore 'S00001';
GO
CREATE PROCEDURE SP_CountSubjects
    @student CHAR(6)
AS
BEGIN
    -- Tính điểm trung bình của sinh viên dựa trên mã StudentID
    SELECT 
        StudentID,
        Count(Score) AS CountSubjects
    FROM Results
    WHERE StudentID = @student
    GROUP BY StudentID;
END;
--EXEC SP_CountSubjects 'S00005';
GO
--loc theo sv va mh
CREATE PROC SP_FILTERSVMH(@SubjectsID char(6),@StudentID char(6))
AS
	SELECT *
	FROM Results
	WHERE SubjectsID = @SubjectsID AND StudentID = @StudentID
--test thuc thi
--EXEC SP_FILTERSVMH 'SUB001','S00001'
GO
--loc theo sv
CREATE PROC SP_FILTERSV(@StudentID char(6))
AS
	SELECT *
	FROM Results
	WHERE StudentID = @StudentID
--test thuc thi
--EXEC SP_FILTERSV 'S00001'
GO
--loc theo mh
CREATE PROC SP_FILTERMH(@SubjectsID char(6))
AS
	SELECT *
	FROM Results
	WHERE SubjectsID = @SubjectsID
--test thuc thi
--EXEC SP_FILTERMH 'SUB001'
GO
CREATE PROCEDURE SP_AddAward
    @AwardID CHAR(6),
    @AwardName NVARCHAR(100),
    @Description NVARCHAR(255)
AS
BEGIN
    INSERT INTO Awards (AwardID, AwardName, Description)
    VALUES (@AwardID, @AwardName, @Description);
END;
--EXEC SP_AddAward 'A0001', 'Excellent Student', 'Awarded to students with GPA > 9.0';
--EXEC SP_AddAward 'A0002', 'Best Attendance', 'Awarded to students with 100% attendance';
GO
CREATE PROCEDURE SP_DeleteAward
    @AwardID CHAR(6)
AS
BEGIN
    DELETE FROM Awards
    WHERE AwardID = @AwardID;
END;
--EXEC SP_DeleteAward 'A0002';
GO
CREATE PROCEDURE SP_UpdateAward
    @AwardID CHAR(6),
    @AwardName NVARCHAR(100),
    @Description NVARCHAR(255)
AS
BEGIN
    UPDATE Awards
    SET AwardName = @AwardName,
        Description = @Description
    WHERE AwardID = @AwardID;
END;
--EXEC SP_UpdateAward 'A0001', 'Outstanding Student', 'Awarded to students with GPA > 9.5';
GO
CREATE PROCEDURE SP_GetAllAwards
AS
BEGIN
    SELECT AwardID, AwardName, Description
    FROM Awards;
END;
--EXEC SP_GetAllAwards;
GO
CREATE PROCEDURE SP_AddStudentAward
    @StudentAwardID CHAR(6),
    @StudentID CHAR(6),
    @AwardID CHAR(6),
    @AwardDate DATE
AS
BEGIN
    INSERT INTO StudentAwards (StudentAwardID, StudentID, AwardID, AwardDate)
    VALUES (@StudentAwardID, @StudentID, @AwardID, @AwardDate);
END;
--EXEC SP_GetAllAwards;
GO
CREATE PROCEDURE SP_DeleteStudentAward
    @StudentAwardID CHAR(6)
AS
BEGIN
    DELETE FROM StudentAwards
    WHERE StudentAwardID = @StudentAwardID;
END;
--EXEC SP_DeleteStudentAward 'SA002';
GO
CREATE PROCEDURE SP_UpdateStudentAward
    @StudentAwardID CHAR(6),
    @StudentID CHAR(6),
    @AwardID CHAR(6),
    @AwardDate DATE
AS
BEGIN
    UPDATE StudentAwards
    SET StudentID = @StudentID,
        AwardID = @AwardID,
        AwardDate = @AwardDate
    WHERE StudentAwardID = @StudentAwardID;
END;
--EXEC SP_UpdateStudentAward 'SA001', 'S00001', 'A0001', '2024-11-10';
GO
CREATE PROCEDURE SP_GetAllStudentAwards
AS
BEGIN
    SELECT sa.StudentAwardID, st.FullName, aw.AwardName, sa.AwardDate
    FROM StudentAwards sa
    JOIN Students st ON sa.StudentID = st.StudentID
    JOIN Awards aw ON sa.AwardID = aw.AwardID
    ORDER BY sa.AwardDate DESC;
END;
GO
CREATE PROC SP_TimSAMa(@studentId char(6))
AS
	SELECT *
	FROM StudentAwards
	WHERE StudentAwardID = @studentId
--test thuc thi
--EXEC SP_TimSAMa 'SA0001'
GO
-- Procedure 1: Load danh sách sinh viên được khen thưởng
CREATE PROCEDURE SP_LoadStudentAwards
AS
BEGIN
    SELECT 
        SA.StudentAwardID, 
        S.StudentID, 
        S.FullName, 
        S.ClassID, -- Lấy thông tin lớp từ bảng Student
        A.AwardName,
		A.AwardID,
        SA.AwardDate
    FROM StudentAwards SA
    JOIN Students S ON SA.StudentID = S.StudentID
    JOIN Awards A ON SA.AwardID = A.AwardID
    ORDER BY SA.AwardDate DESC;
END;
GO

-- Procedure 2: Tìm kiếm sinh viên được khen thưởng theo tiêu chí
CREATE PROCEDURE SP_FindStudentAwards
    @StudentID CHAR(6) = NULL,
    @FullName NVARCHAR(100) = NULL,
    @ClassName NVARCHAR(50) = NULL,
    @AwardID CHAR(6) = NULL -- Chuyển sang kiểu CHAR
AS
BEGIN
    SELECT 
        SA.StudentAwardID, 
        S.StudentID, 
        S.FullName, 
        S.ClassID, -- Lấy thông tin lớp học
        A.AwardName, 
        A.AwardID, -- Mã giải thưởng
        SA.AwardDate
    FROM StudentAwards SA
    JOIN Students S ON SA.StudentID = S.StudentID
    JOIN Awards A ON SA.AwardID = A.AwardID
    WHERE 
        (@StudentID IS NULL OR S.StudentID = @StudentID) AND
        (@FullName IS NULL OR S.FullName LIKE '%' + @FullName + '%') AND
        (@ClassName IS NULL OR S.ClassID LIKE '%' + @ClassName + '%') AND
        (@AwardID IS NULL OR A.AwardID = @AwardID)
    ORDER BY SA.AwardDate DESC;
END;
GO

CREATE PROCEDURE SP_GetStudentAwardDetails
AS
BEGIN
    SELECT 
        s.StudentID,                           -- Mã học sinh
        s.FullName,                             -- Họ và tên học sinh
        s.ClassID,                     -- Mã lớp học (dùng thông tin từ bảng Students)
        a.AwardName,                            -- Tên giải thưởng
        sa.AwardID,                             -- Mã giải thưởng
        sa.AwardDate,                           -- Ngày nhận giải thưởng
        sub.SubjectsName,                       -- Tên môn học
        sub.SubjectsID AS SubjectID             -- Mã môn học
    FROM 
        Students s
    INNER JOIN 
        StudentAwards sa ON s.StudentID = sa.StudentID -- Kết nối sinh viên và phần thưởng
    INNER JOIN 
        Awards a ON sa.AwardID = a.AwardID     -- Kết nối phần thưởng
    INNER JOIN 
        Results r ON s.StudentID = r.StudentID -- Kết nối sinh viên và điểm
    INNER JOIN 
        Subjects sub ON r.SubjectsID = sub.SubjectsID -- Kết nối kết quả học tập và môn học
    ORDER BY 
        s.StudentID, sa.AwardDate;             -- Sắp xếp theo Mã học sinh và Ngày nhận giải thưởng
END;
GO
