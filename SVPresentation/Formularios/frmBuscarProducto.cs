using SVPresentation.Utilidades;
using SVPresentation.ViewModels;
using SVServices.Interfaces;


namespace SVPresentation.Formularios
{
    public partial class frmBuscarProducto : Form
    {
        private readonly IProductoService _productoService;
        public ProductoVM _productoSeleccionado { get; set; } = null!;
        public frmBuscarProducto(IProductoService productoService)
        {
            InitializeComponent();
            _productoService = productoService;
        }

        private async Task MostrarProductos(string buscar = "")
        {
            var listaProductos = await _productoService.Lista(buscar);

            var listaVM = listaProductos
            .Where(item => item.Activo == 1 && item.Cantidad > 0)
            .Select(item => new ProductoVM
            {
                IdProducto = item.IdProducto,
                Codigo = item.Codigo,
                Descripcion = item.Descripcion,
                IdCategoria = item.RefCategoria.IdCategoria,
                Categoria = item.RefCategoria.Nombre,
                PrecioCompra = item.PrecioCompra.ToString("0.00"),
                PrecioVenta = item.PrecioVenta.ToString("0.00"),
                Cantidad = item.Cantidad,
                //Activo = item.Activo,
                //Habilitado = item.Activo == 1 ? "Si" : "No"
            }).ToList();

            dgvProductos.DataSource = listaVM;

            dgvProductos.Columns["IdProducto"].Visible = false;
            dgvProductos.Columns["IdCategoria"].Visible = false;
            dgvProductos.Columns["Activo"].Visible = false;
            dgvProductos.Columns["Habilitado"].Visible = false;
            dgvProductos.Columns["Descripcion"].Width = 200;
        }

        private async void frmBuscarProducto_Load(object sender, EventArgs e)
        {
            dgvProductos.ImplementarConfiguracion();
            await MostrarProductos();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarProductos(txbBuscar.Text.Trim());
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _productoSeleccionado = (ProductoVM)dgvProductos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
