using System;
using System.Collections.Generic;
using System.Text;
using TrustDataLayer.Models;

namespace TrustBusinessLayer.Repository
{
    public class FoodRepo : IFoodRepo
    {
        public void CreateFood(Foods food)
        {
            throw new NotImplementedException();
        }

        public void DeleteFood(Foods food)
        {
            throw new NotImplementedException();
        }

        public Foods FoodsById(int ID)
        {
            return new Foods { ID = 11, Category = "Non-Veg", OutletAssign = "Madivala", Date = "20/01/2021" };
        }

        public IEnumerable<Foods> GetAllFoods()
        {
            var foods = new List<Foods>
            {
                new Foods{ ID = 11, Category = "Non-Veg", OutletAssign = "Madivala",  Date="20/01/2021"},
                new Foods{ ID = 22, Category = "Both", OutletAssign = "Kochi", Date="21/01/2021"}
        };

            return foods;

        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateFood(Foods food)
        {
            throw new NotImplementedException();
        }
    }
}
