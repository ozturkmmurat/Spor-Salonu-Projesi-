<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPanelPersonelAyarları.aspx.cs" Inherits="ProjeSite.AdminPanelPersonelAyarları" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <link href="Adminpanel.css" rel="stylesheet" />
    <script type="Adminpanel.js"></script>
      <link href="Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="Content/jquery-3.4.1.min.js"></script>
    <script src="Content/js/bootstrap.min.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <nav class="navbar navbar-expand-lg navbar-light bg-light navbar navbar-dark bg-dark">
  <a class="navbar-brand" href="#">Anasayfa</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>

  <div class="collapse navbar-collapse" id="navbarSupportedContent">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item active">
        <a class="nav-link" href="#">Spor Salonları <span class="sr-only">(current)</span></a>
      </li>
      <li class="nav-item">
        <a class="nav-link" style ="color:#fff;"href="#">Uzaktan Eğitim</a>
      </li>
     
      <li class="nav-item">
        <a class="nav-link disabled"style ="color:#fff; href="#" tabindex="-1" aria-disabled="true">Hakkında</a>
      </li>
    </ul>
    <form class="form-inline my-2 my-lg-0">
      <input class="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search" />
      <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>
    </form>
  </div>
</nav>
    <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
  <ol class="carousel-indicators">
    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
  </ol>

  <div class="admin-panel clearfix">
  <div class="slidebar">
    <div class="logo">
      <a href=""></a>
    </div>
    <ul>
      <li><a href="AdminPanelPersonelAyarları.aspx" id="targeted">Personel - Ayarları</a></li>
      <li><a href="AdminPanelHakkında.aspx">Hakkımızda</a></li>
      <li><a href="#media">Slayt - Ayarları</a></li>
      <li><a href="#pages">Üye Listesi</a></li>
      <li><a href="#links">İletişim</a></li>
      <li><a href="#comments">F Sayfası</a></li>
      <li><a href="#widgets">H Sayfası</a></li>
      <li><a href="#plugins">G Sayfası</a></li>
    </ul>
  </div>
  <div class="main">

    <div class="mainContent clearfix">
      <div id="dashboard">
        <h2 class="header"><span class=""></span>Başlık</h2>
     
           <div class="card" style="width: 18rem;">
  <img src="..." class="card-img-top" alt="...">
  <div class="card-body">
    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
  </div>
</div>
           <p></p>
      

       </div>
       <div id="posts">
         <h2 class="header">Başlık</h2>
             <div class="monitor">
                
            </div>     
       </div>
       <div id="media">
         <h2 class="header">Başlık</h2>

         
       </div>
       <div id="pages">
         <h2 class="header">Başlık</h2>
       </div>
       <div id="links">
         <h2 class="header">Başlık</h2>
       </div>
       <div id="comments">
         <h2 class="header">Başlık</h2>
       </div>
       <div id="widgets">
         <h2 class="header">Başlık</h2>
       </div>
       <div id="plugins">
         <h2 class="header">Başlık</h2>
       </div>
       <div id="users">
         <h2 class="header">Başlık</h2>
       </div>
       <div id="tools">
         <h2 class="header">Başlık</h2>
       </div>
       <div id="settings">
         <h2 class="header">Başlık</h2>
       </div>
     </div>
     <ul class="statusbar">
       <li><a href=""></a></li>
       <li><a href=""></a></li>

       <li class="logout"><a href="">Çıkış</a></li>
     </ul>
   </div>
</div>
 
        <div>
        </div>
    </form>
</body>
</html>
