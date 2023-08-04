using Restaurant_BusinessLayer.Abstract;
using Restaurant_DataAccessLayer.Abstract;
using Restaurant_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_BusinessLayer.Concrete
{
    public class ProductImageMenager : IProductImageService
    {
        private readonly IProductImageDal _productImageDal;

        public ProductImageMenager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }

        public void TDelete(ProductImage t)
        {
            _productImageDal.Delete(t);
        }

        public ProductImage TGetByID(int id)
        {
            return _productImageDal.GetById(id);
        }

        public List<ProductImage> TGetList()
        {
            return _productImageDal.GetList();
        }

        public void TInsert(ProductImage t)
        {
            _productImageDal.Insert(t);
        }

        public void TUpdate(ProductImage t)
        {
            _productImageDal.Update(t);
        }
    }
}
