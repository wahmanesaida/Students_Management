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
using System.Windows.Shapes;

namespace projectExam
{
    /// <summary>
    /// Logique d'interaction pour modifyStudent.xaml
    /// </summary>
    public partial class modifyStudent : Window
    {

        etudiant etudiant1 = new etudiant();
        DataClasses1DataContext context = new DataClasses1DataContext();
        public modifyStudent(etudiant etudiant)
        {
            InitializeComponent();
            etudiant1=etudiant;
            cne.Text = etudiant.CNE.ToString() ;
            nom.Text = etudiant.Nom.ToString();
            prenom.Text=etudiant.Prénom.ToString();
            DateN.Text = etudiant.Date_Naissance.ToString();

        }
        private void validate(object sender, RoutedEventArgs e)
        {

            etudiant1.CNE = int.Parse(cne.Text);
            etudiant1.Nom = nom.Text;
            etudiant1.Prénom = prenom.Text;
            
            etudiant1.Date_Naissance = DateTime.Parse(DateN.Text);
            var x = (from c in context.etudiant where c.CNE == etudiant1.CNE select c).SingleOrDefault();
            x.CNE = etudiant1.CNE;
            x.Nom = etudiant1.Nom;
            x.Prénom = etudiant1.Prénom;
           
            x.Date_Naissance = etudiant1.Date_Naissance;
            context.SubmitChanges();

        }
    }
}
