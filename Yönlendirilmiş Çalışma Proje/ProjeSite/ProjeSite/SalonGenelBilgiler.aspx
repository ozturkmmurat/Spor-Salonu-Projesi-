<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SalonGenelBilgiler.aspx.cs"EnableViewState="false" ViewStateMode="Disabled" EnableEventValidation="false" Inherits="ProjeSite.SalonGenelBilgiler" %>

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
    <form runat="server" enctype="multipart/form-data" id="HakkındaBolumu">

           <%--<asp:ScriptManager ID="ScriptManager1" EnableScriptGlobalization="true" runat="server"></asp:ScriptManager>   --%>
        <asp:ScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server"></asp:ScriptManager>
	<div class="listing-description">
  
								<div class="title-icon">
                                    <hr />
									<h3 class="title"><span class="icon-folder2">
                                        <img id="Hakkındaİcon" style ="height:24px; width:24px;" src="image/galeri/Hakkındaicon.jpg" /></span>Hakkında<a name="giris"></a></h3>
                                   <hr />
                                    <div class="Hakkında">

                                        <asp:TextBox id="txt_Hakkimizda" TextMode="MultiLine" MaxLength="260"  runat="server" placeholder="Hakkımızda Yazısı Giriniz"/>
                            <%--             <textarea runat="server" style="width:95%;" class="form-control" rows="5" id="txt_Hakkimizda"></textarea>--%>
                                    </div>
                                   
								</div>
        </div>
      <div id="the-count">
    <span id="current">0</span>
    <span id="maximum">/ 260</span>
  </div>
       
        <div class="form-group">  

       <button runat="server" onserverclick="Hakkımızda_ServerClick" id="Hakkımızda" type="button" class="btn btn-outline-secondary">Oluştur</button>
       <button runat="server" onserverclick="HakkımızdaGüncelle_ServerClick"  id="HakkımızdaGüncelle" type="button"  class="btn btn-outline-secondary">Güncelle </button>                                  
  

       
             
             </div>
     
                                     
      <%--<%--<%--<%--<%--  <div class="listing-description">
								<div class="title-icon">
                                    <hr />
									<h3 class="title"><span class="icon-folder2">
                                        <img id="Aktivitelerİcon"  src="image/galeri/etiket.jpg" /></span>Aktiviteler<a name="giris"></a></h3>
                                   <hr />
                                   
                                    <asp:DropDownList ID="DropDownList_Aktiviteler"  runat="server"    BorderColor="#999999" ForeColor="#666666" RepeatColumns="10" OnSelectedIndexChanged="CheckBox_Aktivite_Secilenler">
                                        <asp:ListItem>Aerobik</asp:ListItem>
                                        <asp:ListItem>Aikido</asp:ListItem>
                                        <asp:ListItem>Aqua Gym</asp:ListItem>
                                        <asp:ListItem>Bisiklet</asp:ListItem>
                                        <asp:ListItem>Boks</asp:ListItem>
                                        <asp:ListItem>BootCamp</asp:ListItem>
                                        <asp:ListItem>Bosu Training</asp:ListItem>
                                        <asp:ListItem>Cardio</asp:ListItem>
                                        <asp:ListItem>Circuit Training</asp:ListItem>
                                        <asp:ListItem>Crossfit</asp:ListItem>
                                        <asp:ListItem>Crosstraining</asp:ListItem>
                                        <asp:ListItem>Crunch</asp:ListItem>
                                        <asp:ListItem>Dans</asp:ListItem>
                                        <asp:ListItem>Dart</asp:ListItem>
                                        <asp:ListItem>Express Abs</asp:ListItem>
                                        <asp:ListItem Value="Fatburning">FatBurning</asp:ListItem>
                                        <asp:ListItem>Fitness</asp:ListItem>
                                        <asp:ListItem>Fonksiyonel Antrenman</asp:ListItem>
                                        <asp:ListItem>Gym Stick</asp:ListItem>
                                        <asp:ListItem>Jimnastik</asp:ListItem>
                                        <asp:ListItem>Judo</asp:ListItem>
                                        <asp:ListItem>Kangoo</asp:ListItem>
                                        <asp:ListItem>Karaoke</asp:ListItem>
                                        <asp:ListItem>Karate</asp:ListItem>
                                        <asp:ListItem>Kickboks</asp:ListItem>
                                        <asp:ListItem>Kinesis</asp:ListItem>
                                        <asp:ListItem>Koşu</asp:ListItem>
                                        <asp:ListItem>Masa Tenisi</asp:ListItem>
                                        <asp:ListItem>Masaj</asp:ListItem>
                                        <asp:ListItem>Medikal Fitness</asp:ListItem>
                                        <asp:ListItem>Pilates</asp:ListItem>
                                        <asp:ListItem>Pilates Reforme</asp:ListItem>
                                        <asp:ListItem>Poligonlar</asp:ListItem>
                                        <asp:ListItem>PT [Özel Ders]</asp:ListItem>
                                        <asp:ListItem>Sauna</asp:ListItem>
                                        <asp:ListItem>Smart Steching</asp:ListItem>
                                        <asp:ListItem>Smart Stengthing</asp:ListItem>
                                        <asp:ListItem>Spinning</asp:ListItem>
                                        <asp:ListItem>Step</asp:ListItem>
                                        <asp:ListItem>Streching</asp:ListItem>
                                        <asp:ListItem>Smart Stength</asp:ListItem>
                                        <asp:ListItem>Spinning</asp:ListItem>
                                        <asp:ListItem>Step</asp:ListItem>
                                        <asp:ListItem>Streching</asp:ListItem>
                                        <asp:ListItem>TaEbo</asp:ListItem>
                                        <asp:ListItem>Tenis</asp:ListItem>
                                        <asp:ListItem>Tırmanma Duvarı</asp:ListItem>
                                        <asp:ListItem>Tiyatro</asp:ListItem>
                                        <asp:ListItem>TRX Training</asp:ListItem>
                                        <asp:ListItem>Vücut Geliştirme</asp:ListItem>
                                        <asp:ListItem>WingChun</asp:ListItem>
                                        <asp:ListItem>Yoga</asp:ListItem>
                                        <asp:ListItem>Yüzme Havuzu</asp:ListItem>
                                        <asp:ListItem>Zumba</asp:ListItem>
                                             
                                     </asp:DropDownList>
                                          
                                    
                                        
                                      
                                          <%-- <asp:UpdatePanel ID="UpdatePanelAktiviteGüncelle" ChildrenAsTriggers="true" runat="server"  UpdateMode="Conditional">
                                          <ContentTemplate> --%>
                                    <%-- <button runat="server"  onserverclick="Aktiviteler_Olustur_ServerClick" id="Aktiviteler_Olustur" type="button"  class="btn btn-outline-secondary">Oluştur </button>                            
                                    <button runat="server" onserverclick="Aktiviteler_Güncelle_ServerClick" id="Aktiviteler_Güncelle" type="button"  class="btn btn-outline-secondary">Güncelle </button>                                  
                                           --%>
                        <%--  </ContentTemplate>
                                        <Triggers>--%>
                                        
                                      <%--      <asp:AsyncPostBackTrigger ControlID="Aktiviteler_Olustur" EventName="Click"  />
                                        </Triggers>
                                            </asp:UpdatePanel>--%>
                   <%--                 
								</div>
        </div>

          <table>
  <thead>
    <tr>
         <th scope="col" >İD</th>
     <th scope="col" >AKTİVİTELER</th>
         <th scope="col">DÜZENLE</th>
                <th scope="col">SİL</th> 
     </tr>
  </thead>
  <tbody>
 
          <asp:Repeater OnItemCommand="Datalist_Aktivite_ItemCommand"  ID="Datalist_Aktivite" runat="server">
                  <ItemTemplate>
    <tr>
         <td data-column="İD"> <%#Eval("id") %></td>
      <td data-column="AKTİVİTE"> <%#Eval("SporSalonu_Aktiviteler") %></td>
       <td data-column="DÜZENLE"> 
        <%--   <asp:UpdatePanel ID="UpdatePanelDeneme"  UpdateMode="Conditional" runat="server">
               <ContentTemplate> --%>
        <%--  <asp:ImageButton  ID="Düzenle" Style="height:auto;width:auto; background-color: #FAFAFA;"  
              runat="server"  CommandName="Düzenleme"   CommandArgument='<%#Eval("id")%>' img src="image/galeri/edit.jpg" />
         </td>--%>
        <%--<td data-column="Sil">           
          <asp:ImageButton Style="height:auto;width:auto; background-color: #FAFAFA;"  ID="Sil" 
              runat="server" OnClientClick="return confirm('Silmek istediğinizden emin misiniz?')"  
              CommandName="Sil" CommandArgument='<%#Eval("id")%>' Text="Sil" img src="image/galeri/Deleteİcon.jpg" />
               </td>
                   
<%--                     </ContentTemplate>
        </asp:UpdatePanel>--%>
      <%--  </ItemTemplate>
              </asp:Repeater>
  </tbody>
</table>
        <asp:Label ID="lbl_Ozellikler" runat="server" Text="Label"></asp:Label>
        <div class="form-group">  --%>
 
            <%-- </div>--%>



    <%--    ÖZELLİKLER BÖLÜMÜ--%>
   <%--     <asp:Label ID="lbl_Ozelliklerİd" runat="server" Text="Label"></asp:Label>--%>
        <%-- <div class="listing-description">
								<div class="title-icon">
                                    <hr />
									<h3 class="title"><span class="icon-folder2">
                                        <img id="Ozelliklerİcon"  src="image/galeri/etiket.jpg" /></span>Özellikler<a name="giris"></a></h3>
                                   <hr />
                                   
                                 
                                    <asp:DropDownList  ID="Ozellikler_DropdownList" runat="server"   BorderColor="#999999" ForeColor="#666666" RepeatColumns="10" OnSelectedIndexChanged="Ozellikler_DropdownList_SelectedIndexChanged">
            <asp:ListItem>Kilitli Dolap</asp:ListItem>                                             
            <asp:ListItem>Duş Kabini</asp:ListItem>
            <asp:ListItem>Sauna</asp:ListItem>
            <asp:ListItem>Kafe</asp:ListItem>
            <asp:ListItem>Otopark (Ücretli)</asp:ListItem>
            <asp:ListItem>Ücretsiz</asp:ListItem>
            <asp:ListItem>Protein Bar</asp:ListItem>
            <asp:ListItem>Kapalı Havuz</asp:ListItem>
            <asp:ListItem>Buhar Odası</asp:ListItem>
            <asp:ListItem>Metroya Yakın</asp:ListItem>
            <asp:ListItem>Durağa Yakın</asp:ListItem>
            <asp:ListItem>Metrobüse Yakın</asp:ListItem>
            <asp:ListItem>Kafe</asp:ListItem>
            <asp:ListItem></asp:ListItem>                
            </asp:DropDownList>--%>
        


            <%--<button runat="server"  onserverclick="Btn_Ozellik_Olustur_ServerClick" id="Btn_Ozellik_Olustur" type="button"  class="btn btn-outline-secondary">Oluştur </button>
        <%-- <asp:UpdatePanel ID="UpdatePanel1" runat="server">--%>
                                      <%--  <ContentTemplate>--%>
<%--          <button runat="server"  onserverclick="Btn_Ozellik_Güncelle_ServerClick" id="Btn_Ozellik_Güncelle" type="button"  class="btn btn-outline-secondary">Güncelle </button>--%>
<%-- </ContentTemplate> 
 </asp:UpdatePanel>--%>
          <%--  </div>
             </div>
       
             <table>
  <thead>
    <tr>
         <th scope="col" >İD</th>
     <th scope="col" >ÖZELLİKLER</th>
         <th scope="col">DÜZENLE</th>
                <th scope="col">SİL</th> 
     </tr>
  </thead>
  <tbody>--%>
           
      
    <%--  <asp:Label ID="lblDeneme"  runat="server"  ></asp:Label>       
      <asp:Repeater   OnItemCommand="Ozellikler_Repater_ItemCommand"  ID="Ozellikler_Repater" runat="server">    
      
              <ItemTemplate>                 

         <td data-column="İD"> <%#Eval("id") %></td>
      <td data-column="ÖZELLİKLER"> <%#Eval("SporSalon_Ozellikler") %></td>
       <td data-column="DÜZENLE">
      
       
           <%--<asp:UpdatePanel  ID="updatepaneldeneme" CommandName="UpdatePanel" CommandArgument="'<%#Eval("id")%>'" runat="server">
     <ContentTemplate>--%>
       <%--   <asp:ImageButton  ID="DüzenleOzellikler"  Style="height:auto;width:auto; background-color: #FAFAFA;"  
              runat="server"  CommandName="DüzenlemeOzellikler"   CommandArgument='<%#Eval("id")%>' img src="image/galeri/edit.jpg" />
         </td>
       
        <td data-column="Sil">           
          <asp:ImageButton Style="height:auto;width:auto; background-color: #FAFAFA;"  ID="Sil" 
              runat="server" OnClientClick="return confirm('Silmek istediğinizden emin misiniz?')"  
              CommandName="SilOzellikler" CommandArgument='<%#Eval("id")%>' Text="Sil" img src="image/galeri/Deleteİcon.jpg" />--%>
          <%--  </ContentTemplate>
              </asp:UpdatePanel>--%> 
         <%--      </td>
       </tr>
                     
        </ItemTemplate>             
              </asp:Repeater>
          
       
  </tbody>
</table>--%>

                
          
        <script src="Js%20Bolumu/HarfSayaci.js"></script>
       
         </form>
</asp:Content>
