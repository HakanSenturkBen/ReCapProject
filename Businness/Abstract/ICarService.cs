using Entities.Concrete;
using System.Collections.Generic;

namespace Businness
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandsOrColor(int ID);
        List<Car> GetAllByDailyPrice(int min, int max);
    }
}
