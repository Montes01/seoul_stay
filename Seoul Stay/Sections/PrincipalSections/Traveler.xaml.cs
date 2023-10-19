using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using static Seoul_Stay.DAL.Connection;
namespace Seoul_Stay.Sections.PrincipalSections
{
    /// <summary>
    /// Lógica de interacción para Traveler.xaml
    /// </summary>
    public partial class Traveler : UserControl
    {

        private readonly static SqlConnection _conn = GetConnection();
        public Traveler()
        {
            InitializeComponent();
            Services.ItemsSource =  GetServicesByName("");
        }
        

        private void q_TextChanged(object sender, TextChangedEventArgs e)
        {
            Services.ItemsSource = GetServicesByName((sender as TextBox).Text); ;
        }

        private dynamic GetServicesByName(string name)
        {
            string q = $"EXEC usp_SearchAdvise '{name}'";
            DataTable dt = new DataTable();
            try
            {
                new SqlDataAdapter(q, _conn).Fill(dt);
                return dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "There was an error getting the items";
            }

        }
    }
}
