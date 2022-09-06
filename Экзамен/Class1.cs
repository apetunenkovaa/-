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

        public void trace(int[] arr)
        {
            Trace.Listeners.Add(new TextWriterTraceListener("Debug.txt"));
            for (int i = 0; i < arr.Length; i++)
            {
                Trace.WriteLine(arr[i]);
            }

            Trace.Flush();
        }
        /// <summary>
        /// метод, предназначенный для записи результата в файл
        /// </summary>
        /// <param name="rez"></param>
        public void zapis(int rez)
        {
            string Path = "Результат.txt";   // Пропысываем полный путь к файлу

            File.WriteAllText(Path, Convert.ToString(rez));    // Добавляем новое содержимое в файл

            Console.WriteLine(File.ReadAllText(Path));

            Console.WriteLine();

            File.AppendAllText(Path, Environment.NewLine);  // Переход на новую строку в файле
        }
    }
    
    
}