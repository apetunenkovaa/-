using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Экзамен
{
    internal class Program
    {
        public static object otv;

        static void Main(string[] args)
        {
            MessageBox.Show("Программа запущена ", "Начало", MessageBoxButtons.OK, MessageBoxIcon.Information);

            while (true)
            {
               

                Console.WriteLine("\nВведите сумму, которую хотите положить в банк:");
                double sumVklad = Convert.ToDouble(Console.ReadLine());
                


                double rez = PersentStavk(sumVklad);
                Class1 obj = new Class1();
                obj.trace();
                obj.zapis(rez);//метод, вызываемый из Class1
                Debug.WriteLine("Файл записан");

                MessageBox.Show("Программа выполнена ", "Конец", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    Console.Write("\nЖелаете повторить программу?\nДа(Y)/Нет(N)\nОтвет: ");
                    otv = Convert.ToChar(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Введены некорректные данные!");
                }
            }
            if ((otv.Equals('N') || otv.Equals('N') || otv.Equals('Т') || otv.Equals('т')))
            {
                return;
            }
        }

        public static double PersentStavk(double sumVklad)
        {
            double persStavk = 0;
            if (sumVklad < 700000)
            {
                persStavk = sumVklad / 50000;
            }
            else if (sumVklad < 700000)
            {
                persStavk = 20;
                //максимальная процентная ставка
            }
            return persStavk;
        }

    }
    
}
