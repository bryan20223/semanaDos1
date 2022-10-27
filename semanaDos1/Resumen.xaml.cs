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
    public partial class Resumen : ContentPage
    {
  
        private int v;
        private Entry txtcuota;
        private Entry txtmontoInicial;
        private string montoInicial;

        public Resumen(string montoInicial)
        {
            this.montoInicial = montoInicial;
        }

        

        public Resumen(string cuota, string montoInicial)
        {
            InitializeComponent();

            
          
          
            txtNombre.Text = "Inicia " + montoInicial;
            lblUsuario.Text = "Cuota Mensual a Pagar " + cuota;

        }
        public Resumen(string montoInicial, int v) : this(montoInicial)
        {
            this.v = v;

        }

        public Resumen(string cuota, string montoInicial, int v) : this(cuota, montoInicial)
        {
            this.v = v;
            lblUsuario.Text = "Cuota Mensual a Pagar " + cuota;
        }

       
    }
}