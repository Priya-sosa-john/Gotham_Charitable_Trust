using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrustDataLayer.Models;

namespace TrustBusinessLayer.Repository
{
    public class SqlFoodRepo : IFoodRepo
    {
        private readonly GothamContext _context;

        public SqlFoodRepo(GothamContext context)
        {
            _context = context;
        }

        public void CreateFood(Foods food)
        {
            if (food == null)
            {
                throw new ArgumentNullException(nameof(food));
            }
            _context.Foods.Add(food);
        }

        public void DeleteFood(Foods food)
        {
            throw new NotImplementedException();
        }

        public Foods FoodsById(int ID)
        {
            return _context.Foods.FirstOrDefault(p => p.ID == ID);
        }

        public IEnumerable<Foods> GetAllFoods()
        {
            return _context.Foods.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateFood(Foods food)
        {
            throw new NotImplementedException();
        }
    }
}
