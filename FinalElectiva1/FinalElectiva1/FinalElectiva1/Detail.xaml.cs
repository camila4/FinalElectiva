﻿using FinalElectiva1.Tabs;
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
	public partial class Detail : TabbedPage
    {
		public Detail ()
		{
			InitializeComponent ();

            Children.Add(new Page1());
            Children.Add(new Page2());




        }
	}
}