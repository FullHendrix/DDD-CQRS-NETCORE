CREATE TABLE [dbo].[MedicalCenterSpecialists]
(
	MedicalCenterSpecialistGuid UNIQUEIDENTIFIER PRIMARY KEY,
    SpecialistGuid UNIQUEIDENTIFIER,
    MedicalCenterGuid UNIQUEIDENTIFIER,
	Active BIT, 
    CONSTRAINT [FK_MedicalCenterSpecialist_MedicalCenter] FOREIGN KEY (MedicalCenterGuid) REFERENCES MedicalCenters(MedicalCenterGuid)
)
