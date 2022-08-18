DROP TABLE author;
DROP TABLE book;

CREATE TABLE book (
	isbn INT PRIMARY KEY NOT NULL ,
	title VARCHAR(50),
	genre varchar(50)
);

CREATE TABLE author(
	author_id INT NOT NULL auto_increment,
	PRIMARY KEY (author_id),
	first_name varchar(50),
	last_name VARCHAR(50),
	isbn INT,
	foreign key (isbn)
		references book(isbn)
);

INSERT INTO author(author_id, first_name, last_name, isbn)
VALUES(2154, "James", "derik", 1), (1111, "blank", "Blamkey", 1);

INSERT INTO book(isbn, title, genre)
VALUES("1", "duuuudddde", "FIC"), ("2", "THIS IS ANAZINANSND", "fic"), ("3", "DIIIIE", "fic");

 



select * from book;

SELECT * FROM author;
