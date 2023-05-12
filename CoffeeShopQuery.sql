CREATE DATABASE CoffeeShopDb;

USE CoffeeShopDb;

CREATE TABLE Products (
	id INT PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(255),
	[Description] NVARCHAR(255),
	[Price] float,
	[Category] NVARCHAR(255)
);

INSERT INTO Products(Name,Description,Price,Category)
VALUES('Espresso','Highly concentrated coffee',1.75,'Beverage'),
('Macchiato','Steamed milk over espresso',4.75,'Beverage'),
('Cappuccino','Foamed milk over espresso',4.99,'Beverage'),
('Glazed donut','A donut covered with sugar glaze',0.99,'Food'),
('Breakfast sandwich','Sausage & eggs between toasted english muffins',3.99,'Food')

SELECT * FROM Products;