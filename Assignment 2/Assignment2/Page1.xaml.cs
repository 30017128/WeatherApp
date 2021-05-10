using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page1 : Page
    {
        private string[] selectionItems = new string[] { "Whangarei", "Auckland", "Tauranga", "Wellington", "Eve",
        "Glen", "Quentin", "David", "Sabrina", "Rachel", "Basil", "Tina", "Kathy", "Ivan", "Liam",
        "Quincey", "Ralf", "Louis", "Mick", "Gillian", "Nathan", "Ferdinand", "Iggy", "Olivia", "Paul",
        "Pat", "Mikayla", "Nicole", "James", "Penelope", "Amy", "Frank", "Janette", "Fiona", "Kelly",
        "Odin", "Ewan", "Fred", "Frida", "Amber", "Hannah", "Sacha", "Ulf", "Yasmin",  "Helga", "Zac",
        "Candy", "Xavier", "Dan", "Nigel", "Yana", "Tag", "Zoe", "Wendy", "Tanya", "Xeon", "Becca",
        "Vicky", "Tanner", "William", "Todd", "Carmen" };

        public Page1()
        {
            this.InitializeComponent();
        }
        private void MyAutoSuggestBox_TextChanged(AutoSuggestBox sender,
                                          AutoSuggestBoxTextChangedEventArgs args)
        {
            var autoSuggestBox = (AutoSuggestBox)sender;
            var filtered = selectionItems.Where(p => p.StartsWith(autoSuggestBox.Text)).ToArray();
            autoSuggestBox.ItemsSource = filtered;
            AutoSuggestBoxhResult.Text = "You selected " + sender.Text.ToString();
        }



    }
}
