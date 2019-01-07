using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace eDostava
{
    /// <summary>
    /// Summary description for eDostavaServis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class eDostavaServis : System.Web.Services.WebService
    {

        List<Blok> blokovi = new List<Blok>();
        List<Restoran> restorani = new List<Restoran>();

        public eDostavaServis()
        {
            blokovi.Add(new Blok { Id = 1, Naziv = "Brčanska malta" });
            blokovi.Add(new Blok { Id = 2, Naziv = "Centar" });
            blokovi.Add(new Blok { Id = 3, Naziv = "Irac" });

            restorani.Add(new Restoran { Id = 1, Blok = blokovi[0], Naziv="Petica", Ime = "Eldar", Prezime = "Jahijagić" });
            restorani.Add(new Restoran { Id = 2, Blok = blokovi[0], Naziv = "Sezam", Ime = "Asmir", Prezime = "Duljević" });
            restorani.Add(new Restoran { Id = 3, Blok = blokovi[0], Naziv = "Pizza Hut", Ime = "Emina", Prezime = "Halilagić" });
            restorani.Add(new Restoran { Id = 4, Blok = blokovi[1], Naziv = "Italiano", Ime = "Sanel", Prezime = "Ibrahimović" });
            restorani.Add(new Restoran { Id = 5, Blok = blokovi[2], Naziv = "Stari Grad", Ime = "Mario", Prezime = "Mandžukić" });
        }



        [WebMethod]
        public List<Restoran> GetRestoraniByBlok(int blokId)
        {
            return restorani.Where(r => r.Blok.Id == blokId).ToList();
        }

        [WebMethod]
        public List<Restoran> GetRestoranByNaziv(string naziv)
        {
            return restorani.Where(r => r.Naziv.Contains(naziv)).ToList();
        }

        [WebMethod]
        public List<Restoran> GetRestorani()
        {
            return restorani;
        }

        [WebMethod]
        public List<Blok> GetBlokovi()
        {
            return blokovi;
        }

        public class Blok
        {
            public int Id { get; set; }
            public string Naziv { get; set; }
        }

        public class Restoran
        {
            public int Id { get; set; }
            public string Naziv { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public Blok Blok { get; set; }
        }
    }
}
