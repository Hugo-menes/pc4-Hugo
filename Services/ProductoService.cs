using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pc4_ml.Models;

namespace pc4_ml.Services
{
    public class ProductoService
    {
        public List<Producto> getTrendingProductos() {
            List<Producto> result = new List<Producto>
            {
                new Producto { ProductoId = 3, ProductoNombre = "Ceviche" },
                new Producto { ProductoId = 5, ProductoNombre = "Lomo Saltado" },
                new Producto { ProductoId = 9, ProductoNombre = "Ají de Gallina" }
            };

            return result;
        }
        public List<Producto> getAllProductos() {
            List<Producto> result = new List<Producto>
            {
                new Producto { ProductoId = 1, ProductoNombre = "Anticuchos" },
                new Producto { ProductoId = 2, ProductoNombre = "Causa Rellena" },
                new Producto { ProductoId = 3, ProductoNombre = "Ceviche" },
                new Producto { ProductoId = 4, ProductoNombre = "Papa a la Huancaína" },
                new Producto { ProductoId = 5, ProductoNombre = "Lomo Saltado" },
                new Producto { ProductoId = 6, ProductoNombre = "Tacu Tacu" },
                new Producto { ProductoId = 7, ProductoNombre = "Pollo a la Brasa" },
                new Producto { ProductoId = 8, ProductoNombre = "Arroz con Pollo" },
                new Producto { ProductoId = 9, ProductoNombre = "Ají de Gallina" },
                new Producto { ProductoId = 10, ProductoNombre = "Seco de Cabrito" }
            };

            return result;
        }
    }
}