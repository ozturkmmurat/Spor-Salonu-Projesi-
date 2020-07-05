<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminCalismaSaatleri.aspx.cs" Inherits="ProjeSite.AdminCalismaSaatleri" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
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
           <div class="listing-description">
        <div class="title-icon">
                
                 <h3 class="title"><span class="icon-folder2">
               
      <img id="Cs_Calisma_İcon" style="height:24px; width:24px; margin-top:0px;" src="image/galeri/credit-card.png" /></span>Hafta İçi Çalışma Saatleri<a name="giris"></a></h3>
             <hr />
            <div>
  <asp:TextBox type="time" style="width:auto; float:left;" Text="" id="Cs_Baslangic" data-time-format="H:i" data-step="15" data-min-time="10:00" data-max-time="18:00" data-show-2400="true" runat="server"></asp:TextBox> 
  <asp:TextBox type="time" style="width:auto;"  id="Cs_Bitis" Text="" data-time-format="H:i" data-step="15" data-min-time="10:00" data-max-time="18:00" data-show-2400="true" runat="server"></asp:TextBox> 
            </div>
       <%--  --%>
          </div>
        </div>
                   <hr />
   <%--  Hafta Sonu Çalışma Saatleri--%>
    <div class="listing-description">
        <div class="title-icon">
                  
                 <h3 class="title"><span class="icon-folder2">
               
      <img id="Haftasonu_Cs_icon" style="height:24px; width:24px; margin-top:0px;" src="image/galeri/credit-card.png" /></span>Cumartesi Günü Çalışma Saatleri<a name="giris"></a></h3>
                <hr />
            <div>
                   <asp:DropDownList runat="server" OnSelectedIndexChanged="haftaSonu_Cmt_List_SelectedIndexChanged"  AutoPostBack="true"  ID="haftaSonu_Cmt_List">
                    <asp:ListItem>Kapalı</asp:ListItem>
                    <asp:ListItem>Açık</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox style="width:auto; float:left;" type="time"   id="HaftaSonu_Cs_BaslangicSaat" data-time-format="H:i" data-step="15" data-min-time="10:00" data-max-time="18:00" data-show-2400="true" runat="server" Visible="false"></asp:TextBox> 
             
  <asp:TextBox  style="width:auto;" type="time"  id="HaftaSonu_Cs_BitisSaat"  data-time-format="H:i" data-step="15" data-min-time="10:00" data-max-time="18:00" data-show-2400="true" runat="server" Visible="False"></asp:TextBox> 
            </div>
 
<h3 class="title"><span class="icon-folder2">
 <img id="Haftasonu_Pz_icon" style="height:24px; width:24px; margin-top:0px;" src="image/galeri/credit-card.png" /></span>Pazar Günü Çalışma Saatleri<a name="giris"></a></h3>
          
                <hr />
            <div>
                   <asp:DropDownList runat="server" OnSelectedIndexChanged="HaftaSonu_Pzr_List_SelectedIndexChanged" AutoPostBack="true" ID="HaftaSonu_Pzr_List">
                    <asp:ListItem>Kapalı</asp:ListItem>
                    <asp:ListItem>Açık</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox style="width:auto; float:left;" type="time"  id="HaftaSonu_Pz_BaslangicSaat" data-time-format="H:i" data-step="15" data-min-time="10:00" data-max-time="18:00" data-show-2400="true" runat="server" Visible="False"></asp:TextBox> 
             
  <asp:TextBox  style="width:auto;" type="time"  id="HaftaSonu_Pz_BitisSaat" data-time-format="H:i" data-step="15" data-min-time="10:00" data-max-time="18:00" data-show-2400="true" runat="server" Visible="false"></asp:TextBox> 
            </div>
 


              </div>
        </div>
           <button  runat="server" onserverclick="CalismaSaatiOlustur_ServerClick" id="CalismaSaatiOlustur" type="button" class="btn btn-outline-secondary">Oluştur</button>
           <button  runat="server" onserverclick="CalismaSaatiGuncelle_ServerClick" id="CalismaSaatiGuncelle" type="button" class="btn btn-outline-secondary">Güncelle</button>

        </form>
</asp:Content>

