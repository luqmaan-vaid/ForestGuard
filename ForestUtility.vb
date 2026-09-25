Option Strict On
Option Explicit On
Option Infer On

Public NotInheritable Class ForestUtility
    Public Const FINE_PER_TREE As Double = 500.0
    Public Const MAX_HARVEST_PERCENTAGE As Double = 0.1

    Private Sub New()
    End Sub

    Public Shared Function CalculateFine(amountHarvested As Integer, amountReplanted As Integer) As Double
        Dim deficit As Integer = amountHarvested - amountReplanted
        If deficit < 0 Then
            deficit = 0
        End If
        Return deficit * FINE_PER_TREE
    End Function

    Public Shared Function CalculatePercentage(amount As Double, total As Double) As Double
        If total <= 0 Then
            Return 0
        End If
        Return (amount / total) * 100
    End Function

    Public Shared Function CalculateTreeDensity(totalTrees As Integer, landSize As Double) As Double
        If landSize <= 0 Then
            Return 0
        End If
        Return totalTrees / landSize
    End Function

    Public Shared Function IsNegative(value As Double) As Boolean
        If value < 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
