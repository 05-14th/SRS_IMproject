-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               11.3.0-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             12.3.0.6589
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for student_record
CREATE DATABASE IF NOT EXISTS `student_record` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci */;
USE `student_record`;

-- Dumping structure for table student_record.admissionreq_tbl
CREATE TABLE IF NOT EXISTS `admissionreq_tbl` (
  `AdmissionReqID` int(11) NOT NULL AUTO_INCREMENT,
  `StudentID` varchar(50) NOT NULL,
  `RequirementType` varchar(50) NOT NULL,
  PRIMARY KEY (`AdmissionReqID`),
  KEY `StudentID` (`StudentID`)
) ENGINE=InnoDB AUTO_INCREMENT=6005 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Dumping data for table student_record.admissionreq_tbl: ~5 rows (approximately)
INSERT INTO `admissionreq_tbl` (`AdmissionReqID`, `StudentID`, `RequirementType`) VALUES
	(6000, '1000', 'passed all Req.'),
	(6001, '1001', 'diploma, Form 137'),
	(6002, '1002', 'Good Moral'),
	(6003, '1003', 'passed all req.'),
	(6004, '1004', 'diploma');

-- Dumping structure for table student_record.enrollmentrates_tbl
CREATE TABLE IF NOT EXISTS `enrollmentrates_tbl` (
  `EnrollmentRatesID` int(11) NOT NULL AUTO_INCREMENT,
  `StudentID` varchar(11) NOT NULL DEFAULT '',
  `AcademicYear` varchar(11) NOT NULL DEFAULT '',
  `TuitionFee` int(11) NOT NULL DEFAULT 0,
  `OtherFees` int(11) NOT NULL DEFAULT 0,
  `TotalFees` int(11) NOT NULL,
  PRIMARY KEY (`EnrollmentRatesID`) USING BTREE,
  KEY `StudentID` (`StudentID`)
) ENGINE=InnoDB AUTO_INCREMENT=5005 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Dumping data for table student_record.enrollmentrates_tbl: ~5 rows (approximately)
INSERT INTO `enrollmentrates_tbl` (`EnrollmentRatesID`, `StudentID`, `AcademicYear`, `TuitionFee`, `OtherFees`, `TotalFees`) VALUES
	(5000, '1000', '2023-2024', 4500, 2100, 6600),
	(5001, '1001', '2023-2024', 2000, 500, 2500),
	(5002, '1002', '2023-2024', 3000, 600, 3600),
	(5003, '1003', '2023-2024', 2500, 1000, 3500),
	(5004, '1004', '2023-2024', 3500, 1500, 5000);

-- Dumping structure for table student_record.score_tbl
CREATE TABLE IF NOT EXISTS `score_tbl` (
  `ScoreID` int(11) NOT NULL AUTO_INCREMENT,
  `StudentID` varchar(50) NOT NULL DEFAULT '',
  `TeacherID` varchar(50) NOT NULL DEFAULT '',
  `SubjectID` varchar(50) NOT NULL DEFAULT '',
  `AssessmentType` varchar(50) NOT NULL DEFAULT '',
  `FinalGrades` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`ScoreID`)
) ENGINE=InnoDB AUTO_INCREMENT=4005 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Dumping data for table student_record.score_tbl: ~5 rows (approximately)
INSERT INTO `score_tbl` (`ScoreID`, `StudentID`, `TeacherID`, `SubjectID`, `AssessmentType`, `FinalGrades`) VALUES
	(4000, '1000', '3000', '2000', 'Quiz', '80'),
	(4001, '1001', '3001', '2001', 'Quiz', '96'),
	(4002, '1002', '3002', '2002', 'Quiz', '87'),
	(4003, '1003', '3003', '2003', 'Quiz', '84'),
	(4004, '1004', '3004', '2004', 'Quiz', '88');

-- Dumping structure for table student_record.student_tbl
CREATE TABLE IF NOT EXISTS `student_tbl` (
  `studentID` int(11) NOT NULL AUTO_INCREMENT,
  `Stud_FirstName` varchar(50) NOT NULL DEFAULT '',
  `Stud_LastName` varchar(50) NOT NULL DEFAULT '0',
  `MI` VARCHAR(5) NOT NULL,
  `Stud_Gender` varchar(50) NOT NULL DEFAULT '',
  `Stud_DateofBirth` date DEFAULT '2023-12-01',
  `Stud_ContactNum` varchar(50) DEFAULT NULL,
  `Stud_Address` varchar(50) NOT NULL DEFAULT '',
  PRIMARY KEY (`studentID`)
) ENGINE=InnoDB AUTO_INCREMENT=1005 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Dumping data for table student_record.student_tbl: ~5 rows (approximately)
INSERT INTO `student_tbl` (`studentID`, `Stud_FirstName`, `Stud_LastName`, `MI`,`Stud_Gender`, `Stud_DateofBirth`, `Stud_ContactNum`, `Stud_Address`) VALUES
	(1000, 'Aime', 'Feuntes', 'E','F', '2003-12-15', '09628296540', 'Capalonga'),
	(1001, 'Ailen', 'Albante', 'A','F', '2003-12-28', '09828573209', 'poblacion'),
	(1002, 'belley', 'Caldit', 'D','M', '2004-10-24', '09452863803', 'poblacion'),
	(1003, 'Carl', 'Azores', 'D','M', '2004-02-15', '09758362729', 'ubang'),
	(1004, 'Jess', 'Gadil', 'F','F', '2004-05-26', '09632417267', 'itok');

-- Dumping structure for table student_record.subject_tbl
CREATE TABLE IF NOT EXISTS `subject_tbl` (
  `SubjectID` int(11) NOT NULL AUTO_INCREMENT,
  `StudentID` varchar(50) NOT NULL DEFAULT '',
  `TeacherID` varchar(50) NOT NULL DEFAULT '',
  `SubjectName` char(50) NOT NULL DEFAULT '0',
  `Marks` decimal(20,6) NOT NULL DEFAULT 0.000000,
  PRIMARY KEY (`SubjectID`) USING BTREE,
  KEY `studentID` (`StudentID`) USING BTREE,
  KEY `teacherID` (`TeacherID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=2005 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Dumping data for table student_record.subject_tbl: ~5 rows (approximately)
INSERT INTO `subject_tbl` (`SubjectID`, `StudentID`, `TeacherID`, `SubjectName`, `Marks`) VALUES
	(2000, '1000', '3000', 'Math', 90.000000),
	(2001, '1001', '3001', 'English', 85.000000),
	(2002, '1002', '3002', 'Filipino', 87.000000),
	(2003, '1003', '3003', 'Science', 93.000000),
	(2004, '1004', '3003', 'P.E', 95.000000);

-- Dumping structure for table student_record.teacher_tbl
CREATE TABLE IF NOT EXISTS `teacher_tbl` (
  `TeacherID` int(11) NOT NULL AUTO_INCREMENT,
  `T_FirstName` varchar(15) NOT NULL DEFAULT '',
  `T_LastName` varchar(15) NOT NULL DEFAULT '',
  `T_ContactNum` varchar(11) DEFAULT '',
  `HandledSub` varchar(15) NOT NULL DEFAULT '',
  PRIMARY KEY (`TeacherID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=3005 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Dumping data for table student_record.teacher_tbl: ~5 rows (approximately)
INSERT INTO `teacher_tbl` (`TeacherID`, `T_FirstName`, `T_LastName`, `T_ContactNum`, `HandledSub`) VALUES
	(3000, 'Lanie', 'Garcia', '09273548298', 'Math'),
	(3001, 'Mikee', 'Gardin', '09372539860', 'English'),
	(3002, 'Miguel', 'Aide', '09237263728', 'Filipino'),
	(3003, 'keil', 'Rancano', '09636426484', 'Science'),
	(3004, 'Takashi', 'Silva', '09327236119', 'P.E');
	
CREATE TABLE IF NOT EXISTS `users` (
	`user_id` INT(11) NOT NULL PRIMARY KEY AUTO_INCREMENT,
	`fullname` VARCHAR(255) NOT NULL,
	`username` VARCHAR(255) NOT NULL,
	`email` VARCHAR(255) NOT NULL,
	`password` VARCHAR(255) NOT NULL 
)ENGINE=InnoDB AUTO_INCREMENT=2005 DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

INSERT INTO `users` VALUES (1, "Ad Min", "administrator","schooladmin@gmail.com", "P@ssw0rd");
/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
