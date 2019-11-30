-- 1. Create a database, and name it `ProductsDB`.
CREATE DATABASE ProductsDB;
USE ProductsDB;

-- 2. Create Product table
CREATE TABLE Product(
id INT NOT NULL AUTO_INCREMENT,
-- changed column name to product_name to avoid possible confusion from keyword 'name'
product_name varchar(200) not null, 
price double not null,
description varchar(200),
primary key(id)
);

-- 3. Insert product data to Product table
INSERT INTO Product(product_name, price, description)
VALUES ('Dog Shampoo', 10.57, 'shampoo for long hair dogs'), 
	   ('WD Red 4 TB', 150.99, 'NAS hard drive'), 
	   ('2018 Nissan Mourano', 37866.99, 'Nissan Mourano AWD with Tech Package?');
