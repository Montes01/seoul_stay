using Seoul_Stay.Sections.PrincipalSections;
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
using System.Windows.Shapes;
using static Seoul_Stay.DAL.Connection;
namespace Seoul_Stay.Sections
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        string ID;
        public Principal(string id)
        {
            InitializeComponent();
            this.ID = id;
            InitComponents();
        }

        private void InitComponents()
        {
            Traveler.Content = new Traveler();
            Owner.Content = new Owner(ID);
        }



    }
}
