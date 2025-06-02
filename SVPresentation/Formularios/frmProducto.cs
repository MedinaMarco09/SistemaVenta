using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVPresentation.Utilidades.Objetos;
using SVPresentation.Utilidades;
using SVPresentation.ViewModels;
using SVRepository.Interfaces;
using SVServices.Implementation;
using SVServices.Interfaces;
using SVRepository.Entities;

namespace SVPresentation.Formularios
{
    public partial class frmProducto : Form
    {
        private readonly IProductoService _productoService;
        private readonly ICategoriaService _categoriaService;
        public frmProducto(ICategoriaService categoriaService, IProductoService productoService)
        {
            InitializeComponent();
            _categoriaService = categoriaService;
            _productoService = productoService;
        }

        public void MostrarTab(string tabName)
        {
            var TabsMenu = new TabPage[] { tabLista, tabNuevo, tabEditar };
            foreach (var tab in TabsMenu)
            {
                if (tab.Name != tabName)
                {
                    tab.Parent = null;
                }
                else
                {
                    tab.Parent = tabControlMain;
                }
            }
        }
        private async Task MostrarProductos(string buscar = "")
        {
            var listaProductos = await _productoService.Lista(buscar);

            var listaVM = listaProductos.Select(item => new ProductoVM
            {
                IdProducto = item.IdProducto,
                Codigo = item.Codigo,
                Descripcion = item.Descripcion,
                IdCategoria = item.RefCategoria.IdCategoria,
                Categoria = item.RefCategoria.Nombre,
                PrecioCompra = item.PrecioCompra.ToString("0.00"),
                PrecioVenta = item.PrecioVenta.ToString("0.00"),//Habia dos errores en donde los primeros 2 productos ponian precio compra en venta****Se corrigio*****
                Cantidad = item.Cantidad,
                Activo = item.Activo,
                Habilitado = item.Activo == 1 ? "Si" : "No"
            }).ToList();

            dgvProductos.DataSource = listaVM;

            dgvProductos.Columns["IdProducto"].Visible = false;
            dgvProductos.Columns["IdCategoria"].Visible = false;
            dgvProductos.Columns["Activo"].Visible = false;
            dgvProductos.Columns["Descripcion"].Width = 200;
        }

        private async void frmProducto_Load(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
            dgvProductos.ImplementarConfiguracion("Editar");   //Clases
            txbPrecioCompraNuevo.ValidarNumero();//Logica/restrinccion de objeto para validar los numeros nada más
            txbPrecioCompraEditar.ValidarNumero();//disminuye las posibilidades de error, no puede evitar las letras al copiar y pegar
            txbPrecioVentaNuevo.ValidarNumero();
            txbPrecioVentaEditar.ValidarNumero();
            await MostrarProductos();

            OpcionCombo[] itemsHabilitado = new OpcionCombo[] {
                new OpcionCombo{Texto="Si", Valor =1},
                new OpcionCombo{Texto="No", Valor =0},
            };

            var listaCategoria = await _categoriaService.Lista();
            var items = listaCategoria
                .Where(item => item.Activo == 1)
                .Select(item => new OpcionCombo
                {
                    Texto = item.Nombre,
                    Valor = item.IdCategoria
                }).ToArray();  //A cada item de la lista


            cbbCategoriaEditar.InsertarItems(items);
            cbbCategoriaNuevo.InsertarItems(items);
            cbbHabilitado.InsertarItems(itemsHabilitado);
        }

        private async void btnBuscarLista_Click(object sender, EventArgs e)
        {
            await MostrarProductos(txtBuscarLista.Text);
        }

        private void btnNuevoLista_Click(object sender, EventArgs e)
        {
            MostrarTab(tabNuevo.Name);
            cbbCategoriaNuevo.SelectedIndex = 0;
            txbCodigoNuevo.Text = "";
            txbDescripcionNuevo.Text = "";
            txbPrecioCompraNuevo.Text = "";
            txbPrecioVentaNuevo.Text = "";
            txbCantidadNuevo.Value = 0;
            cbbCategoriaNuevo.Select();
        }

        private void btnVolverNuevo_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (txbCodigoNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe Ingresar el Codigo");
                return;
            }
            if (txbDescripcionNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe Ingresar la Descripcion");
                return;
            }
            if (txbPrecioCompraNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe Ingresar el Precio de Compra");
                return;
            }
            if (txbPrecioVentaNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe Ingresar el Precio de Venta");
                return;
            }
            if (txbCantidadNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe Ingresar la Cantidad");
                return;
            }

            decimal preciocompra = 0;
            decimal precioventa = 0;

            if (!decimal.TryParse(txbPrecioCompraNuevo.Text, out preciocompra))//tryParse convierte el string en decimal
            {
                MessageBox.Show("Precio compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txbPrecioCompraNuevo.Select();
                return;
            }
            if (!decimal.TryParse(txbPrecioVentaNuevo.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txbPrecioVentaNuevo.Select();
                return;
            }
            var objeto = new Producto
            {
                RefCategoria = new Categoria { IdCategoria = ((OpcionCombo)cbbCategoriaNuevo.SelectedItem!).Valor },
                Codigo = txbCodigoNuevo.Text.Trim(),
                Descripcion = txbDescripcionNuevo.Text.Trim(),
                PrecioCompra = preciocompra,
                PrecioVenta = precioventa,
                Cantidad = Convert.ToInt32(txbCantidadNuevo.Value)
            };

            var respuesta = await _productoService.Crear(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarProductos();
                MostrarTab(tabLista.Name);
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "ColumnaAccion") //CustomsDataGridView
            {

                var productoSeleccionado = (ProductoVM)dgvProductos.CurrentRow.DataBoundItem;


                cbbCategoriaEditar.EstablecerValor(productoSeleccionado.IdCategoria);
                txbCodigoEditar.Text = productoSeleccionado.Codigo;
                txbDescripcionEditar.Text = productoSeleccionado.Descripcion;
                txbPrecioCompraEditar.Text = productoSeleccionado.PrecioCompra;
                txbPrecioVentaEditar.Text = productoSeleccionado.PrecioVenta;
                txbCantidadEditar.Value = productoSeleccionado.Cantidad;
                cbbHabilitado.EstablecerValor(productoSeleccionado.Activo);


                MostrarTab(tabEditar.Name);
                cbbCategoriaEditar.Select();
            }
        }

        private void btnVolverEditar_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (txbCodigoEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe Ingresar el Codigo");
                return;
            }
            if (txbDescripcionEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe Ingresar la Descripcion");
                return;
            }
            if (txbPrecioCompraEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe Ingresar el Precio de Compra");
                return;
            }
            if (txbPrecioVentaEditar.Text.Trim() == "")
            {
                MessageBox.Show("Debe Ingresar el Precio de Venta");
                return;
            }
            if (txbCantidadNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe Ingresar la Cantidad");
                return;
            }

            decimal preciocompra = 0;
            decimal precioventa = 0;

            if (!decimal.TryParse(txbPrecioCompraEditar.Text, out preciocompra))//tryParse convierte el string en decimal
            {
                MessageBox.Show("Precio compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txbPrecioCompraEditar.Select();
                return;
            }
            if (!decimal.TryParse(txbPrecioVentaEditar.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txbPrecioVentaEditar.Select();
                return;
            }
            var productoSeleccionado = (ProductoVM)dgvProductos.CurrentRow.DataBoundItem;
            var objeto = new Producto
            {   
                IdProducto = productoSeleccionado.IdProducto,
                RefCategoria = new Categoria { IdCategoria = ((OpcionCombo)cbbCategoriaEditar.SelectedItem!).Valor },
                Codigo = txbCodigoEditar.Text.Trim(),
                Descripcion = txbDescripcionEditar.Text.Trim(),
                PrecioCompra = preciocompra,
                PrecioVenta = precioventa,
                Cantidad = Convert.ToInt32(txbCantidadEditar.Value),
                Activo = ((OpcionCombo)cbbHabilitado.SelectedItem!).Valor
            };

            var respuesta = await _productoService.Editar(objeto);// error ******* Se cambio a Editar (porque creaba en vez de editar)

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarProductos();
                MostrarTab(tabLista.Name);
            }
        }
    }
}
