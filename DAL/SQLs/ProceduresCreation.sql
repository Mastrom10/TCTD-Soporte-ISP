
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