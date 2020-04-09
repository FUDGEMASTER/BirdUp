DROP TABLE IF EXISTS Recognized;

DROP TABLE IF EXISTS Recognizable;

DROP TABLE IF EXISTS Feed_Mix;

CREATE TABLE IF NOT EXISTS Feed_Mix(
        feed_Id INTEGER PRIMARY KEY ,
        feed_Type varchar (50)
        );

CREATE TABLE IF NOT EXISTS Recognizable (
        bird_Id     INTEGER     PRIMARY KEY ,
        common_Name     varchar (50) ,
        scientific_Name     varchar (50) ,
        conservation_Status     varchar (50) ,
        eats     INTEGER     REFERENCES     Feed_Mix(feed_Id)
            );

CREATE TABLE IF NOT EXISTS Recognized(
        entry_Id     INTEGER     REFERENCES     Recognizable(bird_Id),
        common_Name     varchar (50),
        wiki_link     varchar(255),
        conservation_Status     varchar (50) ,
        eats     int     REFERENCES     Feed_Mix(feed_Id),
        place_Seen     VARCHAR(255),
        seen_Date     DATETIME     DEFAULT     CURRENT_DATE ,
        seen_time     DATETIME     DEFAULT     CURRENT_TIME
              );

INSERT INTO Feed_Mix( 
                        feed_Type
                    ) 
                VALUES(
                    'Millet'
                ) ,
                (
                    'Suet'
                ) ,
                (
                    'Black Oil Sunflower Seed'
                ) ,
                (
                    'Corn'
                ),
                (
                    'Hulled Sunflower Seed'
                ),
                (
                    'Safflower'
                ),
                (    
                    'Milo'
                ),
                (   
                    'Nyjer'
                )
                ;
                
INSERT INTO Recognized (
                entry_Id , 
                common_Name , 
                wiki_link , 
                conservation_Status, 
                eats , 
                place_Seen , 
                seen_Date , 
                seen_Time )
            VALUES
                (
                1 , 
                'Blue Jay' , 
                'https://avibase.bsc-eoc.org/species.jsp?avibaseid=1DA430B8663CD4BE' , 
                null  , 
                2 , 
                'North Providence', 
                CURRENT_DATE , 
                CURRENT_TIME
                ) ,
                (2 , 
                'HOUSE SPARROW' ,
                'https://avibase.bsc-eoc.org/species.jsp?avibaseid=240E33900CE34D44' , 
                'INTRODUCED',  
                3 , 
                'Providence'  , 
                CURRENT_DATE , 
                CURRENT_TIME ) , 
                (3 , 
                'northern-cardinal' , 
                'https://avibase.bsc-eoc.org/species.jsp?avibaseid=4E74AE2276258520' , 
                null , 
                1 , 
                'Warwick' , 
                CURRENT_DATE , 
                CURRENT_TIME )
;

INSERT INTO Recognizable( 
                common_Name , 
                scientific_Name , 
                conservation_Status , 
                eats
                )
                VALUES
                (
                    'Blue Jay', 
                    'Cyanociatta Cristata', 
                    'Least Concern', 
                    6),
                    
                (
                    'House Sparrow', 
                    'Passer Domesticus', 
                    'Least Concern', 
                    3),
                (
                    'Northern Cardinal', 
                    'Cardinalis Cardinalis', 
                    'Least Concern', 
                    3),
                (
                    'Black-Capped Chickadee', 
                    'Poecile Atricapillus',
                     'Least Concern', 
                     3),
                (
                    'Dark-Eyed Junco', 
                    'Junco Hyemalis', 
                    'Least Concern', 
                    5),
                (
                    'Downy Woodpecker', 
                    'Dryobates Pubescens', 
                    'Least Concern', 
                    6),
                (
                    'Mourning Dove', 
                    'Zenaida Macroura', 
                    'Least Concern',
                     3),
                (
                    'White-Breasted Nuthatch',
                     'Sitta Carolinensis', 
                     'Least Concern', 
                     3),
                (
                    'American Goldfinch', 
                    'Spinus Tristis', 
                    'Least Concern', 
                    5),
                (
                    'Red-Bellied Woodpecker', 
                    'Melanerpes Carolinus', 
                    'Least Concern', 
                    3),
                (
                    'House Finch', 
                    'Haemorhous Mexicanus', 
                    'Least Concern', 
                    8),
                (
                    'Tufted Titmouse', 
                    'Baeolophus Bicolor', 
                    'Least Concern', 
                    8),
                (
                    'Hairy Woodpecker', 
                    'Dryobates Villosus', 
                    'Least Concern', 
                    6),
                (
                    'European Starling', 
                    'Sturnus Vulgaris', 
                    'Least Concern',
                     2),
                (
                    'American Robin', 
                    'Turdus Migratorius', 
                    'Least Concern',
                     5),
                (
                    'Song Sparrow', 
                    'Melospiza Melodia', 
                    'Least Concern', 
                    8),
                (
                    'Common Grackle', 
                    'Quiscalus Quiscula', 
                    'Near Threatened', 
                    6),
                (
                    'Red-Winged Blackbird', 
                    'Hgelaius Phoniceus',
                     'Least Concern', 
                     1),
                (
                    'American Crow', 
                    'Corvus Brachyrhynclos', 
                    'Least Concern', 
                    5),
                (
                    'Brown-Headed Cowbird', 
                    'Molothrus Ater',
                     'Least Concern', 
                     3),
                (
                    'Purple Finch', 
                    'Haemorhous Purpureus', 
                    'Least Concern', 
                    5)
                ;
                
SELECT          Recognizable.bird_Id, 
                Recognizable.common_Name, 
                Recognizable.scientific_Name, 
                Recognizable.conservation_Status,
                Feed_Mix.feed_Type
FROM            Recognizable
INNER JOIN      Feed_Mix on
                Recognizable.eats = Feed_Mix.feed_Id; 

