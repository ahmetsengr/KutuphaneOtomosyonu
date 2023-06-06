-- --------------------------------------------------------
-- Sunucu:                       127.0.0.1
-- Sunucu versiyonu:             5.7.9-log - MySQL Community Server (GPL)
-- Sunucu İşletim Sistemi:       Win64
-- HeidiSQL Sürüm:               9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- kutuphane için veritabanı yapısı dökülüyor
CREATE DATABASE IF NOT EXISTS `kutuphane` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `kutuphane`;


-- tablo yapısı dökülüyor kutuphane.kitap
CREATE TABLE IF NOT EXISTS `kitap` (
  `kitap_id` int(11) NOT NULL AUTO_INCREMENT,
  `kitap_adi` varchar(50) NOT NULL,
  `yazar_id` int(11) NOT NULL,
  `kitap_sayfa_sayisi` int(11) NOT NULL,
  PRIMARY KEY (`kitap_id`),
  KEY `yazar_id` (`yazar_id`),
  CONSTRAINT `yazar_id` FOREIGN KEY (`yazar_id`) REFERENCES `yazar` (`yazar_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Veri çıktısı seçilmemişti


-- tablo yapısı dökülüyor kutuphane.uye
CREATE TABLE IF NOT EXISTS `uye` (
  `uye_id` int(11) NOT NULL AUTO_INCREMENT,
  `uye_adi` varchar(50) NOT NULL,
  `uye_soyadi` varchar(50) NOT NULL,
  `uye_kayit_tarihi` date NOT NULL,
  `uye_okunan_kitap` int(11) DEFAULT '0',
  PRIMARY KEY (`uye_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Veri çıktısı seçilmemişti


-- tablo yapısı dökülüyor kutuphane.yazar
CREATE TABLE IF NOT EXISTS `yazar` (
  `yazar_id` int(11) NOT NULL AUTO_INCREMENT,
  `yazar_adi_soyadi` varchar(50) NOT NULL,
  `yazar_kitap_sayisi` int(11) DEFAULT '0',
  PRIMARY KEY (`yazar_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Veri çıktısı seçilmemişti
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
