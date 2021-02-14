using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness.Abstract
{
    public interface IBrandsService
    {
        List<Brands> GetAll();
        Brands GetByID(int brandID);
    }
}
