using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
n(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRaiting(5);
            diary.AddRaiting(8.5f);
            diary.AddRaiting(4.7f);

            float avg = diary.CalculateAverage();
            float max = diary.GiveMaxRating();
            float min = diary.GiveMinRating();

            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu 1-10");

                float rating = float.Parse(Console.ReadLine());

                diary.AddRaiting(rating);
            }
        }
    }
}
