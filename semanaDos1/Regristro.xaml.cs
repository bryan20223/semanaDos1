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
    public partial class Regristro : ContentPage
    {
        private int v;

        public Regristro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "el usuario conectado es " + usuario;
        }

        public Regristro(string usuario, int v) : this(usuario)
        {
            this.v = v;
        }

        private void btnInfo_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            double montoInicial = Convert.ToDouble(txtmontoInicial.Text);
        
            double cuota =((3000-montoInicial)/5)+(150);



            if (montoInicial<3000 & montoInicial>0)
            {
            
                Resultado.Text = cuota.ToString();
                DisplayAlert("Mensaje de alerta", "Ingreso Correcto " + cuota + "\n " + montoInicial + "\n Aprobado: " + (cuota*5), "Cerrar");
            }
           else
            {
                DisplayAlert("Mensaje de alerta", "Error:" + nombre + "" + apellido + "la Cuota es incorrecta "+cuota, "Cerrar");

            }
            
           
        }

        
        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Resumen(txtcuota.Text, txtmontoInicial.Text, 30));

            


        }





    }
    
}