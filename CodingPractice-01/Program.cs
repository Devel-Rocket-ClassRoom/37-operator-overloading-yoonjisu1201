using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
/*
// README.md를 읽고 아래에 코드를 작성하세요.
//1.
Counter c = new Counter(5);
Console.WriteLine(-c);
c++;
Console.WriteLine(c);


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
Fraction f1 = new Fraction(1, 2);
Fraction f2 = new Fraction(1, 3);
Console.WriteLine(f1 + f2);
Console.WriteLine(f1 * f2);
public struct Fraction
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
        return new Fraction(num, den);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}
*/
//3.


public struct Money
{
    public decimal Amount;
    public string Currency;

    public Money(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public static bool operator ==(Money a, Money b)
    {
        return a.Currency == b.Currency && a.Amount == b.Amount;
    }

    public static bool operator !=(Money a, Money b)
    {
        return !(a == b); 
    }

    public static bool operator <(Money a, Money b)
    {
        if (a.Currency != b.Currency)
        {
            throw new InvalidOperationException("통화가 다릅니다.");
        }
        return a.Amount < b.Amount;
    }
    public static bool operator >(Money a, Money b)
    {
        if (a.Currency != b.Currency)
        {
            throw new InvalidOperationException("통화가 다릅니다.");
        }
        return a.Amount > b.Amount;
    }

    public override bool Equals(object obj)
    {
        if (obj is Money other)
        {
            return this == other;
        }
        return false;
    }
}