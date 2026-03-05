using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

public struct GameTime
{
    public int Hours;
    public int Minutes;
    public int Seconds;
    public GameTime(int hours, int minutes, int seconds)
    {
        if (seconds >= 60)
        {
            minutes += seconds / 60;
            seconds = seconds % 60;
            if (minutes >= 60)
            {
                hours += minutes / 60;
                minutes = minutes % 60;
            }
        }
        Hours = hours; 
        Minutes = minutes; 
        Seconds = seconds;
    }
    public static GameTime operator +(GameTime a, GameTime b)
    {
        return new GameTime(a.Hours + b.Hours, a.Minutes + b.Minutes, a.Seconds + b.Seconds);
    }
    public static GameTime operator -(GameTime a, GameTime b)
    {
        int value = (a.Hours * 3600 + a.Minutes*60 + a.Seconds) - (b.Hours * 3600 + b.Minutes * 60 + b.Seconds);
        if (value < 0)
        {
            return new GameTime(0, 0, 0);
        }
        return new GameTime(a.Hours - b.Hours, a.Minutes - b.Minutes, a.Seconds - b.Seconds);
    }
    public static bool operator ==(GameTime a, GameTime b)
    {
        return a.Hours == b.Hours && a.Minutes == b.Minutes && a.Seconds == b.Seconds;
    }
    public static bool operator !=(GameTime a, GameTime b)
    {
        return !(a == b);
    }
    public static bool operator <(GameTime a, GameTime b)
    {
        return (a.Hours * 3600 + a.Minutes * 60 + a.Seconds) < (b.Hours * 3600 + b.Minutes * 60 + b.Seconds);
    }
    public static bool operator >(GameTime a, GameTime b)
    {
        return (a.Hours * 3600 + a.Minutes * 60 + a.Seconds) > (b.Hours * 3600 + b.Minutes * 60 + b.Seconds);
    }
    public static GameTime operator *(GameTime t, int a)
    {
        return new GameTime(t.Hours * a, t.Minutes * a, t.Seconds * a);
    }
    public override bool Equals(object obj)
    {
        if (obj is GameTime other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Hours, Minutes, Seconds);
    }

    public override string ToString()
    {
        return $"{Hours}h {Minutes}m {Seconds}s";
    }
    public int GetTotalSeconds()
    {
        return Hours * 3600 + Minutes * 60 + Seconds;
    }
}
