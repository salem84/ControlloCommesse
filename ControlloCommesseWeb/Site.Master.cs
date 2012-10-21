using ControlloCommesseWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlloCommesseWeb
{
    public partial class SiteMaster : MasterPage
    {
        public string HostUrl 
        {
            get
            {
                return Session["HostUrl"] as string;
            }
            set
            {
                Session["HostUrl"] = value;
            }
        }

        public string AppUrl
        {
            get
            {
                return Session["AppUrl"] as string;
            }
            set
            {
                Session["AppUrl"] = value;
            }
        }

        public string ContextToken
        {
            get
            {
                return Session["ContextToken"] as string;
            }
            set
            {
                Session["ContextToken"] = value;
            }
        }

        /*private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }*/

        protected void Page_Init(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ContextToken))
            {
                ContextToken = TokenHelper.GetContextTokenFromRequest(Page.Request);
                if (ContextToken == null)
                {
                    Response.Write("Impossibile leggere il context token --");
                    Response.Flush();
                    Response.Close();
                }

                HostUrl = Page.Request["SPHostUrl"];
                AppUrl = Page.Request["SPAppWebUrl"];
            }

            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            lnkCommesse.NavigateUrl = AppUrl + "/Lists/Commesse";
            lnkAttivita.NavigateUrl = AppUrl + "/Lists/RegistrazioneAttivita";
        }
    }
}