using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyPath
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Create3 : ContentPage
	{
        private int maxPoints = 25;
        private int allocPoints = 0;
		public Create3 ()
		{
			InitializeComponent ();



		}


    }
}