using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semanaDos1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class loguin : ContentPage
    {
        public loguin()
        {
            InitializeComponent();
        }

        private void btnInicio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Regristro());

            string usuario = "Bryan";
            string contrasena = "123456";
            string tusuario = txtUser.Text;
            string tcontrasena = txtContraseña.Text;

            if (usuario == tusuario & contrasena == tcontrasena) 
            {
                DisplayAlert("Alerta", "Usuario correcto", "Cerrar");
                //Navigation.PushAsync(new Regristro());
                
            }
            else
            {
                DisplayAlert("Alerta", "Usuario no existe", "Cerrar");

            }


        }
    }
}