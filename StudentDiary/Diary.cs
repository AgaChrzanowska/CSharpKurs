using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        // Stan - zmienne/pola
        List<float> ratings = new List<float>();

        // Zachowania - metody, które chcemy wpisać, aby umożliwić współdziałania z dzienniczkiem.
        public void AddRaiting(float rating)
        {
            ratings.Add(rating);
        }

        public float CalculateAverage()
        {
            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }
            avg = sum / ratings.Count();
            return avg;
        }
        public float GiveMaxRating()
        {
            return ratings.Max();
        }
        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
