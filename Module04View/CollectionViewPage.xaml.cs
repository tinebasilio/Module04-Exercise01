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
    public partial class CollectionViewPage : ContentPage
    {
        public IList<DisneyMoviesCollection> DisneyMovies { get; private set; }

        public CollectionViewPage()
        {
            InitializeComponent();

            DisneyMovies = new List<DisneyMoviesCollection>();

            DisneyMovies.Add(new DisneyMoviesCollection
            {
                TitleYear = "Turning Red (2022)",
                Image = "https://static.wikia.nocookie.net/disney/images/b/be/Turning_Red_Poster.jpg/revision/latest?cb=20220322161613"
            });

            DisneyMovies.Add(new DisneyMoviesCollection
            {
                TitleYear = "Encanto (2021)",
                Image = "https://static.wikia.nocookie.net/disney/images/b/bc/Encanto_poster_2.JPG/revision/latest/scale-to-width-down/515?cb=20211104205032"
            });

            DisneyMovies.Add(new DisneyMoviesCollection
            {
                TitleYear = "Soul (2020)",
                Image = "https://static.wikia.nocookie.net/disney/images/0/0d/Soul_official_poster.jpg/revision/latest/scale-to-width-down/516?cb=20201026052209"
            });

            DisneyMovies.Add(new DisneyMoviesCollection
            {
                TitleYear = "Mulan (2020)",
                Image = "https://static.wikia.nocookie.net/disney/images/6/6f/Mulan_%282020%2C_Disney_Premier_Access_Poster%29.jpeg/revision/latest/scale-to-width-down/516?cb=20200812161046"
            });

            DisneyMovies.Add(new DisneyMoviesCollection
            {
                TitleYear = "Coco (2017)",
                Image = "https://static.wikia.nocookie.net/disney/images/1/14/Coco_poster.png/revision/latest/scale-to-width-down/516?cb=20170912170727"
            });

            DisneyMovies.Add(new DisneyMoviesCollection
            {
                TitleYear = "Zootopia (2016)",
                Image = "https://static.wikia.nocookie.net/disney/images/2/2f/Zootopia_Poster.jpg/revision/latest/scale-to-width-down/515?cb=20160615162624"
            });

            DisneyMovies.Add(new DisneyMoviesCollection
            {
                TitleYear = "Inside Out (2015)",
                Image = "https://static.wikia.nocookie.net/disney/images/f/fb/Inside-Out-60.png/revision/latest/scale-to-width-down/516?cb=20150304211113"
            });

            DisneyMovies.Add(new DisneyMoviesCollection
            {
                TitleYear = "Tangled (2010)",
                Image = "https://static.wikia.nocookie.net/disney/images/2/2f/Tangled_theatrical_poster.jpg/revision/latest?cb=20130828020844"
            });

            BindingContext = this;

        }
    }
}