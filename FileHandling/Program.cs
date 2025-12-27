using CsvHelper;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Text.Json;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //File Creation Example using FileSteam Class
            // string path = @"D:\Bridzelabz\BridgeLabz-Training-Apexon\FileHandling\MyFile.txt";
            //FileStream fileStream = new FileStream(path, FileMode.Create);
            //fileStream.Close();
            //Console.WriteLine("File is Created and is path is D:\\Bridzelabz\\BridgeLabz-Training-Apexon\\FileHandling");

            //File Open and Write Example using FileSteam Class
            //FileStream filestream = new FileStream(path, FileMode.Append);
            //byte[] bytedata = Encoding.Default.GetBytes("Hello Sir. I am Suraj");
            //filestream.Write(bytedata, 0, bytedata.Length);
            //filestream.Close();
            //Console.WriteLine("SuccessFully Saved this Data");

            //File Read Example using FileStream Class
            //string data;
            //FileStream fileStream = new FileStream(path,FileMode.Open,FileAccess.Read);
            //using(StreamReader streamReader=new StreamReader(fileStream))
            //{
            //    data=streamReader.ReadToEnd();
            //}
            //Console.WriteLine(data);

            //Example to Write User Input to a File using StreamWriter Class


            //StreamWriter streamWriter = new StreamWriter(path);
            //// Asking the user to enter the text that we want to write into the MyFile.txt file
            //Console.WriteLine("Enter the Text that you want to write on File");
            //// To read the input from the user
            //string inputData = Console.ReadLine();
            //// To write the data into the stream use the Write Method of the StreamWriter Object
            //streamWriter.Write(inputData);
            //Console.WriteLine("Data Has Been Written to the File");
            //// Clears all the buffers for the current writer by calling the Flush Method of the StreamWriter Object
            //streamWriter.Flush();
            //// Close the current StreamWriter object and the underlying stream by calling the Flush Method of the StreamWriter Object
            //streamWriter.Close();
            //Console.ReadKey();

            //Save Variable Data to File in C# using StreamWriter Class

            //StreamWriter streamWriter=new StreamWriter(path);
            //Console.WriteLine("Enter two digit: ");
            //int a=int.Parse(Console.ReadLine());
            //int b=int.Parse(Console.ReadLine());
            //int c = a + b;
            //streamWriter.Write(c);
            //Console.WriteLine("Data has been written in file");
            //streamWriter.Flush();
            //Console.WriteLine(c);

            //Save Variable Data to File in C# using StreamWriter Class
            //Console.WriteLine("Enter two digit : ");
            //int a=int.Parse(Console.ReadLine());
            //int b=int.Parse(Console.ReadLine());
            //int result = a + b;
            //using(StreamWriter streamWriter=new StreamWriter(path))
            //{
            //    streamWriter.Write($"The Sum of {a} and {b} = {result}");

            //}
            //Console.WriteLine("Variable Data is already saved");

            //Console.WriteLine("Enter two digit : ");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int result = a + b;
            //using (StreamWriter streamWriter = new StreamWriter(path,true))
            //{
            //    streamWriter.Write($", The Sum of {a} and {b} = {result}");

            //}
            //Console.WriteLine("Variable Data is already saved");



            //StreamReader Class in C#
            //Example to Read Data from a File using StreamReader Class


            //Console.WriteLine("Contant of the file");
            //using (StreamReader reader = new StreamReader(path))
            //{
            //    Console.WriteLine(reader.ReadToEnd());
            //}

            //Using both StreamReader and StreamWriter Class in C#
            //using (StreamWriter streamWriter = new StreamWriter(path))
            //{
            //    streamWriter.WriteLine("Welcome to DotNetTutorials");
            //    streamWriter.WriteLine("You are Learning File Handling in C#");
            //}

            ////Reading text file using StreamReader Class ReadToEnd Method
            //Console.WriteLine("\nReading Approach 1: using ReadToEnd Method");
            //using (StreamReader reader = new StreamReader(path))
            //{
            //    Console.WriteLine(reader.ReadToEnd());
            //}

            ////Another Approach to Read the Data from a text file using StreamReader ReadLine Method
            //Console.WriteLine("\nReading Approach 2: using ReadLine Method");
            //StreamReader streamReader = new StreamReader(path);
            //streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            //string strData = streamReader.ReadLine();
            //while (strData != null)
            //{
            //    Console.WriteLine(strData);
            //    strData = streamReader.ReadLine();
            //}

            //Console.ReadKey();

            //Serialization---------------------------------------------------------------------------------------

            //Person p1 = new Person
            //{
            //    Id = 1,
            //    Name = "Suraj",
            //    Age = 23,
            //    Description = "I am from Bihar"
            //};

            //Person p2 = new Person
            //{
            //    Id = 2,
            //    Name = "Sachin",
            //    Age = 22,
            //    Description = "I am from UP"
            //};
            //using(StreamWriter streamwrite=new StreamWriter(path))
            //{
            //    WritePerson(streamwrite, p1);
            //    WritePerson(streamwrite, p2);
            //}
            //Console.WriteLine("Data Serialized to text file Successfully");


            //Deserialization----------------------------------------------------------------------------------------
            //List<Person> p=ReadPersonFun(path);
            //foreach(var i in p)
            //{
            //    Console.WriteLine($"{i.Id} {i.Name} {i.Age} {i.Description}");
            //}

            /////--------------------------------------------------CSV Serialization (Object → CSV file--------------------------------
            //List<Person> p = new List<Person>
            //{
            //    new Person{Id=1,Name="Bitu",Age=18, Description="Hello Sir"},
            //    new Person{Id=2,Name="Divyanshu", Age=6, Description="I am divyanshu"},
            //    new Person{Id=3,Name="Divyansh", Age=4, Description="I am Divyansh"}
            //};
            string path = @"D:\Bridzelabz\BridgeLabz-Training-Apexon\FileHandling\person.json";
            //using(var writer=new StreamWriter(path))
            //using(var csv=new CsvWriter(writer, CultureInfo.InvariantCulture))
            //{
            //    csv.WriteRecords(p);
            //}

            //Person p = new Person { Id = 3, Name = "Aryan", Age = 22 , Description="hii"};

            //string csvLine = $"{p.Id},{p.Name},{p.Age},{p.Description}";

            //File.WriteAllText(path, csvLine);

            //-------------------------------------------------------CSV Deserialization (CSV → Object)-------------------------------------------

            //string csvdata = File.ReadAllText(path);
            //string[] values = csvdata.Split(',');
            //Person p = new Person
            //{
            //    Id = int.Parse(values[0]),
            //    Name = values[1],
            //    Age = int.Parse(values[2]),
            //    Description = values[3]
            //};
            //Console.WriteLine($"{p.Id} {p.Name} {p.Age} {p.Description}");


            //---------------------------------------CSV Serialization with Multiple Objects----------------------------------------------------
            //List<Person> p = new List<Person>
            //{
            //    new Person{Id=1, Name="Suraj", Age=23, Description="Hi I am Suraj"},
            //    new Person{Id=2, Name="Sachin", Age=22, Description="Hii I am Sachin" }
            //};
            //using(StreamWriter sw= new StreamWriter(path))
            //{
            //    sw.WriteLine("Id,Name,Age,Description");
            //    foreach(var i in p)
            //    {
            //        sw.WriteLine($"{i.Id},{i.Name},{i.Age},{i.Description}");
            //    }
            //}

            //--------------------------------------CSV Deserialization (Multiple Rows)------------------------------------------------
            //List<Person>person=new List<Person>();
            //var lines=File.ReadAllLines(path);
            //for(int i = 1; i < lines.Length; i++)
            //{
            //    var val=lines[i].Split(',');
            //    Person p = new Person()
            //    {
            //        Id = int.Parse(val[0]),
            //        Name = val[1],
            //        Age = int.Parse(val[2]),
            //        Description = val[3]
            //    };
            //    person.Add(p);
            //}
            //foreach (var p in person)
            //{
            //    Console.WriteLine($"{p.Id},{p.Name},{p.Age},{p.Description}");
            //}

            //List<Person> p;
            //using (var reader = new StreamReader(path))
            //using(var csv=new CsvReader(reader, CultureInfo.InvariantCulture))
            //{
            //    p=csv.GetRecords<Person>().ToList();
            //}
            //foreach(var i in p)
            //{
            //    Console.WriteLine($"{i.Id},{i.Name},{i.Age},{i.Description}");
            //}

            //-------------------------------------------JSON Serialization (Object → JSON File)---------------------------------------------
            //FileStream filestream = new FileStream(path, FileMode.Create);
            //List<Person> p = new List<Person>()
            //{
            //    new Person { Id = 1, Name = "Bitu", Age = 18, Description = "Hello Sir" },
            //    new Person { Id = 2, Name = "Divyanshu", Age = 6, Description = "I am Divyanshu" }
            //};
            //string json=JsonSerializer.Serialize(p,new JsonSerializerOptions
            //{
            //    WriteIndented=true
            //});
            //File.WriteAllText(path,json);

            //-----------------------------------------JSON Deserialization (JSON → Object)------------------------------------------------------
            //string json = File.ReadAllText(path);

            //List<Person> people = JsonSerializer.Deserialize<List<Person>>(json);

            //foreach (var p in people)
            //{
            //    Console.WriteLine($"{p.Id}, {p.Name}, {p.Age}, {p.Description}");
            //}
        }
        //static void WritePerson(StreamWriter streamwrite, Person p)
        //{
        //    streamwrite.WriteLine("Id : "+ p.Id);
        //    streamwrite.WriteLine("Name : " + p.Name);
        //    streamwrite.WriteLine("Age : "+p.Age);
        //    streamwrite.WriteLine("Description : " + p.Description);
        //    streamwrite.WriteLine("-----------------------------------");
        //}

        //static List<Person> ReadPersonFun(string path)
        //{
        //    List<Person>person=new List<Person>();
        //    using(StreamReader  sr = new StreamReader(path))
        //    {
        //        while (!sr.EndOfStream)
        //        {
        //            Person p=new Person();
        //            p.Id = int.Parse(sr.ReadLine().Split(':')[1].Trim());
        //            p.Name = sr.ReadLine().Split(':')[1].Trim();
        //            p.Age = int.Parse(sr.ReadLine().Split(':')[1].Trim());
        //            p.Description = sr.ReadLine().Split(':')[1].Trim() ;

        //            sr.ReadLine();
        //            person.Add(p);
        //        }
        //    }
        //    return person;

    }
}
