Imports System.Web.Mvc
Imports System.Web.Optimization

Public Class Global_asax
    Inherits HttpApplication

    Sub Application_Start(sender As Object, e As EventArgs)
        ' Se desencadena al iniciar la aplicación
        AreaRegistration.RegisterAllAreas()
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)

        Application("Aplicaciones") = 0
        Application("SesionUsuario") = 0

        Application("Aplicaciones") = CType(Application("Aplicaciones") + 1, Integer)
    End Sub

    Sub Sesion_Start(sender As Object, e As EventArgs)
        Application("SesionUsuario") = CType(Application("SesionUsuario") + 1, Integer)
    End Sub

    Sub Sesion_End(sender As Object, e As EventArgs)
        Application("SesionUsuario") = CType(Application("SesionUsuario") - 1, Integer)
    End Sub
End Class