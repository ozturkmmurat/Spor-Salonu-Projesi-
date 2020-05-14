<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MasterCalisanlar.aspx.cs" Inherits="ProjeSite.MasterCalisanlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

 
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1"><link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">
<link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/foundation/6.3.0/css/foundation.min.css'>
<link rel='stylesheet' href='https://cdn.materialdesignicons.com/1.8.36/css/materialdesignicons.min.css'><link rel="stylesheet" href="Fotograf.css">
    
       <script src="Adminpanel.js" type="text/javascript"></script>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
   <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Open+Sans:400,600,700"/>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>

     
        <script src="jquery/jquery.js"></script>
        <link href="Content/css/bootstrap.min.css" rel="stylesheet" />
           <script src="Adminpanel.js" type="text/javascript"></script>
      <link rel="stylesheet" href="css/style.css">
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.1.0/css/all.css" integrity="sha384-lKuwvrZot6UHsBSfcMvOkWwlCMgc0TaWr+30HWe3a4ltaBwTZhyTEggF5tJv8tbt" crossorigin="anonymous">
    </head>
    <style>

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
    /*padding: 13px 13px 13px 0px;*/
    margin-bottom: 10px;
    width: 100%;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    -ms-box-sizing: border-box;
    box-sizing: border-box;
    border: 3px solid rgba(0,0,0,0);
}

        textarea {
    width: 100%;
    height: 150px;
    line-height: 150%;
    resize: vertical;
}
        textarea {
    overflow: auto;
    vertical-align: top;
}
.file {
  visibility: hidden;
  position: absolute;
            top: 704px;
            left: 0px;
        }


/*
 * Styles for demo only
 */



h4 {
  color: #a990cc;
  font-size: 24px;
  font-weight: 400;
  text-align: center;
  margin: 0 0 35px 0;
}

.btn.btn-primary {
  background-color: #5c4084;
  border-color: #5c4084;
  outline: none;
}
.btn.btn-primary:hover {
  background-color: #442f62;
  border-color: #442f62;
}
.btn.btn-primary:active, .btn.btn-primary:focus {
  background-color: #684895;
  border-color: #684895;
}



body{
  /*background-color:#add8e6;  */
}


.alert{
  text-align:center;
}

#blah{  
  max-height:256px;
  height:auto;
  width:auto;
  display:block;
  margin-left: auto;
   margin-right: auto;
  padding:5px;
}
#img_contain{
  border-radius:5px;
  /*  border:1px solid grey;*/
  margin-top:20px;
  width:auto;  
}

.imgInp{  
  width:150px;
  margin-top:10px;
  padding:10px;
  background-color:#d3d3d3;  
}
.loading{
   animation:blinkingText ease 2.5s infinite;
}
@keyframes blinkingText{
    0%{     color: #000;    }     
    50%{   color: #transparent; }
    99%{    color:transparent;  }
    100%{ color:#000; }
}
.custom-file-label{
  cursor:pointer;
}

/************CREDITS**************/
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
.credit a{
  color:gray;
}
.credit a:hover{
  color:black;  
}
.credit a:visited{
  color:MediumPurple;
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
    <div class="js--image-preview"></div>
  <div class="upload-options">
      <label>
          
        <asp:FileUpload runat="server"  onserverclick="fotografYukle_Click" name="myFile" id="FileUpload1" type="File" class="image-upload" accept="image/*" />
      </label>
    </div>
  </div>
      <%--      -----------%>

      <p class="name">
     <p style="background-image: url(http://rexkirby.com/kirbyandson/images/name.svg);
    background-size: 30px 30px;
    background-position: 11px 8px;
    background-repeat: no-repeat;">
          <input  runat="server" name="name" type="text" class="validate[required,custom[onlyLetter],length[0,100]] feedback-input" placeholder="Ad" id="CalisanAdi" />
     </p>
       
      </p>
        <p> 
    <input  runat="server" name="name" type="text" class="validate[required,custom[onlyLetter],length[0,100]] feedback-input" placeholder="Soyad" id="CalisanSoyadi" />
 </p>
      <p  class="email">
        <input runat="server" name="email" type="text" class="validate[required,custom[email]] feedback-input" id="email_Calisan" placeholder="Email" />
      </p>
      
      <p class="text">
        <textarea runat="server" name="text" class="validate[required,length[6,300]] feedback-input" id="hakkinda_Calisan" placeholder="Çalışan Hakkında"></textarea>
      </p>

      
      
  
        <div class="form-group">  

         <button  runat="server"  onserverclick="CalisanOlustur_Click" id="CalisanOlustur" type="button" class="btn btn-outline-secondary">Oluştur</button>
      <button type="button" class="btn btn-outline-secondary">Düzenle</button>
      <button type="button" class="btn btn-outline-secondary">Sil</button>
       
             
             <asp:Label ID="lblMesaj" runat="server"></asp:Label>
       
             
             </div>
           

    
        </div>
    </div>


    </div>
  </div>
    <script src="Fotograf.js"></script>
   </form>
</asp:Content>
