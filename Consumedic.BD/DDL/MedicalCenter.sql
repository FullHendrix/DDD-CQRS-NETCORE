CREATE TABLE [dbo].[MedicalCenter]
(
	MedicalCenterGuid UNIQUEIDENTIFIER PRIMARY KEY,
	MedicalCenterName VARCHAR(100),
	UbigeoId INT,
    Address VARCHAR(100) NULL,
	RepresentativeName VARCHAR(100) NULL,
    CompanyGuid UNIQUEiDENTIFIER,
	Active BIT
)
