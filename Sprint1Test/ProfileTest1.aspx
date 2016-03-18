<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfileTest1.aspx.cs" Inherits="Sprint1Test.ProfileTest1" %>

<head runat="server">
    <title>Profile Picture</title>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <link rel="stylesheet" href="layout/styles/layout.css" type="text/css" />
    <script type="text/javascript" src="layout/scripts/jquery.min.js"></script>
    <script type="text/javascript" src="layout/scripts/jquery.jcarousel.pack.js"></script>
    <script type="text/javascript" src="layout/scripts/jquery.easing.1.3.js"></script>
    <script type="text/javascript" src="layout/scripts/jquery.jcarousel.setup.js"></script>
</head>
<body id="top">
    <script>
        window.fbAsyncInit = function () {
            FB.init({
                appId: '1403999033240113',
                xfbml: true,
                version: 'v2.2'
            });
        };

        (function (d, s, id) {
            var js, fjs = d.getElementsByTagName(s)[0];
            if (d.getElementById(id)) return;
            js = d.createElement(s); js.id = id;
            js.src = "//connect.facebook.net/en_US/sdk.js#xfbml=1&version=v2.0";
            fjs.parentNode.insertBefore(js, fjs);
        }(document, 'script', 'facebook-jssdk'));</script>

    <div class="wrapper col1">
        <div id="topbar">
            <p>Tel: 1 + (503) Sym-bios | Mail: SymbiosisInfo@symbiosis.com</p>
            <br class="clear" />
        </div>
    </div>
    <!-- ####################################################################################################### -->
    <div class="wrapper col2">
        <div id="header">
            <div class="fl_left">
                <h1><a href="../">Symbiosis</a></h1>
                <p>A Skill Bartering Free Market Trade Environment</p>
            </div>
            <div class="fl_right"><a href="http://www.NikeBaseball.com">
                <img src="images/demo/Nike ad.jpg" alt="" /></a> </div>
            <br class="clear" />
        </div>
    </div>
    <!-- ####################################################################################################### -->
    <div class="wrapper col3">
        <div id="topnav">
            <ul>
                <li class="active"><a href="../">Homepage</a><span>Home, Sweet Home</span></li>
                <li><a href="pages/style-demo.html">Search Site</a><span>People, skills, locations</span></li>
                <li><a href="pages/full-width.html">Talk to An Expert</a><span>Real People, Real Time</span></li>
                <li>
                    <a href="#">Skills</a><span>Top listed skills</span>
                    <ul>
                        <li><a href="#">Lawn Care</a></li>
                        <li><a href="#">Plumbing</a></li>
                        <li><a href="#">Automotive Repair</a></li>
                        <li><a href="#">Electrical</a></li>
                    </ul>
                </li>
                <li><a href="http://kittenforumtest.azurewebsites.net/forum" target="_blank">Message Board</a><span>Search skills to/for hire</span></li>
                <li class="last"><a href="#">Contact</a><span>Administrator contact</span></li>
            </ul>
            <br class="clear" />
        </div>
    </div>


    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" />
        </div>
        <asp:Panel ID="Panel1" runat="server" ScrollBars="None" Height="150" Width="150">
        </asp:Panel>

        <p><strong><a href="Profile/">Back to profile</a></strong></p>

    </form>
</body>
