using SP = Microsoft.SharePoint.Client;
using ControlloCommesseWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlloCommesseWeb.Pages
{
    public partial class Resoconto : SharepointPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var resoconto = CalcolaResoconto();
            gridResoconto.DataSource = resoconto;
            gridResoconto.DataBind();
            pnlResoconto.Visible = true;
        }

        protected IEnumerable<Attivita> LeggiItemsResoconto()
        {

            using (var clientContext = TokenHelper.GetClientContextWithContextToken(AppUrl, ContextToken, Request.Url.Authority))
            {
                SP.List oList = clientContext.Web.Lists.GetByTitle("RegistrazioneAttivita");
                SP.CamlQuery camlQuery = new SP.CamlQuery();
                camlQuery.ViewXml = "<View><Query><Where><Geq><FieldRef Name='DataInizio'/>" +
                    "<Value Type='DateTime'><Today /></Value></Geq></Where></Query><RowLimit>100</RowLimit></View>";

                SP.ListItemCollection collListItem = oList.GetItems(camlQuery);

                clientContext.Load(collListItem);

                clientContext.ExecuteQuery();

                var proj = from i in collListItem.ToList()
                           select new Attivita()
                           {
                               Titolo = i["Title"] as string,
                               IdCommessa = Convert.ToInt32(i["Commessa"] ?? 0),
                               DataInizio = Convert.ToDateTime(i["DataInizio"]).ToLocalTime(),
                               DataFine = Convert.ToDateTime(i["DataFine"] ?? DateTime.Now).ToLocalTime()
                           };

                return proj;
            }
        }

        protected IEnumerable<ElementiResoconto> CalcolaResoconto()
        {
            var items = LeggiItemsResoconto();

            var gruppiCommesse = from c in items
                                 group c by c.IdCommessa into g
                                 select new
                                 {
                                     Key = g.Key,
                                     Gruppo = g
                                 };

            List<ElementiResoconto> resoconto = new List<ElementiResoconto>();
            foreach (var g in gruppiCommesse)
            {
                var titolo = g.Gruppo.First().Titolo;
                var elemento = new ElementiResoconto()
                {
                    Titolo = titolo
                };

                elemento.Totale = new TimeSpan();
                elemento.NumeroAttivita = 0;
                foreach (var i in g.Gruppo)
                {
                    


                    elemento.Totale = elemento.Totale.Add(i.OreFatte);
                    elemento.NumeroAttivita++;
                }

                resoconto.Add(elemento);
            }


            return resoconto;
        }

        protected string DisplayAsHoursMinutes(object oTimespan)
        {
            
            if (oTimespan == null || (oTimespan is TimeSpan) == false)
                return string.Empty;


            TimeSpan ts = (TimeSpan) oTimespan;
            return string.Format("{0:00}:{1:00}", ts.Hours, ts.Minutes);
        }
    }
}