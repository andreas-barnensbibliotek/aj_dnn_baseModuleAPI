Imports DotNetNuke.Web.Api

Public Class RouteMapper
    Implements IServiceRouteMapper

    Public Sub RegisterRoutes(ByVal mapRouteManager As IMapRoute) Implements IServiceRouteMapper.RegisterRoutes
        mapRouteManager.MapHttpRoute("Aj_quizEngineAPI_vb", "default", "{controller}/{action}", {"Aj_quizEngineAPI_vb"})
    End Sub

End Class
