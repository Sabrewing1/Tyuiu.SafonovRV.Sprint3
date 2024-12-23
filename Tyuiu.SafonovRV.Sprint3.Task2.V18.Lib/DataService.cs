﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SafonovRV.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 1;
            int k = startValue;
            do
            {
                sumSeries = sumSeries * Math.Pow((1 / Math.Cos(startValue)) + (k / 8), 3);
                startValue++;
            } while (startValue <= stopValue);
            

            double a = 287.18;
                return a;
        }
    }
}
