using BLL.Specification;
using DAL.Entities.VehicleEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SpecClasses
{
    public class GetModelsByBrandIdSpec : GenericSpecification<Model>
    {
        public GetModelsByBrandIdSpec(int id) : base(m => m.BrandId == id)
        {
            
        }
    }
}
