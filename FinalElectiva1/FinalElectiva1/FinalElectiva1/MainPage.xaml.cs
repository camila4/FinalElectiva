using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinalElectiva1
{
	public partial class MainPage : ContentPage
    {
		public MainPage()
		{
			InitializeComponent(); 

        }
           async private void Crear(object sender, EventArgs e)
             {
            await Navigation.PushAsync(new CrearCuenta());
           }
          async private void Entrar(object sender, EventArgs e)
              {
            await Navigation.PushAsync(new Ingresar());
          }
    }
}
