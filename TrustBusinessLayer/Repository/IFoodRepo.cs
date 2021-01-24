using System;
using System.Collections.Generic;
using System.Text;
using TrustDataLayer.Models;

namespace TrustBusinessLayer.Repository
{
    public interface IFoodRepo
    {
        bool SaveChanges();
        IEnumerable<Foods> GetAllFoods();
        Foods FoodsById(int ID);

        void CreateFood(Foods food);
        void UpdateFood(Foods food);
        void DeleteFood(Foods food);
    }
}
