using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net.Sockets;

namespace ClassNumber13
{
    class Program
    {
        static void Main(string[] args)
        {

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            //FileStream fs = new FileStream(@"D:/test2.txt" , FileMode.OpenOrCreate , FileAccess.ReadWrite );

            //StreamWriter streamWriter = new StreamWriter(fs);
            //Console.WriteLine("Enter the line of text");

            //string Holder = Console.ReadLine();

            //streamWriter.Write(Holder);

            //streamWriter.AutoFlush = true;

            //StreamReader streamReader = new StreamReader(fs);



            //while (!streamReader.EndOfStream)
            //{
            //    string st = streamReader.ReadLine();
            //    Console.WriteLine(st);
            //}
            ///////////////////////////////////////////////////////////////////////////////////////
            //int i = 0;
            //string Reader = streamReader.ReadLine();
            //do
            //{
            //    string temp = Reader.Substring(Reader.Length - 1 - i, 1);

            //    Console.WriteLine(temp);
            //    i++;
            //} while (i< Reader.Length - 1);
            //////////////////////////////////////////////////////////////////////////////////////////



            ///Console.WriteLine("File Created");
            //////////////////////////////////////////////////////////////////////////////////////////////////////



            //MemoryStream memoryStream = new MemoryStream();

            //BufferedStream bufferedStream = new BufferedStream();

            //NetworkStream networkStream = new NetworkStream();

            //PipeStream.Synchronized();


            /////////////////////////////////////////////////////////////////////////////Linq (lambda expression)
            //List<string> lstperson = new List<string>() {
            //    "asghar","behzad","majid","ahmad","akbar","davood"
            //};

            //List<string> lstStudent = new List<string>()
            //{
            //    "batol","mahmod","gholam","javad","somayeh"
            //};

            //lstperson.AddRange(lstStudent);
            //lstperson.Distinct();

            //lstperson
            //    .Distinct()
            //    .ToList()
            //    .ForEach(x => Console.WriteLine(x));


            //foreach (var item in lstperson)
            //{
            //    Console.WriteLine(item.ToString().ToLower());
            //}

            //bool startwithj = lstperson.All(x => x.StartsWith("j"));


            //bool startwithj2 = lstperson.Any(x => x.StartsWith("j"));

            //List<int> lstnumbers = new List<int>() { 1, 2, 3, 4, 5 };

            //var result = lstnumbers.Aggregate(0, (sum, val) => sum + val);

            //lstStudent.Chunk(3).ElementAt(0).ToList().ForEach(c => Console.WriteLine(c));

            //lstStudent.Chunk(3).ElementAt(1).ToList().ForEach(c => Console.WriteLine(c));

            //string holder2 = lstStudent.ElementAt(0);

            //var holder = lstStudent.ElementAtOrDefault(4);
            //if (holder == null)
            //{
            //    Console.WriteLine("null");
            //}
            //Console.WriteLine("Holder is :",holder);
            //Console.WriteLine(result);

            // lstStudent.Where(c => c.ToString().Contains("j")).ToList().ForEach(x => Console.WriteLine(x));

            ///////////////////////////////Soal 1    اسان-- 

            string GhatiString = "abtin,asghar,akbar,123,---,+++,237";
            
            string[] holder = GhatiString.Split(",");
            List<string> lstname = new List<string>();

            lstname.AddRange(holder);

            lstname.RemoveRange(3, 4);
            
           /// lstname.ForEach(x => Console.WriteLine(x));

            ////Soal 2 
            ///
            Console.WriteLine("Enter a text ");
            
            string ReadedString = Console.ReadLine();
            
            IEnumerable<char> temp2 = ReadedString.Reverse();

            bool IsPalindorme = ReadedString.SequenceEqual(temp2);

            Console.WriteLine(IsPalindorme + " " + "Is Palindorme");
            


        }
    }
}
