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
	public partial class Ingresar : ContentPage
	{
		public Ingresar ()
		{
			InitializeComponent ();
		}

        async private void crea2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearCuenta());
        }
        async private void entrar1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InicioP());
        }

    }
}