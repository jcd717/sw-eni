using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Net;
using System.Net.Sockets;

using System.Collections.Generic;

public partial class _Default : System.Web.UI.Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      Trace.Write("message de trace");
      if (Session["maSession"] == null)
      {
         Session["maSession"] = new MaSession();
      }
      MaSession maSession=(MaSession)Session["maSession"];
      maSession.incrementer();
      
	  IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName()); // `Dns.Resolve()` method is deprecated.
	  String ip=null;
	  foreach(IPAddress ipAddress in ipHostInfo.AddressList) {
		  if(ipAddress.AddressFamily==AddressFamily.InterNetwork)
			  ip=ipAddress.ToString();
	  }
	  
      LabelServeur.Text = "Vous &ecirc;tes sur le serveur: "+Server.MachineName+" ("+ip+")";
      LabelRefresh.Text = "Nombre de Refresh(s): " + maSession.compteur + "  qui " +
         ((maSession.isCompteurPrime()) ? "EST" : "n'est PAS") + " premier";

      LabelNBtrouves.Text = ""+maSession.premiersTrouves.Count;
      String s = "";
      int nb = 0;
      foreach(int p in maSession.premiersTrouves)
      {
         nb++;
         s += p;
         if (nb<maSession.premiersTrouves.Count) s += ", ";
      }
      LabelListePrermiers.Text = s;

         
   }
}
