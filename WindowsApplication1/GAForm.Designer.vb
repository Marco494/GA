<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GAForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.txtChromosomes = New System.Windows.Forms.TextBox()
        Me.txtPop = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listPopulation = New System.Windows.Forms.ListBox()
        Me.listFitness = New System.Windows.Forms.ListBox()
        Me.listCross = New System.Windows.Forms.ListBox()
        Me.Parameters = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nudMutation = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.listMutation = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.listFunctions = New System.Windows.Forms.ListBox()
        Me.listDecimal = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Parameters.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMutation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderlineColor = System.Drawing.Color.Transparent
        Me.Chart1.CausesValidation = False
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.MediumSeaGreen
        ChartArea1.AxisX2.TitleForeColor = System.Drawing.Color.MediumSeaGreen
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.MediumSeaGreen
        ChartArea1.AxisY2.TitleForeColor = System.Drawing.Color.MediumSeaGreen
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.BorderColor = System.Drawing.Color.MidnightBlue
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowColor = System.Drawing.Color.White
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Location = New System.Drawing.Point(42, 70)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Me.Chart1.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Green}
        Me.Chart1.Size = New System.Drawing.Size(981, 396)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.ForeColor = System.Drawing.Color.Khaki
        Title1.Name = "Generation Fitness Level Chart"
        Title1.Text = "Generation Fitness Level Chart"
        Title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.ForeColor = System.Drawing.Color.LightGray
        Title2.Name = "Number of Generations"
        Title2.Text = "Number of Generations"
        Title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.ForeColor = System.Drawing.Color.LightGray
        Title3.Name = "Fitness Level"
        Title3.Text = "Fitness Level"
        Me.Chart1.Titles.Add(Title1)
        Me.Chart1.Titles.Add(Title2)
        Me.Chart1.Titles.Add(Title3)
        '
        'btnRun
        '
        Me.btnRun.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.Location = New System.Drawing.Point(1103, 435)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(179, 42)
        Me.btnRun.TabIndex = 1
        Me.btnRun.Text = "RUN"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'txtChromosomes
        '
        Me.txtChromosomes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChromosomes.Location = New System.Drawing.Point(13, 68)
        Me.txtChromosomes.Name = "txtChromosomes"
        Me.txtChromosomes.Size = New System.Drawing.Size(215, 26)
        Me.txtChromosomes.TabIndex = 2
        '
        'txtPop
        '
        Me.txtPop.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPop.Location = New System.Drawing.Point(13, 122)
        Me.txtPop.Name = "txtPop"
        Me.txtPop.Size = New System.Drawing.Size(215, 29)
        Me.txtPop.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(9, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Individual Size"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(9, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Population Size"
        '
        'listPopulation
        '
        Me.listPopulation.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listPopulation.FormattingEnabled = True
        Me.listPopulation.ItemHeight = 18
        Me.listPopulation.Location = New System.Drawing.Point(17, 94)
        Me.listPopulation.Name = "listPopulation"
        Me.listPopulation.Size = New System.Drawing.Size(118, 112)
        Me.listPopulation.TabIndex = 6
        '
        'listFitness
        '
        Me.listFitness.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listFitness.FormattingEnabled = True
        Me.listFitness.ItemHeight = 18
        Me.listFitness.Location = New System.Drawing.Point(141, 94)
        Me.listFitness.Name = "listFitness"
        Me.listFitness.Size = New System.Drawing.Size(104, 112)
        Me.listFitness.TabIndex = 7
        '
        'listCross
        '
        Me.listCross.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listCross.FormattingEnabled = True
        Me.listCross.ItemHeight = 18
        Me.listCross.Location = New System.Drawing.Point(12, 94)
        Me.listCross.Name = "listCross"
        Me.listCross.Size = New System.Drawing.Size(209, 112)
        Me.listCross.TabIndex = 8
        '
        'Parameters
        '
        Me.Parameters.BackColor = System.Drawing.Color.Transparent
        Me.Parameters.Controls.Add(Me.NumericUpDown2)
        Me.Parameters.Controls.Add(Me.Label11)
        Me.Parameters.Controls.Add(Me.nudMutation)
        Me.Parameters.Controls.Add(Me.Label10)
        Me.Parameters.Controls.Add(Me.txtChromosomes)
        Me.Parameters.Controls.Add(Me.txtPop)
        Me.Parameters.Controls.Add(Me.Label1)
        Me.Parameters.Controls.Add(Me.Label2)
        Me.Parameters.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parameters.ForeColor = System.Drawing.Color.IndianRed
        Me.Parameters.Location = New System.Drawing.Point(1066, 12)
        Me.Parameters.Name = "Parameters"
        Me.Parameters.Size = New System.Drawing.Size(248, 282)
        Me.Parameters.TabIndex = 9
        Me.Parameters.TabStop = False
        Me.Parameters.Text = "Parameters"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.NumericUpDown2.Location = New System.Drawing.Point(13, 245)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(215, 29)
        Me.NumericUpDown2.TabIndex = 14
        Me.NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(9, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 22)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Generations"
        '
        'nudMutation
        '
        Me.nudMutation.DecimalPlaces = 2
        Me.nudMutation.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMutation.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudMutation.Location = New System.Drawing.Point(13, 179)
        Me.nudMutation.Name = "nudMutation"
        Me.nudMutation.Size = New System.Drawing.Size(215, 29)
        Me.nudMutation.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(9, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 22)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Mutation Rate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(9, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 22)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Function Select"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(13, 68)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(215, 29)
        Me.NumericUpDown1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(188, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(706, 44)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Genetic Algorithm - Functions 0, 1, 2, 3"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.listMutation)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.listCross)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox1.Location = New System.Drawing.Point(401, 493)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 221)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crossover && Mutation"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(237, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(183, 16)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Bitwise Mutation based on % rate"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(212, 16)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Two parents picked and tales swapped"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(236, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 22)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Mutation"
        '
        'listMutation
        '
        Me.listMutation.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listMutation.FormattingEnabled = True
        Me.listMutation.ItemHeight = 18
        Me.listMutation.Location = New System.Drawing.Point(240, 94)
        Me.listMutation.Name = "listMutation"
        Me.listMutation.Size = New System.Drawing.Size(123, 112)
        Me.listMutation.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(8, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 22)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Crossed Over"
        '
        'listFunctions
        '
        Me.listFunctions.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listFunctions.FormattingEnabled = True
        Me.listFunctions.ItemHeight = 18
        Me.listFunctions.Location = New System.Drawing.Point(120, 94)
        Me.listFunctions.Name = "listFunctions"
        Me.listFunctions.Size = New System.Drawing.Size(151, 112)
        Me.listFunctions.TabIndex = 14
        '
        'listDecimal
        '
        Me.listDecimal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listDecimal.FormattingEnabled = True
        Me.listDecimal.ItemHeight = 18
        Me.listDecimal.Location = New System.Drawing.Point(12, 94)
        Me.listDecimal.Name = "listDecimal"
        Me.listDecimal.Size = New System.Drawing.Size(80, 112)
        Me.listDecimal.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(137, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fitness Level"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(13, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 22)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Population"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox2.Location = New System.Drawing.Point(1066, 300)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 118)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Functions"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.listPopulation)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.listFitness)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Thistle
        Me.GroupBox3.Location = New System.Drawing.Point(42, 493)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(311, 221)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "First Generation Results"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(138, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 16)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Based on number of 1's"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 16)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Randomly Generated"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(298, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 15
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(298, 137)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 16
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(298, 185)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 26)
        Me.TextBox3.TabIndex = 17
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.listFunctions)
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Controls.Add(Me.listDecimal)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Orange
        Me.GroupBox4.Location = New System.Drawing.Point(884, 493)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(430, 221)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Function Results"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.LightGray
        Me.Label23.Location = New System.Drawing.Point(294, 47)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(116, 22)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "Breakdown"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(295, 166)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 16)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Max"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(295, 119)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 16)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "Average"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(295, 71)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 16)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "Sum"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(117, 71)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(133, 16)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Based on post function"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LightGray
        Me.Label19.Location = New System.Drawing.Point(116, 47)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(110, 22)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Population"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 71)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 16)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Binary to Decimal"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LightGray
        Me.Label16.Location = New System.Drawing.Point(8, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 22)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Decimal"
        '
        'GAForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1350, 741)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Parameters)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "GAForm"
        Me.Text = "Form1"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Parameters.ResumeLayout(False)
        Me.Parameters.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMutation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btnRun As Button
    Friend WithEvents txtChromosomes As TextBox
    Friend WithEvents txtPop As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents listPopulation As ListBox
    Friend WithEvents listFitness As ListBox
    Friend WithEvents listCross As ListBox
    Friend WithEvents Parameters As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents listMutation As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents nudMutation As NumericUpDown
    Friend WithEvents listDecimal As ListBox
    Friend WithEvents listFunctions As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
End Class
