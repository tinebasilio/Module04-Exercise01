using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module04View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnTextCellClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextCellPage());
        }
        private async void OnImageCellClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImageCellPage());
        }
        private async void OnSwitchCellClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SwitchCellPage());
        }
        private async void OnEntryCellClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EntryCellPage());
        }
        private async void OnCollectionViewClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CollectionViewPage());
        }
        private async void OnAboutClicked(object sender, EventArgs e)
        {
            await DisplayAlert("About",
            "This app allows you to explore various aspects of the Toy Story Movie.\n\n" +
            "'Characters' (TextCell) - A list of characters from the Toy Story movies.\n\n" +
            "Character Profile' (ImageCell) - A profile list of Toy Story characters.\n\n" +
            "'Scenes' (SwitchCell) - A list of memorable scenes from Toy Story.\n\n" +
            "'Q&A' (EntryCell) - A list of Toy Story-themed questions and answers.\n\n" +
            "'Explore Movies' (CollectionView) - A list of other Disney movies.\n\n" +
            "Student Information:\n" +
            "Name: Kristine Angeli B. Basilio\n" +
            "Course: PDC03\n" +
            "Activity: Module 04 - Exercise 01",
            "OK");
        }
    }
}
