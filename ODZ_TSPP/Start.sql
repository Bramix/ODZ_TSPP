
CREATE TABLE IF NOT EXISTS `users` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `SecondName` varchar(50) NOT NULL,
  `YearOfConnection` int NOT NULL,
  `PhoneNumber` varchar (20) NOT NULL,
   PRIMARY KEY (Id)
);


INSERT INTO `users` (`SecondName`, `PhoneNumber`, `YearOfConnection`) VALUES
( 'Go', '100', '2000'),
( 'Bob', '200', '444444');

commit;
