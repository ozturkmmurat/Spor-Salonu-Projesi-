<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" EnableViewState="false" ViewStateMode="Disabled" CodeBehind="AktiviteTablosu.aspx.cs" Inherits="ProjeSite.MasterSporBolumuTablosu" %>
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
        <h2>Aktivite Tablosu</h2>



           <table>
  <thead>
    <tr>
     <th scope="col" >İD</th>
         <th scope="col">Branş Adı</th>
            <th scope="col">Düzenle</th>    
          <th scope="col">Sil</th>
           
              
              

    </tr>
  </thead>
  <tbody>
      <asp:Repeater  OnItemCommand="SporBolumuTablosu_ItemCommand" ID="SporBolumuTablosu" runat="server">
                  <ItemTemplate>
    <tr>
      <td data-column="İD"> <%#Eval("id") %></td>
   <td data-column="TC"> <%#Eval("SporBolumu") %></td>
     
       
      <%--  İCON--%>
       
      <td data-column="Düzenle"> 
          <asp:ImageButton  ID="Düzenle" Style="height:auto;width:auto; background-color: #FAFAFA;"  
              runat="server"  CommandName="Düzenleme"   CommandArgument='<%#Eval("id")%>' img src="image/galeri/edit.jpg" />
         </td>
        <td data-column="Sil">           
          <asp:ImageButton Style="height:auto;width:auto; background-color: #FAFAFA;"  ID="Sil" 
              runat="server" OnClientClick="return confirm('Silmek istediğinizden emin misiniz?')"  
              CommandName="Sil" CommandArgument='<%#Eval("id")%>' Text="Sil" img src="image/galeri/Deleteİcon.jpg" />
               </td>
       
     <%--  ---------%>
        </ItemTemplate>
              </asp:Repeater>
  </tbody>
</table>



       </form>
</asp:Content>
