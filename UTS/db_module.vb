Module db_module
    '-- phpMyAdmin SQL Dump
    '-- version 4.7.4
    '-- https://www.phpmyadmin.net/
    '--
    '-- Host: 127.0.0.1
    '-- Generation Time: 07 Mei 2018 pada 06.16
    '-- Versi Server: 10.1.28-MariaDB
    '-- PHP Version: 7.1.11

    'Set SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
    'Set AUTOCOMMIT = 0;
    'START TRANSACTION;
    'Set time_zone = "+00:00";


    '/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
    '/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
    '/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
    '/*!40101 SET NAMES utf8mb4 */;

    '--
    '-- Database: `db_pegawai`
    '--

    '-- --------------------------------------------------------

    '--
    '-- Struktur dari tabel `tbl_master_pegawai`
    '--

    'CREATE TABLE `tbl_master_pegawai` (
    '  `Id` int(11) Not NULL,
    '  `Nik` int(11) Not NULL,
    '  `Nama_pegawai` varchar(150) Not NULL,
    '  `Email` varchar(150) Not NULL,
    '  `Alamat` varchar(500) Not NULL,
    '  `Jenis_kelamin` bit(1) Not NULL,
    '  `Jabatan` varchar(150) Not NULL,
    '  `No_telp` varchar(25) Not NULL,
    '  `Tgl_lahir` date Not NULL,
    '  `Tempat_lahir` varchar(50) Not NULL,
    '  `Flag` int(11) Not NULL
    ') ENGINE=InnoDB DEFAULT CHARSET=latin1;

    '--
    '-- Dumping data untuk tabel `tbl_master_pegawai`
    '--

    'INSERT INTO `tbl_master_pegawai` (`Id`, `Nik`, `Nama_pegawai`, `Email`, `Alamat`, `Jenis_kelamin`, `Jabatan`, `No_telp`, `Tgl_lahir`, `Tempat_lahir`, `Flag`) VALUES
    '(1, 1615323069, 'Cokorda Gde Agung', 'cokkagung@gmail.com', 'Batuaya', b'1', 'Manager', '085237286061', '1998-06-09', 'Karangasem', 1);

    '--
    '-- Indexes for dumped tables
    '--

    '--
    '-- Indexes for table `tbl_master_pegawai`
    '--
    'ALTER TABLE `tbl_master_pegawai`
    '  ADD PRIMARY KEY (`Id`);

    '--
    '-- AUTO_INCREMENT for dumped tables
    '--

    '--
    '-- AUTO_INCREMENT for table `tbl_master_pegawai`
    '--
    'ALTER TABLE `tbl_master_pegawai`
    '  MODIFY `Id` int(11) Not NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
    'COMMIT;

    '/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
    '/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
    '/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
End Module
