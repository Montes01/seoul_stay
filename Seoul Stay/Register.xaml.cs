using Seoul_Stay.DAL;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Seoul_Stay
{
    /// <summary>
    /// Lógica de interacción para Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        private static readonly SqlConnection _conn = Connection.GetConnection();

        public Register()
        {
            InitializeComponent();
        }

        private void RegisterEvent(object sender, RoutedEventArgs e)
        {
            string date = BirthDayInput.SelectedDate.ToString().Split(' ')[0];
            string sex = (bool)maleRadio.IsChecked ? "M" : "F";
            if (PasswordInput.Password != PasswordRepeat.Password)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }


            string q = $"EXECUTE usp_Register {new Random().Next()}, 1, '{UserNameInput.Text}', '{PasswordInput.Password}', '{FullNameInput.Text}', '{sex}', '{date}', {FamilyInput.Text}";
            MessageBox.Show(q);
            SqlCommand com = new SqlCommand(q, _conn);
            _conn.Open();
            try
            {
                com.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado correctamente");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al registrar el usuario");
            }
            finally
            {
                _conn.Close();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e) => Close();
    }
}
