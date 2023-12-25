using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Telerik.Windows.Controls;

namespace projectExam
{
    /// <summary>
    /// Logique d'interaction pour GestionFiliere.xaml
    /// </summary>
    public partial class GestionFiliere : Window
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        private ObservableCollection<filiere> filieres;
        public GestionFiliere()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            filieres = new ObservableCollection<filiere>(context.filiere.ToList());
            radcarsl.ItemsSource = filieres;
        }

        private void carou(object sender, RoutedEventArgs e)
        {
            var filieres = from f in context.filiere
                           select f;
            // Liaison des données avec le RadCarousel
            radcarsl.ItemsSource = filieres;

        }

        private void radcarou(object sender, SelectionChangeEventArgs e)
        {
            if (radcarsl.SelectedItem != null)
            {
                var selectedItem = (filiere)radcarsl.SelectedItem;
                textBoxId.Text = selectedItem.Id_filiere.ToString();
                textBoxNom.Text = selectedItem.Nom_filiere;
                textBoxResponsable.Text = selectedItem.Responsable;
            }
        }

        private void ajouter_click(object sender, RoutedEventArgs e)
        {
            int newId = int.Parse(textBoxId.Text);
            filiere nouvelleFiliere = new filiere
            {
                //Id_filiere = int.Parse(textBoxId.Text),
                Nom_filiere = textBoxNom.Text,
                Responsable = textBoxResponsable.Text
            };

            context.filiere.InsertOnSubmit(nouvelleFiliere);
            context.SubmitChanges();
            nouvelleFiliere.Id_filiere = newId;

            filieres.Add(nouvelleFiliere);
            radcarsl.ItemsSource = null;
            radcarsl.ItemsSource = filieres;
            textBoxId.Text = "";
            textBoxNom.Text = "";
            textBoxResponsable.Text = "";
            MessageBox.Show("Filière ajoutée avec succès !");
        }

        private void modifier_click(object sender, RoutedEventArgs e)
        {
            if (radcarsl.SelectedItem != null)
            {
                var filiereAModifier = (filiere)radcarsl.SelectedItem;

                filiereAModifier.Id_filiere = int.Parse(textBoxId.Text);

                filiereAModifier.Nom_filiere = textBoxNom.Text;
                filiereAModifier.Responsable = textBoxResponsable.Text;

                context.SubmitChanges();
                MessageBox.Show("Filière modifiée avec succès !");

            }

        }

        private void supprimer_click(object sender, RoutedEventArgs e)
        {
            if (radcarsl.SelectedItem != null)
            {
                var filiereASupprimer = (filiere)radcarsl.SelectedItem;

                context.filiere.DeleteOnSubmit(filiereASupprimer);
                context.SubmitChanges();

                filieres.Remove(filiereASupprimer);
                radcarsl.ItemsSource = null;
                radcarsl.ItemsSource = filieres;
                textBoxId.Text = "";
                textBoxNom.Text = "";
                textBoxResponsable.Text = "";
                MessageBox.Show("Filière supprimée avec succès !");
            }
        }

    }
}

