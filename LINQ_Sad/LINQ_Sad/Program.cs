using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Sad
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] teams = { "Бавария", "Белоруссия", "Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

            var selectedTeams = from a in teams // определяем каждый объект из teams как a
                                where a.ToUpper().StartsWith("М") //фильтрация по критерию
                                orderby a  // упорядочиваем по возрастанию
                                select a; // выбираем объект

            foreach (string s in selectedTeams)
                Console.WriteLine(s);
            Console.ReadKey();
            
        }

    }
}
