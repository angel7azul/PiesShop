using System;
using System.Collections.Generic;

namespace PiesShop.Models
{
    public interface IPieRespository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int id);
    }
}