using System;

namespace Module3HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyList<string> list = new MyList<string>();
            list.Add("H");
            list.Add("e");
            list.Add("l");
            list.Add("l");
            list.Add("o");
            list.AddRange(new string[] { "s", "saa", "a" });
            list.RemoteAt(1);
            bool res = list.Remote("a");
            Console.WriteLine($"Размерность массива : {list.GetArr().Length}");
            Console.WriteLine($"Статус удаления : {res}");
            list.Sort();
            list.Add("A");
            foreach (var item in list.GetArr())
            {
                Console.WriteLine(item);
            }
        }
    }
}