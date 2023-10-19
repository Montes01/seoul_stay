using Seoul_Stay.Sections.PrincipalSections.Listing;
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

namespace Seoul_Stay.Sections.PrincipalSections
{
    /// <summary>
    /// Lógica de interacción para Owner.xaml
    /// </summary>
    public partial class Owner : UserControl
    {
        private readonly string ID;
        public Owner(string id)
        {
            ID = id;
            InitializeComponent();
        }

        private void AddListing_Click(object sender, RoutedEventArgs e)
        {
            new ListArticle(ID).ShowDialog();
        }
    }
}
