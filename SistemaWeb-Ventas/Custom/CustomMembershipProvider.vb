Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Security
Imports CapaEntidad
Imports CapaNegocio
Imports System.Runtime.InteropServices

Public Class CustomMembershipProvider
    Inherits MembershipProvider

    Public Overrides Function ValidateUser(ByVal username As String, ByVal password As String) As Boolean
        Dim ok As Boolean = False
        ' Dim objetoCN_Usuario As CN_Usuario = New CN_Usuario()
        Dim objetoCN_Usuario As CN_Usuario
        objetoCN_Usuario = New CN_Usuario()

        Dim objE_Usuario As CE_Usuario

        objE_Usuario = objetoCN_Usuario.Login(username, password)

        If objE_Usuario IsNot Nothing Then
            ok = True
        End If

        Return ok
    End Function

    Public Overrides Function ChangePassword(ByVal username As String, ByVal oldPassword As String, ByVal newPassword As String) As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Function ChangePasswordQuestionAndAnswer(ByVal username As String, ByVal password As String, ByVal newPasswordQuestion As String, ByVal newPasswordAnswer As String) As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Function CreateUser(ByVal username As String, ByVal password As String, ByVal email As String, ByVal passwordQuestion As String, ByVal passwordAnswer As String, ByVal isApproved As Boolean, ByVal providerUserKey As Object, <Out> ByRef status As MembershipCreateStatus) As MembershipUser
        Throw New NotImplementedException()
    End Function

    Public Overrides Function DeleteUser(ByVal username As String, ByVal deleteAllRelatedData As Boolean) As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides ReadOnly Property EnablePasswordReset As Boolean
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property EnablePasswordRetrieval As Boolean
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides Function FindUsersByEmail(ByVal emailToMatch As String, ByVal pageIndex As Integer, ByVal pageSize As Integer, <Out> ByRef totalRecords As Integer) As MembershipUserCollection
        Throw New NotImplementedException()
    End Function

    Public Overrides Function FindUsersByName(ByVal usernameToMatch As String, ByVal pageIndex As Integer, ByVal pageSize As Integer, <Out> ByRef totalRecords As Integer) As MembershipUserCollection
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetAllUsers(ByVal pageIndex As Integer, ByVal pageSize As Integer, <Out> ByRef totalRecords As Integer) As MembershipUserCollection
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetNumberOfUsersOnline() As Integer
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetPassword(ByVal username As String, ByVal answer As String) As String
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetUser(ByVal username As String, ByVal userIsOnline As Boolean) As MembershipUser
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetUser(ByVal providerUserKey As Object, ByVal userIsOnline As Boolean) As MembershipUser
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetUserNameByEmail(ByVal email As String) As String
        Throw New NotImplementedException()
    End Function

    Public Overrides ReadOnly Property MaxInvalidPasswordAttempts As Integer
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property MinRequiredNonAlphanumericCharacters As Integer
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property MinRequiredPasswordLength As Integer
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property PasswordAttemptWindow As Integer
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property PasswordFormat As MembershipPasswordFormat
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property PasswordStrengthRegularExpression As String
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property RequiresQuestionAndAnswer As Boolean
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides ReadOnly Property RequiresUniqueEmail As Boolean
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Overrides Function ResetPassword(ByVal username As String, ByVal answer As String) As String
        Throw New NotImplementedException()
    End Function

    Public Overrides Function UnlockUser(ByVal userName As String) As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Sub UpdateUser(ByVal user As MembershipUser)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Property ApplicationName As String
        Get
            Throw New NotImplementedException()
        End Get
        Set(ByVal value As String)
            Throw New NotImplementedException()
        End Set
    End Property
End Class
