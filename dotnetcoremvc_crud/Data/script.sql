USE [dotnetcoremvc_crud]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/27/2020 11:34:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](80) NULL,
	[Country] [nvarchar](80) NULL,
	[City] [nvarchar](80) NULL,
	[PhoneNo] [nchar](10) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [Name], [Country], [City], [PhoneNo]) VALUES (4, N'Mg Mg', N'Myanmar', N'Yangon', N'097887    ')
INSERT [dbo].[Customer] ([Id], [Name], [Country], [City], [PhoneNo]) VALUES (5, N'Kyaw Kyaw', N'Myanmar', N'Mandalay', N'09789987  ')
INSERT [dbo].[Customer] ([Id], [Name], [Country], [City], [PhoneNo]) VALUES (6, N'Nay Nay', N'Myanmar', N'Monywa', N'091234590 ')
SET IDENTITY_INSERT [dbo].[Customer] OFF
