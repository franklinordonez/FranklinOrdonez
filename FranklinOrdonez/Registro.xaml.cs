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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            double monto = Convert.ToDouble(txtMonto1.Text);
            var Monto1 = double.Parse(txtMonto1.Text);
            var Calcular = 3000 - Monto1;
            var Calcular1 = Calcular / 5;
            var Pmensual = Calcular1 + 150;
            txtPmensual.Text = Pmensual.ToString();
            await Application.Current.MainPage.Navigation.PushAsync(new Resumen(nombre, apellido));

            {
                DisplayAlert("Elemento", "GUARDAR", "Cerrar");
                Navigation.PushAsync(new Registro());
            }

        }
    }
}