CREATE TABLE [dbo].[MedicalCenterSpeciality]
(
	MedicalCenterSpecialityGuid UNIQUEIDENTIFIER PRIMARY KEY,
    SpecialityGuid UNIQUEIDENTIFIER,
    MedicalCenterGuid UNIQUEIDENTIFIER,
	Active BIT, 
    CONSTRAINT [FK_MedicalCenterSpeciality_MedicalCenter] FOREIGN KEY (MedicalCenterGuid) REFERENCES MedicalCenter(MedicalCenterGuid)
)
