-- phpMyAdmin SQL Dump
-- version 4.0.9
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 06, 2014 at 10:53 AM
-- Server version: 5.6.14
-- PHP Version: 5.5.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `powerleague`
--

-- --------------------------------------------------------

--
-- Table structure for table `members`
--

CREATE TABLE IF NOT EXISTS `members` (
  `MemberID` bigint(6) NOT NULL,
  `Surname` varchar(30) DEFAULT NULL,
  `Forename` varchar(30) DEFAULT NULL,
  `Gender` varchar(6) DEFAULT NULL,
  `Address` varchar(25) DEFAULT NULL,
  `County` varchar(25) DEFAULT NULL,
  `City` varchar(25) DEFAULT NULL,
  `Postcode` varchar(8) DEFAULT NULL,
  `Telephone` char(11) DEFAULT NULL,
  `Mobile` char(11) DEFAULT NULL,
  `Email` varchar(40) DEFAULT NULL,
  `TotalRentals` int(4) DEFAULT NULL,
  `LastRental` char(10) DEFAULT NULL,
  `TimeSlot` char(5) DEFAULT NULL,
  `UserID` bigint(6) NOT NULL,
  PRIMARY KEY (`MemberID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `members`
--

INSERT INTO `members` (`MemberID`, `Surname`, `Forename`, `Gender`, `Address`, `County`, `City`, `Postcode`, `Telephone`, `Mobile`, `Email`, `TotalRentals`, `LastRental`, `TimeSlot`, `UserID`) VALUES
(100001, 'Sarpong-Boateng', 'Michael', 'Male', '224 Roman Road', 'London', 'City of London ', 'E6 3SL', '02074735337', '07944154812', 'michael-s-b@hotmail.com', 1, '05/05/2014', '10:15', 500001),
(100002, 'Yeboah', 'Immanuel', 'Male', '76 Lawrence Street', 'London', 'City of London ', 'E16 1HQ', '02075875786', '07997986789', 'immanuelyeboah@gmail.com', 0, NULL, NULL, 500001);

-- --------------------------------------------------------

--
-- Table structure for table `pitches`
--

CREATE TABLE IF NOT EXISTS `pitches` (
  `PitchNumber` int(2) NOT NULL,
  `PitchSize` char(8) DEFAULT NULL,
  `Price` char(5) DEFAULT NULL,
  PRIMARY KEY (`PitchNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pitches`
--

INSERT INTO `pitches` (`PitchNumber`, `PitchSize`, `Price`) VALUES
(1, '5-A-Side', '50.00'),
(2, '5-A-Side', '50.00'),
(3, '5-A-Side', '50.00'),
(4, '5-A-Side', '50.00'),
(5, '5-A-Side', '50.00'),
(6, '7-A-Side', '54.00'),
(7, '7-A-Side', '54.00'),
(8, '7-A-Side', '54.00'),
(9, '7-A-Side', '54.00'),
(10, '7-A-Side', '54.00'),
(11, '7-A-Side', '54.00'),
(12, '7-A-Side', '54.00');

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE IF NOT EXISTS `transactions` (
  `TransID` varchar(9) NOT NULL,
  `MemberID` bigint(6) NOT NULL,
  `Email` varchar(40) DEFAULT NULL,
  `PitchNumber` int(2) DEFAULT NULL,
  `TimeSlot` char(5) DEFAULT NULL,
  `DateBooked` char(10) DEFAULT NULL,
  `Price` char(5) DEFAULT NULL,
  `PaymentMethod` char(4) DEFAULT NULL,
  `UserID` bigint(6) NOT NULL,
  PRIMARY KEY (`TransID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`TransID`, `MemberID`, `Email`, `PitchNumber`, `TimeSlot`, `DateBooked`, `Price`, `PaymentMethod`, `UserID`) VALUES
('100000001', 100001, 'michael-s-b@hotmail.com', 1, '10:15', '2014/04/05', '50.00', 'Card', 500001);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `UserID` bigint(6) NOT NULL,
  `Surname` varchar(30) DEFAULT NULL,
  `Forename` varchar(30) DEFAULT NULL,
  `Address` varchar(25) DEFAULT NULL,
  `County` varchar(25) DEFAULT NULL,
  `City` varchar(25) DEFAULT NULL,
  `Postcode` varchar(8) DEFAULT NULL,
  `Telephone` char(11) DEFAULT NULL,
  `Mobile` char(11) DEFAULT NULL,
  `Email` varchar(40) DEFAULT NULL,
  `Username` varchar(15) DEFAULT NULL,
  `Password` varchar(25) DEFAULT NULL,
  `SecurityCode` char(8) DEFAULT NULL,
  PRIMARY KEY (`UserID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `Surname`, `Forename`, `Address`, `County`, `City`, `Postcode`, `Telephone`, `Mobile`, `Email`, `Username`, `Password`, `SecurityCode`) VALUES
(500001, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'User', 'Password', NULL);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
