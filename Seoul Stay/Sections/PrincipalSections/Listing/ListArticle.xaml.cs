using Seoul_Stay.DAL;
using Seoul_Stay.Models;
using Seoul_Stay.Sections.PrincipalSections.Listing.Items;
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

namespace Seoul_Stay.Sections.PrincipalSections.Listing
{
    /// <summary>
    /// Lógica de interacción para ListArticle.xaml
    /// </summary>
    public partial class ListArticle : Window
    {
        private SqlConnection _conn = Connection.GetConnection();
        public Atractions AttractionControl = new Atractions();
        public Details DetailsControl = new Details();
        public Amenities AmenitiesControl = new Amenities();
        string ID;
        public ListArticle(string iD)
        {
            InitializeComponent();
            InitComponents();
            ID = iD;
        }

        private void InitComponents()
        {
            ListingDetails.Content = DetailsControl;
            Amenities.Content = AmenitiesControl;
            DistanceToAtraction.Content = AttractionControl;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var article = GetItems();
                AddArticle(article);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Article GetItems()
        {
            Article article = new Article
            {
                UserID = int.Parse(ID),
                Titulo = DetailsControl.TitleBox.Text,
                NumeroDeHabitaciones = int.Parse(DetailsControl.BedRooms.Text),
                NumeroDeCamas = int.Parse(DetailsControl.Beds.Text),
                Capacidad = int.Parse(DetailsControl.Capacity.Text),
                Descripcion = DetailsControl.Description.Text,
                NumeroDeBaños = int.Parse(DetailsControl.BathRooms.Text),
                DireccionAproximada = DetailsControl.Adress.Text,
                DireccionExacta = DetailsControl.ExactAdress.Text,
                ItemTypeId = (int)DetailsControl.TypeCombo.SelectedValue,
                HostRules = DetailsControl.HostRules.Text,
                NochesMinimas = int.Parse(DetailsControl.NochesMinimas.Text),
                NochesMaximas = int.Parse(DetailsControl.NochesMaximas.Text),
                ID = 0,
                AreaId = AttractionControl.attractions[0].Area
            };
            return article;
        }

        private void AddArticle(Article article)
        {
            string q = "usp_AgregarArticulo";
            SqlCommand cmd = new SqlCommand(q, _conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@ID", ID));
            cmd.Parameters.Add(new SqlParameter("@UserID", article.UserID));
            cmd.Parameters.Add(new SqlParameter("@ItemTypeId", article.ItemTypeId));
            cmd.Parameters.Add(new SqlParameter("@AreaId", article.AreaId));
            cmd.Parameters.Add(new SqlParameter("@Titulo", article.Titulo));
            cmd.Parameters.Add(new SqlParameter("@Capacidad", article.Capacidad));
            cmd.Parameters.Add(new SqlParameter("@NumeroDeCamas", article.NumeroDeCamas));
            cmd.Parameters.Add(new SqlParameter("@NumeroDeHabitaciones", article.NumeroDeHabitaciones));
            cmd.Parameters.Add(new SqlParameter("@NumeroDeBaños", article.NumeroDeBaños));
            cmd.Parameters.Add(new SqlParameter("@DireccionExacta", article.DireccionExacta));
            cmd.Parameters.Add(new SqlParameter("@DireccionAproximada", article.DireccionAproximada));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", article.Descripcion));
            cmd.Parameters.Add(new SqlParameter("@HostRules", article.HostRules));
            cmd.Parameters.Add(new SqlParameter("@NochesMinimas", article.NochesMinimas));
            cmd.Parameters.Add(new SqlParameter("@NochesMaximas", article.NochesMaximas));
            _conn.Open();

            try
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Articulo agregado correctamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
