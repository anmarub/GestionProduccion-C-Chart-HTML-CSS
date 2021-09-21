CREATE SCHEMA DiseñoRelacionaGestionProduccion;
GO

CREATE TABLE DiseñoRelacionaGestionProduccion.tb_inventory ( 
 );
GO

CREATE TABLE DiseñoRelacionaGestionProduccion.tb_status_production_order ( 
	id_status_op         int NOT NULL    ,
	code_status_op       varchar(10) NOT NULL    ,
	name                 varchar(150) NOT NULL    ,
	CONSTRAINT Pk_status_production_order_id_oc PRIMARY KEY  ( id_status_op ) 
 );
GO

CREATE TABLE DiseñoRelacionaGestionProduccion.tb_status_purchanse_order ( 
	id_status_oc         int NOT NULL    ,
	code_status_oc       varchar(1) NOT NULL    ,
	name                 varchar(100) NOT NULL    ,
	CONSTRAINT Pk_status_purchanse_order_id_status_op PRIMARY KEY  ( id_status_oc ) 
 );
GO

CREATE TABLE DiseñoRelacionaGestionProduccion.tb_type_document ( 
	id_document          int NOT NULL    ,
	code_document        varchar(15) NOT NULL    ,
	name                 varchar(150) NOT NULL    ,
	CONSTRAINT Pk_tb_type_document_id_document PRIMARY KEY  ( id_document ) 
 );
GO

CREATE TABLE DiseñoRelacionaGestionProduccion.tb_type_product ( 
	id_type_product      int NOT NULL    ,
	code_product         varchar(10) NOT NULL    ,
	name                 varchar(100) NOT NULL    ,
	CONSTRAINT Pk_tb_type_product_id_product PRIMARY KEY  ( id_type_product ) 
 );
GO

CREATE TABLE DiseñoRelacionaGestionProduccion.tb_user ( 
	id_user              int NOT NULL    ,
	usuario              varchar(256) NOT NULL    ,
	nombre               varchar(150) NOT NULL    ,
	apellido             varchar(150) NOT NULL    ,
	rol                  int NOT NULL    ,
	CONSTRAINT Pk_tb_user_id_user PRIMARY KEY  ( id_user ) 
 );
GO

CREATE TABLE DiseñoRelacionaGestionProduccion.tb_customer ( 
	id_customer          int NOT NULL    ,
	name                 varchar(100) NOT NULL    ,
	identification       varchar(15) NOT NULL    ,
	email                varchar(150) NOT NULL    ,
	direcction           varchar(150) NOT NULL    ,
	id_type_identification int NOT NULL    ,
	CONSTRAINT Pk_tb_customer_id_customer PRIMARY KEY  ( id_customer ) 
 );
GO

CREATE TABLE DiseñoRelacionaGestionProduccion.tb_product ( 
	id_product           int NOT NULL    ,
	code_product         varchar(20) NOT NULL    ,
	name                 varchar(100) NOT NULL    ,
	type_product         int NOT NULL    ,
	date_expiration      date     ,
	date_manufacturing   date NOT NULL    ,
	qty_available        int NOT NULL CONSTRAINT [defo_tb_product_qty_available] DEFAULT 0   ,
	qty_production       int NOT NULL CONSTRAINT [defo_tb_product_qty_production] DEFAULT 0   ,
	qty_order            int NOT NULL CONSTRAINT [defo_tb_product_qty_order] DEFAULT 0   ,
	lote                 varchar(50)     ,
	CONSTRAINT Pk_tb_product_id_product PRIMARY KEY  ( id_product ) 
 );
GO

CREATE TABLE DiseñoRelacionaGestionProduccion.tb_production_order ( 
	id_op                int NOT NULL    ,
	code_order           varchar(50) NOT NULL    ,
	date_delivery        date NOT NULL    ,
	delivery             varchar(150) NOT NULL    ,
	id_status_op         int NOT NULL    ,
	CONSTRAINT Pk_tb_production_order_id_op PRIMARY KEY  ( id_op ) 
 );
GO

CREATE TABLE DiseñoRelacionaGestionProduccion.tb_purchanse_order ( 
	id_oc                int NOT NULL    ,
	id_customer          int NOT NULL    ,
	id_status_oc         int NOT NULL    ,
	date_delivery        date NOT NULL    ,
	CONSTRAINT Pk_tb_purchanse_order_id_oc PRIMARY KEY  ( id_oc ) 
 );
GO

CREATE TABLE DiseñoRelacionaGestionProduccion.oc_details_fk_product ( 
	id                   int NOT NULL    ,
	id_purchanse_order   int NOT NULL    ,
	id_product           int NOT NULL    ,
	qty                  int NOT NULL    ,
	CONSTRAINT Pk_oc_details_id PRIMARY KEY  ( id ) 
 );
GO

CREATE TABLE DiseñoRelacionaGestionProduccion.op_details_fk_product ( 
	id                   int NOT NULL    ,
	id_production_order  int NOT NULL    ,
	id_product           int NOT NULL    ,
	qty_production       int NOT NULL    ,
	CONSTRAINT Pk_op_details_fk_product_id PRIMARY KEY  ( id ) 
 );
GO

ALTER TABLE DiseñoRelacionaGestionProduccion.oc_details_fk_product ADD CONSTRAINT oc_details_fk_product_Fk_purchanse_order FOREIGN KEY ( id_purchanse_order ) REFERENCES DiseñoRelacionaGestionProduccion.tb_purchanse_order( id_oc ) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

ALTER TABLE DiseñoRelacionaGestionProduccion.oc_details_fk_product ADD CONSTRAINT oc_details_fk_product_Fk_product FOREIGN KEY ( id_product ) REFERENCES DiseñoRelacionaGestionProduccion.tb_product( id_product ) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

ALTER TABLE DiseñoRelacionaGestionProduccion.op_details_fk_product ADD CONSTRAINT op_details_fk_product_Fk_production_order FOREIGN KEY ( id_production_order ) REFERENCES DiseñoRelacionaGestionProduccion.tb_production_order( id_op ) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

ALTER TABLE DiseñoRelacionaGestionProduccion.op_details_fk_product ADD CONSTRAINT op_details_fk_product_Fk_product FOREIGN KEY ( id_product ) REFERENCES DiseñoRelacionaGestionProduccion.tb_product( id_product ) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

ALTER TABLE DiseñoRelacionaGestionProduccion.tb_customer ADD CONSTRAINT customer_fk_type_identification FOREIGN KEY ( id_type_identification ) REFERENCES DiseñoRelacionaGestionProduccion.tb_type_document( id_document ) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

ALTER TABLE DiseñoRelacionaGestionProduccion.tb_product ADD CONSTRAINT fk_tb_product_tb_type_product FOREIGN KEY ( type_product ) REFERENCES DiseñoRelacionaGestionProduccion.tb_type_product( id_type_product ) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

ALTER TABLE DiseñoRelacionaGestionProduccion.tb_production_order ADD CONSTRAINT fk_tb_production_order FOREIGN KEY ( id_status_op ) REFERENCES DiseñoRelacionaGestionProduccion.tb_status_production_order( id_status_op ) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

ALTER TABLE DiseñoRelacionaGestionProduccion.tb_purchanse_order ADD CONSTRAINT purchanse_order_Fk_id_status FOREIGN KEY ( id_status_oc ) REFERENCES DiseñoRelacionaGestionProduccion.tb_status_purchanse_order( id_status_oc ) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

ALTER TABLE DiseñoRelacionaGestionProduccion.tb_purchanse_order ADD CONSTRAINT tb_purchanse_order_Fk_customer FOREIGN KEY ( id_customer ) REFERENCES DiseñoRelacionaGestionProduccion.tb_customer( id_customer ) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
