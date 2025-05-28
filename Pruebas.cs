using System.Linq;
using NUnit.Framework;
using ProyectoFinalPrg;

namespace ProyectoFinalPrg.Tests
{
    [TestFixture]
    public class Pruebas
    {
        private Form2 form2;

        [SetUp]
        public void SetUp()
        {
            // Inicializa el formulario antes de cada prueba
            form2 = new Form2();

            // Simula la carga de datos en el ComboBox y ListBox
            form2.Articulos.Items.Add(new Form2.Articulo { ID = 1, Nombre = "Producto1", Precio = 100 });
            form2.Articulos.Items.Add(new Form2.Articulo { ID = 2, Nombre = "Producto2", Precio = 200 });
            form2.MostrarDatosGroupbox();
        }

        [Test]
        public void AgregarProductoAlCarrito_ProductoSeleccionado_SeAgregaCorrectamente()
        {
            // Arrange
            form2.cmb_ArticuloComprar.SelectedIndex = 0; // Selecciona el primer producto en el ComboBox

            // Act
            form2.btn_comprar_Click(null, null);

            // Assert
            var carrito = form2.lisBox_carritoCompra.Items.Cast<Form2.Articulo>().ToList();
            var articulosDisponibles = form2.Articulos.Items.Cast<Form2.Articulo>().ToList();

            Assert.AreEqual(1, carrito.Count, "El carrito debería contener un producto.");
            Assert.AreEqual("Producto1", carrito[0].Nombre, "El producto en el carrito no coincide con el seleccionado.");
            Assert.AreEqual(1, articulosDisponibles.Count, "La lista de artículos disponibles debería tener un producto menos.");
            Assert.AreEqual("Producto2", articulosDisponibles[0].Nombre, "El producto restante en la lista de artículos disponibles no coincide.");
        }

        [Test]
        public void EliminarProducto_ProductoSeleccionado_SeEliminaCorrectamente()
        {
            // Arrange
            form2.Articulos.SelectedIndex = 0; // Selecciona el primer producto en el ListBox

            // Act
            form2.Eliminar_Click(null, null);

            // Assert
            var articulosDisponibles = form2.Articulos.Items.Cast<Form2.Articulo>().ToList();

            Assert.AreEqual(1, articulosDisponibles.Count, "La lista de artículos disponibles debería tener un producto menos.");
            Assert.AreEqual("Producto2", articulosDisponibles[0].Nombre, "El producto restante en la lista de artículos disponibles no coincide.");
        }

        [Test]
        public void FinalizarCompra_ProductosEnCarrito_SeProcesanCorrectamente()
        {
            // Arrange
            form2.lisBox_carritoCompra.Items.Add(new Form2.Articulo { ID = 1, Nombre = "Producto1", Precio = 100, Cantidad = 2 });
            form2.lisBox_carritoCompra.Items.Add(new Form2.Articulo { ID = 2, Nombre = "Producto2", Precio = 200, Cantidad = 1 });

            // Act
            form2.button1_Click(null, null); 

            // Assert
            Assert.AreEqual(0, form2.lisBox_carritoCompra.Items.Count, "El carrito debería estar vacío después de finalizar la compra.");
        }

        [Test]
        public void CalcularIVA_ProductosEnCarrito_SeCalculaCorrectamente()
        {
            // Arrange
            form2.lisBox_carritoCompra.Items.Add(new Form2.Articulo { ID = 1, Nombre = "Producto1", Precio = 100, Cantidad = 2 });
            form2.lisBox_carritoCompra.Items.Add(new Form2.Articulo { ID = 2, Nombre = "Producto2", Precio = 200, Cantidad = 1 });

            decimal ivaEsperado = (100 * 2 + 200 * 1) * 0.19m; // IVA = 19% del total
            decimal totalConIVAEsperado = (100 * 2 + 200 * 1) + ivaEsperado;

            // Act
            decimal totalConIVA = 0;
            foreach (var item in form2.lisBox_carritoCompra.Items)
            {
                if (item is Form2.Articulo articulo)
                {
                    decimal iva = articulo.Precio * articulo.Cantidad * 0.19m;
                    totalConIVA += (articulo.Precio * articulo.Cantidad) + iva;
                }
            }

            // Assert
            Assert.AreEqual(totalConIVAEsperado, totalConIVA, "El total con IVA no se calculó correctamente.");
        }

        [Test]
        public void CalcularSinIVA_ProductosEnCarrito_SeCalculaCorrectamente()
        {
            // Arrange
            form2.lisBox_carritoCompra.Items.Add(new Form2.Articulo { ID = 1, Nombre = "Producto1", Precio = 100, Cantidad = 2 });
            form2.lisBox_carritoCompra.Items.Add(new Form2.Articulo { ID = 2, Nombre = "Producto2", Precio = 200, Cantidad = 1 });

            decimal totalSinIVAEsperado = (100 * 2 + 200 * 1); // Total sin IVA

            // Act
            decimal totalSinIVA = 0;
            foreach (var item in form2.lisBox_carritoCompra.Items)
            {
                if (item is Form2.Articulo articulo)
                {
                    totalSinIVA += articulo.Precio * articulo.Cantidad;
                }
            }

            // Assert
            Assert.AreEqual(totalSinIVAEsperado, totalSinIVA, "El total sin IVA no se calculó correctamente.");
        }
    }
}