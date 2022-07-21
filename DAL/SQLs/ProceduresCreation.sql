
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
	
--OBTENER_USUARIO_POR_EMAIL

CREATE PROCEDURE OBTENER_USUARIO_POR_EMAIL
@Email VARCHAR(50)
AS
	SELECT * FROM Usuario WHERE Email = @Email
	GO


--Procedures para Permiso
--TABLE [dbo].[Permiso](
--[id] [int] NOT NULL,
--[Nombre] [varchar](50) NOT NULL,
--[Tipo] [varchar](50) NULL,

CREATE PROCEDURE CREAR_PERMISO @Nombre VARCHAR(50),
                               @Tipo   VARCHAR(50),
                               @Id     INT,
							   @esFamilia INT
AS
    INSERT INTO Permiso
                (Nombre,
                 Tipo,
                 Id,
				 esFamilia)
    VALUES      (@Nombre,
                 @Tipo,
                 @Id,
				 @esFamilia)

go

CREATE PROCEDURE BORRAR_PERMISO @Id     INT,
                                @Nombre VARCHAR(50) = NULL,
                                @Tipo   VARCHAR(50) = NULL,
								@esFamilia INT = NULL
AS
    DELETE FROM Permiso
    WHERE  Id = @Id

go

CREATE PROCEDURE OBTENER_TODOS_PERMISOS
AS
    SELECT *
    FROM   Permiso

go

CREATE PROCEDURE OBTENER_PERMISO_POR_ID @Id     INT,
                                        @Nombre VARCHAR(50) = NULL,
                                        @Tipo   VARCHAR(50) = NULL,
										@esFamilia INT = NULL
AS
    SELECT *
    FROM   Permiso
    WHERE  Id = @Id

go

CREATE PROCEDURE OBTENER_MAX_ID_PERMISO
AS
    SELECT Max(Id) AS Id
    FROM   Permiso

go

CREATE PROCEDURE ACTUALIZAR_PERMISO @Id     INT,
                                    @Nombre VARCHAR(50),
                                    @Tipo   VARCHAR(50),
									@esFamilia INT
AS
    UPDATE Permiso
    SET    Nombre = @Nombre,
           Tipo = @Tipo,
		   esFamilia = @esFamilia
    WHERE  Id = @Id

go

CREATE PROCEDURE OBTENER_PERMISO_POR_NOMBRE @Nombre VARCHAR(50)
AS
    SELECT *
    FROM   Permiso
    WHERE  Nombre = @Nombre

go

CREATE PROCEDURE OBTENER_PERMISO_POR_TIPO @Tipo VARCHAR(50)
AS
    SELECT *
    FROM   Permiso
    WHERE  Tipo = @Tipo

go




-- TABLE Usuario_x_Permiso(
-- 	[FK_id_Usuario] [int] NOT NULL,
-- 	[FK_id_Permiso] [int] NOT NULL
-- )

--TABLE [dbo].[Permiso](
--[id] [int] NOT NULL,
--[Nombre] [varchar](50) NOT NULL,
--[Tipo] [varchar](50) NULL,

CREATE PROCEDURE OBTENER_PERMISOS_POR_ID_USUARIO
@Id INT, @Email VARCHAR(50) = NULL, @HashPassword VARCHAR(50) = NULL, @FK_id_Empleado INT = NULL

AS
    SELECT p.id, p.Nombre, p.Tipo, p.esFamilia FROM Permiso p
    INNER JOIN Usuario_x_Permiso up ON up.FK_id_Permiso = p.id
    WHERE up.FK_id_Usuario = @Id
GO


CREATE PROCEDURE OBTENER_PERMISOS_HIJOS
@Id INT, @Nombre VARCHAR(50) = NULL, @Tipo VARCHAR(50) = NULL, @esFamilia INT = NULL

AS
    SELECT p.id, p.Nombre, p.Tipo, p.esFamilia FROM Permiso p
    INNER JOIN Permiso_x_Permiso pp ON pp.FK_Id_Permiso_Hijo = p.id
    WHERE pp.FK_Id_Permiso_Padre = @Id
GO

CREATE PROCEDURE GUARDAR_PERMISO_HIJO
@Id_Padre INT, @Id_Hijo INT
AS
	INSERT INTO Permiso_x_Permiso
				(FK_Id_Permiso_Padre,
				 FK_Id_Permiso_Hijo)
	VALUES      (@Id_Padre,
				 @Id_Hijo)
GO

CREATE PROCEDURE BORRAR_PERMISO_HIJO
@Id_Padre INT, @Id_Hijo INT
AS
	DELETE FROM Permiso_x_Permiso
	WHERE FK_Id_Permiso_Padre = @Id_Padre AND FK_Id_Permiso_Hijo = @Id_Hijo
GO

CREATE PROCEDURE BORRAR_PERMISO_PADRE
@Id INT
AS
	DELETE FROM Permiso_x_Permiso
	WHERE FK_Id_Permiso_Hijo = @Id
GO

CREATE PROCEDURE OBTENER_PERMISOS_PADRE
@Id INT, @Nombre VARCHAR(50) = NULL, @Tipo VARCHAR(50) = NULL, @esFamilia INT = NULL
 as
SELECT * from Permiso_x_Permiso
WHERE FK_Id_Permiso_Hijo = @Id
GO

--AGREGAR_PERMISO_A_USUARIO
CREATE PROCEDURE AGREGAR_PERMISO_A_USUARIO
@Id_Usuario INT, @Id_Permiso INT
AS
	INSERT INTO Usuario_x_Permiso
				(FK_id_Usuario,
				 FK_id_Permiso)
	VALUES      (@Id_Usuario,
				 @Id_Permiso)
GO

--QUITAR_PERMISO_A_USUARIO
CREATE PROCEDURE QUITAR_PERMISO_A_USUARIO
@Id_Usuario INT, @Id_Permiso INT
AS
	DELETE FROM Usuario_x_Permiso
	WHERE FK_id_Usuario = @Id_Usuario AND FK_id_Permiso = @Id_Permiso
GO




--TABLE Idioma (
--	[id] [int] NOT NULL,
--	[Nombre] [varchar](50) NOT NULL
-- )

-- CREAR_IDIOMA
CREATE PROCEDURE CREAR_IDIOMA
@Id INT, @Nombre VARCHAR(50)
AS
	INSERT INTO Idioma
				(id,
				 nombre)
	VALUES      (@Id,
				 @Nombre)
				GO
				
-- OBTENER_TODOS_IDIOMAS
CREATE PROCEDURE OBTENER_TODOS_IDIOMAS
AS
	SELECT id, nombre from Idioma
	GO

-- OBTENER_IDIOMA_POR_ID
CREATE PROCEDURE OBTENER_IDIOMA_POR_ID
@Id INT, @Nombre VARCHAR(50) = NULL
AS
	SELECT id, nombre from Idioma
	WHERE id = @Id
GO

-- BORRAR_IDIOMA
CREATE PROCEDURE BORRAR_IDIOMA
@Id INT, @Nombre VARCHAR(50) = NULL
AS
	DELETE FROM Idioma
	WHERE id = @Id
GO

-- ACTUALIZAR_IDIOMA
CREATE PROCEDURE ACTUALIZAR_IDIOMA
@Id INT, @Nombre VARCHAR(50)
AS
	UPDATE Idioma
	SET    nombre = @Nombre
	WHERE id = @Id
Go

-- OBTENER_MAX_ID_IDIOMA
CREATE PROCEDURE OBTENER_MAX_ID_IDIOMA
AS
	SELECT MAX(id) as id from Idioma
GO



CREATE PROCEDURE OBTENER_TODAS_TRADUCCIONES
AS
SELECT * from Traduccion
GO

CREATE PROCEDURE OBTENER_TRADUCCIONES_POR_IDIOMA
@Id INT, @Nombre_Idioma VARCHAR(50) = NULL
AS
SELECT       e.id as Id_Etiqueta, e.nombre as NombreEtiqueta, e.defaultText as defaultText, t.Traduccion as Traduccion
FROM            dbo.Etiqueta AS e LEFT OUTER JOIN
                             (SELECT        FK_id_idioma, FK_id_etiqueta, Traduccion
                               FROM         Traducciones
                               WHERE        FK_id_idioma = @Id) AS t ON e.id = t.FK_id_etiqueta
GO

-- UPDATE_TRADUCCIONES
CREATE PROCEDURE UPDATE_TRADUCCIONES
@Id_Idioma INT, @Id_Etiqueta INT, @Traduccion VARCHAR(200) = NULL
AS
BEGIN
	IF NOT @Traduccion IS NULL
	BEGIN
		IF NOT EXISTS (
		SELECT * FROM Traducciones 
		WHERE FK_id_idioma = @Id_Idioma AND FK_id_etiqueta = @Id_Etiqueta
		) 
		BEGIN
			INSERT INTO Traducciones
						(FK_id_idioma,
						 FK_id_etiqueta,
						 Traduccion)
			VALUES      (@Id_Idioma,
						 @Id_Etiqueta,
						 @Traduccion)
		END
		ELSE
		BEGIN
			UPDATE Traducciones
			SET Traduccion = @Traduccion
			WHERE FK_id_idioma = @Id_Idioma AND FK_id_etiqueta = @Id_Etiqueta
		END
	END
END
GO


-- SET_IDIOMA_TO_USER
CREATE PROCEDURE SET_IDIOMA_TO_USER
@Id_Usuario INT, @Id_Idioma INT
AS
BEGIN
	IF NOT EXISTS (
	SELECT * FROM Usuario_x_Idioma
	WHERE FK_id_usuario = @Id_Usuario)
	BEGIN
		INSERT INTO Usuario_x_Idioma
					(FK_id_usuario,
					 FK_id_idioma)
		VALUES      (@Id_Usuario,
					 @Id_Idioma)
	END
	ELSE
	BEGIN
		UPDATE Usuario_x_Idioma
		SET FK_id_idioma = @Id_Idioma
		WHERE FK_id_usuario = @Id_Usuario
	END
	
END

GO

-- GET_IDIOMA_FROM_USER
CREATE PROCEDURE GET_IDIOMA_FROM_USER
@Id_Usuario INT
AS
BEGIN
	SELECT FK_id_idioma FROM Usuario_x_Idioma
	WHERE FK_id_usuario = @Id_Usuario
END
GO

----------------------------------
-- TABLE NodoRed
-- public string nombre;
-- public EstadoNodo estado;

-- CREAR_NODORED
CREATE PROCEDURE CREAR_NODORED
@id INT, @nombre VARCHAR(50), @estado VARCHAR(50) = NULL
AS
 INSERT INTO NodoRed
				(id,
				 nombre,
				 estado)
	VALUES      (@id,
				 @nombre,
				 @estado)
GO

-- BORRAR_
CREATE PROCEDURE BORRAR_NODORED
@id INT, @nombre VARCHAR(50) = NULL, @estado VARCHAR(50) = NULL
AS
	DELETE FROM NodoRed
	WHERE id = @id
GO


-- OBTENER_TODOS_
CREATE PROCEDURE OBTENER_TODOS_NODOSRED
AS
	SELECT id, nombre, estado from NodoRed
GO
	
-- OBTENER_POR_ID_
 CREATE PROCEDURE OBTENER_POR_ID_NODOSRED
@id INT, @nombre VARCHAR(50) = NULL, @estado VARCHAR(50) = NULL
AS
	SELECT id, nombre, estado from NodoRed
	WHERE id = @id
	GO

-- ACTUALIZAR_
 CREATE PROCEDURE ACTUALIZAR_NODORED
@id INT, @nombre VARCHAR(50), @estado VARCHAR(50) = NULL
AS
	UPDATE NodoRed
	SET    nombre = @nombre, estado = @estado
	WHERE id = @id
Go

-- OBTENER_MAX_ID_
CREATE PROCEDURE OBTENER_MAX_ID_NODOSRED
AS
	SELECT MAX(id) as id from NodoRed
GO















-- CREAR_
-- BORRAR_
-- OBTENER_TODOS_
-- OBTENER_POR_ID_
-- ACTUALIZAR_
-- OBTENER_MAX_ID_