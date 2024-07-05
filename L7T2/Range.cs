using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_1
{
    public class Range
    {
        public double from;
        public double to;

        public Range(double userFrom, double userTo)
        {
            this.from = userFrom;
            this.to = userTo;
        }

        //На самом деле если мы принимаем 2 вещественных числа то количество будет бесконечно т.к. вещественных бесконечно
        //Так что будем считать что 2 целочисленных числа и что from < to, иначе задача не имеет решения
        //Проблема с вещественными такая что между 2 и 2.5 сколько чисел? Или 0 или бесконечность. 
        //Вот был бы ты на лекции Гутмана про самую знаменитую задачу 20 века про гипотизу континиума то понял
        //Можешь почитать https://habr.com/ru/articles/766446/ я не знаю как там все точно расписано но суть такая что
        //вещественные числа это континиум, даже если между 2 любыми. Так что вот
        //Или просто объясни в чем прикол
        public double GetLength()
        {
            return this.to - this.from + 1;
        }

        public bool IsInside(double number)
        {
            if (number > this.from && number < this.to)
            {
                return true;
            }

            return false;
        }
    }
}