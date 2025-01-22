SET IDENTITY_INSERT [dbo].[USUARIO] ON
    INSERT INTO [dbo].[USUARIO] ([id], [nombre], [password], [rol]) VALUES (1, N'Tharivol', N'1234', N'administrador')
    INSERT INTO [dbo].[USUARIO] ([id], [nombre], [password], [rol]) VALUES (2, N'Elandril', N'1234', N'usuario')
    INSERT INTO [dbo].[USUARIO] ([id], [nombre], [password], [rol]) VALUES (3, N'Morthil', N'1234', N'usuario')
    INSERT INTO [dbo].[USUARIO] ([id], [nombre], [password], [rol]) VALUES (4, N'Liafina', N'1234', N'usuario')
    INSERT INTO [dbo].[USUARIO] ([id], [nombre], [password], [rol]) VALUES (5, N'Kaelthorn', N'1234', N'usuario')
SET IDENTITY_INSERT [dbo].[USUARIO] OFF