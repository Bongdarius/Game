CREATE TABLE G_USER(
	G_Seq INT IDENTITY(0, 1) PRIMARY KEY,
	G_Uid NVARCHAR(100) UNIQUE,
	G_Pwd NVARCHAR(100)
)

INSERT INTO G_USER(G_UID, G_PWD) VALUES('adimin', '1234');