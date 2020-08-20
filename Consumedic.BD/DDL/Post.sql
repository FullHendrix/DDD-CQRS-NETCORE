CREATE TABLE [dbo].[Posts]
(
    [IdPost] INT NOT NULL PRIMARY KEY , 
	[IdBlog] INT NOT NULL , 
    [Title] VARCHAR(100) NULL, 
    CONSTRAINT [FK_Post_Blog] FOREIGN KEY (IdBlog) REFERENCES Blogs(IdBlog), 
)
