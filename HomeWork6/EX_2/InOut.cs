using System;
using System.IO;

namespace EX_2
{
    public class InOut
    {
        /// <summary>Метод производит расчёт значения переданной функции и записывает в файл двоинчм потоком</summary>
        public void Save(string fileName, double start, double end, double step, Fun F)
        {
            FileStream fs = new(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new(fs);

            while (start <= end)
            {
                bw.Write(F(start));
                start += step;
            }
            bw.Close();
            fs.Close();
        }

        /// <summary>Функция возвращает массив значений из файла и находит минимальное</summary>

        public double[] Load(string fileName, out double min)
        {
            FileStream fs = new(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new(fs);
            double[] array = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                array[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return array;
        }
    }
}
