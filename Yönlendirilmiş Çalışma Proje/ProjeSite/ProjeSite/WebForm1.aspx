
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ProjeSite.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <link href="Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="Content/jquery-3.4.1.min.js"></script>
    <script src="Content/js/bootstrap.min.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    

</head>

    <title></title>
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

       <%--   Slider değişen fotoğraf --%>
 
        <div class="carousel-inner">
      <div class="carousel-item active">
      <img class="d-block w-100" src="image/931296_30d95e6919b6ed11ce584bef3b13e588_640x640.jpg"  /> alt="İlk slide  fotoğrafı">
    </div>
   
      <div class="carousel-item">
      <img class="d-block w-100" src="image/spor-beslenme-370x228.jpg" /> alt="İkinci slide fotoğrafı">
    </div>
  
      <div class="carousel-item">
      <img class="d-block w-100" src="image/Sporcu-Beslenme-Ust.jpg" /> alt="Üçüncü slide fotoğrafı">
    </div>
 
      </div>
  <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>

    <%--Card  Açıklama --%>

    <div class="card-deck">
  <div class="card">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <img src="image/takipedin.jpg"class="card-img-top" alt="..."> <div class="card-body">
         <h5 class="card-title">Hızlı Takip</h5>
          <p class="card-text">Ölçüm değerlerinizi&nbsp; ve&nbsp; Beslenme Spor Programlarınızı rahatlıkla takip edebilirsiniz.
    </div>
    <div class="card-footer">
      <small class="text-muted">Last updated 3 mins ago</small>
    </div>
  </div>
  <div class="card">
    &nbsp;
    <img src="image/spor.jpg"class="card-img-top" > 
    <div class="card-body">
    <h5 class="card-title">Hızlı Gelişim </h5>
      <p class="card-text">Ölçümlerinizi ve Beslenme Programınızı istatiksel olarak görüp kendinizi daha iyi bir şekilde geliştirebilirsiniz.</p>
    </div>
    <div class="card-footer">
      <small class="text-muted">Last updated 3 mins ago</small>
    </div>
  </div>
  <div class="card">
    <img src="image/beslenmetakip.jpg"  class="card-img-top"style ="height:180px;" >
    <div class="card-body">
      <h5 class="card-title"style = margin-top:-40px;>Beslenme Ve Spor</h5>
      <p class="card-text"style = margin-top:-10px;>Beslenme ve Spor Programınızdan anında haberdar olun.</p>
    </div>
    <div class="card-footer" >
      <small class="text-muted">Last updated 3 mins ago</small>
    </div>
  </div>
</div>

    </body>
</html>
