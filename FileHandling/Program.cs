using System.ComponentModel;
using System.Text;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //File Creation Example using FileSteam Class
            string path = @"D:\Bridzelabz\BridgeLabz-Training-Apexon\FileHandling\MyFile.txt";
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
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine("Welcome to DotNetTutorials");
                streamWriter.WriteLine("You are Learning File Handling in C#");
            }

            //Reading text file using StreamReader Class ReadToEnd Method
            Console.WriteLine("\nReading Approach 1: using ReadToEnd Method");
            using (StreamReader reader = new StreamReader(path))
            {
                Console.WriteLine(reader.ReadToEnd());
            }

            //Another Approach to Read the Data from a text file using StreamReader ReadLine Method
            Console.WriteLine("\nReading Approach 2: using ReadLine Method");
            StreamReader streamReader = new StreamReader(path);
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            string strData = streamReader.ReadLine();
            while (strData != null)
            {
                Console.WriteLine(strData);
                strData = streamReader.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
