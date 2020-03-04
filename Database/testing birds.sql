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

INSERT INTO Entry (entry_Id , common_Name , wiki_link , conservation_Status , eats , place_Seen , seen_Date , seen_Time)
VALUES
(1 , 'Blue Jay' , 'https://avibase.bsc-eoc.org/species.jsp?avibaseid=1DA430B8663CD4BE' , null  , 2 , 1 , CURRENT_DATE , CURRENT_TIME) ,
(2 , 'HOUSE SPARROW' , 'https://avibase.bsc-eoc.org/species.jsp?avibaseid=240E33900CE34D44' , 'INTRODUCED',  3 , 2  , CURRENT_DATE , CURRENT_TIME ) , 
(3 , 'northern-cardinal' , 'https://avibase.bsc-eoc.org/species.jsp?avibaseid=4E74AE2276258520' , null , 1 , 3 , CURRENT_DATE , CURRENT_TIME )
;

CREATE TABLE Bird(
bird_Id INTEGER PRIMARY KEY ,
common_Name varchar (50) ,
scientific_Name varchar (50) ,
conservation_Status varchar (50) ,
eats int REFERENCES Feed_Mix(feed_Id)
);

INSERT INTO Bird( common_Name , scientific_Name , conservation_Status , eats)
VALUES
('Blue Jay', 'cyannociatta cristata', null, 2),
('house sparrow', 'something-sciency', 'introduced', 3),
('northern-cardinal', 'somewhat sciency', null, 1) 
;

CREATE TABLE Feed_Mix(
feed_Id INTEGER PRIMARY KEY ,
feed_Type varchar (50)
);

INSERT INTO Feed_Mix( feed_Type) VALUES
('millet') ,
('suet') ,
('black oil sunflower seed') ,
('corn')
;

CREATE TABLE Location(
location_Id INTEGER PRIMARY KEY ,
zip varchar (10),
city varchar (30),
state varchar (20)
);

INSERT INTO Location(zip , city , state ) VALUES
('02893' , 'warwick' , 'RI' ) ,
('02903' , 'cranston' , 'RI'  ) ,
('02908', 'providence' , 'RI' ) 
;