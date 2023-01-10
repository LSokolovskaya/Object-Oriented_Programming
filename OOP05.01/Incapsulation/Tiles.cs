// 1. Создать класс Tiles (кафель), который будет содержать свойства с открытым доступом: 
// Brand, SizeH, SizeW, Price, метод класса GetData() возвращающий полную информацию о плитке 
// и метод класса GetCountTiles() принимающий площадь и возвращающий количество плиток необходимое для данной площади. 
// В главном методе объявить пару объектов класса и внести данные в свойства. Затем отобразить их, 
// вызвав методы GetData() и GetCountTiles().

namespace Incapsulation;

public class Tiles
{

    public string Brand { get; set; }
    public double SizeH { get; set; }
    public double SizeW { get; set; }
    public double Price { get; set; }

    public Tiles(string brand, double sizeH, double sizeW, double price)
    {
        Brand = brand;
        SizeH = sizeH;
        SizeW = sizeW;
        Price = price;
    }

    public string GetData()
    {
        return $"brand : {Brand}, Size : {SizeH} x {SizeW}, price : {Price}";
    }

    public int GetCountTiles(double s)
    {
        return (int)Math.Ceiling(s / (SizeH * SizeW));
    }
}