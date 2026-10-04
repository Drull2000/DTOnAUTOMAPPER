using DTOnAUTOMAPPER.DTO;
using DTOnAUTOMAPPER.Services.Abstract;
using System.Xml.Linq;

namespace DTOnAUTOMAPPER.Services;

public class ProductService : IProductService
{
    private static readonly List<ProductDTO> products = new List<ProductDTO>();
    public ProductDTO Create(ProductDTO product)
    {
        var newProduct = new ProductDTO
        {
            Name = product.Name,
            Price = product.Price
        };
        products.Add(newProduct);
        return newProduct;
    }
}