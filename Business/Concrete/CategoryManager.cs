using System;
using Business.Abstract;
using Core.Aspects;

namespace Business.Concrete
{
    public class CategoryManager :ICategoryService
    {
        public CategoryManager()
        {
        }

        [TestAspect]
        public void Add()
        {
            //... business code
        }

        public void Delete()
        {
            //... business code
        }

        public void Update()
        {
            //... business code
        }
    }
}
