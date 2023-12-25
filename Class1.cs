using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectExam
{
    internal class Class1
    {
        DataClasses1DataContext context = new DataClasses1DataContext();
        public string NomFiliere { get; set; }
        public int NombreEtudiants { get; set; }

        public static List<Class1> GetNombreEtudiantsParFiliere()
        {
            DataClasses1DataContext dataContext = new DataClasses1DataContext();

            var query = from filiere in dataContext.filiere
                        select new Class1
                        {
                            NomFiliere = filiere.Nom_filiere,
                            NombreEtudiants = filiere.etudiant.Count()
                        };

            return query.ToList();
        }
    }
}
