using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServicioOperaciones
{
    /// <summary>
    /// Descripción breve de OperacionesSW
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class OperacionesSW : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public decimal Sumar(decimal ValorA, decimal ValorB)
        {
            return ValorA + ValorB;
        }
        [WebMethod]
        public decimal Resta(decimal ValorA, decimal ValorB)
        {
            return ValorA - ValorB;
        }
        [WebMethod]
        public decimal Multi(decimal ValorA, decimal ValorB)
        {
            return ValorA * ValorB;
        }
        [WebMethod]
        public decimal Division(decimal ValorA, decimal ValorB)
        {
            return ValorA / ValorB;
        }
        [WebMethod]
        public double Potencia(int ValorA, int ValorB)
        {
            return Math.Pow(ValorA, ValorB);
        }

        [WebMethod]
        public List<Producto> ProductosRebajados()
        {
            return Productos.ToList();
        }

        [WebMethod]
        public List<Producto> ProductosPorNombre(string nombre)
        {
            return Productos.Where(x=>x.Nombre.Contains(nombre)).ToList();
        }
        [WebMethod]
        public Producto GetProducto(int id)
        {
            return Productos.Where(x => x.Id==id).FirstOrDefault();
        }

        [WebMethod]
        public void AddProducto(int id, string nombre, decimal precio, int cant )
        {
            Producto Nuevo = new Producto(id, nombre, precio, cant);

            Productos.Add(Nuevo);
            
        }



        public static List<Producto> Productos = new List<Producto>()
        { 
            new Producto(1,"Camisa Polo", 20,10)
            ,new Producto(2,"Pantalon Jeans", 120,30)
            ,new Producto(3,"Zapatos Rebook", 1200,15)
        };
        public class Producto
        {
            public Producto() { }
            public Producto(int id, string nombre, decimal precio, int existencia)
            {
                Id = id;
                Nombre = nombre;
                Precio = precio;
                Existencia = existencia;
            }

            public int Id { get; set; }
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public int Existencia { get; set; }
        }
    }
}
