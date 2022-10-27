using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FranklinOrdonez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "nombreEstudiante2022";
            string contrasena = "uisrael2022";
            string tUsuario = txtUsuario.Text;
            string tContrasena = txtContrasena.Text;
            

            
            if (usuario == tUsuario & contrasena == tContrasena)


            {
                DisplayAlert("Alerta", "USUARIO CORRECTO", "Cerrar");
                await Application.Current.MainPage.Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                DisplayAlert("Alerta", "USUARIO NO EXISTE", "Cerrar");

            }
        }
    }
}