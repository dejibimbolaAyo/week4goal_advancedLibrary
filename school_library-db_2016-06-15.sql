-- phpMyAdmin SQL Dump
-- version 4.6.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:8080
-- Generation Time: Jun 15, 2016 at 04:21 PM
-- Server version: 5.6.30
-- PHP Version: 7.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `school_library`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin_info`
--

CREATE TABLE `admin_info` (
  `admin_ID` int(10) NOT NULL,
  `firstName` varchar(30) NOT NULL,
  `lastName` varchar(30) NOT NULL,
  `lastLogIn` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `admin_info`
--

INSERT INTO `admin_info` (`admin_ID`, `firstName`, `lastName`, `lastLogIn`) VALUES
(23, 'Oriolowo', 'Nancy', '2016-06-15 05:21:16.000000');

-- --------------------------------------------------------

--
-- Table structure for table `book_info`
--

CREATE TABLE `book_info` (
  `book_ID` int(10) NOT NULL,
  `book_title` varchar(50) NOT NULL,
  `book_author` varchar(50) NOT NULL,
  `book_ISBN` varchar(25) NOT NULL,
  `book_Available` bit(1) NOT NULL,
  `addedBy` varchar(30) NOT NULL,
  `addedOn` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `book_info`
--

INSERT INTO `book_info` (`book_ID`, `book_title`, `book_author`, `book_ISBN`, `book_Available`, `addedBy`, `addedOn`) VALUES
(1, 'Ada Goes To School', 'Abimbola Ayodeji', '1234-4563-7890', b'1', '', ''),
(2, 'Ada Comes Back From School', 'Abimbola Oweme', '1245-5467-9876', b'0', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `borrowed_books`
--

CREATE TABLE `borrowed_books` (
  `ID` int(10) NOT NULL,
  `book_ID` int(10) NOT NULL,
  `student_ID` int(10) NOT NULL,
  `date_borrowed` date NOT NULL,
  `date_returned` date NOT NULL,
  `returned_toggle` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `borrowed_books`
--

INSERT INTO `borrowed_books` (`ID`, `book_ID`, `student_ID`, `date_borrowed`, `date_returned`, `returned_toggle`) VALUES
(1, 2, 12, '2016-06-15', '2016-06-23', b'0'),
(2, 1, 12, '2016-06-15', '2016-06-23', b'0'),
(3, 2, 12, '0000-00-00', '0000-00-00', b'0'),
(4, 2, 12, '2016-06-01', '2016-06-03', b'0');

-- --------------------------------------------------------

--
-- Table structure for table `students_info`
--

CREATE TABLE `students_info` (
  `student_ID` int(10) NOT NULL,
  `fullName` varchar(25) NOT NULL,
  `lastName` varchar(25) NOT NULL,
  `middleName` varchar(25) NOT NULL,
  `age` int(2) NOT NULL,
  `email` varchar(50) NOT NULL,
  `phone` varchar(12) NOT NULL,
  `matNo` varchar(10) NOT NULL,
  `department` varchar(25) NOT NULL,
  `faculty` varchar(25) NOT NULL,
  `session` int(4) NOT NULL,
  `createdBy` varchar(20) NOT NULL,
  `createdOn` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `students_info`
--

INSERT INTO `students_info` (`student_ID`, `fullName`, `lastName`, `middleName`, `age`, `email`, `phone`, `matNo`, `department`, `faculty`, `session`, `createdBy`, `createdOn`) VALUES
(11, 'Abimbola', 'Omohose', 'Bosede', 32, 'omohose@gmail.com', '08069703865', 'psc099', 'Geography', 'Education', 2009, '', ''),
(12, 'Abimbola', 'Ayodeji', 'Oweme', 22, 'dejibimbola@gmail.com', '07065249677', 'psc3444', 'Computer Science', 'Physical Science', 2016, '', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin_info`
--
ALTER TABLE `admin_info`
  ADD PRIMARY KEY (`admin_ID`);

--
-- Indexes for table `book_info`
--
ALTER TABLE `book_info`
  ADD PRIMARY KEY (`book_ID`);

--
-- Indexes for table `borrowed_books`
--
ALTER TABLE `borrowed_books`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `book_ID` (`book_ID`),
  ADD KEY `student_ID` (`student_ID`),
  ADD KEY `student_ID_2` (`student_ID`),
  ADD KEY `book_ID_2` (`book_ID`);

--
-- Indexes for table `students_info`
--
ALTER TABLE `students_info`
  ADD PRIMARY KEY (`student_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin_info`
--
ALTER TABLE `admin_info`
  MODIFY `admin_ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;
--
-- AUTO_INCREMENT for table `book_info`
--
ALTER TABLE `book_info`
  MODIFY `book_ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `borrowed_books`
--
ALTER TABLE `borrowed_books`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `students_info`
--
ALTER TABLE `students_info`
  MODIFY `student_ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `borrowed_books`
--
ALTER TABLE `borrowed_books`
  ADD CONSTRAINT `borrowed_books_ibfk_1` FOREIGN KEY (`book_ID`) REFERENCES `book_info` (`book_ID`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `borrowed_books_ibfk_2` FOREIGN KEY (`student_ID`) REFERENCES `students_info` (`student_ID`) ON DELETE NO ACTION ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
