

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using SVPresentation.Utilidades;
using SVServices.Interfaces;

namespace SVPresentation.Formularios
{
    public partial class frmLogin : Form
    {
        private readonly IUsuarioService _usuarioService;
        private readonly ICorreoService _correoService;
        private readonly IServiceProvider _serviceProvider;

        public frmLogin(IUsuarioService usuarioService, ICorreoService correoService,
            IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            _correoService = correoService;
            _serviceProvider = serviceProvider;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txbUsuario.Select();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            var encontrado = await _usuarioService.Login(txbUsuario.Text, Util.ConvertToSha256(txbContrasena.Text));

            if (encontrado.IdUsuario == 0)
            {
                MessageBox.Show("No se encontró el usuario.");
                return;
            }

            if (encontrado.Activo == 0)
            {
                MessageBox.Show("El usuario está deshabilitado.");
                return;
            }

            if (encontrado.ResetearClave == 1)
            {
                var _formActualizarClave = _serviceProvider.GetRequiredService<frmActualizarClave>();
                _formActualizarClave._idUsuario = encontrado.IdUsuario;
               var resultado =  _formActualizarClave.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    txbContrasena.Text = "";
                    txbContrasena.Select();
                    MessageBox.Show("La contraseña fue actualizada, vuelva a ingresar");
                }
               
            }
            else
            {
                UsuarioSesion.IdUsuario = encontrado.IdUsuario;
                UsuarioSesion.NombreUsuario = encontrado.NombreUsuario;
                UsuarioSesion.NombreCompleto = encontrado.NombreCompleto;
                UsuarioSesion.IdRol = encontrado.RefRol.IdRol;
                UsuarioSesion.Rol = encontrado.RefRol.Nombre;

            
                var _formLayout = _serviceProvider.GetRequiredService<Layout>();
                this.Hide();
                txbUsuario.Text = "";
                txbContrasena.Text = "";

                _formLayout.Show();
                _formLayout.FormClosed += (sender, e) =>
                {
                    this.Show();
                    txbUsuario.Select();
                };
            }



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void linkOlvideContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           var correo = Interaction.InputBox("Ingrese su correo de usuario", "Olvidé mi contraseña", "");

           var idusuario =  await _usuarioService.VerificarCorreo(correo);

            if(idusuario == 0)
            {
                MessageBox.Show("No se tiene ningún usuario registrado con el correo ingresado.");
                return;
            }

            var claveGenerada = Util.GenerateCode();
            var claveSha256 = Util.ConvertToSha256(claveGenerada);

            await _usuarioService.ActualizarClave(idusuario, claveSha256, 1);

            var mensaje = $"Contraseña actualizada <br> Su contraseña temporal es: {claveGenerada}";
            await _correoService.Enviar(correo, "Contraseña Actualizada", mensaje);



            MessageBox.Show("Su contraseña fue actualizada, revise su correo.");
        }
    }
}
