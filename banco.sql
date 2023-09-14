
CREATE DATABASE IF NOT EXISTS academico;

USE academico;

CREATE TABLE aluno (

	id				int				NOT NULL AUTO_INCREMENT,
	matricula		varchar(15)		NOT NULL,
	data_nasc		datetime		NOT NULL,
	nome			varchar(100)	NOT NULL,
	endereco		varchar(100)	NOT NULL,
	bairro			varchar(100)	NOT NULL,
	cidade			varchar(100)	NOT NULL,
	estado			varchar(02)		NOT NULL,
	senha			varchar(60)		NOT NULL,
	PRIMARY KEY (id)

);

CREATE TABLE curso (
	id				int				NOT NULL AUTO_INCREMENT,
	nome			VARCHAR(100)	NOT NULL,
	tipo			VARCHAR(100)	NOT NULL, 
	-- Técnico, Tecnólogo, Bacharelado, Licenciatura
	ano_criacao		INT				NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE professor (
	id				int				NOT NULL AUTO_INCREMENT,
	matricula		VARCHAR(15)		NOT NULL,
	dt_nascimento	DATETIME		NOT NULL,
	nome			VARCHAR(100)	NOT NULL,
	titulacao		VARCHAR(100)	NOT NULL,
	-- Graduação, Especialização, Mestrado, Doutorado
	area_formacao	VARCHAR(100)	NOT NULL,
	endereco		VARCHAR(100)	NOT NULL,
	bairro			VARCHAR(100)	NOT NULL,
	cidade			VARCHAR(100)	NOT NULL,
	estado			VARCHAR(02)		NOT NULL,
	PRIMARY KEY (id)
);