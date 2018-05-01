<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication1.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
    <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <title>Andia - Responsive Agency Template</title>

        <!-- CSS -->
        <link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Open+Sans:400italic,400">
        <link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Droid+Sans">
        <link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Lobster">
        <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
        <link rel="stylesheet" href="assets/font-awesome/css/font-awesome.min.css">
        <link rel="stylesheet" href="assets/css/animate.css">
        <link rel="stylesheet" href="assets/css/magnific-popup.css">
        <link rel="stylesheet" href="assets/flexslider/flexslider.css">
        <link rel="stylesheet" href="assets/css/form-elements.css">
        <link rel="stylesheet" href="assets/css/style.css">
        <link rel="stylesheet" href="assets/css/media-queries.css">

        <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
        <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
        <!--[if lt IE 9]>
            <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
            <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
        <![endif]-->

        <!-- Favicon and touch icons -->
        <link rel="shortcut icon" href="assets/ico/favicon.ico">
        <link rel="apple-touch-icon-precomposed" sizes="144x144" href="assets/ico/apple-touch-icon-144-precomposed.png">
        <link rel="apple-touch-icon-precomposed" sizes="114x114" href="assets/ico/apple-touch-icon-114-precomposed.png">
        <link rel="apple-touch-icon-precomposed" sizes="72x72" href="assets/ico/apple-touch-icon-72-precomposed.png">
        <link rel="apple-touch-icon-precomposed" href="assets/ico/apple-touch-icon-57-precomposed.png">

            <!-- Page Title -->
        <div class="page-title-container">
            <div class="container">
                <div class="row">
                    <div class="col-sm-12 wow fadeIn">
                        <i class="fa fa-envelope"></i>
                        <h1>Contact Us /</h1>
                        <p>Here is how you can contact us</p>
                    </div>
                </div>
            </div>
        </div>
     <!-- Contact Us -->
        <div class="contact-us-container">
        	<div class="container">
	            <div class="row">
	                <div class="col-sm-7 contact-form wow fadeInLeft">
	                    <p>
                            We are here to answer any questions you may have about our ABC company. Reach out to us and we will respond as soon as we can. Let us know and we promise we'll do our best to find it for you and send you there.
	                    </p>
	                    <form role="form" action="assets/contact.php" method="post">
	                    	<div class="form-group">
	                    		<label for="contact-name">Name</label>
	                        	<input type="text" name="name" placeholder="Enter your name..." class="contact-name" id="contact-name">
	                        </div>
	                    	<div class="form-group">
	                    		<label for="contact-email">Email</label>
	                        	<input type="text" name="email" placeholder="Enter your email..." class="contact-email" id="contact-email">
	                        </div>
	                        <div class="form-group">
	                        	<label for="contact-subject">Subject</label>
	                        	<input type="text" name="subject" placeholder="Your subject..." class="contact-subject" id="contact-subject">
	                        </div>
	                        <div class="form-group">
	                        	<label for="contact-message">Message</label>
	                        	<textarea name="message" placeholder="Your message..." class="contact-message" id="contact-message"></textarea>
	                        </div>
	                        <button type="submit" class="btn">Send</button>
	                    </form>
	                </div>
	                <div class="col-sm-5 contact-address wow fadeInUp">
	                    <h3>We Are Here</h3>
	                    <div class="map"></div>
	                    <h3>Address</h3>
	                    <p>TCS - ILP <br> Karapakkam,Chennai</p>
	                    <p>Phone: +91 8802287900</p>
	                </div>
	            </div>
	        </div>
        </div>

            <!-- Javascript -->
        <script src="assets/js/jquery-1.11.1.min.js"></script>
        <script src="assets/bootstrap/js/bootstrap.min.js"></script>
        <script src="assets/js/bootstrap-hover-dropdown.min.js"></script>
        <script src="assets/js/jquery.backstretch.min.js"></script>
        <script src="assets/js/wow.min.js"></script>
        <script src="assets/js/retina-1.1.0.min.js"></script>
        <script src="assets/js/jquery.magnific-popup.min.js"></script>
        <script src="assets/flexslider/jquery.flexslider-min.js"></script>
        <script src="assets/js/jflickrfeed.min.js"></script>
        <script src="assets/js/masonry.pkgd.min.js"></script>
        <script src="http://maps.google.com/maps/api/js?sensor=true"></script>
        <script src="assets/js/jquery.ui.map.min.js"></script>
        <script src="assets/js/scripts.js"></script>
</asp:Content>
