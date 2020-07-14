Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Optimization

Public Class BundleConfig
    ' Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkID=303951
    Public Shared Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/vendors/jquery/dist/jquery.min.js"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/vendors/bootstrap/dist/js/bootstrap.bundle.min.js"))

        bundles.Add(New ScriptBundle("~/bundles/vefastclick").Include(
                        "~/Scripts/vendors/fastclick/lib/fastclick.js"))

        bundles.Add(New ScriptBundle("~/bundles/nprogress").Include(
                        "~/Scripts/vendors/nprogress/nprogress.js"))

        bundles.Add(New ScriptBundle("~/bundles/Chart").Include(
                        "~/Scripts/vendors/Chart.js/dist/Chart.min.js"))

        bundles.Add(New ScriptBundle("~/bundles/gauge").Include(
                        "~/Scripts/vendors/gauge.js/dist/gauge.min.js"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap-progressbar").Include(
                        "~/Scripts/vendors/bootstrap-progressbar/bootstrap-progressbar.min.js"))

        bundles.Add(New ScriptBundle("~/bundles/Flot").Include(
                        "~/Scripts/vendors/Flot/jquery.flot.js",
                        "~/Scripts/vendors/Flot/jquery.flot.pie.js",
                        "~/Scripts/vendors/Flot/jquery.flot.time.js",
                        "~/Scripts/vendors/Flot/jquery.flot.stack.js",
                        "~/Scripts/vendors/Flot/jquery.flot.resize.js"))

        bundles.Add(New ScriptBundle("~/bundles/flot").Include(
                        "~/Scripts/vendors/flot.orderbars/js/jquery.flot.orderBars.js",
                        "~/Scripts/vendors/flot.curvedlines/curvedLines.js"))

        bundles.Add(New ScriptBundle("~/bundles/flot-spline").Include(
                        "~/Scripts/vendors/flot-spline/js/jquery.flot.spline.min.js"))

        bundles.Add(New ScriptBundle("~/bundles/DateJS").Include(
                        "~/Scripts/vendors/DateJS/build/date.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqvmap").Include(
                        "~/Scripts/vendors/jqvmap/dist/jquery.vmap.js",
                        "~/Scripts/vendors/jqvmap/dist/maps/jquery.vmap.world.js",
                        "~/Scripts/vendors/jqvmap/examples/js/jquery.vmap.sampledata.js"))

        bundles.Add(New ScriptBundle("~/bundles/build").Include(
                        "~/Scripts/build/js/custom.min.js"))

        bundles.Add(New ScriptBundle("~/bundles/WebFormsJs").Include(
                        "~/Scripts/WebForms/WebForms.js",
                        "~/Scripts/WebForms/WebUIValidation.js",
                        "~/Scripts/WebForms/MenuStandards.js",
                        "~/Scripts/WebForms/Focus.js",
                        "~/Scripts/WebForms/GridView.js",
                        "~/Scripts/WebForms/DetailsView.js",
                        "~/Scripts/WebForms/TreeView.js",
                        "~/Scripts/WebForms/WebParts.js"))

        ' El orden es muy importante para el funcionamiento de estos archivos ya que tienen dependencias explícitas
        bundles.Add(New ScriptBundle("~/bundles/MsAjaxJs").Include(
                "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"))

        ' Use la versión de desarrollo de Modernizr para desarrollar y aprender. Luego, cuando esté listo
        ' para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"))
    End Sub
End Class
