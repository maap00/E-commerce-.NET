using WebAppDataBaseConnection.datba;
using WebAppDataBaseConnection.DTOs;
using WebAppDataBaseConnection.Mapper;
using WebAppDataBaseConnection.models;

namespace WebAppDataBaseConnection.service
{
    public class ProductServices
    {

        private CoderContext context;

        public ProductServices(CoderContext coderContext)
        {
            this.context = coderContext;
        }


        public List<Producto> GetAllProductsList()
        {
           List<Producto> products = context.Productos.ToList();

           return products;            
        }

        public  Producto GetProductForID(int id)
        {
            List<Producto> productsList = GetAllProductsList();

            foreach (Producto product in productsList)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }
            return null;
        }

        public  bool AddNewProduct(ProductDTO dto)
        {
            Producto product = ProductMapper.MapperToProduct(dto);
            context.Productos.Add(product);
            context.SaveChanges();
            return true;            
        }

        public  bool DeleteProduct(int id)
        {     
           Producto productToDelete = context.Productos.Where(u => u.Id == id).FirstOrDefault();

           if (productToDelete != null)
           {
                context.Productos.Remove(productToDelete);
                context.SaveChanges();
                return true;
           }
                return false;            
        }

        public bool UpdateProductForId(int id, ProductDTO productDTO)
        {           

                Producto? productFound = context.Productos.Where(u => u.Id == id).FirstOrDefault();

                productFound.Descripciones = productDTO.Descripciones;
                productFound.Costo = productDTO.Costo;
                productFound.PrecioVenta = productDTO.PrecioVenta;
                productFound.Stock = productDTO.Stock;
                productFound.IdUsuario = productDTO.IdUsuario;          


                context.Productos.Update(productFound);

                context.SaveChanges();
                return true;
            
        }
    }
}
