
CREATE PROCEDURE CREAR_EMPLEADO
@Nombre VARCHAR(50), @Apellido VARCHAR(50), @NumeroRepresentante INT,
@TipoEmpleado INT, @Id INT

AS
	INSERT INTO EMPLEADO (Nombre, Apellido, NumeroRepresentante, FK_id_TipoEmpleado, Id)
	VALUES (@Nombre, @Apellido, @NumeroRepresentante, @TipoEmpleado, @Id)
GO
	
CREATE PROCEDURE BORRAR_EMPLEADO
@Id INT, @Nombre VARCHAR(50) = NULL, @Apellido VARCHAR(50) = NULL, @NumeroRepresentante INT = NULL,
@TipoEmpleado INT = NULL

AS
	DELETE FROM EMPLEADO WHERE Id = @Id
GO

CREATE PROCEDURE OBTENER_TODOS_EMPLEADOS
 AS
	SELECT * FROM EMPLEADO
	GO
	

CREATE PROCEDURE OBTENER_EMPLEADO_POR_ID
@Id INT
AS
	SELECT * FROM EMPLEADO WHERE Id = @Id
	GO
	
CREATE PROCEDURE OBTENER_MAX_ID_EMPLEADO
AS
	SELECT MAX(Id) as Id FROM EMPLEADO
	GO
	
CREATE PROCEDURE ACTUALIZAR_EMPLEADO
@Id INT, @Nombre VARCHAR(50), @Apellido VARCHAR(50), @NumeroRepresentante INT,
@TipoEmpleado INT

AS
	UPDATE EMPLEADO SET Nombre = @Nombre, Apellido = @Apellido, NumeroRepresentante = @NumeroRepresentante, FK_id_TipoEmpleado = @TipoEmpleado WHERE Id = @Id
	GO


--TABLE [Usuario]
--[id][int] NOT NULL,
--[email] [varchar] (50) NOT NULL,
--[HashPassword] [varchar] (50) NOT NULL,
--[FK_id_Empleado] [int] NOT NULL	

CREATE PROCEDURE CREAR_USUARIO
@Email VARCHAR(50), @HashPassword VARCHAR(50), @id INT, @FK_id_Empleado INT
AS
INSERT INTO Usuario (Email, HashPassword, FK_id_Empleado, Id)
	VALUES (@Email, @HashPassword, @FK_id_Empleado, @id)
 GO

CREATE PROCEDURE BORRAR_USUARIO
@Id INT, @Email VARCHAR(50) = NULL, @HashPassword VARCHAR(50) = NULL, @FK_id_Empleado INT = NULL
AS
	DELETE FROM Usuario WHERE Id = @Id
	GO
	
CREATE PROCEDURE OBTENER_TODOS_USUARIOS
 AS
	SELECT * FROM Usuario
	GO

CREATE PROCEDURE OBTENER_USUARIO_POR_ID
@Id INT, @Email VARCHAR(50) = NULL, @HashPassword VARCHAR(50) = NULL, @FK_id_Empleado INT = NULL
AS
	SELECT * FROM Usuario WHERE Id = @Id
	GO

CREATE PROCEDURE OBTENER_MAX_ID_USUARIO
AS
	SELECT MAX(Id) as Id FROM Usuario
	GO

CREATE PROCEDURE ACTUALIZAR_USUARIO
@Id INT, @Email VARCHAR(50), @HashPassword VARCHAR(50), @FK_id_Empleado INT
AS
	UPDATE Usuario SET Email = @Email, HashPassword = @HashPassword, FK_id_Empleado = @FK_id_Empleado WHERE Id = @Id
	GO
	
	
	
	