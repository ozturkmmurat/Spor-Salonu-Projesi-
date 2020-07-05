<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris Sayfası.aspx.cs" Inherits="ProjeSite.Giris_Sayfası" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Tc"></asp:Label>
            <asp:TextBox ID="txt_Tc" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Şifre"></asp:Label>
            <asp:TextBox ID="Txt_Sifre" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_GirisYap" runat="server" OnClick="btn_GirisYap_Click" Text="Giriş Yap" />
        </div>
    </form>
</body>
</html>
