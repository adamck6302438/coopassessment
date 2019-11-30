-- 1. Create a database, and name it `ProductsDB`.
CREATE DATABASE ProductsDB;
USE ProductsDB;

-- 2. Create Product table
CREATE TABLE Product(
id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
-- changed column name to product_name to avoid possible confusion from keyword 'name'
product_name VARCHAR(255) NOT NULL, 
price FLOAT,
product_description VARCHAR(255),
);

-- 3. Insert product data to Product table
INSERT INTO Product(product_name, price, product_description)
VALUES ('Dog Shampoo', 10.57, 'shampoo for long hair dogs'), 
	('WD Red 4 TB', 150.99, 'NAS hard drive'), 
	('2018 Nissan Mourano', 37866.99, 'Nissan Mourano AWD with Tech Package?');

-- 4. Create a copy of Product table called 'Product_Copy' 
SELECT * INTO Product_Copy FROM Product;

-- 5. Delete 2nd row of Product_Copy table
DELETE FROM Product_Copy WHERE id = 2;
