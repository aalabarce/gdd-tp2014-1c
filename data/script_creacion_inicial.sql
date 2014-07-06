GO
CREATE SCHEMA STR_NOMBRE_GRUPO

--CREACION DE TABLAS
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
	[FUN_ID][INT] IDENTITY(0,1),
	PRIMARY KEY CLUSTERED (FUN_ID),
	[FUN_NOMBRE][NVARCHAR](50)
)

GO
CREATE TABLE [STR_NOMBRE_GRUPO].[ROL_FUNCIONALIDAD](
	[ROL_FUN_ROL_ID][INT],
	[ROL_FUN_FUN_ID][INT],
	PRIMARY KEY CLUSTERED (ROL_FUN_ROL_ID,ROL_FUN_FUN_ID),
	FOREIGN KEY (ROL_FUN_ROL_ID) REFERENCES STR_NOMBRE_GRUPO.ROL(ROL_ID),
	FOREIGN KEY (ROL_FUN_FUN_ID) REFERENCES STR_NOMBRE_GRUPO.FUNCIONALIDAD(FUN_ID)
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
	[CLI_BAJA][BIT] DEFAULT 0,
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
	[EMP_BAJA][BIT] DEFAULT 0,
	
	FOREIGN KEY (EMP_USU_ID) REFERENCES STR_NOMBRE_GRUPO.USUARIO(USU_ID)
)
GO

 CREATE TABLE [STR_NOMBRE_GRUPO].[ESTADO](
	[ESTADO_ID][CHAR],
	[ESTADO_DESCRIPCION][NVARCHAR](50),
	PRIMARY KEY CLUSTERED (ESTADO_ID)
)
GO

CREATE TABLE [STR_NOMBRE_GRUPO].[TIPO](
	[TIPO_ID][CHAR],
	[TIPO_DESCRIPCION][NVARCHAR](50),
	PRIMARY KEY CLUSTERED (TIPO_ID)
)
GO

		
	CREATE TABLE [STR_NOMBRE_GRUPO].[VISIBILIDAD](
		[VIS_ID][numeric](18,0) IDENTITY(0,1),
		PRIMARY KEY CLUSTERED (VIS_ID),
		[VIS_CODIGO][numeric](18,0),
		[VIS_DESCRIPCION][NVARCHAR](255),
		[VIS_PRECIO][numeric](18,2),
		[VIS_PORCENTAJE][numeric](18,2),
		[VIS_DURACION][INT] NULL,
		[VIS_BAJA][BIT] DEFAULT 0
	)
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
		[RES_ID][INT] IDENTITY(0,1),
		PRIMARY KEY CLUSTERED (RES_ID),
		[RES_PRE_ID] [INT],
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

			
	CREATE TABLE [STR_NOMBRE_GRUPO].[PUBLICACION_RUBRO](
		[PUB_RUB_RUBRO_ID][INT],
		[PUB_RUB_PUB_ID][NUMERIC](18,0),
		PRIMARY KEY CLUSTERED (PUB_RUB_RUBRO_ID, PUB_RUB_PUB_ID),
		FOREIGN KEY (PUB_RUB_RUBRO_ID) REFERENCES STR_NOMBRE_GRUPO.RUBRO(RUBRO_ID),
		FOREIGN KEY (PUB_RUB_PUB_ID) REFERENCES STR_NOMBRE_GRUPO.PUBLICACION(PUB_ID)
	)
	GO
	
	
	CREATE TABLE [STR_NOMBRE_GRUPO].[CALIFICACION](
		[CAL_ID][NUMERIC](18,0) IDENTITY(0,1),
		PRIMARY KEY CLUSTERED (CAL_ID),
		[CAL_CANT_ESTRELLAS][NUMERIC](18,0),
		[CAL_DESCRIPCION][NVARCHAR](255),
	)
	GO
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
	CREATE TABLE [STR_NOMBRE_GRUPO].[OFERTA](
		[OFE_ID][INT] IDENTITY(0,1),
		PRIMARY KEY CLUSTERED (OFE_ID),
		[OFE_PUB_ID][NUMERIC](18,0),
		[OFE_MONTO][NUMERIC](18,2),
		[OFE_FECHA][DATETIME],
		[OFE_USU_ID][INT],
		FOREIGN KEY (OFE_USU_ID) REFERENCES STR_NOMBRE_GRUPO.USUARIO(USU_ID),
		FOREIGN KEY (OFE_PUB_ID) REFERENCES STR_NOMBRE_GRUPO.PUBLICACION(PUB_ID)
	)
	GO

		
	CREATE TABLE [STR_NOMBRE_GRUPO].[FORMA_PAGO](
		[FORMA_ID][INT] IDENTITY(0,1),
		PRIMARY KEY CLUSTERED (FORMA_ID),
		[FORMA_DESCRIPCION][NVARCHAR](255),
	)
	GO
	
	CREATE TABLE [STR_NOMBRE_GRUPO].[FACTURA](
		[FAC_ID][NUMERIC](18,0) IDENTITY(0,1),
		PRIMARY KEY CLUSTERED (FAC_ID),
		[FAC_FECHA][DATETIME],
		[FAC_TOTAL][NUMERIC](18,2),
		[FAC_USU_ID][INT],
		[FAC_FORMA_ID][INT],
		FOREIGN KEY (FAC_USU_ID) REFERENCES STR_NOMBRE_GRUPO.USUARIO(USU_ID),
		FOREIGN KEY (FAC_FORMA_ID) REFERENCES STR_NOMBRE_GRUPO.FORMA_PAGO(FORMA_ID)
	)
	GO

	CREATE TABLE [STR_NOMBRE_GRUPO].[ITEM_FACTURA](
	[ITEM_ID][INT] IDENTITY(0,1),
	PRIMARY KEY CLUSTERED (ITEM_ID),
	[ITEM_MONTO][NUMERIC](18,2),
	[ITEM_CANTIDAD][NUMERIC](18,0),
	[ITEM_PUB_ID][NUMERIC](18,0),
	[ITEM_FAC_ID][NUMERIC](18,0),
	FOREIGN KEY (ITEM_PUB_ID) REFERENCES STR_NOMBRE_GRUPO.PUBLICACION(PUB_ID),
	FOREIGN KEY (ITEM_FAC_ID) REFERENCES STR_NOMBRE_GRUPO.FACTURA(FAC_ID)
)
GO


CREATE TABLE [STR_NOMBRE_GRUPO].[TARJETA](
	[TAR_ID][INT] IDENTITY(0,1),
	PRIMARY KEY CLUSTERED (TAR_ID),
	[TAR_NUMERO][NUMERIC](18,0),
	[TAR_MES_VENC][NUMERIC](2,0),
	[TAR_ANIO_VENC][NUMERIC](2,0),
	[TAR_CODIGO_SEGURIDAD][NUMERIC](3,0),
	[TAR_FAC_ID][NUMERIC](18,0),
	FOREIGN KEY (TAR_FAC_ID) REFERENCES STR_NOMBRE_GRUPO.FACTURA(FAC_ID)
)
GO

--CREACION VISTAS

CREATE VIEW [STR_NOMBRE_GRUPO].[OFERTAS_ACTIVAS]
AS
SELECT PUB_STOCK, PUB_PRECIO, PUB_DESCRIPCION, PUB_USU_ID, PUB_ID
FROM STR_NOMBRE_GRUPO.PUBLICACION 
WHERE PUB_ESTADO_ID = 'A' AND PUB_STOCK > 0 AND PUB_FECHA_FINALIZACION > GETDATE()
 AND PUB_TIPO_ID = 'S'
 AND PUB_ID NOT IN (SELECT COM_PUB_ID FROM STR_NOMBRE_GRUPO.COMPRA)
 
 GO
 

CREATE VIEW [STR_NOMBRE_GRUPO].[COMPRAS_ACTIVAS]
AS
SELECT (PUB_STOCK - (SELECT (isnull(sum(COM_CANTIDAD),0)) FROM STR_NOMBRE_GRUPO.COMPRA WHERE COM_PUB_ID = PUB_ID)) as PUB_STOCK, PUB_PRECIO, PUB_DESCRIPCION, PUB_USU_ID, PUB_ID
FROM STR_NOMBRE_GRUPO.PUBLICACION 
WHERE PUB_ESTADO_ID = 'A' AND PUB_STOCK > 0 AND PUB_FECHA_FINALIZACION > GETDATE()
 AND PUB_TIPO_ID = 'C'

GO
 
 
--Creo la vista de la publicacion
create view [STR_NOMBRE_GRUPO].[PUBLICACION_COMPLETA]
as
select *
from STR_NOMBRE_GRUPO.PUBLICACION
join STR_NOMBRE_GRUPO.VISIBILIDAD V on V.VIS_ID=PUB_VIS_ID
join STR_NOMBRE_GRUPO.TIPO on TIPO_ID=PUB_TIPO_ID
join STR_NOMBRE_GRUPO.ESTADO on ESTADO_ID=PUB_ESTADO_ID

GO


--Creo la vista de las subastas(ofertadas o publicadas) 
create view [STR_NOMBRE_GRUPO].[SUBASTAS_USUARIOS]
as
SELECT Vendedor, Comprador, Publicacion, Fecha, CASE WHEN COM_CAL_ID is null THEN null ELSE CAL_CANT_ESTRELLAS END as Calificacion, Gano
FROM
(SELECT COM_CAL_ID, usu2.USU_USERNAME as Vendedor, usu1.USU_USERNAME as Comprador, PUB_DESCRIPCION as Publicacion, OFE_FECHA as Fecha,CASE WHEN COM_USU_ID=OFE_USU_ID AND OFE_FECHA=COM_FECHA THEN 'Si' ELSE 'No' END as Gano
FROM STR_NOMBRE_GRUPO.PUBLICACION
JOIN STR_NOMBRE_GRUPO.OFERTA ON OFE_PUB_ID=PUB_ID
JOIN STR_NOMBRE_GRUPO.USUARIO usu1 ON OFE_USU_ID=usu1.USU_ID
JOIN STR_NOMBRE_GRUPO.USUARIO usu2 ON PUB_USU_ID=usu2.USU_ID
LEFT OUTER JOIN STR_NOMBRE_GRUPO.COMPRA ON (PUB_ID=COM_PUB_ID AND COM_USU_ID=OFE_USU_ID AND OFE_FECHA=COM_FECHA) ) tab
LEFT OUTER JOIN STR_NOMBRE_GRUPO.CALIFICACION ON CAL_ID=COM_CAL_ID

GO


--Creo la vista de las compras directas 
create view [STR_NOMBRE_GRUPO].[COMPRAS_DIRECTAS_USUARIOS]
as
SELECT usu1.USU_USERNAME AS Vendedor,usu2.USU_USERNAME AS Comprador,PUB_DESCRIPCION AS Publicacion, COM_FECHA AS Fecha, CAL_CANT_ESTRELLAS AS Calificacion, COM_CANTIDAD AS Cantidad, PUB_PRECIO AS Monto_Unitario 
FROM STR_NOMBRE_GRUPO.USUARIO usu1
JOIN STR_NOMBRE_GRUPO.PUBLICACION ON PUB_USU_ID=usu1.USU_ID
JOIN STR_NOMBRE_GRUPO.COMPRA ON COM_PUB_ID=PUB_ID
JOIN STR_NOMBRE_GRUPO.CALIFICACION ON COM_CAL_ID=CAL_ID
JOIN STR_NOMBRE_GRUPO.USUARIO usu2 ON usu2.USU_ID=COM_USU_ID
WHERE PUB_TIPO_ID='C'
UNION
SELECT usu1.USU_USERNAME, usu2.USU_USERNAME, PUB_DESCRIPCION, COM_FECHA, COM_CAL_ID, COM_CANTIDAD, PUB_PRECIO
FROM STR_NOMBRE_GRUPO.USUARIO usu1
JOIN STR_NOMBRE_GRUPO.PUBLICACION ON PUB_USU_ID=usu1.USU_ID
JOIN STR_NOMBRE_GRUPO.COMPRA ON COM_PUB_ID=PUB_ID
JOIN STR_NOMBRE_GRUPO.USUARIO usu2 ON usu2.USU_ID=COM_USU_ID
WHERE COM_CAL_ID is null AND PUB_TIPO_ID='C'

GO


--Creo vista con las compras sin calificar
create view [STR_NOMBRE_GRUPO].[COMPRAS_SIN_CALIFICAR]
as
SELECT COM_ID, PUB_ID, PUB_DESCRIPCION As Publicacion, USU_USERNAME As Comprador, COM_FECHA As Fecha
FROM STR_NOMBRE_GRUPO.PUBLICACION
JOIN STR_NOMBRE_GRUPO.COMPRA ON COM_PUB_ID=PUB_ID
JOIN STR_NOMBRE_GRUPO.USUARIO ON COM_USU_ID=USU_ID
WHERE COM_CAL_ID is null

GO

--Creo vista con la cantidad de compras sin calificar trimestrales
create view [STR_NOMBRE_GRUPO].[CANTIDAD_SIN_CALIFICAR]
as
SELECT Usuario, A�o, Trimestre, COUNT(COM_ID) as Cantidad
FROM
(SELECT Comprador as Usuario,COM_ID, YEAR(Fecha) as A�o, 
CASE WHEN MONTH(Fecha)=1 or MONTH(Fecha)=2 or MONTH(Fecha)=3 THEN 'Primero'
WHEN MONTH(Fecha)=4 or MONTH(Fecha)=5 or MONTH(Fecha)=6 THEN 'Segundo'
WHEN MONTH(Fecha)=7 or MONTH(Fecha)=8 or MONTH(Fecha)=9 THEN 'Tercero'
WHEN MONTH(Fecha)=10 or MONTH(Fecha)=11 or MONTH(Fecha)=12 THEN 'Cuarto' END as Trimestre
FROM STR_NOMBRE_GRUPO.COMPRAS_SIN_CALIFICAR) as tab
GROUP BY Usuario, A�o, Trimestre

GO


--Creo vista de los vendedores y sus calificaciones trimestrales
create view [STR_NOMBRE_GRUPO].[CALIFICACIONES_VENDEDORES]
as
SELECT Usuario, A�o, Trimestre, AVG(Calificacion) as Promedio
FROM
(SELECT DATEPART(YEAR,COM_FECHA) As A�o, 
CASE WHEN 1=MONTH(COM_FECHA)or 2=MONTH(COM_FECHA)or 3=MONTH(COM_FECHA) THEN 'Primero' 
WHEN 4=MONTH(COM_FECHA)or 5=MONTH(COM_FECHA)or 6=MONTH(COM_FECHA) THEN 'Segundo'
WHEN 7=MONTH(COM_FECHA)or 8=MONTH(COM_FECHA)or 9=MONTH(COM_FECHA) THEN 'Tercero'
WHEN 10=MONTH(COM_FECHA)or 11=MONTH(COM_FECHA)or 12=MONTH(COM_FECHA) THEN 'Cuarto' END as Trimestre, 
USU_USERNAME As Usuario, CAL_ID, CAL_CANT_ESTRELLAS AS Calificacion
FROM STR_NOMBRE_GRUPO.COMPRA
JOIN STR_NOMBRE_GRUPO.CALIFICACION ON CAL_ID=COM_CAL_ID
JOIN STR_NOMBRE_GRUPO.PUBLICACION ON PUB_ID=COM_PUB_ID
JOIN STR_NOMBRE_GRUPO.USUARIO ON USU_ID=PUB_USU_ID) as tab
GROUP BY Usuario, A�o, Trimestre

GO


create view [STR_NOMBRE_GRUPO].[FACTURACIONES_VENDEDORES]
as
SELECT Usuario, A�o, Trimestre, SUM(Monto) as Facturacion
FROM
(SELECT FAC_ID, USU_USERNAME as Usuario, FAC_TOTAL as Monto, DATEPART(YEAR,FAC_FECHA) as A�o,
CASE WHEN DATEPART(MONTH,FAC_FECHA)=1 OR DATEPART(MONTH,FAC_FECHA)=2 OR DATEPART(MONTH,FAC_FECHA)=3 THEN 'Primero'
WHEN DATEPART(MONTH,FAC_FECHA)=4 OR DATEPART(MONTH,FAC_FECHA)=5 OR DATEPART(MONTH,FAC_FECHA)=6 THEN 'Segundo'
WHEN DATEPART(MONTH,FAC_FECHA)=7 OR DATEPART(MONTH,FAC_FECHA)=8 OR DATEPART(MONTH,FAC_FECHA)=9 THEN 'Tercero'
WHEN DATEPART(MONTH,FAC_FECHA)=10 OR DATEPART(MONTH,FAC_FECHA)=11 OR DATEPART(MONTH,FAC_FECHA)=12 THEN 'Cuarto' END as Trimestre
FROM STR_NOMBRE_GRUPO.FACTURA
JOIN STR_NOMBRE_GRUPO.USUARIO ON USU_ID=FAC_USU_ID) as Facturacion
GROUP BY Usuario, A�o, Trimestre

GO


create view [STR_NOMBRE_GRUPO].[PRODUCTOS_SIN_VENDER]
as
SELECT p.PUB_ID, USU_USERNAME as Usuario, A�o, Trimestre, VIS_DESCRIPCION as Visibilidad, Stock-SUM(COM_CANTIDAD) as CANT_SIN_VENDER
FROM 
(SELECT PUB_ID, PUB_STOCK  As Stock, COM_CANTIDAD, YEAR(PUB_FECHA_INICIO) as A�o,
CASE WHEN MONTH(PUB_FECHA_INICIO)=1 or MONTH(PUB_FECHA_INICIO)=2 or MONTH(PUB_FECHA_INICIO)=3 THEN 'Primero'
WHEN MONTH(PUB_FECHA_INICIO)=4 or MONTH(PUB_FECHA_INICIO)=5 or MONTH(PUB_FECHA_INICIO)=6 THEN 'Segundo'
WHEN MONTH(PUB_FECHA_INICIO)=7 or MONTH(PUB_FECHA_INICIO)=8 or MONTH(PUB_FECHA_INICIO)=9 THEN 'Tercero'
WHEN MONTH(PUB_FECHA_INICIO)=10 or MONTH(PUB_FECHA_INICIO)=11 or MONTH(PUB_FECHA_INICIO)=12 THEN 'Cuarto' END as Trimestre
FROM STR_NOMBRE_GRUPO.PUBLICACION
JOIN STR_NOMBRE_GRUPO.COMPRA ON PUB_ID=COM_PUB_ID
WHERE PUB_ESTADO_ID = 'F') as Tablita 
JOIN STR_NOMBRE_GRUPO.PUBLICACION p ON p.PUB_ID=Tablita.PUB_ID
JOIN STR_NOMBRE_GRUPO.USUARIO ON USU_ID= PUB_USU_ID
JOIN STR_NOMBRE_GRUPO.VISIBILIDAD ON VIS_ID=PUB_VIS_ID
GROUP BY p.PUB_ID, USU_USERNAME, A�o, Trimestre, Stock, VIS_DESCRIPCION

GO


--creacion de vista lineas de facturacion
CREATE VIEW [STR_NOMBRE_GRUPO].[LINEAS_FACTURACION]
AS
select PUB_ID AS CODIGO_PUB, VIS_PRECIO AS PRECIO, SUM(COM_CANTIDAD) AS CANTIDAD, 0 AS X, PUB_FECHA_FINALIZACION AS  FECHA_FIN, PUB_USU_ID AS USUARIO
from STR_NOMBRE_GRUPO.PUBLICACION
join STR_NOMBRE_GRUPO.VISIBILIDAD on PUB_VIS_ID=VIS_ID
right join STR_NOMBRE_GRUPO.COMPRA on COM_PUB_ID=PUB_ID
where not exists(SELECT * FROM STR_NOMBRE_GRUPO.ITEM_FACTURA WHERE ITEM_PUB_ID = PUB_ID)
group by PUB_ID, VIS_PRECIO, PUB_FECHA_FINALIZACION,PUB_USU_ID
union
select PUB_ID, 
CASE WHEN PUB_TIPO_ID = 'C' THEN PUB_PRECIO*COM_CANTIDAD*VIS_PORCENTAJE 
	ELSE PUB_PRECIO * VIS_PORCENTAJE END monto, 
COM_CANTIDAD, com_id , PUB_FECHA_FINALIZACION, PUB_USU_ID
from STR_NOMBRE_GRUPO.PUBLICACION
right join STR_NOMBRE_GRUPO.COMPRA on COM_PUB_ID=PUB_ID
join STR_NOMBRE_GRUPO.VISIBILIDAD on VIS_ID=PUB_VIS_ID
where not exists(SELECT * FROM STR_NOMBRE_GRUPO.ITEM_FACTURA WHERE ITEM_PUB_ID = PUB_ID)
GO


--Creo vista con las preguntas sin responder
create view [STR_NOMBRE_GRUPO].[PREGUNTAS_A_RESPONDER]
as
SELECT PUB_DESCRIPCION as Publicacion, PRE_TEXTO as Pregunta, PUB_USU_ID, PRE_ID
FROM STR_NOMBRE_GRUPO.PREGUNTA
JOIN STR_NOMBRE_GRUPO.PUBLICACION ON PUB_ID=PRE_PUB_ID
WHERE 0 = (SELECT COUNT(RES_ID) FROM STR_NOMBRE_GRUPO.RESPUESTA WHERE RES_PRE_ID=PRE_ID)

GO


create view [STR_NOMBRE_GRUPO].[PREGUNTAS_RESPUESTAS]
as
SELECT PUB_DESCRIPCION as Publicacion, PRE_TEXTO as Pregunta,RES_TEXTO as Respuesta, RES_FECHA as Fecha, PRE_USU_ID
FROM STR_NOMBRE_GRUPO.RESPUESTA
JOIN STR_NOMBRE_GRUPO.PREGUNTA ON PRE_ID=RES_PRE_ID
JOIN STR_NOMBRE_GRUPO.PUBLICACION ON PUB_ID=PRE_PUB_ID

GO



--CREACION DE PROCEDIMIENTOS

--CREACION PROCEDIMIENTO COMPRA_PAGINADA
CREATE PROCEDURE [STR_NOMBRE_GRUPO].[ComprasLIMIT]
@contador int,
@rubroId int = null,
@descripcion varchar(4000) = null,
@usuarioId int
AS
SELECT *
FROM
(
     SELECT (PUB_STOCK - (SELECT (isnull(sum(COM_CANTIDAD),0)) FROM STR_NOMBRE_GRUPO.COMPRA WHERE COM_PUB_ID = PUB_ID)) as PUB_STOCK,
PUB_PRECIO, PUB_DESCRIPCION, PUB_USU_ID, PUB_ID,
       ROW_NUMBER() OVER (ORDER BY VIS_PRECIO DESC) as rowNum
      FROM STR_NOMBRE_GRUPO.PUBLICACION, STR_NOMBRE_GRUPO.VISIBILIDAD      
 WHERE PUB_FECHA_FINALIZACION > GETDATE()
 AND PUB_TIPO_ID = 'C'
 AND PUB_DESCRIPCION LIKE '%' + @descripcion + '%'
 AND (PUB_ID IN (SELECT PUB_RUB_PUB_ID FROM STR_NOMBRE_GRUPO.PUBLICACION_RUBRO 
					WHERE PUB_RUB_RUBRO_ID = @rubroId) OR @rubroId IS NULL)
 AND (PUB_STOCK - (SELECT (isnull(sum(COM_CANTIDAD),0)) FROM STR_NOMBRE_GRUPO.COMPRA WHERE COM_PUB_ID = PUB_ID)) > 0
 AND VIS_ID = PUB_VIS_ID
 AND PUB_USU_ID <> @usuarioId
) sub
WHERE rowNum > @contador
 AND rowNum <= @contador + 10
 
GO
	
	
CREATE PROCEDURE PROCEDURE [STR_NOMBRE_GRUPO].[OfertasLIMIT] 
@contador int, 
@rubroId int = null,
@descripcion varchar(4000) = null,
@usuarioId int
AS 
SELECT * FROM ( 
SELECT PUB_STOCK, PUB_PRECIO, PUB_DESCRIPCION, PUB_USU_ID, PUB_ID, PUB_VIS_ID,
 ROW_NUMBER() OVER (ORDER BY VIS_PRECIO DESC)
 as rowNum
 FROM STR_NOMBRE_GRUPO.PUBLICACION, STR_NOMBRE_GRUPO.VISIBILIDAD 
 WHERE PUB_STOCK > 0 
 AND PUB_FECHA_FINALIZACION > GETDATE() 
 AND PUB_TIPO_ID = 'S' 
 AND PUB_ID NOT IN (SELECT COM_PUB_ID FROM STR_NOMBRE_GRUPO.COMPRA) 
 AND PUB_DESCRIPCION LIKE '%' + @descripcion + '%' 
 AND (PUB_ID IN 
 (SELECT PUB_RUB_PUB_ID FROM STR_NOMBRE_GRUPO.PUBLICACION_RUBRO 
 WHERE PUB_RUB_RUBRO_ID = @rubroId) OR @rubroId IS NULL) 
 AND VIS_ID = PUB_VIS_ID
 AND PUB_USU_ID <> @usuarioId ) 
 sub 
 WHERE rowNum > @contador 
 AND rowNum <= @contador + 10

GO




--MIGRACION DE DATOS

	DECLARE @rol_id_cliente int
	DECLARE @rol_id_empresa int
	DECLARE @rol_id_admin int
	declare @funcionalidad_id int
	
--creo los tres roles. me guardo en variables sus identities.
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[ROL] ([ROL_NOMBRE])
     VALUES ('Administrador');
    SET @rol_id_admin = @@IDENTITY;
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[ROL] ([ROL_NOMBRE])
     VALUES ('Cliente');
     SET @rol_id_cliente = @@IDENTITY;
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[ROL] ([ROL_NOMBRE])
     VALUES ('Empresa');
     SET @rol_id_empresa = @@IDENTITY;
     

--creo las funcionalidades y se las asigno a los roles correspondientes.
--login
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[FUNCIONALIDAD]
           ([FUN_NOMBRE])
     VALUES
           ('Login');
SET @funcionalidad_id = @@IDENTITY;
insert into [GD1C2014].[STR_NOMBRE_GRUPO].[ROL_FUNCIONALIDAD]([ROL_FUN_ROL_ID], [ROL_FUN_FUN_ID])
	VALUES(@rol_id_empresa, @funcionalidad_id),
		(@rol_id_cliente, @funcionalidad_id),
		(@rol_id_admin, @funcionalidad_id);
--abm rol
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[FUNCIONALIDAD]
           ([FUN_NOMBRE])
     VALUES
           ('ABM Rol');
SET @funcionalidad_id = @@IDENTITY;
insert into [GD1C2014].[STR_NOMBRE_GRUPO].[ROL_FUNCIONALIDAD]([ROL_FUN_ROL_ID], [ROL_FUN_FUN_ID])
	VALUES
		(@rol_id_admin, @funcionalidad_id);
--abm cliente
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[FUNCIONALIDAD]
           ([FUN_NOMBRE])
     VALUES
           ('ABM Cliente');
SET @funcionalidad_id = @@IDENTITY;
insert into [GD1C2014].[STR_NOMBRE_GRUPO].[ROL_FUNCIONALIDAD]([ROL_FUN_ROL_ID], [ROL_FUN_FUN_ID])
	VALUES
		(@rol_id_admin, @funcionalidad_id);
--abm empresa
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[FUNCIONALIDAD]
           ([FUN_NOMBRE])
     VALUES
           ('ABM Empresa');
SET @funcionalidad_id = @@IDENTITY;
insert into [GD1C2014].[STR_NOMBRE_GRUPO].[ROL_FUNCIONALIDAD]([ROL_FUN_ROL_ID], [ROL_FUN_FUN_ID])
	VALUES
		(@rol_id_admin, @funcionalidad_id);
--abm rubro
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[FUNCIONALIDAD]
           ([FUN_NOMBRE])
     VALUES
           ('ABM Rubro');
SET @funcionalidad_id = @@IDENTITY;
insert into [GD1C2014].[STR_NOMBRE_GRUPO].[ROL_FUNCIONALIDAD]([ROL_FUN_ROL_ID], [ROL_FUN_FUN_ID])
	VALUES
		(@rol_id_admin, @funcionalidad_id);
--abm Visibilidad de Publicaci�n
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[FUNCIONALIDAD]
           ([FUN_NOMBRE])
     VALUES
           ('ABM Visibilidad de Publicacion');
SET @funcionalidad_id = @@IDENTITY;
insert into [GD1C2014].[STR_NOMBRE_GRUPO].[ROL_FUNCIONALIDAD]([ROL_FUN_ROL_ID], [ROL_FUN_FUN_ID])
	VALUES
		(@rol_id_admin, @funcionalidad_id);
--Generar Publicaci�n
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[FUNCIONALIDAD]
           ([FUN_NOMBRE])
     VALUES
           ('Generar Publicacion');
SET @funcionalidad_id = @@IDENTITY;
insert into [GD1C2014].[STR_NOMBRE_GRUPO].[ROL_FUNCIONALIDAD]([ROL_FUN_ROL_ID], [ROL_FUN_FUN_ID])
	VALUES
		(@rol_id_cliente, @funcionalidad_id),
		(@rol_id_empresa, @funcionalidad_id);
--abm Editar publicacion
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[FUNCIONALIDAD]
           ([FUN_NOMBRE])
     VALUES
           ('Editar Publicacion');
SET @funcionalidad_id = @@IDENTITY;
insert into [GD1C2014].[STR_NOMBRE_GRUPO].[ROL_FUNCIONALIDAD]([ROL_FUN_ROL_ID], [ROL_FUN_FUN_ID])
	VALUES
		(@rol_id_cliente, @funcionalidad_id),
		(@rol_id_empresa, @funcionalidad_id);
--gestion de preguntas
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[FUNCIONALIDAD]
           ([FUN_NOMBRE])
     VALUES
           ('Gestion de Preguntas');
SET @funcionalidad_id = @@IDENTITY;
insert into [GD1C2014].[STR_NOMBRE_GRUPO].[ROL_FUNCIONALIDAD]([ROL_FUN_ROL_ID], [ROL_FUN_FUN_ID])
	VALUES
		(@rol_id_cliente, @funcionalidad_id),
		(@rol_id_empresa, @funcionalidad_id);
--comprar / ofertar
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[FUNCIONALIDAD]
           ([FUN_NOMBRE])
     VALUES
           ('Comprar / Ofertar');
SET @funcionalidad_id = @@IDENTITY;
insert into [GD1C2014].[STR_NOMBRE_GRUPO].[ROL_FUNCIONALIDAD]([ROL_FUN_ROL_ID], [ROL_FUN_FUN_ID])
	VALUES
		(@rol_id_cliente, @funcionalidad_id);
--Historial del cliente
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[FUNCIONALIDAD]
           ([FUN_NOMBRE])
     VALUES
           ('Historial del Cliente');
SET @funcionalidad_id = @@IDENTITY;
insert into [GD1C2014].[STR_NOMBRE_GRUPO].[ROL_FUNCIONALIDAD]([ROL_FUN_ROL_ID], [ROL_FUN_FUN_ID])
	VALUES
		(@rol_id_cliente, @funcionalidad_id),
		(@rol_id_empresa, @funcionalidad_id);
--Calificar al vendedor
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[FUNCIONALIDAD]
           ([FUN_NOMBRE])
     VALUES
           ('Calificar al Vendedor');
SET @funcionalidad_id = @@IDENTITY;
insert into [GD1C2014].[STR_NOMBRE_GRUPO].[ROL_FUNCIONALIDAD]([ROL_FUN_ROL_ID], [ROL_FUN_FUN_ID])
	VALUES
		(@rol_id_cliente, @funcionalidad_id);
--facturar publicaciones
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[FUNCIONALIDAD]
           ([FUN_NOMBRE])
     VALUES
           ('Facturar Publicaciones');
SET @funcionalidad_id = @@IDENTITY;
insert into [GD1C2014].[STR_NOMBRE_GRUPO].[ROL_FUNCIONALIDAD]([ROL_FUN_ROL_ID], [ROL_FUN_FUN_ID])
	VALUES
		(@rol_id_cliente, @funcionalidad_id),
		(@rol_id_empresa, @funcionalidad_id);
--listado estadistico
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[FUNCIONALIDAD]
           ([FUN_NOMBRE])
     VALUES
           ('Listado estadistico');
SET @funcionalidad_id = @@IDENTITY;
insert into [GD1C2014].[STR_NOMBRE_GRUPO].[ROL_FUNCIONALIDAD]([ROL_FUN_ROL_ID], [ROL_FUN_FUN_ID])
	VALUES
		(@rol_id_admin, @funcionalidad_id);

--inserto clientes
	INSERT INTO STR_NOMBRE_GRUPO.CLIENTE(CLI_DOC,CLI_USU_ID,CLI_NOMBRE,CLI_APE,CLI_TIPO_DOC,CLI_MAIL,CLI_TELEFONO,CLI_CALLE,CLI_CALLE_NRO,CLI_PISO,CLI_DEPTO,CLI_LOCALIDAD,CLI_COD_POSTAL,CLI_FECHA_NAC)
			select distinct(Cli_Dni),NULL,Cli_Nombre,Cli_Apeliido,'1',Cli_Mail,NULL,Cli_Dom_Calle,Cli_Nro_Calle,Cli_Piso,Cli_Depto,NULL,Cli_Cod_Postal,Cli_Fecha_Nac
			FROM gd_esquema.Maestra
			where Cli_Dni is not NULL

--inserto usuario cliente
 	INSERT INTO STR_NOMBRE_GRUPO.USUARIO(USU_USERNAME,USU_PASSWORD,USU_INTENTOS_LOGIN,USU_TIPO)
			SELECT CLI_DOC, '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4',0,'C'
			FROM STR_NOMBRE_GRUPO.CLIENTE
	
--modifico el id de usuario en la tabla cliente
	UPDATE STR_NOMBRE_GRUPO.CLIENTE 
	set CLI_USU_ID = (select USU_ID 
					from STR_NOMBRE_GRUPO.CLIENTE BIS
					join STR_NOMBRE_GRUPO.USUARIO on USU_USERNAME=BIS.CLI_DOC
					where BIS.CLI_DOC=STR_NOMBRE_GRUPO.CLIENTE.CLI_DOC)
	
--inserto empresas
	INSERT INTO STR_NOMBRE_GRUPO.EMPRESA(EMP_CUIT,EMP_USU_ID,EMP_RAZON_SOCIAL,EMP_MAIL,EMP_TELEFONO,EMP_CALLE,EMP_CALLE_NRO,EMP_PISO,EMP_DPTO,EMP_LOCALIDAD,EMP_CIUDAD,EMP_NOM_CONTACTO,EMP_FECHA_CREACION)
			SELECT distinct(Publ_Empresa_Cuit),NULL,Publ_Empresa_Razon_Social,Publ_Empresa_Mail,NULL,Publ_Cli_Dom_Calle,Publ_Empresa_Nro_Calle,Publ_Empresa_Piso,Publ_Empresa_Depto,NULL,NULL,NULL,Publ_Empresa_Fecha_Creacion
			from gd_esquema.Maestra
			where Publ_Empresa_Cuit is not NULL
--inserto usuario empresa		
	INSERT INTO STR_NOMBRE_GRUPO.USUARIO(USU_USERNAME,USU_PASSWORD,USU_INTENTOS_LOGIN,USU_TIPO)
			SELECT EMP_CUIT, '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4',0,'E'
			FROM STR_NOMBRE_GRUPO.EMPRESA
--modifico el id de usuario en la tabla empresa
	UPDATE STR_NOMBRE_GRUPO.EMPRESA 
	set EMP_USU_ID = (select USU_ID 
					from STR_NOMBRE_GRUPO.EMPRESA BIS
					join STR_NOMBRE_GRUPO.USUARIO on USU_USERNAME=BIS.EMP_CUIT
					where BIS.EMP_CUIT=STR_NOMBRE_GRUPO.EMPRESA.EMP_CUIT)

--inserto rol de usuarios cliente
	INSERT INTO [STR_NOMBRE_GRUPO].[USUARIO_ROL]
           ([USU_ROL_USUARIO_ID]
           ,[USU_ROL_ROL_ID])
     SELECT CLI_USU_ID, @rol_id_cliente from str_nombre_grupo.cliente
	 
--inserto rol de usuarios empresa
	 INSERT INTO [STR_NOMBRE_GRUPO].[USUARIO_ROL]
           ([USU_ROL_USUARIO_ID]
           ,[USU_ROL_ROL_ID])
     SELECT EMP_USU_ID, @rol_id_empresa from str_nombre_grupo.empresa
	
--inserto un usuario ADMIN
DECLARE @usuarioAdminId int;
INSERT INTO STR_NOMBRE_GRUPO.USUARIO(USU_USERNAME,USU_PASSWORD,USU_INTENTOS_LOGIN,USU_TIPO)
VALUES('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918',0,'A');
SET @usuarioAdminId = @@IDENTITY;
INSERT INTO [STR_NOMBRE_GRUPO].[USUARIO_ROL]
           ([USU_ROL_USUARIO_ID]
           ,[USU_ROL_ROL_ID])
VALUES(@usuarioAdminId, @rol_id_admin);

--inserto estados de publicacion
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[ESTADO]([ESTADO_ID],[ESTADO_DESCRIPCION])
     VALUES
           ('B', 'Borrador'),
           ('A', 'Activa'),
           ('P', 'Pausada'),
           ('F', 'Finalizada')
	GO
	
--inserto tipos de publicacion
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[TIPO]([TIPO_ID],[TIPO_DESCRIPCION])
     VALUES
           ('S', 'Subasta'), ('C', 'Compra Inmediata')
	GO


--inserto visibilidades.
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[VISIBILIDAD]
			   ([VIS_CODIGO], [VIS_DESCRIPCION]
			   ,[VIS_PRECIO]
			   ,[VIS_PORCENTAJE], [VIS_DURACION])
	select distinct Publicacion_Visibilidad_Cod,Publicacion_Visibilidad_Desc,Publicacion_Visibilidad_Precio,Publicacion_Visibilidad_Porcentaje,
				DATEDIFF ( d , Publicacion_Fecha , Publicacion_Fecha_Venc )
				FROM gd_esquema.Maestra
				where Publicacion_Visibilidad_Cod is not NULL
	GO

--inserto publicaciones
	SET IDENTITY_INSERT [STR_NOMBRE_GRUPO].[PUBLICACION] ON
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[PUBLICACION]
			   ([PUB_ID], [PUB_TIPO_ID],[PUB_STOCK],[PUB_PRECIO],[PUB_ESTADO_ID],[PUB_FECHA_INICIO],[PUB_FECHA_FINALIZACION]
			   ,[PUB_DESCRIPCION],[PUB_VIS_ID],[PUB_USU_ID])
	SELECT DISTINCT Publicacion_Cod, 
	LEFT(Publicacion_Tipo, 1),Publicacion_Stock, Publicacion_Precio, 'A',
	Publicacion_Fecha, Publicacion_Fecha_Venc,
	Publicacion_Descripcion, (SELECT vis_id from [STR_NOMBRE_GRUPO].[visibilidad] where vis_codigo = Publicacion_Visibilidad_Cod), 
	(CASE WHEN Publ_Cli_Mail IS NULL THEN
		(select EMP_USU_ID FROM [STR_NOMBRE_GRUPO].[EMPRESA] WHERE EMP_CUIT = Publ_Empresa_Cuit) 
		ELSE
		(select CLI_USU_ID FROM [STR_NOMBRE_GRUPO].[CLIENTE] WHERE Cli_Mail = Publ_Cli_Mail) 
	END)
	FROM gd_esquema.Maestra

	SET IDENTITY_INSERT [STR_NOMBRE_GRUPO].[PUBLICACION] OFF
	GO
--inserto rubros
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[RUBRO]([RUBRO_DESCRIPCION])
     SELECT DISTINCT PUBLICACION_RUBRO_DESCRIPCION FROM
     gd_esquema.Maestra
	GO
--inserto info en tabla publiacion_rubro
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[PUBLICACION_RUBRO]
           ([PUB_RUB_RUBRO_ID]
           ,[PUB_RUB_PUB_ID])
	SELECT DISTINCT 
		(SELECT RUBRO_ID FROM [STR_NOMBRE_GRUPO].RUBRO R WHERE R.RUBRO_DESCRIPCION = M.PUBLICACION_RUBRO_DESCRIPCION),
		PUBLICACION_COD
		FROM gd_esquema.Maestra M
	GO

--inserto calificaciones
	SET IDENTITY_INSERT [STR_NOMBRE_GRUPO].[CALIFICACION] ON
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[CALIFICACION]([CAL_ID],[CAL_CANT_ESTRELLAS],[CAL_DESCRIPCION])

	SELECT CALIFICACION_CODIGO, CALIFICACION_CANT_ESTRELLAS, CALIFICACION_DESCRIPCION
	FROM gd_esquema.Maestra
	  WHERE
	  CALIFICACION_CODIGO IS NOT NULL
	GO

	SET IDENTITY_INSERT [STR_NOMBRE_GRUPO].[CALIFICACION] OFF

	--inserto compras
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[COMPRA]([COM_PUB_ID],[COM_CANTIDAD],[COM_FECHA],[COM_USU_ID],[COM_CAL_ID])

	SELECT DISTINCT PUBLICACION_COD, COMPRA_CANTIDAD, COMPRA_FECHA, 
	(select CLI_USU_ID FROM [STR_NOMBRE_GRUPO].[CLIENTE] c WHERE c.Cli_doc = M.Cli_dni),
	CALIFICACION_CODIGO
	FROM gd_esquema.Maestra M
	  WHERE 
	  COMPRA_CANTIDAD IS NOT NULL AND CALIFICACION_CODIGO IS NOT NULL
	GO
	

--inserto ofertas
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[OFERTA]([OFE_PUB_ID],[OFE_MONTO],[OFE_FECHA],[OFE_USU_ID])

	SELECT DISTINCT PUBLICACION_COD, OFERTA_MONTO, OFERTA_FECHA,
	(select CLI_USU_ID FROM [STR_NOMBRE_GRUPO].[CLIENTE] c WHERE c.Cli_doc = M.Cli_dni)
	FROM gd_esquema.Maestra M
	  WHERE OFERTA_MONTO IS NOT NULL
	  
	GO


--inserto formas de pago
	INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[FORMA_PAGO]([FORMA_DESCRIPCION])
	VALUES ('Efectivo'),('Tarjeta de Credito');


--inserto facturas
SET IDENTITY_INSERT [STR_NOMBRE_GRUPO].[FACTURA] ON
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[FACTURA]([FAC_ID], [FAC_FECHA],[FAC_TOTAL],[FAC_USU_ID],[FAC_FORMA_ID])
 select distinct Factura_Nro, Factura_Fecha, factura_total,
 (CASE WHEN Publ_Cli_Mail IS NULL THEN
		(select EMP_USU_ID FROM [STR_NOMBRE_GRUPO].[EMPRESA] WHERE EMP_CUIT = Publ_Empresa_Cuit) 
		ELSE
		(select CLI_USU_ID FROM [STR_NOMBRE_GRUPO].[CLIENTE] WHERE Cli_Mail = Publ_Cli_Mail) 
	END),
 (select FORMA_ID FROM [STR_NOMBRE_GRUPO].[FORMA_PAGO] WHERE FORMA_DESCRIPCION = Forma_Pago_Desc)
  from [GD1C2014].[gd_esquema].[Maestra]
  WHERE Factura_Nro is not null
  
SET IDENTITY_INSERT [STR_NOMBRE_GRUPO].[FACTURA] OFF
GO
--inserto items factura
INSERT INTO [GD1C2014].[STR_NOMBRE_GRUPO].[ITEM_FACTURA]([ITEM_MONTO],[ITEM_CANTIDAD],[ITEM_PUB_ID],[ITEM_FAC_ID])
SELECT DISTINCT item_factura_monto, item_factura_cantidad, publicacion_cod, factura_nro
from [GD1C2014].[gd_esquema].[Maestra]
where factura_nro is not null
GO
