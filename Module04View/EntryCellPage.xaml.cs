using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryCellPage : ContentPage
    {
        public EntryCellPage()
        {
            InitializeComponent();
        }
        void OnSubmitEntry(object sender, EventArgs e)
        {
            string entry1 = question1.Text;
            string entry2 = question2.Text;
            string entry3 = question3.Text;
            string entry4 = question4.Text;
            string entry5 = question5.Text;
            string entry6 = question6.Text;
            string entry7 = question7.Text;
            string entry8 = question8.Text;

            DisplayAlert("Entered values",
                $"Answer 1: {entry1}\n" +
                $"Answer 2: {entry2}\n" +
                $"Answer 3: {entry3}\n" +
                $"Answer 4: {entry1}\n" +
                $"Answer 5: {entry2}\n" +
                $"Answer 6: {entry3}\n" +
                $"Answer 7: {entry2}\n" +
                $"Answer 8: {entry3}\n" +
                $"Are you sure you want to submit?", "OK", "Cancel");
        }
    }
}