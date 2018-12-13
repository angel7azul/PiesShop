using System;
using System.Collections.Generic;


namespace PiesShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Pie> GetAllPies()
        {
           return appDbContext.Pies;
        }

        public Pie GetPieById(int id)
        {
            return appDbContext.Pies.Find(id);
        }

        public void AddPie(Pie pie) 
        {
            appDbContext.Pies.Add(pie);
            appDbContext.SaveChanges();
        }
    }
}