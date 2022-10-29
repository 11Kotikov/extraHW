﻿// Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент времени: 
// «h часов, m минут, s секунд». 
// Определить угол (в градусах) между положением часовой стрелки в начале суток
// и в указанный момент времени.


void TimeAngle(int h, int m, int s)
{
    int hSeconds = h * 3600,
        mSeconds = m * 60;
    int summ = hSeconds + mSeconds + s;

    if (h >= 0 & h < 12 & m >= 0 & m < 60 & s >= 0 & s < 60)
    {
        int angle = summ / 120;
        System.Console.WriteLine($"your time is {h}:{m}:{s} and angle between is {angle} degrees ");
    }
    else if (h >= 12 & h < 24 & m >= 0 & m < 60 & s >= 0 & s < 60)
    {
        int angle = (summ / 120) - 360;
        System.Console.WriteLine($"your time is {h}:{m}:{s} and angle is {angle} degrees ");
    }
    else
    {
        System.Console.WriteLine("please input correct time is no more than 23h:59m:59s format ");
    }
}

System.Console.WriteLine("Input Hours");
int h = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input Minutes");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input Seconds");
int s = Convert.ToInt32(Console.ReadLine());
System.Console.Write("the first task:");
TimeAngle(h, m, s);
System.Console.WriteLine();

//С начала суток часовая стрелка повернулась на y градусов (0 ≤ y ≤ 360, y — вещественное число).
//Определить число полных часов и число полных минут, прошедших с начала суток.

void AngleTime()
{
    int angle = new Random().Next(0, 361);
    int hours = (angle * 120) / 60 / 60, hoursInSeconds = angle * 120;
    int minutes = (hoursInSeconds - (hours * 3600)) / 60;
    System.Console.WriteLine($"The angle is {angle} and its time is {hours}:{minutes} a.m. or {hours + 12}:{minutes} p.m.");
}
System.Console.Write("the second task:");
AngleTime();