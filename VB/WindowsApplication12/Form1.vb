Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraLayout
Imports DevExpress.XtraDataLayout
Imports DevExpress.XtraEditors

Namespace WindowsApplication12
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' TODO: This line of code loads data into the 'carsDBDataSet1.Cars' table. You can move, or remove it, as needed.
            Me.carsTableAdapter.Fill(Me.carsDBDataSet1_Renamed.Cars)
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            'dataLayoutControl1.RetrieveFields();
            RetrieveFields(dataLayoutControl1)
        End Sub

        Public Sub RetrieveFields(ByVal lc As DataLayoutControl)
            lc.Clear()
            Dim bindingHelper As New LayoutElementsBindingInfoHelper(lc)
            Dim info As LayoutElementsBindingInfo
            info = bindingHelper.CreateDataLayoutElementsBindingInfo()
            bindingHelper.FillWithSuggestedValues(info)
            Dim bindingsInfo As List(Of LayoutElementBindingInfo) = info.GetAllBindings()
            For Each bindingInfo As LayoutElementBindingInfo In bindingsInfo
                If bindingInfo.DataInfo.Name = "Description" Then
                    bindingInfo.EditorType = GetType(MemoEdit)
                    Exit For
                End If
            Next bindingInfo
            Dim creator As New LayoutCreator(lc)
            creator.CreateLayout(info)
            For Each item As BaseLayoutItem In lc.Items
                If TypeOf item Is LayoutControlItem Then
                    Dim c As Control = (TryCast(item, LayoutControlItem)).Control
                    If c.DataBindings(0).BindingMemberInfo.BindingMember = "Description" Then
                        TryCast(item, LayoutControlItem).SizeConstraintsType = SizeConstraintsType.Custom
                        TryCast(item, LayoutControlItem).MinSize = New Size(0, 100)
                    End If
                End If
            Next item
        End Sub
    End Class
End Namespace