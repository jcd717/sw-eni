<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Test</title>
</head>
<body >
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelServeur" runat="server" Font-Size="X-Large">Serveur</asp:Label>
    
    </div>
    <br/>
    
        <asp:Label ID="LabelRefresh" runat="server" Font-Size="X-Large">Refreshs</asp:Label>
    
    
    
    <p />
    Nombres Premiers trouv&eacute;s:
    <asp:Label ID="LabelNBtrouves" runat="server"></asp:Label>
    <br />
    <asp:Label ID="LabelListePrermiers" runat="server"></asp:Label>
    
    
    </form>
    <div>
        VERSION 3
    </div>
</body>
</html>

