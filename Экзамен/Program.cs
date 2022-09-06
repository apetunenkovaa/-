using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экзамен
{
    internal class Program
    {
        private static object otv;

        static void Main(string[] args)
        {
            MessageBox.Show("Программа запущена ", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

            while (true)
            {























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
    }   
}
