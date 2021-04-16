using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp8
{
 class Program
 {
 static void Main(string[] args)
 {
 String path = @"P:\Example1.txt";
 using (StreamWriter sr = File.AppendText(path))
 {
 Console.WriteLine("enter content into file:");
 sr.WriteLine(Console.ReadLine());
 sr.Close();
 }
 using (StreamReader sr = File.OpenText(path))
 {
 String s = "";
 Console.WriteLine("File containg data is:");
 while ((s = sr.ReadLine()) != null)
 {
 Console.WriteLine(s);
 }
 }
 }
 }
}
