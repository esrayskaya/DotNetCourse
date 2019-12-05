USE master
GO

CREATE DATABASE [Users_and_awards]
ON
 (NAME=[Users_and_awards_dat],
  FILENAME='D:\база\Users_and_awards_dat.mdf',
  SIZE=10,
  MAXSIZE=50,
  FILEGROWTH=5)
LOG ON
 (NAME=[Users_and_awards_log],
  FILENAME='D:\база\Users_and_awards_log.ldf',
  SIZE=5MB,
  MAXSIZE=25MB,
  FILEGROWTH=5MB);
GO

USE [Users_and_awards]
GO

CREATE TABLE [Users]
 (ID_user INT IDENTITY(1,1),
  Firstname NVARCHAR(50) NOT NULL,
  Lastname NVARCHAR(50) NOT NULL,
  BirthDay DATE NOT NULL,
  CONSTRAINT PK_User
   PRIMARY KEY(ID_user)
 );
/*USE [Users_and_awards]
GO*/
CREATE TABLE [Awards]
 (ID_award INT IDENTITY(1,1),
  Title NVARCHAR(50) NOT NULL,
  [Description] NVARCHAR(250),
  CONSTRAINT PK_Award
   PRIMARY KEY(ID_award)
 );
USE [Users_and_awards]
GO
CREATE TABLE [UsersAndAwards]
 (ID_user INT NOT NULL,
  ID_award INT NOT NULL,
  CONSTRAINT FK_Users_UsersAndAwards
   FOREIGN KEY(ID_user)
  REFERENCES [Users],
  CONSTRAINT FK_Awards_UsersAndAwards
   FOREIGN KEY(ID_award)
  REFERENCES [Awards],
  CONSTRAINT PK_UsersAndAwards
  PRIMARY KEY(ID_user, ID_award)
 );

USE [Users_and_awards]
GO

CREATE PROC AddUser
 @Firstname NVARCHAR(50),
 @Lastname NVARCHAR(50),
 @BirthDay DATE
AS
 INSERT INTO Users
  VALUES(@Firstname, @Lastname, @BirthDay)
GO

CREATE PROC UpdateUser
 @ID INT,
 @Firstname NVARCHAR(50),
 @Lastname NVARCHAR(50),
 @BirthDay DATE
AS
 UPDATE Users
  SET Firstname=@Firstname, Lastname=@Lastname, BirthDay=@BirthDay
 WHERE ID_user=@ID
 GO

 CREATE PROC DeleteUser
  @ID INT,
  @Firstname NVARCHAR(50),
  @Lastname NVARCHAR(50),
  @BirthDay DATE
AS
 DELETE Users
  WHERE ID_user=@ID AND Firstname=@Firstname AND Lastname=@Lastname AND BirthDay=@BirthDay
GO

CREATE PROC AddAward
 @Title NVARCHAR(50),
 @Description NVARCHAR(250)
AS
 INSERT INTO Awards
  VALUES(@Title, @Description)
GO

CREATE PROC UpdateAward
 @ID INT,
 @Title NVARCHAR(50),
 @Description NVARCHAR(250)
AS
 UPDATE Awards
  SET Title=@Title, [Description]=@Description
WHERE ID_award=@ID
GO

CREATE PROC DeleteAward
 @ID INT,
 @Title NVARCHAR(50),
 @Description NVARCHAR(250)
AS
 DELETE Awards
  WHERE ID_award=@ID AND Title=@Title AND [Description]=@Description
GO

CREATE PROC GetUsersAwards
 @ID INT
AS
 SELECT *
  FROM UsersAndAwards
  WHERE ID_user=@ID
GO

USE [Users_and_awards]
GO

CREATE PROC GetAwards
AS
 SELECT *
  FROM Awards
GO

CREATE PROC GetUsers
AS
 SELECT *
  FROM Users
GO