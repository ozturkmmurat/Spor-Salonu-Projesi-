<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterTemplate.Master" AutoEventWireup="true" CodeBehind="KullanıcıSporTablosu.aspx.cs" Inherits="ProjeSite.KullanıcıSporTablosu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <%--   İCON JS--%>
        <head>
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
     <th scope="col" >Spor Gün</th>        
            <th scope="col">Yapılacak Hareketler</th>  
         <th scope="col">Program Bitiş</th>
        
    </tr>
  </thead>
  <tbody>
      <asp:Repeater  ID="SporBolumuTablosu" OnItemCommand="SporBolumuTablosu_ItemCommand" runat="server">
                  <ItemTemplate>
    <tr>
       
      <td data-column="Spor Gün"> <%#Eval("Spor_Gun") %></td>
    <td data-column="Yapılacak Hareketler"> <%#Eval("Yapilacak_Hareketler") %></td>
        <td data-column="Program Bitiş"> <%#Eval("Program_Bitis") %></td>
       <td data-column="Düzenle"> 
          <asp:ImageButton  ID="Düzenle" Style="height:auto;width:auto; background-color: #FAFAFA;"  
              runat="server"  CommandName="Getir"   CommandArgument='<%#Eval("id")%>' img src="image/galeri/edit.jpg" />
         </td>
     
        </ItemTemplate>
              </asp:Repeater>
  </tbody>
</table>
           </form>
</asp:Content>
