<%@ Page Title="" Language="C#" MasterPageFile="~/test.master" AutoEventWireup="true" CodeBehind="Service.aspx.cs" Inherits="WebApplication1.Service" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
    <!-- Basic Page Needs
  ================================================== -->
    <meta charset="utf-8">
    <meta name="description" content="">
    <meta name="author" content="">

    <!-- Mobile Specific Metas
  ================================================== -->
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
        <style>
            @import url(http://fonts.googleapis.com/css?family=Roboto:100);
@import url(http://cdnjs.cloudflare.com/ajax/libs/meyer-reset/2.0/reset.css);

body {
  background: url(http://jsrun.it/assets/p/r/8/X/pr8Xi.png);  /*bg  1a1a1a  434240  */
  color: white;
  font-family: 'Roboto';
}
p{
  color:;
}
input:focus{
  background-color:yellow;
}
.flat-form {
  background: #34495e;  /*tablebg e74c3c #34495e  #88565b ed7271*/
  margin: 25px auto;
  width: 446px;
  height: 542px;
  position: relative;
  font-family: 'Roboto';
                top: -74px;
                left: -259px;
            }
.tabs {
  background: #ed7271;  /*topbar #c0392b #88565b*/
  height: 40px;
  padding: 0;
  list-style-type: none;
  width: 100%;
  position: relative;
  display: block;
  margin-bottom: 20px;
        top: -2px;
        left: -4px;
        margin-left: 0;
        margin-right: 0;
        margin-top: 0;
    }
.tabs li {
  display: block;
  float: left;
  margin: 0;
  padding: 0;
}
.tabs a {
  background: #ed7271;  /*topbar c0392b  #88565b */
  display: block;
  float: left;
  text-decoration: none;
  color: white;
  font-size: 16px;
  padding: 12px 22px 12px 22px;
  /*border-right: 1px solid @tab-border;*/

}
.tabs li:last-child a {
  border-right: none;
  width: 174px;
  padding-left: 0;
  padding-right: 0;
  text-align: center;
}
.tabs a.active {
  background: #ed7271;  /*topbar e74c3c  */
  border-right: none;
  -webkit-transition: all 0.5s linear;
	-moz-transition: all 0.5s linear;
	transition: all 0.5s linear;
}
.form-action {
  padding: 0 20px;
  position: relative;
}

.form-action h1 {
  font-size: 42px;
  padding-bottom: 10px;
}
.form-action p {
  font-size: 12px;
  padding-bottom: 10px;
  line-height: 25px;
}
form {
  padding-right: 20px !important;
        width: 398px;
        height: 311px;
    }
form input[type=text],
form input[type=password],
form input[type=submit] {
  font-family: 'Roboto';
}

form input[type=text],
form input[type=password] {
  width: 100%;
  height: 40px;
  margin-bottom: 10px;
  padding-left: 15px;
  background: #fff; /* #44454a  */
  border: none;
  color: #00000;   /* e74c3c e9e9e9  */
  outline: none;
}

.dark-box {
  background: #5e0400;
  box-shadow: 1px 3px 3px #3d0100 inset;
  height: 40px;
  width: 50px;
}
.form-action .dark-box.bottom {
  position: absolute;
  right: 0;
  bottom: -24px;
}
.tabs + .dark-box.top {
  position: absolute;
  right: 0;
  top: 0px;
}
.show {
  display: block;
}
.hide {
  display: none;
}

.button {
    border-style: none;
        border-color: inherit;
        border-width: medium;
        display: block;
        background: #136899;
        width: 80px;
        color: #ffffff;
        text-align: center;
        border-radius: 5px;
    /*box-shadow: 0px 3px 1px #2075aa;*/
  	    -webkit-transition: all 0.15s linear;
	    -moz-transition: all 0.15s linear;
	    transition: all 0.15s linear;
}

.button:hover {
  background: #1e75aa;
  /*box-shadow: 0 3px 1px #237bb2;*/
}

.button:active {
  background: #136899;
  /*box-shadow: 0 3px 1px #0f608c;*/
}

::-webkit-input-placeholder {
  color:dark ;    /*  #e74c3c */
}
:-moz-placeholder {
  /* Firefox 18- */
  color: #e74c3c;
}
::-moz-placeholder {
  /* Firefox 19+ */
  color: #e74c3c;
}
:-ms-input-placeholder {
  color: #e74c3c;
}
            </style>
        <script type="text/javascript">
            $(function () {
                // constants
                var SHOW_CLASS = 'show',
                    HIDE_CLASS = 'hide',
                    ACTIVE_CLASS = 'active';

                $('.tabs').on('click', 'li a', function (e) {
                    e.preventDefault();
                    var $tab = $(this),
                         href = $tab.attr('href');

                    $('.active').removeClass(ACTIVE_CLASS);
                    $tab.addClass(ACTIVE_CLASS);

                    $('.show')
                       .removeClass(SHOW_CLASS)
                       .addClass(HIDE_CLASS)
                       .hide();

                    $(href)
                      .removeClass(HIDE_CLASS)
                      .addClass(SHOW_CLASS)
                      .hide()
                      .fadeIn(550);
                });
            });
        </script>



        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">

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


       



        <!-- Services Full Width Text -->
        <div class="services-full-width-container">
        	<div class="container">
	            <div class="row">
	                <div class="col-sm-12 services-full-width-text wow fadeInLeft">


	                    <div class="container">
        <div class="flat-form">
            <ul class="tabs">
                <li>
                    <a href="#login" class="active">BGC Test Administrator</a>
                </li>
            </ul>
            <div id="login" class="form-action show">
                <p>
                    &nbsp;</p>
                <h1 class="auto-style2">HR Services</h1>
                <p class="auto-style1">
                    Add BGC Test Administrator/s
                </p>
                <form id="formbgc" runat="server">
                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    <ul>
                        <li>
                            &nbsp;&nbsp;<h4><asp:Label ID="bgctest" runat="server" Text="BGC Test Administrator" ForeColor="Maroon"></asp:Label>
                                <%--<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SelectBGCta" DataTextField="user_EmployeeID" DataValueField="user_EmployeeID">
                                    <asp:ListItem></asp:ListItem>
                                    
                                </asp:DropDownList>--%>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                                <asp:DropDownList ID="ddlBGCta" runat="server" Width="200px" 
        AutoPostBack="True" DataSourceID="trail" DataTextField="AdministratorID" 
        DataValueField="AdministratorID" AppendDataBoundItems="True" ForeColor="Black" Font-Bold="true" Font-Names="Arial">

    <asp:ListItem Text="" Value="" />
 </asp:DropDownList>
                </ContentTemplate>
        </asp:UpdatePanel>
                                <asp:SqlDataSource ID="trail" runat="server" ConnectionString="<%$ ConnectionStrings:CHN22_MMS104_Group3ConnectionString %>" SelectCommand="SELECT [AdministratorID] FROM [administratorID]"></asp:SqlDataSource>
                            </h4>
                            <h4>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlBGCta" ErrorMessage="Select Administrator" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                            </h4>
                        </li>
                        <li>
                            &nbsp;<h4><asp:Label ID="status" runat="server" Text="Status" ForeColor="Maroon"></asp:Label> 
                            </h4>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                            <asp:DropDownList ID="ddlApproval" runat="server" Enabled="False" Height="27px" Width="163px" ForeColor="Black" Font-Bold="true" Font-Names="Arial">
                                <asp:ListItem Selected="True">Pending Approval</asp:ListItem>
                            </asp:DropDownList>
                        </li>
                        </ul>
                            <asp:Button ID="Add" runat="server" Text="Add" class="button" Width="389px" BackColor="#006699" ForeColor="White" Height="35px" OnClick="Add_Click" /><br />
                            <asp:Button ID="Reset" runat="server" Text="Reset" CssClass="button" Width="387px" BackColor="#006699" ForeColor="White" Height="31px" />          
                    <br />

                    
                </form>
            </div>          
        </div>
    </div>
                         <script class="cssdeck" src="//cdnjs.cloudflare.com/ajax/libs/jquery/1.8.0/jquery.min.js"></script>




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
