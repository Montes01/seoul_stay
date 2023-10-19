using Seoul_Stay.DAL;
using Seoul_Stay.Sections;
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

namespace Seoul_Stay
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static readonly SqlConnection _conn = Connection.GetConnection();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) => new Register().ShowDialog();


        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string q = $"EXECUTE usp_Login '{UserInput.Text}', '{PasswordInput.Password}'";
            DataTable dt = new DataTable();
            try
            {
                new SqlDataAdapter(q, _conn).Fill(dt);
                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("El usuario no existe");
                    return;
                }
                MessageBox.Show("Loggeado correctamente " + dt.Rows[0]["NombreCompleto"]);
                new Principal(dt.Rows[0]["ID"].ToString()).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error " + ex.Message);
            }
        }
    }
}
