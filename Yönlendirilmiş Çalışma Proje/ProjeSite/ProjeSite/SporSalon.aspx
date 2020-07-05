<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SporSalon.aspx.cs" Inherits="ProjeSite.SporSalonPencere" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  
   <link href="Content/css/bootstrap.min.css" rel="stylesheet" />
    <script src="Content/jquery-3.4.1.min.js"></script>
    <script src="Content/js/bootstrap.min.js"></script>
<%--<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>--%>
      <meta name="viewport" content="width=device-width, initial-scale=1,maximum-scale=1">
    <title></title>
</head>
<body>
    <form runat="server">
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
    
      <input class="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search" />
      <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>
   
  </div>
</nav>
    <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
        <div>
        </div>
   <%--     SLİDER--%>
     <div class="bd-example">
  <div id="carouselExampleCaptions" class="carousel slide" data-ride="carousel">
    <ol class="carousel-indicators">
      <li data-target="#carouselExampleCaptions" data-slide-to="0" class="active"></li>
      <li data-target="#carouselExampleCaptions" data-slide-to="1"></li>
      <li data-target="#carouselExampleCaptions" data-slide-to="2"></li>
    </ol>
    <div class="carousel-inner">
      <div class="carousel-item active">
         <img src="image/galeri/931296_30d95e6919b6ed11ce584bef3b13e588_640x640.jpg"  class="d-block w-100" alt="..." /> 
        <div class="carousel-caption d-none d-md-block">
          <h5>First slide label</h5>
          <p>Nulla vitae elit libero, a pharetra augue mollis interdum.</p>
        </div>
      </div>
      <div class="carousel-item">
        <img src="image/Sporcu-Beslenme-Ust.jpg" class="d-block w-100" alt="...">
        <div class="carousel-caption d-none d-md-block">
          <h5>Second slide label</h5>
          <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
        </div>
      </div>
      <div class="carousel-item">
        <img src="image/931296_30d95e6919b6ed11ce584bef3b13e588_640x640.jpg"  class="d-block w-100" alt="...">
        <div class="carousel-caption d-none d-md-block">
          <h5>Third slide label</h5>
          <p>Praesent commodo cursus magna, vel scelerisque nisl consectetur.</p>
        </div>
      </div>
    </div>
    <a class="carousel-control-prev" href="#carouselExampleCaptions" role="button" data-slide="prev">
      <span class="carousel-control-prev-icon" aria-hidden="true"></span>
      <span class="sr-only">Previous</span>
    </a>
    <a class="carousel-control-next" href="#carouselExampleCaptions" role="button" data-slide="next">
      <span class="carousel-control-next-icon" aria-hidden="true"></span>
      <span class="sr-only">Next</span>
    </a>
  </div>
</div>

       <%-- YAZI KUTUSU--%>
        <div  style="margin-left:35px;" class="form-group">
  <label style="margin-top:50px;" for="comment">Spor Salonu Hakında:</label>
  <textarea style="width:450px;" class="form-control" rows="5" id="comment"></textarea>
  

            <asp:DataList ID="DataList" runat="server" RepeatColumns="4">
                <ItemTemplate>
 <div class="card" style="width: 18rem; margin-right: 95px;
    margin-top: 41px;">
      <p>
          <img src="CalisanFoto/<%#Eval("Resim") %>" style="margin-left:-14px;  width:243px; height:200px;"/>
      </p>
                      <%--  <img class="card-img-top" src=" <%#Eval("Resim") %>" >--%>
                        <div class="card-body">
                          
                            <h5 runat="server" id="lblCalisanGetir" class="card-title"><%#Eval("Calisan_Ad") %>&nbsp; <%#Eval("Calisan_Soyad") %></h5>
                            
                            <p runat ="server" style="height:230px;" class="card-text">
                             <%#Eval("Calisan_Hakkinda") %></p>
                        </div>
                        
                    <%--    <ul class="list-group list-group-flush">
                            <li class="list-group-item">    <%#Eval("Calisan_Hakkin") %></li>
                            <li class="list-group-item">Dapibus ac facilisis in</li>
                            <li class="list-group-item">Vestibulum at eros</li>
                        </ul>--%>
                        <div class="card-body">
                            <a href="#" class="card-link"><%#Eval("E_mail") %></a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:DataList>


           
              
                  

    <%--    CARD--%>
      </form>
    
</body>
</html>
