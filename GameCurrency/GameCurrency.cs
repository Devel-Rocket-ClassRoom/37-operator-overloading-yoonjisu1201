using System;
using System.Collections.Generic;
using System.Text;

public struct GameCurrency
{
    public int Gold;
    public int Silver;

    public GameCurrency(int gold, int silver)
    {
        if (silver >= 100)
        {
            gold += silver / 100;
            silver = silver % 100;
        }
        Gold = gold;
        Silver = silver;
    }

    public static GameCurrency operator +(GameCurrency a, GameCurrency b)
    {
        return new GameCurrency(a.Gold + b.Gold, a.Silver + b.Silver);
    }
    public static GameCurrency operator -(GameCurrency a, GameCurrency b)
    {
        int value = (a.Gold * 100 + a.Silver) - (b.Gold * 100 + b.Silver);
        if (value < 0)
        {
            return new GameCurrency(0, 0);
        }
        return new GameCurrency(a.Gold - b.Gold, a.Silver - b.Silver);
    }

    public static bool operator ==(GameCurrency a, GameCurrency b)
    {
        return a.Gold == b.Gold && a.Silver == b.Silver;
    }
    public static bool operator !=(GameCurrency a, GameCurrency b)
    {
        return !(a == b);
    }

    public static bool operator <(GameCurrency a, GameCurrency b)
    {
        return (a.Gold * 100 + a.Silver) < (b.Gold * 100 + b.Silver);
    }
    public static bool operator >(GameCurrency a, GameCurrency b)
    {
        return (a.Gold * 100 + a.Silver) > (b.Gold * 100 + b.Silver);
    }

    public override bool Equals(object obj)
    {
        if (obj is GameCurrency other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Gold, Silver);
    }

    public override string ToString()
    {
        return $"{Gold}G {Silver}S";
    }
    public int GetTotalSilver()
    {
        return Gold * 100 + Silver;
    }

}
