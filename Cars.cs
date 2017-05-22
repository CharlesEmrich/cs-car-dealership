using System;
using System.Collections.Generic;

class Car
{
  private string _MakeModel;
  private int _Price;
  private int _Miles;
  private string Desc = "Description Un-Set.";

  public string GetMakeModel()
  {
    return _MakeModel;
  }
  public void SetMakeModel(string newMakeModel)
  {
    _MakeModel = newMakeModel;
  }
  public int GetMiles()
  {
    return _Miles;
  }
  public void SetMiles(int newMiles)
  {
    _Miles = newMiles;
  }
  public int GetPrice()
  {
    return _Price;
  }
  public void SetPrice(int newPrice)
  {
    _Price = newPrice;
  }
  public string GetDesc()
  {
    return Desc;
  }
  public void SetDesc(string newDesc)
  {
    Desc = newDesc;
  }
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car();
    porsche.SetMakeModel("2014 Porsche 911");
    porsche.SetPrice(114991);
    porsche.SetMiles(7864);
    porsche.SetDesc(porsche.GetMakeMode() + "with " + porsche.GetMiles() + " miles on it.");

    Car ford = new Car();
    ford.SetMakeModel("2011 Ford F450");
    ford.SetPrice(55995);
    ford.SetMiles(14241);

    Car lexus = new Car();
    lexus.SetMakeModel("2013 Lexus RX 350");
    lexus.SetPrice(44700);
    lexus.SetMiles(20000);

    Car mercedes = new Car();
    mercedes.SetMakeModel("Mercedes Benz CLS550");
    mercedes.SetPrice(39900);
    mercedes.SetMiles(37979);

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

    Console.WriteLine("What is your top price? ");
    int topPrice = int.Parse(Console.ReadLine());

    foreach(Car car in Cars)
    {
      if (car._Price <= topPrice) {
        Console.WriteLine(car.GetDesc());
      }
    }
  }
}
