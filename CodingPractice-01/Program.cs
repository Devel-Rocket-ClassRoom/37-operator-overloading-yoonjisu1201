using System;

// README.md를 읽고 아래에 코드를 작성하세요.
//1.
Counter c = new Counter(5);
Console.WriteLine(-c);

Console.WriteLine(++c);


public struct Counter
{
    public int Value;

    public Counter(int value)
    {
        Value = value; 
    }

    public static Counter operator -(Counter c)
    {
        return new Counter(-c.Value);
    }

    public static Counter operator ++(Counter c)
    {
        return new Counter(++c.Value);
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}

//2.

/*public struct Fraction
{
    public int Numerator;
    public int Denominator;

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        int num = a.Numerator * b.Denominator + a.Denominator * b.Numerator;
        int den = a.Denominator * b.Denominator;
        return new Fraction (num, den);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(a.Numerator*b.Numerator, a.Denominator*b.Denominator);
    }
}*/