Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports DotNetNuke.Web.Api

Public Class AndreasController
    Inherits DnnApiController

    <AllowAnonymous>
    <HttpGet>
    Public Function Quiztest() As HttpResponseMessage
        Dim dal As New aj_QuizDAL

        Return Request.CreateResponse(HttpStatusCode.OK, dal.testarlinq)
    End Function

    <AllowAnonymous>
    <HttpGet>
    Public Function Test() As HttpResponseMessage

        Return Request.CreateResponse(HttpStatusCode.OK, "funkar")
    End Function
End Class

