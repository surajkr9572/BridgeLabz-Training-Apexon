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


            StreamWriter streamWriter = new StreamWriter(path);
            // Asking the user to enter the text that we want to write into the MyFile.txt file
            Console.WriteLine("Enter the Text that you want to write on File");
            // To read the input from the user
            string inputData = Console.ReadLine();
            // To write the data into the stream use the Write Method of the StreamWriter Object
            streamWriter.Write(inputData);
            Console.WriteLine("Data Has Been Written to the File");
            // Clears all the buffers for the current writer by calling the Flush Method of the StreamWriter Object
            streamWriter.Flush();
            // Close the current StreamWriter object and the underlying stream by calling the Flush Method of the StreamWriter Object
            streamWriter.Close();
            Console.ReadKey();
        }
    }
}
