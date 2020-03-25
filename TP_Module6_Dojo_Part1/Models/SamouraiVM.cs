using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_Module6_Dojo_Part1.Models
{
    public class SamouraiVM
    {
        public Samourai Samourai { get; set; }
        public List<Arme> Armes { get; set; }
        public int? IdSelectedArme { get; set; }
        public List<ArtMartial> ArtMartials { get; set; } = new List<ArtMartial>();
        public List<int> ArtMartialsIds { get; set; } = new List<int>();

    }
}