CREATE DATABASE IF NOT EXISTS db_equips
CHARACTER SET utf8mb4 
COLLATE utf8mb4_unicode_ci;


CREATE TABLE equips (
  ABREVIACIO varchar(3) NOT NULL PRIMARY KEY,
  NOM varchar(20) NOT NULL,
  PRESSUPOST int(11) NOT NULL,
  LOGOLINK varchar(70) NOT NULL
);

INSERT INTO equips (ABREVIACIO, NOM, PRESSUPOST, LOGOLINK) VALUES
('ARS', 'Arsenal', 230, 'https://a.espncdn.com/i/teamlogos/soccer/500/359.png'),
('AVL', 'Aston Villa', 60, 'https://a.espncdn.com/i/teamlogos/soccer/500/362.png');


COMMIT;
