<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AktiviteOlustur.aspx.cs"EnableViewState="false" ViewStateMode="Disabled" EnableEventValidation="false" Inherits="ProjeSite.MasterSporBolumuAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <header>
        

         
 <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Open+Sans:400,600,700" />    
       <script src=jquery-1.7.2.min.js type=text/javascript></script>
        <meta name="viewport" content="width=device-width, initial-scale=1,maximum-scale=1">
       
        <link rel='stylesheet' href='https://cdn.materialdesignicons.com/1.8.36/css/materialdesignicons.min.css'>
        <link rel="stylesheet" href="Fotograf.css">
        <script src="Js%20Bolumu/HarfSayaci.js"></script>
        <script src="Adminpanel.js" type="text/javascript"></script>
        <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
        <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Open+Sans:400,600,700" />
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>

        <link href="Css/CalisanOlustur.css" rel="stylesheet" />
        <script src="jquery/jquery.js"></script>
        <link href="Content/css/bootstrap.min.css" rel="stylesheet" />
        <script src="Adminpanel.js" type="text/javascript"></script>

        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.1.0/css/all.css" integrity="sha384-lKuwvrZot6UHsBSfcMvOkWwlCMgc0TaWr+30HWe3a4ltaBwTZhyTEggF5tJv8tbt" crossorigin="anonymous">
    </header> 
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
body{
    min-height:150em;
}




    </style>
    
    <form runat="server" enctype="multipart/form-data" id="HakkındaBolumu">
        <div class="card-body">
    <div class="input-group">
        <%-----------------------%>      
<div id="form-main">
  <div   id="form-div">


         <%--  Fotoğraf--%>
        <div style="padding:0px;" class="box">
    <div class="js--image-preview"></div>
  <div class="upload-options">
      <label>
      
        <asp:FileUpload runat="server"  onserverclick="fotografYukle_Click" name="myFile" id="FileUpload1" type="File" class="image-upload"  accept="image/*" />
      </label>
    </div>
  </div>
      <%--      -----------%>

      
   
        <div style="margin-top:15px;" class="listing-description">
            <asp:Label runat="server">Spor Bölümü Adı:</asp:Label>
        <asp:DropDownList style="margin:auto;" runat="server"   RepeatColumns="10" ID="SporBolumListesi" >
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
           </div>
      <button style="margin-top:10px; margin-left:auto;" runat="server" id="btnSporBolumuOlustur"  type="button" onserverclick="btnSporBolumuOlustur_ServerClick" class="btn btn-outline-secondary">Oluştur</button>

      
         </div>
    </div>
        </div>
        </div>
           
      <%--  Listeye Sınır koyma--%>
       <%-- <script>
        var element = document.querySelector('#ContentPlaceHolder2_deneme');

            element.addEventListener('mousedown', function () {
                this.size = 5;
            });
            element.addEventListener('change', function () {
                this.blur();
            });
            element.addEventListener('blur', function () {
                this.size = 0;
            });

        </script>--%>
           <script src="Js%20Bolumu/Fotoekle.js"></script>
        </form>
          
</asp:Content>
