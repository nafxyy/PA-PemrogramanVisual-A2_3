-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 24, 2023 at 04:21 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbsosiskuu`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbakun`
--

CREATE TABLE `tbakun` (
  `id_akun` int(11) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `pgambar` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbakun`
--

INSERT INTO `tbakun` (`id_akun`, `nama`, `email`, `username`, `password`, `pgambar`) VALUES
(1, 'admin', 'admin@admin', 'Admin', 'Admin123', 'admin@admin.png'),
(2, 'heidar', 'heidar@gmail.com', 'heidar', 'heidar123', 'heidar@gmail.com.png'),
(3, 'awu', 'awu', 'awu', 'awu', 'awu.png'),
(4, 'tua', 'tua', 'tua', 'tua', 'tua.png');

-- --------------------------------------------------------

--
-- Table structure for table `tbkeranjang`
--

CREATE TABLE `tbkeranjang` (
  `id_akun` int(11) NOT NULL,
  `id_order` int(11) NOT NULL,
  `id_produk` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `harga` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbkeranjang`
--

INSERT INTO `tbkeranjang` (`id_akun`, `id_order`, `id_produk`, `jumlah`, `harga`) VALUES
(3, 2, 2, 1, 30000),
(4, 5, 2, 1, 30000),
(2, 1, 2, 1, 30000),
(2, 8, 2, 5, 150000),
(2, 9, 2, 4, 120000),
(2, 10, 2, 5, 150000),
(2, 11, 2, 1, 30000),
(2, 12, 2, 1, 30000),
(2, 13, 2, 7, 210000),
(2, 15, 2, 1, 15000),
(2, 16, 2, 4, 60000),
(2, 16, 8, 2, 40000),
(2, 17, 2, 3, 45000),
(2, 17, 8, 1, 20000),
(2, 17, 9, 2, 86000),
(2, 17, 10, 4, 136000),
(3, 2, 9, 1, 43000);

-- --------------------------------------------------------

--
-- Table structure for table `tborder`
--

CREATE TABLE `tborder` (
  `id_order` int(11) NOT NULL,
  `id_akun` int(11) NOT NULL,
  `total_harga` int(11) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  `dibayar` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tborder`
--

INSERT INTO `tborder` (`id_order`, `id_akun`, `total_harga`, `jumlah`, `tanggal`, `dibayar`) VALUES
(1, 2, 30000, 1, '2023-05-23', 1),
(2, 3, 73000, 2, '2023-05-23', 1),
(5, 4, NULL, NULL, NULL, 0),
(8, 2, 150000, 5, '2023-05-23', 1),
(9, 2, 120000, 4, '2023-05-23', 1),
(10, 2, 150000, 5, '2023-05-23', 1),
(11, 2, 30000, 1, '2023-05-23', 1),
(12, 2, 30000, 1, '2023-05-23', 1),
(13, 2, 210000, 7, '2023-05-23', 1),
(15, 2, 15000, 1, '2023-05-23', 1),
(16, 2, 100000, 6, '2023-05-23', 1),
(17, 2, 287000, 10, '2023-05-23', 1),
(18, 2, NULL, NULL, NULL, 0),
(19, 3, NULL, NULL, NULL, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbproduk`
--

CREATE TABLE `tbproduk` (
  `id_produk` int(11) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `bahan` varchar(255) NOT NULL,
  `berat` int(11) NOT NULL,
  `stok` int(11) NOT NULL,
  `harga` int(11) NOT NULL,
  `panjang` double DEFAULT NULL,
  `bentuk` varchar(25) DEFAULT NULL,
  `jenis` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbproduk`
--

INSERT INTO `tbproduk` (`id_produk`, `nama`, `bahan`, `berat`, `stok`, `harga`, `panjang`, `bentuk`, `jenis`) VALUES
(2, 'Sogood', 'Ayam', 500, 191, 15000, 7, NULL, 'sosis'),
(8, 'Sonice', 'Ayam', 600, 37, 20000, 5, NULL, 'sosis'),
(9, 'Jaguar', 'Sapi', 450, 9, 43000, 7, NULL, 'sosis'),
(10, 'Cangcimen', 'Tempe', 600, 31, 34000, NULL, 'Cukimai', 'nugget'),
(11, 'sogud', 'sapi', 2, 3, 5000, 7, NULL, 'sosis'),
(12, 'sones', 'domba', 5, 20, 10000, 5, NULL, 'sosis'),
(13, 'sones', 'domba', 5, 20, 10000, 5, NULL, 'sosis');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbakun`
--
ALTER TABLE `tbakun`
  ADD PRIMARY KEY (`id_akun`);

--
-- Indexes for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  ADD KEY `keranjangakun` (`id_akun`),
  ADD KEY `keranjangproduk` (`id_produk`),
  ADD KEY `orderproduk` (`id_order`);

--
-- Indexes for table `tborder`
--
ALTER TABLE `tborder`
  ADD PRIMARY KEY (`id_order`) USING BTREE,
  ADD KEY `orderakun` (`id_akun`);

--
-- Indexes for table `tbproduk`
--
ALTER TABLE `tbproduk`
  ADD PRIMARY KEY (`id_produk`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbakun`
--
ALTER TABLE `tbakun`
  MODIFY `id_akun` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tborder`
--
ALTER TABLE `tborder`
  MODIFY `id_order` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `tbproduk`
--
ALTER TABLE `tbproduk`
  MODIFY `id_produk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  ADD CONSTRAINT `keranjangakun` FOREIGN KEY (`id_akun`) REFERENCES `tbakun` (`id_akun`) ON DELETE CASCADE,
  ADD CONSTRAINT `keranjangproduk` FOREIGN KEY (`id_produk`) REFERENCES `tbproduk` (`id_produk`) ON DELETE CASCADE,
  ADD CONSTRAINT `orderproduk` FOREIGN KEY (`id_order`) REFERENCES `tborder` (`id_order`) ON DELETE CASCADE ON UPDATE NO ACTION;

--
-- Constraints for table `tborder`
--
ALTER TABLE `tborder`
  ADD CONSTRAINT `orderakun` FOREIGN KEY (`id_akun`) REFERENCES `tbakun` (`id_akun`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
