Imports Microsoft.VisualBasic
Imports System
Namespace MultiPaneChart
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
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
			Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barStaticItem1, Me.barEditItem1})
			Me.barManager1.MaxItemId = 3
			Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1})
			' 
			' bar1
			' 
			Me.bar1.BarName = "Tools"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barEditItem1)})
			Me.bar1.Offset = 5
			Me.bar1.Text = "Tools"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "Add Series"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
'			Me.barButtonItem1.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barButtonItem1_ItemClick);
			' 
			' barStaticItem1
			' 
			Me.barStaticItem1.Caption = "Ser Max Series Value"
			Me.barStaticItem1.Id = 1
			Me.barStaticItem1.Name = "barStaticItem1"
			Me.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' barEditItem1
			' 
			Me.barEditItem1.Caption = "MaxValue"
			Me.barEditItem1.Edit = Me.repositoryItemSpinEdit1
			Me.barEditItem1.EditValue = "500"
			Me.barEditItem1.Id = 2
			Me.barEditItem1.Name = "barEditItem1"
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' panel1
			' 
			Me.panel1.AutoScroll = True
			Me.panel1.Controls.Add(Me.chartControl1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel1.Location = New System.Drawing.Point(0, 25)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(626, 420)
			Me.panel1.TabIndex = 4
			' 
			' chartControl1
			' 
			Me.chartControl1.Location = New System.Drawing.Point(12, 6)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chartControl1.Size = New System.Drawing.Size(611, 11)
			Me.chartControl1.TabIndex = 0
			Me.chartControl1.Visible = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(626, 445)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Resize += New System.EventHandler(Me.Form1_Resize);
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar1 As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem
		Private barEditItem1 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private panel1 As System.Windows.Forms.Panel
		Private chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

