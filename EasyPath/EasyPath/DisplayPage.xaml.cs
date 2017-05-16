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



	public partial class DisplayPage : ContentPage
	{
        public string race = "";
        public string subrace = "";
        public string ofskill = "";
        public string defskill = "";
        public string eduskill = "";
        public string specskill = "";





        public DisplayPage (Identity character)
		{
			InitializeComponent ();
            lblRace.Text = App.curCharacter.race.Race;
		}
	}
}