DROP DATABASE IF EXISTS PYCSLosrapidos;
CREATE DATABASE PYCSLosrapidos;

GO

 USE PYCSLosrapidos;

 CREATE TABLE [ESTADO] (
  [ID_ESTADO] INT IDENTITY(1,1) NOT NULL,
  [NOMBRE_ESTADO] VARCHAR(10) NOT NULL,
  CONSTRAINT [PK_ESTADO] PRIMARY KEY CLUSTERED (ID_ESTADO)
);

INSERT INTO ESTADO (NOMBRE_ESTADO)
VALUES('ACTIVO'), ('INACTIVO'); 
SET IDENTITY_INSERT ESTADO ON;
INSERT INTO ESTADO(ID_ESTADO, NOMBRE_ESTADO) values(0, 'ELIMINADO'); 
SET IDENTITY_INSERT ESTADO OFF;

CREATE TABLE [HOSPITAL] (
  [ID_HOSPITAL] INT IDENTITY(100,1) NOT NULL,
  [NOMBRE_HOSPITAL] VARCHAR(45) NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ID_ESTADO] INT NOT NULL DEFAULT 1,
  CONSTRAINT [PK_HOSPITAL] PRIMARY KEY CLUSTERED (ID_HOSPITAL),
  Constraint [FK_H_IDESTADO] foreign key(ID_ESTADO) references ESTADO (ID_ESTADO)
);

INSERT INTO HOSPITAL(NOMBRE_HOSPITAL)
VALUES('Hospital del niño'), ('Omnihospital'), ('Torre Médica'), ('Hospital Universitario de Guayaquil'), ('Clínica Kennedy'),
('Hospital Solca'), ('Hospital Alcívar'), ('Clínica San Diego'), ('Hospital Luis Vernaza'), ('Clínica San Marcos'), ('Hospital de la mujer');


CREATE TABLE PERSONA(
	[ID_PERSONA] INT IDENTITY(100,1) NOT NULL,
	[CEDULA] VARCHAR(10) NOT NULL,
	[NOMBRE_1] VARCHAR(20) NOT NULL,
	[NOMBRE_2] VARCHAR(20) NOT NULL,
	[APELLIDO_1] VARCHAR(20) NOT NULL,
	[APELLIDO_2] VARCHAR(20) NOT NULL,
	[SEXO] VARCHAR(20) NOT NULL,
	[FECHA_NAC] DATE NOT NULL,
	[TELEFONO] VARCHAR(10) NOT NULL,
	[FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
	CONSTRAINT [PK_PERSONA] PRIMARY KEY CLUSTERED (ID_PERSONA)
);
ALTER TABLE PERSONA
ADD CONSTRAINT UC_PERSONA_CEDULA UNIQUE (CEDULA);

CREATE TABLE [USUARIO] (
  [ID_USUARIO] INT IDENTITY(100,1) NOT NULL,
  [NOMBRE_USUARIO] VARCHAR(20) NOT NULL,
  [CORREO] VARCHAR(75) NOT NULL,
  [CONTRASENIA] VARCHAR(20) NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ID_ESTADO] INT NOT NULL DEFAULT 1,
  CONSTRAINT [PK_USUARIO] PRIMARY KEY CLUSTERED (ID_USUARIO),
  Constraint [FK_U_IDESTADO] foreign key(ID_ESTADO) references ESTADO (ID_ESTADO)
);
ALTER TABLE USUARIO
ADD CONSTRAINT UC_USUARIO_NOMUSUARIO UNIQUE (NOMBRE_USUARIO);
ALTER TABLE USUARIO
ADD CONSTRAINT UC_USUARIO_CORREO UNIQUE (CORREO);


CREATE TABLE [GERENTE] (
  [ID_GERENTE] INT IDENTITY(100,1) NOT NULL,
  [ID_PERSONA] INT NOT NULL,
  [ID_USUARIO] INT NOT NULL,
  [FECHA_CONTRATO] DATE NOT NULL,
  [FECHA_REGISTRO ] DATETIME NOT NULL DEFAULT GETDATE(),
  [ID_ESTADO] INT NOT NULL DEFAULT 1,
  CONSTRAINT [PK_GERENTE] PRIMARY KEY CLUSTERED (ID_GERENTE),
  Constraint [FK_G_IDPERSONA] foreign key(ID_PERSONA) references PERSONA (ID_PERSONA),
  Constraint [FK_G_IDUSUARIO] foreign key(ID_USUARIO) references USUARIO (ID_USUARIO),
  Constraint [FK_G_IDESTADO] foreign key(ID_ESTADO) references ESTADO (ID_ESTADO)
);

CREATE TABLE [FACTURA_CABECERA] (
  [ID_FACTURA_CABECERA] INT IDENTITY(100,1) NOT NULL,
  [TOTAL] DECIMAL(6,2) NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ID_ESTADO] INT NOT NULL DEFAULT 1,
  CONSTRAINT [PK_FACTURA_CABECERA] PRIMARY KEY CLUSTERED (ID_FACTURA_CABECERA),
  Constraint [FK_FC_IDESTADO] foreign key(ID_ESTADO) references ESTADO (ID_ESTADO)
);

CREATE TABLE [CLIENTE] (
  [ID_CLIENTE] INT IDENTITY(100,1) NOT NULL,
  [ID_HOSPITAL] INT NOT NULL,
  [ID_PERSONA] INT NOT NULL,
  [ID_USUARIO] INT NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ID_ESTADO] INT NOT NULL DEFAULT 1,
  CONSTRAINT [PK_CLIENTE] PRIMARY KEY CLUSTERED (ID_CLIENTE),
  Constraint [FK_CL_IDPERSONA] foreign key(ID_PERSONA) references PERSONA (ID_PERSONA),
  Constraint [FK_CL_IDHOSPITAL] foreign key(ID_HOSPITAL) references HOSPITAL (ID_HOSPITAL),
  Constraint [FK_CL_IDUSUARIO] foreign key(ID_USUARIO) references USUARIO (ID_USUARIO),  
  Constraint [FK_CL_IDESTADO] foreign key(ID_ESTADO) references ESTADO (ID_ESTADO)
);

CREATE TABLE [TIPO_AMBULANCIA] (
  [ID_TIPO_AMBULANCIA] INT IDENTITY(1,1) NOT NULL,
  [NOMBRE_TIPO_AMBULANCIA] VARCHAR(45) NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ID_ESTADO] INT NOT NULL DEFAULT 1,
  CONSTRAINT [PK_TIPO_AMBULANCIA] PRIMARY KEY CLUSTERED (ID_TIPO_AMBULANCIA),
  Constraint [FK_TA_IDESTADO] foreign key(ID_ESTADO) references ESTADO (ID_ESTADO)
);

INSERT INTO TIPO_AMBULANCIA (NOMBRE_TIPO_AMBULANCIA)
VALUES('TIPO I'), ('TIPO II'), ('TIPO III');

CREATE TABLE [PETICION] (
  [ID_PETICION] INT IDENTITY(100,1) NOT NULL,
  [ID_CLIENTE] INT NOT NULL,
  [ID_TIPO_AMBULANCIA] INT NOT NULL,
  [N_AMBULANCIAS] INT NOT NULL,
  [PUNTO_ORIGEN] VARCHAR(45) NOT NULL,
  [PUNTO_DESTINO] VARCHAR(45) NOT NULL,
  [CONDICION] VARCHAR(15) NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ID_ESTADO] INT NOT NULL DEFAULT 1,
  CONSTRAINT [PK_PETICION] PRIMARY KEY CLUSTERED (ID_PETICION),
  Constraint [FK_P_IDCLIENTE] foreign key(ID_CLIENTE) references CLIENTE (ID_CLIENTE),
  Constraint [FK_P_TIPO_AMBULANCIA] foreign key(ID_TIPO_AMBULANCIA) references TIPO_AMBULANCIA (ID_TIPO_AMBULANCIA),
  Constraint [FK_P_IDESTADO] foreign key(ID_ESTADO) references ESTADO (ID_ESTADO)
);

CREATE TABLE [SECRETARIA] (
  [ID_SECRETARIA] INT IDENTITY(100,1) NOT NULL,
  [ID_PERSONA] INT NOT NULL,
  [ID_USUARIO] INT NOT NULL,
  [FECHA_CONTRATO] DATE NOT NULL,
  [FECHA_REGISTRO ] DATETIME NOT NULL DEFAULT GETDATE(),
  [ID_ESTADO] INT NOT NULL DEFAULT 1,
  CONSTRAINT [PK_SECRETARIA] PRIMARY KEY CLUSTERED (ID_SECRETARIA),
  Constraint [FK_S_IDPERSONA] foreign key(ID_PERSONA) references PERSONA (ID_PERSONA),
  Constraint [FK_S_IDUSUARIO] foreign key(ID_USUARIO) references USUARIO (ID_USUARIO),
  Constraint [FK_S_IDESTADO] foreign key(ID_ESTADO) references ESTADO (ID_ESTADO)
);

CREATE TABLE [DISPONIBILIDAD] (
  [ID_DISPONIBILIDAD] INT IDENTITY(1,1) NOT NULL,
  [NOMBRE_DISPONIBILIDAD] VARCHAR(15) NOT NULL,
  CONSTRAINT [PK_DISPONIBILIDAD] PRIMARY KEY CLUSTERED (ID_DISPONIBILIDAD)
);

INSERT INTO DISPONIBILIDAD (NOMBRE_DISPONIBILIDAD)
VALUES('DISPONIBLE'), ('NO DISPONIBLE'); 

CREATE TABLE [CONDUCTOR] (
  [ID_CONDUCTOR] INT IDENTITY(100,1) NOT NULL,
  [ID_PERSONA] INT NOT NULL,
  [FECHA_CONTRATO] DATE NOT NULL,
  [ID_DISPONIBILIDAD] INT NOT NULL DEFAULT 1,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ID_ESTADO] INT NOT NULL DEFAULT 1,
  CONSTRAINT [PK_CONDUCTOR] PRIMARY KEY CLUSTERED (ID_CONDUCTOR),
  Constraint [FK_CON_IDPERSONA] foreign key(ID_PERSONA) references PERSONA (ID_PERSONA),
  Constraint [FK_CON_IDDISPONIBILIDAD] foreign key(ID_DISPONIBILIDAD) references DISPONIBILIDAD (ID_DISPONIBILIDAD),
  Constraint [FK_CON_IDESTADO] foreign key(ID_ESTADO) references ESTADO (ID_ESTADO)
); 

CREATE TABLE [AMBULANCIA] (
  [ID_AMBULANCIA] INT IDENTITY(100,1) NOT NULL,
  [PLACA] VARCHAR(7) NOT NULL,
  [MODELO] VARCHAR(45) NOT NULL,
  [ID_TIPO_AMBULANCIA] INT NOT NULL,
  [CAPACIDAD] INT NOT NULL,
  [OBSERVACION] VARCHAR(45) NOT NULL,
  [ID_DISPONIBILIDAD] INT NOT NULL DEFAULT 1,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ID_ESTADO] INT NOT NULL DEFAULT 1,
  CONSTRAINT [PK_AMBULANCIA] PRIMARY KEY CLUSTERED (ID_AMBULANCIA),
  Constraint [FK_A_IDDISPONIBILIDAD] foreign key(ID_DISPONIBILIDAD) references DISPONIBILIDAD (ID_DISPONIBILIDAD),
  Constraint [FK_A_IDESTADO] foreign key(ID_ESTADO) references ESTADO (ID_ESTADO)
);

CREATE TABLE [FORMA_PAGO] (
  [ID_FORMA_PAGO] INT IDENTITY(1,1) NOT NULL,
  [NOMBRE_FORMA_PAGO] VARCHAR(50) NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ID_ESTADO] INT NOT NULL DEFAULT 1,
  CONSTRAINT [PK_FORMA_PAGO] PRIMARY KEY CLUSTERED (ID_FORMA_PAGO),
  Constraint [FK_FP_IDESTADO] foreign key(ID_ESTADO) references ESTADO (ID_ESTADO)
);

CREATE TABLE [BANCO] (
  [ID_BANCO] INT IDENTITY(1,1) NOT NULL,
  [NOMBRE_BANCO] VARCHAR(50) NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ID_ESTADO] INT NOT NULL DEFAULT 1,
  CONSTRAINT [PK_BANCO] PRIMARY KEY CLUSTERED (ID_BANCO),
  Constraint [FK_B_IDESTADO] foreign key(ID_ESTADO) references ESTADO (ID_ESTADO)
);

CREATE TABLE [FACTURA_DETALLE] (
  [ID_FACTURA_DETALLE] INT IDENTITY(100,1) NOT NULL,
  [ID_FACTURA_CABECERA] INT NOT NULL,
  [ID_PETICION] INT NOT NULL,
  [ID_FORMA_PAGO] INT NOT NULL,
  [ID_BANCO] INT NOT NULL,
  [VALOR_UNITARIO] DECIMAL(6,2) NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ID_ESTADO] INT NOT NULL DEFAULT 1,
  CONSTRAINT [PK_FACTURA_DETALLE] PRIMARY KEY CLUSTERED (ID_FACTURA_DETALLE),
  Constraint [FK_FD_FACTURA_CABECERA] foreign key(ID_FACTURA_CABECERA) references FACTURA_CABECERA (ID_FACTURA_CABECERA),
  Constraint [FK_FD_PETICION] foreign key(ID_PETICION) references PETICION (ID_PETICION),
  Constraint [FK_FD_FORMA_PAGO] foreign key(ID_FORMA_PAGO) references FORMA_PAGO (ID_FORMA_PAGO),
  Constraint [FK_FD_BANCO] foreign key(ID_BANCO) references BANCO (ID_BANCO),
  Constraint [FK_FD_IDESTADO] foreign key(ID_ESTADO) references ESTADO (ID_ESTADO)
);

CREATE TABLE [ASIGNACION_CABECERA] (
  [ID_ASIGNACION_CABECERA] INT IDENTITY(100,1) NOT NULL,
  [ID_PETICION] INT NOT NULL,
  [ID_SECRETARIA] INT NOT NULL,
  [CONDICION] VARCHAR(15) NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ID_ESTADO] INT NOT NULL DEFAULT 1,
  CONSTRAINT [PK_ASIGNACION_CABECERA] PRIMARY KEY CLUSTERED (ID_ASIGNACION_CABECERA),
  Constraint [FK_AC_PETICION] foreign key(ID_PETICION) references PETICION (ID_PETICION),
  Constraint [FK_AC_SECRETARIA] foreign key(ID_SECRETARIA) references SECRETARIA (ID_SECRETARIA),
  Constraint [FK_AC_IDESTADO] foreign key(ID_ESTADO) references ESTADO (ID_ESTADO)
);

CREATE TABLE [ASIGNACION_DETALLE] (
  [ID_ASIGNACION_DETALLE] INT IDENTITY(100,1) NOT NULL,
  [ID_ASIGNACION_CABECERA] INT NOT NULL,
  [ID_CONDUCTOR] INT NOT NULL,
  [ID_AMBULANCIA] INT NOT NULL,
  [FECHA_REGISTRO] DATETIME NOT NULL DEFAULT GETDATE(),
  [ID_ESTADO] INT NOT NULL DEFAULT 1,
  CONSTRAINT [PK_ASIGNACION_DETALLE] PRIMARY KEY CLUSTERED (ID_ASIGNACION_DETALLE),
  Constraint [FK_AD_ASIGNACION_CABECERA] foreign key(ID_ASIGNACION_CABECERA) references ASIGNACION_CABECERA (ID_ASIGNACION_CABECERA)
  ON UPDATE CASCADE
  ON DELETE CASCADE,
  Constraint [FK_AD_CONDUCTOR] foreign key(ID_CONDUCTOR) references CONDUCTOR (ID_CONDUCTOR),
  Constraint [FK_AD_AMBULANCIA] foreign key(ID_AMBULANCIA) references AMBULANCIA (ID_AMBULANCIA),
  Constraint [FK_AD_IDESTADO] foreign key(ID_ESTADO) references ESTADO (ID_ESTADO)
);

 CREATE TABLE [SERVIDOR_CORREO] (
  [ID_SERVIDOR_CORREO] INT IDENTITY(1,1) NOT NULL,
  [SENDER_MAIL] VARCHAR(100) NOT NULL,
  [PASSWORD] VARCHAR(100) NOT NULL,
  [HOST] VARCHAR(10) NOT NULL,
  [PORT] INT NOT NULL,
  [SSL] VARCHAR(10) NOT NULL,
  CONSTRAINT [PK_SERVIDOR_CORREO] PRIMARY KEY CLUSTERED (ID_SERVIDOR_CORREO)
);

INSERT INTO PERSONA (CEDULA,NOMBRE_1,NOMBRE_2,APELLIDO_1,APELLIDO_2,SEXO,FECHA_NAC,TELEFONO)
VALUES('0953581972', 'Alexander', 'Joel', 'Castro', 'Mora', 'Masculino', GETDATE(), '0992015890'); 

INSERT INTO PERSONA (CEDULA,NOMBRE_1,NOMBRE_2,APELLIDO_1,APELLIDO_2,SEXO,FECHA_NAC,TELEFONO)
VALUES('0914201033', 'Helen', 'Lisbeth', 'Bernal', 'Veliz', 'Femenino', GETDATE(), '0992015890'); 

INSERT INTO PERSONA (CEDULA,NOMBRE_1,NOMBRE_2,APELLIDO_1,APELLIDO_2,SEXO,FECHA_NAC,TELEFONO)
VALUES('0992015890', 'Renan', 'Oswaldo', 'Perez', 'Balladares', 'Masculino', GETDATE(), '0992015890'); 


INSERT INTO USUARIO(NOMBRE_USUARIO, CORREO, CONTRASENIA)
VALUES('Stefan45S','joel45alex@hotmail.es','12345');
INSERT INTO USUARIO(NOMBRE_USUARIO, CORREO, CONTRASENIA)
VALUES('Helen45B','helenlbernalv@hotmail.com','12345');

/*INSERT INTO USUARIO(USUARIO, CORREO, CONTRASENIA)
VALUES('Renan45P','renan.opb@hotmail.com','12345');*/

INSERT INTO HOSPITAL(NOMBRE_HOSPITAL)
VALUES('HOSPITAL MONTE BELLO');


INSERT INTO GERENTE(ID_PERSONA,ID_USUARIO, FECHA_CONTRATO)
VALUES(100,100, GETDATE());

INSERT INTO CLIENTE(ID_PERSONA,ID_USUARIO, ID_HOSPITAL)
VALUES(101,101,100);

INSERT INTO CONDUCTOR(ID_PERSONA, FECHA_CONTRATO)
VALUES(102,GETDATE());

INSERT INTO PERSONA (CEDULA,NOMBRE_1,NOMBRE_2,APELLIDO_1,APELLIDO_2,SEXO,FECHA_NAC,TELEFONO)
VALUES('0953124512', 'Billy', 'Joel', 'Alvear', 'Cisneros', 'Masculino', GETDATE(), '0992015890');

INSERT INTO USUARIO(NOMBRE_USUARIO, CORREO, CONTRASENIA)
VALUES('Blilly','alvearbilly@gmail.com','12345');

INSERT INTO SECRETARIA(ID_PERSONA, ID_USUARIO ,FECHA_CONTRATO)
VALUES(103,102,GETDATE());

INSERT INTO AMBULANCIA(PLACA, MODELO, ID_TIPO_AMBULANCIA, CAPACIDAD, OBSERVACION)
VALUES('ABC123', 'Mercedes-Benz', 2, 3, 'No tiene material de asistencia'),
('HYR432', 'Yutong', 1, 4, 'Dispone de camilla y botiquin'),
('MGT543', 'Ford', 2, 5, 'Tiene dos camillas');

-- -------------------- PROCEDIMIENTO PARA CONSULTAR PLACA --------------------------------------
GO
CREATE PROCEDURE sp_consultar_placa
	@placa varchar(7)
AS
SELECT * FROM AMBULANCIA WHERE PLACA = @placa AND ID_ESTADO = 1;
GO

-- -------------------- PROCEDIMIENTO PARA INSERTAR AMBULANCIAS --------------------------------------
GO
CREATE PROCEDURE sp_insertar_ambulancia
	@placa varchar(7),
	@modelo varchar(45),
	@tipo_ambulancia int,
	@capacidad int,
	@observacion varchar(45)
AS
INSERT INTO AMBULANCIA(
	PLACA, MODELO, ID_TIPO_AMBULANCIA, CAPACIDAD, 
	OBSERVACION
	)
	VALUES(
	@placa, 
	@modelo, 
	@tipo_ambulancia, 
	@capacidad, 
	@observacion
	)
GO
-- ------------------ PROCEDIMIENTO PARA CONSULTAR AMBULANCIAS --------------------------------------
CREATE PROCEDURE sp_consultar_ambulancias
	@opcionA int,
	@opcionB int,
	@dato varchar(45),
	@tipo_ambulancia int
AS
	declare @str_select varchar(max) = N'SELECT A.ID_AMBULANCIA as ID, D.NOMBRE_DISPONIBILIDAD as DISPONIBILIDAD, A.PLACA as PLACA, A.MODELO as MODELO,
	T.NOMBRE_TIPO_AMBULANCIA as TIPO_AMBULANCIA, A.CAPACIDAD as CAPACIDAD, A.OBSERVACION as OBSERVACION FROM AMBULANCIA A'
	declare @str_join varchar(max) = N' INNER JOIN DISPONIBILIDAD D ON A.ID_DISPONIBILIDAD = D.ID_DISPONIBILIDAD
							   INNER JOIN TIPO_AMBULANCIA T ON T.ID_TIPO_AMBULANCIA = A.ID_TIPO_AMBULANCIA'
	declare @str_where varchar(max)
	declare @str_and varchar(max)
	declare @str_consulta varchar(max)

BEGIN
	if(@opcionA = 1) 
		BEGIN
			set @str_where = N' WHERE A.ID_ESTADO = 1 AND A.PLACA LIKE UPPER(''%' + @dato + '%'')' 
		END
	else if(@opcionA = 2) 
		BEGIN
			set @str_where = N' WHERE A.ID_ESTADO = 1 AND A.MODELO LIKE ''%'+ @dato +'%''' 
		END

	if(@opcionB = 1)
		BEGIN
			set @str_and = N' AND A.ID_DISPONIBILIDAD = 1' 
		END
	else if(@opcionB = 2)
		BEGIN
			set @str_and = N' AND T.ID_TIPO_AMBULANCIA =  '+ CONVERT(varchar(1), @tipo_ambulancia) 
		END
	else if(@opcionB = 3)
		BEGIN
			set @str_and = N' AND T.ID_TIPO_AMBULANCIA = ' + CONVERT(varchar(1), @tipo_ambulancia) + ' AND A.ID_DISPONIBILIDAD = 1'
		END
	else set @str_and = ''
END

set @str_consulta = CONCAT(@str_select, @str_join, @str_where, @str_and)

PRINT @str_consulta
exec(@str_consulta)
GO	
-- -------------------------------------- PROCEDIMIENTO PARA LISTAR AMBULANCIAS -------------------------------
CREATE PROCEDURE sp_listar_ambulancias
AS
	SELECT A.ID_AMBULANCIA as ID, D.NOMBRE_DISPONIBILIDAD as DISPONIBILIDAD, A.PLACA as PLACA, A.MODELO as MODELO,
	T.NOMBRE_TIPO_AMBULANCIA as TIPO_AMBULANCIA, A.CAPACIDAD as CAPACIDAD, A.OBSERVACION as OBSERVACION FROM AMBULANCIA A
	INNER JOIN DISPONIBILIDAD D ON A.ID_DISPONIBILIDAD = D.ID_DISPONIBILIDAD
	INNER JOIN TIPO_AMBULANCIA T ON T.ID_TIPO_AMBULANCIA = A.ID_TIPO_AMBULANCIA
	WHERE A.ID_ESTADO = 1;
GO	

-- -------------------------------------- PROCEDIMIENTO PARA INSERTAR PETICIONES -----------------------------------------
CREATE PROCEDURE sp_insertar_peticion
	@id_cliente int,
	@id_tipo_ambulancia int,
	@n_ambulancias int,
	@punto_origen varchar(45),
	@punto_destino varchar(45),
	@condicion varchar(15)
AS
INSERT INTO PETICION(
	ID_CLIENTE, ID_TIPO_AMBULANCIA, N_AMBULANCIAS, PUNTO_ORIGEN, 
	PUNTO_DESTINO, CONDICION
	)
	VALUES(
	@id_cliente,
	@id_tipo_ambulancia,
	@n_ambulancias,
	@punto_origen,
	@punto_destino,
	@condicion
	)
GO

-- -------------------------------------- PROCEDIMIENTO PARA INSERTAR PERSONA

CREATE PROCEDURE sp_insertar_persona
	@cedula VARCHAR (10),
	@nombre_1 VARCHAR (20),
	@nombre_2 VARCHAR (20),
	@apellido_1 VARCHAR (20),
	@apellido_2 VARCHAR (20),
	@sexo VARCHAR(20),
	@fecha_nac DATETIME,
	@telefono VARCHAR (10)
	WITH ENCRYPTION
AS
	BEGIN
		IF NOT EXISTS (SELECT 1 FROM PERSONA WHERE CEDULA = @cedula) 
			BEGIN
				INSERT INTO PERSONA (CEDULA, NOMBRE_1, NOMBRE_2, APELLIDO_1, APELLIDO_2, SEXO, FECHA_NAC, TELEFONO)
				VALUES				(@cedula, @nombre_1, @nombre_2, @apellido_1, @apellido_2, @sexo, @fecha_nac, @telefono)
				-- obtener id_persona
				DECLARE @id_persona INT
				SELECT @id_persona = ID_PERSONA FROM PERSONA
				WHERE CEDULA = @cedula
				RETURN	@id_persona
			END;
		ELSE 
			BEGIN
				SET @id_persona = -1
				RETURN	@id_persona
			END;
	END;
GO

-- -------------------------------------- PROCEDIMIENTO PARA INSERTAR CONDUCTOR

CREATE PROCEDURE sp_insertar_conductor
	-- Datos_persona
	@cedula VARCHAR (10),
	@nombre_1 VARCHAR (20),
	@nombre_2 VARCHAR (20),
	@apellido_1 VARCHAR (20),
	@apellido_2 VARCHAR (20),
	@sexo VARCHAR(20),
	@fecha_nac DATETIME,
	@telefono VARCHAR (10),
	-- Datos_conductor
	@fecha_contrato DATETIME
	WITH ENCRYPTION
AS 
	BEGIN
		DECLARE @id_persona INT
		EXEC @id_persona = sp_insertar_persona @cedula, @nombre_1, @nombre_2, @apellido_1, @apellido_2, @sexo, @fecha_nac, @telefono
		IF (@id_persona != -1)
			BEGIN
				INSERT INTO CONDUCTOR	(ID_PERSONA, FECHA_CONTRATO)
				VALUES					(@id_persona, @fecha_contrato)
				-- obtener id_conductor
				DECLARE @id_conductor INT
				SELECT @id_conductor = ID_CONDUCTOR FROM CONDUCTOR
				WHERE ID_PERSONA = @id_persona
				RETURN	@id_conductor
			END;
		ELSE
			BEGIN
				SET @id_conductor = -1
				RETURN	@id_conductor
			END;
	END;
GO

-- -------------------------------------- PROCEDIMIENTO PARA INSERTAR USUARIO

CREATE PROCEDURE sp_insertar_usuario
	-- Datos_usuario
	@id_persona INT,
	@nombre_usuario varchar(20),
	@correo varchar(75),
	@contrasenia varchar(20)
	WITH ENCRYPTION
AS
	BEGIN
		IF (@id_persona != -1)
			BEGIN
				INSERT INTO USUARIO (NOMBRE_USUARIO, CORREO, CONTRASENIA)
				VALUES				(@nombre_usuario, @correo, @contrasenia)
				-- obtener id_usuario
				DECLARE @id_usuario INT
				SELECT @id_usuario = ID_USUARIO FROM USUARIO
				WHERE NOMBRE_USUARIO = @nombre_usuario
				RETURN	@id_usuario	
			END;
		ELSE
			BEGIN
				SET @id_usuario = -1
				RETURN	@id_usuario
			END;
	END;
GO

-- -------------------------------------- PROCEDIMIENTO PARA INSERTAR SECRETARIA

CREATE PROCEDURE sp_insertar_secretaria
	-- Datos_persona
	@cedula VARCHAR (10),
	@nombre_1 VARCHAR (20),
	@nombre_2 VARCHAR (20),
	@apellido_1 VARCHAR (20),
	@apellido_2 VARCHAR (20),
	@sexo VARCHAR(20),
	@fecha_nac DATETIME,
	@telefono VARCHAR (10),
	-- Datos_usuario
	@nombre_usuario VARCHAR (20),
	@correo VARCHAR (75),
	@contrasenia VARCHAR (20),
	-- Datos_secretaria
	@fecha_contrato DATE
	WITH ENCRYPTION
AS 
	BEGIN
		if NOT EXISTS (SELECT 1 FROM USUARIO WHERE NOMBRE_USUARIO = @nombre_usuario)
			BEGIN
				IF NOT EXISTS (SELECT 1 FROM USUARIO WHERE CORREO =	@correo)
					BEGIN
						DECLARE @id_persona INT
						DECLARE @id_usuario INT
						EXEC @id_persona = sp_insertar_persona @cedula, @nombre_1, @nombre_2, @apellido_1, @apellido_2, @sexo, @fecha_nac, @telefono
						EXEC @id_usuario = sp_insertar_usuario @id_persona, @nombre_usuario, @correo, @contrasenia
						IF (@id_persona != -1 AND @id_usuario != -1)
							BEGIN
								INSERT INTO SECRETARIA (ID_PERSONA, ID_USUARIO, FECHA_CONTRATO)
								VALUES					(@id_persona, @id_usuario, @fecha_contrato)
								-- obtener id_usuario
								DECLARE @id_secretaria INT
								SELECT @id_secretaria = ID_SECRETARIA FROM SECRETARIA
								WHERE ID_PERSONA = @id_persona AND ID_USUARIO = @id_usuario
								RETURN	@id_secretaria
							END;
						ELSE
							BEGIN
								SET @id_secretaria = -1
								RETURN	@id_secretaria
							END;
					END;
				ELSE
					BEGIN
						SET @id_secretaria = -1
						RETURN	@id_secretaria
					END;
			END;
		ELSE
			BEGIN
				SET @id_secretaria = -1
				RETURN	@id_secretaria
			END;
	END;
GO



---------------------------------- PROCEDIMIENTO PARA LISTAR AMBULANCIAS DISPONIBLES

CREATE PROCEDURE sp_listar_ambulancias_disponibles
AS
	SELECT A.ID_AMBULANCIA as CODIGO, D.NOMBRE_DISPONIBILIDAD as DISPONIBILIDAD, A.PLACA as PLACA, A.MODELO as MODELO,
	T.NOMBRE_TIPO_AMBULANCIA as TIPO_AMBULANCIA, A.CAPACIDAD as CAPACIDAD, A.OBSERVACION as OBSERVACION FROM AMBULANCIA A
	INNER JOIN DISPONIBILIDAD D ON A.ID_DISPONIBILIDAD = D.ID_DISPONIBILIDAD
	INNER JOIN TIPO_AMBULANCIA T ON T.ID_TIPO_AMBULANCIA = A.ID_TIPO_AMBULANCIA
	WHERE D.ID_DISPONIBILIDAD = 1;
GO

---------------------------------- PROCEDIMIENTO PARA LISTAR CONDUCTORES DISPONIBLES

CREATE PROCEDURE sp_listar_conductores_disponibles
AS
SELECT C.ID_CONDUCTOR AS CÓDIGO, CONCAT(P.NOMBRE_1,' ',P.APELLIDO_1) AS CONDUCTOR, D.NOMBRE_DISPONIBILIDAD AS DISPONIBILIDAD
FROM CONDUCTOR C
INNER JOIN PERSONA P ON C.ID_PERSONA = P.ID_PERSONA
INNER JOIN DISPONIBILIDAD D ON C.ID_DISPONIBILIDAD = D.ID_DISPONIBILIDAD
WHERE C.ID_DISPONIBILIDAD = 1;
GO

---------------------------------- PROCEDIMIENTO PARA LISTAR PETICIONES EN PROGRESO

CREATE PROCEDURE sp_listar_peticiones_progreso
AS
SELECT PET.ID_PETICION as Código, CONCAT(P.NOMBRE_1,' ',P.APELLIDO_1) as Cliente, TA.NOMBRE_TIPO_AMBULANCIA as Tipo_Ambulancia,
PET.N_AMBULANCIAS as Cant_Ambulancias, PET.PUNTO_ORIGEN as Punto_Origen, PET.PUNTO_DESTINO as Punto_Destino,
PET.CONDICION as Condicion
FROM PETICION PET
INNER JOIN CLIENTE C ON PET.ID_CLIENTE = C.ID_CLIENTE
INNER JOIN PERSONA P ON C.ID_PERSONA = P.ID_PERSONA
INNER JOIN TIPO_AMBULANCIA TA ON PET.ID_TIPO_AMBULANCIA=TA.ID_TIPO_AMBULANCIA
WHERE PET.CONDICION='En Progreso';
GO

---------------------------------- PROCEDIMIENTO PARA CONSULTAR HOSPITALES

create proc sp_consultar_hospitales
as
Select hospi.ID_HOSPITAL, hospi.NOMBRE_HOSPITAL from HOSPITAL as hospi where ID_ESTADO = 1 order by hospi.ID_HOSPITAL
go

---------------------------------- PROCEDIMIENTO PARA INSERTAR CLIENTES

CREATE PROCEDURE sp_insertar_cliente
	-- Datos_persona
	@cedula VARCHAR (10),
	@nombre_1 VARCHAR (20),
	@nombre_2 VARCHAR (20),
	@apellido_1 VARCHAR (20),
	@apellido_2 VARCHAR (20),
	@sexo VARCHAR(20),
	@fecha_nac DATETIME,
	@telefono VARCHAR (10),
	-- Datos_usuario
	@nombre_usuario VARCHAR (20),
	@correo VARCHAR (75),
	@contrasenia VARCHAR (20),
	-- Datos_secretaria
	@id_hospital int
	WITH ENCRYPTION
AS 
	BEGIN
		if NOT EXISTS (SELECT 1 FROM USUARIO WHERE NOMBRE_USUARIO = @nombre_usuario)
			BEGIN
				IF NOT EXISTS (SELECT 1 FROM USUARIO WHERE CORREO =	@correo)
					BEGIN
						DECLARE @id_persona INT
						DECLARE @id_usuario INT
						EXEC @id_persona = sp_insertar_persona @cedula, @nombre_1, @nombre_2, @apellido_1, @apellido_2, @sexo, @fecha_nac, @telefono
						EXEC @id_usuario = sp_insertar_usuario @id_persona, @nombre_usuario, @correo, @contrasenia
						IF (@id_persona != -1 AND @id_usuario != -1)
							BEGIN
								INSERT INTO CLIENTE(ID_PERSONA, ID_USUARIO, ID_HOSPITAL)
								VALUES					(@id_persona, @id_usuario, @id_hospital)
								-- obtener id_usuario
								DECLARE @id_cliente INT
								SELECT @id_cliente = ID_CLIENTE FROM CLIENTE
								WHERE ID_PERSONA = @id_persona AND ID_USUARIO = @id_usuario
								RETURN	@id_cliente
							END;
						ELSE
							BEGIN
								SET @id_cliente = -1
								RETURN	@id_cliente
							END;
					END;
				ELSE
					BEGIN
						SET @id_cliente = -1
						RETURN	@id_cliente
					END;
			END;
		ELSE
			BEGIN
				SET @id_cliente = -1
				RETURN	@id_cliente
			END;
	END;
GO


---------------------------------- PROCEDIMIENTOS PARA INSERTAR ASIGNACIONES
GO
CREATE PROCEDURE sp_insertar_asignacion_cabecera
	@id_a_cabecera int=null output,
	@id_peticion int,
	@id_secretaria int,
	@condicion varchar(15)
AS
INSERT INTO ASIGNACION_CABECERA(
	ID_PETICION, ID_SECRETARIA, CONDICION
	)
	VALUES(
	@id_peticion,
	@id_secretaria,
	@condicion
	)
	SET @id_a_cabecera = @@identity
GO
CREATE PROCEDURE sp_insertar_asignacion_detalle
	@id_a_detalle int = null output,
	@id_a_cabecera int,
	@id_conductor int,
	@id_ambulancia int
AS
INSERT INTO ASIGNACION_DETALLE(
	ID_ASIGNACION_CABECERA, ID_CONDUCTOR, ID_AMBULANCIA
	)
	VALUES(
	@id_a_cabecera,
	@id_conductor,
	@id_ambulancia
	)
	SET @id_a_detalle = @@identity
GO

CREATE PROCEDURE sp_actualizar_peticiones_asignada
	@id_peticion int
AS
UPDATE PETICION
SET	CONDICION = 'Asignada'
WHERE ID_PETICION = @id_peticion
GO

CREATE PROCEDURE sp_ocupar_conductor
  @id_conductor int
AS
UPDATE CONDUCTOR
SET ID_DISPONIBILIDAD = 2
WHERE ID_CONDUCTOR = @id_conductor
GO

CREATE PROCEDURE sp_ocupar_ambulancia
  @id_ambulancia int
AS
UPDATE AMBULANCIA
SET ID_DISPONIBILIDAD = 2
WHERE ID_AMBULANCIA = @id_ambulancia
GO

-----------PROCEDIMIENTO LISTAR PETICIONES POR DESTINO SI ERES CLIENTE
CREATE PROCEDURE sp_listar_peticiones_destino
	@destino varchar(45),
	@idC int
AS
SELECT PET.ID_PETICION as Código, CONCAT(P.NOMBRE_1,' ',P.APELLIDO_1) as Cliente, TA.NOMBRE_TIPO_AMBULANCIA as Tipo_Ambulancia,
PET.N_AMBULANCIAS as Cant_Ambulancias, PET.PUNTO_ORIGEN as Punto_Origen, PET.PUNTO_DESTINO as Punto_Destino,
PET.CONDICION as Condicion
FROM PETICION PET
INNER JOIN CLIENTE C ON PET.ID_CLIENTE = C.ID_CLIENTE
INNER JOIN PERSONA P ON C.ID_PERSONA = P.ID_PERSONA
INNER JOIN TIPO_AMBULANCIA TA ON PET.ID_TIPO_AMBULANCIA=TA.ID_TIPO_AMBULANCIA
WHERE PET.PUNTO_DESTINO LIKE '%'+ @destino +'%'
AND C.ID_CLIENTE=@idC;
GO

-----------PROCEDIMIENTO PARA ELIMINAR PETICION
CREATE PROCEDURE sp_eliminar_peticion
	@id int
AS
DELETE FROM PETICION
WHERE PETICION.ID_PETICION = @id;
GO

----------PROCEDIMIENTO PARA EL CONSULTAR PETICIONES SI ERES CLIENTE
CREATE PROCEDURE sp_listar_peticiones_pend_usuario
	@idC int
AS
SELECT PET.ID_PETICION as Código, CONCAT(P.NOMBRE_1,' ',P.APELLIDO_1) as Cliente, TA.NOMBRE_TIPO_AMBULANCIA as Tipo_Ambulancia,
PET.N_AMBULANCIAS as Cant_Ambulancias, PET.PUNTO_ORIGEN as Punto_Origen, PET.PUNTO_DESTINO as Punto_Destino,
PET.CONDICION as Condicion
FROM PETICION PET
INNER JOIN CLIENTE C ON PET.ID_CLIENTE = C.ID_CLIENTE
INNER JOIN PERSONA P ON C.ID_PERSONA = P.ID_PERSONA
INNER JOIN TIPO_AMBULANCIA TA ON PET.ID_TIPO_AMBULANCIA=TA.ID_TIPO_AMBULANCIA
WHERE (PET.CONDICION='En Progreso' OR PET.CONDICION='Asignada')
AND c.ID_CLIENTE=@idC;
GO

--------PROCEDIMIENTO PARA CONSULTAR PETICION A EDITAR
CREATE PROCEDURE sp_consultar_peticion_x_id
	@idP int
AS
SELECT PET.ID_PETICION as Codigo, P.CEDULA as Cedula,P.NOMBRE_1 as Nombre,P.APELLIDO_1 as Apellido, TA.ID_TIPO_AMBULANCIA as Tipo_Ambulancia,
PET.N_AMBULANCIAS as Cant_Ambulancias, PET.PUNTO_ORIGEN as Punto_Origen, PET.PUNTO_DESTINO as Punto_Destino,
PET.CONDICION as Condicion
FROM PETICION PET
INNER JOIN CLIENTE C ON PET.ID_CLIENTE = C.ID_CLIENTE
INNER JOIN PERSONA P ON C.ID_PERSONA = P.ID_PERSONA
INNER JOIN TIPO_AMBULANCIA TA ON PET.ID_TIPO_AMBULANCIA=TA.ID_TIPO_AMBULANCIA
WHERE PET.ID_PETICION = @idP;
GO

---------PROICEDIMIENTO PARA EDITAR PETICION
CREATE PROCEDURE sp_editar_peticion
@idP int,
@id_tipo_ambulancia int,
@n_ambulancias int,
@punto_origen varchar(45),
@punto_destino varchar(45)
AS
UPDATE PETICION
SET
PETICION.ID_TIPO_AMBULANCIA=@id_tipo_ambulancia,
PETICION.N_AMBULANCIAS=@n_ambulancias,
PETICION.PUNTO_ORIGEN=@punto_origen,
PETICION.PUNTO_DESTINO=@punto_destino
WHERE PETICION.ID_PETICION=@idP;
GO


--------------------------------- PROCEDIMEINTO PARA CONSULTAR LOS ESTADOS 
create proc sp_consultar_estados
as
Select  est.ID_ESTADO, est.NOMBRE_ESTADO  from ESTADO as est where est.ID_ESTADO != 0;
go

------------------ PROCEDIMIENTO PARA LISTAR TODOS LOS CLIENTES

CREATE PROCEDURE sp_listar_clientes
AS
	Select clien.ID_CLIENTE, est.NOMBRE_ESTADO ,hospi.NOMBRE_HOSPITAL ,person.CEDULA, 
	CONCAT(person.NOMBRE_1 , char(160) ,  person.NOMBRE_2) as Nombres, 
	CONCAT(person.APELLIDO_1 ,char(160) ,person.APELLIDO_2) as Apellidos, person.SEXO, 
	person.FECHA_NAC, person.TELEFONO, usur.CORREO from CLIENTE clien 
	inner join PERSONA person 
	on person.ID_PERSONA = clien.ID_PERSONA
	inner join HOSPITAL hospi
	on hospi.ID_HOSPITAL = clien.ID_HOSPITAL
	inner join ESTADO est
	on est.ID_ESTADO = clien.ID_ESTADO
	inner join USUARIO usur
	on usur.ID_USUARIO = clien.ID_USUARIO where clien.ID_ESTADO != 0;
GO	
------ PROCEDIMIENTO PARA CONSULTAR LOS CLIENTES POR FILTROS

CREATE PROCEDURE sp_consultar_clientes
	@opcionA int,
	@opcionB int,
	@dato varchar(75),
	@hospital int,
	@estado int
AS
	declare @str_select varchar(max) = N'Select clien.ID_CLIENTE, est.NOMBRE_ESTADO ,hospi.NOMBRE_HOSPITAL ,person.CEDULA, 
	CONCAT(person.NOMBRE_1 , char(160) ,  person.NOMBRE_2) as Nombres, 
	CONCAT(person.APELLIDO_1 ,char(160) ,person.APELLIDO_2) as Apellidos, person.SEXO, 
	person.FECHA_NAC, person.TELEFONO, usur.CORREO from CLIENTE clien 
	inner join PERSONA person 
	on person.ID_PERSONA = clien.ID_PERSONA
	inner join HOSPITAL hospi
	on hospi.ID_HOSPITAL = clien.ID_HOSPITAL
	inner join ESTADO est
	on est.ID_ESTADO = clien.ID_ESTADO
	inner join USUARIO usur
	on usur.ID_USUARIO = clien.ID_USUARIO'
	
	declare @str_where varchar(max)
	declare @str_and varchar(max)
	declare @str_consulta varchar(max)

BEGIN
	if(@opcionA = 1) 
		BEGIN
			set @str_where = N' where (CONCAT(person.NOMBRE_1 , person.NOMBRE_2, person.APELLIDO_1, person.APELLIDO_2) 
								like ''%'+ @dato +'%'' or CONCAT(person.NOMBRE_1, person.APELLIDO_1, person.APELLIDO_2) like ''%'+ @dato +'%'' or 
								CONCAT(person.NOMBRE_1, person.APELLIDO_2) like ''%'+ @dato +'%'' or CONCAT(person.NOMBRE_2, person.APELLIDO_2) 
								like ''%'+ @dato +'%'')'
		END
	else if(@opcionA = 2) 
		BEGIN
			if(@dato='')begin
				set @str_where = N' where person.CEDULA != '' '+ @dato +' '''
			end
			else set @str_where = N' where person.CEDULA = ' + @dato 
 		END
	if(@opcionB = 1)
		BEGIN
			set @str_and = ' AND hospi.ID_HOSPITAL = ' +  CONVERT(varchar(8) , @hospital)   
		END
	else if(@opcionB = 2)
		BEGIN
			set @str_and = N' AND est.ID_ESTADO =  '+ CONVERT(varchar(3), @estado) 
		END
	else if(@opcionB = 3)
		BEGIN
			set @str_and = N' AND est.ID_ESTADO = ' + CONVERT(varchar(3), @estado) + ' AND hospi.ID_HOSPITAL = ' + CONVERT(varchar(8) , @hospital)
		END
	else set @str_and = ''
END

set @str_consulta = CONCAT(@str_select, @str_where, @str_and, ' AND clien.ID_ESTADO != 0')
PRINT @str_consulta
exec(@str_consulta)
GO	

-------------------------------------------------------------------- PROCEDIMIENTO PARA CONSULTAR LOS CONDUTORES 
 CREATE PROCEDURE sp_listar_conductores WITH ENCRYPTION
      AS
      	SELECT
      		C.ID_CONDUCTOR AS ID,
      		P.CEDULA AS CEDULA,
      		P.NOMBRE_1 AS NOMBRE,
      		CONCAT(P.APELLIDO_1, char(160), P.APELLIDO_2) AS APELLIDOS,
      		D.NOMBRE_DISPONIBILIDAD AS DISPONIBILIDAD,
      		C.FECHA_CONTRATO AS FECHA_CONTRATO
      	FROM CONDUCTOR AS C
        INNER JOIN PERSONA AS P ON C.ID_PERSONA = P.ID_PERSONA
        INNER JOIN DISPONIBILIDAD AS D ON C.ID_DISPONIBILIDAD = D.ID_DISPONIBILIDAD
        INNER JOIN ESTADO AS E ON C.ID_ESTADO = E.ID_ESTADO
      GO

-------------------------------------------------------------------- PROCEDIMIENTO PARA CONSULTAR LOS CONDUTORES POR FILTROS
CREATE PROCEDURE sp_buscar_conductores
	@cedula_nombre	VARCHAR (50),
	@disponibilidad	VARCHAR (1)
	WITH ENCRYPTION
AS
	declare @str_select varchar(max) = N'
		SELECT
			C.ID_CONDUCTOR									AS ID, 
			P.CEDULA										AS CEDULA,
			P.NOMBRE_1										AS NOMBRE, 
			CONCAT(P.APELLIDO_1, char(160), P.APELLIDO_2)	AS APELLIDOS,
			D.NOMBRE_DISPONIBILIDAD							AS DISPONIBILIDAD,
			C.FECHA_CONTRATO								AS FECHA_CONTRATO
		FROM CONDUCTOR				AS C
		INNER JOIN PERSONA			AS P ON C.ID_PERSONA		= P.ID_PERSONA
		INNER JOIN DISPONIBILIDAD	AS D ON C.ID_DISPONIBILIDAD	= D.ID_DISPONIBILIDAD
		INNER JOIN ESTADO			AS E ON C.ID_ESTADO			= E.ID_ESTADO'
	declare @str_where varchar(max)
	declare @str_and varchar(max)
	declare @str_consulta varchar(max)

	declare @str_cedula varchar(max)
	declare @str_nombre varchar(max)
	declare @str_disponibilidad varchar(max)

	BEGIN
		set @str_where	= N' WHERE '
		set @str_and	= N' AND '
		set @str_cedula = N' P.CEDULA = '+ @cedula_nombre
		set @str_nombre = N' (
			CONCAT(P.NOMBRE_1, P.NOMBRE_2, P.APELLIDO_1, P.APELLIDO_2)	like ''%'+ @cedula_nombre +'%'' OR 
			CONCAT(P.NOMBRE_1, P.APELLIDO_1, P.APELLIDO_2)				like ''%'+ @cedula_nombre +'%'' OR 
			CONCAT(P.NOMBRE_1, P.APELLIDO_2)							like ''%'+ @cedula_nombre +'%'' OR 
			CONCAT(P.NOMBRE_2, P.APELLIDO_2)							like ''%'+ @cedula_nombre +'%'' )'
		set @str_disponibilidad	= N' C.ID_DISPONIBILIDAD = ' + @disponibilidad
		
		IF (@cedula_nombre IS NOT NULL ) BEGIN 
			IF (ISNUMERIC(@cedula_nombre) = 1) BEGIN
				SET @str_where = CONCAT(@str_where, @str_cedula)
			END ELSE BEGIN
				SET @str_where = CONCAT(@str_where, @str_nombre)
			END
			IF (@disponibilidad IS NOT NULL) BEGIN
				set @str_and = CONCAT(@str_and, @str_disponibilidad)
			END ELSE BEGIN
				set @str_and = N' '
			END
		END ELSE BEGIN
			set @str_and = N' '
			SET @str_where = CONCAT(@str_where, @str_disponibilidad)
		END
		set @str_consulta = CONCAT(@str_select, @str_where, @str_and)
		PRINT @str_consulta
		exec(@str_consulta)
	END
GO

--------------------------------------PROCEDIMIENTO PARA LISTAR ASIGNACIONES POR ID SECRETARIO
CREATE PROCEDURE sp_listar_asignaciones
@idS int
AS
SELECT AC.ID_ASIGNACION_CABECERA AS Código_Asignación,
PET.ID_PETICION AS Código_Petición,
P.CEDULA AS Cedula_Cliente,
CONCAT(P.NOMBRE_1,' ',P.APELLIDO_1) AS Cliente_Nombre,
TA.NOMBRE_TIPO_AMBULANCIA AS Tipo_Ambulancia,
PET.N_AMBULANCIAS AS Cantidad_Ambulancias,
PET.PUNTO_ORIGEN AS Origen, PET.PUNTO_DESTINO AS Destino,
AC.CONDICION as Condición_Asignación
FROM ASIGNACION_CABECERA AC
INNER JOIN PETICION PET ON PET.ID_PETICION = AC.ID_PETICION
INNER JOIN CLIENTE C ON PET.ID_CLIENTE = C.ID_CLIENTE
INNER JOIN PERSONA P ON C.ID_PERSONA = P.ID_PERSONA
INNER JOIN TIPO_AMBULANCIA tA ON TA.ID_TIPO_AMBULANCIA = PET.ID_TIPO_AMBULANCIA
WHERE AC.ID_SECRETARIA = @idS AND AC.ID_ESTADO = 1;
GO

-------------------------------PROCEDIMIENTO PARA FILTRAR ASIGNACIONES
CREATE PROCEDURE sp_filtrar_asignaciones
	@idS int,
	@cedC varchar(10),
	@cond varchar(15)
AS
SELECT AC.ID_ASIGNACION_CABECERA AS Código_Asignación,
PET.ID_PETICION AS Código_Petición,
P.CEDULA AS Cedula_Cliente,
CONCAT(P.NOMBRE_1,' ',P.APELLIDO_1) AS Cliente_Nombre,
TA.NOMBRE_TIPO_AMBULANCIA AS Tipo_Ambulancia,
PET.N_AMBULANCIAS AS Cantidad_Ambulancias,
PET.PUNTO_ORIGEN AS Origen, PET.PUNTO_DESTINO AS Destino,
AC.CONDICION as Condición_Asignación
FROM ASIGNACION_CABECERA AC
INNER JOIN PETICION PET ON PET.ID_PETICION = AC.ID_PETICION
INNER JOIN CLIENTE C ON PET.ID_CLIENTE = C.ID_CLIENTE
INNER JOIN PERSONA P ON C.ID_PERSONA = P.ID_PERSONA
INNER JOIN TIPO_AMBULANCIA tA ON TA.ID_TIPO_AMBULANCIA = PET.ID_TIPO_AMBULANCIA
WHERE AC.ID_SECRETARIA = @idS AND AC.ID_ESTADO = 1
AND (P.CEDULA=@cedC OR AC.CONDICION = @cond);
GO

-----------------------PROCEDIMIENTO PARA CONSULTAR ASIGNACIONES POR ID ASIGNACION CABECERA
CREATE PROCEDURE sp_consultar_asignacion_x_id
	@idAs int
AS
SELECT AC.ID_ASIGNACION_CABECERA AS Código_Asignación,
P.CEDULA AS Cedula_Cliente,
P.NOMBRE_1 AS Nombre, P.APELLIDO_1 AS Apellido,
TA.NOMBRE_TIPO_AMBULANCIA AS Tipo_Ambulancia,
PET.N_AMBULANCIAS AS Cantidad_Ambulancias,
PET.PUNTO_ORIGEN AS Origen, PET.PUNTO_DESTINO AS Destino
FROM ASIGNACION_CABECERA AC
INNER JOIN PETICION PET ON PET.ID_PETICION = AC.ID_PETICION
INNER JOIN CLIENTE C ON PET.ID_CLIENTE = C.ID_CLIENTE
INNER JOIN PERSONA P ON C.ID_PERSONA = P.ID_PERSONA
INNER JOIN TIPO_AMBULANCIA tA ON TA.ID_TIPO_AMBULANCIA = PET.ID_TIPO_AMBULANCIA
WHERE AC.ID_ASIGNACION_CABECERA=@idAs;
GO

---------------------------PROCEDIMIENTO PARAA CONSULTAR ASIGNACION DETALLE EN POR EL ID CABECERA
CREATE PROCEDURE sp_consultar_asignacion_detalle_idAs
	@idAs int
AS
SELECT AD.ID_ASIGNACION_DETALLE AS CODIGO_DETALLE,
C.ID_CONDUCTOR AS CODIGO_CONDUCTOR,
CONCAT(P.NOMBRE_1,' ',P.APELLIDO_1) AS NOMBRE_CONDUCTOR,
A.ID_AMBULANCIA AS CODIGO_AMBULANCIA,
CONCAT(A.PLACA,' ',A.MODELO) AS NOMBRE_AMBULANCIA
FROM ASIGNACION_DETALLE AD
INNER JOIN CONDUCTOR C ON AD.ID_CONDUCTOR=C.ID_CONDUCTOR
INNER JOIN AMBULANCIA A ON AD.ID_AMBULANCIA=A.ID_AMBULANCIA
INNER JOIN PERSONA P ON C.ID_PERSONA=P.ID_PERSONA
WHERE AD.ID_ASIGNACION_CABECERA=@idAs AND AD.ID_ESTADO=1;
GO

---------------------------PROCEDIMIENTO PARA HACER UPDATE A ASIGNACION DETALLE
CREATE PROCEDURE sp_update_asignacion
	@id_detalle int,
	@id_conductor int,
	@id_ambulancia int
AS
UPDATE ASIGNACION_DETALLE
SET ID_CONDUCTOR = @id_conductor,
ID_AMBULANCIA= @id_ambulancia
WHERE ID_ASIGNACION_DETALLE = @id_detalle;

UPDATE CONDUCTOR
SET ID_DISPONIBILIDAD = 2
WHERE ID_CONDUCTOR = @id_conductor;

UPDATE AMBULANCIA
SET ID_DISPONIBILIDAD = 2
WHERE ID_AMBULANCIA = @id_ambulancia;
GO

---------------------------- Procedimiento verificar login
CREATE PROCEDURE sp_login
	@nombre_usuario varchar(75),
	@CONTRASENIA varchar(75)	
as 
	select * from (select 'Gerente' as tipo, ge.ID_GERENTE as id_tipo, pers.NOMBRE_1 as nombre, pers.APELLIDO_1 as apellido, us.NOMBRE_USUARIO, us.CORREO, us.CONTRASENIA, us.ID_ESTADO
		from GERENTE as ge inner join PERSONA as pers 
		on pers.ID_PERSONA = ge.ID_PERSONA 
		inner join USUARIO as us 
		on us.ID_USUARIO = ge.ID_USUARIO 
		UNION 
		select 'Cliente', cl.ID_CLIENTE,  pers.NOMBRE_1, pers.APELLIDO_1, us.NOMBRE_USUARIO, us.CORREO, us.CONTRASENIA, us.ID_ESTADO from CLIENTE as cl 
		inner join PERSONA as pers on pers.ID_PERSONA = cl.ID_PERSONA 
		inner join USUARIO as us 
		on us.ID_USUARIO = cl.ID_USUARIO 
		UNION 
		select 'Secretaria', sctria.ID_SECRETARIA,  pers.NOMBRE_1, pers.APELLIDO_1, us.NOMBRE_USUARIO, us.CORREO, us.CONTRASENIA, us.ID_ESTADO 
		from SECRETARIA as sctria 
		inner join PERSONA as pers on pers.ID_PERSONA = sctria.ID_PERSONA 
		inner join USUARIO as us on us.ID_USUARIO = sctria.ID_USUARIO ) as resul 
		where resul.NOMBRE_USUARIO = @nombre_usuario and resul.CONTRASENIA = @contrasenia and resul.ID_ESTADO =1
go


------ procedimiento para eliminar clientes
CREATE PROCEDURE sp_eliminar_clientes
	@idcliente int 
AS
	declare @idpersona int
	declare @idusuario int
	set @idusuario = (SELECT clien.ID_USUARIO FROM CLIENTE CLIEN WHERE CLIEN.ID_CLIENTE = @idcliente) 

	update cliente set ID_ESTADO = 0 where ID_CLIENTE= @idcliente; 
	update USUARIO set ID_ESTADO = 0 where ID_USUARIO= @idusuario;
GO	

--------------------------------------------------------- PERSONA INSERTAR DATOS
CREATE PROCEDURE sp_persona_insertarDatos
	@cedula		VARCHAR (10),
	@nombre_1	VARCHAR (20),
	@nombre_2	VARCHAR (20),
	@apellido_1 VARCHAR (20),
	@apellido_2 VARCHAR (20),
	@sexo		VARCHAR(20),
	@fecha_nac	DATE,
	@telefono	VARCHAR (10)
	WITH ENCRYPTION
AS
	BEGIN
		IF NOT EXISTS (SELECT 1 FROM PERSONA WHERE CEDULA = @cedula) BEGIN
			INSERT INTO PERSONA (CEDULA, NOMBRE_1, NOMBRE_2, APELLIDO_1, APELLIDO_2, SEXO, FECHA_NAC, TELEFONO)
			VALUES				(@cedula, @nombre_1, @nombre_2, @apellido_1, @apellido_2, @sexo, @fecha_nac, @telefono)
			-- obtener id_persona
			DECLARE @id_persona INT
			SELECT @id_persona = ID_PERSONA FROM PERSONA WHERE CEDULA = @cedula
			RETURN	@id_persona
		END; ELSE BEGIN
			SET @id_persona = -1
			RETURN	@id_persona
		END;
	END;
GO
--------------------------------------------------------- CONDUCTOR INSETAR DATOS
CREATE PROCEDURE sp_conductor_insertarDatos
	-- Datos_persona
	@cedula			VARCHAR (10),
	@nombre_1		VARCHAR (20),
	@nombre_2		VARCHAR (20),
	@apellido_1		VARCHAR (20),
	@apellido_2		VARCHAR (20),
	@sexo			VARCHAR (20),
	@fecha_nac		DATE,
	@telefono		VARCHAR (10),
	-- Datos_conductor
	@fecha_contrato	DATE
	WITH ENCRYPTION
AS 
	BEGIN
		DECLARE @id_persona INT
		EXEC @id_persona = sp_persona_insertarDatos @cedula, @nombre_1, @nombre_2, @apellido_1, @apellido_2, @sexo, @fecha_nac, @telefono
		IF (@id_persona != -1) BEGIN
			INSERT INTO CONDUCTOR	(ID_PERSONA, FECHA_CONTRATO)
			VALUES					(@id_persona, @fecha_contrato)
			-- obtener id_conductor
			DECLARE @id_conductor INT
			SELECT @id_conductor = ID_CONDUCTOR FROM CONDUCTOR WHERE ID_PERSONA = @id_persona
			RETURN	@id_conductor
		END; ELSE BEGIN
			SET @id_conductor = -1
			RETURN	@id_conductor
		END;
	END;
GO

--------------------------------------------------------- PERSONA ACTUALIZAR DATOS
CREATE PROCEDURE sp_persona_actualizarDatos
	@cedula		VARCHAR (10),
	@nombre_1	VARCHAR (20),
	@nombre_2	VARCHAR (20),
	@apellido_1 VARCHAR (20),
	@apellido_2 VARCHAR (20),
	@sexo		VARCHAR(20),
	@fecha_nac	DATE,
	@telefono	VARCHAR (10)
	WITH ENCRYPTION
AS
	BEGIN
		IF EXISTS (SELECT 1 FROM PERSONA WHERE CEDULA = @cedula) BEGIN
			UPDATE PERSONA SET
				NOMBRE_1	= @nombre_1, 
				NOMBRE_2	= @nombre_2, 
				APELLIDO_1	= @apellido_1, 
				APELLIDO_2	= @apellido_2, 
				SEXO		= @sexo, 
				FECHA_NAC	= @fecha_nac, 
				TELEFONO	= @telefono
			WHERE CEDULA	= @cedula
			-- obtener id_persona
			DECLARE @id_persona INT
			SELECT @id_persona = ID_PERSONA FROM PERSONA WHERE CEDULA = @cedula
			RETURN	@id_persona
		END; ELSE BEGIN
			SET @id_persona = -1
			RETURN	@id_persona
		END;
	END;
GO
--------------------------------------------------------- CONDUCTOR ACTUALZIAR DATOS
CREATE PROCEDURE sp_conductor_actualizarDatos
	-- Datos_persona
	@cedula			VARCHAR (10),
	@nombre_1		VARCHAR (20),
	@nombre_2		VARCHAR (20),
	@apellido_1		VARCHAR (20),
	@apellido_2		VARCHAR (20),
	@sexo			VARCHAR (20),
	@fecha_nac		DATE,
	@telefono		VARCHAR (10),
	-- Datos_conductor
	@fecha_contrato	DATE
	WITH ENCRYPTION
AS 
	BEGIN
		DECLARE @id_persona INT
		EXEC @id_persona = sp_persona_actualizarDatos @cedula, @nombre_1, @nombre_2, @apellido_1, @apellido_2, @sexo, @fecha_nac, @telefono
		IF (@id_persona != -1) BEGIN
			UPDATE CONDUCTOR SET
				FECHA_CONTRATO	= @fecha_contrato
			WHERE ID_PERSONA	= @id_persona
			-- obtener id_conductor
			DECLARE @id_conductor INT
			SELECT @id_conductor = ID_CONDUCTOR FROM CONDUCTOR WHERE ID_PERSONA = @id_persona
			RETURN	@id_conductor
		END; ELSE BEGIN
			SET @id_conductor = -1
			RETURN	@id_conductor
		END;
	END;
GO

--------------------------------------------------------- CONDUCTOR LISTAR DATOS
CREATE PROCEDURE sp_conductor_listarDatos 
	WITH ENCRYPTION
AS
	SELECT 
		C.ID_CONDUCTOR									AS ID,
		P.CEDULA										AS CEDULA,
		E.NOMBRE_ESTADO									AS ESTADO,
		P.NOMBRE_1										AS NOMBRE1,
		CONCAT(P.APELLIDO_1, char(160), P.APELLIDO_2)	AS APELLIDOS,
		D.NOMBRE_DISPONIBILIDAD							AS DISPONIBILIDAD,
		P.TELEFONO										AS TELEFONO,
		P.SEXO											AS SEXO,
		P.FECHA_NAC										AS FECHA_NACIMIENTO,
		C.FECHA_CONTRATO								AS FECHA_CONTRATO
	FROM CONDUCTOR				AS C
	INNER JOIN PERSONA			AS P ON C.ID_PERSONA		= P.ID_PERSONA
	INNER JOIN DISPONIBILIDAD	AS D ON C.ID_DISPONIBILIDAD = D.ID_DISPONIBILIDAD
	INNER JOIN ESTADO			AS E ON C.ID_ESTADO			= E.ID_ESTADO
GO
--------------------------------------------------------- CONDUCTOR BUSCAR DATOS POR ID
CREATE PROCEDURE sp_conductor_buscarDatosPor_Id
	@dato_idConductor INT
	WITH ENCRYPTION
AS
	BEGIN
		SELECT 
			C.ID_CONDUCTOR			AS ID,
			P.CEDULA				AS CEDULA,
			E.NOMBRE_ESTADO			AS ESTADO,
			P.NOMBRE_1				AS NOMBRE1,
			P.NOMBRE_2				AS NOMBRE2,
			P.APELLIDO_1			AS APELLIDO1,
			P.APELLIDO_2			AS APELLIDO2,
			D.NOMBRE_DISPONIBILIDAD AS DISPONIBILIDAD,
			P.TELEFONO				AS TELEFONO,
			P.SEXO					AS SEXO,
			P.FECHA_NAC				AS FECHA_NACIMIENTO,
			C.FECHA_CONTRATO		AS FECHA_CONTRATO
		FROM CONDUCTOR AS C
		INNER JOIN PERSONA			AS P ON C.ID_PERSONA		= P.ID_PERSONA
		INNER JOIN DISPONIBILIDAD	AS D ON C.ID_DISPONIBILIDAD = D.ID_DISPONIBILIDAD
		INNER JOIN ESTADO			AS E ON C.ID_ESTADO			= E.ID_ESTADO
		WHERE ID_CONDUCTOR = @dato_idConductor
	END;
GO
--------------------------------------------------------- USUARIO INSERTAR DATOS
CREATE PROCEDURE sp_usuario_insertarDatos
	-- Datos_usuario
	@id_persona INT,
	@nombre_usuario varchar(20),
	@correo varchar(75),
	@contrasenia varchar(20)
	WITH ENCRYPTION
AS
	BEGIN
		IF (@id_persona != -1) BEGIN
			INSERT INTO USUARIO (NOMBRE_USUARIO, CORREO, CONTRASENIA)
			VALUES				(@nombre_usuario, @correo, @contrasenia)
			-- obtener id_usuario
			DECLARE @id_usuario INT
			SELECT @id_usuario = ID_USUARIO FROM USUARIO WHERE NOMBRE_USUARIO = @nombre_usuario
			RETURN	@id_usuario	
		END; ELSE BEGIN
			SET @id_usuario = -1
			RETURN	@id_usuario
		END;
	END;
GO
--------------------------------------------------------- SECREATARIA INSERTAR DATOS
CREATE PROCEDURE sp_secretaria_insertarDatos
	-- Datos_persona
	@cedula VARCHAR (10),
	@nombre_1 VARCHAR (20),
	@nombre_2 VARCHAR (20),
	@apellido_1 VARCHAR (20),
	@apellido_2 VARCHAR (20),
	@sexo VARCHAR(20),
	@fecha_nac DATETIME,
	@telefono VARCHAR (10),
	-- Datos_usuario
	@nombre_usuario VARCHAR (20),
	@correo VARCHAR (75),
	@contrasenia VARCHAR (20),
	-- Datos_secretaria
	@fecha_contrato DATE
	WITH ENCRYPTION
AS 
	BEGIN
		IF NOT EXISTS (SELECT 1 FROM USUARIO WHERE NOMBRE_USUARIO = @nombre_usuario) BEGIN
			IF NOT EXISTS (SELECT 1 FROM USUARIO WHERE CORREO =	@correo) BEGIN
				DECLARE @id_persona INT
				DECLARE @id_usuario INT
				EXEC @id_persona = sp_persona_insertarDatos @cedula, @nombre_1, @nombre_2, @apellido_1, @apellido_2, @sexo, @fecha_nac, @telefono
				EXEC @id_usuario = sp_usuario_insertarDatos @id_persona, @nombre_usuario, @correo, @contrasenia
				IF (@id_persona != -1 AND @id_usuario != -1) BEGIN
					INSERT INTO SECRETARIA (ID_PERSONA, ID_USUARIO, FECHA_CONTRATO)
					VALUES					(@id_persona, @id_usuario, @fecha_contrato)
					-- obtener id_usuario
					DECLARE @id_secretaria INT
					SELECT @id_secretaria = ID_SECRETARIA FROM SECRETARIA WHERE ID_PERSONA = @id_persona AND ID_USUARIO = @id_usuario
					RETURN	@id_secretaria
				END; ELSE BEGIN
					SET @id_secretaria = -1
					RETURN	@id_secretaria
				END;
			END; ELSE BEGIN
				SET @id_secretaria = -1
				RETURN	@id_secretaria
			END;
		END; ELSE BEGIN
			SET @id_secretaria = -1
			RETURN	@id_secretaria
		END;
	END;
GO

--------------------------------------------------------- USUARIO ACTUALIZAR DATOS
CREATE PROCEDURE sp_usuario_actualizarDatos
	-- Datos_usuario
	@id_persona		INT,
	@nombre_usuario	VARCHAR (20),
	@correo			VARCHAR (75),
	@contrasenia	VARCHAR (20)
	WITH ENCRYPTION
AS
	BEGIN
		IF (@id_persona != -1) BEGIN
			UPDATE USUARIO SET
				CORREO		= @correo, 
				CONTRASENIA	= @contrasenia
			WHERE NOMBRE_USUARIO = @nombre_usuario
			-- obtener id_usuario
			DECLARE @id_usuario INT
			SELECT @id_usuario = ID_USUARIO FROM USUARIO WHERE NOMBRE_USUARIO = @nombre_usuario
			-- 
			RETURN	@id_usuario	
		END; ELSE BEGIN
			SET @id_usuario = -1
			RETURN	@id_usuario
		END;
	END;
GO
--------------------------------------------------------- SECREATARIA ACTUALIZAR DATOS
CREATE PROCEDURE sp_secretaria_actualizarDatos
	-- Datos_persona
	@cedula			VARCHAR (10),
	@nombre_1		VARCHAR (20),
	@nombre_2		VARCHAR (20),
	@apellido_1		VARCHAR (20),
	@apellido_2		VARCHAR (20),
	@sexo			VARCHAR (20),
	@fecha_nac		DATE,
	@telefono		VARCHAR (10),
	-- Datos_usuario
	@nombre_usuario	VARCHAR (20),
	@correo			VARCHAR (75),
	@contrasenia	VARCHAR (20),
	-- Datos_secretaria
	@fecha_contrato	DATE
	WITH ENCRYPTION
AS 
	BEGIN
		IF EXISTS (SELECT 1 FROM USUARIO WHERE NOMBRE_USUARIO = @nombre_usuario) BEGIN
			IF EXISTS (SELECT 1 FROM USUARIO WHERE CORREO =	@correo) BEGIN
				DECLARE @id_persona INT
				DECLARE @id_usuario INT
				EXEC @id_persona = sp_persona_actualizarDatos @cedula, @nombre_1, @nombre_2, @apellido_1, @apellido_2, @sexo, @fecha_nac, @telefono
				EXEC @id_usuario = sp_usuario_actualizarDatos @id_persona, @nombre_usuario, @correo, @contrasenia
				IF (@id_persona != -1 AND @id_usuario != -1) BEGIN
					UPDATE SECRETARIA SET 
						FECHA_CONTRATO	= @fecha_contrato
					WHERE	ID_PERSONA	= @id_persona
					AND		ID_USUARIO	= @id_usuario
					-- obtener id_usuario
					DECLARE @id_secretaria INT
					SELECT @id_secretaria = ID_SECRETARIA FROM SECRETARIA WHERE ID_PERSONA = @id_persona AND ID_USUARIO = @id_usuario
					RETURN	@id_secretaria
				END; ELSE BEGIN
					-- no existe id_persona 0 id_usuario
					SET @id_secretaria = -1
					RETURN	@id_secretaria
				END;
			END; ELSE BEGIN
				-- no existe correo
				SET @id_secretaria = -2
				RETURN	@id_secretaria
			END;
		END; ELSE BEGIN
			-- no existe nombre_usuario
			SET @id_secretaria = -3
			RETURN	@id_secretaria
		END;
		PRINT @id_secretaria
	END;
GO

--------------------------------------------------------- SECREATARIA LISTAR DATOS
CREATE PROCEDURE sp_secretaria_listarDatos
	WITH ENCRYPTION
AS
	SELECT 
		S.ID_SECRETARIA		AS ID,
		P.CEDULA			AS CEDULA,
		E.NOMBRE_ESTADO		AS ESTADO,
		P.NOMBRE_1			AS NOMBRE,
		CONCAT(P.APELLIDO_1, char(160), P.APELLIDO_2) AS APELLIDOS,
		U.CORREO			AS CORREO,
		P.TELEFONO			AS TELEFONO,
		P.SEXO				AS SEXO,
		S.FECHA_CONTRATO	AS FECHA_CONTRATO,
		P.FECHA_NAC			AS FECHA_NACIMIENTO
	FROM SECRETARIA AS S
	INNER JOIN PERSONA			AS P ON S.ID_PERSONA	= P.ID_PERSONA
	INNER JOIN USUARIO			AS U ON S.ID_USUARIO	= U.ID_USUARIO
	INNER JOIN ESTADO			AS E ON S.ID_ESTADO		= E.ID_ESTADO
Go
--------------------------------------------------------- SECREATARIA BUSCAR DATOS POR ID
CREATE PROCEDURE sp_secretaria_buscarDatosPorId
	@dato_idSecretaria INT
	WITH ENCRYPTION
AS
	BEGIN
		SELECT 
			S.ID_SECRETARIA		AS ID,
			P.CEDULA			AS CEDULA,
			E.NOMBRE_ESTADO		AS ESTADO,
			P.NOMBRE_1			AS NOMBRE1,
			P.NOMBRE_2			AS NOMBRE2,
			P.APELLIDO_1		AS APELLIDO1,
			P.APELLIDO_2		AS APELLIDO2,
			U.CORREO			AS CORREO,
			P.TELEFONO			AS TELEFONO,
			P.SEXO				AS SEXO,
			S.FECHA_CONTRATO	AS FECHA_CONTRATO,
			P.FECHA_NAC			AS FECHA_NACIMIENTO
		FROM SECRETARIA AS S
		INNER JOIN PERSONA			AS P ON S.ID_PERSONA		= P.ID_PERSONA
		INNER JOIN USUARIO			AS U ON S.ID_USUARIO		= U.ID_USUARIO
		INNER JOIN ESTADO			AS E ON S.ID_ESTADO			= E.ID_ESTADO
		WHERE ID_SECRETARIA = @dato_idSecretaria
	END;
GO
---------------------------------------- Procedimiento para buscar cliente por ID
CREATE PROCEDURE sp_cliente_buscarDatosPorId
	@idcliente INT
	WITH ENCRYPTION
AS
	BEGIN
		select client.ID_CLIENTE, client.ID_ESTADO, person.CEDULA, client.ID_HOSPITAL, person.NOMBRE_1,
		person.NOMBRE_2, person.APELLIDO_1, person.APELLIDO_2, person.FECHA_NAC, person.SEXO, usur.CORREO,
		person.TELEFONO, usur.CONTRASENIA 
		from cliente as client
		INNER JOIN PERSONA	AS person ON person.ID_PERSONA		= client.ID_PERSONA
		INNER JOIN USUARIO	AS usur ON usur.ID_USUARIO		= client.ID_USUARIO
		where client.ID_CLIENTE = @idcliente
	END;
GO