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
    public partial class TextCellPage : ContentPage
    {
        ObservableCollection<ToyStoryCharacter> toyStoryCharacterList = new ObservableCollection<ToyStoryCharacter>();
        public ObservableCollection<ToyStoryCharacter> CharacterListItem { get { return toyStoryCharacterList; } }

        public TextCellPage()
        {
            InitializeComponent();

            itemListView.ItemsSource = toyStoryCharacterList;

            CharacterListItem.Add(new ToyStoryCharacter
            {
                CharacterName = "Woody",
                CharacterInfo = "Woody is the cowboy sheriff and the leader of the toys."
            });

            CharacterListItem.Add(new ToyStoryCharacter
            {
                CharacterName = "Buzz Lightyear",
                CharacterInfo = "Buzz Lightyear is a space ranger action figure who believes he's a real space ranger."
            });

            CharacterListItem.Add(new ToyStoryCharacter
            {
                CharacterName = "Jessie",
                CharacterInfo = "Jessie is a yodeling cowgirl and a member of Woody's Roundup gang."
            });

            CharacterListItem.Add(new ToyStoryCharacter
            {
                CharacterName = "Rex",
                CharacterInfo = "Rex is a timid Tyrannosaurus rex who is afraid of everything."
            });

            CharacterListItem.Add(new ToyStoryCharacter
            {
                CharacterName = "Hamm",
                CharacterInfo = "Hamm is a wise-cracking piggy bank with a fondness for counting money."
            });

            CharacterListItem.Add(new ToyStoryCharacter
            {
                CharacterName = "Bo Peep",
                CharacterInfo = "Bo Peep is a shepherdess and Woody's love interest."
            });

            CharacterListItem.Add(new ToyStoryCharacter
            {
                CharacterName = "Mr.Potato Head",
                CharacterInfo = "Mr.Potato Head is a sarcastic and grumpy toy with detachable body parts."
            });
        }
    }
}