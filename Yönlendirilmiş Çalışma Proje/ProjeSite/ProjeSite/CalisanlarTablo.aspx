<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"  CodeBehind="CalisanlarTablo.aspx.cs"EnableViewState="false" ViewStateMode="Disabled" Inherits="ProjeSite.CalisanlarTablo" %>
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
 <h2>ÜYELERİM</h2>
               <asp:HiddenField ID="hdnId" runat="server" />
           <asp:Label ID="Calisanİd" runat="server" Text="Label"></asp:Label>
<table style="margin-left:0px;">
  <thead>
    <tr>
    
         <th scope="col">TC</th>
                <th scope="col">AD</th>              
              <th scope="col">SOYAD</th>
        <th scope="col">TEL</th>
        <th scope="col">DG.TRH</th>
        <th scope="col">ADRES</th>
              <th scope="col">E _mail</th>
         <th scope="col">Branş</th>
                <th scope="col">Hakkında</th>                
                <th scope="col">DÜZENLE</th>
                <th scope="col">SİL</th>
           
              
              

    </tr>
  </thead>
  <tbody>
      <asp:Repeater OnItemCommand="CalisanlarTabloİd_ItemCommand" ID="CalisanlarTabloİd" runat="server">
                  <ItemTemplate>
    <tr>
   
   <td data-column="TC"> <%#Eval("Calisan_TcNo") %></td>
      <td data-column="AD"> <%#Eval("Calisan_Ad") %></td>
      <td data-column="SOYAD"> <%#Eval("Calisan_Soyad") %></td>
          <td data-column="Tel"> <%#Eval("Calisan_Tel") %></td>
      <td data-column="DG.TRH"> <%#Eval("Calisan_DogumTarh","{0:MM/dd/yyyy}") %></td>
          <td data-column="E-Mail"> <%#Eval("Calisan_Adres") %></td>        
       <td data-column="Adres"> <%#Eval("E_mail") %></td>
        <td data-column="Branş"> <%#Eval("Calisan_Brans") %></td>
         <td  data-column ="Hakkında"> <%#Eval("Calisan_Hakkinda") %></td>
       
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
