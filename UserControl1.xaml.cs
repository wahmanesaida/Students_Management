using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace projectExam
{

    public partial class UserControl1 : UserControl
    {

        DataClasses1DataContext context = new DataClasses1DataContext();
        public UserControl1()
        {
            InitializeComponent();
            //chargerDatagrid();
            chargerComboBox();
            Loaded += UserControl1_Loaded;
        }

        private void UserControl1_Loaded(object sender, RoutedEventArgs e)
        {
            // Load data when UserControl is loaded
            chargerDatagrid();
        }

        private void chargerComboBox()
        {

            comboBox.SelectionChanged += RadComboBox_SelectionChanged;

            var nomsFilieres = (from f in context.filiere
                                select f).ToList();

            // Liaison des données au RadComboBox
            comboBox.Items.Clear();
            comboBox.ItemsSource = nomsFilieres;
            comboBox.DisplayMemberPath = "Nom_filiere";
            comboBox.SelectedIndex = 0;
        }

        private void RadComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            // Récupérer la filière sélectionnée dans le RadComboBox
            filiere selectedFiliere = (filiere)comboBox.SelectedItem;

            if (selectedFiliere != null)
            {
                // Utiliser le DataContext pour interagir avec la base de données

                // Récupérer les étudiants de la filière sélectionnée
                var etudiantsFiliere = from etudiant in context.etudiant
                                       where etudiant.Id_filiere == selectedFiliere.Id_filiere
                                       select etudiant;

                // Charger les étudiants dans le DataGrid
                dataGrid.ItemsSource = etudiantsFiliere.ToList();

            }
        }

        private void modifier_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {

            }
            
        }

        private void chargerDatagrid()
        {
            dataGrid.Columns.Clear();
            var etudiants = from e in context.etudiant
                            select new
                            {
                                e.CNE,
                                e.Nom,
                                e.Prénom,
                                e.Date_Naissance,
                                e.image_profile 
                            };
            dataGrid.ItemsSource = etudiants;
        }
    }
}
