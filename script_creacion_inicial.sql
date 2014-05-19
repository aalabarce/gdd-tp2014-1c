GO
USE [GD1C2014]

GO
CREATE SCHEMA STR_NOMBRE_GRUPO

GO
CREATE TABLE [STR_NOMBRE_GRUPO].[USUARIO](
	[USU_ID] INT IDENTITY(0,1),
	PRIMARY KEY CLUSTERED (USU_ID),
	[USU_USERNAME][NVARCHAR](255),
	[USU_PASSWORD][NVARCHAR](255),
	[USU_INTENTOS_LOGIN][INT],
	[USU_TIPO][CHAR](1),
	[USU_BAJA][BIT] DEFAULT 0

)
GO
CREATE TABLE [STR_NOMBRE_GRUPO].[ROL](
	[ROL_ID][INT] IDENTITY(0,1),
	PRIMARY KEY CLUSTERED (ROL_ID),
	[ROL_NOMBRE][NVARCHAR](50),
	[ROL_BAJA][BIT] DEFAULT 0
)

GO
CREATE TABLE [STR_NOMBRE_GRUPO].[USUARIO_ROL](
	[USU_ROL_USUARIO_ID][INT],
	[USU_ROL_ROL_ID][INT],
	PRIMARY KEY CLUSTERED (USU_ROL_USUARIO_ID,USU_ROL_ROL_ID),
	FOREIGN KEY (USU_ROL_USUARIO_ID) REFERENCES STR_NOMBRE_GRUPO.USUARIO(USU_ID),
	FOREIGN KEY (USU_ROL_ROL_ID) REFERENCES STR_NOMBRE_GRUPO.ROL(ROL_ID)

)

CREATE TABLE [STR_NOMBRE_GRUPO].[FUNCIONALIDAD](
	[FUN_ID][INT],
	PRIMARY KEY CLUSTERED (FUN_ID),
	[FUN_NOMBRE][NVARCHAR](50)
)

GO
CREATE TABLE [STR_NOMBRE_GRUPO].[ROL_FUNCIONALIDAD](
	[ROL_FUN_ROL][INT],
	[ROL_FUN_FUN][INT],
	PRIMARY KEY CLUSTERED (ROL_FUN_ROL,ROL_FUN_FUN),
	FOREIGN KEY (ROL_FUN_ROL) REFERENCES STR_NOMBRE_GRUPO.ROL(ROL_ID),
	FOREIGN KEY (ROL_FUN_FUN) REFERENCES STR_NOMBRE_GRUPO.FUNCIONALIDAD(FUN_ID)
)

GO

CREATE TABLE [STR_NOMBRE_GRUPO].[CLIENTE](
	[CLI_ID][INT] IDENTITY(0,1),
	PRIMARY KEY CLUSTERED (CLI_ID),
	[CLI_USU_ID][INT],
	[CLI_NOMBRE][NVARCHAR](255),
	[CLI_APE][NVARCHAR](255),
	[CLI_DOC][numeric](18,0),
	[CLI_TIPO_DOC][CHAR](1),
	[CLI_MAIL][NVARCHAR](255),
	[CLI_TELEFONO][INT],
	[CLI_CALLE][NVARCHAR](255),
	[CLI_PISO][numeric](18,0),
	[CLI_DEPTO][NVARCHAR](50),
	[CLI_LOCALIDAD][NVARCHAR](50),
	[CLI_COD_POSTAL][NVARCHAR](50),
	[CLI_FECHA_NAC][DATETIME],
	[CLI_CALLE_NRO][numeric](18,0),
	FOREIGN KEY (CLI_USU_ID) REFERENCES STR_NOMBRE_GRUPO.USUARIO(USU_ID)
)

GO

CREATE TABLE [STR_NOMBRE_GRUPO].[EMPRESA](
	[EMP_ID][INT] IDENTITY(0,1),
	PRIMARY KEY CLUSTERED (EMP_ID),
	[EMP_USU_ID][INT],
	[EMP_RAZON_SOCIAL][NVARCHAR](255),
	[EMP_MAIL][NVARCHAR](50),
	[EMP_TELEFONO][INT],
	[EMP_CALLE][NVARCHAR](255),
	[EMP_CALLE_NRO][numeric](18,0),
	[EMP_PISO][numeric](18,0),
	[EMP_DPTO][NVARCHAR](50),
	[EMP_LOCALIDAD][NVARCHAR](50),
	[EMP_COD_POSTAL][NVARCHAR](50),
	[EMP_CIUDAD][NVARCHAR](50),
	[EMP_CUIT][NVARCHAR](50),
	[EMP_NOM_CONTACTO][NVARCHAR](50),
	[EMP_FECHA_CREACION][DATETIME],
	FOREIGN KEY (EMP_USU_ID) REFERENCES STR_NOMBRE_GRUPO.USUARIO(USU_ID)
)
GO

--MIGRACIÓN DE DATOS
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[ROL] ([ROL_NOMBRE])
     VALUES ('Administrador')
	 INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[ROL] ([ROL_NOMBRE])
     VALUES ('Cliente') 
	 INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[ROL] ([ROL_NOMBRE])
     VALUES ('Empresa') 

	INSERT INTO STR_NOMBRE_GRUPO.CLIENTE(CLI_DOC,CLI_USU_ID,CLI_NOMBRE,CLI_APE,CLI_TIPO_DOC,CLI_MAIL,CLI_TELEFONO,CLI_CALLE,CLI_CALLE_NRO,CLI_PISO,CLI_DEPTO,CLI_LOCALIDAD,CLI_COD_POSTAL,CLI_FECHA_NAC)
			select distinct(Cli_Dni),NULL,Cli_Nombre,Cli_Apeliido,'1',Cli_Mail,NULL,Cli_Dom_Calle,Cli_Nro_Calle,Cli_Piso,Cli_Depto,NULL,Cli_Cod_Postal,Cli_Fecha_Nac
			FROM gd_esquema.Maestra
			where Cli_Dni is not NULL
			
 	INSERT INTO STR_NOMBRE_GRUPO.USUARIO(USU_USERNAME,USU_PASSWORD,USU_INTENTOS_LOGIN,USU_TIPO)
			SELECT CLI_DOC,CLI_APE,0,'C'
			FROM STR_NOMBRE_GRUPO.CLIENTE
	
	UPDATE STR_NOMBRE_GRUPO.CLIENTE 
	set CLI_USU_ID = (select USU_ID 
					from STR_NOMBRE_GRUPO.CLIENTE BIS
					join STR_NOMBRE_GRUPO.USUARIO on USU_USERNAME=BIS.CLI_DOC
					where BIS.CLI_DOC=STR_NOMBRE_GRUPO.CLIENTE.CLI_DOC)
	
	INSERT INTO STR_NOMBRE_GRUPO.EMPRESA(EMP_CUIT,EMP_USU_ID,EMP_RAZON_SOCIAL,EMP_MAIL,EMP_TELEFONO,EMP_CALLE,EMP_CALLE_NRO,EMP_PISO,EMP_DPTO,EMP_LOCALIDAD,EMP_CIUDAD,EMP_NOM_CONTACTO,EMP_FECHA_CREACION)
			SELECT distinct(Publ_Empresa_Cuit),NULL,Publ_Empresa_Razon_Social,Publ_Empresa_Mail,NULL,Publ_Cli_Dom_Calle,Publ_Empresa_Nro_Calle,Publ_Empresa_Piso,Publ_Empresa_Depto,NULL,NULL,NULL,Publ_Empresa_Fecha_Creacion
			from gd_esquema.Maestra
			where Publ_Empresa_Cuit is not NULL
			
	INSERT INTO STR_NOMBRE_GRUPO.USUARIO(USU_USERNAME,USU_PASSWORD,USU_INTENTOS_LOGIN,USU_TIPO)
			SELECT EMP_CUIT,EMP_RAZON_SOCIAL,0,'E'
			FROM STR_NOMBRE_GRUPO.EMPRESA
	
	UPDATE STR_NOMBRE_GRUPO.EMPRESA 
	set EMP_USU_ID = (select USU_ID 
					from STR_NOMBRE_GRUPO.EMPRESA BIS
					join STR_NOMBRE_GRUPO.USUARIO on USU_USERNAME=BIS.EMP_CUIT
					where BIS.EMP_CUIT=STR_NOMBRE_GRUPO.EMPRESA.EMP_CUIT)
					
					
	DECLARE @rol_id_cliente int
	SET @rol_id_cliente = (select ROL_ID from str_nombre_grupo.rol where ROL_NOMBRE = 'Cliente')
	DECLARE @rol_id_empresa int
	SET @rol_id_empresa = (select ROL_ID from str_nombre_grupo.rol where ROL_NOMBRE = 'Empresa')

	INSERT INTO [STR_NOMBRE_GRUPO].[USUARIO_ROL]
           ([USU_ROL_USUARIO_ID]
           ,[USU_ROL_ROL_ID])
     SELECT CLI_USU_ID, @rol_id_cliente from str_nombre_grupo.cliente

	 INSERT INTO [STR_NOMBRE_GRUPO].[USUARIO_ROL]
           ([USU_ROL_USUARIO_ID]
           ,[USU_ROL_ROL_ID])
     SELECT EMP_USU_ID, @rol_id_empresa from str_nombre_grupo.empresa

	 CREATE TABLE [STR_NOMBRE_GRUPO].[ESTADO](
		[ESTADO_ID][CHAR],
		[ESTADO_DESCRIPCION][NVARCHAR](50),
		PRIMARY KEY CLUSTERED (ESTADO_ID)
	)
	GO
	
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[ESTADO]([ESTADO_ID],[ESTADO_DESCRIPCION])
     VALUES
           ('B', 'Borrador'),
           ('A', 'Activa'),
           ('P', 'Pausada'),
           ('F', 'Finalizada')
	GO
	
	CREATE TABLE [STR_NOMBRE_GRUPO].[TIPO](
		[TIPO_ID][CHAR],
		[TIPO_DESCRIPCION][NVARCHAR](50),
		PRIMARY KEY CLUSTERED (TIPO_ID)
	)
	GO
	
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[TIPO]([TIPO_ID],[TIPO_DESCRIPCION])
     VALUES
           ('S', 'Subasta'), ('C', 'Compra Inmediata')
	GO


	CREATE TABLE [STR_NOMBRE_GRUPO].[VISIBILIDAD](
		[VIS_ID][numeric](18,0) IDENTITY(0,1),
		PRIMARY KEY CLUSTERED (VIS_ID),
		[VIS_DESCRIPCION][NVARCHAR](255),
		[VIS_PRECIO][numeric](18,2),
		[VIS_PORCENTAJE][numeric](18,2),
		[VIS_DURACION][INT] NULL,
		[VIS_BAJA][BIT] DEFAULT 0
	)
	GO
	
	SET IDENTITY_INSERT [STR_NOMBRE_GRUPO].[VISIBILIDAD] ON
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[VISIBILIDAD]
			   ([VIS_ID], [VIS_DESCRIPCION]
			   ,[VIS_PRECIO]
			   ,[VIS_PORCENTAJE])
	select distinct Publicacion_Visibilidad_Cod,Publicacion_Visibilidad_Desc,Publicacion_Visibilidad_Precio,Publicacion_Visibilidad_Porcentaje
				FROM gd_esquema.Maestra
				where Publicacion_Visibilidad_Cod is not NULL
	SET IDENTITY_INSERT [STR_NOMBRE_GRUPO].[VISIBILIDAD] OFF
	GO
	
	CREATE TABLE [STR_NOMBRE_GRUPO].[PUBLICACION](
	[PUB_ID][NUMERIC](18,0) IDENTITY(0,1),
	PRIMARY KEY CLUSTERED (PUB_ID),
	[PUB_TIPO_ID][CHAR],
	[PUB_STOCK][NUMERIC](18,0),
	[PUB_PRECIO][NUMERIC](18,2),
	[PUB_ESTADO_ID][CHAR],
	[PUB_FECHA_INICIO][DATETIME],
	[PUB_FECHA_FINALIZACION][DATETIME],
	[PUB_DESCRIPCION][NVARCHAR](255),
	[PUB_VIS_ID][numeric](18,0),
	[PUB_USU_ID][INT],
	[PUB_PERMITIR_PREGUNTAS][BIT] DEFAULT 0,
	FOREIGN KEY (PUB_TIPO_ID) REFERENCES STR_NOMBRE_GRUPO.TIPO(TIPO_ID),
	FOREIGN KEY (PUB_ESTADO_ID) REFERENCES STR_NOMBRE_GRUPO.ESTADO(ESTADO_ID),
	FOREIGN KEY (PUB_VIS_ID) REFERENCES STR_NOMBRE_GRUPO.VISIBILIDAD(VIS_ID),
	FOREIGN KEY (PUB_USU_ID) REFERENCES STR_NOMBRE_GRUPO.USUARIO(USU_ID)
	)
	GO
	
	SET IDENTITY_INSERT [STR_NOMBRE_GRUPO].[PUBLICACION] ON
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[PUBLICACION]
			   ([PUB_ID], [PUB_TIPO_ID],[PUB_STOCK],[PUB_PRECIO],[PUB_ESTADO_ID],[PUB_FECHA_INICIO],[PUB_FECHA_FINALIZACION]
			   ,[PUB_DESCRIPCION],[PUB_VIS_ID],[PUB_USU_ID])
	SELECT DISTINCT Publicacion_Cod, 
	LEFT(Publicacion_Tipo, 1),Publicacion_Stock, Publicacion_Precio, 'A',
	Publicacion_Fecha, Publicacion_Fecha_Venc,
	Publicacion_Descripcion, Publicacion_Visibilidad_Cod, 
	(CASE WHEN Publ_Cli_Mail IS NULL THEN
		(select EMP_USU_ID FROM [STR_NOMBRE_GRUPO].[EMPRESA] WHERE EMP_CUIT = Publ_Empresa_Cuit) 
		ELSE
		(select CLI_USU_ID FROM [STR_NOMBRE_GRUPO].[CLIENTE] WHERE Cli_Mail = Publ_Cli_Mail) 
	END)
	FROM gd_esquema.Maestra

	SET IDENTITY_INSERT [STR_NOMBRE_GRUPO].[PUBLICACION] OFF
	GO
	
	
	CREATE TABLE [STR_NOMBRE_GRUPO].[PREGUNTA](
		[PRE_ID][INT] IDENTITY(0,1),
		PRIMARY KEY CLUSTERED (PRE_ID),
		[PRE_PUB_ID][NUMERIC](18,0),
		[PRE_USU_ID][INT],
		[PRE_TEXTO][NVARCHAR](500),
		FOREIGN KEY (PRE_PUB_ID) REFERENCES STR_NOMBRE_GRUPO.PUBLICACION(PUB_ID),
		FOREIGN KEY (PRE_USU_ID) REFERENCES STR_NOMBRE_GRUPO.USUARIO(USU_ID)
	)
	GO

	CREATE TABLE [STR_NOMBRE_GRUPO].[RESPUESTA](
		[RES_PRE_ID][INT] IDENTITY(0,1),
		PRIMARY KEY CLUSTERED (RES_PRE_ID),
		[RES_TEXTO][NVARCHAR](500),
		[RES_FECHA][DATETIME],
		FOREIGN KEY (RES_PRE_ID) REFERENCES STR_NOMBRE_GRUPO.PREGUNTA(PRE_ID)
	)
	GO
	
	CREATE TABLE [STR_NOMBRE_GRUPO].[RUBRO](
		[RUBRO_ID][INT] IDENTITY(0,1),
		PRIMARY KEY CLUSTERED (RUBRO_ID),
		[RUBRO_DESCRIPCION][NVARCHAR](255) NOT NULL,
		[RUBRO_BAJA][BIT] DEFAULT 0
	)
	GO
	
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[RUBRO]([RUBRO_DESCRIPCION])
     SELECT DISTINCT PUBLICACION_RUBRO_DESCRIPCION FROM
     gd_esquema.Maestra
	GO

	CREATE TABLE [STR_NOMBRE_GRUPO].[PUBLICACION_RUBRO](
		[PUB_RUB_RUBRO_ID][INT],
		[PUB_RUB_PUB_ID][NUMERIC](18,0),
		PRIMARY KEY CLUSTERED (PUB_RUB_RUBRO_ID, PUB_RUB_PUB_ID),
		FOREIGN KEY (PUB_RUB_RUBRO_ID) REFERENCES STR_NOMBRE_GRUPO.RUBRO(RUBRO_ID),
		FOREIGN KEY (PUB_RUB_PUB_ID) REFERENCES STR_NOMBRE_GRUPO.PUBLICACION(PUB_ID)
	)
	GO
	
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[PUBLICACION_RUBRO]
           ([PUB_RUB_RUBRO_ID]
           ,[PUB_RUB_PUB_ID])
	SELECT DISTINCT 
		(SELECT RUBRO_ID FROM [STR_NOMBRE_GRUPO].RUBRO R WHERE R.RUBRO_DESCRIPCION = M.PUBLICACION_RUBRO_DESCRIPCION),
		PUBLICACION_COD
		FROM gd_esquema.Maestra M
	GO
	
	CREATE TABLE [STR_NOMBRE_GRUPO].[CALIFICACION](
		[CAL_ID][NUMERIC](18,0) IDENTITY(0,1),
		PRIMARY KEY CLUSTERED (CAL_ID),
		[CAL_CANT_ESTRELLAS][NUMERIC](18,0),
		[CAL_DESCRIPCION][NVARCHAR](255),
	)
	GO
	
	SET IDENTITY_INSERT [STR_NOMBRE_GRUPO].[CALIFICACION] ON
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[CALIFICACION]([CAL_ID],[CAL_CANT_ESTRELLAS],[CAL_DESCRIPCION])

	SELECT CALIFICACION_CODIGO, CALIFICACION_CANT_ESTRELLAS, CALIFICACION_DESCRIPCION
	FROM gd_esquema.Maestra
	  WHERE
	  CALIFICACION_CODIGO IS NOT NULL
	GO

	SET IDENTITY_INSERT [STR_NOMBRE_GRUPO].[CALIFICACION] OFF
	
	CREATE TABLE [STR_NOMBRE_GRUPO].[COMPRA](
		[COM_ID][INT] IDENTITY(0,1),
		PRIMARY KEY CLUSTERED (COM_ID),
		[COM_PUB_ID][NUMERIC](18,0),
		[COM_CANTIDAD][NUMERIC](18,0),
		[COM_FECHA][DATETIME],
		[COM_USU_ID][INT],
		[COM_CAL_ID][NUMERIC](18,0),
		FOREIGN KEY (COM_USU_ID) REFERENCES STR_NOMBRE_GRUPO.USUARIO(USU_ID),
		FOREIGN KEY (COM_CAL_ID) REFERENCES STR_NOMBRE_GRUPO.CALIFICACION(CAL_ID),
		FOREIGN KEY (COM_PUB_ID) REFERENCES STR_NOMBRE_GRUPO.PUBLICACION(PUB_ID)
	)
	GO

	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[COMPRA]([COM_PUB_ID],[COM_CANTIDAD],[COM_FECHA],[COM_USU_ID],[COM_CAL_ID])

	SELECT DISTINCT PUBLICACION_COD, COMPRA_CANTIDAD, COMPRA_FECHA, 
	(CASE WHEN Publ_Cli_Mail IS NULL THEN
			(select EMP_USU_ID FROM [STR_NOMBRE_GRUPO].[EMPRESA] WHERE EMP_CUIT = Publ_Empresa_Cuit) 
			ELSE
			(select CLI_USU_ID FROM [STR_NOMBRE_GRUPO].[CLIENTE] WHERE Cli_Mail = Publ_Cli_Mail) 
		END),
	CALIFICACION_CODIGO
	FROM gd_esquema.Maestra
	  WHERE 
	  COMPRA_CANTIDAD IS NOT NULL AND CALIFICACION_CODIGO IS NOT NULL
	GO
	
		
	CREATE TABLE [STR_NOMBRE_GRUPO].[OFERTA](
		[OFE_ID][INT] IDENTITY(0,1),
		PRIMARY KEY CLUSTERED (OFE_ID),
		[OFE_PUB_ID][NUMERIC](18,0),
		[OFE_MONTO][NUMERIC](18,2),
		[OFE_FECHA][DATETIME],
		[OFE_USU_ID][INT],
		[OFE_CAL_ID][NUMERIC](18,0),
		FOREIGN KEY (OFE_USU_ID) REFERENCES STR_NOMBRE_GRUPO.USUARIO(USU_ID),
		FOREIGN KEY (OFE_CAL_ID) REFERENCES STR_NOMBRE_GRUPO.CALIFICACION(CAL_ID),
		FOREIGN KEY (OFE_PUB_ID) REFERENCES STR_NOMBRE_GRUPO.PUBLICACION(PUB_ID)
	)
	GO
	
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[OFERTA]([OFE_PUB_ID],[OFE_MONTO],[OFE_FECHA],[OFE_USU_ID],[OFE_CAL_ID])

	SELECT DISTINCT PUBLICACION_COD, OFERTA_MONTO, OFERTA_FECHA,
	(CASE WHEN Publ_Cli_Mail IS NULL THEN
			(select EMP_USU_ID FROM [STR_NOMBRE_GRUPO].[EMPRESA] WHERE EMP_CUIT = Publ_Empresa_Cuit) 
			ELSE
			(select CLI_USU_ID FROM [STR_NOMBRE_GRUPO].[CLIENTE] WHERE Cli_Mail = Publ_Cli_Mail) 
		END),
	NULL
	FROM gd_esquema.Maestra M
	  WHERE OFERTA_MONTO IS NOT NULL
	  
	GO
	
	UPDATE [GD1C2014].[STR_NOMBRE_GRUPO].[OFERTA]
	SET OFE_CAL_ID = M.CALIFICACION_CODIGO
	FROM [GD1C2014].[STR_NOMBRE_GRUPO].[OFERTA] O, [GD1C2014].[gd_esquema].[Maestra] M
	WHERE 
	M.CALIFICACION_CODIGO IS NOT NULL AND M.PUBLICACION_COD = O.OFE_PUB_ID
	AND (SELECT MAX(OFE_MONTO) FROM [GD1C2014].[STR_NOMBRE_GRUPO].[OFERTA] O2
		WHERE O2.OFE_PUB_ID = O.OFE_PUB_ID
		GROUP BY O2.OFE_PUB_ID) = O.OFE_MONTO