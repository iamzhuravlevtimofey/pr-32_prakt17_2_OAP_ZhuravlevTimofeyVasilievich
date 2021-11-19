using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace pr_32_prakt17_2_OAP_ZhuravlevTimofeyVasilievich
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("t.txt");
            List<People> peoples = new List<People>();
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                string[] t = str.Split(' ');
                peoples.Add(new People { F = t[0], I = t[1], O = t[2], AGE = Convert.ToInt32(t[3]), VES = Convert.ToInt32(t[4]) });
            }
            var sortedPeoples = from p in peoples
                                orderby p.AGE descending
                                select p;
            Console.WriteLine("Сортировка по возрасту:");
            foreach (People p in sortedPeoples)
            {
                Console.WriteLine(p.AGE);
            }
            var selectedPeoples = peoples.Where(p => p.AGE % 3 == 0);
            Console.WriteLine("Сотрудники с возрастом кратным 3:");
            foreach (People p in selectedPeoples)
            {
                Console.WriteLine($"{p.F} - {p.I} - {p.O} - {p.AGE} - {p.VES}");
            }
            Console.ReadLine();
        }
    }
    internal class People
    {
        public string F { get; set; }
        public string I { get; set; }
        public string O { get; set; }
        public int AGE { get; set; }
        public int VES { get; set; }
    }
}