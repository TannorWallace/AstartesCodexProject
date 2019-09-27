-- CREATE TABLE primarch(
--   id int AUTO_INCREMENT NOT NULL,
--   img VARCHAR(255),
--   name VARCHAR(255),
--   orgin VARCHAR(255),
--   flagship VARCHAR(255),
--   isLoyal TINYINT DEFAULT 1,
--   PRIMARY KEY (id)
-- );

-- CREATE TABLE legion(
-- id int AUTO_INCREMENT NOT NULL,
-- img VARCHAR(255),
-- primarch VARCHAR(255),
-- legionHomeWorld VARCHAR(255),
-- legionStory VARCHAR(MAX),
-- isLoyal TINYINT DEFAULT 1,
-- PRIMARY KEY (id)
-- );

-- CREATE TABLE notableastartes(
--   id int AUTO_INCREMENT NOT NULL,
--   img VARCHAR(255),
--   name VARCHAR(255),
--   story VARCHAR(65535),
--   legion VARCHAR(255),
--   primarch VARCHAR(255), 
--   isLoyal TINYINT DEFAULT 1,
--   PRIMARY KEY (id)
-- );

-- ALTER TABLE legion
-- -- ADD name VARCHAR(255);
-- MODIFY COLUMN legionStory VARCHAR(65535);

-- ALTER TABLE primarch
-- MODIFY COLUMN orgin VARCHAR(65535);

