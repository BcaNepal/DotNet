CREATE TABLE Student
(
	id INT PRIMARY KEY,
	fnname VARCHAR(20),
	lname VARCHAR(20),
	age INT
)

--DROP TABLE Student

--delete

INSERT INTO Student VALUES(1, 'Ram', 'KC', 23)
INSERT INTO Student VALUES(2, 'Shyam', 'Thapa', 21)

SELECT * FROM Student

DELETE FROM Student WHERE id= 1

UPDATE Student SET age=19 Where id=1