using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_1._1
{
    static class libl
    {

        public static void stpow(string word, int chislo)
        {
            string slovo = "";
            for (int i = 0; i < chislo; i++)
            {
                slovo += word;
            }
            Console.WriteLine("Решение - " + slovo);
        }


        public static void rev(string word)
        {
            string drow = "";
            for (int i = word.Length - 1; i > -1; i--)
            {
                drow += word[i];
            }
            Console.WriteLine("Перевернутая строка - " + drow);
        }


        public static void remove(string word, string letter)
        {
            string c = "";
            c = word.Replace(letter, "");
            Console.WriteLine("Решение - "  + c);
        }

        public static void leng(string str)
        {
            Console.WriteLine("Колличество символов в строке - " + str.Length);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите желаемую команду \n\nПример: stpow(“ha”,4) \n\n\tСписок команд:\n\nstpow(“ha”,4) => “hahahaha”\nrev(“xev”) => “vex” \nremove(“xeveer”,”e”) => “xvr” \nleng(“xeveer”)  => 6");
            string command = Console.ReadLine();
            string[] mass = command.Split(' ','(');
            if (mass[0] == "stpow")
            {
                mass = command.Split('(','"', '"', ',', ')') ;
                string word = mass[2];
                int chislo = Convert.ToInt32(mass[4]);
                libl.stpow(word, chislo);
            }
            if (mass[0] == "rev")
            {
                mass = command.Split('(', '"', '"', ')');
                string word = mass[2];
                libl.rev(word);
            }
            if (mass[0] == "remove")
            {
                mass = command.Split('(', '"', '"', ',', '"', '"', ')');
                foreach (var wordss in mass)
                { Console.WriteLine($"{wordss}"); }
                string word = mass[2];
                string letter = mass[5];
                libl.remove(word, letter) ;
            }
            if (mass[0] == "leng")
            {
                mass = command.Split('(', '"', '"', ')');
                string str = mass[2];
                libl.leng(str);
            }
            Console.WriteLine("Для выхода нажмите любую кнопку");
            Console.ReadLine();
        }
    }
    
}
