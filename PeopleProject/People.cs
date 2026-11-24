using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleProject
{
    internal class People
    {
        List<int> eletkorok;

        public People()
        {
            this.eletkorok = new List<int>();
        }

        public void UjSzemely(int eletkor)
        {
            if (eletkor < 0)
            {
                throw new ArgumentException("Az életkor nem lehet negatív!");
            }
            else
            {
                eletkorok.Add(eletkor);
            }
        }
public double AtlagEletkor(int minEletkor, int maxEletkor)
{
    if (eletkorok.Count == 0)
    {
        throw new InvalidOperationException("Nincs személy a listában!");
    }

    if (minEletkor > maxEletkor)
    {
        throw new ArgumentException("A maxEletkornak nagyobbnak kell lennie mint a minEletkor!");
    }

    if (minEletkor < 0 || maxEletkor < 0)
    {
        throw new ArgumentException("Az életkor nem lehet negatív!");
    }

    int ossz = 0;
    int db = 0;

    for (int i = 0; i < eletkorok.Count; i++)
    {
        if (eletkorok[i] >= minEletkor && eletkorok[i] <= maxEletkor)
        {
            ossz += eletkorok[i];
            db++;
        }
    }

    if (db == 0)
    {
        throw new ArgumentException("Nincs a megadott korhatárok közé eső személy!");
    }

    return ossz / db;
}
    }
}
