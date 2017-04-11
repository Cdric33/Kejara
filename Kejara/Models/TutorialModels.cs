using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Data.Entity;

namespace Kejara.Models
{
    #region Modèle Tutorial
    /// <summary>
    /// Objet metier Tutorial
    /// </summary>
    [Table("UserProfile")]
    public class Tutorial
    {
        /// <summary>
        /// Clé primaire ID
        /// </summary>
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Champ Auteur
        /// </summary>
        public string Auteur { get; set; }

        /// <summary>
        /// Champ Titre
        /// </summary>
        public string Titre { get; set; }

        /// <summary>
        /// Construteur par défaut
        /// </summary>
        public Tutorial()
        {
            ID = 0;
            Auteur = "";
            Titre = "";
        }

        /// <summary>
        /// Construteur avec paramètres
        /// </summary>
        public Tutorial(int id, string auteur, string titre)
        {
            ID = id;
            Auteur = auteur;
            Titre = titre;
        }
    }
    #endregion

    #region TutorialService
     /// <summary>
    /// Classe de service pour Tutorial
    /// </summary>
    public class TutorialService
    {
        /// <summary>
        /// Fournit une liste de Tutorials
        /// </summary>
        /// <returns></returns>
        public List<Tutorial> Select()
        {
            List<Tutorial> listTuto = new List<Tutorial>();
            listTuto.Add(new Tutorial(1, "Cédric GOMEZ", "ASP.NET MVC"));
            listTuto.Add(new Tutorial(2, "Cédric GOMEZ", "LINQ"));

            return listTuto;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Tutorial Select(int id)
        {
            // On utilise LINQ
            var tuto = from o in Select()
                       where o.ID == id
                       select o;

            return tuto.ToArray()[0];
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="tutorial"></param>
        public void Insert(Tutorial tutorial)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tutorial"></param>
        public void Update(Tutorial tutorial)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tutorial"></param>
        public void Delete(int id)
        {

        }
    }
    #endregion
}