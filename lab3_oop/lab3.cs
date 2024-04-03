using System;

abstract class Triad
{
    public abstract void Increment();
}

class Date : Triad
{
    private int day;
    private int month;
    private int year;

    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public override void Increment()
    {
        day++;
        if (day > 31)
        {
            day = 1;
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
        }
    }

    public override string ToString()
    {
        return $"{day:D2}/{month:D2}/{year:D4}";
    }
}

class Time : Triad
{
    private int hours;
    private int minutes;
    private int seconds;

    public Time(int hours, int minutes, int seconds)
    {
        this.hours = hours;
        this.minutes = minutes;
        this.seconds = seconds;
    }

    public override void Increment()
    {
        seconds++;
        if (seconds >= 60)
        {
            seconds = 0;
            minutes++;
            if (minutes >= 60)
            {
                minutes = 0;
                hours++;
                if (hours >= 24)
                {
                    hours = 0;
                }
            }
        }
    }

    public override string ToString()
    {
        return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Date date = new Date(1, 1, 2024);
        Time time = new Time(23, 59, 59);

        Console.WriteLine("Initial date: " + date);
        Console.WriteLine("Initial time: " + time);

        date.Increment();
        time.Increment();

        Console.WriteLine("Date after incrementing by 1: " + date);
        Console.WriteLine("Time after incrementing by 1: " + time);
    }
}
