using ProjetAP.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAP.VuesModeles.VuesModelesEncheres
{
    public class UneEnchereFlashVueModele : BaseVueModele
    {
        #region Attributes
        private Enchere _enchere;
        private List<BoxFlash> _tableauFlash;
        #endregion

        #region Constructeurs
        public UneEnchereFlashVueModele(Enchere enchere)
        {
            Enchere= enchere;
            TableauFlash= new List<BoxFlash>();
            foreach (string str in enchere.TableauFlash.Split(',').ToList())
            {
                TableauFlash.Add(new BoxFlash(enchere.LeProduit.PrixReel, str=="1"));
            };
            int nbBoutons = enchere.TableauFlash.Split(',').Count();
            int nbLignesCols = Convert.ToInt32(Math.Floor(Math.Sqrt(nbBoutons)));
            for (int x = 0; x < nbLignesCols; x++)
            {
                for (int y = 0; y < nbLignesCols; y++)
                {

                }
            }
        }
        #endregion

        #region Properties (Getters/Setters)
        public Enchere Enchere
        {
            get => _enchere;
            set => SetProperty(ref _enchere, value);
        }

        public List<BoxFlash> TableauFlash
        {
            get => _tableauFlash;
            set => SetProperty(ref _tableauFlash, value);
        }
        #endregion

        #region Méthodes
        #endregion
    }
}
