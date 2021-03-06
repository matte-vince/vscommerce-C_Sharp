USE [vscommerce]
GO
/****** Object:  Table [dbo].[brand]    Script Date: 12/06/2020 19:45:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[brand](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_brand_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[category]    Script Date: 12/06/2020 19:45:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order]    Script Date: 12/06/2020 19:45:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[customer] [int] NOT NULL,
	[date] [datetime] NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [PK_order] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderLine]    Script Date: 12/06/2020 19:45:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderLine](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[product] [int] NOT NULL,
	[orderID] [int] NOT NULL,
	[qty] [int] NOT NULL,
	[priceUnit] [float] NOT NULL,
 CONSTRAINT [PK_orderLine] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prodotti]    Script Date: 12/06/2020 19:45:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prodotti](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [varchar](50) NULL,
	[price] [float] NOT NULL,
	[tax] [int] NOT NULL,
	[qty] [int] NOT NULL,
	[barcode] [varchar](15) NULL,
	[brand] [int] NOT NULL,
	[category] [int] NOT NULL,
	[image] [varchar](max) NOT NULL,
 CONSTRAINT [PK_prodotti] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 12/06/2020 19:45:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[surname] [varchar](50) NOT NULL,
	[birthday] [datetime] NULL,
	[fiscalCode] [varchar](16) NULL,
	[password] [varchar](100) NOT NULL,
	[isAdmin] [bit] NOT NULL,
	[email] [varchar](100) NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[brand] ON 

INSERT [dbo].[brand] ([ID], [name]) VALUES (1, N'ZANICHELLI')
INSERT [dbo].[brand] ([ID], [name]) VALUES (2, N'MONDADORI')
INSERT [dbo].[brand] ([ID], [name]) VALUES (3, N'APPLE')
INSERT [dbo].[brand] ([ID], [name]) VALUES (4, N'SAMSUNG')
INSERT [dbo].[brand] ([ID], [name]) VALUES (5, N'CORSAIR')
INSERT [dbo].[brand] ([ID], [name]) VALUES (6, N'RASPBERRY')
INSERT [dbo].[brand] ([ID], [name]) VALUES (7, N'DYSON')
INSERT [dbo].[brand] ([ID], [name]) VALUES (8, N'DELL')
INSERT [dbo].[brand] ([ID], [name]) VALUES (9, N'ONEPLUS')
INSERT [dbo].[brand] ([ID], [name]) VALUES (10, N'DJI')
INSERT [dbo].[brand] ([ID], [name]) VALUES (11, N'MICROSOFT')
INSERT [dbo].[brand] ([ID], [name]) VALUES (12, N'SONY')
INSERT [dbo].[brand] ([ID], [name]) VALUES (13, N'AKG')
INSERT [dbo].[brand] ([ID], [name]) VALUES (14, N'CANON')
SET IDENTITY_INSERT [dbo].[brand] OFF
GO
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([ID], [name]) VALUES (1, N'ELETTRONICA')
INSERT [dbo].[category] ([ID], [name]) VALUES (2, N'INFORMATICA')
INSERT [dbo].[category] ([ID], [name]) VALUES (3, N'LIBRERIA')
INSERT [dbo].[category] ([ID], [name]) VALUES (4, N'TELEFONIA')
INSERT [dbo].[category] ([ID], [name]) VALUES (5, N'TV E HOME CINEMA')
INSERT [dbo].[category] ([ID], [name]) VALUES (6, N'AUDIO E HI-FI')
INSERT [dbo].[category] ([ID], [name]) VALUES (7, N'FOTO E VIDEO')
INSERT [dbo].[category] ([ID], [name]) VALUES (8, N'ELETTRODOMESTICI')
INSERT [dbo].[category] ([ID], [name]) VALUES (9, N'CONSOLE E VIDEOGIOCHI')
INSERT [dbo].[category] ([ID], [name]) VALUES (10, N'TEMPO LIBERO')
SET IDENTITY_INSERT [dbo].[category] OFF
GO
SET IDENTITY_INSERT [dbo].[order] ON 

INSERT [dbo].[order] ([ID], [customer], [date], [total]) VALUES (8, 6, CAST(N'2020-06-06T11:13:43.487' AS DateTime), 219.98)
INSERT [dbo].[order] ([ID], [customer], [date], [total]) VALUES (9, 6, CAST(N'2020-06-12T18:07:15.927' AS DateTime), 3050)
INSERT [dbo].[order] ([ID], [customer], [date], [total]) VALUES (10, 6, CAST(N'2020-06-12T18:08:20.147' AS DateTime), 805)
INSERT [dbo].[order] ([ID], [customer], [date], [total]) VALUES (11, 6, CAST(N'2020-06-12T18:10:02.477' AS DateTime), 988)
SET IDENTITY_INSERT [dbo].[order] OFF
GO
SET IDENTITY_INSERT [dbo].[orderLine] ON 

INSERT [dbo].[orderLine] ([ID], [product], [orderID], [qty], [priceUnit]) VALUES (10, 4, 8, 2, 109.99)
INSERT [dbo].[orderLine] ([ID], [product], [orderID], [qty], [priceUnit]) VALUES (11, 29, 9, 1, 1800)
INSERT [dbo].[orderLine] ([ID], [product], [orderID], [qty], [priceUnit]) VALUES (12, 19, 9, 1, 350)
INSERT [dbo].[orderLine] ([ID], [product], [orderID], [qty], [priceUnit]) VALUES (13, 15, 9, 1, 900)
INSERT [dbo].[orderLine] ([ID], [product], [orderID], [qty], [priceUnit]) VALUES (14, 13, 10, 1, 785)
INSERT [dbo].[orderLine] ([ID], [product], [orderID], [qty], [priceUnit]) VALUES (15, 17, 10, 1, 20)
INSERT [dbo].[orderLine] ([ID], [product], [orderID], [qty], [priceUnit]) VALUES (16, 8, 11, 1, 988)
SET IDENTITY_INSERT [dbo].[orderLine] OFF
GO
SET IDENTITY_INSERT [dbo].[prodotti] ON 

INSERT [dbo].[prodotti] ([ID], [name], [description], [price], [tax], [qty], [barcode], [brand], [category], [image]) VALUES (1, N'La coscienza di Zeno - Italo Svevo', N'LA COSCIENZA DI ZENO ITALO SVEVO OSCAR MONDADOR', 19.99, 22, 20, N'03864046', 2, 3, N'https://www.mondadoristore.it/img/La-coscienza-di-Zeno-Italo-Svevo/ea978880466829/BL/BL/01/NZO/?tit=La+coscienza+di+Zeno&aut=Italo+Svevo')
INSERT [dbo].[prodotti] ([ID], [name], [description], [price], [tax], [qty], [barcode], [brand], [category], [image]) VALUES (4, N'Case PC - Omega red', N'case bellissimo', 109.99, 22, 6, N'15161', 5, 2, N'https://www.techpowerup.com/review/corsair-carbide-spec-omega/images/small.png')
INSERT [dbo].[prodotti] ([ID], [name], [description], [price], [tax], [qty], [barcode], [brand], [category], [image]) VALUES (8, N'iPhone 11 Pro', N'iphone 11 pro della apple', 988, 22, 355, N'186085', 3, 4, N'https://wmstatic.global.ssl.fastly.net/ml/4180220-4898465.png?width=320&height=320&whitespace=true')
INSERT [dbo].[prodotti] ([ID], [name], [description], [price], [tax], [qty], [barcode], [brand], [category], [image]) VALUES (9, N'Samsung Series 6 TV QLED', N'Samsung Series 6 TV QLED, gran televisore ', 596, 22, 120, N'12340665', 4, 5, N'https://i.ebayimg.com/images/g/X~kAAOSw2aJesEGm/s-l225.jpg')
INSERT [dbo].[prodotti] ([ID], [name], [description], [price], [tax], [qty], [barcode], [brand], [category], [image]) VALUES (10, N'Raspberry Pi 4 Modello B', N'Raspberry Pi versione 4 modello B ', 35, 22, 899, N'0165041656', 6, 1, N'https://media.rs-online.com/t_large/F8332699-01.jpg')
INSERT [dbo].[prodotti] ([ID], [name], [description], [price], [tax], [qty], [barcode], [brand], [category], [image]) VALUES (13, N'DELL XPS 14', N'dell xps 14 ', 785, 22, 4588, N'054605546', 8, 1, N'https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSV7DwtHAxTMa36osQNKarZvP1uIHqQFD2b1OKG2zsZ8LohDDVl&usqp=CAU')
INSERT [dbo].[prodotti] ([ID], [name], [description], [price], [tax], [qty], [barcode], [brand], [category], [image]) VALUES (14, N'Dyson V10 Parquet', N'dyson versione 10 parquet ', 455, 22, 47, N'05161634', 7, 8, N'https://prodpics.trovaprezzi.it/comparisonit/dyson_v10_parquet-300x300.jpg')
INSERT [dbo].[prodotti] ([ID], [name], [description], [price], [tax], [qty], [barcode], [brand], [category], [image]) VALUES (15, N'OnePlus 8 Pro', N'oneplus 8 pro ', 900, 22, 144, N'0123485', 9, 4, N'https://www.ourphonestoday.com/wp-content/uploads/2020/04/OnePlus-8.png')
INSERT [dbo].[prodotti] ([ID], [name], [description], [price], [tax], [qty], [barcode], [brand], [category], [image]) VALUES (16, N'MacBook Pro 2020 Apple', N'Macbook pro 16 Apple', 1229, 22, 18, N'01247536', 3, 2, N'https://download.seaicons.com/icons/turbomilk/gadgets/512/Apple-MacBook-Pro-icon.png')
INSERT [dbo].[prodotti] ([ID], [name], [description], [price], [tax], [qty], [barcode], [brand], [category], [image]) VALUES (17, N'OFFICE Professional plus', N'Ultima versione di office Professional Plus ', 20, 22, 998, N'01560556', 11, 2, N'https://www.amstelsoftware.com/34-large_default/microsoft-office-2016-professional-plus.jpg')
INSERT [dbo].[prodotti] ([ID], [name], [description], [price], [tax], [qty], [barcode], [brand], [category], [image]) VALUES (18, N'Playstation 5 by SONY', N'Playstation 5 con 1 controller e cuffie wireless ', 599, 22, 520, N'0210315', 12, 9, N'https://static.sky.it/images/skytg24/it/tecnologia/2020/06/12/sony-ps5/ps5-bella.png')
INSERT [dbo].[prodotti] ([ID], [name], [description], [price], [tax], [qty], [barcode], [brand], [category], [image]) VALUES (19, N'AKG Cuffie OverEar', N'AKG cuffie over ear con jack audio 3.5', 350, 22, 799, N'1208460', 13, 6, N'https://m.media-amazon.com/images/S/aplus-media/vc/b95bf45c-0e25-4a53-8f03-c34e4bf57e90.__CR0,0,1605,1605_PT0_SX300_V1___.png')
INSERT [dbo].[prodotti] ([ID], [name], [description], [price], [tax], [qty], [barcode], [brand], [category], [image]) VALUES (21, N'AirPods 2', N'airpods 2, colore bianco, true wireless ', 169, 22, 499, N'0654154', 3, 6, N'https://d5bnf7st86nuo.cloudfront.net/wp-content/uploads/2017/12/08162549/AirPods-Verizon-Wireless-Apple-Audio-CELLibrity.png')
INSERT [dbo].[prodotti] ([ID], [name], [description], [price], [tax], [qty], [barcode], [brand], [category], [image]) VALUES (27, N'DJI Mavic Mini', N'dji mavic mini, peso 249g, colore bianco', 399, 22, 139, N'140546', 10, 7, N'https://www.der-schweighofer.it/public/files/productDetailBig/DJI-Mavic-Mini-Fly-More-Combo-FPV-Drohne-2.7K-Kamera-RTF-3030441-a279847.png')
INSERT [dbo].[prodotti] ([ID], [name], [description], [price], [tax], [qty], [barcode], [brand], [category], [image]) VALUES (29, N'Reflex Canon EOS 6D ', N'Canon 6D full frame, reflex con obiettivo incluso', 1800, 22, 44, N'01215318', 14, 7, N'https://pictures.monclick.it/serve/001/1/8/9/1897c022/250/97a0dbd25da940a7b427ef34b88fd092.jpg')
SET IDENTITY_INSERT [dbo].[prodotti] OFF
GO
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([ID], [name], [surname], [birthday], [fiscalCode], [password], [isAdmin], [email]) VALUES (1, N'karanveer', N'singh', CAST(N'1998-07-21T00:00:00.000' AS DateTime), N'sngknv98l21z222h', N'db068ce9f744fbb35eedc9a883f91085', 1, N'karan98.ks3@gmail.com')
INSERT [dbo].[user] ([ID], [name], [surname], [birthday], [fiscalCode], [password], [isAdmin], [email]) VALUES (6, N'test', N'cliente', CAST(N'1998-07-21T00:00:00.000' AS DateTime), N'sngknv98l21z222h', N'202cb962ac59075b964b07152d234b70', 0, N'test')
INSERT [dbo].[user] ([ID], [name], [surname], [birthday], [fiscalCode], [password], [isAdmin], [email]) VALUES (8, N'karanveer', N'singh', CAST(N'1998-07-21T23:41:50.000' AS DateTime), N'sngknv98l21z222h', N'81dc9bdb52d04dc20036dbd8313ed055', 0, N'karanveer.singh@studenti.unipr.it')
INSERT [dbo].[user] ([ID], [name], [surname], [birthday], [fiscalCode], [password], [isAdmin], [email]) VALUES (10, N'matteo', N'vincenzi', CAST(N'1998-05-21T21:30:00.000' AS DateTime), N'MVNCZN05H01L219Y', N'2a409d9e2bde25bf19dfed329e45e288', 1, N'mattevince@gmail.com')
INSERT [dbo].[user] ([ID], [name], [surname], [birthday], [fiscalCode], [password], [isAdmin], [email]) VALUES (12, N'roberto', N'de falco', CAST(N'1985-01-01T11:00:00.000' AS DateTime), N'TTTNCH07M53L219S', N'ac8c0826d26ace7d67486fa3ef3c0290', 1, N'roberto.defalco@sigrade.it')
SET IDENTITY_INSERT [dbo].[user] OFF
GO
EXEC sys.sp_addextendedproperty @name=N'Identity', @value=N'True' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'brand', @level2type=N'COLUMN',@level2name=N'ID'
GO
