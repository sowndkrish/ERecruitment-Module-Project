<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ContentPlaceHolderID="Content1" runat="server">
     <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <title>ABC Ltd - E-Recruitment</title>

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
<!-- Slider -->
        <div class="slider-container">
            <div class="container">
                <div class="row">
                    <div class="col-sm-10 col-sm-offset-1 slider">
                        <div class="flexslider">
                            <ul class="slides">
                                <li data-thumb="assets/img/slider/1.jpg">
                                    <img src="assets/img/slider/1.jpg">
                                    <div class="flex-caption">
                                       Today’s talent. Tomorrow’s success.We deliver results.
"We promise what we demand”.Empowering leaders to live life on purpose.
                                    </div>
                                </li>
                                <li data-thumb="assets/img/slider/2.jpg">
                                    <img src="assets/img/slider/2.jpg">
                                    <div class="flex-caption">
We understand your business demands.Smile, you’ve found us.
                                        Leading people. Leading organizations.Improving workplace productivity.
                                    </div>
                                </li>
                                <li data-thumb="assets/img/slider/gp.jpg">
                                    <img src="assets/img/slider/gp.jpg">
                                    <div class="flex-caption">
                                        ABC Ltd has the best tech helps at hand and in hand.
The power interface of your mobile brain and our portable machines.The right trainers, the right place, at the right time.
                                    </div>
                                </li>
                                <li data-thumb="assets/img/slider/4.jpg">
                                    <img src="assets/img/slider/4.jpg">
                                    <div class="flex-caption">
A company’s most valuable asset is its employees. “Bringing together hands-on calculators and brains-on people”.
                                        Making the impossible possible.People! Process! Power!
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Presentation -->
        <div class="presentation-container">
        	<div class="container">
        		<div class="row">
	        		<div class="col-sm-12 wow fadeInLeftBig">
	            		<h1>We are <span class="violet">ABC Ltd</span>, New ideas,Better HR</h1>
	            		<p>Your journey begins here.We assure you a rose garden.</p>
	            	</div>
            	</div>
        	</div>
        </div>

        <!-- Services -->
        <div class="services-container">
	        <div class="container">
	            <div class="row">
	            	<div class="col-sm-3">
		                <div class="service wow fadeInUp">
		                    <div class="service-icon"><i class="fa fa-eye"></i></div>
		                    <h3>Resume/ Application</h3>
		                    <p>Resume building is an evolutionary process. Upload your best version of the resume and become a part of the team in this company.</p>
		                    <a class="big-link-1" href="services.html">Read more</a>
		                </div>
					</div>
					<div class="col-sm-3">
		                <div class="service wow fadeInDown">
		                    <div class="service-icon"><i class="fa fa-table"></i></div>
		                    <h3>Screening Test</h3>
		                    <p>Defining requisite job competencies. For the most effective use of online testing, it is imperative that the job competencies are clearly defined.</p>
		                    <a class="big-link-1" href="services.html">Read more</a>
		                </div>
	                </div>
	                <div class="col-sm-3">
		                <div class="service wow fadeInUp">
		                    <div class="service-icon"><i class="fa fa-magic"></i></div>
		                    <h3> HR Inteview</h3>
		                    <p>Interacting with candidates, putting them into scenarios and asking for examples of how they have responded in the past is a part of interview.</p>
		                    <a class="big-link-1" href="services.html">Read more</a>
		                </div>
	                </div>
	                <div class="col-sm-3">
		                <div class="service wow fadeInDown">
		                    <div class="service-icon"><i class="fa fa-print"></i></div>
		                    <h3>Decision</h3>
		                    <p>Gathering information and resources.Weighing the risks and decising on the values. Making the optimal decision.</p>
		                    <a class="big-link-1" href="services.html">Read more</a>
		                </div>
	                </div>
	            </div>
	        </div>
        </div>

        <!-- Latest work -->
        <div class="work-container">
	        <div class="container">
	        	<div class="row">
		            <div class="col-sm-12 work-title wow fadeIn">
		                <h2>Our Industries</h2>
		            </div>
	            </div>
	            <div class="row">
	            	<div class="col-sm-3">
		                <div class="work wow fadeInUp">
		                    <img src="assets/img/portfolio/finance.jpg" alt="Finance" data-at2x="assets/img/portfolio/finance.jpg">
		                    <h3>Financial Services</h3>
		                    <p>ABC is the partner that gets you results: optimized investments, enhanced operational efficiencies and minimized risk</p>
		                    <div class="work-bottom">
		                        <a class="big-link-2 view-work" href="assets/img/portfolio/finance.jpg"><i class="fa fa-search"></i></a>
		                        <a class="big-link-2" href="portfolio.html"><i class="fa fa-link"></i></a>
		                    </div>
		                </div>
	                </div>
	                <div class="col-sm-3">
		                <div class="work wow fadeInDown">
		                    <img src="assets/img/portfolio/insurance1.jpg" alt="Insurance" data-at2x="assets/img/portfolio/insurance1.jpg">
		                    <h3>Insurance Services</h3>
		                    <p>ABC enables leading global insurers with business transformation and operational efficiency.</p>
		                    <div class="work-bottom">
		                        <a class="big-link-2 view-work" href="assets/img/portfolio/insurance1.jpg"><i class="fa fa-search"></i></a>
		                        <a class="big-link-2" href="portfolio.html"><i class="fa fa-link"></i></a>
		                    </div>
		                </div>
		            </div>
		            <div class="col-sm-3">
		                <div class="work wow fadeInUp">
		                    <img src="assets/img/portfolio/telecom1.jpg" alt="Telecom" data-at2x="assets/img/portfolio/telecom1.jpg">
		                    <h3>Telecom Services</h3>
		                    <p>ABC Ltd are looking for ways to transform their legacy, plan ahead for transformation required to secure future in the digital age.</p>
		                    <div class="work-bottom">
		                        <a class="big-link-2 view-work" href="assets/img/portfolio/telecom1.jpg"><i class="fa fa-search"></i></a>
		                        <a class="big-link-2" href="portfolio.html"><i class="fa fa-link"></i></a>
		                    </div>
		                </div>
		            </div>
		            <div class="col-sm-3">
		                <div class="work wow fadeInDown">
		                    <img src="assets/img/portfolio/retl.jpg" alt="Retail" data-at2x="assets/img/portfolio/retl.jpg">
		                    <h3>Retail Services</h3>
		                    <p>ABC offers a fully integrated organization that embeds end-to-end capabilities to help you achieve success.</p>
		                    <div class="work-bottom">
		                        <a class="big-link-2 view-work" href="assets/img/portfolio/retl.jpg"><i class="fa fa-search"></i></a>
		                        <a class="big-link-2" href="portfolio.html"><i class="fa fa-link"></i></a>
		                    </div>
		                </div>
		            </div>
	            </div>
	        </div>
        </div>
</asp:Content>