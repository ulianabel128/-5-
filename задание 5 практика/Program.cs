using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_5_практика
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double p_dou=0;
            bool ok = false;

            do
            {
                Console.WriteLine("Введите n");
                string user = Console.ReadLine();
                ok = int.TryParse(user, out n);
                if (n < 0) ok = false;
                if (!ok) Console.WriteLine("Неверный ввод");
            }       
            while (!ok) ;

            ok = false;
            int[] mas = new int[n];

            for (int i=0; i<mas.Length;i++)
            {
                do
                {
                    Console.WriteLine("Введите a" + (i) + " элемент");
                    string user = Console.ReadLine();
                    ok = int.TryParse(user, out mas[i]);
                    if ((mas[i] < 0) && (mas[i]>1)) ok = false;
                    if ((i == (n - 1)) && (mas[i] != 1)) ok = false;
                    if (!ok) Console.WriteLine("Неверный ввод");
                }
                while (!ok);
                ok = false;
            }

            n=n-1;

            for (int i=mas.Length-1; i>-1; i--)
            {
                p_dou =p_dou+(mas[i]*Math.Pow(2, n));
                n--;
            }


            Console.WriteLine("Первоначальное p="+p_dou);
            Console.WriteLine("p-1=" + (p_dou-1));

            p_dou--;
            int p_int=Convert.ToInt32(p_dou);
            string conclusion = "";

            Console.WriteLine();

            if ((p_int != 0) && (p_int!=-1))
            {
                while (p_int != 1)
                {
                    if (p_int % 2 == 0) conclusion = conclusion + "0";
                    else conclusion = conclusion + "1";
                    p_int = p_int / 2;
                }
                conclusion = conclusion + "1";
                conclusion = ReverseString(conclusion);
            }
            if (p_int == 0) conclusion = "0";
            if (p_int == -1) conclusion = "-1";

            Console.WriteLine(conclusion);
            Console.ReadKey();
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
