using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
    public class Dal : IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public void CreerRestaurant(string nom, string telephone)
        {
            bdd.Restos.Add(new Resto { Nom = nom, Telephone = telephone });
            bdd.SaveChanges();
        }

        public List<Resto> ObtientTousLesRestaurants()
        {
            return bdd.Restos.ToList();
        }


        public void ModifierRestaurant(int id, string nom, string telephone)
        {
            Resto restoTrouve = bdd.Restos.FirstOrDefault(resto => resto.Id == id);
            if (restoTrouve != null)
            {
                restoTrouve.Nom = nom;
                restoTrouve.Telephone = telephone;
                bdd.SaveChanges();
            }
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public bool RestaurantExiste(string v)
        {
            throw new NotImplementedException();
        }

        public void AjouterUtilisateur(string prenom, string motDePasse)
        {
            bdd.Utilisateurs.Add(new Utilisateur { Prenom = prenom, MotDePasse = motDePasse });
            bdd.SaveChanges();
        }

        public Utilisateur Authentifier(string prenom, string motDePasse)
        {
            throw new NotImplementedException();
        }
    }
}