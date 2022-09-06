using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Экзамен
{
    internal class Class1
    {
        

        public void trace()
        {
            Trace.Listeners.Add(new TextWriterTraceListener("Debug.txt"));

            Trace.WriteLine("Программа запущена" );

            Trace.Flush();
        }
        /// <summary>
        /// метод, предназначенный для записи результата в файл
        /// </summary>
        /// <param name="rez"></param>
        public void zapis(double rez)
        {
            string Path = "Результат.txt";   // Пропысываем полный путь к файлу

            File.WriteAllText(Path, "Процентная ставка равна "+ Convert.ToString(rez));    // Добавляем новое содержимое в файл

            Console.WriteLine(File.ReadAllText(Path));

            Console.WriteLine();

            File.AppendAllText(Path, Environment.NewLine);  // Переход на новую строку в файле
        }
    }
    
    
}