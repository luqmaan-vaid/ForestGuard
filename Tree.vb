Option Strict On
Option Explicit On
Option Infer On

Public Class Tree
    Private _treeType As String
    Private _treeCount As Integer
    Private _growthRate As Double
    Private _waterRequirement As Double
    Private _maximumSize As Double
    Private _usage As String

    Public Sub New(treeType As String, treeCount As Integer, growthRate As Double, waterRequirement As Double, maximumSize As Double, usage As String)
        _treeType = treeType
        _treeCount = treeCount
        _growthRate = growthRate
        _waterRequirement = waterRequirement
        _maximumSize = maximumSize
        _usage = usage
    End Sub

    Public Sub AddTrees(amount As Integer)
        If amount <= 0 Then
            Exit Sub
        End If
        _treeCount += amount

    End Sub

    Public Sub RemoveTrees(amount As Integer)
        If amount <= 0 Then
            Exit Sub

        End If
        If amount > _treeCount Then
            Exit Sub
        End If
        _treeCount -= amount
    End Sub

    Public ReadOnly Property TreeType As String
        Get
            Return _treeType
        End Get
    End Property

    Public ReadOnly Property TreeCount As Integer
        Get
            Return _treeCount
        End Get
    End Property

    Public ReadOnly Property GrowthRate As Double
        Get
            Return _growthRate
        End Get
    End Property

    Public ReadOnly Property WaterRequirement As Double
        Get
            Return _waterRequirement
        End Get
    End Property

    Public ReadOnly Property MaximumSize As Double
        Get
            Return _maximumSize
        End Get
    End Property

    Public ReadOnly Property Usage As String
        Get
            Return _usage
        End Get

    End Property

End Class
