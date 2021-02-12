using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brands:ICar
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
    }
}
