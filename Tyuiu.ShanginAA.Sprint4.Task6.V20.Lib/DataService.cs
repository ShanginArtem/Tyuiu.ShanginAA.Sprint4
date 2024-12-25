﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShanginAA.Sprint4.Task6.V20.Lib
{
    public class DataService : ISprint4Task6V20
    {
        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, predmet => predmet.Length < 10);
            return mas;
        }
    }
}
