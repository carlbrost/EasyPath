using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EasyPath
{
	public partial class MainPage : ContentPage
	{

        public Identity currentCharacter;

		public MainPage()
		{
            currentCharacter = new Identity();
			InitializeComponent();
		}
        async void CreationClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Create1());
        }
        async void Creation2Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Create2(currentCharacter));
        }

        async void Creation3Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Create3());
        }

        async void Display_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DisplayPage(currentCharacter));

        }
    }
}
