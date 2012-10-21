using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ControlloCommesseWeb;

namespace ControlloCommesseWeb.Pages
{
    public class SharepointPage : Page
    {
        protected SiteMaster SiteMasterPage
        {
            get
            {
                return Page.Master as SiteMaster;
            }
        }

        protected string HostUrl
        {
            get
            {
                return SiteMasterPage.HostUrl;
            }
            
        }

        protected string AppUrl
        {
            get
            {
                return SiteMasterPage.AppUrl;
            }
            
        }

        protected string ContextToken
        {
            get
            {
                return SiteMasterPage.ContextToken;
            }
            
        }
    }
}