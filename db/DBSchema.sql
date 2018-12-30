CREATE DATABASE my_test;

USE DATABASE my_test;

DROP TABLE IF EXISTS `user_info`;

CREATE TABLE `my_test`.`user_info` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(50) NOT NULL,
  `Email` VARCHAR(100) NOT NULL,
  `Address` VARCHAR(500) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC));

INSERT INTO `my_test`.`user_info` (`Name`, `Email`, `Address`) VALUES ('test001', 'test001@test.com', 'test001 address');

INSERT INTO `user_info`(`Name`, `Email`, `Address`) VALUES ('Richie','richie@test.com','Richie Address');

INSERT INTO `user_info`(`Name`, `Email`, `Address`) VALUES ('Wang','wang@test.com','wang Address');

INSERT INTO `user_info`(`Name`, `Email`, `Address`) VALUES ('peng','peng@test.com','peng Address');

INSERT INTO `user_info`(`Name`, `Email`, `Address`) VALUES ('jun','jun@test.com','jun Address');