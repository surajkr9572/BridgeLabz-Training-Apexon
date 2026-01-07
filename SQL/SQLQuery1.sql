EXEC sp_databases
 SELECT name FROM sys.databases

--Create a db
Create database school_db
Create database demo


--Selecting a DB
use school_db
select DB_Name()

--Deleting database
use demo
drop database school

--Create a Table 
create table students(
student_id int primary key,
name varchar (100),
age int,
grade int
);


--Insert the values


Insert into students(student_id,name,age,grade)
values(101,'Raju',10,5);

Insert into students(student_id,name,age,grade)
values(102,'Sham',12,7),(103,'Baburao',14,9);


Insert into students
values(104,'Paul',11,6);
--delete table 
drop table student1

--Reading DATA
select *from account

select Name from student

--Updating DATA
UPDATE students 
	SET grade=12
	WHERE student_id=103


--DELETE DATA
DELETE FROM students
WHERE student_id=104

--TRUNCATE
TRUNCATE table students


----------TASK-------------
--Write a Query to change Grade of Raju from 5 to 6
UPDATE students
SET grade=6
WHERE student_id=101

--Add a new Student to the table 
INSERT into students
VALUES(104,'Alex',11,6)

--Write a query to remove 'Baburao' from the table
DELETE FROM students
WHERE name='baburao'

--Write a query to reterieve only the details for the student named Sham
SELECT * FROM students
WHERE name='Sham';

--write a query to print age of Raju
SELECT age FROM students
WHERE student_id=101



-------Constraints------------------

--Primary Key
create table student1(
student_id int primary key,
Firstname varchar (100),
Lastname varchar(100),
);

create table student2(
Student_id INT NOT NULL,
FirstName varchar(12) NOT NULL,
LastName varchar(12) NOT NULL,
Email varchar(100) NOT NULL
CONSTRAINT Stud_student PRIMARY KEY(Student_id,Email)
);

CREATE table account(
Id INT IDENTITY(1,1)NOT NULL,
Name VARCHAR(20),
Email VARCHAR(50) unique,
Created_at DATETIME DEFAULT GETDATE()
);


---------------------------TASK2-------------------
CREATE DATABASE bank_db

use bank_db

CREATE TABLE employees(
emp_id INT PRIMARY KEY IDENTITY (101,1),
fname VARCHAR(50) NOT NULL,
lname VARCHAR(50) NOT NULL,
email VARCHAR(100) UNIQUE NOT NULL,
job_title VARCHAR(50) NOT NULL,
department VARCHAR(50),
salary DECIMAL(10,2) DEFAULT 30000.00,	
hire_date DATE NOT NULL  DEFAULT CONVERT(date,GETDATE()),
city VARCHAR(50)
);

EXEC sp_help employees

INSERT INTO employees

(fname, lname, email, job_title, department, salary, hire_date, city)

VALUES

('Aarav', 'Sharma', 'aarav.sharma@example.com', 'Director', 'Management', 180000, '2019-02-10', 'Mumbai'),
('Diya', 'Patel', 'diya.patel@example.com', 'Lead Engineer', 'Tech', 120000, '2020-08-15', 'Bengaluru'),
('Rohan', 'Mehra', 'rohan.mehra@example.com', 'Software Engineer', 'Tech', 85000, '2022-05-20', 'Bengaluru'),
('Priya', 'Singh', 'priya.singh@example.com', 'HR Manager', 'Human Resources', 95000, '2019-11-05', 'Mumbai'),
('Arjun', 'Kumar', 'arjun.kumar@example.com', 'Data Scientist', 'Tech', 110000, '2021-07-12', 'Hyderabad'),
('Ananya', 'Gupta', 'ananya.gupta@example.com', 'Marketing Lead', 'Marketing', 90000, '2020-03-01', 'Delhi'),
('Vikram', 'Reddy', 'vikram.reddy@example.com', 'Sales Executive', 'Sales', 75000, '2023-01-30', 'Mumbai'),
('Sameera', 'Rao', 'sameera.rao@example.com', 'Software Engineer', 'Tech', 88000, '2023-06-25', 'Pune'),
('Ishaan', 'Verma', 'ishaan.verma@example.com', 'Recruiter', 'Human Resources', 65000, '2022-09-01', 'Mumbai'),
('Kavya', 'Joshi', 'kavya.joshi@example.com', 'Product Designer', 'Design', 92000, '2021-04-18', 'Bengaluru'),
('Zain', 'Khan', 'zain.khan@example.com', 'Sales Manager', 'Sales', 115000, '2019-09-14', 'Delhi'),
('Nisha', 'Desai', 'nisha.desai@example.com', 'Jr. Data Analyst', 'Tech', 70000, '2024-02-01', 'Hyderabad'),
('Aditya', 'Nair', 'aditya.nair@example.com', 'Marketing Analyst', 'Marketing', 68000, '2022-10-10', 'Delhi'),
('Fatima', 'Ali', 'fatima.ali@example.com', 'Sales Executive', 'Sales', 78000, '2022-11-22', 'Mumbai'),
('Kabir', 'Shah', 'kabir.shah@example.com', 'DevOps Engineer', 'Tech', 105000, '2020-12-01', 'Pune');


----------------Clause------------------------
--1.Where
Select * from employees where department='Tech'

select * From employees where salary >50000

select * from employees where hire_date>'2020-12-31'

--2.DISTINCT
select DISTINCT department from employees

--3.OrderdBY
SELECT *FROM employees ORDER BY salary
SELECT *FROM employees ORDER BY  salary desc

SELECT *FROM employees ORDER BY hire_date
SELECT *FROM employees ORDER BY fname

select department,fname from employees ORDER By department,fname

--4.LIKE
SELECT *FROM employees WHERE fname LIKE 'A%'

SELECT *FROM employees WHERE fname LIKE '%a' 

SELECT *FROM employees WHERE fname LIKE'%gupta%'

--5.TOP
SELECT TOP 3* FROM employees ORDER BY salary desc

SELECT TOP 5 * From employees ORDER BY hire_date desc

SELECT TOP 1 * From employees Where department='Marketing' Order By department desc

SELECT TOP 2 * FROM employees ORDER by fname


--------------------------------------------------------------TASK--------------------------------------------------
select distinct department from employees 

select * from employees order by salary desc

select TOP 3 * from employees 

select fname from employees where fname like'A%'

select lname from employees where Len(lname)=4

--------------------------------------Logical Operator---------------------------------
select * from employees where salary=75000 AND department='Sales'

select * from employees where salary=75000 OR department IN('Tech','Sales','Management')

select * from employees where salary Between 75000 AND 100000
select * from employees where salary=75000 OR department NOT IN('Tech','Sales','Management')

--case
SELECT 
	fname,
	lname,
	salary,
	CASE
		WHEN salary>100000 THEN 'High Earner'
		WHEN salary>=80000 AND salary<=100000 THEN 'Medium Earner'
		ELSE 'Standared Earner'
		END AS salary_band
	FROM
		employees

----------Calculate Bouns---------

SELECT fname,lname,department,salary,
	CASE 
		WHEN department IN('Sales','Marketing') THEN salary*0.10
		WHEN department ='Tech' THEN salary*0.12
		ELSE salary*0.05
	END AS bonus
FROM employees

-----Aggregate Function---------------
Select COUNT(emp_id) from employees
SELECT MIN(salary) from employees
SELECT MAX(salary) from employees
SELECT AVG(salary) from employees
SELECT Sum(salary) from employees


--------------------GROUP BY-------------
select department from employees GROUP BY department
select department,COUNT(emp_id) as count from employees GROUP BY department Order By count
select department,Sum(salary) as sum from employees GROUP BY department Order By sum
select department,AVG(salary) as AVG from employees GROUP BY department Order By AVG



select city,COUNT(emp_id) from employees GROUP BY city

-------------------Multi-Column Grouping---
SELECT department,city,COUNT(emp_id)
from employees GROUP BY department,city
Order by department;


---------------------HAVING--------------------
select department,COUNT(emp_id) as count
from employees Group By department
having COUNT(emp_id)>2

select job_title ,AVG(salary) as AVG 
from employees Group By job_title
HAVING AVG(salary)>90000

select department,SUM(salary)
from employees Group By department 
HAVING SUM(salary)>200000

-----------------------------ROllUP----------
select department,COUNT(emp_id) as count
from employees Group By ROLLUP (department) 

select department,Sum(salary) as sum
from employees GROUP BY ROLLUP(department) Order By sum


---------------------------USECASE----------------
select department,city,Count(emp_id) 
from employees Group BY ROLLUP(department,city)
Order By department
--COALESCE method are use for remove NULL value from any feild 

select department, COALESCE (city,'Total') as city ,Count(emp_id)
from employees Group By ROLLUP(department,city)
Order By department

----------------------------------------------------------SUB QUERIES-----------------------------------
select * from employees WHERE salary > (
	select AVG(salary) from employees
);

select * from employees where department IN(
select department from employees where city='Mumbai'
);


select * from employees Where salary IN(
select  MAX(salary)  from employees GROUP BY department);

--------------------Correlated----------------------
select * from employees e where salary=(
select Max(salary) from employees e2
where e2.department=e.department
);

---------------------Inline view-------------------------------
--select department,AVG(salary) as avg from employees Group By department  Having AVG(salary)>90000
select department,avg_salary from (
select department,AVG(salary) as avg_salary
from employees
Group By department
) as dept_avg
where avg_salary>90000

-----------------------String Functions-----------------
SELECT CONCAT (fname,' ',lname) as fullName from employees

--CONCAT WS
SELECT CONCAT_WS(',',emp_id,fname,lname,city,department,email) from employees

-----------------------------------------TASK-----------------------
--1 & 2.
select CONCAT_WS(':',emp_id,CONCAT(fname,' ',lname),department) from employees

--3. 
SELECT CONCAT_WS(':',emp_id,fname,lname,UPPER(department)) from employees

--4
SELECT CONCAt(LEFT(department,1),emp_id),fname from employees



---------------------DATE Functions--------------------------------
SELECT GETDATE()
SELECT DATEADD(YEAR,2,GETDATE())  --DATEADD(INTERVAL,number,date)
SELECT DATEDIFF(MONTH,'2025-07-31',GETDATE())  --DATEDIFF(Interval,startdate,endDate)
SELECT MONTH(GETDATE())
SELECT DAY(GETDATE())
SELECT YEAR(GETDATE())
SELECT FORMAT(GETDATE(),'MM/dd/yyyy')

----------------------------------TASK-------
SELECT DATEADD(YEAR,5,hire_date) from employees
select MONTH(hire_date) from employees WHERE MONTH(hire_date)=2
SELECT YEAR(hire_date) as Years ,MONTH(hire_date) as Months,DAY(hire_date) as Days from employees
SELECT FORMAT(hire_date,'MM/dd/yyyy') as date from employees

------------------------------------------ALTER----------------------------------
ALTER TABLE employees
ADD phone varchar(15);

ALTER table employees
drop column phone
select * from employees

exec sp_help 'employees'
Alter Table employees
Alter column email VARCHAR(100) NOT NULL

EXEC sp_rename
'employees.first_name','fname','column'

  -----Changing table name--
  EXEC sp_rename
  'employee','employees'

  ---Adding Constrain----
  EXEC sp_help 'employees'

  ALTER TABLE employees
  ADD CONSTRAINT default_dept DEFAULT 'Trainee'
  for department

  INSERT INTO employees
  (fname,lname,email,job_title,salary,city)
  values
  ('ALex','Philip','alex.philip@example.com','Fresher',-100000,'Mumbai');
  select * from employees

  ----------CHECK Constrain------------------
  ALTER TABLE employees
  ADD CONSTRAINT chk_emp_positive_sal CHECK(salary>0)

  ALTER TABLE employees
  DROP CONSTRAINT chk_emp_positive_sal

  ALTER TABLE employees
  ADD CONSTRAINT chk_valid_email CHECK(email LIKE '%@%.%')


  --------------------------ONE TO MANY---------------------------
  CREATE DATABASE store_db
  use store_db

  CREATE TABLE Customers ( 
    customer_id INT IDENTITY(100,1) PRIMARY KEY, 
    customer_name VARCHAR(100) NOT NULL, 
    email VARCHAR(100) UNIQUE 
);
CREATE TABLE Customers ( 

    customer_id INT IDENTITY(100,1) PRIMARY KEY, 

    customer_name VARCHAR(100) NOT NULL, 

    email VARCHAR(100) UNIQUE 

);

CREATE TABLE Orders ( 

    order_id INT IDENTITY(500,1) PRIMARY KEY, 
    order_date DATE NOT NULL, 
    total_amount DECIMAL(10, 2), 
    customer_id INT, 
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id) 
);

INSERT INTO Customers (customer_name, email) 
VALUES 
('Paul', 'paul@example.com'), 
('Sham', 'sham@example.com'), 
('Baburao', 'baburao@example.com');

INSERT INTO Orders (order_date, total_amount, customer_id) 
VALUES 
('2025-09-15', 1500.00, 100), -- This links to Raju (customer_id 100) 
('2025-09-28', 800.00, 101), -- This links to Sham (customer_id 101) 
('2025-10-05', 2200.00, 100), -- This links to Raju (customer_id 100) 
('2025-10-12', 500.00, 102), -- This links to Baburao (customer_id 102) 
('2025-10-17', 1200.00, 101); -- New order for Sham (customer_id 101)

INSERT INTO Orders (order_date, total_amount) 
VALUES 
('2025-10-18', 3500.00)


SELECT *FROM Customers
SELECT *FROM Orders

---------------------------------JOINS--------------
--1.CROSS JOIN:-Every row of one table is combined with every row of another table.
SELECT *FROM Customers CROSS JOIN Orders

--2.INNER JOIN:-Returns only the Rows where there is match between the specific columns in both table.
SELECT *FROM
Customers INNER JOIN Orders 
ON Customers.customer_id=Orders.customer_id

SELECT c.customer_name,COUNT(o.order_id),SUM(o.total_amount) From
Customers c INNER JOIN Orders o
ON c.customer_id=o.customer_id
GROUP BY c.customer_name

--3.LEFT JOIN:-All the records from left table and matching records from right table
SELECT *FROM
Customers LEFT JOIN Orders 
ON Customers.customer_id=Orders.customer_id

SELECT c.customer_name,COUNT(o.order_id), SUM(o.total_amount) FROM
Customers c LEFT JOIN Orders o
ON c.customer_id=o.customer_id
GROUP BY c.customer_name

--3.RIGHT JOIN:-All the records from right table and matching records from left table
SELECT *FROM
Customers RIGHT JOIN Orders 
ON Customers.customer_id=Orders.customer_id

SELECT c.customer_name,COUNT(o.order_id), SUM(o.total_amount) FROM
Customers c RIGHT JOIN Orders o
ON c.customer_id=o.customer_id
GROUP BY c.customer_name

--4.FULL OUTER JOIN:-Return all the rows when there is a match in either the left or right table
SELECT *FROM
Customers FULL OUTER JOIN Orders 
ON Customers.customer_id=Orders.customer_id

--**OUTER APPLY:-outer apply is used to join each row from one table(the left table) to the results of a table-valued functions or subquery(the right side)
SELECT c.customer_id, c.customer_name,
		o.order_id,o.order_date,o.total_amount
		FROM Customers AS c
		CROSS APPLY(
		SELECT TOP 1*
		FROM Orders As o
		WHERE o.customer_id=c.customer_id
		ORDER BY o.order_date desc
)As o;

--5.UNION:-IT is used to combine the result of two or more SELECT statement into a single result set.
           --(combine data vertically)
           --UNION remove duplicate value but when we use UNION ALL Then show duplicate value

--6.EXCEPT:-EXCEPT returs rows from the first query that do not exist in the second query

--7. SELF JOIN:-A SELF JOIN is standard SQL Join where a table is joined to itself
			--IT is udes when rows in a table are related to other row in the same table 

CREATE TABLE CompanyHierarchy (
    EmployeeID INT PRIMARY KEY,
    Name VARCHAR(100),
    ManagerID INT
);


INSERT INTO CompanyHierarchy (EmployeeID, Name, ManagerID)
VALUES
(1, 'Sonia Verma', NULL),  -- The CEO
(2, 'Rohan Gupta', 1),     -- Reports to Sonia
(3, 'Amit Sharma', 2),     -- Reports to Rohan
(4, 'Priya Singh', 1),     -- Reports to Sonia
(5, 'Kabir Shah', 2);      -- Reports to Rohan

SELECT * FROM CompanyHierarchy

SELECT 
	e.Name AS EmployeeName,
	m.Name AS ManagerName
FROM
	CompanyHierarchy AS e
LEFT JOIN
	CompanyHierarchy AS m
ON e.ManagerID=m.EmployeeID


---------MANY TO MANY-----------------------------
CREATE DATABASE institute
use institute

CREATE TABLE courses(
course_id int IDENTITY(1,1) PRIMARY KEY,
course_name VARCHAR(100) NOT NULL,
course_fee NUMERIC(10,2) NOT NULL
);

INSERT INTO courses(course_name,course_fee)
VALUES
('Mathematics',500.00),
('Physic',600.00),
('Chemistry',700.00);

SELECT *FROM courses

CREATE TABLE students(
student_id INT IDENTITY(1,1) PRIMARY KEY,
student_name VARCHAR(100) NOT NULL
);
INSERT INTO students (student_name) VALUES
('Raju'),
('Sham'),
('Baburao'),
('Alex');
select * FROM students

CREATE TABLE enrollment(
enrollment_id INT IDENTITY(1,1) PRIMARY KEY,
student_id INT NOT NULL,
course_id INT NOT NULL,
enrollment_date DATE NOT NULL

FOREIGN KEY (student_id) REFERENCES students(student_id),
FOREIGN KEY (course_id) REFERENCES courses(course_id)
);
INSERT INTO enrollment(student_id,course_id,enrollment_date)
VALUES
(1,1,'2025-01-01'),
(1,2,'2025-01-15'),
(2,1,'2025-02-01'),
(2,3,'2025-02-15'),
(3,3,'2025-03-25')

SELECT s.student_name,c.course_name,e.enrollment_date,c.course_fee FROM enrollment e
INNER JOIN students s ON s.student_id=e.student_id
INNER JOIN courses c ON c.course_id=e.course_id

-------------------------------------------TASK----------------------------------------------
CREATE DATABASE estore_db;

use master
use estore_db
CREATE TABLE customers (
    cust_id INT IDENTITY(1,1) PRIMARY KEY,
    cust_name VARCHAR(100) NOT NULL
);

INSERT INTO customers (cust_name)
VALUES
    ('Raju'), ('Sham'), ('Paul'), ('Alex'),('Baburao') ;

CREATE TABLE orders (
    ord_id INT IDENTITY(1,1) PRIMARY KEY,
    ord_date DATE NOT NULL,
    cust_id INT NOT NULL,
    FOREIGN KEY (cust_id) REFERENCES customers(cust_id) ON DELETE CASCADE
);

INSERT INTO orders (ord_date, cust_id)
VALUES
    ('2025-01-01', 1),  -- Raju first order
    ('2025-02-01', 2),  -- Sham first order
    ('2025-03-01', 3),  -- Paul first order
    ('2025-04-04', 2);  -- Sham second order


CREATE TABLE products (
    p_id INT IDENTITY(1,1) PRIMARY KEY,
    p_name VARCHAR(100) NOT NULL,
    price NUMERIC NOT NULL
);

INSERT INTO products (p_name, price)
VALUES
    ('Laptop', 55000.00),
    ('Mouse', 500),
    ('Keyboard', 800.00),
    ('Cable', 250.00),
     ('Monitor', 12000.00);

CREATE TABLE order_items (
    item_id INT IDENTITY(1,1) PRIMARY KEY,
    ord_id INT NOT NULL,
    p_id INT NOT NULL,
    quantity INT NOT NULL,
    FOREIGN KEY (ord_id) REFERENCES orders(ord_id),
    FOREIGN KEY (p_id) REFERENCES products(p_id)
);

INSERT INTO order_items (ord_id, p_id, quantity)
VALUES
    (1, 1, 1),  -- Raju ordered 1 Laptop
    (1, 4, 2),  -- Raju ordered 2 Cables
    (2, 1, 1),  -- Sham ordered 1 Laptop
    (3, 2, 1),  -- Paul ordered 1 Mouse
    (3, 4, 5),  -- Paul ordered 5 Cables
    (4, 3, 1);  -- Sham ordered 1 Keyboard


SELECT c.cust_name,o.ord_id,o.ord_date,p.p_name,oi.quantity,p.price,oi.quantity*p.price as total_price
FROM 
order_items oi 
INNER JOIN products p ON oi.p_id=p.p_id
INNER JOIN orders o On o.ord_id=oi.ord_id
INNER JOIN customers c ON c.cust_id=o.cust_id

-------------------------------------------VIEWS-------------------------------------
CREATE VIEW enrollment_view AS 
SELECT s.student_name,c.course_name,e.enrollment_date,c.course_fee FROM enrollment e
INNER JOIN students s ON s.student_id=e.student_id
INNER JOIN courses c ON c.course_id=e.course_id

select * from enrollment_view

SELECT TABLE_SCHEMA, TABLE_NAME
FROM INFORMATION_SCHEMA.VIEWS

sp_helptext 'enrollment_view'

---------------------------ROW_NUMBER()-------------------------------
use bank_db
SELECT * from employees
SELECT 
    ROW_NUMBER() OVER(ORDER BY fname) as row_num,
    fname,department,salary
    FROM employees

---RANK()--

SELECT fname,department,salary,
RANK() OVER(ORDER BY salary desc) as rank
FROM employees

---DENSE RANK()--
update employees 
SET salary=180000
WHERE fname='NISHA'
SELECT fname,department,salary,
DENSE_RANK() OVER(ORDER BY salary desc) as rank
FROM employees

-------------------CTE()-------------------
select * from employees
WITH avgsal AS(
SELECT department,AVG(salary) AS dept_avg
from employees
GROUP BY department)
SELECT e.fname,e.department,e.salary,a.dept_avg
FROM employees e JOIN avgsal a
ON e.department=a.department
WHERE e.salary>=a.dept_avg

WITH maxsal AS(
select department,MAX(salary) as dept_max
from employees 
Group by department )
SELECT e.emp_id,e.fname,e.department,e.salary,m.dept_max
FROM employees e JOIN maxsal m
ON e.department=m.department
WHERE salary=m.dept_max

--------------------------STORED Procedure---------------------
CREATE PROCEDURE get_employee_sp
AS
BEGIN
SELECT emp_id,fname,lname,department,hire_date,city
FROM employees
END

EXEC get_employee_sp

--------STORED PROCEDURE WITH INPUT PARAMETER--------
CREATE PROCEDURE get_emp_by_dept_sp 
    @p_department VARCHAR(100)
AS
BEGIN
SELECT emp_id,fname,lname,department,hire_date,city
FROM employees
WHERE department=@p_department
END

EXEC get_emp_by_dept_sp 'Sales'


-----------HOW TO CHECK EXISTING SP -----
SELECT ROUTINE_NAME
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_TYPE='PROCEDURE'

EXEC sp_helptext 'get_employee_sp'
---------------ALTER PROCEDURE-----------

ALTER PROCEDURE get_employee_sp  
AS  
BEGIN  
SELECT emp_id,fname,lname,department,job_title,hire_date,city  
FROM employees  
END

EXEC get_employee_sp


CREATE PROCEDURE update_mp_salary
    @p_employee_id int,
    @p_new_salary decimal(10,2)
AS 
BEGIN
UPDATE employees
set salary=@p_new_salary
where emp_id=@p_employee_id
END

SELECT * FROM employees
EXEC update_mp_salary 103,90000

------SP WITH OUTPUT---
CREATE PROCEDURE get_emp_dept_avg
@p_dept VARCHAR(100),
@dept_avg NUMERIC(10,2) OUTPUT
AS
BEGIN
    SELECT
    @dept_avg= AVG(salary) from employees
    WHERE  department =@p_dept
END

-------
DECLARE @AvgDeptResult NUMERIC(10,2)
EXEC get_emp_dept_avg 'Tech' ,@AvgDeptResult OUTPUT

SELECT @AvgDeptResult


---------------------USER DEFINE FUNCTION-----------------
--1.SCALAR FUNCTION:- always return a values
CREATE FUNCTION DOUBLE_VALUE(
    @p_num NUMERIC(10,2)
)
RETURNS NUMERIC(10,2)
AS
BEGIN
DECLARE @result NUMERIC(10,2)
SET @result=@p_num*2
RETURN @result 
END

SELECT dbo.DOUBLE_VALUE(200)

--2. INLINE TABLE VALUE FUNCTION (ITVF):-Always return a table




--------------------TRIGGERS----------------
CREATE TRIGGER trg_PreventManagementRemoval
ON employees 
INSTEAD OF DELETE
AS 
BEGIN
---------check if emp is from managament department
        IF EXISTS(SELECT 1 FROM deleted WHERE department='Tech')
        BEGIN
            RAISERROR('Deletion not allow for management emp: ',16,1)
            ROLLBACK TRANSACTION;
            RETURN
        END
        DELETE FROM employees
        WHERE emp_id IN (SELECT emp_id FROM deleted)
END
DROP TRIGGER trg_PreventManagementRemoval

SELECT *FROM employees
DELETE FROM employees
WHERE emp_id=136


------------------------EXPORT DATABASE-----------
CREATE DATABASE test_bulk;
GO
BACKUP DATABASE test_bulk
TO DISK = 'D:\Bridzelabz\BridgeLabz-Training-Apexon\SQL\test_bulk.bak'
WITH FORMAT,
NAME = 'Full backup of test_bulk';

-----------------Import Database------------
RESTORE DATABASE test_bulk
FROM DISK ='D:\Bridzelabz\BridgeLabz-Training-Apexon\SQL\test_bulk.bak'
WITH REPLACE

use test_bulk
------------------Importing Data From CSV FILE
CREATE TABLE SimpleProducts (
    ProductId INT PRIMARY KEY,
    ProductName VARCHAR(100),
    ProductPrice DECIMAL (10,2)
);


SELECT *FROM SimpleProducts
BULK INSERT SimpleProducts
FROM 'D:\Bridzelabz\BridgeLabz-Training-Apexon\SQL\Product.csv'
WITH (
    FIELDTERMINATOR = ',',
    ROWTERMINATOR = '0x0D0A',
    FIRSTROW = 2
);
