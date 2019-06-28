-- phpMyAdmin SQL Dump
-- version 4.1.12
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 17, 2019 at 03:45 AM
-- Server version: 5.6.16
-- PHP Version: 5.5.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `thzcineplus`
--

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `User_id` int(11) NOT NULL AUTO_INCREMENT,
  `User_name` text NOT NULL,
  `User_password` text NOT NULL,
  `User_email` text NOT NULL,
  `User_points` int(11) NOT NULL DEFAULT '1000',
  `Tickets_bought` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`User_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`User_id`, `User_name`, `User_password`, `User_email`, `User_points`, `Tickets_bought`) VALUES
(1, 'tharhtetzan', 'kC4N0sFUJ4Ea1NAxNOZEbTg4bE4HzuEa4l+w34Uh3hM=', 'thahtetzan@gmail.com', 1000000000, 0),
(2, 'someone', 'R9BM47twqnB3Lyj3aWaNPg==', 'someone@gmail.com', 1000, 0),
(3, 'mohmoh', '+8nZe5+WDFL58ctpAtPzzw==', 'mohmoh@gmail.com', 1000, 0),
(4, 'kpz', 'JGsYLjvREp6PYFGeRRmAZg==', 'kpz@gmail.com', 1000, 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
