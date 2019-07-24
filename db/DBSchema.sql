USE my_test;

DROP TABLE IF EXISTS `user_info`;

CREATE TABLE `my_test`.`user_info` (
  `id` VARCHAR(100) NOT NULL,
  `password` VARCHAR(100) NULL,
  `mobile_phone` VARCHAR(20) NOT NULL,
  `gender` INT NULL,
  `name` VARCHAR(100) NULL,
  `email` VARCHAR(100) NULL,
  `address` VARCHAR(500) NULL,
  `birthday` DATETIME NULL,
  `created_date_utc` DATETIME NOT NULL,
  `created_by` VARCHAR(100) NOT NULL,
  `updated_date_utc` DATETIME NULL,
  `updated_by` VARCHAR(100) NULL,
  `deleted_date_utc` DATETIME NULL,
  `deleted_by` VARCHAR(100) NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC)) ENGINE=InnoDB CHARSET=utf8mb4;

DROP TABLE IF EXISTS `note`;

CREATE TABLE `my_test`.`note` (
  `id` VARCHAR(100) NOT NULL,
  `content` TEXT NULL,
  `created_date_utc` DATETIME NOT NULL,
  `created_by` VARCHAR(100) NOT NULL,
  `updated_date_utc` DATETIME NULL,
  `updated_by` VARCHAR(100) NULL,
  `deleted_date_utc` DATETIME NULL,
  `deleted_by` VARCHAR(100) NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC)) ENGINE=InnoDB CHARSET=utf8mb4;