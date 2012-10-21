using SP = Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using ControlloCommesseWeb.Models;

namespace ControlloCommesseWeb.Pages
{
    public partial class Default : SharepointPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // The following code gets the client context and Title property by using TokenHelper.
            // To access other properties, you may need to request permissions on the host web.
            if (!Page.IsPostBack)
            {
                using (var clientContext = TokenHelper.GetClientContextWithContextToken(AppUrl, ContextToken, Request.Url.Authority))
                {
                    //clientContext.Load(clientContext.Web, web => web.Title);
                    //clientContext.ExecuteQuery();
                    //Response.Write(clientContext.Web.Title);
                    //clientContext.ToString();

                    SP.List oList = clientContext.Web.Lists.GetByTitle("Commesse");
                    SP.CamlQuery camlQuery = new SP.CamlQuery();
                    camlQuery.ViewXml = "<View><Query><Where><Eq><FieldRef Name='Visualizzabile'/>" +
                        "<Value Type='Boolean'>1</Value></Eq></Where></Query><RowLimit>100</RowLimit></View>";

                    SP.ListItemCollection collListItem = oList.GetItems(camlQuery);

                    clientContext.Load(collListItem);

                    clientContext.ExecuteQuery();

                    List<Commessa> commesse = new List<Commessa>();
                    foreach (var item in collListItem)
                    {
                        var commessa = new Commessa()
                        {
                            Id = item.Id,
                            Titolo = item["Title"].ToString(),
                            Colore = Color.FromName(item["Colore"] as string ?? "Red")
                        };

                        commesse.Add(commessa);
                    }

                    lvCommesse.DataSource = commesse;
                    lvCommesse.DataBind();
                }

                // Lo metto solo quando faccio la postback perchè quando clicco sul button lo setto direttamente
                // nell'handler dell'evento
                var lastItem = LeggiUltimaAttivita();
                VisualizzaAttivita(lastItem);
            }


            
        }

        private void VisualizzaAttivita(SP.ListItem lastItem)
        {
            if (lastItem != null)
            {
                var attivita = new Attivita()
                {
                    Titolo = lastItem["Title"] as string,
                    IdCommessa = Convert.ToInt32(lastItem["Commessa"] ?? 0),
                    DataInizio = Convert.ToDateTime(lastItem["DataInizio"]).ToLocalTime(),
                    //DataFine = Convert.ToDateTime(lastItem["DataFine"] ?? DateTime.Now).ToLocalTime()
                };

                frmAttivitaCorrente.DataSource = new List<Attivita>() { attivita };
                frmAttivitaCorrente.DataBind();
            }

            
        }

        private SP.ListItem LeggiUltimaAttivita()
        {
            using (var clientContext = TokenHelper.GetClientContextWithContextToken(AppUrl, ContextToken, Request.Url.Authority))
            {
                SP.List oList = clientContext.Web.Lists.GetByTitle("RegistrazioneAttivita");

                //Aggiorno l'ultima commessa
                SP.CamlQuery camlQuery = new SP.CamlQuery();
                camlQuery.ViewXml = "<View><Query><OrderBy><FieldRef Name='ID' Ascending='False' />" +
                    "</OrderBy></Query><RowLimit>1</RowLimit></View>";

                SP.ListItemCollection collListItem = oList.GetItems(camlQuery);

                clientContext.Load(collListItem);

                clientContext.ExecuteQuery();

                
                var lastItem = collListItem.ToList().LastOrDefault();

                return lastItem;
            }
        }

        private Color GetRandomColor()
        {
            Random randomGen = new Random((int) DateTime.Now.Ticks);
            KnownColorSelezionati[] names = (KnownColorSelezionati[])Enum.GetValues(typeof(KnownColorSelezionati));
            KnownColorSelezionati randomColorName = names[randomGen.Next(names.Length)];
            KnownColor kn = (KnownColor)((int)randomColorName);
            Color randomColor = Color.FromKnownColor(kn);

            return randomColor;
        }

        protected void lvCommesse_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int itemIndex = ((ListViewDataItem)e.Item).DisplayIndex;

            // Extract the key and cast it to its data type.
            DataKey key = ((ListView)sender).DataKeys[itemIndex];
            string idCommessa = key.Values["Id"].ToString();
            string titolo = key.Values["Titolo"] as string;
                        

            using (var clientContext = TokenHelper.GetClientContextWithContextToken(AppUrl, ContextToken, Request.Url.Authority))
            {
                SP.List oList = clientContext.Web.Lists.GetByTitle("RegistrazioneAttivita");

                //Aggiorno l'ultima commessa
                var lastItem = LeggiUltimaAttivita();
                if (lastItem != null)
                {
                    // Lo devo rileggere perchè l'ho caricato con un altro contesto
                    lastItem = oList.GetItemById(lastItem.Id);
                    lastItem["DataFine"] = DateTime.Now;

                    lastItem.Update();
                    clientContext.ExecuteQuery();

                    
                }

                //Aggiungo quella nuova
                var spCreationInfo = new SP.ListItemCreationInformation();
                var attivitaItem = oList.AddItem(spCreationInfo);
                attivitaItem["Title"] = titolo;
                attivitaItem["Commessa"] = idCommessa;
                attivitaItem["DataInizio"] = DateTime.Now;

                attivitaItem.Update();

                clientContext.ExecuteQuery();

                VisualizzaAttivita(attivitaItem);
            }
        }

        
    }
}