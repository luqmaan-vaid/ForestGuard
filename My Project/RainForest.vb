Option Strict On
Option Explicit On
Option Infer Off
Public Class RainForest
    Inherits Forest
    Private _minimumTreeDensity As Double
    Public Sub New(forestName As String, location As String, landSize As Double, age As Integer)

        MyBase.New(forestName, location, landSize, age)
        _minimumTreeDensity = 20
    End Sub

    Public ReadOnly Property minimumTreeDensity As Double
        Get
            Return _minimumTreeDensity
        End Get
    End Property

    ' Calculate risk specifically for a rainforest:
    Public Overrides Function CalculateRiskLevel() As String

        Dim density As Double = CalculateTreeDensity()

        If density >= _minimumTreeDensity Then
            Return "Low"
        ElseIf density >= _minimumTreeDensity / 2 Then
            Return "Medium"
        Else
            Return "High"
        End If

    End Function

End Class
