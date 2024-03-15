using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageCellPage : ContentPage
    {
        ObservableCollection<ToyStoryCharacter> CharacterProfileList = new ObservableCollection<ToyStoryCharacter>();
        public ObservableCollection<ToyStoryCharacter> ProfileListItem { get { return CharacterProfileList; } }

        public ImageCellPage()
        {
            InitializeComponent();

            itemListView.ItemsSource = CharacterProfileList;

            ProfileListItem.Add(new ToyStoryCharacter
            {
                CharacterName = "Woody (Sheriff Woody Pride)",
                Details = "<i>\"<i>Reach for the sky!</i>\"</i>\nToy cowboy",
                Image = "https://static.wikia.nocookie.net/disney/images/2/22/Profile_-_Woody.jpeg/revision/latest?cb=20200711052417"
            });

            ProfileListItem.Add(new ToyStoryCharacter
            {
                CharacterName = "Buzz Lightyear",
                Details = "<i>\"<i>To infinity...AND BEYOND!</i>\"</i>\nSpace Ranger Toy",
                Image = "https://static.wikia.nocookie.net/disney/images/7/74/Profile_-_Buzz_Lightyear.jpeg/revision/latest?cb=20190623020017"
            });

            ProfileListItem.Add(new ToyStoryCharacter
            {
                CharacterName = "Jessie (Jessie the Yodeling Cowgirl)",
                Details = "Toy cowgirl",
                Image = "https://static.wikia.nocookie.net/disney/images/1/11/Profile_-_Jessie.jpeg/revision/latest?cb=20190313152740"
            });

            ProfileListItem.Add(new ToyStoryCharacter
            {
                CharacterName = "Rex",
                Details = "Toy dinosaur",
                Image = "https://static.wikia.nocookie.net/disney/images/5/56/Profile_-_Rex.jpeg/revision/latest/scale-to-width-down/516?cb=20190313050619"
            });

            ProfileListItem.Add(new ToyStoryCharacter
            {
                CharacterName = "Hamm",
                Details = "Piggy Bank toy",
                Image = "https://static.wikia.nocookie.net/disney/images/4/4f/Profile_-_Hamm.jpeg/revision/latest/scale-to-width-down/516?cb=20190313051329"
            });

            ProfileListItem.Add(new ToyStoryCharacter
            {
                CharacterName = "Bo Peep",
                Details = "Lamp shepherdess",
                Image = "https://static.wikia.nocookie.net/disney/images/3/30/Profile_-_Bo_Peep.jpeg/revision/latest?cb=20201105221228"
            });

        }

    }
}