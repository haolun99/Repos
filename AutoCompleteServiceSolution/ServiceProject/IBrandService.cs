using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBrandService" in both code and config file together.
    [ServiceContract]
    public interface IBrandService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<CarBrand> GetCarBrands(); 
    }
}
