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
        public Regristro()
        {
            InitializeComponent();
        }

        private void btnInfo_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            double nota1 = Convert.ToDouble(txtNotaUno.Text);
            double nota2 = Convert.ToDouble(txtNotaDos.Text);
            double nota =(nota1+nota2)/2;

               Resultado.Text=nota.ToString();


            if (nota>=7)
            {
                DisplayAlert("Mensaje de alerta", "Felicidades" + nombre + "\n " + apellido + "\n Aprobado: "+nota, "Cerrar");
            }
            else
            {
                DisplayAlert("Mensaje de alerta", "Estimado:" + nombre + "" + apellido + "Reprobado con "+nota, "Cerrar");

            }
            
           
        }
    }
}