-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 07, 2024 at 03:14 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `posdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `billt`
--

CREATE TABLE `billt` (
  `bID` int(11) NOT NULL,
  `Bdate` date NOT NULL,
  `CustId` varchar(255) NOT NULL,
  `CustName` varchar(255) NOT NULL,
  `PMethod` varchar(255) NOT NULL,
  `Amt` float NOT NULL,
  `ProductName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `billt`
--

INSERT INTO `billt` (`bID`, `Bdate`, `CustId`, `CustName`, `PMethod`, `Amt`, `ProductName`) VALUES
(1, '2024-10-03', '1', '', 'Cash', 500, ''),
(2, '2024-10-03', '1', 'Fosu', 'Cash', 1000, ''),
(3, '2024-10-03', '1', '', 'Cash', 200, ''),
(4, '2024-10-04', '1', '', 'Cash', 50, ''),
(5, '2024-10-04', '1', '', 'Cash', 50, ''),
(6, '2024-10-04', '1', '', 'Cash', 50, ''),
(7, '2024-10-04', '1', '', 'Cash', 50, ''),
(8, '2024-10-04', '1', '', 'Cash', 400, ''),
(9, '2024-10-04', '1', '', 'Cash', 100, 'Alomo Sache'),
(10, '2024-10-04', '1', '', 'Cash', 40, 'Kasapreko'),
(11, '2024-10-05', '1', '', 'Cash', 40, 'Kasapreko'),
(12, '2024-10-05', '1', '', 'Cash', 252.5, 'Alomo Sache'),
(13, '2024-10-05', '1', '', 'Cash', 200, 'Malt'),
(14, '2024-10-05', '1', '', 'Momo', 100, 'Kasapreko'),
(15, '2024-10-05', '1', '', 'Cash', 250, 'Alomo Sache'),
(16, '2024-10-05', '1', '', 'Cash', 540, 'Adonko 123 Bottle'),
(17, '2024-10-05', '1', '', 'Cash', 180, 'Kasapreko'),
(18, '2024-10-05', '1', '', 'Cash', 160, 'Kasapreko'),
(19, '2024-10-06', '1', '', 'Cash', 100, 'Alomo Sache'),
(20, '2024-10-06', '1', '', 'Cash', 100, 'Kasapreko'),
(21, '2024-10-06', '1', '', 'Cash', 200, 'Alomo Sache'),
(22, '2024-10-06', '1', '', 'Cash', 100, 'Alomo Sache'),
(23, '2024-10-06', '1', '', 'Cash', 100, 'Alomo Sache'),
(24, '2024-10-06', '1', '', 'Cash', 400, 'Malt'),
(25, '2024-10-06', '1', '', 'Cash', 1000, 'Fridge'),
(26, '2024-10-06', '1', '', 'Cash', 60, 'Five Star Energy Drink'),
(27, '2024-10-06', '1', '', 'Cash', 100, 'Alomo Sache'),
(28, '2024-10-06', '1', '', 'Cash', 80, 'Adonko 123 Bottle'),
(29, '2024-10-06', '1', '', 'Cash', 40, 'Adonko 123 Bottle'),
(30, '2024-10-06', '1', '', 'Cash', 40, 'Adonko 123 Bottle'),
(31, '2024-10-06', '1', '', 'Cash', 500, 'Fridge'),
(32, '2024-10-06', '1', '', 'Cash', 1000, 'Fridge'),
(33, '2024-10-06', '1', '', 'Cash', 20, 'Five Star Energy Drink'),
(34, '2024-10-06', '1', '', 'Cash', 20, 'Adonko 123 Bottle'),
(35, '2024-10-06', '1', '', 'Cash', 100, 'Adonko 123 Bottle'),
(36, '2024-10-06', '1', '', 'Momo', 500, 'Fridge'),
(37, '2024-10-06', '1', '', 'Momo', 100, 'Adonko 123 Bottle'),
(38, '2024-10-06', '1', '', 'Cash', 240, 'Black Rock'),
(39, '2024-10-06', '1', '', 'Momo', 60, 'Black Rock'),
(40, '2024-10-06', '1', '', 'Cash', 240, 'Black Rock'),
(41, '2024-10-06', '1', '', 'Momo', 300, 'Black Rock'),
(42, '2024-10-06', '1', '', 'Cash', 120, 'Black Rock'),
(43, '2024-10-06', '1', '', 'Cash', 300, 'Black Rock'),
(44, '2024-10-06', '1', '', 'Cash', 120, 'Black Rock'),
(45, '2024-10-06', '1', '', 'Cash', 300, 'Black Rock'),
(46, '2024-10-06', '1', '', 'Cash', 360, 'Black Rock'),
(47, '2024-10-07', '1', '', 'Cash', 20, 'Adonko 123 Bottle'),
(48, '2024-10-07', '1', '', 'Cash', 50, 'Alomo Sache'),
(49, '2024-10-07', '1', '', 'Cash', 100, 'Alomo Sache'),
(50, '2024-10-07', '1', '', 'Cash', 300, 'Black Rock');

-- --------------------------------------------------------

--
-- Table structure for table `customertbl`
--

CREATE TABLE `customertbl` (
  `CusId` int(11) NOT NULL,
  `CusName` varchar(255) NOT NULL,
  `CusAdd` varchar(255) NOT NULL,
  `CusPhone` int(11) NOT NULL,
  `CusRem` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customertbl`
--

INSERT INTO `customertbl` (`CusId`, `CusName`, `CusAdd`, `CusPhone`, `CusRem`) VALUES
(1, 'Fosu Boahen', 'JM 11', 246380080, 'he owns electrical shop'),
(2, 'Bismark', 'Anyima', 246380080, 'great');

-- --------------------------------------------------------

--
-- Table structure for table `producttbl`
--

CREATE TABLE `producttbl` (
  `PId` int(11) NOT NULL,
  `PName` varchar(255) NOT NULL,
  `Pcat` varchar(255) NOT NULL,
  `Pprice` varchar(11) NOT NULL,
  `PQty` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `producttbl`
--

INSERT INTO `producttbl` (`PId`, `PName`, `Pcat`, `Pprice`, `PQty`) VALUES
(1, 'Fridge', 'Electronics', '500', '3'),
(2, 'Alomo Sache', 'Chargers', '50', '40'),
(3, 'Kasapreko', 'Chargers', '20', '0'),
(4, 'Malt', 'Electronics', '200', '0'),
(5, 'Five Star Energy Drink', 'Bulbs ', '20', '0'),
(6, 'Adonko 123 Bottle', 'Bulbs ', '20', '18'),
(7, 'Club ', 'Chargers', '15', '50'),
(8, 'Mini Club', 'Chargers', '12', '100'),
(9, 'Black Rock', 'General', '60', '11'),
(10, 'Deray Bottle', 'General', '25', '150'),
(11, 'Guiness', 'General', '12', '64');

-- --------------------------------------------------------

--
-- Table structure for table `suppliertbl`
--

CREATE TABLE `suppliertbl` (
  `SupId` int(11) NOT NULL,
  `SupName` varchar(255) NOT NULL,
  `SupAddress` varchar(255) NOT NULL,
  `SupPhone` varchar(255) NOT NULL,
  `SupRem` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `suppliertbl`
--

INSERT INTO `suppliertbl` (`SupId`, `SupName`, `SupAddress`, `SupPhone`, `SupRem`) VALUES
(1, 'Kofi Abogo', 'Supplier of beans', '246380080', 'We gonn make');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `billt`
--
ALTER TABLE `billt`
  ADD PRIMARY KEY (`bID`);

--
-- Indexes for table `customertbl`
--
ALTER TABLE `customertbl`
  ADD PRIMARY KEY (`CusId`);

--
-- Indexes for table `producttbl`
--
ALTER TABLE `producttbl`
  ADD PRIMARY KEY (`PId`);

--
-- Indexes for table `suppliertbl`
--
ALTER TABLE `suppliertbl`
  ADD PRIMARY KEY (`SupId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `billt`
--
ALTER TABLE `billt`
  MODIFY `bID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT for table `customertbl`
--
ALTER TABLE `customertbl`
  MODIFY `CusId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `producttbl`
--
ALTER TABLE `producttbl`
  MODIFY `PId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `suppliertbl`
--
ALTER TABLE `suppliertbl`
  MODIFY `SupId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
