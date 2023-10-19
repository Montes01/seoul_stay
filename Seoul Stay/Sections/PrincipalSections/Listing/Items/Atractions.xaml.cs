using Seoul_Stay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Seoul_Stay.Sections.PrincipalSections.Listing.Items
{
    /// <summary>
    /// Lógica de interacción para Atractions.xaml
    /// </summary>
    public partial class Atractions : UserControl
    {

        public readonly List<Attraction> attractions = new List<Attraction>() { new Attraction() { } };
        public Atractions()
        {
            InitializeComponent();
            ShowAttractions();
        }


        private void ShowAttractions()
        {

            AttracionList.ItemsSource = null;
            AttracionList.ItemsSource = attractions;
        }

        private void AddAttraction_Click(object sender, RoutedEventArgs e)
        {
            attractions.Add(new Attraction() { AttractionName = "newAttraction"});
            ShowAttractions();
        }


        private void Attraction_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Area_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Distance_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OnFoot_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OnCar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }



}
