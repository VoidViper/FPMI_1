using System;

using System.IO;
using System.Text;

using System.Runtime.Serialization.Formatters.Binary;

using Newtonsoft.Json;

namespace Serialization
{
    //TEST
    [Serializable]
    class Book
    {
        public string author;
        public int year;

        public Book(string author, int year)
        {
            this.author = author;
            this.year = year;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            DirectoryInfo currDir = new DirectoryInfo(".");
            DirectoryInfo dereksDir = new DirectoryInfo("/Users/zlatko/Projects");
            Console.WriteLine(dereksDir.FullName);
            Console.WriteLine(dereksDir.Name);
            Console.WriteLine(dereksDir.Parent);
            Console.WriteLine(dereksDir.Attributes);
            Console.WriteLine(dereksDir.CreationTime);

            // Write a string array to a text file
            string[] customers =
            {
                "Bob Smith",
                "Sally Smith",
                "Robert Smith"
            };

            string textFilePath = "/Users/zlatko/Projects/CSharpData/testfile1.txt";

            // Write the array
            File.WriteAllLines(textFilePath, customers);

            // Read strings from array
            foreach (string cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customer : {cust}");
            }

            // ----- GETTING FILE DATA -----

            DirectoryInfo myDataDir = new DirectoryInfo("/Users/zlatko/Projects/CSharpData");

            // Get all txt files 
            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            // Number of matches
            Console.WriteLine("Matches : {0}", txtFiles.Length);

            foreach (FileInfo file in txtFiles)
            {
                // Get file name
                Console.WriteLine(file.Name);

                // Get bytes in file
                Console.WriteLine(file.Length);
            }

            // ----- FILESTREAMS -----
            // FileStream is used to read and write a byte
            // or an array of bytes. 

            string textFilePath2 = "/Users/zlatko/Projects/CSharpData/testfile2.txt";

            using (FileStream fs = File.Open(textFilePath2, FileMode.Create))
            {
                string randString = "This is a random string";

                // Convert to a byte array
                byte[] rsByteArray = Encoding.Default.GetBytes(randString);

                // Write to file by defining the byte array,
                // the index to start writing from and length
                fs.Write(rsByteArray, 0, rsByteArray.Length);


                // Move back to the beginning of the file
                fs.Position = 0;

                // Create byte array to hold file data
                byte[] fileByteArray = new byte[rsByteArray.Length];

                // Put bytes in array
                for (int i = 0; i < rsByteArray.Length; i++)
                {
                    fileByteArray[i] = (byte)fs.ReadByte();
                }

                // Convert from bytes to string and output
                Console.WriteLine(Encoding.Default.GetString(fileByteArray));

            }






            using (FileStream fs = new FileStream("/Users/zlatko/Projects/CSharpData/testfile5.dat", FileMode.Create, FileAccess.Write))
            {
                int[] arrayOfInts = { 1, 2, 3, 4, 5, 6, 7 };

                BinaryFormatter bf = new BinaryFormatter();

                bf.Serialize(fs, arrayOfInts);
            }

            using (FileStream fs = new FileStream("/Users/zlatko/Projects/CSharpData/testfile5.dat", FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();

                int[] dArrayOfInts = (int[])bf.Deserialize(fs);
                Console.WriteLine($"ARRAY!!!!!! {string.Join(", ", dArrayOfInts)}");

            }

            using (FileStream fs = new FileStream("/Users/zlatko/Projects/CSharpData/testfile6.dat", FileMode.Create, FileAccess.Write))
            {
                Book[] arrayOfBooks = {
                    new Book("Ivan", 1981),
                    new Book("Dragan", 1993),
                    new Book("Petkan", 2011)
                };

                BinaryFormatter bf = new BinaryFormatter();


                bf.Serialize(fs, arrayOfBooks);

            }

            using (FileStream fs = new FileStream("/Users/zlatko/Projects/CSharpData/testfile6.dat", FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();

                Book[] dArrayOfBooks = (Book[])bf.Deserialize(fs);
                Console.WriteLine($"BOOOKS!!!!!! {dArrayOfBooks[0].author}, {dArrayOfBooks[0].year}, {dArrayOfBooks[1].author}, {dArrayOfBooks[1].year}, {dArrayOfBooks[2].author}, {dArrayOfBooks[2].year}");
            }








            //// ----- STREAMWRITER / STREAMREADER -----
            //// These are best for reading and writing strings

            //string textFilePath3 = "/Users/zlatko/Projects/CSharpData/testfile3.txt";

            //// Create a text file
            //StreamWriter sw = File.CreateText(textFilePath3);

            //// Write to a file without a newline
            //sw.Write("This is a random ");

            //// Write to a file with a newline
            //sw.WriteLine("sentence.");

            //// Write another
            //sw.WriteLine("This is another sentence.");

            //// Close the StreamWriter
            //sw.Close();

            //// Open the file for reading
            //StreamReader sr = File.OpenText(textFilePath3);

            //// Peek returns the next character as a unicode
            //// number. Use Convert to change to a character
            //Console.WriteLine("Peek : {0}", Convert.ToChar(sr.Peek()));

            //// Read to a newline
            //Console.WriteLine("1st String : {0}", sr.ReadLine());

            //// Read to the end of the file starting
            //// where you left off reading
            //Console.WriteLine("Everything : {0}", sr.ReadToEnd());

            //sr.Close();

            //// ----- BINARYWRITER / BINARYREADER -----
            //// Used to read and write data types 
            //string textFilePath4 = "/Users/zlatko/Projects/CSharpData/testfile4.dat";

            //// Get the file
            //FileInfo datFile = new FileInfo(textFilePath4);

            //// Open the file
            //BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            //// Data to save to the file
            //string randText = "Random Text";
            //int myAge = 42;
            //double height = 6.25;

            //// Write data to a file
            //bw.Write(randText);
            //bw.Write(myAge);
            //bw.Write(height);

            //bw.Close();

            //// Open file for reading
            //BinaryReader br = new BinaryReader(datFile.OpenRead());

            //// Output data
            //Console.WriteLine(br.ReadString());
            //Console.WriteLine(br.ReadInt32());
            //Console.WriteLine(br.ReadDouble());

            //br.Close();




            //// ----- JSON Serialization -----
            //string textFilePath6 = "/Users/zlatko/Projects/CSharpData/testfile6.json";
            //// Get the file
            //FileInfo jsonFile = new FileInfo(textFilePath6);

            //// Open the file
            //bw = new BinaryWriter(jsonFile.OpenWrite());

            //string jsonOfBooks = JsonConvert.SerializeObject(arrayOfBooks);

            //bw.Write(jsonOfBooks);

            //bw.Close();

            //// Open file for reading
            //br = new BinaryReader(jsonFile.OpenRead());

            //// Output data
            //Console.WriteLine(br.ReadString());



            //dArrayOfBooks = JsonConvert.DeserializeObject<Book[]>(jsonOfBooks);

            //Console.WriteLine($"BOOOKS!!!!!! {dArrayOfBooks[0].author}, {dArrayOfBooks[0].year}, {dArrayOfBooks[1].author}, {dArrayOfBooks[1].year}, {dArrayOfBooks[2].author}, {dArrayOfBooks[2].year}");



            ////Product deserializedProduct = JsonConvert.DeserializeObject<Product>(output);



            //br.Close();

        }
    }
}