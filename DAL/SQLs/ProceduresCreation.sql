
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



-- CREAR_SERVICEPLAN
CREATE PROCEDURE CREAR_SERVICEPLAN
@id INT, @descripcion VARCHAR(200)
AS
 INSERT INTO ServicePlan
				(id,
				 descripcion)
	VALUES      (@id,
				 @descripcion)
				Go

-- BORRAR_SERVICEPLAN
CREATE PROCEDURE BORRAR_SERVICEPLAN
@id INT, @descripcion VARCHAR(200) = NULL
AS
	DELETE FROM ServicePlan
	WHERE id = @id
	GO
	
-- OBTENER_TODOS_SERVICEPLAN
CREATE PROCEDURE OBTENER_TODOS_SERVICEPLAN
AS
	SELECT id, descripcion from ServicePlan
	GO
-- OBTENER_POR_ID_SERVICEPLAN
CREATE PROCEDURE OBTENER_POR_ID_SERVICEPLAN
@id INT, @descripcion VARCHAR(200) = NULL
AS
	SELECT id, descripcion from ServicePlan
	WHERE id = @id
	GO
	
-- ACTUALIZAR_SERVICEPLAN
CREATE PROCEDURE ACTUALIZAR_SERVICEPLAN
@id INT, @descripcion VARCHAR(200)
AS
	UPDATE ServicePlan
	SET    descripcion = @descripcion
	WHERE id = @id
	GO
	
-- OBTENER_MAX_ID_SERVICEPLAN
CREATE PROCEDURE OBTENER_MAX_ID_SERVICEPLAN
AS
	SELECT MAX(id) as id from ServicePlan
	GO
	


-- CREAR_DISPOSITIVO
CREATE PROCEDURE CREAR_DISPOSITIVO
@id INT, @tipo VARCHAR(50) = NULL, @macAdress VARCHAR(50), @nroserie VARCHAR(50) = NULL
AS
 INSERT INTO Dispositivo
				(id,
				 tipo,
				 macAdress,
				 nroserie)
	VALUES      (@id,
				 @tipo,
				 @macAdress,
				 @nroserie)
				Go


-- BORRAR_DISPOSITIVO
CREATE PROCEDURE BORRAR_DISPOSITIVO
@id INT, @tipo VARCHAR(50) = NULL, @macAdress VARCHAR(50) = NULL, @nroserie VARCHAR(50) = NULL
AS
	DELETE FROM Dispositivo
	WHERE id = @id
	GO

	
-- OBTENER_TODOS_DISPOSITIVO
CREATE PROCEDURE OBTENER_TODOS_DISPOSITIVO
 AS
	SELECT id, tipo, macAdress, nroserie from Dispositivo
	GO
	



-- OBTENER_POR_ID_DISPOSITIVO
 CREATE PROCEDURE OBTENER_POR_ID_DISPOSITIVO
@id INT, @tipo VARCHAR(50) = NULL, @macAdress VARCHAR(50) = NULL, @nroserie VARCHAR(50) = NULL
AS
	SELECT id, tipo, macAdress, nroserie from Dispositivo
	WHERE id = @id
	GO

-- OBTENER_MAX_ID_DISPOSITIVO
CREATE PROCEDURE OBTENER_MAX_ID_DISPOSITIVO
AS
	SELECT MAX(id) as id from Dispositivo
	GO

	
-- ACTUALIZAR_DISPOSITIVO
CREATE PROCEDURE ACTUALIZAR_DISPOSITIVO
@id INT, @tipo VARCHAR(50) = NULL, @macAdress VARCHAR(50), @nroserie VARCHAR(50) = NULL
AS
	UPDATE Dispositivo
	SET    tipo = @tipo, macAdress = @macAdress, nroserie = @nroserie
	WHERE id = @id
	GO

-- OBTENER_DISPOSITIVOS_POR_SERVICIO
CREATE PROCEDURE OBTENER_DISPOSITIVOS_POR_SERVICIO
@id INT
AS
	SELECT id, tipo, macAdress, nroserie from Dispositivo
	WHERE id IN (SELECT FK_id_dispositivo FROM Servicio_x_Dispositivo WHERE FK_id_servicio = @id)
GO

--AGREGAR_DISPOSITIVO_A_SERVICIO
CREATE PROCEDURE AGREGAR_DISPOSITIVO_A_SERVICIO
@idDispositivo INT, @idServicio INT
AS
	INSERT INTO Servicio_x_Dispositivo
				(FK_id_dispositivo,
				 FK_id_servicio)
	VALUES      (@idDispositivo,
				 @idServicio)
Go

-- QUITAR_DISPOSITIVO_A_SERVICIO
CREATE PROCEDURE QUITAR_DISPOSITIVO_A_SERVICIO
@idDispositivo INT, @idServicio INT
AS
	DELETE FROM Servicio_x_Dispositivo
	WHERE FK_id_dispositivo = @idDispositivo AND FK_id_servicio = @idServicio
GO
	

-- OBTENER_UNASSIGNED_DISPOSITIVO
CREATE PROCEDURE OBTENER_UNASSIGNED_DISPOSITIVO
as
SELECT id, tipo, macAdress, nroserie from Dispositivo
	WHERE id NOT IN (SELECT FK_id_dispositivo FROM Servicio_x_Dispositivo)
	GO




-- CREAR_DIRECCION
CREATE PROCEDURE CREAR_DIRECCION
@id INT,
@calle VARCHAR(200),
@altura VARCHAR(50),
@codigoPostal VARCHAR(50) = NULL,
@localidad VARCHAR(50) = NULL,
@provincia VARCHAR(50) = NULL,
@depto VARCHAR(50) = NULL,
@piso VARCHAR(50) = NULL,
@FK_id_nodoRed INT = NULL
AS
 INSERT INTO Direccion
				(id,
				 calle,
				 altura,
				 codigoPostal,
				 localidad,
				 provincia,
				 depto,
				 piso,
				 FK_id_nodoRed)
	VALUES      (@id,
				 @calle,
				 @altura,
				 @codigoPostal,
				 @localidad,
				 @provincia,
				 @depto,
				 @piso,
				 @FK_id_nodoRed)
Go

-- BORRAR_DIRECCION
CREATE PROCEDURE BORRAR_DIRECCION
@id INT,
@calle VARCHAR(200) = NULL,
@altura VARCHAR(50) = NULL,
@codigoPostal VARCHAR(50) = NULL,
@localidad VARCHAR(50) = NULL,
@provincia VARCHAR(50) = NULL,
@depto VARCHAR(50) = NULL,
@piso VARCHAR(50) = NULL,
@FK_id_nodoRed INT = NULL
AS
	DELETE FROM Direccion
	WHERE id = @id
GO


-- OBTENER_TODOS_DIRECCION
CREATE PROCEDURE OBTENER_TODOS_DIRECCION
AS
	SELECT id, calle, altura, codigoPostal, localidad, provincia, depto, piso, FK_id_nodoRed from Direccion
GO


-- OBTENER_POR_ID_DIRECCION
CREATE PROCEDURE OBTENER_POR_ID_DIRECCION
@id INT,
@calle VARCHAR(200) = NULL,
@altura VARCHAR(50) = NULL,
@codigoPostal VARCHAR(50) = NULL,
@localidad VARCHAR(50) = NULL,
@provincia VARCHAR(50) = NULL,
@depto VARCHAR(50) = NULL,
@piso VARCHAR(50) = NULL,
@FK_id_nodoRed INT = NULL
AS
	SELECT id, calle, altura, codigoPostal, localidad, provincia, depto, piso, FK_id_nodoRed from Direccion
	WHERE id = @id
	GO
	
	


-- OBTENER_MAX_ID_DIRECCION
CREATE PROCEDURE OBTENER_MAX_ID_DIRECCION
AS
	SELECT MAX(id) as id from Direccion
	GO


-- ACTUALIZAR_DIRECCION
CREATE PROCEDURE ACTUALIZAR_DIRECCION
@id INT,
@calle VARCHAR(200),
@altura VARCHAR(50),
@codigoPostal VARCHAR(50) = NULL,
@localidad VARCHAR(50) = NULL,
@provincia VARCHAR(50) = NULL,
@depto VARCHAR(50) = NULL,
@piso VARCHAR(50) = NULL,
@FK_id_nodoRed INT = NULL
AS 
UPDATE Direccion
SET    calle = @calle, altura = @altura, codigoPostal = @codigoPostal, localidad = @localidad, provincia = @provincia, depto = @depto, piso = @piso, FK_id_nodoRed = @FK_id_nodoRed
WHERE id = @id
GO


-- OBTENER_DIRECCION_POR_ID_CLIENTE
CREATE PROCEDURE OBTENER_DIRECCION_POR_ID_CLIENTE
@id INT
AS
	SELECT Direccion.id as id, calle, altura, codigoPostal, localidad, provincia, depto, piso, FK_id_nodoRed
	FROM Direccion
	INNER JOIN Cliente ON Direccion.id = Cliente.FK_id_direccion
	WHERE Cliente.id = @id
GO
	
	
	


-- CREAR_SERVICIO
CREATE PROCEDURE CREAR_SERVICIO
@id INT, @estado VARCHAR(50), @FK_id_ServicePlan INT
AS
	INSERT INTO Servicio
				(id,
				 estado,
				 FK_id_ServicePlan)
	VALUES      (@id,
				 @estado,
				 @FK_id_ServicePlan)
GO

-- BORRAR_SERVICIO
CREATE PROCEDURE BORRAR_SERVICIO
@id INT, @estado VARCHAR(50) = NULL, @FK_id_ServicePlan INT = NULL
AS
	DELETE FROM Servicio
	WHERE id = @id
	GO


-- OBTENER_TODOS_SERVICIO
CREATE PROCEDURE OBTENER_TODOS_SERVICIO
AS
	SELECT id, estado, FK_id_ServicePlan from Servicio
GO


-- OBTENER_POR_ID_SERVICIO
CREATE PROCEDURE OBTENER_POR_ID_SERVICIO
@id INT, @estado VARCHAR(50) = NULL, @FK_id_ServicePlan INT = NULL
AS
	SELECT id, estado, FK_id_ServicePlan from Servicio
	WHERE id = @id
GO


-- OBTENER_MAX_ID_SERVICIO
CREATE PROCEDURE OBTENER_MAX_ID_SERVICIO
 AS
	SELECT MAX(id) as id from Servicio
GO
	


-- ACTUALIZAR_SERVICIO
CREATE PROCEDURE ACTUALIZAR_SERVICIO
@id INT, @estado VARCHAR(50) = NULL, @FK_id_ServicePlan INT = NULL
AS
	UPDATE Servicio
	SET    estado = @estado, FK_id_ServicePlan = @FK_id_ServicePlan
	WHERE id = @id
GO

-- OBTENER_SERVICIO_POR_CLIENTE
CREATE PROCEDURE OBTENER_SERVICIO_POR_CLIENTE
@id INT
AS
	SELECT Servicio.id as id, estado, FK_id_ServicePlan
	FROM Servicio
	INNER JOIN Cliente ON Servicio.id = Cliente.FK_id_servicio
	WHERE Cliente.id = @id
GO

-- CREAR_CLIENTE
CREATE PROCEDURE CREAR_CLIENTE
@id INT, @nombre VARCHAR(50) = NULL, @apellido VARCHAR(50)  = NULL, @dni VARCHAR(50)  = NULL, @telefonoPrincipal VARCHAR(50)  = NULL, @telefonoSecundario VARCHAR(50)  = NULL, @email VARCHAR(50)  = NULL, @FK_id_direccion INT  = NULL, @FK_id_servicio INT  = NULL, @fechaNacimiento DATE  = NULL
AS
INSERT INTO Cliente
				(id,
				 nombre,
				 apellido,
				 dni,
				 telefonoPrincipal,
				 telefonoSecundario,
				 email,
				 FK_id_direccion,
				 FK_id_servicio,
				 fechaNacimiento
				)
VALUES      (@id,
			 @nombre,
			 @apellido,
			 @dni,
			 @telefonoPrincipal,
			 @telefonoSecundario,
			 @email,
			 @FK_id_direccion,
			 @FK_id_servicio,
			 @fechaNacimiento)
GO
				


-- BORRAR_CLIENTE
 CREATE PROCEDURE BORRAR_CLIENTE
 @id INT, @nombre VARCHAR(50) = NULL, @apellido VARCHAR(50)  = NULL, @dni VARCHAR(50)  = NULL, @telefonoPrincipal VARCHAR(50)  = NULL, @telefonoSecundario VARCHAR(50)  = NULL, @email VARCHAR(50)  = NULL, @FK_id_direccion INT  = NULL, @FK_id_servicio INT  = NULL, @fechaNacimiento DATE  = NULL
AS
DELETE FROM Cliente
WHERE id = @id
GO

-- OBTENER_TODOS_CLIENTE
CREATE PROCEDURE OBTENER_TODOS_CLIENTE
AS
	SELECT id, nombre, apellido, dni, telefonoPrincipal, telefonoSecundario, email, FK_id_direccion, FK_id_servicio, fechaNacimiento
	FROM Cliente
	GO
	


-- OBTENER_POR_ID_CLIENTE
CREATE PROCEDURE OBTENER_POR_ID_CLIENTE
@id INT, @nombre VARCHAR(50) = NULL, @apellido VARCHAR(50)  = NULL, @dni VARCHAR(50)  = NULL, @telefonoPrincipal VARCHAR(50)  = NULL, @telefonoSecundario VARCHAR(50)  = NULL, @email VARCHAR(50)  = NULL, @FK_id_direccion INT  = NULL, @FK_id_servicio INT  = NULL, @fechaNacimiento DATE  = NULL
AS
	SELECT id, nombre, apellido, dni, telefonoPrincipal, telefonoSecundario, email, FK_id_direccion, FK_id_servicio, fechaNacimiento
	FROM Cliente
	WHERE id = @id
	GO

-- OBTENER_CLIENTE_POR_DNI
CREATE PROCEDURE OBTENER_CLIENTE_POR_DNI
@cadena VARCHAR(50)
AS
	SELECT id, nombre, apellido, dni, telefonoPrincipal, telefonoSecundario, email, FK_id_direccion, FK_id_servicio, fechaNacimiento
	FROM Cliente
	WHERE dni = @cadena
	GO
	


-- OBTENER_MAX_ID_CLIENTE
	CREATE PROCEDURE OBTENER_MAX_ID_CLIENTE
 AS
	SELECT MAX(id) as id from Cliente
	GO
	


-- ACTUALIZAR_CLIENTE
CREATE PROCEDURE ACTUALIZAR_CLIENTE
@id INT, @nombre VARCHAR(50) = NULL, @apellido VARCHAR(50)  = NULL, @dni VARCHAR(50)  = NULL, @telefonoPrincipal VARCHAR(50)  = NULL, @telefonoSecundario VARCHAR(50)  = NULL, @email VARCHAR(50)  = NULL, @FK_id_direccion INT  = NULL, @FK_id_servicio INT  = NULL, @fechaNacimiento DATE  = NULL
AS
	UPDATE Cliente
	SET    nombre = @nombre, apellido = @apellido, dni = @dni, telefonoPrincipal = @telefonoPrincipal, telefonoSecundario = @telefonoSecundario, email = @email, FK_id_direccion = @FK_id_direccion, FK_id_servicio = @FK_id_servicio, fechaNacimiento = @fechaNacimiento
	WHERE id = @id
	GO

	






-- CREAR_TICKET
CREATE PROCEDURE CREAR_TICKET
@id INT, @titulo VARCHAR(200), @descripcion VARCHAR(2000) = NULL, @estado VARCHAR(50), @prioridad VARCHAR(50), @fechaCreacion DATETIME = NULL,
@fechaUltimaModificacion DATETIME = NULL, @fechaCierre DATETIME = NULL, @FK_id_cliente INT, @FK_id_empleado INT
AS
INSERT INTO Ticket
				(id,
				 titulo,
				 descripcion,
				 estado,
				 prioridad,
				 fechaCreacion,
				 fechaUltimaModificacion,
				 fechaCierre,
				 FK_id_cliente,
				 FK_id_empleado
				) 
 VALUES      (@id,
			 @titulo,
			 @descripcion,
			 @estado,
			 @prioridad,
			 @fechaCreacion,
			 @fechaUltimaModificacion,
			 @fechaCierre,
			 @FK_id_cliente,
			 @FK_id_empleado)
 GO





-- BORRAR_TICKET
CREATE PROCEDURE BORRAR_TICKET
@id INT, @titulo VARCHAR(200) = NULL, @descripcion VARCHAR(2000) = NULL, 
@estado VARCHAR(50) = NULL, @prioridad VARCHAR(50) = NULL, @fechaCreacion DATETIME = NULL,
@fechaUltimaModificacion DATETIME = NULL, @fechaCierre DATETIME = NULL, 
@FK_id_cliente INT = NULL, @FK_id_empleado INT = NULL
AS
DELETE FROM Ticket
WHERE id = @id
GO

-- OBTENER_TODOS_TICKET
CREATE PROCEDURE OBTENER_TODOS_TICKET
AS
	SELECT id, titulo, descripcion, estado, prioridad, fechaCreacion, fechaUltimaModificacion, fechaCierre, FK_id_cliente, FK_id_empleado
	FROM Ticket
	GO
	
-- OBTENER_POR_ID_TICKET
CREATE PROCEDURE OBTENER_POR_ID_TICKET
@id INT, @titulo VARCHAR(200) = NULL, @descripcion VARCHAR(2000) = NULL,
@estado VARCHAR(50) = NULL, @prioridad VARCHAR(50) = NULL, @fechaCreacion DATETIME = NULL,
@fechaUltimaModificacion DATETIME = NULL, @fechaCierre DATETIME = NULL,
@FK_id_cliente INT = NULL, @FK_id_empleado INT = NULL
AS
	SELECT id, titulo, descripcion, estado, prioridad, fechaCreacion, fechaUltimaModificacion, fechaCierre, FK_id_cliente, FK_id_empleado
	FROM Ticket
	WHERE id = @id
	GO
	
-- OBTENER_MAX_ID_TICKET
CREATE PROCEDURE OBTENER_MAX_ID_TICKET
AS
	SELECT MAX(id) as id from Ticket
	GO
	
-- ACTUALIZAR_TICKET
CREATE PROCEDURE ACTUALIZAR_TICKET
@id INT, @titulo VARCHAR(200) = NULL, @descripcion VARCHAR(2000) = NULL,
@estado VARCHAR(50) = NULL, @prioridad VARCHAR(50) = NULL, @fechaCreacion DATETIME = NULL,
@fechaUltimaModificacion DATETIME = NULL, @fechaCierre DATETIME = NULL,
@FK_id_cliente INT = NULL, @FK_id_empleado INT = NULL
AS
	UPDATE Ticket
	SET    titulo = @titulo, descripcion = @descripcion, estado = @estado, prioridad = @prioridad, fechaCreacion = @fechaCreacion, fechaUltimaModificacion = @fechaUltimaModificacion, fechaCierre = @fechaCierre, FK_id_cliente = @FK_id_cliente, FK_id_empleado = @FK_id_empleado
	WHERE id = @id
	GO

-- OBTENER_TICKET_POR_ID_CLIENTE
CREATE PROCEDURE OBTENER_TICKET_POR_ID_CLIENTE
@id INT
AS
	SELECT id, titulo, descripcion, estado, prioridad, fechaCreacion, fechaUltimaModificacion, fechaCierre, FK_id_cliente, FK_id_empleado
	FROM Ticket
	WHERE FK_id_cliente = @id
	GO

 -- OBTENER_TICKET_POR_ID_EMPLEADO
CREATE PROCEDURE OBTENER_TICKET_POR_ID_EMPLEADO
@id INT
AS
	SELECT id, titulo, descripcion, estado, prioridad, fechaCreacion, fechaUltimaModificacion, fechaCierre, FK_id_cliente, FK_id_empleado
	FROM Ticket
	WHERE FK_id_empleado = @id
	GO

	-- OBTENER_TICKET_POR_ESTADO
	CREATE PROCEDURE OBTENER_TICKET_POR_ESTADO
	@texto VARCHAR(50)
	AS
		SELECT id, titulo, descripcion, estado, prioridad, fechaCreacion, fechaUltimaModificacion, fechaCierre, FK_id_cliente, FK_id_empleado
		FROM Ticket
		WHERE estado = @texto
	GO



	USE [SoporteISP]
GO



/*
	[id] [int] NOT NULL,
	[accion] [varchar](200) NOT NULL,
	[motivo] [varchar](200) NULL,
	[observacion] [varchar](2000) NULL,
	[fecha] [datetime] NOT NULL,
	[FK_id_empleado] [int] NOT NULL,
	[FK_id_ticket] [int] NOT NULL,
*/

-- CREAR_INTERACCION
CREATE PROCEDURE CREAR_INTERACCION
@id INT, @accion VARCHAR(200) = NULL, 
@motivo VARCHAR(200) = NULL, @observacion VARCHAR(2000) = NULL, 
@fecha DATETIME = NULL, @FK_id_empleado INT = NULL, @FK_id_ticket INT = NULL
AS
	INSERT INTO Interaccion
	(id, accion, motivo, observacion, fecha, FK_id_empleado, FK_id_ticket)
	VALUES
	(@id, @accion, @motivo, @observacion, @fecha, @FK_id_empleado, @FK_id_ticket)
	GO
	
-- BORRAR_INTERACCION
CREATE PROCEDURE BORRAR_INTERACCION
@id INT
AS
	DELETE FROM Interaccion
	WHERE id = @id
	GO
	
-- OBTENER_TODOS_INTERACCION
CREATE PROCEDURE OBTENER_TODOS_INTERACCION
AS
	SELECT id, accion, motivo, observacion, fecha, FK_id_empleado, FK_id_ticket
	FROM Interaccion
	GO
-- OBTENER_POR_ID_INTERACCION
CREATE PROCEDURE OBTENER_POR_ID_INTERACCION
@id INT
AS
	SELECT id, accion, motivo, observacion, fecha, FK_id_empleado, FK_id_ticket
	FROM Interaccion
	WHERE id = @id
	GO
-- OBTENER_MAX_ID_INTERACCION
CREATE PROCEDURE OBTENER_MAX_ID_INTERACCION
AS
	SELECT MAX(id) as id from Interaccion
	GO
	
-- ACTUALIZAR_INTERACCION
CREATE PROCEDURE ACTUALIZAR_INTERACCION
@id INT, @accion VARCHAR(200) = NULL, @motivo VARCHAR(200) = NULL, @observacion VARCHAR(2000) = NULL, @fecha DATETIME = NULL, @FK_id_empleado INT = NULL, @FK_id_ticket INT = NULL
AS
	UPDATE Interaccion
	SET    accion = @accion, motivo = @motivo, observacion = @observacion, fecha = @fecha, FK_id_empleado = @FK_id_empleado, FK_id_ticket = @FK_id_ticket
	WHERE id = @id
	GO
	
-- OBTENER_INTERACCION_POR_ID_TICKET
CREATE PROCEDURE OBTENER_INTERACCION_POR_ID_TICKET
@id INT
AS
	SELECT id, accion, motivo, observacion, fecha, FK_id_empleado, FK_id_ticket
	FROM Interaccion
	WHERE FK_id_ticket = @id
	GO

	-- OBTENER_POR_ID_EMPLEADO
	CREATE PROCEDURE OBTENER_POR_ID_EMPLEADO
	@id INT
	AS
		SELECT id, accion, motivo, observacion, fecha, FK_id_empleado, FK_id_ticket
		FROM Interaccion
		WHERE FK_id_empleado = @id

		GO
		














-- CREAR_INTERACCION
-- BORRAR_
-- OBTENER_TODOS_
-- OBTENER_POR_ID_
-- OBTENER_MAX_ID_
-- ACTUALIZAR_