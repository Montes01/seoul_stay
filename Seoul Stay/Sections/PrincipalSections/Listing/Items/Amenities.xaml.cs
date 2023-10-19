using static Seoul_Stay.DAL.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Lógica de interacción para Amenities.xaml
    /// </summary>
    public partial class Amenities : UserControl
    {
        private readonly SqlConnection _conn = GetConnection();
        private readonly List<int> _items = new List<int>();
        public Amenities()
        {
            InitializeComponent();
            InitComponents();
        }
        private void InitComponents()
        {
            AmenitiesList.ItemsSource = GetAmenities();
        }

        private dynamic GetAmenities()
        {
            string q = "EXEC usp_GetAmenities";
            DataTable dt = new DataTable();
            try
            {
                new SqlDataAdapter(q, _conn).Fill(dt);
                return dt.DefaultView;

            }
            catch (Exception)
            {
                return null;
            }

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            _items.Add((int)(sender as CheckBox).Content);
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            _items.Remove((int)(sender as CheckBox).Content);
        }


    }
}
