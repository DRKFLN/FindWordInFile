using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using static System.Console;
namespace FindWordInFile
{
    class Program
    {

        static void Main(string[] args)
        {
            string word;//искомое слово
            string path = @""; //путь
            char[] Sep = { ' ', '-', '\n', '\t' }; //разделитель
            int counter = 0;//счетчик слов
            Console.WriteLine("Укажите путь к файлу");
            //path = Console.ReadLine();
            path = @"C:\\Users\arata\Desktop\1.txt";
            Console.WriteLine("Укажите искомое слово");
            word = Console.ReadLine();
            FileInfo fileinf = new FileInfo(path);
            if (fileinf.Exists)
            {
                Console.WriteLine("Файл найден");
                Console.WriteLine("Имя файла " + fileinf.Name);
                Console.WriteLine("Размер файла " + fileinf.Length);
                string text = File.ReadAllText(path);
                string[] arrString = text.Split(Sep);
                foreach (string s in arrString)
                {
                    if (s.Contains(word))
                    {
                        counter += 1;
                    }
                }
                Console.WriteLine("В файле " + fileinf.Name + " слово \"" + word + "\"" + " встреченно " + counter + " раз");
            }
            else
            {
                Console.WriteLine("Такого файла нет");
            }
        }
    }
}
