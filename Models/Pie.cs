using System;
namespace PiesShop.Models
{
    /*Si se actualiza el modelo, se debe agregar una nueva migracion(dotnet ef migrations add AddInStockPie)
    y posterior a eso se actualiza la BD (dotnet ef database update)*/
    public class Pie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string  ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool IsInStock { get; set; }
    }
}