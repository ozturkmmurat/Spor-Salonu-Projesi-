<%@ Page Title="" Language="C#" MasterPageFile="~/TemplateMaster.Master" AutoEventWireup="true" CodeBehind="SporSalonPencere.aspx.cs" Inherits="ProjeSite.SporSalonPencere1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!DOCTYPE html>
<html>
  <head>
    <!-- Basic Page Needs
    ================================================== -->
    <meta charset="utf-8">
    <!--[if IE]><meta http-equiv="x-ua-compatible" content="IE=9" /><![endif]-->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>FitX - Fitness & Gym HTML Template</title>
    <meta name="description" content="FitX is multipurpose Html template option for web developer or designer who needs a web template to promote and introduce their business company or client. FitX is designed for club, dojo, fitness, yoga, martial art, gym, sport, businesses, or any type of person or business who wants to showcase their work, services and professional way.">
    <meta name="keywords" content="boxing, extreme game, fitness, fitness website, gym, matrial arts, modern, multi-purpose, rometheme, sport, template, website, yoga">
    <meta name="author" content="rometheme.net"> 
	
	<!-- ==============================================
	Favicons
	=============================================== -->
	<link rel="shortcut icon" href="images/favicon.ico">
	<link rel="apple-touch-icon" href="images/apple-touch-icon.png">
	<link rel="apple-touch-icon" sizes="72x72" href="images/apple-touch-icon-72x72.png">
	<link rel="apple-touch-icon" sizes="114x114" href="images/apple-touch-icon-114x114.png">
	
	<!-- ==============================================
	CSS VENDOR
	=============================================== -->
      <link href="css/vendor/font-awesome.min.css" rel="stylesheet" />
	<link rel="stylesheet" type="text/css" href="css/vendor/bootstrap.min.css" />
	<link rel="stylesheet" type="text/css" href="css/vendor/font-awesome.min.css">
	<link rel="stylesheet" type="text/css" href="css/vendor/owl.carousel.min.css">
	<link rel="stylesheet" type="text/css" href="css/vendor/owl.theme.default.min.css">
	<link rel="stylesheet" type="text/css" href="css/vendor/magnific-popup.css">
	<link rel="stylesheet" type="text/css" href="css/vendor/animate.min.css">
	
	<!-- ==============================================
	Custom Stylesheet
	=============================================== -->
	<link rel="stylesheet" type="text/css" href="css/style.css" />
	
    <script src="js/vendor/modernizr.min.js"></script>

</head>
   
<body>
    
	

	<!-- BANNER -->
    <div id="oc-fullslider" class="banner">
    	<div class="owl-carousel owl-theme full-screen">
	    	<div class="item">
	        	<img src="images/dummy-img-1920x900.jpg" alt="Slider">
	        	<div class="overlay-bg"></div>
	        	<div class="container d-flex align-items-center">
	            	<div class="wrap-caption">
		                <h1 class="caption-heading">WELCOME TO FITX</h1>
	            		<p class="caption-subheading">GET FIT IN LESS 2 WEEKS</p>
		                <p>We provide high businesses dolor sit amet, consectetur adipiscing elit dolor sit amet consectetuer adipiscing elit, sed diam nonummy nibh euismod.</p>
		                <a href="#" class="btn btn-primary">CONTACT NOW</a>
		            </div>   
	            </div>
	    	</div>
	    	<div class="item">
	            <img src="images/dummy-img-1920x900-2.jpg" alt="Slider">
	            <div class="overlay-bg"></div>
	            <div class="container d-flex align-items-center">
	            	<div class="wrap-caption">
		                <h1 class="caption-heading">START YOUR HEALTH</h1>
	            		<p class="caption-subheading">GET FIT IN LESS 2 WEEKS</p>
		                <p>We provide high businesses dolor sit amet, consectetur adipiscing elit dolor sit amet consectetuer adipiscing elit, sed diam nonummy nibh euismod.</p>
		                <a href="#" class="btn btn-primary">CONTACT NOW</a>
		            </div>  
	            </div>
	        </div> 
	    	<div class="item">
	            <img src="images/dummy-img-1920x900-3.jpg" alt="Slider">
	            <div class="overlay-bg"></div>
	            <div class="container d-flex align-items-center">
	            	<div class="wrap-caption">
		                <h1 class="caption-heading">AWESOME FITNESS</h1>
	            		<p class="caption-subheading">GET FIT IN LESS 2 WEEKS</p>
		                <p>We provide high businesses dolor sit amet, consectetur adipiscing elit dolor sit amet consectetuer adipiscing elit, sed diam nonummy nibh euismod.</p>
		                <a href="#" class="btn btn-primary">CONTACT NOW</a>
		            </div>    
	            </div>
	        </div> 
    	</div>
	    <div class="custom-nav owl-nav"></div>
    </div>


     <!-- SHORTCUT -->
	<div class="section services">
		<div class="content-wrap pb-0">
			<div class="container">
				<div class="row">
					<div class="col-sm-12 col-md-12">
						<div class="row no-gutters overlap">
							<div class="col-sm-12 col-md-12 col-lg-6">
								<!-- BOX 1 -->
								<div class="rs-feature-box-1 bg-primary" data-background="">
									<div class="title" id="kampanyaAdı" runat="server"> <%#Eval("KampanyaAdı") %> </div>
									<div class="body">
										<p runat="server" id="kampanyaBilgisi"> <%#Eval("KampanyaBilgisi") %></p>
										<a href="#" class="btn btn-secondary">CONTACT NOW</a>
										<div class="clearfix"></div>
									</div>
					            </div>
							</div>
							<div class="col-sm-12 col-md-12 col-lg-6">
								<!-- BOX 2 -->
								<div class="rs-feature-box-1" data-background="images/promo1.jpg">
									<div class="title">ÇALIŞMA SAATLERİMİZ<br></div>
									<div class="body">
										<div class="row">
											<div class="col-12 col-sm-12 col-md-6 col-lg-6">
					
                                                <div class="row">
													<div class="col-6">HAFTAİÇİ</div>
													<div id="HaftaiciSaati" runat="server" class="col-6"> :</div>
												
													<div class="col-6">CUMARTESİ GÜNÜ</div>
													<div runat="server" id="CumartesiSaati" class="col-6"> :</div>
												

                                                    <div class="col-6">PAZAR GÜNÜ</div>
													<div runat="server" id="PazargünüSaati" class="col-6"> :</div>

													
												</div>
											</div>
										</div>
										<div class="spacer-10"></div>
										<a href="#" class="btn btn-primary">CLASSES HERE</a>
										<div class="clearfix"></div>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>				



    <!-- ABOUT OUR GYM -->
	<div id="about" class="section">
		<div class="content-wrap">
			<div class="container">
				
				<div class="row">

					<div class="col-sm-12 col-md-12 col-lg-8">
						<h2 class="section-heading mb-4">
							WELCOME TO FITX
						</h2>            
                       
						<p id="HakkımızdaP" runat="server"> <%#Eval("Hakkimizda") %></p>                   
					 
                        <div class="spacer-30"></div>
						<div class="row">
							<!-- Item 1 -->
							<div class="col-sm-12 col-md-6 col-lg-6">
								<div class="box-icon-2">
									<div class="icon">
										<i class="fa fa-thumbs-up"></i>
									</div>
									<div class="body-content">
										<h4>The Best in Melbourne</h4>
										<p>Dolor sit amet dolor gravida placerat liberolorem ipsum dolor consectetur adipiscing elit, sed do eiusmod.</p>
									</div>
								</div>
							</div>
							<!-- Item 2 -->
							<div class="col-sm-12 col-md-6 col-lg-6">
								<div class="box-icon-2">
									<div class="icon">
										<i class="fa fa-trophy"></i>
									</div>
									<div class="body-content">
										<h4>Qualified Instructor</h4>
										<p>Dolor sit amet dolor gravida placerat liberolorem ipsum dolor consectetur adipiscing elit, sed do eiusmod.</p>
									</div>
								</div>
							</div>
							<!-- Item 3 -->
							<div class="col-sm-12 col-md-6 col-lg-6">
								<div class="box-icon-2">
									<div class="icon">
										<i class="fa fa-briefcase"></i>
									</div>
									<div class="body-content">
										<h4>High Tech Gym</h4>
										<p>Dolor sit amet dolor gravida placerat liberolorem ipsum dolor consectetur adipiscing elit, sed do eiusmod.</p>
									</div>
								</div>
							</div>
							<!-- Item 4 -->
							<div class="col-sm-12 col-md-6 col-lg-6">
								<div class="box-icon-2">
									<div class="icon">
										<i class="fa fa-users"></i>
									</div>
									<div class="body-content">
										<h4>Happy Members</h4>
										<p>Dolor sit amet dolor gravida placerat liberolorem ipsum dolor consectetur adipiscing elit, sed do eiusmod.</p>
									</div>
								</div>
							</div>
						</div>

					</div>

					<div class="col-sm-12 col-md-12 col-lg-4">
						
						<div class="rs-class-box mb-5">
							<div class="media-box">
								<img src="images/about-img.jpg" alt="" class="img-fluid">
							</div>
							<div class="body-box">
								<div class="title">ERNEST DOEL</div>
								<div class="detail">
									<div class="col">Personal Trainers</div>
									<div class="col">
										<div class="sosmed-icon d-inline-flex">
											<a href="#"><i class="fa fa-facebook"></i></a> 
											<a href="#"><i class="fa fa-twitter"></i></a> 
											<a href="#"><i class="fa fa-instagram"></i></a> 
										</div>
									</div>
								</div>
							</div>
						</div>

					</div>

				</div>

			</div>
		</div>
	</div>


    <!-- VIDEO -->
	<div class="section bgi-cover-center" data-background="images/video-bg.jpg">
		<div class="content-wrap">
			<div class="container">

				<div class="row">

					<div class="col-sm-12 col-md-12 col-lg-6 offset-lg-3">
						<div class="text-center">
							<a href="https://www.youtube.com/watch?v=vNDrLjOmUY4"  class="popup-youtube btn-video"><i class="fa fa-play fa-2x" ></i></a>
							<h3 class="text-primary mt-5">WATCH MOTIVATION VIDEO HERE</h3>
							<p>Aliquam a augue suscipit, luctus neque purus ipsum neque dolor primis libero tempus, tempor posuere ligula varius impedit enim tempor sapien</p>
						</div>
					</div>

				</div>
			</div>
		</div>
	</div>



    <!-- CLASS -->
	<div id="classes" class="section">
		<div class="content-wrap">
			<div class="container">

				<div class="row">
					<div class="col-sm-12 col-md-12">
						<h2 class="section-heading text-center mb-4">
					            SPOR SALONUMUZUN SINIFLARI
						</h2>
						<p class="subheading text-center mb-5">Spor Salonumuzdaki Branşlar</p>
					</div>
				</div>

				<div class="row mt-4">
                 
					<!-- Item 1 -->
                    <asp:Repeater runat="server" ID="SporBolumuRepater">
                  
                        <ItemTemplate>
					<div class="col-sm-12 col-md-6 col-lg-4">
						<div class="rs-class-box mb-5">
							<div class="media-box">
								<img  style="height:300px; width:350px;" src="SporSalonuBolum/<%#Eval("Resim") %>"  alt="" class="img-fluid">
							</div>
							<div class="body-box">
								<div class="title"><%#Eval("SporBolumu") %></div>
								<div class="detail">
									<div class="col"><i class="fa fa-clock-o"></i> 15:00 PM</div>
									<div class="col"><i class="fa fa-calendar-o"></i>Mon, Sun, Wed, Fri</div>
								</div>
							</div>
						</div>
					</div>
                 </ItemTemplate>
                        </asp:Repeater>
					

			</div>
		</div>
	</div>




    <!-- CLIENTS -->
	<div class="section bg-primary">
		<div class="content-wrap py-3">
			<div class="container">
				
				<div class="row">
					<div class="col-6 col-sm-4 col-md-2">
						<div class="client-img">
							<a href="#">
								<img src="images/client1.png" alt="" class="img-fluid">
							</a>
						</div>
					</div>

					<div class="col-6 col-sm-4 col-md-2">
						<div class="client-img">
							<a href="#"><img src="images/client2.png" alt="" class="img-fluid"></a>
						</div>
					</div>

					<div class="col-6 col-sm-4 col-md-2">
						<div class="client-img">
							<a href="#"><img src="images/client3.png" alt="" class="img-fluid"></a>
						</div>
					</div>

					<div class="col-6 col-sm-4 col-md-2">
						<div class="client-img">
							<a href="#"><img src="images/client4.png" alt="" class="img-fluid"></a>
						</div>
					</div>

					<div class="col-6 col-sm-4 col-md-2">
						<div class="client-img">
							<a href="#"><img src="images/client5.png" alt="" class="img-fluid"></a>
						</div>
					</div>

					<div class="col-6 col-sm-4 col-md-2">
						<div class="client-img">
							<a href="#"><img src="images/client6.png" alt="" class="img-fluid"></a>
						</div>
					</div>
					
				</div>
			</div>
		</div>
	</div>




    <!-- OUR TRAINERS -->
       
	<div id="trainers" class="section">
		<div class="content-wrap">
			<div class="container">

				<div class="row">
					<div class="col-sm-12 col-md-12">
						<h2 class="section-heading text-center mb-4">
							EĞİTMENLERİMİZ
						</h2>
						<p class="subheading text-center mb-5">We provide high standar clean website for your business solutions</p>
					</div>
				</div>

				<div class="row mt-4">
					<!-- Item 1 -->
                    <asp:Repeater runat="server" ID="RepaterList">
                  
                        <ItemTemplate>
					<div class="col-sm-12 col-md-6 col-lg-4">
						<div class="rs-class-box mb-5">
							<div class="media-box">
								<img  style="height:300px; width:350px;" src="CalisanFoto/<%#Eval("Resim") %>"  alt="" class="img-fluid">
							</div>
							<div class="body-box">
								<div class="title"><%#Eval("Calisan_Ad") %>&nbsp; <%#Eval("Calisan_Soyad") %></div>
								<div class="detail">
									<div class="col">Branş :  <%#Eval("Calisan_Brans") %>  </div>
									<div class="col">
										<div class="sosmed-icon d-inline-flex">
											<a href="#"><i class="fa fa-facebook"></i></a> 
											<a href="#"><i class="fa fa-twitter"></i></a> 
											<a href="#"><i class="fa fa-instagram"></i></a> 
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
                     </ItemTemplate>
                       </asp:Repeater>      
					

				</div>

			</div>
		</div>
	</div>
    

   


        <!-- CTA -->
	<div class="section bgi-cover-center" data-background="images/dummy-img-1920x900-3.jpg">
		<div class="content-wrap">
			<div class="container">

				<div class="row">

					<div class="col-sm-12 col-md-12 col-lg-8 offset-lg-2">
						<div class="text-center">
							<h2 class="text-primary"><em>GET FIT IN LESS 2 WEEKS WITH FITX</em></h2>
							<p class="mb-5">Aliquam a augue suscipit, luctus neque purus ipsum neque dolor primis libero tempus, tempor posuere ligula varius impedit enim tempor sapien</p>
							<a href="#" class="btn btn-primary">CONTACT NOW</a>
						</div>
					</div>

				</div>
			</div>
		</div>
	</div>





        <!-- OUR GALLERY -->
	<div id="gallery" class="section">
		<div class="content-wrap">
			<div class="container">
				<div class="row">

					<div class="col-sm-12 col-md-12">
						<h2 class="section-heading text-center">
							Our <span>Gallery</span>
						</h2>
						<p class="subheading text-center">Lorem ipsum dolor sit amet, onsectetur adipiscing cons ectetur nulla. Sed at ullamcorper risus.</p>
					</div>

				</div>

				<div class="row popup-gallery gutter-5 mt-5">
					<div class="col-sm-12 col-md-6 col-lg-4">
						<div class="box-gallery">
							<a href="images/dummy-img-900x500.jpg" title="Gallery #1">
								<img src="images/dummy-img-900x500.jpg" alt="" class="img-fluid">
								<div class="project-info">
									<div class="project-icon">
										<span class="fa fa-search"></span>
									</div>
								</div>
							</a>
						</div>
					</div>
					<div class="col-sm-12 col-md-6 col-lg-4">
						<div class="box-gallery">
							<a href="images/gallery-2.jpg" title="Gallery #2">
								<img src="images/dummy-img-900x500.jpg" alt="" class="img-fluid">
								<div class="project-info">
									<div class="project-icon">
										<span class="fa fa-search"></span>
									</div>
								</div>
							</a>
						</div>
					</div>
					<div class="col-sm-12 col-md-6 col-lg-4">
						<div class="box-gallery">
							<a href="images/dummy-img-900x500.jpg" title="Gallery #3">
								<img src="images/dummy-img-900x500.jpg" alt="" class="img-fluid">
								<div class="project-info">
									<div class="project-icon">
										<span class="fa fa-search"></span>
									</div>
								</div>
							</a>
						</div>
					</div>
					<div class="col-sm-12 col-md-6 col-lg-4">
						<div class="box-gallery">
							<a href="images/dummy-img-900x500.jpg" title="Gallery #4">
								<img src="images/dummy-img-900x500.jpg" alt="" class="img-fluid">
								<div class="project-info">
									<div class="project-icon">
										<span class="fa fa-search"></span>
									</div>
								</div>
							</a>
						</div>
					</div>
					<div class="col-sm-12 col-md-6 col-lg-4">
						<div class="box-gallery">
							<a href="images/dummy-img-900x500.jpg" title="Gallery #5">
								<img src="images/dummy-img-900x500.jpg" alt="" class="img-fluid">
								<div class="project-info">
									<div class="project-icon">
										<span class="fa fa-search"></span>
									</div>
								</div>
							</a>
						</div>
					</div>
					<div class="col-sm-12 col-md-6 col-lg-4">
						<div class="box-gallery">
							<a href="images/dummy-img-900x500.jpg" title="Gallery #6">
								<img src="images/dummy-img-900x500.jpg" alt="" class="img-fluid">
								<div class="project-info">
									<div class="project-icon">
										<span class="fa fa-search"></span>
									</div>
								</div>
							</a>
						</div>
					</div>
					
				</div>
			</div>
		</div>
	</div>


        <!-- OUR PACKAGES -->
	<div class="section">
		<div class="content-wrap">
			<div class="container">
				<div class="row">

					<div class="col-sm-12 col-md-12">
						<h2 class="section-heading text-center">
							OUR PACKAGES
						</h2>
						<p class="subheading text-center">Lorem ipsum dolor sit amet, onsectetur adipiscing cons ectetur nulla. Sed at ullamcorper risus.</p>
					</div>

				</div>

				<div class="row mt-5">
 
					<!-- Item 1 -->
					<div class="col-sm-12 col-md-12 col-lg-4">
						<div class="rs-pricing-1 bg-primary-1 mb-5">
						  <img src="images/package-1.jpg" alt="" class="img-fluid">
						  <div class="blok-title">
				              <h3 class="title">BEGINNER</h3>
				              <div class="price"> $10<span>/month</span> </div> 
						  </div>
			              <div class="features">
			                <ul>
			                  <li>2 Day a Week</li>
			                  <li>GYM Access & Equipment</li>
			                  <li>Get Suplement</li>
			                  <li>Personal Trainers</li>
			                  <li>Diet Guides</li>
			                </ul>
			              </div>
			              <div class="action">
			                <a href="#" class="btn btn-secondary">JOIN FORCE</a>
			              </div>
			            </div>
					</div>

					<!-- Item 2 -->
					<div class="col-sm-12 col-md-12 col-lg-4">
						<div class="rs-pricing-1 bg-primary-1 mb-5">
						  <img src="images/package-2.jpg" alt="" class="img-fluid">
						  <div class="blok-title">
				              <h3 class="title">ADVANCED</h3>
				              <div class="price"> $20<span>/month</span> </div> 
						  </div>
			              <div class="features">
			                <ul>
			                  <li>2 Day a Week</li>
			                  <li>GYM Access & Equipment</li>
			                  <li>Get Suplement</li>
			                  <li>Personal Trainers</li>
			                  <li>Diet Guides</li>
			                </ul>
			              </div>
			              <div class="action">
			                <a href="#" class="btn btn-secondary">JOIN FORCE</a>
			              </div>
			            </div>
					</div>

					<!-- Item 3 -->
					<div class="col-sm-12 col-md-12 col-lg-4">
						<div class="rs-pricing-1 bg-primary-1 mb-5">
						  <img src="images/package-3.jpg" alt="" class="img-fluid">
						  <div class="blok-title">
				              <h3 class="title">PROFESSIONAL</h3>
				              <div class="price"> $25<span>/month</span> </div> 
						  </div>
			              <div class="features">
			                <ul>
			                  <li>2 Day a Week</li>
			                  <li>GYM Access & Equipment</li>
			                  <li>Get Suplement</li>
			                  <li>Personal Trainers</li>
			                  <li>Diet Guides</li>
			                </ul>
			              </div>
			              <div class="action">
			                <a href="#" class="btn btn-secondary">JOIN FORCE</a>
			              </div>
			            </div>
					</div>
					
				</div>
			</div>
		</div>
	</div>
   
   



    </html>
  </div>

</asp:Content>