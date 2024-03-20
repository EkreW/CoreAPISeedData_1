using CoreAPISeedData_1.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreAPISeedData_1.Extensions
{
    public static class DataSeedExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region CategoryData
            Category c = new()
            {
                ID = 1,
                CategoryName = "Tatlılar",
                Description = "Test verisidir"
            };
            modelBuilder.Entity<Category>().HasData(c);
            #endregion
        }
    }
}
