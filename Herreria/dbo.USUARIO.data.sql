-- Insertar el administrador
INSERT INTO [dbo].[USUARIO] ([nombre], [password], [rol])
VALUES 
('Tharivol', '1234', 'administrador');

-- Insertar los usuarios
INSERT INTO [dbo].[USUARIO] ([nombre], [password], [rol])
VALUES 
('Elandril', '1234', 'usuario'),
('Morthil', '1234', 'usuario'),
('Liafina', '1234', 'usuario'),
('Kaelthorn', '1234', 'usuario');