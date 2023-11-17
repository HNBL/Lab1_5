using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
    {

        static void Main(string[] args)
        {
        Console.WriteLine("Введите периметр треульника ");

        double P= Convert.ToDouble(Console.ReadLine());
            double Side;
            Side = P / 3; //Значение строны
      
           
            double p2= P/2 - Side;//Полупериметр
            double pow =Math.Pow(p2,3);// возведения в куб по формуле Герона
            double s = pow * P/2;
            double S=Math.Sqrt(s);//корень крвадратный по формуле герона

        Console.WriteLine("Сторона   Площадь\n {0: 0.00}   {1: 0.00}",Side,S);
        
    }
    }
