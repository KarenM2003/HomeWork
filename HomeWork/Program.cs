using System.IO;

string path = @"C:\Users\user\Desktop\HomeWorke\example.txt";
string path2 = @"C:\Users\user\Desktop\HomeWorke2\example.txt";


string text = "Barev dzez";

using (StreamWriter sw = new StreamWriter(path))
{
    sw.WriteLine(text);
}


using (StreamReader sr = new StreamReader(path))
{
    string line;
    using (StreamWriter sw = new StreamWriter(path2))
    {
        while ((line = sr.ReadLine()) != null)
        {
            sw.WriteLine(line);
        }
    }
}

