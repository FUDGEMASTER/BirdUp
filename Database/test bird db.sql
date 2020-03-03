--
-- File generated with SQLiteStudio v3.2.1 on Tue Mar 3 18:13:31 2020
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: Bird
CREATE TABLE Bird(

bird_Id INTEGER PRIMARY KEY ,

common_Name varchar (50) ,

scientific_Name varchar (50) ,

conservation_Status varchar (50) ,

eats int REFERENCES Feed_Mix(feed_Id)

);
INSERT INTO Bird (bird_Id, common_Name, scientific_Name, conservation_Status, eats) VALUES (1, 'Blue Jay', 'cyannociatta cristata', NULL, 2);
INSERT INTO Bird (bird_Id, common_Name, scientific_Name, conservation_Status, eats) VALUES (2, 'house sparrow', 'something-sciency', 'introduced', 3);
INSERT INTO Bird (bird_Id, common_Name, scientific_Name, conservation_Status, eats) VALUES (3, 'northern-cardinal', 'somewhat sciency', NULL, 1);

-- Table: Entry
CREATE TABLE Entry(

entry_Id INTEGER REFERENCES Bird(bird_Id),

common_Name varchar (50),

wiki_link varchar(255),

conservation_Status varchar (50) ,

eats int REFERENCES Feed_Mix(feed_Id),

place_Seen int REFERENCES Location(location_Id),

seen_Date DATETIME DEFAULT CURRENT_DATE ,

seen_time DATETIME DEFAULT CURRENT_TIME

);
INSERT INTO Entry (entry_Id, common_Name, wiki_link, conservation_Status, eats, place_Seen, seen_Date, seen_time) VALUES (1, 'Blue Jay', '', NULL, 2, 1, '2020-03-03', '22:48:10');
INSERT INTO Entry (entry_Id, common_Name, wiki_link, conservation_Status, eats, place_Seen, seen_Date, seen_time) VALUES (2, 'HOUSE SPARROW', '', 'INTRODUCED', 3, 2, '2020-03-03', '22:48:10');
INSERT INTO Entry (entry_Id, common_Name, wiki_link, conservation_Status, eats, place_Seen, seen_Date, seen_time) VALUES (3, 'northern-cardinal', '', NULL, 1, 3, '2020-03-03', '22:48:10');

-- Table: Feed_Mix
CREATE TABLE Feed_Mix(

feed_Id INTEGER PRIMARY KEY ,

feed_Type varchar (50)

);
INSERT INTO Feed_Mix (feed_Id, feed_Type) VALUES (1, 'millet');
INSERT INTO Feed_Mix (feed_Id, feed_Type) VALUES (2, 'suet');
INSERT INTO Feed_Mix (feed_Id, feed_Type) VALUES (3, 'black oil sunflower seed');
INSERT INTO Feed_Mix (feed_Id, feed_Type) VALUES (4, 'corn');

-- Table: Location
CREATE TABLE Location(

location_Id INTEGER PRIMARY KEY ,

zip varchar (10),

city varchar (30),

state varchar (20)

);
INSERT INTO Location (location_Id, zip, city, state) VALUES (1, '02893', 'warwick', 'RI');
INSERT INTO Location (location_Id, zip, city, state) VALUES (2, '02903', 'cranston', 'RI');
INSERT INTO Location (location_Id, zip, city, state) VALUES (3, '02908', 'providence', 'RI');

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
