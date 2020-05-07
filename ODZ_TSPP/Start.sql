
CREATE TABLE IF NOT EXISTS `users` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SecondName` varchar(50) NOT NULL,
  `YearOfConnection` int NOT NULL,
  `PhoneNumber` varchar (20) NOT NULL,
   PRIMARY KEY (Id)
);

CREATE TABLE IF NOT EXISTS `address` (
  `Id` int(11) PRIMARY KEY AUTO_INCREMENT,
  `City` varchar(20) NOT NULL,
  `Street` varchar(30) NOT NULL,
  `NumberOfHouse` varchar(5) NOT NULL,
  `NumberOfFlat`  int,
  `UserId` int,
  FOREIGN KEY (UserId) REFERENCES Users(id)
);

drop table roles;
CREATE TABLE IF NOT EXISTS `roles` (
  `Id` int(2) PRIMARY KEY AUTO_INCREMENT,
  `NameOfRole` varchar(20) NOT NULL unique,
  `Password` varchar(200) NOT NULL
);

INSERT INTO roles(`NameOfRole`, `Password`) VALUES ('ADMIN', '21232F297A57A5A743894A0E4A801FC3'), ('User', 'EE11CBB19052E40B07AAC0CA060C23EE'); 

/*INSERT INTO `users` (`SecondName`, `PhoneNumber`, `YearOfConnection`) VALUES
( 'Go', '100', '2000'),
( 'Bob', '200', '444444');


INSERT INTO `address` (`City`, `Street`, `NumberOfHouse`,`NumberOfFlat`, `UserId`) VALUES
( 'Sumy', 'Supruna', '10A', '10','1'),
( 'Sumy', 'Supruna', '10A', '10','2');*/

commit;
