using Businness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Concrete
{
    public class BrandsManager : IBrandsService
    {
        IBrandsDal _brandsDal;

        public BrandsManager(IBrandsDal brandsDal)
        {
            _brandsDal = brandsDal;
        }

        public List<Brands> GetAll()
        {
            return _brandsDal.GetAll();
        }

        public Brands GetByID(int brandID)
        {
            return _brandsDal.Get(b => b.BrandID == brandID);
        }
    }
}
