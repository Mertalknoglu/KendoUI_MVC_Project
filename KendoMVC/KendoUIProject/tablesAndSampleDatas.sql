/****** Object:  Table [dbo].[menus]    Script Date: 3.06.2021 22:41:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menus](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[parentid] [int] NOT NULL,
	[title] [varchar](50) NOT NULL,
	[link] [varchar](50) NOT NULL,
 CONSTRAINT [PK_menus] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[task]    Script Date: 3.06.2021 22:41:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[task](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[talepno] [varchar](50) NULL,
	[isadi] [varchar](500) NULL,
	[bildirimtarih] [datetime] NULL,
	[cozumtarih] [datetime] NULL,
	[issahibi] [varchar](50) NULL,
	[durum] [tinyint] NULL,
 CONSTRAINT [PK_isbilgi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[menus] ON 
GO
INSERT [dbo].[menus] ([id], [parentid], [title], [link]) VALUES (1, 0, N'Ana Sayfa', N'1')
GO
INSERT [dbo].[menus] ([id], [parentid], [title], [link]) VALUES (2, 0, N'Inbox', N'2')
GO
INSERT [dbo].[menus] ([id], [parentid], [title], [link]) VALUES (3, 2, N'Acil İşler', N'3')
GO
INSERT [dbo].[menus] ([id], [parentid], [title], [link]) VALUES (5, 2, N'Normal İşler', N'4')
GO
INSERT [dbo].[menus] ([id], [parentid], [title], [link]) VALUES (7, 0, N'Completed', N'5')
GO
SET IDENTITY_INSERT [dbo].[menus] OFF
GO
SET IDENTITY_INSERT [dbo].[task] ON 
GO
INSERT [dbo].[task] ([id], [talepno], [isadi], [bildirimtarih], [cozumtarih], [issahibi], [durum]) VALUES (21, N'2', N'TaskProject', CAST(N'2021-06-02T00:00:00.000' AS DateTime), CAST(N'2021-06-08T00:00:00.000' AS DateTime), N'Gokhan', 3)
GO
INSERT [dbo].[task] ([id], [talepno], [isadi], [bildirimtarih], [cozumtarih], [issahibi], [durum]) VALUES (22, N'1', N'KendoProject', CAST(N'2021-06-01T00:00:00.000' AS DateTime), CAST(N'2021-06-03T00:00:00.000' AS DateTime), N'Mert', 3)
GO
INSERT [dbo].[task] ([id], [talepno], [isadi], [bildirimtarih], [cozumtarih], [issahibi], [durum]) VALUES (23, N'3', N'MvcProject', CAST(N'2021-06-07T00:00:00.000' AS DateTime), CAST(N'2021-06-12T00:00:00.000' AS DateTime), N'Ahmet', 4)
GO
INSERT [dbo].[task] ([id], [talepno], [isadi], [bildirimtarih], [cozumtarih], [issahibi], [durum]) VALUES (24, N'4', N'WebAPIproject', CAST(N'2021-06-08T00:00:00.000' AS DateTime), CAST(N'2021-06-23T00:00:00.000' AS DateTime), N'Oğuz', 4)
GO
INSERT [dbo].[task] ([id], [talepno], [isadi], [bildirimtarih], [cozumtarih], [issahibi], [durum]) VALUES (25, N'10', N'KendoMVCProject', CAST(N'2021-05-31T00:00:00.000' AS DateTime), CAST(N'2021-06-02T00:00:00.000' AS DateTime), N'Mert', 5)
GO
SET IDENTITY_INSERT [dbo].[task] OFF
GO
