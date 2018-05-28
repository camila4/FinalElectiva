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
	public partial class InicioP : MasterDetailPage 
    {
		public InicioP ()
		{
            InitializeComponent();
            this.Master = new Master();
            this.Detail = new NavigationPage(new Detail());

        }
	}
}