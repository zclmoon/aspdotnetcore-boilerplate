USE my_test;

DROP TABLE IF EXISTS `user_info`;

CREATE TABLE `my_test`.`user_info` (
  `id` VARCHAR(100) NOT NULL,
  `password` VARCHAR(100) NOT NULL,
  `mobile_phone` VARCHAR(20) NOT NULL,
  `gender` INT NOT NULL,
  `name` VARCHAR(100) NOT NULL,
  `email` VARCHAR(100) NOT NULL,
  `address` VARCHAR(500) NOT NULL,
  `birthday` DATETIME NULL,
  `created_date_utc` DATETIME NOT NULL,
  `created_by` VARCHAR(100) NOT NULL,
  `updated_date_utc` DATETIME NOT NULL,
  `updated_by` VARCHAR(100) NOT NULL,
  `deleted_date_utc` DATETIME NOT NULL,
  `deleted_by` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC)) ENGINE=InnoDB CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;