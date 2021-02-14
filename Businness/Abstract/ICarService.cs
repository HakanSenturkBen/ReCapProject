using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Businness
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandsOrColor(int ID);
        List<Car> GetAllByDailyPrice(decimal min, decimal max);
        List<CarDetailDto> GetCarDetails();
    }
}
