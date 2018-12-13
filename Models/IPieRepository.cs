using System;
using System.Collections.Generic;

namespace PiesShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int id);
        void AddPie(Pie pie);
    }
}