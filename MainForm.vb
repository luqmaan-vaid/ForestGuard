Option Strict On
Option Explicit On
Option Infer Off
Public Class MainForm
    Private _forestManager As ForestManager


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _forestManager = New ForestManager()
    End Sub

    Private Sub btnCreateForest_Click(sender As Object, e As EventArgs) Handles btnCreateForest.Click
        Try

            Dim forestName As String
            Dim location As String
            Dim landSize As Double
            Dim age As Integer
            Dim forestType As String

            forestName = InputBox("Enter the forest name:", "Create Forest")
            location = InputBox("Enter the forest location:", "Create Forest")
            landSize = CDbl(InputBox("Enter the land size:", "Create Forest"))
            age = CInt(InputBox("Enter the age of the forest:", "Create Forest"))
            forestType = InputBox("Enter the forest type:" & vbCrLf &
                                  "Rainforest" & vbCrLf &
                                  "Temperate Forest",
                                  "Create Forest")

            Dim forest As Forest

            If forestType.ToLower() = "rainforest" Then

                forest = New RainForest(
                    forestName,
                    location,
                    landSize,
                    age)

            ElseIf forestType.ToLower() = "temperate forest" Then

                forest = New TemperateForest(
                    forestName,
                    location,
                    landSize,
                    age)

            Else

                MessageBox.Show("Invalid forest type.")
                Exit Sub

            End If

            If _forestManager.AddForest(forest) Then

                cmbSelectForest.Items.Add(forest.ForestName)
                cmbSelectForest.SelectedItem = forest.ForestName

                MessageBox.Show("Forest created successfully.")

            Else

                MessageBox.Show("A forest with that name already exists.")

            End If

        Catch ex As FormatException

            MessageBox.Show("Please enter numbers correctly.")

        Catch ex As OverflowException

            MessageBox.Show("The number entered is too large.")

        Catch ex As Exception

            MessageBox.Show("Error creating forest: " & ex.Message)

        End Try
    End Sub

    Private Sub btnRemoveForest_Click(sender As Object, e As EventArgs) Handles btnRemoveForest.Click
        Try

            If cmbSelectForest.SelectedIndex = -1 Then

                MessageBox.Show("Please select a forest first.")
                Exit Sub

            End If

            Dim forestName As String =
            cmbSelectForest.SelectedItem.ToString()

            If _forestManager.RemoveForest(forestName) Then

                cmbSelectForest.Items.Remove(forestName)

                MessageBox.Show("Forest removed successfully.")

            Else

                MessageBox.Show("Forest could not be found.")

            End If

        Catch ex As Exception

            MessageBox.Show("Error removing forest: " & ex.Message)

        End Try

    End Sub


    Private Sub btnViewForest_Click(sender As Object, e As EventArgs) Handles btnViewForest.Click
        Try

            If cmbSelectForest.SelectedIndex = -1 Then

                MessageBox.Show("Please select a forest first.")
                Exit Sub

            End If

            Dim forestName As String =
            cmbSelectForest.SelectedItem.ToString()

            Dim forest As Forest =
            _forestManager.FindForest(forestName)

            If forest Is Nothing Then

                MessageBox.Show("Forest could not be found.")
                Exit Sub

            End If

            Dim output As String = ""

            output += "Forest Name: " & forest.ForestName & vbCrLf
            output += "Location: " & forest.Location & vbCrLf
            output += "Land Size: " & forest.LandSize & " ha" & vbCrLf
            output += "Age: " & forest.Age & " years" & vbCrLf
            output += "Status: " & forest.Status & vbCrLf
            output += "Tree Types: " & forest.TreeCount

            MessageBox.Show(output, "Forest Details")

        Catch ex As Exception

            MessageBox.Show("Error displaying forest: " & ex.Message)

        End Try
    End Sub

    Private Sub btnAddTrees_Click(sender As Object, e As EventArgs) Handles btnAddTrees.Click
        Try
            If cmbSelectForest.SelectedIndex = -1 Then
                MessageBox.Show("Please select a forest first.")
                Exit Sub
            End If

            Dim forestName As String =
                cmbSelectForest.SelectedItem.ToString()

            Dim forest As Forest =
                _forestManager.FindForest(forestName)

            If forest Is Nothing Then
                MessageBox.Show("Forest could not be found.")
                Exit Sub
            End If

            Dim treeType As String
            Dim amount As Integer
            Dim growthRate As Double
            Dim waterRequirement As Double
            Dim maximumSize As Double
            Dim usage As String

            treeType = InputBox("Enter the tree type:", "Add Trees")
            amount = CInt(InputBox("Enter the number of trees:", "Add Trees"))
            growthRate = CDbl(InputBox("Enter the growth rate:", "Add Trees"))
            waterRequirement = CDbl(InputBox("Enter the water requirement:", "Add Trees"))
            maximumSize = CDbl(InputBox("Enter the maximum size:", "Add Trees"))
            usage = InputBox("Enter the tree usage:", "Add Trees")

            forest.AddTrees(treeType, amount, growthRate,
                            waterRequirement, maximumSize, usage)

            MessageBox.Show("Trees added successfully.")

        Catch ex As FormatException
            MessageBox.Show("Please enter numbers correctly.")
        Catch ex As OverflowException
            MessageBox.Show("The number entered is too large.")
        Catch ex As Exception
            MessageBox.Show("Error adding trees: " & ex.Message)
        End Try
    End Sub

    Private Sub btnViewTrees_Click(sender As Object, e As EventArgs) Handles btnViewTrees.Click
        Try
            If cmbSelectForest.SelectedIndex = -1 Then
                MessageBox.Show("Please select a forest first.")
                Exit Sub
            End If

            Dim forestName As String =
                cmbSelectForest.SelectedItem.ToString()

            Dim forest As Forest =
                _forestManager.FindForest(forestName)

            If forest Is Nothing Then
                MessageBox.Show("Forest could not be found.")
                Exit Sub
            End If

            If forest.TreeCount = 0 Then
                MessageBox.Show("This forest has no trees.")
                Exit Sub
            End If

            Dim output As String = ""

            For i As Integer = 1 To forest.TreeCount
                output += "Tree Type: " & forest.Trees(i).TreeType & vbCrLf
                output += "Amount: " & forest.Trees(i).TreeCount & vbCrLf
                output += "Growth Rate: " & forest.Trees(i).GrowthRate & vbCrLf
                output += "Water Requirement: " & forest.Trees(i).WaterRequirement & vbCrLf
                output += "Maximum Size: " & forest.Trees(i).MaximumSize & vbCrLf
                output += "Usage: " & forest.Trees(i).Usage & vbCrLf
                output += "------------------------" & vbCrLf
            Next

            MessageBox.Show(output, "Tree Details")

        Catch ex As Exception
            MessageBox.Show("Error displaying trees: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCalculateDensity_Click(sender As Object, e As EventArgs) Handles btnCalculateDensity.Click
        Try
            If cmbSelectForest.SelectedIndex = -1 Then
                MessageBox.Show("Please select a forest first.")
                Exit Sub
            End If

            Dim forestName As String =
                cmbSelectForest.SelectedItem.ToString()

            Dim forest As Forest =
                _forestManager.FindForest(forestName)

            If forest Is Nothing Then
                MessageBox.Show("Forest could not be found.")
                Exit Sub
            End If

            Dim density As Double = forest.CalculateTreeDensity()

            MessageBox.Show("Tree Density: " & density & " trees per hectare",
                            "Forest Analysis")

        Catch ex As Exception
            MessageBox.Show("Error calculating density: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCheckRisk_Click(sender As Object, e As EventArgs) Handles btnCheckRisk.Click
        Try
            If cmbSelectForest.SelectedIndex = -1 Then
                MessageBox.Show("Please select a forest first.")
                Exit Sub
            End If

            Dim forestName As String =
                cmbSelectForest.SelectedItem.ToString()

            Dim forest As Forest =
                _forestManager.FindForest(forestName)

            If forest Is Nothing Then
                MessageBox.Show("Forest could not be found.")
                Exit Sub
            End If

            forest.UpdateStatus()

            MessageBox.Show("Risk Level: " & forest.CalculateRiskLevel() &
                            vbCrLf &
                            "Status: " & forest.Status,
                            "Forest Analysis")

        Catch ex As Exception
            MessageBox.Show("Error checking risk: " & ex.Message)
        End Try
    End Sub

    Private Sub btnHarvestTrees_Click(sender As Object, e As EventArgs) Handles btnHarvestTrees.Click
        Private Sub btnHarvestTrees_Click(sender As Object, e As EventArgs) Handles btnHarvestTrees.Click
        Try
            If cmbSelectForest.SelectedIndex = -1 Then
                MessageBox.Show("Please select a forest first.")
                Exit Sub
            End If

            Dim forestName As String =
                cmbSelectForest.SelectedItem.ToString()

            Dim forest As Forest =
                _forestManager.FindForest(forestName)

            If forest Is Nothing Then
                MessageBox.Show("Forest could not be found.")
                Exit Sub
            End If

            If forest.CanHarvest() = False Then
                MessageBox.Show("Harvesting is not allowed because the forest has a high risk level.")
                Exit Sub
            End If

            Dim companyName As String
            Dim treeType As String
            Dim amount As Integer
            Dim amountReplanted As Integer

            companyName = InputBox("Enter the company name:", "Harvest Trees")
            treeType = InputBox("Enter the tree type to harvest:", "Harvest Trees")
            amount = CInt(InputBox("Enter the number of trees to harvest:", "Harvest Trees"))
            amountReplanted = CInt(InputBox("Enter the number of trees to replant:", "Harvest Trees"))

            Dim record As HarvestRecord =
                forest.HarvestTree(companyName, treeType, amount, amountReplanted)

            If record Is Nothing Then
                MessageBox.Show("Harvest could not be completed." &
                                vbCrLf &
                                "Check the tree type, amount, or maximum harvest limit.")
                Exit Sub
            End If

            MessageBox.Show("Harvest completed." &
                            vbCrLf &
                            "Company: " & record.CompanyName &
                            vbCrLf &
                            "Trees harvested: " & record.AmountHarvested &
                            vbCrLf &
                            "Trees replanted: " & record.AmountReplanted &
                            vbCrLf &
                            "Fine: R" & record.Fine,
                            "Harvest Complete")

        Catch ex As FormatException
            MessageBox.Show("Please enter numbers correctly.")
        Catch ex As OverflowException
            MessageBox.Show("The number entered is too large.")
        Catch ex As Exception
            MessageBox.Show("Error during harvesting: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
