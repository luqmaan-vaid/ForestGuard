Option Strict On
Option Explicit On
Option Infer Off
Public MustInherit Class Forest
    Protected _forestName As String
    Protected _location As String
    Protected _landSize As Double
    Protected _age As Integer
    Protected _status As String
    Protected _trees() As Tree
    Protected _treeCount As Integer
    Public Sub New(forestName As String, location As String, landSize As Double, age As Integer)

        _forestName = forestName
        _location = location
        _landSize = landSize
        _age = age
        _status = "Healthy"
        _treeCount = 0
        ReDim _trees(1)

    End Sub
    Public Sub AddTrees(treeType As String, amount As Integer, growthRate As Double, waterRequirement As Double,
                        maximumSize As Double, usage As String)

        If amount <= 0 Then
            Exit Sub
        End If

        For i As Integer = 1 To _treeCount

            If _trees(i).TreeType = treeType Then
                _trees(i).AddTrees(amount)
                Exit Sub
            End If

        Next


        _treeCount += 1
        ReDim Preserve _trees(_treeCount)
        _trees(_treeCount) = New Tree(treeType,
                              amount,
                              growthRate,
                              waterRequirement,
                              maximumSize,
                              usage)

    End Sub


    Public Function CalculateTreeDensity() As Double

        Dim totalTrees As Integer = 0


        For i As Integer = 1 To _treeCount
            totalTrees += _trees(i).TreeCount
        Next

        Return ForestUtility.CalculateTreeDensity(totalTrees, _landSize)

    End Function
    ' Each forest type calculates risk differently:
    Public MustOverride Function CalculateRiskLevel() As String

    Public Function CanHarvest() As Boolean

        If CalculateRiskLevel() = "High" Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function HarvestTree(companyName As String, treeType As String, amount As Integer, amountReplanted As Integer) As Harvestrecord

        ' Check whether harvesting is allowed:
        If CanHarvest() = False Then
            Return Nothing
        End If

        ' Check that the amount is valid:
        If amount <= 0 Then
            Return Nothing
        End If

        ' Check that the amount replanted is not negative:
        If amountReplanted < 0 Then
            Return Nothing
        End If

        ' Find the tree type:
        For i As Integer = 1 To _treeCount

            If _trees(i).TreeType = treeType Then

                ' Calculate the maximum amount that can be harvested:
                Dim maximumHarvest As Integer =
                CInt(_trees(i).TreeCount * ForestUtility.MAX_HARVEST_PERCENTAGE)

                ' Check whether the requested amount is allowed:
                If amount > maximumHarvest Then
                    Return Nothing
                End If

                ' Remove the harvested trees:
                _trees(i).RemoveTrees(amount)

                ' Add the replanted trees:
                _trees(i).AddTrees(amountReplanted)

                Dim fine As Double = ForestUtility.CalculateFine(amount, amountReplanted)

                ' Update the forest status:
                UpdateStatus()

                ' Create a record of the harvest:
                Return New Harvestrecord(companyName, treeType, amount, amountReplanted, fine)

            End If

        Next

        ' Tree type was not found:
        Return Nothing
    End Function
    ' Update status based on the current risk level:
    Public Sub UpdateStatus()

        Dim riskLevel As String = CalculateRiskLevel()

        If riskLevel = "Low" Then
            _status = "Healthy"
        ElseIf riskLevel = "Medium" Then
            _status = "At Risk"
        Else
            _status = "Critical"
        End If

    End Sub

    Public ReadOnly Property ForestName As String
        Get
            Return _forestName
        End Get
    End Property

    ' Location property:
    Public ReadOnly Property Location As String
        Get
            Return _location
        End Get
    End Property

    ' Land size property:
    Public ReadOnly Property LandSize As Double
        Get
            Return _landSize
        End Get
    End Property

    ' Age property:
    Public ReadOnly Property Age As Integer
        Get
            Return _age
        End Get
    End Property

    ' Status property:
    Public ReadOnly Property Status As String
        Get
            Return _status
        End Get
    End Property

    ' Trees property:
    Public ReadOnly Property Trees As Tree()
        Get
            Return _trees
        End Get
    End Property

    ' Number of tree types in the forest:
    Public ReadOnly Property TreeCount As Integer
        Get
            Return _treeCount
        End Get
    End Property


End Class
