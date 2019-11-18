using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BrandService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BrandService.svc or BrandService.svc.cs at the Solution Explorer and start debugging.
    public class BrandService : IBrandService
    {
        carbrandEntities context = new carbrandEntities();

        public void DoWork()
        {
        }

        public List<CarBrand> GetCarBrands()
        {
            return context.CarBrands.ToList();
        }
    }
}
