using System;
using PiesShop.Models;
using System.Collections.Generic;

namespace PiesShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
