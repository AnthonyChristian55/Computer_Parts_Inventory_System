-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 18, 2024 at 12:30 AM
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
-- Database: `citech_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `id` int(11) NOT NULL,
  `category_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`id`, `category_name`) VALUES
(1, 'Mouse'),
(2, 'Keyboard'),
(3, 'Monitor'),
(4, 'Storage'),
(5, 'Processor');

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `id` int(11) NOT NULL,
  `product_name` varchar(100) NOT NULL,
  `category_id` int(11) DEFAULT NULL,
  `price` decimal(10,2) NOT NULL,
  `stock` int(11) NOT NULL,
  `description` varchar(500) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `image_url` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`id`, `product_name`, `category_id`, `price`, `stock`, `description`, `created_at`, `updated_at`, `image_url`) VALUES
(1, 'Dell Alienware AW3225QF', 3, 2500.00, 8, 'Huawei Monitor', '2024-11-22 12:18:10', '2024-12-16 23:46:14', ''),
(2, 'Logitech Signature Slim K950', 2, 4500.00, 3, 'Wireless Keyboard', '2024-11-22 12:58:12', '2024-12-16 11:27:30', ''),
(3, 'ROG mouse', 1, 250.00, 4, 'mouse', '2024-11-22 12:58:31', '2024-12-16 11:15:50', ''),
(4, 'Lenovo Monitor', 3, 10000.00, 4, 'Monitor', '2024-11-22 14:21:37', '2024-12-16 11:08:07', ''),
(5, 'Logitech G102', 1, 200.00, 1, 'Mouse', '2024-11-22 14:58:58', '2024-12-16 11:07:40', ''),
(7, 'Razor V3', 1, 99.00, 2, 'Gaming Mouse', '2024-11-23 00:33:17', '2024-12-16 11:40:51', ''),
(8, 'Razer Blackwidow V4 Pro', 2, 12300.00, 3, 'Mechanical Gaming Keyboard', '2024-11-23 01:59:16', '2024-12-16 11:28:18', ''),
(9, 'Logitech', 1, 5000.00, 3, 'Mouse', '2024-12-16 11:07:12', '2024-12-16 11:07:12', ''),
(10, 'WD Purple 1TB', 4, 2500.00, 5, '1TB Storage', '2024-12-16 11:10:45', '2024-12-16 11:10:45', ''),
(11, 'Logitech G Pro', 1, 7000.00, 2, 'Wireless Mouse', '2024-12-16 11:18:51', '2024-12-17 12:44:28', 'C:\\Users\\Gian\\Documents\\citech-20241217T122919Z-001\\citech\\citech\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\8f52b955-707b-4d36-83fe-8b54c9196392.jpg'),
(12, 'Logitech G Pro X Superlight', 1, 12000.00, 3, 'Wireless Mouse', '2024-12-16 11:20:28', '2024-12-17 12:44:59', 'C:\\Users\\Gian\\Documents\\citech-20241217T122919Z-001\\citech\\citech\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\bac055b7-76d5-4815-af1d-0729a7b86f67.jpg'),
(13, 'Gigabyte GP-G34WQC', 3, 26000.00, 3, '144Hz Monitor', '2024-12-16 11:23:11', '2024-12-16 11:23:11', ''),
(15, 'Kingston NV3 1TB', 4, 2500.00, 8, 'NVMe SSD PCIe 4.0 Gen 4x4 Up to 6000 MB/s', '2024-12-16 11:26:02', '2024-12-16 11:26:02', 'C:\\Users\\Gian\\Documents\\citech\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\17db1cc5-5310-4c1c-8d2f-7fa13351a8c4.jpg'),
(16, 'Razer Blackwidow V4 Pro', 2, 12300.00, 3, 'Mechanical Gaming Keyboard', '2024-12-16 11:29:23', '2024-12-17 12:43:08', ''),
(17, 'Razer BlackWidow V3 Mini Hyperspeed Phantom Edition', 2, 9000.00, 5, 'Wireless Mechanical Gaming Keyboard', '2024-12-16 11:30:34', '2024-12-17 12:43:27', ''),
(18, 'ROG Pugio', 1, 3000.00, 4, 'Gaming Mouse', '2024-12-16 11:32:27', '2024-12-16 11:41:07', 'C:\\Users\\Gian\\Documents\\citech\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\c04d190b-b252-411c-8ffb-8bfa9469972d.jpg'),
(19, 'LENOVO 27\" R27Q-30 Legion', 3, 16000.00, 3, 'Gaming Monitor', '2024-12-16 11:34:13', '2024-12-16 11:34:13', ''),
(20, 'ASUS ROG Strix Flare', 2, 25000.00, 3, 'Mechanical Gaming Keyboard', '2024-12-16 11:35:15', '2024-12-17 12:43:36', 'C:\\Users\\Gian\\Documents\\citech-20241217T122919Z-001\\citech\\citech\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\b32e190d-1c6e-4686-b46c-33fafb71c9c5.jpg'),
(21, 'asus tuf gaming vg27aq3a', 3, 15000.00, 2, '27-inch 180hz gaming monitor', '2024-12-16 11:36:49', '2024-12-17 12:41:18', 'C:\\Users\\Gian\\Documents\\citech-20241217T122919Z-001\\citech\\citech\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\ba574209-b07a-4c0d-83c7-ac21fb3e3645.jpg'),
(22, 'SEAGATE 4TB Sata Ironwolf', 4, 65000.00, 3, 'NAS Hard Drive', '2024-12-16 11:38:12', '2024-12-16 11:38:12', 'C:\\Users\\Gian\\Documents\\citech\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\d153db44-e14a-4330-bfcc-b41fbeca92c1.jpg'),
(23, 'SAMSUNG 500GB 980 M.2', 4, 4300.00, 5, 'NVME SSD', '2024-12-16 11:39:07', '2024-12-16 11:39:07', 'C:\\Users\\Gian\\Documents\\citech\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\c55fd882-bee1-4e4b-bedc-207f07104a85.jpg'),
(24, 'ADATA 256GB SU650 2.5', 4, 1200.00, 8, 'SSD', '2024-12-16 11:40:31', '2024-12-17 12:39:55', 'C:\\Users\\Gian\\Documents\\citech-20241217T122919Z-001\\citech\\citech\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\b18a03e0-8be2-4842-b28a-e038a09e5899.jpg'),
(25, 'AMD Ryzen 9 7950X3D', 5, 30000.00, 3, 'Processor', '2024-12-16 11:43:40', '2024-12-16 11:43:40', 'C:\\Users\\Gian\\Documents\\citech\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\aa6f7a55-6646-4011-a6b0-9dbb58d0f931.jpg'),
(26, 'AMD Ryzen 7 7800X3D', 5, 28000.00, 2, '7000 Series 8-Core 4.2 GHz Socket AM5 Processor', '2024-12-16 11:44:35', '2024-12-16 11:44:35', 'C:\\Users\\Gian\\Documents\\citech\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\00880d90-acbf-4343-b0c6-e72b1787c9b1.jpg'),
(27, 'AMD Ryzen 5 8600G', 5, 10500.00, 7, '4.3 GHz, Socket AM5', '2024-12-16 11:46:00', '2024-12-17 12:37:56', 'C:\\Users\\Gian\\Documents\\citech-20241217T122919Z-001\\citech\\citech\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\ef3c22c4-2ee7-4eab-aaf0-f087c83cf938.jpg'),
(28, 'Intel® Core™ i5 processors', 5, 18100.00, 3, '14th Gen Processor', '2024-12-16 11:47:08', '2024-12-17 12:37:29', 'C:\\Users\\Gian\\Documents\\citech-20241217T122919Z-001\\citech\\citech\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\16b4c029-1a5a-4ba2-9f8e-4dd87beae450.jpg'),
(29, 'Intel® Core™ i9 processor 14900K', 5, 43100.00, 3, '36M Cache, up to 6.00 GHz', '2024-12-16 11:48:20', '2024-12-17 12:37:09', 'C:\\Users\\Gian\\Documents\\citech-20241217T122919Z-001\\citech\\citech\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\11f7dfe7-e4a4-417c-abb9-732fb12ce253.jpg'),
(30, 'Intel® Core™ i3 processor 14100F', 5, 8000.00, 3, '12M Cache, up to 4.70 GHz', '2024-12-17 12:38:58', '2024-12-17 12:45:14', 'C:\\Users\\Gian\\Documents\\citech-20241217T122919Z-001\\citech\\citech\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\81c89061-0258-4cf5-bf37-9fb329196d13.jpg'),
(31, 'Lenovo Gsync', 3, 12100.00, 2, 'Gaming Monitor', '2024-12-17 12:40:33', '2024-12-17 12:40:33', ''),
(32, 'BENQ', 3, 6000.00, 4, 'Monitor', '2024-12-17 12:40:56', '2024-12-17 12:40:56', ''),
(33, 'Royal Kludge 61', 2, 2500.00, 6, 'Mechanical Gaming Keyboard', '2024-12-17 12:42:13', '2024-12-17 12:42:13', 'C:\\Users\\Gian\\Documents\\citech-20241217T122919Z-001\\citech\\citech\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\3dbb38d5-6e63-4467-ad97-c947fa83ae09.jpg'),
(34, 'Royal Kludge 71', 2, 3500.00, 6, 'Mechanical Gaming Keyboard', '2024-12-17 12:42:50', '2024-12-17 12:42:50', ''),
(35, 'AMD Ryzen 5 3500g', 5, 6500.00, 3, 'Processor', '2024-12-17 12:45:37', '2024-12-17 12:45:51', ''),
(36, 'AMD Ryzen 5 2500g', 5, 4500.00, 2, 'Processor', '2024-12-17 12:46:17', '2024-12-17 12:46:17', ''),
(37, 'ANvision EG24S1 PRO', 3, 5100.00, 3, 'Gaming Monitor', '2024-12-17 18:36:09', '2024-12-17 18:36:09', ''),
(38, 'Razer Chroma', 2, 7800.00, 3, 'Gaming Keyboard', '2024-12-17 18:36:38', '2024-12-17 18:36:38', ''),
(39, 'Attack Sharv V3', 1, 3600.00, 7, 'Gaming Mouse', '2024-12-17 18:36:57', '2024-12-17 18:36:57', ''),
(40, 'Team Group GX2 512GB', 4, 3295.00, 10, 'SSD', '2024-12-17 18:37:33', '2024-12-17 18:37:33', ''),
(41, 'Crucial P3 Plus 500GB', 4, 2525.00, 5, 'SSD', '2024-12-17 18:38:01', '2024-12-17 18:38:01', ''),
(42, 'Team Group GX2 Solid State Drive', 4, 4675.00, 4, 'SSD', '2024-12-17 18:38:29', '2024-12-17 18:38:29', ''),
(43, 'MX Master 3S Wireless Bluetooth Mouse', 1, 3000.00, 5, 'Best Mouse for Work', '2024-12-17 22:55:21', '2024-12-17 22:55:21', 'C:\\Users\\antho\\OneDrive\\Desktop\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\53cf02f8-e233-49b9-8933-6f895552b409.jpg'),
(45, 'Mouse Pro 2', 1, 400.00, 5, 'Pro Mouse for Home', '2024-12-17 23:02:02', '2024-12-17 23:02:33', 'C:\\Users\\antho\\OneDrive\\Desktop\\citech\\citech\\bin\\Debug\\net8.0-windows\\pictures\\f3bb06c8-867e-4b98-a8a1-56f578d1dce5.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `id` int(11) NOT NULL,
  `product_id` int(11) DEFAULT NULL,
  `category_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `total_price` decimal(10,2) NOT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp(),
  `revenue` decimal(10,2) NOT NULL DEFAULT 0.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`id`, `product_id`, `category_id`, `quantity`, `total_price`, `date`, `revenue`) VALUES
(9, 1, 3, 10, 25000.00, '2024-11-01 02:30:00', 25000.00),
(10, 2, 2, 5, 2500.00, '2024-11-02 03:00:00', 2500.00),
(11, 3, 1, 2, 500.00, '2024-11-03 04:15:00', 500.00),
(12, 1, 3, 8, 20000.00, '2024-11-04 05:45:00', 20000.00),
(13, 2, 2, 7, 3500.00, '2024-11-05 06:30:00', 3500.00),
(14, 4, 3, 3, 10500.00, '2024-11-06 07:20:00', 10500.00),
(15, 3, 1, 6, 1500.00, '2024-11-07 08:10:00', 1500.00),
(16, 4, 3, 9, 31500.00, '2024-11-08 09:00:00', 31500.00),
(19, 1, 3, 1, 0.00, '2024-11-29 07:56:42', 2500.00),
(20, 1, 3, 2, 0.00, '2024-11-29 07:57:55', 5000.00),
(21, 1, 3, 1, 0.00, '2024-11-29 08:21:46', 2500.00),
(22, 1, 3, 1, 0.00, '2024-11-29 08:22:07', 2500.00),
(23, 1, 3, 2, 0.00, '2024-11-29 09:07:25', 5000.00),
(24, 1, 3, 1, 0.00, '2024-11-29 09:08:07', 2500.00),
(25, 1, 3, 1, 0.00, '2024-11-29 09:08:49', 2500.00),
(26, 1, 3, 1, 0.00, '2024-11-29 09:09:44', 2500.00),
(27, 1, 3, 1, 0.00, '2024-11-29 09:24:01', 2500.00),
(28, 1, 3, 2, 0.00, '2024-11-29 09:24:24', 5000.00),
(29, 1, 3, 1, 0.00, '2024-11-29 09:41:51', 2500.00),
(30, 1, 3, 1, 0.00, '2024-11-29 09:42:18', 2500.00);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `fullname` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` enum('admin','staff') NOT NULL,
  `date_created` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `fullname`, `password`, `role`, `date_created`) VALUES
(1, 'admin', '', '0192023a7bbd73250516f069df18b500', 'admin', '2024-11-17 04:15:42'),
(4, 'logic', 'Gianne Quinto', '827ccb0eea8a706c4c34a16891f84e7b', 'staff', '2024-12-16 11:04:52'),
(5, 'anthony_user', 'Anthony Rosales', '2bcdc184ae90e2815d070f2d65dfe7a0', 'staff', '2024-12-17 21:29:35'),
(6, 'juan_user', 'Juan Miguel Torres', 'c68544ec0fc148da28e642b0f9a40862', 'staff', '2024-12-17 22:12:28');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_category` (`category_id`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_sales_product` (`product_id`),
  ADD KEY `fk_sales_category` (`category_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `fk_category` FOREIGN KEY (`category_id`) REFERENCES `categories` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `products_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `categories` (`id`);

--
-- Constraints for table `sales`
--
ALTER TABLE `sales`
  ADD CONSTRAINT `fk_sales_category` FOREIGN KEY (`category_id`) REFERENCES `categories` (`id`),
  ADD CONSTRAINT `fk_sales_product` FOREIGN KEY (`product_id`) REFERENCES `products` (`id`),
  ADD CONSTRAINT `sales_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `products` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
