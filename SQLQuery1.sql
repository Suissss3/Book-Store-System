SELECT * FROM categories

SELECT * FROM products

CREATE TABLE orders
(
	id int PRIMARY KEY IDENTITY (1,1),
	customer_id VARCHAR(MAX) null,
	prod_id VARCHAR(MAX) null,
	prod_name VARCHAR(MAX) null,
	category VARCHAR(MAX) null,
	qty INT NULL,
	orig_price float null,
	total_price float NULL,
	order_date DATE null
)

ALTER TABLE orders
ADD customer_id INT null

SELECT* FROM orders

CREATE TABLE customers
(
	id int PRIMARY KEY IDENTITY (1,1),
	customer_id VARCHAR(MAX) null,
	customer_name VARCHAR(MAX) null,
	total_price FLOAT null,
	amount float null,
	change FLOAT NULL,
	order_date DATE null
)

SELECT * FROM customers

ALTER TABLE customers
DROP COLUMN prod_id