using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Absract
{
    public interface ICarService
    {
        List<Car> GetAll();
    }
}
