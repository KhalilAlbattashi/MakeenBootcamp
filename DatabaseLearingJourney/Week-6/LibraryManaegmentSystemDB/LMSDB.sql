CREATE TABLE books (
  id INT NOT NULL AUTO_INCREMENT,
  title VARCHAR(255) NOT NULL,
  author VARCHAR(255) NOT NULL,
  publication_year YEAR NOT NULL,
  isbn VARCHAR(13) NOT NULL,
  availability_status VARCHAR(255) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE library_members (
  id INT NOT NULL AUTO_INCREMENT,
  name VARCHAR(255) NOT NULL,
  address VARCHAR(255) NOT NULL,
  contact_details VARCHAR(255) NOT NULL,
  membership_status VARCHAR(255) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE library_staff (
  id INT NOT NULL AUTO_INCREMENT,
  name VARCHAR(255) NOT NULL,
  position VARCHAR(255) NOT NULL,
  contact_details VARCHAR(255) NOT NULL,
  staff_id VARCHAR(255) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE library_branches (
  id INT NOT NULL AUTO_INCREMENT,
  name VARCHAR(255) NOT NULL,
  address VARCHAR(255) NOT NULL,
  contact_details VARCHAR(255) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE transactions (
  id INT NOT NULL AUTO_INCREMENT,
  book_id INT NOT NULL,
  member_id INT NOT NULL,
  due_date DATE NOT NULL,
  fines_or_penalties DECIMAL(10,2) NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (book_id) REFERENCES books (id),
  FOREIGN KEY (member_id) REFERENCES library_members (id)
);

CREATE TABLE genres (
  id INT NOT NULL AUTO_INCREMENT,
  name VARCHAR(255) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE authors (
  id INT NOT NULL AUTO_INCREMENT,
  name VARCHAR(255) NOT NULL,
  nationality VARCHAR(255) NOT NULL,
  notable_works VARCHAR(255) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE publishers (
  id INT NOT NULL AUTO_INCREMENT,
  name VARCHAR(255) NOT NULL,
  contact_details VARCHAR(255) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE book_authors (
  book_id INT NOT NULL,
  author_id INT NOT NULL,
  PRIMARY KEY (book_id, author_id),
  FOREIGN KEY (book_id) REFERENCES books (id),
  FOREIGN KEY (author_id) REFERENCES authors (id)
);

CREATE TABLE book_genres (
  book_id INT NOT NULL,
  genre_id INT NOT NULL,
  PRIMARY KEY (book_id, genre_id),
  FOREIGN KEY (book_id) REFERENCES books (id),
  FOREIGN KEY (genre_id) REFERENCES genres (id)
);

CREATE TABLE book_publishers (
  book_id INT NOT NULL,
  publisher_id INT NOT NULL,
  PRIMARY KEY (book_id, publisher_id),
  FOREIGN KEY (book_id) REFERENCES books (id),
  FOREIGN KEY (publisher_id) REFERENCES publishers (id)
);