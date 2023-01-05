CREATE TABLE models(
ModelID int PRIMARY KEY IDENTITY,
modelName varchar(255),
MakeID int FOREIGN KEY REFERENCES makes(MakeID),
)
