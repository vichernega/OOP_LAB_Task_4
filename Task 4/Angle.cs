using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Angle
    {
        private double degree, minute, second;

        public double Degree
        {
            get { return degree; }
            set
            {
                bool flag = true;
                while (flag)
                {
                    if (value >= 360) { value -= 360; }
                    else { flag = false; }
                }
                degree = value;
            }
        }
        public double Minute
        {
            get { return minute; }
            set
            {
                bool flag = true;
                while (flag)
                {
                    if (value >= 60)
                    {
                        value -= 60;
                        Degree += 1;
                    }
                    else { flag = false; }
                }
                minute = value;
            }
        }
        public double Second
        {
            get { return second; }
            set
            {
                bool flag = true;
                while (flag)
                {
                    if (value >= 60)
                    {
                        value -= 60;
                        Minute += 1;
                    }
                    else { flag = false; }
                    second = value;
                }
            }
        }
        public override string ToString()
        {
            return $"{degree}°{minute}'{second}''";
        }


        public double ToDecimal()
        {
            double decimalAngle = degree + (minute + second / 60) / 60;
            return decimalAngle;
        }
        public double ToRadians()
        {
            double radianAngle = ToDecimal() * Math.PI / 180;
            return radianAngle;
        }
        public void ToAngle(double radianAngle)
        {
            double decimalAngle = radianAngle * 180 / Math.PI;
            degree = Math.Floor(decimalAngle);
            double doublePartOfDecimal_1 = decimalAngle - Math.Floor(decimalAngle);
            minute = Math.Floor(doublePartOfDecimal_1*60);
            double doublePartOfDecimal_2 = doublePartOfDecimal_1 * 60 - minute;
            second = Math.Round(doublePartOfDecimal_2 * 60, 4);

        }
        public static Angle operator +(Angle angle1, Angle angle2)
        {
            Angle sumOfAngles = new Angle();
            sumOfAngles.ToAngle(angle1.ToRadians() + angle2.ToRadians());
            return sumOfAngles;
        }
        public static Angle operator -(Angle angle1, Angle angle2)
        {
            Angle differenceOfAngles = new Angle();
            differenceOfAngles.ToAngle(angle1.ToRadians() - angle2.ToRadians());
            return differenceOfAngles;
        }
        public static Angle operator *(Angle angle, double number)
        {
            Angle multiplicatedAngle = new Angle();
            multiplicatedAngle.ToAngle(angle.ToRadians() * number);
            return multiplicatedAngle;
        }
        public void Write(StreamWriter stream)
        {
            stream.WriteLine(Degree);
            stream.WriteLine(Minute);
            stream.WriteLine(Second);
        }
        public void Read(StreamReader stream)
        {
            Degree = Convert.ToDouble(stream.ReadLine());
            Minute = Convert.ToDouble(stream.ReadLine());
            Second = Convert.ToDouble(stream.ReadLine());
        }
       
    }

}
