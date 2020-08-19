CREATE TABLE [dbo].[MedicalCenterSpecialist]
(
	MedicalCenterSpecialistGuid UNIQUEIDENTIFIER PRIMARY KEY,
    SpecialistGuid UNIQUEIDENTIFIER,
    MedicalCenterGuid UNIQUEIDENTIFIER,
	Active BIT, 
    CONSTRAINT [FK_MedicalCenterSpecialist_MedicalCenter] FOREIGN KEY (MedicalCenterGuid) REFERENCES MedicalCenter(MedicalCenterGuid)
)
