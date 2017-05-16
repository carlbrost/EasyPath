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
    public partial class Create1 : ContentPage
    {
        private Identity Character = new Identity();

        public Create1()
        {
            InitializeComponent();
            registerEvents();
        }

        private void registerEvents(){

            this.selRace.SelectedIndexChanged += SelRace_SelectedIndexChanged;
        }

        private void SelRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Need to make sure if this is a string value or an object with the control and it's properties
            this.Character.race.Race = (string) this.selRace.Items[this.selRace.SelectedIndex];
            this.ShowNext(this.selRace.Items[this.selRace.SelectedIndex]);
        }
        private void ShowNext(string race)
        {
            switch (race) {
                case "Undead":
                    { 
                        this.selUndead.IsVisible = true;
                        //need to add others as false below
                        break;
                    }
                case "Imp":
                    {
                        this.selImp.IsVisible = true;

                        //need to add others as false below
                        this.selUndead.IsVisible = false;
                        break;
                    }
                case "Bot":
                    {
                        this.selBot.IsVisible = true;

                        //need to add others as false below
                        this.selUndead.IsVisible = false;
                        break;
                    }
                case "Abberant":
                    {
                        this.selAbberant.IsVisible = true;

                        //need to add others as false below
                        this.selUndead.IsVisible = false;
                        break;
                    }
                case "Fae":
                    {
                        this.selFae.IsVisible = true;

                        //need to add others as false below
                        this.selUndead.IsVisible = false;
                        break;
                    }
                case "Kobold":
                    {
                        this.selKobold.IsVisible = true;

                        //need to add others as false below
                        this.selUndead.IsVisible = false;
                        break;
                    }
                //Conti
                case "Ogre":
                    {
                        this.selOgre.IsVisible = true;

                        //need to add others as false below
                        this.selUndead.IsVisible = false;
                        break;
                    }

                default: {

                        //None are selected
                        this.selUndead.IsVisible = false;
                        //need to add others as false below

                        return;
                    }
            }
                    
        }


    }
}