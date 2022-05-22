CREATE DATABASE recetario;
USE recetario;

CREATE TABLE receta(
	cod_receta int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	fuente_receta varchar(100) NOT NULL,
	ubicacion_fisica_receta varchar(100) NOT NULL,
	lista_ingredientes_receta varchar(100) NOT NULL,
	utensilios_receta varchar(100) NOT NULL,
	comentario_receta varchar(100) NOT NULL,
	tiempo_receta time(7) NOT NULL,
	activo BIT DEFAULT 1 ON DELETE CASCADE
);

CREATE PROC agregar_receta
	@fuente_receta varchar(100),
	@ubicacion_fisica_receta varchar(100),
	@lista_ingredientes_receta varchar(100),
	@utensilios_receta varchar(100),
	@comentario_receta varchar(100),
	@tiempo_receta time(7)
AS
INSERT INTO receta
(
	fuente_receta,
	ubicacion_fisica_receta,
	lista_ingredientes_receta,
	utensilios_receta,
	comentario_receta, 
	tiempo_receta
)
VALUES
(
	@fuente_receta,
	@ubicacion_fisica_receta,
	@lista_ingredientes_receta,
	@utensilios_receta,
	@comentario_receta, 
	@tiempo_receta
);

CREATE PROC modificar_receta
	@cod_receta int,
	@fuente_receta varchar(100),
	@ubicacion_fisica_receta varchar(100),
	@lista_ingredientes_receta varchar(100),
	@utensilios_receta varchar(100),
	@comentario_receta varchar(100),
	@tiempo_receta time(7)
AS
UPDATE receta SET 
	fuente_receta = @fuente_receta,
	ubicacion_fisica_receta = @ubicacion_fisica_receta,
	lista_ingredientes_receta = @lista_ingredientes_receta,
	utensilios_receta = @utensilios_receta,
	comentario_receta = @comentario_receta, 
	tiempo_receta = @tiempo_receta
WHERE cod_receta = @cod_receta;

CREATE PROC eliminar_receta
	@cod_receta int
AS
DELETE FROM receta
WHERE cod_receta = @cod_receta;

CREATE PROC consultar_receta
	@cod_receta int
AS
SELECT * FROM receta
WHERE cod_receta = @cod_receta;

CREATE PROC mostrar_receta
AS
SELECT * FROM receta;

CREATE TABLE menu(
	cod_menu int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	cod_receta int NOT NULL,
	nombre_menu varchar(50) NOT NULL,
	precio_menu decimal(18, 2) NOT NULL,
	comentario_menu varchar(100) NOT NULL,
	activo BIT DEFAULT 1,
	CONSTRAINT fk_menu_receta FOREIGN KEY(cod_receta) REFERENCES receta(cod_receta) ON DELETE CASCADE
);


CREATE PROC agregar_menu
	@cod_receta int,
	@nombre_menu varchar(50),
	@precio_menu decimal(18, 2),
	@comentario_menu varchar(100)
AS
INSERT INTO menu
(
	cod_receta,
	nombre_menu,
	precio_menu,
	comentario_menu
)
VALUES
(
	@cod_receta,
	@nombre_menu,
	@precio_menu,
	@comentario_menu
);

CREATE PROC modificar_menu
	@cod_menu int,
	@cod_receta int,
	@nombre_menu varchar(50),
	@precio_menu decimal(18, 2),
	@comentario_menu varchar(100)
AS
UPDATE menu SET 
	cod_receta = @cod_receta,
	nombre_menu = @nombre_menu,
	precio_menu = @precio_menu,
	comentario_menu = @comentario_menu
WHERE cod_menu = @cod_menu;

CREATE PROC eliminar_menu
@cod_menu int
AS
DELETE FROM menu
WHERE cod_menu = @cod_menu;

CREATE PROC consultar_menu
@cod_menu int
AS
SELECT * FROM menu
WHERE cod_menu = @cod_menu;

CREATE PROC mostrar_menu
AS
SELECT * FROM menu;


CREATE TABLE plato(
	cod_plato int IDENTITY(1,1) NOT NULL,
	cod_receta int NOT NULL,
	tipo_plato varchar(50) NOT NULL,
	ingredientes_principal_plato varchar(100) NOT NULL,
	precio_plato decimal(18, 2) NOT NULL,
	comentario_adicional_plato varchar(100) NOT NULL,
	nombre_plato varchar(100) NOT NULL,
	calorias_plato varchar(100) NOT NULL,
	cant_util_ing_por_plato decimal(5, 2) NOT NULL,
	unidad_medida_por_plato varchar(100) NOT NULL,
	activo BIT DEFAULT 1,
	CONSTRAINT fk_plato_receta FOREIGN KEY(cod_receta) REFERENCES receta(cod_receta) ON DELETE CASCADE
);

CREATE PROC agregar_plato
	@cod_receta int,
	@tipo_plato varchar(50),
	@ingredientes_principal_plato varchar(100),
	@precio_plato decimal(18, 2),
	@comentario_adicional_plato varchar(100),
	@nombre_plato varchar(100),
	@calorias_plato varchar(100),
	@cant_util_ing_por_plato decimal(5, 2),
	@unidad_medida_por_plato varchar(100)
AS
INSERT INTO plato
(
	cod_receta,
	tipo_plato,
	ingredientes_principal_plato,
	precio_plato,
	comentario_adicional_plato,
	nombre_plato,
	calorias_plato,
	cant_util_ing_por_plato,
	unidad_medida_por_plato
)
VALUES
(
	@cod_receta,
	@tipo_plato,
	@ingredientes_principal_plato,
	@precio_plato,
	@comentario_adicional_plato,
	@nombre_plato,
	@calorias_plato,
	@cant_util_ing_por_plato,
	@unidad_medida_por_plato
);

CREATE PROC modificar_plato
	@cod_plato int,
	@cod_receta int,
	@tipo_plato varchar(50),
	@ingredientes_principal_plato varchar(100),
	@precio_plato decimal(18, 2),
	@comentario_adicional_plato varchar(100),
	@nombre_plato varchar(100),
	@calorias_plato varchar(100),
	@cant_util_ing_por_plato decimal(5, 2),
	@unidad_medida_por_plato varchar(100)
AS
UPDATE plato SET 
	cod_receta = @cod_receta,
	tipo_plato = @tipo_plato,
	ingredientes_principal_plato = @ingredientes_principal_plato,
	precio_plato = @precio_plato,
	comentario_adicional_plato = @comentario_adicional_plato,
	nombre_plato = @nombre_plato,
	calorias_plato = @calorias_plato,
	cant_util_ing_por_plato = @cant_util_ing_por_plato,
	unidad_medida_por_plato = @unidad_medida_por_plato
WHERE cod_plato = @cod_plato;

CREATE PROC eliminar_plato
@cod_plato int
AS
DELETE FROM plato
WHERE cod_plato = @cod_plato;

CREATE PROC consultar_plato
@cod_plato int
AS
SELECT * FROM plato
WHERE cod_plato = @cod_plato;

CREATE PROC mostrar_plato
AS
SELECT * FROM plato;



create proc consultar_cod_receta
as
SELECT cod_receta FROM receta