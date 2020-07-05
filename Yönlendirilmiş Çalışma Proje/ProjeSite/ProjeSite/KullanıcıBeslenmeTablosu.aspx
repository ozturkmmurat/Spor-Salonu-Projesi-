<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterTemplate.Master" AutoEventWireup="true" CodeBehind="KullanıcıBeslenmeTablosu.aspx.cs" Inherits="ProjeSite.KullanıcıBeslenmeTablosu" %>
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
        <h2>Beslenme Programı Tablosu</h2>



           <table>
  <thead>
    <tr>
     <th scope="col" >Beslenme Gün</th>       
            <th scope="col">Beslenme Programı Sabah</th>    
          <th scope="col">Beslenme Programı Öğlen</th>
          <th scope="col">Beslenme Programı Ara Öğün</th>
         <th scope="col">Beslenme Programı Akşam</th>
            <th scope="col">Program Bitiş</th>
              
              

    </tr>
  </thead>
  <tbody>
      <asp:Repeater  ID="BeslenmeTablosu" runat="server">
                  <ItemTemplate>
    <tr style="word-break: break-word;" >
        <td data-column=" Gün"> <%#Eval("Beslenme_Gun") %></td>
      <td data-column="  Sabah"> <%#Eval("Beslenme_Sabah") %></td>
    <td data-column="  Öğlen"> <%#Eval("Beslenme_Oglen") %></td>
         <td data-column="  Ara Öğün"> <%#Eval("Beslenme_AraOgun") %></td>
         <td data-column="  Akşam"> <%#Eval("Beslenme_Aksam") %></td>
         <td data-column=" Bitiş"> <%#Eval("Program_Bitis") %></td>
     
       
     
        </ItemTemplate>
              </asp:Repeater>
  </tbody>
</table>
           </form>
</asp:Content>
