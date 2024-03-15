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
    public partial class SwitchCellPage : ContentPage
    {
        ObservableCollection<ToyStoryScene> SceneList = new ObservableCollection<ToyStoryScene>();
        public ObservableCollection<ToyStoryScene> SceneListItem { get { return SceneList; } }

        public SwitchCellPage()
        {
            InitializeComponent();

            itemListView.ItemsSource = SceneList;

            SceneListItem.Add(new ToyStoryScene
            {
                Scene= "Andy's Room"
            });

            SceneListItem.Add(new ToyStoryScene
            {
                Scene = "Pizza Planet"
            });

            SceneListItem.Add(new ToyStoryScene
            {
                Scene = "The Claw Machine"
            });

            SceneListItem.Add(new ToyStoryScene
            {
                Scene = "Bonnie's Toy Room"
            });

            SceneListItem.Add(new ToyStoryScene
            {
                Scene = "Sid's House"
            });

            SceneListItem.Add(new ToyStoryScene
            {
                Scene = "Al's Toy Barn"
            });

            SceneListItem.Add(new ToyStoryScene
            {
                Scene = "Sunnyside Daycare"
            });
        }

        public void displayMessage (object sender, ToggledEventArgs e)
        {
            SwitchCell switchCell = (SwitchCell)sender;
            bool isToggledOn = e.Value;

            ToyStoryScene scene = (ToyStoryScene)switchCell.BindingContext;
            string sceneName = scene.Scene;

            if (isToggledOn)
            {
                DisplayAlert("Message", $"Yay! You remember the scene: {sceneName}. Keep it up!", "OK");
            }
            else
            {
                DisplayAlert("Message", $"Oops! You forgot the scene: {sceneName}. Try to remember it again.", "OK");
            }
        }
    }
}