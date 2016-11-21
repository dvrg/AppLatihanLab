CREATE DATABASE db_psb;

GO

USE db_psb;

GO

CREATE TABLE tb_asal_sekolah (
	id_sekolah CHAR(5) NOT NULL PRIMARY KEY,
	nama_sekolah VARCHAR(50) NOT NULL,
	alamat_sekolah VARCHAR(100) NULL,
	telp VARCHAR(15) NULL
);

GO

CREATE TABLE tb_staff (
	id_staff CHAR(5) NOT NULL PRIMARY KEY,
	nama_staff VARCHAR(50) NOT NULL,
	jabatan VARCHAR(25) NOT NULL,
	password VARCHAR(10) NOT NULL
);

GO

CREATE TABLE tb_pekerjaan (
	id_pekerjaan TINYINT NOT NULL PRIMARY KEY,
	nama_pekerjaan VARCHAR(30) NOT NULL
);

GO

CREATE TABLE tb_pendaftar (
	id_pendaftar CHAR(10) NOT NULL PRIMARY KEY,
	nama_pendaftar VARCHAR(50) NOT NULL,
	jenis_kelamin CHAR(1) NOT NULL DEFAULT 'L',
	tanggal_lahir SMALLDATETIME NOT NULL,
	alamat_pendaftar VARCHAR(100) NOT NULL,
	nilai_ujian REAL NOT NULL,
	id_sekolah CHAR(5) NOT NULL FOREIGN KEY
		REFERENCES tb_asal_sekolah (id_sekolah)
		ON UPDATE CASCADE ON DELETE NO ACTION,
	nama_ayah VARCHAR(50) NOT NULL,
	nama_ibu VARCHAR(50) NOT NULL,
	pekerjaan_ayah TINYINT NOT NULL FOREIGN KEY
		REFERENCES tb_pekerjaan (id_pekerjaan)
		ON UPDATE CASCADE ON DELETE NO ACTION,
	alamat_orang_tua VARCHAR(100) NOT NULL,
	telp_orang_tua VARCHAR(15) NOT NULL,
	id_staff CHAR(5) NOT NULL FOREIGN KEY
		REFERENCES tb_staff (id_staff)
		ON UPDATE CASCADE ON DELETE NO ACTION
);

GO

INSERT INTO tb_staff VALUES ('ST-01','Ani Sanjaya Putri','Staff Administrasi','01anisp');