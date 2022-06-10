create database restoran;
use restoran;


CREATE TABLE r_musteriler
(
	m_id		  	varchar(64) 	not null,
    m_ad 			varchar(64) 	not null,
    m_soyad    		varchar(64) 	not null,
    m_tel       	varchar(25) 	not null,
   
    
    primary key(m_id)
);


CREATE TABLE r_odemeler
(
	o_id		varchar(64) 	not null,
	m_id		varchar(64) 	not null,    
    o_tarih 	datetime 		not null,
	o_tutar 	float 			not null,    
    o_tur 		varchar(25) 	not null,   

   primary key(o_id),
   
   foreign key(m_id) 	references r_musteriler(m_id)
		on delete cascade on update cascade
);

CREATE TABLE r_masalar
( 
	m_masano 	varchar(64) not null,
	m_id		varchar(64) not null,
    m_masakisi 	float not null,
   
    primary key(m_masano),
    
    foreign key(m_id) references r_musteriler(m_id)
		on delete cascade on update cascade
		
);

CREATE TABLE r_urunler
(
	urun_id			varchar(64) 	not null,
    urun_ad 		varchar(250) 	not null,
    urun_kategori 	varchar(250) 	not null,
	urun_fiyat 		float 			not null,
    
	primary key(urun_id)
);

CREATE TABLE r_siparisler
(
	s_id		varchar(64) 	not null,
	m_id		varchar(64) 	not null,
	urun_id		varchar(64) 	not null,    
    s_tarih 	datetime 		not null,
	s_fiyat 	float 			not null,
    
	primary key(s_id),
   
	foreign key(m_id)	references r_musteriler(m_id)
		on delete cascade on update cascade,
        
	foreign key(urun_id)	references r_urunler(urun_id)
		on delete cascade on update cascade                         
);

DELIMITER $$
CREATE PROCEDURE r_MusterilerListele ()
BEGIN
	SELECT 
		m_id 		as ID,
		m_ad 		as Adi,
		m_soyad 	as Soyadi,
		m_tel		as Telefon
        
    FROM r_musteriler;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE r_MusteriEkle (
	id  	varchar(64) ,
    ad		varchar(64) ,
    soy 	varchar(64) ,
    tel 	varchar(25) 

)
BEGIN
	INSERT INTO r_musteriler
    VALUES 	(id, ad, soy, tel);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE r_MusteriGuncelle (
	id  	varchar(64) ,
    ad		varchar(64) ,
    soy 	varchar(64) ,
    tel 	varchar(25) 
)
BEGIN
	UPDATE r_musteriler
    SET 
		m_ad		= ad,
		m_soyad 	= soy,
		m_tel 		= tel
	WHERE 
    	m_id  	= id;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE r_MusteriSil (
	id  	varchar(64) 
)
BEGIN
	DELETE FROM r_musteriler
	WHERE  	m_id  = id;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE r_MusteriBul (
	filtre  varchar(32) 
)
BEGIN
	SELECT * FROM r_musteriler
    WHERE 
    	m_id  		LIKE  CONCAT('%',filtre,'%') OR
		m_ad		LIKE  CONCAT('%',filtre,'%') OR
		m_soyad 	LIKE  CONCAT('%',filtre,'%') OR
		m_tel 		LIKE  CONCAT('%',filtre,'%');
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE r_MusteriSiparisler(
	id			varchar(64)  
)
BEGIN
	SELECT * FROM r_siparisler
    WHERE m_id = id;
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE r_MasaNoEkle(
	masano varchar(64),
	m_id varchar(64),
    m_masakisi float
)
BEGIN 
		INSERT INTO r_masalar
        VALUES(m_masano,m_id,m_masakisi);
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE r_MasaSil(
	id  	varchar(64) 
)
BEGIN
	DELETE FROM r_masalar
	WHERE  	m_masano  = id;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE r_MasalariListele ()
BEGIN
	SELECT 
		m_masano	as 'Masa No',
		m_id 		as 'Musteri ID',
		m_masakisi	as 'Kisi Sayisi'
        
    FROM r_masalar;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE r_MasaBul (
	filtre  varchar(32) 
)
BEGIN
	SELECT * FROM r_masalar
    WHERE 
    	m_masano	LIKE  CONCAT('%',filtre,'%') OR
		m_masakisi	LIKE  CONCAT('%',filtre,'%');
END $$
DELIMITER ;

-- -------------------------------------------------------------------

DELIMITER $$
CREATE PROCEDURE r_UrunlerHepsi()
BEGIN
	SELECT 
		urun_id as ID,
        urun_ad as AD,
        urun_kategori as 'Kategori',
        urun_fiyat as Fiyat
	FROM r_urunler;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE r_UrunEkle (
	id			varchar(64)  ,
    ad 			varchar(250) ,
    kategori 	varchar(250) ,
	fiyat 		float		 
    
)
BEGIN
	INSERT INTO r_urunler
    VALUES 	(id, ad, kategori, fiyat, stok, birim, detay);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE r_UrunGuncelle (
	id			varchar(64)  ,
    ad 			varchar(250) ,
    kategori 	varchar(250) ,
	fiyat 		float 	     
)
BEGIN
	UPDATE r_urunler
    SET 
		urun_ad 	  = ad,
		urun_kategori = kategori,
		urun_fiyat 	  = fiyat
	WHERE 
    	urun_id  	  = id;
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE r_UrunSil (
	id			varchar(64)  
)
BEGIN
	DELETE FROM r_urunler
	WHERE urun_id  = id;
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE r_UrunBul (
	filtre  varchar(32) 
)
BEGIN
	SELECT * FROM r_urunler
    WHERE 
    	urun_id  		LIKE  CONCAT('%',filtre,'%') OR
		urun_ad			LIKE  CONCAT('%',filtre,'%') OR
		urun_kategori 	LIKE  CONCAT('%',filtre,'%') OR
		urun_fiyat		LIKE  CONCAT('%',filtre,'%');
END $$
DELIMITER ;

-- ----------------------------------------
DELIMITER $$
CREATE PROCEDURE r_SiparisEkle(

	id	varchar(64),
    mid varchar(64),
    uid varchar(64),
    tarih datetime,
    fiyat float
)
BEGIN	
	INSERT INTO r_siparisler
    VALUE(id,mid,uid,tarih,fiyat);
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE r_SiparislerHepsi()
BEGIN
	SELECT 
		s_id as ID,
        m_id as 'Musteri ID',
        urun_id as 'Urun ID',
        s_tarih as Tarih,
        s_fiyat as Fiyat
	FROM r_siparisler;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE r_SiparisBul (
	filtre  varchar(32) 
)
BEGIN
	SELECT * FROM r_siparisler
    WHERE 
    	s_id  		LIKE  CONCAT('%',filtre,'%') OR
		m_id		LIKE  CONCAT('%',filtre,'%') OR
		urun_id		LIKE  CONCAT('%',filtre,'%') OR
        s_fiyat 	LIKE CONCAT('%',filtre,'%') OR
		s_tarih		LIKE  CONCAT('%',filtre,'%');
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE r_SiparisSil (
	id		varchar(64)  
)
BEGIN
	DELETE FROM r_siparisler
	WHERE s_id  = id;
END $$
DELIMITER ;
-- ------------------------------------------

DELIMITER $$
CREATE PROCEDURE r_OdemeEkle(
	id	varchar(64),
    mid varchar(64),
    tarih datetime,
    tutar float,
    tur varchar(25)
)
BEGIN	
	INSERT INTO r_odemeler
    VALUE(id,mid,tarih,tutar,tur);
END $$
DELIMITER ;


