CREATE TABLE book (
isbn INT PRIMARY KEY NOT NULL ,
title VARCHAR(50),
genre varchar(59)
);

CREATE TABLE author(
	author_id INT  NOT NULL auto_increment,
	PRIMARY KEY (author_id),
	first_name varchar(50),
	last_name VARCHAR(50),
	isbn INT,
	foreign key(isbn)
		references book (isbn)
);

INSERT INTO author

INSERT INTO book (author_id, first_name, last_name, idbn)
VALUES(1, "the doom", "fiction"),
(1, "the soom", "fiction"),
(1, "the voom", "fiction");
