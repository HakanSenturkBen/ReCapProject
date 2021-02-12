using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businness
{
    public interface ICarService
    {
        List<Car> GetAll();
    }
}
