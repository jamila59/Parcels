using Microsoft.AspNetCore.Mvc;

namespace ParcelCalc.Models
{
  public class Parcel
  {
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    private string _size;
    public double Price { get; set; }

    public Parcel (double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }
    public void Volume()
    {
      double volume = (Length * Width * Height);
      if (volume < 30 )
      {
        _size = "small";
      }
      else if (volume >= 30 && volume < 40 )
      {
        _size = "medium";
      }
      else 
      {
        _size = "large";
      }
    }
    public double CostToShip()
    {
      if( _size =="small")
      {
        Price = 5;
      }
      else if (_size == "medium")
      {
         Price = 10;
      }
      else
      {
        Price = 15;
      }
      return Price;
    }

    public string returnResults(double result)
    {
      
      string results = result.ToString();
      return results;
    }
  }
}