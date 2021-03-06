USE [master]
GO
/****** Object:  Database [Trade_Finance]    Script Date: 2/17/2019 3:41:11 AM ******/
CREATE DATABASE [Trade_Finance]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Trade_Finance', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2K14\MSSQL\DATA\Trade_Finance.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Trade_Finance_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL2K14\MSSQL\DATA\Trade_Finance_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Trade_Finance] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Trade_Finance].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Trade_Finance] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Trade_Finance] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Trade_Finance] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Trade_Finance] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Trade_Finance] SET ARITHABORT OFF 
GO
ALTER DATABASE [Trade_Finance] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Trade_Finance] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Trade_Finance] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Trade_Finance] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Trade_Finance] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Trade_Finance] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Trade_Finance] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Trade_Finance] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Trade_Finance] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Trade_Finance] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Trade_Finance] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Trade_Finance] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Trade_Finance] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Trade_Finance] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Trade_Finance] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Trade_Finance] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Trade_Finance] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Trade_Finance] SET RECOVERY FULL 
GO
ALTER DATABASE [Trade_Finance] SET  MULTI_USER 
GO
ALTER DATABASE [Trade_Finance] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Trade_Finance] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Trade_Finance] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Trade_Finance] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Trade_Finance] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Trade_Finance', N'ON'
GO
USE [Trade_Finance]
GO
/****** Object:  Table [dbo].[CorrespondanceType]    Script Date: 2/17/2019 3:41:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CorrespondanceType](
	[CorrespondanceTypeId] [int] IDENTITY(1,1) NOT NULL,
	[CorrespondanceTypeName] [varchar](50) NULL,
	[Created_By] [varchar](50) NULL,
	[Created_date] [datetime] NULL,
	[Modified_By] [varchar](50) NULL,
	[Modified_date] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_CorrespondanceType] PRIMARY KEY CLUSTERED 
(
	[CorrespondanceTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EventDetail]    Script Date: 2/17/2019 3:41:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EventDetail](
	[EventDetailId] [int] IDENTITY(1,1) NOT NULL,
	[BranchId] [int] NULL,
	[Batch1] [varchar](50) NULL,
	[Batch2] [varchar](50) NULL,
	[EventTypeId] [int] NULL,
	[IssueMediumId] [int] NULL,
	[LCNumber] [int] NULL,
	[EventNumber] [int] NULL,
	[EventStatus1] [varchar](50) NULL,
	[EventStatus2] [varchar](50) NULL,
	[correspondanceNo] [int] NULL,
	[CorrespondanceDate] [datetime] NULL,
	[CorrespondanceTypeId] [int] NULL,
	[PartiesId] [int] NULL,
	[BankBranch] [varchar](50) NULL,
	[BankNo] [int] NULL,
	[BranchNo] [int] NULL,
	[Information] [varchar](500) NULL,
	[Information2] [varchar](50) NULL,
	[Reference] [varchar](50) NULL,
	[IntractionToSend] [varchar](500) NULL,
	[information3] [varchar](500) NULL,
	[EventDetailStatus] [varchar](50) NULL,
	[Created_By] [varchar](50) NULL,
	[Created_date] [datetime] NULL,
	[Modified_By] [varchar](50) NULL,
	[Modified_date] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_EventDetail] PRIMARY KEY CLUSTERED 
(
	[EventDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EventType]    Script Date: 2/17/2019 3:41:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EventType](
	[EventsTypeId] [int] IDENTITY(1,1) NOT NULL,
	[EventTypeName] [varchar](50) NULL,
	[Created_By] [varchar](50) NULL,
	[Created_date] [datetime] NULL,
	[Modified_By] [varchar](50) NULL,
	[Modified_date] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_EventType] PRIMARY KEY CLUSTERED 
(
	[EventsTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IssueMedium]    Script Date: 2/17/2019 3:41:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IssueMedium](
	[IssueMediumId] [int] IDENTITY(1,1) NOT NULL,
	[IssueMediumName] [varchar](50) NULL,
	[Created_By] [varchar](50) NULL,
	[Created_date] [datetime] NULL,
	[Modified_By] [varchar](50) NULL,
	[Modified_date] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_IssueMedium] PRIMARY KEY CLUSTERED 
(
	[IssueMediumId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Parties]    Script Date: 2/17/2019 3:41:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Parties](
	[PartiesID] [int] IDENTITY(1,1) NOT NULL,
	[PartiesName] [varchar](50) NULL,
	[Created_By] [varchar](50) NULL,
	[Created_date] [datetime] NULL,
	[Modified_By] [varchar](50) NULL,
	[Modified_date] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Parties] PRIMARY KEY CLUSTERED 
(
	[PartiesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CorrespondanceType] ON 

GO
INSERT [dbo].[CorrespondanceType] ([CorrespondanceTypeId], [CorrespondanceTypeName], [Created_By], [Created_date], [Modified_By], [Modified_date], [IsActive]) VALUES (1, N'Correspondance1', NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[CorrespondanceType] ([CorrespondanceTypeId], [CorrespondanceTypeName], [Created_By], [Created_date], [Modified_By], [Modified_date], [IsActive]) VALUES (2, N'Correspondance2', NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[CorrespondanceType] ([CorrespondanceTypeId], [CorrespondanceTypeName], [Created_By], [Created_date], [Modified_By], [Modified_date], [IsActive]) VALUES (3, N'Correspondance3', NULL, NULL, NULL, NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[CorrespondanceType] OFF
GO
SET IDENTITY_INSERT [dbo].[EventDetail] ON 

GO
INSERT [dbo].[EventDetail] ([EventDetailId], [BranchId], [Batch1], [Batch2], [EventTypeId], [IssueMediumId], [LCNumber], [EventNumber], [EventStatus1], [EventStatus2], [correspondanceNo], [CorrespondanceDate], [CorrespondanceTypeId], [PartiesId], [BankBranch], [BankNo], [BranchNo], [Information], [Information2], [Reference], [IntractionToSend], [information3], [EventDetailStatus], [Created_By], [Created_date], [Modified_By], [Modified_date], [IsActive]) VALUES (1, NULL, NULL, NULL, 1, 1, 123455, 6543, N'abc', N'def', 678, CAST(N'2019-02-16 00:00:00.000' AS DateTime), 1, 1, N'BANK', 1, NULL, N'information1', N'information3', N'refernce1', N'intraction to send', N'information2', NULL, NULL, NULL, N'Modified User', CAST(N'2019-02-17 01:14:53.897' AS DateTime), 1)
GO
INSERT [dbo].[EventDetail] ([EventDetailId], [BranchId], [Batch1], [Batch2], [EventTypeId], [IssueMediumId], [LCNumber], [EventNumber], [EventStatus1], [EventStatus2], [correspondanceNo], [CorrespondanceDate], [CorrespondanceTypeId], [PartiesId], [BankBranch], [BankNo], [BranchNo], [Information], [Information2], [Reference], [IntractionToSend], [information3], [EventDetailStatus], [Created_By], [Created_date], [Modified_By], [Modified_date], [IsActive]) VALUES (2, NULL, NULL, NULL, 3, 2, 123451, 1, N'12', N'123', 1234, CAST(N'2019-02-17 00:00:00.000' AS DateTime), 3, 3, N'BRANCH', 1, NULL, N'infor1', N'infor3', N'ref1', N'inttraction ', N'infor2', NULL, N'Created User', CAST(N'2019-02-17 01:16:21.787' AS DateTime), N'Modified User', CAST(N'2019-02-17 01:16:21.787' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[EventDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[EventType] ON 

GO
INSERT [dbo].[EventType] ([EventsTypeId], [EventTypeName], [Created_By], [Created_date], [Modified_By], [Modified_date], [IsActive]) VALUES (1, N'Event Type1', NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[EventType] ([EventsTypeId], [EventTypeName], [Created_By], [Created_date], [Modified_By], [Modified_date], [IsActive]) VALUES (2, N'Event Type2', NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[EventType] ([EventsTypeId], [EventTypeName], [Created_By], [Created_date], [Modified_By], [Modified_date], [IsActive]) VALUES (3, N'Event Type3', NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[EventType] ([EventsTypeId], [EventTypeName], [Created_By], [Created_date], [Modified_By], [Modified_date], [IsActive]) VALUES (4, N'Event Type4', NULL, NULL, NULL, NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[EventType] OFF
GO
SET IDENTITY_INSERT [dbo].[IssueMedium] ON 

GO
INSERT [dbo].[IssueMedium] ([IssueMediumId], [IssueMediumName], [Created_By], [Created_date], [Modified_By], [Modified_date], [IsActive]) VALUES (1, N'IssueMedium1', NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[IssueMedium] ([IssueMediumId], [IssueMediumName], [Created_By], [Created_date], [Modified_By], [Modified_date], [IsActive]) VALUES (2, N'IssueMedium2', NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[IssueMedium] ([IssueMediumId], [IssueMediumName], [Created_By], [Created_date], [Modified_By], [Modified_date], [IsActive]) VALUES (3, N'IssueMedium3', NULL, NULL, NULL, NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[IssueMedium] OFF
GO
SET IDENTITY_INSERT [dbo].[Parties] ON 

GO
INSERT [dbo].[Parties] ([PartiesID], [PartiesName], [Created_By], [Created_date], [Modified_By], [Modified_date], [IsActive]) VALUES (1, N'Parties1', NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[Parties] ([PartiesID], [PartiesName], [Created_By], [Created_date], [Modified_By], [Modified_date], [IsActive]) VALUES (2, N'Parties2', NULL, NULL, NULL, NULL, 1)
GO
INSERT [dbo].[Parties] ([PartiesID], [PartiesName], [Created_By], [Created_date], [Modified_By], [Modified_date], [IsActive]) VALUES (3, N'Parties3', NULL, NULL, NULL, NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[Parties] OFF
GO
ALTER TABLE [dbo].[EventDetail]  WITH CHECK ADD  CONSTRAINT [FK_EventDetail_CorrespondanceType] FOREIGN KEY([CorrespondanceTypeId])
REFERENCES [dbo].[CorrespondanceType] ([CorrespondanceTypeId])
GO
ALTER TABLE [dbo].[EventDetail] CHECK CONSTRAINT [FK_EventDetail_CorrespondanceType]
GO
ALTER TABLE [dbo].[EventDetail]  WITH CHECK ADD  CONSTRAINT [FK_EventDetail_EventType] FOREIGN KEY([EventTypeId])
REFERENCES [dbo].[EventType] ([EventsTypeId])
GO
ALTER TABLE [dbo].[EventDetail] CHECK CONSTRAINT [FK_EventDetail_EventType]
GO
ALTER TABLE [dbo].[EventDetail]  WITH CHECK ADD  CONSTRAINT [FK_EventDetail_IssueMedium] FOREIGN KEY([IssueMediumId])
REFERENCES [dbo].[IssueMedium] ([IssueMediumId])
GO
ALTER TABLE [dbo].[EventDetail] CHECK CONSTRAINT [FK_EventDetail_IssueMedium]
GO
ALTER TABLE [dbo].[EventDetail]  WITH CHECK ADD  CONSTRAINT [FK_EventDetail_Parties] FOREIGN KEY([PartiesId])
REFERENCES [dbo].[Parties] ([PartiesID])
GO
ALTER TABLE [dbo].[EventDetail] CHECK CONSTRAINT [FK_EventDetail_Parties]
GO
USE [master]
GO
ALTER DATABASE [Trade_Finance] SET  READ_WRITE 
GO
