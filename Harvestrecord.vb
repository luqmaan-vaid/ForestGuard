Option Strict On
Option Explicit On
Option Infer Off

Public Class HarvestRecord
    Private _companyName As String
    Private _treeType As String
    Private _amountHarvested As Integer
    Private _amountReplanted As Integer
    Private _fine As Double

    Public Sub New(companyName As String, treeType As String, amountHarvested As Integer, amountReplanted As Integer, fine As Double)
        _companyName = companyName
        _treeType = treeType
        _amountHarvested = amountHarvested
        _amountReplanted = amountReplanted
        _fine = fine
    End Sub

    Public ReadOnly Property CompanyName As String
        Get
            Return _companyName
        End Get
    End Property

    Public ReadOnly Property TreeType As String
        Get
            Return _treeType
        End Get
    End Property

    Public ReadOnly Property AmountHarvested As Integer
        Get
            Return _amountHarvested
        End Get
    End Property

    Public ReadOnly Property AmountReplanted As Integer
        Get
            Return _amountReplanted
        End Get
    End Property

    Public ReadOnly Property Fine As Double
        Get
            Return _fine
        End Get
    End Property
End Class
