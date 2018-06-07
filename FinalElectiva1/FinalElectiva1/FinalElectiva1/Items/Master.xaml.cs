using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalElectiva1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : ContentPage
	{
		public Master ()
		{
			InitializeComponent ();
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