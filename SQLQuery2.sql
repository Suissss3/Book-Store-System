CREATE TABLE users
(
	id int PRIMARY KEY IDENTITY (1,1),
	username VARCHAR(MAX) null,
	password VARCHAR(MAX) null,
	role VARCHAR(MAX) null,
	status VARCHAR(MAX) null,
	date DATE null
)
DELETE FROM users WHERE id = 13
SELECT * FROM users
 
INSERT INTO users(username, password,role,status,date)VALUES ('admin','admin123','Admin','Active','2024-05-08')

CREATE TABLE categories
(
	 id int PRIMARY KEY IDENTITY (1,1),
	 category VARCHAR(MAX) null,
	 date DATE null,
)

SELECT * FROM categories

CREATE TABLE products
(
id int PRIMARY KEY IDENTITY (1,1),
	prod_id VARCHAR(MAX) null,
	prod_name VARCHAR(MAX) null,
	category VARCHAR(MAX) null,
	price FLOAT null,
	stock INT null,
	image_path VARCHAR(MAX) null,
	status VARCHAR(MAX) null,
	date_insert DATE null,
)
SELECT * FROM products
