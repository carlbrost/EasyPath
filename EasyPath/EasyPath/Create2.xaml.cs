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
    public partial class Create2 : ContentPage
    {
        private Identity Character;

        public Create2(Identity character)
        {
            this.Character = character;
            InitializeComponent();
            registerEvents();
        }


        private void registerEvents()
        {
            this.selDefSkills.SelectedIndexChanged += SelDefSkills_SelectedIndexChanged;
            this.eduSkills.SelectedIndexChanged += EduSkills_SelectedIndexChanged;
            this.selSpecSkills.SelectedIndexChanged += SpecSkills_SelectedIndexChanged;
            this.selOffSkills.SelectedIndexChanged += SelOffSkills_SelectedIndexChanged;

        }

        private void EduSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.curCharacter.skills.edu = (string)eduSkills.SelectedItem;
        }

        private void SelDefSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.curCharacter.skills.def = (string)selDefSkills.SelectedItem;
        }

        private void SpecSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.curCharacter.skills.spec = (string)selSpecSkills.SelectedItem;
        }

        private void SelOffSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.curCharacter.skills.off = (string)selOffSkills.SelectedItem;
        }
    }
 }
