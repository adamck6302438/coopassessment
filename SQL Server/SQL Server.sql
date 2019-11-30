-- 1. Create a database, and name it `ProductsDB`.
CREATE DATABASE ProductsDB;

-- 2. Create Product table
CREATE TABLE Product(
id INT NOT NULL AUTO_INCREMENT,
-- changed column name to product_name to avoid possible confusion from keyword 'name'
product_name varchar(25) not null, 
Price double not null,
description varchar(25),
primary key(id)
);