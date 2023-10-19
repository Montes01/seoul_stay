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
    /// Lógica de interacción para Details.xaml
    /// </summary>
    public partial class Details : UserControl
    {
        private readonly static SqlConnection _conn = GetConnection();
        public Details()
        {
            InitializeComponent();
            InitComponents();
        }

        private void InitComponents()
        {
            TypeCombo.ItemsSource = GetTypes();
            TypeCombo.DisplayMemberPath = "Nombre";
            TypeCombo.SelectedValuePath = "ID";


        }

        private dynamic GetTypes()
        {
            string q = "EXEC usp_ListArticleTypes";
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

        private void TypeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(TypeCombo.SelectedValue.ToString());
        }

        private void Beds_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
