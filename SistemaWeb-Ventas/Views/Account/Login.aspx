﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="SistemaWeb_Ventas.Login1" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

<<<<<<< HEAD
    <title>Login </title>
=======
    <title>Sistemas Ventas</title>
>>>>>>> 82df7d6d269a162e60ef4ce5eea69cf68a208ff7

    <!-- Bootstrap -->
    <link href="../../Scripts/vendors/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Font Awesome -->
    <link href="../../Scripts/vendors/font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <!-- NProgress -->
    <link href="../../Scripts/vendors/nprogress/nprogress.css" rel="stylesheet">
    <!-- Animate.css -->
    <link href="../../Scripts/vendors/animate.css/animate.min.css" rel="stylesheet">

    <!-- Custom Theme Style -->
    <link href="../../Scripts/build/css/custom.min.css" rel="stylesheet" />

    <style>
        #btnLogin {
            margin-left: 0px;
            margin-top: 13px;
            width: 100%;
        }

        #btnReset {
            margin-right: 0px;
            margin-left: 0px;
        }
    </style>
</head>

<body class="login">
    <div>
        <a class="hiddenanchor" id="signup"></a>
        <a class="hiddenanchor" id="signin"></a>

        <%--<div class="container-fluid">
            <asp:Image ID="imgLogo" runat="server" ImageUrl="~/images/logo.jpg" ImageAlign="Top" />
        </div>--%>
        <div class="login_wrapper">
            <div class="animate form login_form">
                <section class="login_content">
                    <form runat="server">
                        <h1>Iniciar Sesión</h1>
                        <div>
                            <asp:TextBox ID="txtUser" CssClass="form-control" runat="server" placeholder="Usuario" required="" TabIndex="1"></asp:TextBox>
                        </div>
                        <div>
                            <asp:TextBox ID="txtPass" runat="server" CssClass="form-control" placeholder="Contraseña" required="" TabIndex="2" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="btnLogin" runat="server" Text="Iniciar Sesión" CssClass="btn btn-primary submit" TabIndex="3" />
                            <%--<asp:Button ID="btnReset" runat="server" Text="¿Olvidaste tu contraseña?" CssClass="reset_pass btn btn-info" TabIndex="4" />--%>
                        </div>

                        <div class="clearfix"></div>

                        <div class="separator">
                            <%--<p class="change_link">New to site?
                                  <a href="#signup" class="to_register"> Create Account </a>
                                </p>--%>
                            <div class="clearfix"></div>
                            <br />

                            <div>
                                <h1><i class="fa fa-shopping-cart"></i>  Sistema Ventas</h1>
                                <p>&copy; <%: DateTime.Now.Year %> - Mi aplicación ASP.NET</p>
                            </div>
                        </div>
                    </form>
                </section>
            </div>

            <div id="register" class="animate form registration_form">
                <section class="login_content">
                    <form>
                        <h1>Crear Cuenta</h1>
                        <div>
                            <input type="text" class="form-control" placeholder="Username" required="" />
                        </div>
                        <div>
                            <input type="email" class="form-control" placeholder="Email" required="" />
                        </div>
                        <div>
                            <input type="password" class="form-control" placeholder="Password" required="" />
                        </div>
                        <div>
                            <button id="btnRegister" class="btn btn-primary submit">Enviar</button>
                        </div>

                        <div class="clearfix"></div>

                        <div class="separator">
                            <p class="change_link">
                                ¿Ya eres usuario?
                                <a href="#signin" class="to_register">Iniciar Sesión </a>
                            </p>

                            <div class="clearfix"></div>
                            <br />

                            <div>
                                <h1><i class="fa fa-shopping-cart"></i>  Sistema ventas</h1>
                                <p>&copy; <%: DateTime.Now.Year %> - Mi aplicación ASP.NET</p>
                            </div>
                        </div>
                    </form>
                </section>
            </div>
        </div>
    </div>
</body>
</html>
