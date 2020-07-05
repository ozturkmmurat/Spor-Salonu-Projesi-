<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminKampanyalar.aspx.cs" ViewStateMode="Disabled" Inherits="ProjeSite.AdminKampanyalar" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

 <header>
         <link href="TabloTasarım.css" rel="stylesheet" />
           <link href="Css/SalonGenelBilgiler.css" rel="stylesheet" />
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
             <link href="Content/css/bootstrap.min.css" rel="stylesheet" />
 <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Open+Sans:400,600,700" />
      
          <meta name="viewport" content="width=device-width, initial-scale=1,maximum-scale=1">
    </header> 
    <form runat="server">
    <asp:ScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"></asp:ScriptManager>
    <div class="listing-description">
        <div class="title-icon">
                     <hr />
                 <h3 class="title"><span class="icon-folder2">
                 
      <img id="Kampanyaİcon" style="height:24px; width:24px; margin-top:0px;" src="image/galeri/credit-card.png" /></span>Kampanyalar<a name="giris"></a></h3>
                                   <hr />

                                    <div class="Hakkında">
         <input  runat="server" name="name" type="text" class="validate[required,custom[onlyLetter],length[0,100]] feedback-input" placeholder="Kampanya Adı" id="txt_Kampanya_Adı" />
     <textarea maxlength="260" runat="server" class="deneme" type="text"  id="txt_kampanya_Bilgisi" placeholder="Kampanya Bilgisi"></textarea>
                          
                  </div>
                                   
				    	</div>
        </div>
       <button runat="server"  onserverclick="btn_KampanyaOlustur_ServerClick"  id="btn_KampanyaOlustur" class="btn btn-outline-secondary" type="button" >Oluştur</button>
        <button runat="server" visible="false" onserverclick="btn_Güncelle_ServerClick" id="btn_Güncelle" class="btn btn-outline-secondary" type="button" >Güncelle</button>
           <button runat="server" style="width:183px;" visible="false" onserverclick="btn_Aktif_Pasif_ServerClick" id="btn_Aktif_Pasif" class="btn btn-outline-secondary" type="button" >Kampanyayı Aktifleştir</button>

        <table>
  <thead>
    <tr>
         <th scope="col" >İD</th>
     <th scope="col" >KAMPANYA ADI</th>
        <th scope="col">KAMPANYA BİLGİSİ</th>
        <th scope ="col">DÜZENLE</th>
        <th scope="col">AKTİF/PASİF</th>
        <th scope="col">SİL</th>
     </tr>
  </thead>
  <tbody>
   
        <asp:Repeater runat="server" ID="Kampanyalar_Repater"  OnItemCommand="Kampanyalar_Repater_ItemCommand">
                  <ItemTemplate>
    <tr>
         <td data-column="İD"> <%#Eval("id") %></td>
      <td data-column="KAMPANYA ADI"> <%#Eval("KampanyaAdı") %></td>
       <td data-column="KAMPANYA BİLGİSİ"> <%#Eval("KampanyaBilgisi") %></td>
       <td data-column="DÜZENLE"> 
       
          <asp:ImageButton  ID="Düzenle" Style="margin-left:30px; height:auto;width:auto; background-color: #FAFAFA;"  
              runat="server"   CommandName="DüzenleKampanya"   CommandArgument='<%#Eval("id")%>' img src="image/galeri/edit.jpg" />
         </td>

          <td data-column="Aktif/Pasif">           
          <asp:ImageButton Style="height:auto;width:auto; background-color: #FAFAFA; margin-left:27px;"  ID="Aktif_Pasif" 
              runat="server" CommandName="Aktif_Pasif" CommandArgument='<%#Eval("id")%>' Text="Sil" img src="image/galeri/Aktif.png" />
               </td>
       

        <td data-column="Sil">           
          <asp:ImageButton Style="margin-left:30px; height:auto;width:auto; background-color: #FAFAFA;"  ID="Sil" 
              runat="server" OnClientClick="return confirm('Silmek istediğinizden emin misiniz?')"  
              CommandName="SilKampanya" CommandArgument='<%#Eval("id")%>' Text="Sil" img src="image/galeri/Deleteİcon.jpg" />
               </td>
      
        </ItemTemplate>
              </asp:Repeater>
  </tbody>
</table>
        
    </form>
</asp:Content>
