using System;
using System.Collections.Generic;

class WineCellar
{
    private List<Wine> wines = new List<Wine>();

    public void AddWine(Wine wine)
    {
        wines.Add(wine);
    }

    public void RemoveWine(Wine wine)
    {
        wines.Remove(wine);
    }

    public List<Wine> SearchWine(string keyword)
    {
        return wines.FindAll(w => w.Name.Contains(keyword) || w.Region.Contains(keyword));
    }

    public void DisplayAllWines()
    {
        foreach (var wine in wines)
        {
            wine.DisplayInformation();
        }
    }
}
