
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) NOT NULL,
  `SecondName` varchar(50) NOT NULL,
  `Mark` DOUBLE NOT NULL,
  `NumberOfSchool` INTEGER NOT NULL,
   PRIMARY KEY (id)
);


INSERT INTO `users` (`FirstName`, `SecondName`, `Mark`, `NumberOfSchool`) VALUES
( 'Go', 'GO', '100', '200'),
( 'Bob', 'Anna', '200', '444444');

commit;
