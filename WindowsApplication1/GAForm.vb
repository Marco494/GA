#Region "Options"
Option Explicit On
Option Strict On
Option Infer Off
#End Region

#Region "Imports"
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms.DataVisualization.Charting
#End Region


'
Public Class GAForm

#Region "Declarations"

    Dim intChromosomes As Integer = 0
    Dim intPopSize As Integer = 0
    Dim intPopFit As Integer = 0
    Dim arraylistPop As New ArrayList
    Dim arrayPop As Array
    Dim arraylistPopDisplay As New ArrayList
    Dim arraylistPopMutated As New ArrayList
    Dim arraylistPopDisplayMutated As New ArrayList
    Dim arrayCrossedOver As Array
    Dim arraylistFitness As New ArrayList
    Dim arraylistTour As New ArrayList
    Dim arraylistTourFit As New ArrayList
    Dim arraylistBTD As New ArrayList
    Dim arraylistFunction1 As New ArrayList
    Dim arraylistFunction2 As New ArrayList
    Dim intFitPopSize As Integer = 0
    Dim dblCrossoverRate As Double
    Dim dblMutationRate As Decimal
    Dim intTourSize As Integer = 3
    Dim tourParents(1) As String
    Dim crossParents(1) As String
    Dim intGenSize As Integer = 1
    Dim seriesFit As New Series
    Dim intGenerationSize As Integer = 50
    Dim firstRun As Boolean = True
    Dim intSum As Integer = 0
    Dim dblAverage As Double = 0.0
    Dim intMax As Integer = 0

#End Region

#Region "Load Form"
    Public Sub GAForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Chart1.Series.Clear()

        seriesFit.ChartType = SeriesChartType.Line

        Chart1.Series.Add(seriesFit)

    End Sub

#End Region

#Region "Data Input"

    Private Sub txtChromosomes_TextChanged(sender As Object, e As EventArgs) Handles txtChromosomes.TextChanged
        If txtChromosomes.Text = "" Then
        Else
            intChromosomes = Convert.ToInt32(txtChromosomes.Text)
        End If
    End Sub

    Private Sub txtPop_TextChanged(sender As Object, e As EventArgs) Handles txtPop.TextChanged
        If txtPop.Text = "" Then
        Else
            intPopSize = Convert.ToInt32(txtPop.Text)
        End If
    End Sub



#End Region

#Region "Run"

    Private Sub run()

        Label3.Text = "Genetic Algorithm - Functions 0, 1, 2, 3"

        ClearData()

        Initialization()

        If NumericUpDown1.Value = 2 Or NumericUpDown1.Value = 3 Then
            TournamentSelectionMin()
        Else
            TournamentSelectionMax()
        End If

        Crossover(tourParents)
        BitFlipMutation()

        listPopulation.Items.Clear()
        listFitness.Items.Clear()
        listCross.Items.Clear()
        listMutation.Items.Clear()
        listDecimal.Items.Clear()

        listPopulation.Items.AddRange(arraylistPopDisplay.ToArray)
        listFitness.Items.AddRange(arraylistFitness.ToArray)
        listCross.Items.AddRange(tourParents)
        listMutation.Items.AddRange(arraylistPopDisplayMutated.ToArray)
        listDecimal.Items.AddRange(arraylistBTD.ToArray())

        If NumericUpDown1.Value = 0 Then
            listDecimal.Items.Clear()
            listDecimal.Items.Add("N/A")
            listFitness.Items.Clear()
            listFitness.Items.Add("N/A")
            TextBox1.Text = "N/A"
            TextBox2.Text = "N/A"
            TextBox3.Text = "N/A"
            FitnessChart(arraylistBTD)
        End If

        If NumericUpDown1.Value = 1 Then
            function1()
            FitnessChart(arraylistFunction1)
        End If

        If NumericUpDown1.Value = 2 Then
            function2()
            FitnessChart(arraylistFunction2)
        End If

        If NumericUpDown1.Value = 3 Then
            function3()
            Label3.Text = "Not Implemented Yet"
        End If
    End Sub

#End Region

#Region "Generations"

    Private Sub generations()

        Dim temp As Integer

        While temp <> NumericUpDown2.Value

            run()

            temp = temp + 1

        End While

    End Sub

#End Region

#Region "Start Button"

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click

        generations()

    End Sub

#End Region

#Region "Initialization"

    Private Sub Initialization()

        If firstRun = True Then
            Dim temp As Integer = 0

            While temp <> intPopSize
                System.Threading.Thread.Sleep(1)
                Dim rand As New Random(Now.Millisecond)
                Dim array() As Integer = {}

                For I As Integer = 1 To intChromosomes
                    ReDim Preserve array(I - 1)
                    array(I - 1) = rand.Next(0, 2)
                Next

                arraylistPop.Add(array)
                arraylistPopDisplay.Add(ArrayToString(array))

                temp = temp + 1

                Fitness(array)
            End While
            firstRun = False
        Else

            Dim temp As Integer = 0
            Dim intChromosomesRun As Integer = 0

            While temp <> intPopSize
                Dim array() As Integer = {}
                Dim strTemp As String = ""

                strTemp = String.Join("", arraylistPopDisplayMutated.ToArray)
                Dim chars() As Char = strTemp.ToCharArray()

                For I As Integer = 1 To intChromosomes
                    ReDim Preserve array(I - 1)
                    array(I - 1) = CInt(chars((I + intChromosomesRun) - 1).ToString)
                Next

                intChromosomesRun = intChromosomesRun + intChromosomes

                arraylistPop.Add(array)
                arraylistPopDisplay.Add(ArrayToString(array))

                temp = temp + 1

                Fitness(array)
            End While

            arraylistPopDisplayMutated.Clear()
            arraylistPopMutated.Clear()

        End If

        'Dim temp1 As Integer = 0

        'While temp1 <> intPopSize
        '    Dim array() As Integer = {}
        '    Dim strTemp As String = ""

        '    strTemp = String.Join("", arraylistPopDisplay.ToArray)
        '    Dim chars() As Char = strTemp.ToCharArray()

        '    For I As Integer = 1 To intChromosomes
        '        ReDim Preserve array(I - 1)
        '        array(I - 1) = CInt(chars(I - 1).ToString)
        '    Next

        '    Fitness(array)
        '    temp1 = temp1 + 1
        'End While

    End Sub

#End Region

#Region "Tournament Selection"

    Private Sub TournamentSelectionMin()
        Dim parentCount As Integer = 0

        While parentCount <> 2

            arraylistTour.Clear()
            arraylistTourFit.Clear()
            Dim temp As Integer = 0
            Dim temp1 As Integer = 0
            Dim temp2 As Integer = 0
            Dim temp3 As Integer = 0

            Dim TourParent As String = ""
            Dim TourParentFit As String = ""
            Dim intNumber As Integer
            Dim arrNumber(0 To (intTourSize - 1)) As Integer

            For temp1 = 0 To (intTourSize - 1)
Start:
                Randomize()
                intNumber = CInt(Int((intPopSize * Rnd()) + 1))
                For temp2 = 0 To (intTourSize - 1)
                    If intNumber = arrNumber(temp2) Then
                        GoTo Start
                    End If
                Next temp2
                arrNumber(temp1) = intNumber

            Next temp1

            While temp <> intTourSize

                arraylistTour.Add(ArrayToString(CType(arraylistPop.Item(arrNumber(temp) - 1), Integer())))
                arraylistTourFit.Add(arraylistFitness.Item(arrNumber(temp) - 1))

                temp = temp + 1
            End While

            Dim firstTourRun As Boolean = True

            While temp3 <> temp
                If firstTourRun = True Then
                    TourParentFit = Nothing
                    TourParentFit = arraylistTourFit(temp3).ToString

                    TourParent = Nothing
                    TourParent = arraylistTour(temp3).ToString
                    firstTourRun = False
                End If

                If TourParentFit > arraylistTourFit(temp3).ToString Then

                    TourParentFit = Nothing
                    TourParentFit = arraylistTourFit(temp3).ToString

                    TourParent = Nothing
                    TourParent = arraylistTour(temp3).ToString
                End If

                temp3 = temp3 + 1

            End While

            tourParents(parentCount) = TourParent

            parentCount = parentCount + 1
            System.Threading.Thread.Sleep(1)

        End While

    End Sub

    Private Sub TournamentSelectionMax()
        Dim parentCount As Integer = 0

        While parentCount <> 2

            arraylistTour.Clear()
            arraylistTourFit.Clear()
            Dim temp As Integer = 0
            Dim temp1 As Integer = 0
            Dim temp2 As Integer = 0
            Dim temp3 As Integer = 0

            Dim TourParent As String = ""
            Dim TourParentFit As String = ""
            Dim intNumber As Integer
            Dim arrNumber(0 To (intTourSize - 1)) As Integer

            For temp1 = 0 To (intTourSize - 1)
Start:
                Randomize()
                intNumber = CInt(Int((intPopSize * Rnd()) + 1))
                For temp2 = 0 To (intTourSize - 1)
                    If intNumber = arrNumber(temp2) Then
                        GoTo Start
                    End If
                Next temp2
                arrNumber(temp1) = intNumber

            Next temp1

            While temp <> intTourSize

                arraylistTour.Add(ArrayToString(CType(arraylistPop.Item(arrNumber(temp) - 1), Integer())))
                arraylistTourFit.Add(arraylistFitness.Item(arrNumber(temp) - 1))

                temp = temp + 1
            End While

            Dim firstTourRun As Boolean = True

            While temp3 <> temp

                If TourParentFit < arraylistTourFit(temp3).ToString Then

                    TourParentFit = Nothing
                    TourParentFit = arraylistTourFit(temp3).ToString

                    TourParent = Nothing
                    TourParent = arraylistTour(temp3).ToString
                End If

                temp3 = temp3 + 1

            End While

            tourParents(parentCount) = TourParent

            parentCount = parentCount + 1
            System.Threading.Thread.Sleep(1)

        End While

    End Sub

#End Region

#Region "Crossover"

    Private Sub Crossover(parents() As String)

        Dim strParents As String
        Dim intParentsLength As Integer
        Dim intParentLength As Integer

        strParents = String.Join("", parents)
        intParentsLength = strParents.Length()
        intParentLength = CInt(intParentsLength / 2)

        Dim crossoverPoint As Integer
        System.Threading.Thread.Sleep(1)
        Dim rand As New Random(Now.Millisecond)

        crossoverPoint = rand.Next(0, (intParentLength + 1))

        Dim strParent1 As String
        Dim strParent2 As String

        strParent1 = strParents.Substring(0, intParentLength)
        strParent2 = strParents.Substring(intParentLength, intParentLength)

        Dim strParent1a As String
        Dim strParent1b As String

        strParent1a = strParent1.Substring(0, crossoverPoint)
        strParent1b = strParent1.Substring(crossoverPoint, (strParent1.Length - crossoverPoint))

        Dim strParent2a As String
        Dim strParent2b As String

        strParent2a = strParent2.Substring(0, crossoverPoint)
        strParent2b = strParent2.Substring(crossoverPoint, (strParent2.Length - crossoverPoint))

        crossParents(0) = String.Concat(strParent1a, strParent2b)
        crossParents(1) = String.Concat(strParent2a, strParent1b)

        Dim temp As Integer = 0
        Dim fitnessTemp As Integer = intChromosomes * intPopSize
        Dim fitnessPosition1 As Integer

        While temp < arraylistFitness.Count

            If CInt(arraylistFitness(temp)) < fitnessTemp Then

                fitnessTemp = CInt(arraylistFitness(temp))
                fitnessPosition1 = temp

            End If


            temp = temp + 1
        End While

        arraylistPop(fitnessPosition1) = crossParents(0)
        arraylistPopDisplay(fitnessPosition1) = crossParents(0)

        Dim temp1 As Integer = 0
        Dim fitnessTemp1 As Integer = intChromosomes * intPopSize
        Dim fitnessPosition2 As Integer

        While temp1 < arraylistFitness.Count

            If temp1 <> fitnessPosition1 Then
                If CInt(arraylistFitness(temp1)) < fitnessTemp1 Then
                    fitnessTemp1 = CInt(arraylistFitness(temp1))
                    fitnessPosition2 = temp1
                End If
            End If

            temp1 = temp1 + 1
        End While

        arraylistPop(fitnessPosition2) = crossParents(1)
        arraylistPopDisplay(fitnessPosition2) = crossParents(1)


    End Sub

#End Region

#Region "Bit Flip Mutation"

    Private Sub BitFlipMutation()
        Dim intRate As Integer = 0
        Dim intTemp As Integer = 0
        Dim strTemp As String = ""

        strTemp = String.Join("", arraylistPopDisplay.ToArray)
        Dim chars() As Char = strTemp.ToCharArray()

        intRate = CInt((intChromosomes * intPopSize) * nudMutation.Value)

        While intTemp <> intRate
            Dim charPopMutated((intChromosomes * intPopSize) - 1) As Char
            Dim random As New Random(Now.Millisecond)
            System.Threading.Thread.Sleep(1)
            Dim rand As Integer = random.Next(0, (intChromosomes * intPopSize))
            Dim intChar As Integer = CInt(chars(rand).ToString)

            Dim ctr As Integer

            If intChar = 1 Then
                intChar = 0
            Else
                intChar = 1
            End If

            For ctr = 0 To chars.Length - 1
                If ctr = rand Then
                    charPopMutated(ctr) = CChar(intChar.ToString)
                Else
                    charPopMutated(ctr) = chars(ctr)
                End If
            Next
            chars = charPopMutated


            intTemp = intTemp + 1
        End While

        Dim tempSize As Integer

        While tempSize <> chars.Length()

            Dim temp As Integer = 0

            While temp <> intPopSize
                Dim array(intPopSize) As Integer

                Dim tempSize1 As Integer = 0

                While tempSize1 <> intChromosomes
                    ReDim Preserve array(tempSize1)
                    array(tempSize1) = CInt(chars(tempSize).ToString)
                    tempSize = tempSize + 1
                    tempSize1 = tempSize1 + 1
                End While

                arraylistPopMutated.Add(array)
                arraylistPopDisplayMutated.Add(ArrayToString(array))
                binaryToDecimal(ArrayToString(array))

                temp = temp + 1
            End While

        End While

    End Sub

#End Region

#Region "Survivor Selection"
    Private Sub SurvivorSelection()

    End Sub
#End Region

#Region "Fitness"

    Private Sub Fitness(intIndividuals As Array)
        Dim sum As Integer

        'If intFitPopSize <> intPopSize Then
        For Each item As Integer In intIndividuals
            sum += item
            'intFitPopSize = intFitPopSize + 1
        Next
        arraylistFitness.Add(sum)
        'End If

    End Sub

    Private Sub FitnessChart(intFitness As ArrayList)
        Dim sum As Integer
        intFitPopSize = 0

        If intFitPopSize <> intPopSize Then
            For Each item As Integer In intFitness
                sum += item
                intFitPopSize = intFitPopSize + 1
            Next
            intPopFit = sum
        End If

        seriesFit.Points.AddXY(intGenSize, sum)

        intGenSize = intGenSize + 1

    End Sub

#End Region

#Region "Converting Binary to Decimal"

    Public Sub binaryToDecimal(binary As String)
        Dim dblDecimal As Double = Nothing
        Dim intLength As Integer = Len(binary)
        Dim temp As Integer = Nothing
        Dim x As Integer = Nothing
        For x = 1 To intLength
            temp = CInt(Val(Mid(binary, intLength, 1)))
            intLength = intLength - 1
            If temp <> 0 Then
                dblDecimal += (2 ^ (x - 1))
            End If
        Next
        arraylistBTD.Add(dblDecimal)
    End Sub

#End Region

#Region "Converting Array to String"

    Function ArrayToString(array As Integer()) As String
        Dim stringBuilder As New System.Text.StringBuilder
        For temp As Integer = 0 To UBound(array)
            If temp = UBound(array) Then
                stringBuilder.Append(array(temp).ToString)
            Else
                stringBuilder.Append(array(temp).ToString)
            End If
        Next
        Return stringBuilder.ToString
    End Function

#End Region

#Region "Function 1"

    Private Sub function1()

        Dim temp As Integer

        Dim tempArray(arraylistBTD.Count) As Integer

        While temp <> arraylistBTD.Count
            arraylistFunction1.Add(CInt(arraylistBTD(temp)) * CInt(arraylistBTD(temp)))
            tempArray(temp) = (CInt(arraylistBTD(temp)) * CInt(arraylistBTD(temp)))


            If intMax < (CInt(arraylistBTD(temp)) * CInt(arraylistBTD(temp))) Then
                intMax = (CInt(arraylistBTD(temp)) * CInt(arraylistBTD(temp)))
                TextBox3.Text = intMax.ToString
            End If

            intSum = intSum + (CInt(arraylistBTD(temp)) * CInt(arraylistBTD(temp)))
            TextBox1.Text = intSum.ToString

            temp = temp + 1
        End While

        dblAverage = tempArray.Average
        TextBox2.Text = dblAverage.ToString

        listFunctions.Items.Clear()
        listFunctions.Items.AddRange(arraylistFunction1.ToArray)

    End Sub

#End Region

#Region "Function 2"

    Private Sub function2()

        Dim temp As Integer
        Dim tempArray(arraylistBTD.Count) As Double

        While temp <> arraylistBTD.Count
            Dim x As Integer = CInt(arraylistBTD(temp))
            Dim y As Integer = CInt(arraylistBTD(temp + 1))

            If (temp + 1) > arraylistBTD.Count Then
                Exit While
            End If

            Dim calc As Double = (0.26 * ((x * x) + (y * y)) - 0.48 * x * y)
            arraylistFunction2.Add(CInt(calc))
            tempArray(temp) = calc


            If intMax < CInt(calc) Then
                intMax = CInt(calc)
                TextBox3.Text = intMax.ToString
            End If

            intSum = intSum + CInt(calc)
            TextBox1.Text = intSum.ToString

            temp = temp + 2
        End While

        dblAverage = tempArray.Average
        TextBox2.Text = dblAverage.ToString

        listFunctions.Items.Clear()
        listFunctions.Items.AddRange(arraylistFunction2.ToArray)


    End Sub

#End Region

#Region "Function 3"

    Private Sub function3()
        'Not Implemented in current version
    End Sub

#End Region

#Region "Clear Data"

    Sub ClearData()
        tourParents(0) = Nothing
        crossParents(0) = Nothing
        tourParents(1) = Nothing
        crossParents(1) = Nothing

        arraylistPop.Clear()
        arraylistPopDisplay.Clear()
        arraylistFitness.Clear()
        arraylistTour.Clear()
        arraylistTourFit.Clear()
        arraylistBTD.Clear()
        arraylistFunction1.Clear()
        arraylistFunction2.Clear()


        dblCrossoverRate = 0
        dblMutationRate = 0

        intTourSize = 3
        intFitPopSize = 0

        intSum = 0
        dblAverage = 0.0
        intMax = 0

    End Sub

#End Region

#Region "Validation"
    Private Sub txtChromosomes_Validating(sender As Object, e As CancelEventArgs) Handles txtChromosomes.Validating
        If txtChromosomes.Text Is Nothing Or txtChromosomes.Text Is "" Then
            e.Cancel = True
        End If

    End Sub

    Private Sub txtPop_Validating(sender As Object, e As CancelEventArgs) Handles txtPop.Validating
        If txtPop.Text Is Nothing Or txtPop.Text Is "" Then
            e.Cancel = True
        End If
    End Sub

#End Region

End Class