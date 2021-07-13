using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = Projet.DALGlobal.Models;

namespace Projet.DALClient.Models
{
    public class Chambre
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string DescriptionC { get; set; }
        public string DescriptionL { get; set; }
        public string TypeDeChambre { get; set; }
        public int Capacite { get; set; }
        public int NombreDeSDB { get; set; }
        public int NombreDeWC { get; set; }
        public string Nom { get; set; }

        public double Prix { get; set; }
        public int HotelId { get; set; }

        public Chambre(G.Chambre entity)
        {
            Id = entity.Id;
            Numero = entity.Numero;
            DescriptionC = entity.DescriptionC;
            DescriptionL = entity.DescriptionL;
            TypeDeChambre = entity.TypeDeChambre;
            Capacite = entity.Capacite;
            NombreDeSDB = entity.NombreDeSDB;
            NombreDeWC = entity.NombreDeWC;
            Prix = entity.Prix;
            HotelId = entity.HotelId;
            Nom = entity.Nom;

        }
        public Chambre()
        {

        }
    }
}
