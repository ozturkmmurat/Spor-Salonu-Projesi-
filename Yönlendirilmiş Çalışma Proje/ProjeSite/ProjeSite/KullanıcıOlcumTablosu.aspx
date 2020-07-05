<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterTemplate.Master" AutoEventWireup="true" CodeBehind="KullanıcıOlcumTablosu.aspx.cs" Inherits="ProjeSite.KullanıcıOlcumTablosu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <head>
     <%--   İCON JS--%>
     
        <meta name='viewport' content='width=device-width, initial-scale=1'>
<script src='https://kit.fontawesome.com/a076d05399.js'></script>
<%------------%>
        <link href="Content/css/bootstrap.min.css" rel="stylesheet" />
    <link href="TabloTasarım.css" rel="stylesheet" />
    </head>
       <form runat="server">
        <h2>Ölçüm Tablosu</h2>



           <table>
  <thead>
    <tr>
     <th scope="col" >KİLO</th>
         <th scope="col">BOY</th>
            <th scope="col">KAS ORANI</th>    
          <th scope="col">YAĞ ORANI</th>
          <th scope="col">SU ORANI</th>
          <th scope="col">Program Bitiş Tarihi</th>
           
              
             

    </tr>
  </thead>
  <tbody>
      <asp:Repeater   ID="OlcumTablosu" runat="server">
                  <ItemTemplate>
    <tr>
     <td data-column="Kilo"> <%#Eval("Kilo") %></td>
     <td data-column="Boy"> <%#Eval("Boy") %></td>
     <td data-column="Kas Oranı"> <%#Eval("Kas_Orani") %></td>
     <td data-column="Yağ Oranı"> <%#Eval("Yag_Orani") %></td>
     <td data-column="Su Oranı"> <%#Eval("Su_Orani") %></td>
     <td data-column="Program Bitis Tarihi"> <%#Eval("Program_Bitis") %></td>
       </tr>
     
        </ItemTemplate>
              </asp:Repeater>
  </tbody>
</table>



       </form>
</asp:Content>
