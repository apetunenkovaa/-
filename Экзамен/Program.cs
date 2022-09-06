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
        private static object otv;

        static void Main(string[] args)
        {
            MessageBox.Show("Программа запущена ", "Начало", MessageBoxButtons.OK, MessageBoxIcon.Information);

            while (true)
            {
                int rez=0;
                Class1 obj=new Class1();
                obj.zapis(rez);
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
    }

    
    
}
