using Restaurant_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        public List<Product> TGetProductswithCategory();
    }
}
