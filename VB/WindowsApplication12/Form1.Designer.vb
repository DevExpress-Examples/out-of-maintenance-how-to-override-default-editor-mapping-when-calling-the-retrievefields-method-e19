Namespace WindowsApplication12
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.carsDBDataSet1_Renamed = New WindowsApplication12.CarsDBDataSet1()
            Me.carsTableAdapter = New WindowsApplication12.CarsDBDataSet1TableAdapters.CarsTableAdapter()
            DirectCast(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.carsDBDataSet1_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dataLayoutControl1
            ' 
            Me.dataLayoutControl1.DataSource = Me.carsBindingSource
            Me.dataLayoutControl1.Location = New System.Drawing.Point(106, 38)
            Me.dataLayoutControl1.Name = "dataLayoutControl1"
            Me.dataLayoutControl1.Root = Me.layoutControlGroup1
            Me.dataLayoutControl1.Size = New System.Drawing.Size(500, 148)
            Me.dataLayoutControl1.TabIndex = 0
            Me.dataLayoutControl1.Text = "dataLayoutControl1"
            ' 
            ' carsBindingSource
            ' 
            Me.carsBindingSource.DataMember = "Cars"
            Me.carsBindingSource.DataSource = Me.carsDBDataSet1_Renamed
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(500, 148)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(301, 229)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
            Me.simpleButton1.TabIndex = 1
            Me.simpleButton1.Text = "simpleButton1"
            ' 
            ' carsDBDataSet1
            ' 
            Me.carsDBDataSet1_Renamed.DataSetName = "CarsDBDataSet1"
            Me.carsDBDataSet1_Renamed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' carsTableAdapter
            ' 
            Me.carsTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(697, 377)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.dataLayoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.carsDBDataSet1_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private carsBindingSource As System.Windows.Forms.BindingSource

        Private carsDBDataSet1_Renamed As CarsDBDataSet1
        Private carsTableAdapter As WindowsApplication12.CarsDBDataSet1TableAdapters.CarsTableAdapter
    End Class
End Namespace

