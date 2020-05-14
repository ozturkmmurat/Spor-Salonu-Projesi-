
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="ProjeSite.AdminPanel" %>

<!DOCTYPE html>
<html lang="es">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Adminpanel.css" rel="stylesheet" />
    <script src="Adminpanel.js"></script>
  <meta charset="UTF-8">
  <title>Gestionamiento</title>
  <link rel="stylesheet" href="css/style.css">
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Open+Sans:400,600,700">
  <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.4.1/css/all.css" integrity="sha384-5sAR7xN1Nv6T6+dT2mhtzEpVJvfS3NScPQTrOxhwjIuvcA67KV2R5Jz6kr4abQsz" crossorigin="anonymous">

<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
   <script src="Adminpanel.js" type="text/javascript"></script>
  <link rel="stylesheet" href="css/style.css">



</head>
    


<body>
  <h1>Administrador</h1>
  <main>

    <input id="tab1" type="radio" name="tabs" checked>
    <label for="tab1">Çalışan Bilgileri </label>

    <input id="tab2" type="radio" name="tabs">
    <label for="tab2">İstatistik</label>

    <input id="tab3" type="radio" name="tabs">
    <label for="tab3">Üyeler</label>

    <input id="tab4" type="radio" name="tabs">
    <label for="tab4">Hakkımızda</label>

    <input id="tab5" type="radio" name="tabs">
    <label for="tab5">Ver módulos</label>

    <input id="tab6" type="radio" name="tabs">
    <label for="tab6">Videolarım  </label>

    <input id="tab7" type="radio" name="tabs" onclick="location.href = 'login.html';">
    

    <section id="content1">
      <p>
       Çalışan Bilgileri 
      </p>
       <div class="card-deck">
  <div class="card">
      <img src="image/anonim.jpg"  class="card-img-top" alt="...">
    <div class="card-body">
    <div class="input-group">
<%-----------------------%>
<div id="form-main">
  <div id="form-div">
    <form class="form" id="form1">
      
      <p class="name">
        <input name="name" type="text" class="validate[required,custom[onlyLetter],length[0,100]] feedback-input" placeholder="Name" id="name" />
      </p>
      
      <p class="email">
        <input name="email" type="text" class="validate[required,custom[email]] feedback-input" id="email" placeholder="Email" />
      </p>
      
      <p class="text">
        <textarea name="text" class="validate[required,length[6,300]] feedback-input" id="comment" placeholder="Comment"></textarea>
      </p>
      
      
    
         <button type="button" class="btn btn-outline-secondary">Secondary</button>
      <button type="button" class="btn btn-outline-secondary">Secondary</button>
      <button type="button" class="btn btn-outline-secondary">Secondary</button>
    </form>
  

<%-------------------------------%>
    <div class="card-footer">
      <small class="text-muted">Last updated 3 mins ago</small>
      </div>
      </div>
       </div>
<%------------------------------------%>
 <div class="form-group">
    <input type="file" name="img[]" class="file">
    <div class="input-group col-xs-12">
      <span class="input-group-addon"><i class="glyphicon glyphicon-picture"></i></span>
      <input type="text" class="form-control input-lg" disabled placeholder="Upload Image">
      <span class="input-group-btn">
        <button class="browse btn btn-primary input-lg" type="button"><i class="glyphicon glyphicon-search"></i> Browse</button>
      </span>
    </div>
  </div>

<%--------------------------------------------%>
    
    </div>
  </div>

    </section>

 
 

    <section id="content2">
      <table>
          <thead>
            <tr>
              <th colspan="4">Ölçüm Oran İstatistiği</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>
                <div class="divStatistics">
                  <img src="https://www.wearecontent.com/wp-content/uploads/2017/10/estadisticas-del-marketing-de-contenidos-2018.jpg" alt="imagen" />
                </div>
              </td>
            </tr>            
          </tbody>
        </table>
    </section>

    <section id="content3">
      <div id="content3_main">
        <div id="content3_links">
          <span style="text-decoration: none;
    color: #13b657;"> Üye Listesi</span>
          <p><a href="#">Página principal</a></p>
        </div>
      </div>
      <div id="content3_tables">
          <table>
               <tr>
              <th style ="background-color:#13b657b7;color: #fff;" colspan="3">Usuarios</th>
              <th class="yeniEkle" style="text-align: right; background-color:#13b657b7;">
                  
                   <asp:Button <a class="fas button fa-2x fa-plus" runat="server"  ID="yeniEkle" CssClass="yeniEkle" Onclick ="yeniEklee_Click"> </a></th>
                   </tr>
              </table>



        <table style="text-align: left;
    line-height: 40px;
    border-collapse: separate;
    border-spacing: 0;
    border: 2px solid #13b657b7;
    width: 100%;
    margin: 0 auto;
    margin-top: 20px;
    border-radius: .25rem;">

          <thead>
           <tr>
   
              <th scope="col" >İD</th>
                <th scope="col">AD</th>              
              <th scope="col">SOYAD</th>
              <th scope="col">DG.TRH</th>
                <th scope="col">ÜYELİK.S.BS</th>
                 <th scope="col">ÜYELİK.S.BTS</th>
              <th scope="col">ÜYELİK.KLN.SR</th>
                <th scope="col">E_MAİL</th>
                <th scope="col">TELEFON_NO</th>
               <th scope="col">DUZENLE</th>
            </tr>
          </thead>
          <tbody>
              <asp:Repeater ID="üyeListeİd" runat="server">
                  <ItemTemplate>  <tr>
              <td scope="col"><%#Eval("id") %></td>
            <td ><%#Eval("Ad") %></td>
             <td scope="col" ><%#Eval("Soyad") %></td>          
             <td style="-webkit-line-clamp: 3" scope="col"><%#Eval("Dogum_Tarihi") %></td>
               <td scope="col"><%#Eval("Uyelik_Suresibaslangic") %></td>
             <td scope="col"><%#Eval("Uyelik_Suresibitis") %></t>
            <td scope="col"><%#Eval("Uyelik_Kalansüre") %></td>
              <td scope="col"><%#Eval("E_mail") %></td>
            <td scope="col"><%#Eval("Telefon_No") %></td>
                      <td>
                <i class="far button fa-2x fa-edit"></i>
                <i class="far button fa-2x fa-trash-alt"></i>
              </td>

            </tr>  

                  </ItemTemplate>
              </asp:Repeater>
      
          </tbody>
        </table>
        <table>
             <tr>
              <th  style ="background-color:#13b657b7;color: #fff;" colspan="3">Grupos</th>
              <th style="text-align: right; background-color:#13b657b7;"><i class="fas button fa-2x fa-plus"></i></th>
            </tr>
        </table>
        <table>
          <thead>
           
            <tr>
              <th>ID</th>
              <th>Nombre</th>
              <th colspan="2">Descripción del grupo</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>1</td>
              <td>Admin (2 miembros)</td>
              <td></td>
              <td>
                <i class="far button fa-2x fa-edit"></i>
                <i class="far button fa-2x fa-trash-alt"></i>
              </td>
            </tr>  
            <tr>
              <td>2</td>
              <td>Módulos (1 miembros)</td>
              <td>Grupo de usuarios encargados del acceso a los módulos de turnos.</td>
              <td>
                <i class="far button fa-2x fa-edit"></i>
                <i class="far button fa-2x fa-trash-alt"></i>
              </td>
            </tr> 
          </tbody>
        </table>
      </div>
    </section>

    <section id="content4">
      <p>Hakkımızda Ayarlar</p>
    </section>
    <section id="content5">
      <table>
          <thead>
            <tr>
              <th colspan="2">Módulos activos</th>
              <th style="text-align: right"><i class="fas button fa-2x fa-plus"></i></th>
            </tr>
            <tr>
              <th>Nombre del módulo</th>
              <th>Usuario</th>
              <th>Acceder al módulo</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>Módulo 1</td>
              <td>1</td>
              <td>
                <i class="fas button fa-2x fa-link"></i>            
              </td>
            </tr>    
            <tr>
              <td>Módulo 2</td>
              <td>2</td>
              <td>
                <i class="fas button fa-2x fa-link"></i>            
              </td>
            </tr> 
            <tr>
              <td>Módulo 3</td>
              <td>3</td>
              <td>
                <i class="fas button fa-2x fa-link"></i>            
              </td>
            </tr> 
            <tr>
              <td>Módulo 4</td>
              <td>4</td>
              <td>
                <i class="fas button fa-2x fa-link"></i>            
              </td>
            </tr> 
            <tr>
              <td>Módulo 5</td>
              <td>5</td>
              <td>
                <i class="fas button fa-2x fa-link"></i>            
              </td>
            </tr> 
          </tbody>
        </table>
    </section>
    <section id="content6">
      <div id="video_player">
        <video width="95%" height="240" controls>
          <source src="" type="video/mp4">
        </video>
        <div class="video_upload">
          <button class="btn_upload">Video Ekle</button>
         
        </div>
      </div>
      <div id="video_playlist">
        <table>
          <thead>
            <tr>
              <th  colspan="3">Videos</th>
            </tr>
            <tr>
              <th>Video Adı</th>
              <th>Orden</th>
              <th></th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td colspan="1">la-calidad-de-muebles-jamar.mp4</td>
              <td>5</td>
              <td>
                <i class="far button fa-2x fa-times-circle"></i> 
              </td>
            </tr> 
            <tr>
              <td>don omar ft natti natasha - dutty love.flv</td>
              <td>6</td>
              <td>
                <i class="far button fa-2x fa-times-circle"></i> 
              </td>
            </tr>
            <tr>
              <td>don omar vs daddy yankee aki se decidio kien gano1.flv</td>
              <td>5</td>
              <td>
                <i class="far button fa-2x fa-times-circle"></i> 
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </section>
  </main>
 </body>
</html>