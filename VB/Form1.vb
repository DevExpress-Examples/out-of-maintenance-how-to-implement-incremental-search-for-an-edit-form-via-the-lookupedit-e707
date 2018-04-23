Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace SearchHelper
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private dateEdit1 As DevExpress.XtraEditors.DateEdit
		Private spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private label4 As System.Windows.Forms.Label
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private WithEvents lookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.label4 = New System.Windows.Forms.Label()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.lookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.lookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' textEdit1
			' 
			Me.textEdit1.EditValue = "textEdit1"
			Me.textEdit1.Location = New System.Drawing.Point(144, 37)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(221, 22)
			Me.textEdit1.TabIndex = 1
			' 
			' dateEdit1
			' 
			Me.dateEdit1.EditValue = New System.DateTime(2005, 12, 9, 0, 0, 0, 0)
			Me.dateEdit1.Location = New System.Drawing.Point(144, 83)
			Me.dateEdit1.Name = "dateEdit1"
			Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit1.Size = New System.Drawing.Size(221, 22)
			Me.dateEdit1.TabIndex = 3
			' 
			' spinEdit1
			' 
			Me.spinEdit1.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit1.Location = New System.Drawing.Point(144, 129)
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit1.Properties.DisplayFormat.FormatString = "c"
			Me.spinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.spinEdit1.Properties.Mask.EditMask = "c"
			Me.spinEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
			Me.spinEdit1.Size = New System.Drawing.Size(221, 22)
			Me.spinEdit1.TabIndex = 5
			' 
			' dataNavigator1
			' 
			Me.dataNavigator1.Location = New System.Drawing.Point(19, 175)
			Me.dataNavigator1.Name = "dataNavigator1"
			Me.dataNavigator1.Size = New System.Drawing.Size(349, 28)
			Me.dataNavigator1.TabIndex = 6
			Me.dataNavigator1.Text = "dataNavigator1"
			Me.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(19, 37)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(120, 18)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Name:"
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(19, 83)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(120, 19)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Purchase Date:"
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(19, 129)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(120, 19)
			Me.label3.TabIndex = 4
			Me.label3.Text = "Payment Amount:"
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.Location = New System.Drawing.Point(154, 120)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(211, 138)
			Me.listBoxControl1.TabIndex = 5
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(19, 120)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(120, 18)
			Me.label4.TabIndex = 4
			Me.label4.Text = "All Contacts:"
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.label3)
			Me.groupControl1.Controls.Add(Me.label1)
			Me.groupControl1.Controls.Add(Me.dataNavigator1)
			Me.groupControl1.Controls.Add(Me.label2)
			Me.groupControl1.Controls.Add(Me.dateEdit1)
			Me.groupControl1.Controls.Add(Me.spinEdit1)
			Me.groupControl1.Controls.Add(Me.textEdit1)
			Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.groupControl1.Location = New System.Drawing.Point(0, 0)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(386, 222)
			Me.groupControl1.TabIndex = 0
			Me.groupControl1.Text = "Contact information"
			' 
			' groupControl2
			' 
			Me.groupControl2.Controls.Add(Me.lookUpEdit1)
			Me.groupControl2.Controls.Add(Me.label6)
			Me.groupControl2.Controls.Add(Me.label5)
			Me.groupControl2.Controls.Add(Me.listBoxControl1)
			Me.groupControl2.Controls.Add(Me.label4)
			Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupControl2.Location = New System.Drawing.Point(0, 222)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(386, 274)
			Me.groupControl2.TabIndex = 1
			Me.groupControl2.Text = "Fast navigation"
			' 
			' lookUpEdit1
			' 
			Me.lookUpEdit1.Location = New System.Drawing.Point(144, 28)
			Me.lookUpEdit1.Name = "lookUpEdit1"
			Me.lookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lookUpEdit1.Size = New System.Drawing.Size(221, 22)
			Me.lookUpEdit1.TabIndex = 2
'			Me.lookUpEdit1.EditValueChanged += New System.EventHandler(Me.lookUpEdit1_EditValueChanged);
'			Me.lookUpEdit1.QueryPopUp += New System.ComponentModel.CancelEventHandler(Me.lookUpEdit1_QueryPopUp);
			' 
			' label6
			' 
			Me.label6.Location = New System.Drawing.Point(19, 65)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(346, 37)
			Me.label6.TabIndex = 3
			Me.label6.Text = "Type initial letters of a person name in the edit box to locate the contact recor" & "d."
			' 
			' label5
			' 
			Me.label5.Location = New System.Drawing.Point(19, 28)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(120, 18)
			Me.label5.TabIndex = 1
			Me.label5.Text = "Search By Name:"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
			Me.ClientSize = New System.Drawing.Size(386, 496)
			Me.Controls.Add(Me.groupControl2)
			Me.Controls.Add(Me.groupControl1)
			Me.Name = "Form1"
			Me.Text = "Incremental search via LookUpEdit"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			CType(Me.lookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub DataBind()
			Dim data As DevExpress.Tutorials.XtraEditors.ContactList
			data = DevExpress.Tutorials.XtraEditors.ContactList.GetContacts()
			textEdit1.DataBindings.Add("EditValue", data, "Name")
			dateEdit1.DataBindings.Add("EditValue", data, "PurchaseDate")
			spinEdit1.DataBindings.Add("EditValue", data, "PaymentAmount")
			dataNavigator1.DataSource = data
			listBoxControl1.DataSource = data
			listBoxControl1.DisplayMember = "Name"

			SetupSearchHelper(data, "Name")
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			DataBind()
		End Sub

		Private Sub SetupSearchHelper(ByVal data As IList, ByVal member As String)
			lookUpEdit1.Properties.DataSource = data
			lookUpEdit1.Properties.DisplayMember = member
			lookUpEdit1.Properties.SearchMode = SearchMode.AutoComplete
			lookUpEdit1.Properties.Buttons.Clear()
			lookUpEdit1.Properties.NullText = "[Type a contact to find]"
			lookUpEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
			lookUpEdit1.Properties.TextEditStyle = TextEditStyles.Standard
		End Sub

		Private Sub lookUpEdit1_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookUpEdit1.QueryPopUp
			e.Cancel = True
		End Sub

		Private Sub lookUpEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookUpEdit1.EditValueChanged
			Dim edit As LookUpEdit = TryCast(sender, LookUpEdit)
			Dim data As IList = TryCast(edit.Properties.DataSource, IList)
			Dim bm As BindingManagerBase = BindingContext(data)
			If edit.EditValue Is Nothing Then
				bm.Position = 0
			Else
				Dim index As Integer = data.IndexOf(edit.EditValue)
				If index > -1 Then
					bm.Position = index
				End If
			End If
		End Sub
	End Class
End Namespace

