using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.Modeles
{
    public class TypeEnchere
    {
        #region Attribus
        private int _id;
        private string _nom;


        #endregion

        #region Constructeur
        public TypeEnchere(int id, string nom)
        {
            _id = id;
            _nom = nom;
        }
        #endregion

        #region Guetteurs Setteurs
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        #endregion

        #region Methode
        #endregion




        #region Attribus
        #endregion

        #region Constructeur
        #endregion

        #region Guetteurs Setteurs
        #endregion

        #region Methode
        #endregion
    }
}
