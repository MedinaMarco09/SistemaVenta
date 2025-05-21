using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVPresentation.ViewModels;
using SVRepository.Interfaces;
using SVServices.Interfaces;
using SVPresentation.Utilidades;
using SVPresentation.Utilidades.Objetos;
using SVServices.Implementation;
using SVRepository.Entities;


namespace SVPresentation.Formularios
{
    public partial class frmCategoria : Form
    {
        private readonly IMedidaService _medidaService;
        private readonly ICategoriaService _categoriaService;


        public frmCategoria(ICategoriaService categoriaService, IMedidaService medidaService)
        {
            InitializeComponent();
            _categoriaService = categoriaService;
            _medidaService = medidaService;
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

        private async Task MostrarCategorias(string buscar = "")
        {
            var listacategorias = await _categoriaService.Lista(buscar);

            var listaVM = listacategorias.Select(item => new CategoriaVM
            {
                IdCategoria = item.IdCategoria,
                Nombre = item.Nombre,
                IdMedida = item.RefMedida.IdMedida,
                Medida = item.RefMedida.Nombre,
                Activo = item.Activo,
                Habilitado = item.Activo == 1 ? "Si" : "No"
            }).ToList();

            dgvCategorias.DataSource = listaVM;

            dgvCategorias.Columns["IdCategoria"].Visible = false;
            dgvCategorias.Columns["IdMedida"].Visible = false;
            dgvCategorias.Columns["Activo"].Visible = false;
        }
        private async void frmCategoria_Load(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
            dgvCategorias.ImplementarConfiguracion("Editar");   //Clase 
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //propiedad
            await MostrarCategorias();

            OpcionCombo[] itemsHabilitado = new OpcionCombo[] {
                new OpcionCombo{Texto="Si", Valor =1},
                new OpcionCombo{Texto="No", Valor =0},
            };

            var listaMedida = await _medidaService.Lista();
            var items = listaMedida.Select(item => new OpcionCombo
            {
                Texto = item.Nombre,
                Valor = item.IdMedida
            }).ToArray();  //A cada item de la lista


            cbbMedidaEditar.InsertarItems(items);
            cbbMedidaNuevo.InsertarItems(items);
            cbbHabilitado.InsertarItems(itemsHabilitado);
        }

        private async void btnBuscarLista_Click(object sender, EventArgs e) //Llamado al boton buscar categoria
        {
            await MostrarCategorias(txtBuscarLista.Text);
        }

        private void btnNuevoLista_Click(object sender, EventArgs e)
        {
            txbNombreNuevo.Text = "";
            cbbMedidaNuevo.SelectedIndex = 0;
            txbNombreNuevo.Select();
            tabControlMain.SelectedTab = tabControlMain.TabPages[tabNuevo.Name];
            MostrarTab(tabNuevo.Name);
        }

        private void btnVolverNuevo_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }



        private async void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (txbNombreNuevo.Text.Trim() == "")//Trim elimina los espacios vacios al final e inicio del texto
            {
                MessageBox.Show("Debe ingresar el nombre");
                return;
            }

            var item = (OpcionCombo)cbbMedidaNuevo.SelectedItem!; //Todo se convierte en una opcion combo por ser de ese mismo tipo
            var objeto = new Categoria
            {
                Nombre = txbNombreNuevo.Text.Trim(),
                RefMedida = new Medida { IdMedida = item.Valor }
            };

            var respuesta = await _categoriaService.Crear(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);

            }
            else
            {
                await MostrarCategorias();
                MostrarTab(tabLista.Name);
            }
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.Columns[e.ColumnIndex].Name == "ColumnaAccion") //CustomsDataGridView
            {

                var categoriaSeleccionada = (CategoriaVM)dgvCategorias.CurrentRow.DataBoundItem;

                txbNombreEditar.Text = categoriaSeleccionada.Nombre.ToString();
                cbbMedidaEditar.EstablecerValor(categoriaSeleccionada.IdMedida);
                cbbHabilitado.EstablecerValor(categoriaSeleccionada.Activo);
                MostrarTab(tabEditar.Name);
                txbNombreEditar.Select();
            }
        }
        private void btnVolverEditar_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            if (txbNombreEditar.Text.Trim() == "")//Trim elimina los espacios vacios al final e inicio del texto
            {
                MessageBox.Show("Debe ingresar el nombre");
                return;
            }

            var categoriaSeleccionada = (CategoriaVM)dgvCategorias.CurrentRow.DataBoundItem;
            var objeto = new Categoria
            {
                IdCategoria = categoriaSeleccionada.IdCategoria,
                Nombre = txbNombreEditar.Text.Trim(),
                RefMedida = new Medida { IdMedida = ((OpcionCombo)cbbMedidaEditar.SelectedItem!).Valor },
                Activo=((OpcionCombo)cbbHabilitado.SelectedItem!).Valor
            };

            var respuesta = await _categoriaService.Editar(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);

            }
            else
            {
                await MostrarCategorias();
                MostrarTab(tabLista.Name);
            }
        }
    }
}
