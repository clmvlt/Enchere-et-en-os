using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.Modeles
{
    public class Encherir
    {
        #region Attribus
        public static List<Encherir> CollClasse = new List<Encherir>();
        private int _id;
        private float _prixEnchere;
        private DateTime _dateEnchere;
        private Enchere _laEnchere;
        private User _leUser;

        public Encherir(int id, float prixEnchere, DateTime dateEnchere, Enchere laEnchere, User leUser)
        {
            Id = id;
            PrixEnchere = prixEnchere;
            DateEnchere = dateEnchere;
            LaEnchere = laEnchere;
            LeUser = leUser;
            Encherir.CollClasse.Add(this);
        }

        #endregion

        #region Constructeurs
        #endregion

        #region Properties
        public int Id { get => _id; set => _id = value; }
        public float PrixEnchere { get => _prixEnchere; set => _prixEnchere = value; }
        public DateTime DateEnchere { get => _dateEnchere; set => _dateEnchere = value; }
        public Enchere LaEnchere { get => _laEnchere; set => _laEnchere = value; }
        public User LeUser { get => _leUser; set => _leUser = value; }
        #endregion

        #region Methodes
        #endregion
    }
}
