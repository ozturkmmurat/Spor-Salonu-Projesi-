<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MasterCalisanlarGuncelle.aspx.cs" Inherits="ProjeSite.MasterCalisanlar" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    
    <head>
     
        
    
        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
      <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>

        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">
        <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/foundation/6.3.0/css/foundation.min.css'>
        <link rel='stylesheet' href='https://cdn.materialdesignicons.com/1.8.36/css/materialdesignicons.min.css'>
        <link rel="stylesheet" href="Fotograf.css">

        <script src="Adminpanel.js" type="text/javascript"></script>
        <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
        <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Open+Sans:400,600,700" />
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>


        <script src="jquery/jquery.js"></script>
        <link href="Content/css/bootstrap.min.css" rel="stylesheet" />
        <script src="Adminpanel.js" type="text/javascript"></script>

        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.1.0/css/all.css" integrity="sha384-lKuwvrZot6UHsBSfcMvOkWwlCMgc0TaWr+30HWe3a4ltaBwTZhyTEggF5tJv8tbt" crossorigin="anonymous">
    </head>
    <style>

        td {
     line-height: 20px; 
    font-weight: 300;
    padding: 0 10px;
}
        #form-div {
    background-color: rgba(72,72,72,0.1);
    padding-left: 35px;
    padding-right: 35px;
    padding-top: 35px;
    padding-bottom: 50px;
    width: 450px;
    margin: auto;
    -moz-border-radius: 7px;
    -webkit-border-radius: 7px;
    margin-bottom: 20px;
}
        p {
    margin: 0 0 20px;
    line-height: 1.5;
}
        img {
    vertical-align: middle;
    border:0;
}
       
        .input-group {
    position: relative;
  
    border-collapse: separate;
}
        #form-main {
    width: 100%;
    float: left;
    padding-top: 0px;
    margin-left: -1.47rem;
}
        #form-div {
    background-color: rgba(72,72,72,0.1);
    padding-left: 35px;
    padding-right: 35px;
    padding-top: 35px;
    padding-bottom: 50px;
    width: 450px;
    margin:auto;
    -moz-border-radius: 7px;
    -webkit-border-radius: 7px;
    margin-bottom: 20px;
}
        #name {
    background-image: url(http://rexkirby.com/kirbyandson/images/name.svg);
    background-size: 30px 30px;
    background-position: 11px 8px;
    background-repeat: no-repeat;
}
        
        p {
    margin: 0 0 20px;
    line-height: 1.5;
}
        .credit{    
  font: 14px "Century Gothic", Futura, sans-serif;
  font-size:12px;  
  color:#3d3d3d;
  text-align:left;
  margin-top:10px;
  margin-left:auto;
  margin-right:auto;
  text-align:center;
}
        #email {
    background-image: url(http://rexkirby.com/kirbyandson/images/email.svg);
    background-size: 30px 30px;
    background-position: 11px 8px;
    background-repeat: no-repeat;
}
        #comment {
    background-image: url(http://rexkirby.com/kirbyandson/images/comment.svg);
    background-size: 30px 30px;
    background-position: 11px 8px;
    background-repeat: no-repeat;
}
        .feedback-input {
            color: #3c3c3c;
            font-family: Helvetica, Arial, sans-serif;
            font-weight: 500;
            font-size: 18px;
            border-radius: 0;
            line-height: 22px;
            background-color: #fbfbfb;
        }
 .credit a{
  color:gray;
}
.credit a:hover{
  color:black;  
}
.credit a:visited{
  color:MediumPurple;}

.feedback-input {
    color: #3c3c3c;
    font-family: Helvetica, Arial, sans-serif;
    font-weight: 500;
    font-size: 18px;
    border-radius: 0;
    line-height: 22px;
    background-color: #fbfbfb;
    /* padding: 13px 13px 13px 0px; */
    margin-bottom: 10px;
    width: 100%;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    -ms-box-sizing: border-box;
    box-sizing: border-box;
    border: 3px solid rgba(0,0,0,0);
}
form input, form textarea, form select {
    width: 100%;
    display: block;
    border: solid 1px #dde;
    padding: .5em;
}







    </style>



 
     

       
 

    <div class="card-body">
    <div class="input-group">
        <%-----------------------%>
         
<div id="form-main">
  <div   id="form-div">
   
  <form id="form1" runat="server" enctype="multipart/form-data">
      
      <%--  Fotoğraf--%>
      
      <div style="padding:0px;" class="box">
         
 <%--   <div class="js--image-preview"></div>--%>
           <img style="margin:auto;" runat="server" id="FotoCalisan" class="js--image-preview"/>
             
<%--       class="js--image-preview"--%>

  <%--  <div class="js--image-preview"></div>--%>
  <div class="upload-options">
      <label>
        <asp:FileUpload runat="server"  onserverclick="fotografYukle_Click" name="myFile" id="FileUpload1" type="File" class="image-upload" accept="image/*" />
      </label>
    </div>
  </div>
         
      <%--      -----------%>
      
      <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>   
      <p class="name">
           <p> 
    <input  runat="server" name="name" type="text" class="validate[required,custom[onlyLetter],length[0,100]] feedback-input" placeholder="Tc" id="Calisan_Tc" />
 </p>
          
     <p>

          <input  runat="server" name="name" type="text" class="validate[required,custom[onlyLetter],length[0,100]] feedback-input" placeholder="Ad" id="CalisanAdi" />
     </p>
       
      </p>
        <p> 
    <input  runat="server" name="name" type="text" class="validate[required,custom[onlyLetter],length[0,100]] feedback-input" placeholder="Soyad" id="CalisanSoyadi" />
 </p>
       <p> 
    <input  runat="server" name="name" type="text" class="validate[required,custom[onlyLetter],length[0,100]] feedback-input" placeholder="Tel" id="Calisan_Tel" />
 </p>



       <asp:TextBox  ID="Txt_Calisan_DogumTarih" CssClass="validate[required,custom[onlyLetter],length[0,100]] feedback-input"  runat="server" placeholder="Doğum Tarihi: dd.MM.yyyy"></asp:TextBox>
      <ajaxToolkit:CalendarExtender ID="CalendarExtender1"   Format="dd.MM.yyyy" TargetControlID="Txt_Calisan_DogumTarih" runat="server" CssClass="Calender" />
  
      
      <ajaxToolkit:FilteredTextBoxExtender ID="txt_YazıGirisAyarla" Enabled="True" 
          FilterType="Custom" TargetControlID="Txt_Calisan_DogumTarih" ValidChars=".1234567890"  runat="server" />
   
       <p> 
    <input  runat="server" name="name" type="text" class="validate[required,custom[onlyLetter],length[0,100]] feedback-input" placeholder="Adres" id="Calisan_Adres" />
 </p>

      <p  class="email">
        <input runat="server" name="email" type="text" class="validate[required,custom[email]] feedback-input" id="email_Calisan" placeholder="Email" />
      </p>
      
       <p>
          <asp:DropDownList placeholder="Branş Giriniz" runat="server" ID="List_Brans">
              <asp:ListItem>Diyetisyen</asp:ListItem>
              <asp:ListItem>Plates</asp:ListItem>
              <asp:ListItem>Yoga</asp:ListItem>
              <asp:ListItem>Fitness Eğitmeni</asp:ListItem>
              <asp:ListItem>Macfit Eğitmeni</asp:ListItem>
              <asp:ListItem>Yüzme</asp:ListItem>
          </asp:DropDownList>


      </p>

      <p class="text">
        <textarea runat="server" maxlength="260" style="height:150px; margin-left:0px;" name="text" class="validate[required,length[6,300]] feedback-input" id="hakkinda_Calisan" placeholder="Çalışan Hakkında"></textarea>
      </p>

       <div id="the-count">
    <span id="current">0</span>
    <span id="maximum">/ 260</span>
  </div>
      
  
        <div class="form-group">  

         <button  runat="server"  style="margin-left:0px;" onserverclick="CalisanDüzenle_Click" id="CalisanOlustur" type="button" class="btn btn-outline-secondary">Güncelle</button>
    
          <%--   <button runat="server"  onserverclick="CalisanDüzenle_Click" id="CalisanOlustur"  >  Güncelle </button> --%>

            <%-- <asp:Label ID="lblMesaj" runat="server" Text="a"></asp:Label>
            --%>
       
             
             <asp:Label ID="lbl_CalisanidGetir" runat="server" Text="Label"></asp:Label>
       
             
             </div>
           

    
        </div>
    </div>


    </div>
  </div>


   <%-- SCRİPT BÖLÜMÜ--%>  

    <script src="Fotograf.js"></script>
    <script src="Js%20Bolumu/HarfSayaci.js"></script>
   </form>
</asp:Content>
