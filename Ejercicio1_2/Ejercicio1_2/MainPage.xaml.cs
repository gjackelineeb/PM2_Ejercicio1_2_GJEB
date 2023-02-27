using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Clicked(object sender, EventArgs e)
        {
            var emple = new Models.Empleados
            {
                nombre = txtNombre.Text,
                apellidos = txtApellidos.Text,
                edad = txtEdad.Text,
                email = txtEmail.Text,
            };

            var datos = new PageData();
            datos.BindingContext = emple;
            await Navigation.PushAsync(datos);

        }
    }
}
