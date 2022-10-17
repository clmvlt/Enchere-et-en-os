using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.Modeles
{
    public class Enchere
    {
        #region Attribus
        public static List<Enchere> CollClasse = new List<Enchere>();

        private int _id;
        private string _dateDebut;
        private string _dateFin;
        private int _prixReserve;
        private Produit _leProduit;
        private TypeEnchere _leTypeenchere;
        private bool _visibilite;
        private Magasin _leMagasin;
        private int _prixDepart;
        private object _tableauFlash;
        private List<object> _playerFlashes;
        #endregion

        #region Constructeur
        public Enchere(int id, string dateDebut, string dateFin, int prixReserve, Produit leProduit, TypeEnchere leTypeenchere, bool visibilite, Magasin leMagasin, int prixDepart, object tableauFlash, List<object> playerFlashes)
        {
            _id = id;
            _dateDebut = dateDebut;
            _dateFin = dateFin;
            _prixReserve = prixReserve;
            _leProduit = leProduit;
            _leTypeenchere = leTypeenchere;
            _visibilite = visibilite;
            _leMagasin = leMagasin;
            _prixDepart = prixDepart;
            _tableauFlash = tableauFlash;
            _playerFlashes = playerFlashes;

            Enchere.CollClasse.Add(this);
        }

        #endregion

        #region Guetteurs Setteurs
        public int Id { get => _id; set => _id = value; }
        public string DateDebut { get => _dateDebut; set => _dateDebut = value; }
        public string DateFin { get => _dateFin; set => _dateFin = value; }
        public int PrixReserve { get => _prixReserve; set => _prixReserve = value; }
        public Produit LeProduit { get => _leProduit; set => _leProduit = value; }
        public TypeEnchere LeTypeenchere { get => _leTypeenchere; set => _leTypeenchere = value; }
        public bool Visibilite { get => _visibilite; set => _visibilite = value; }
        public Magasin LeMagasin { get => _leMagasin; set => _leMagasin = value; }
        public int PrixDepart { get => _prixDepart; set => _prixDepart = value; }
        public object TableauFlash { get => _tableauFlash; set => _tableauFlash = value; }
        public List<object> PlayerFlashes { get => _playerFlashes; set => _playerFlashes = value; }
        #endregion

        #region Methodes
        #endregion
    }
}
