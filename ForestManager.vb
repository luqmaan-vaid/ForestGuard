
Option Strict On
Option Explicit On
Option Infer Off

Public Class ForestManager

        Private _forests() As Forest
        Private _forestCount As Integer

        Public Sub New()

            _forestCount = 0
        ReDim _forests(1)

    End Sub

        Public Function AddForest(forest As Forest) As Boolean

            If forest Is Nothing Then
                Return False
            End If

            For i As Integer = 1 To _forestCount

                If _forests(i).ForestName = forest.ForestName Then
                    Return False
                End If

            Next

            _forestCount += 1

            If _forestCount > 1 Then
            ReDim Preserve _forests(_forestCount)
        End If

            _forests(_forestCount) = forest

            Return True

        End Function

        Public Function RemoveForest(forestName As String) As Boolean

            For i As Integer = 1 To _forestCount

                If _forests(i).ForestName = forestName Then

                    For j As Integer = i To _forestCount - 1
                        _forests(j) = _forests(j + 1)
                    Next

                    _forests(_forestCount) = Nothing
                    _forestCount -= 1

                    Return True

                End If

            Next

            Return False

        End Function

        Public Function FindForest(forestName As String) As Forest

            For i As Integer = 1 To _forestCount

                If _forests(i).ForestName = forestName Then
                    Return _forests(i)
                End If

            Next

            Return Nothing

        End Function

        Public ReadOnly Property ForestCount As Integer
            Get
                Return _forestCount
            End Get
        End Property

        Public ReadOnly Property Forests As Forest()
            Get
                Return _forests
            End Get
        End Property

    End Class

