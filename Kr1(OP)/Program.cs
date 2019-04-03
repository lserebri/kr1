using System;
using System.Text;
using System.IO;
using System.Collections;

namespace Kr1_OP_
{
    class Program
    {
        static void DefineTheNumber(string[] number)
        {
            var enc1251 = CodePagesEncodingProvider.Instance.GetEncoding(1251);
            string[] ten = {"one", "two", "three", "four", "five","six","seven","eight","nine", "ten" };
            string teen = "teen";
            string[] hundred = {"twenty -","thirty-", "fourty-", "fifty-","sixty-","seventy-","eighty-","ninety-"};
            //int[] num = new int[string];
            for(int i = 0; i < number.Length; i++)
            {
                if(Convert.ToInt32(number[i]) <= 10)
                {
                    StreamWriter newfile = new StreamWriter($"C:\\Users\\lsere\\OneDrive\\Рабочий стол\\kr1\\{number[i]}.txt", false, enc1251);
                    newfile.WriteLine(ten[Convert.ToInt32(number[i]) - 1]);
                    newfile.Close();
                }
                if(Convert.ToInt32(number[i]) >= 13 && Convert.ToInt32(number[i]) <= 19)
                {
                    StreamWriter newfile = new StreamWriter($"C:\\Users\\lsere\\OneDrive\\Рабочий стол\\kr1\\{number[i]}.txt", false, enc1251);
                    newfile.WriteLine(ten[Convert.ToInt32(number[i]) - 11]);
                    newfile.Close();
                   // Console.WriteLine(ten[Convert.ToInt32(number[i]) - 1] + teen);
                }
                if (Convert.ToInt32(number[i]) == 11)
                {
                    StreamWriter newfile = new StreamWriter($"C:\\Users\\lsere\\OneDrive\\Рабочий стол\\kr1\\{11}.txt", false, enc1251);
                    newfile.WriteLine("eleven");
                    newfile.Close();
                }
                if (Convert.ToInt32(number[i]) == 12)
                {
                    StreamWriter newfile = new StreamWriter($"C:\\Users\\lsere\\OneDrive\\Рабочий стол\\kr1\\{12}.txt", false, enc1251);
                    newfile.WriteLine("twelve");
                    newfile.Close();
                }
                if (Convert.ToInt32(number[i]) == 20)
                {
                    StreamWriter newfile = new StreamWriter($"C:\\Users\\lsere\\OneDrive\\Рабочий стол\\kr1\\{20}.txt", false, enc1251);
                    newfile.WriteLine("twenty");
                    newfile.Close();
                }
                if(Convert.ToInt32(number[i]) >=)
            }
        }
        static void ReadFile(StreamReader secondfile, int n)
        {
            for(int i = 0; i < n - 1; i++)
            {
                string Line = secondfile.ReadLine();
                string[] number = Line.Split(" ");
                DefineTheNumber(number);
            }
        }
        static int CountLines(StreamReader firstfile)
        {
            string Line = "";
            int n = 0;
            while (Line != null)
            {
                Line = firstfile.ReadLine();
                n++;
            }
            return n;
        }
        static void Main(string[] args)
        {
            var enc1251 = CodePagesEncodingProvider.Instance.GetEncoding(1251);
            StreamReader firstfile = new StreamReader("C:\\Users\\lsere\\OneDrive\\Рабочий стол\\newfile.txt", enc1251);
            StreamReader secondfile = new StreamReader("C:\\Users\\lsere\\OneDrive\\Рабочий стол\\newfile.txt", enc1251);
            ReadFile(secondfile, CountLines(firstfile));
        }
    }
}
