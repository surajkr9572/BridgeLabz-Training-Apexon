use todo

Create table Task(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Tname VARCHAR(100)
)
	Select * from Task
	--Insert in  Store Procedure
CREATE PROCEDURE sp_CreateTask
	@Tname Varchar(100)
AS
BEGIN
	INSERT INTO TASK(Tname)
	VALUES(@Tname);
End;
exec sp_helptext 'sp_CreateTask'

--Project Or Show Procedure
CREATE PROCEDURE GetAllTasks
AS
BEGIN
    SELECT * FROM Task;
END;

EXEC GetAllTasks

--Update Store Procedure
CREATE PROCEDURE UpdateTask
    @Id INT,
    @Tname VARCHAR(100)
AS
BEGIN
    UPDATE Task
    SET Tname = @Tname
    WHERE Id = @Id;
END;

--Delete Store Procedure
CREATE PROCEDURE DeleteTask
	@Id INT
AS
BEGIN
	DELETE FROM TASK
	WHERE Id=@Id;
END