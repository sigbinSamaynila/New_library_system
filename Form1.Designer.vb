Imports System.Data.SqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAST_INVENTORYDataSet = New LAST_INVENTORY.LAST_INVENTORYDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_barrow = New System.Windows.Forms.Button()
        Me.txt_BarrowDate = New System.Windows.Forms.TextBox()
        Me.txt_Author = New System.Windows.Forms.TextBox()
        Me.txt_Title = New System.Windows.Forms.TextBox()
        Me.txt_BookID = New System.Windows.Forms.TextBox()
        Me.txt_StudentID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_BarrowDate = New System.Windows.Forms.Label()
        Me.lbl_Author2 = New System.Windows.Forms.Label()
        Me.lbl_Title2 = New System.Windows.Forms.Label()
        Me.lbl_BookID2 = New System.Windows.Forms.Label()
        Me.lbl_StudentID2 = New System.Windows.Forms.Label()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.DirectorySearcher2 = New System.DirectoryServices.DirectorySearcher()
        Me.Tbl_InventoryTableAdapter = New LAST_INVENTORY.LAST_INVENTORYDataSetTableAdapters.tbl_InventoryTableAdapter()
        Me.btn_history = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAST_INVENTORYDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblInventoryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(262, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(442, 261)
        Me.DataGridView1.TabIndex = 0
        '
        'BookIDDataGridViewTextBoxColumn
        '
        Me.BookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID"
        Me.BookIDDataGridViewTextBoxColumn.HeaderText = "BookID"
        Me.BookIDDataGridViewTextBoxColumn.Name = "BookIDDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'TblInventoryBindingSource
        '
        Me.TblInventoryBindingSource.DataMember = "tbl_Inventory"
        Me.TblInventoryBindingSource.DataSource = Me.LAST_INVENTORYDataSet
        '
        'LAST_INVENTORYDataSet
        '
        Me.LAST_INVENTORYDataSet.DataSetName = "LAST_INVENTORYDataSet"
        Me.LAST_INVENTORYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Bisque
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btn_barrow)
        Me.GroupBox1.Controls.Add(Me.txt_BarrowDate)
        Me.GroupBox1.Controls.Add(Me.txt_Author)
        Me.GroupBox1.Controls.Add(Me.txt_Title)
        Me.GroupBox1.Controls.Add(Me.txt_BookID)
        Me.GroupBox1.Controls.Add(Me.txt_StudentID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl_BarrowDate)
        Me.GroupBox1.Controls.Add(Me.lbl_Author2)
        Me.GroupBox1.Controls.Add(Me.lbl_Title2)
        Me.GroupBox1.Controls.Add(Me.lbl_BookID2)
        Me.GroupBox1.Controls.Add(Me.lbl_StudentID2)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 458)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btn_barrow
        '
        Me.btn_barrow.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_barrow.Location = New System.Drawing.Point(62, 356)
        Me.btn_barrow.Name = "btn_barrow"
        Me.btn_barrow.Size = New System.Drawing.Size(128, 23)
        Me.btn_barrow.TabIndex = 11
        Me.btn_barrow.Text = "BARROW BOOK"
        Me.btn_barrow.UseVisualStyleBackColor = True
        '
        'txt_BarrowDate
        '
        Me.txt_BarrowDate.Location = New System.Drawing.Point(112, 293)
        Me.txt_BarrowDate.Name = "txt_BarrowDate"
        Me.txt_BarrowDate.Size = New System.Drawing.Size(102, 20)
        Me.txt_BarrowDate.TabIndex = 10
        '
        'txt_Author
        '
        Me.txt_Author.Location = New System.Drawing.Point(112, 253)
        Me.txt_Author.Name = "txt_Author"
        Me.txt_Author.Size = New System.Drawing.Size(102, 20)
        Me.txt_Author.TabIndex = 9
        '
        'txt_Title
        '
        Me.txt_Title.Location = New System.Drawing.Point(112, 219)
        Me.txt_Title.Name = "txt_Title"
        Me.txt_Title.Size = New System.Drawing.Size(102, 20)
        Me.txt_Title.TabIndex = 8
        '
        'txt_BookID
        '
        Me.txt_BookID.Location = New System.Drawing.Point(112, 181)
        Me.txt_BookID.Name = "txt_BookID"
        Me.txt_BookID.Size = New System.Drawing.Size(102, 20)
        Me.txt_BookID.TabIndex = 7
        '
        'txt_StudentID
        '
        Me.txt_StudentID.Location = New System.Drawing.Point(112, 144)
        Me.txt_StudentID.Name = "txt_StudentID"
        Me.txt_StudentID.Size = New System.Drawing.Size(102, 20)
        Me.txt_StudentID.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "INFORMATION"
        '
        'lbl_BarrowDate
        '
        Me.lbl_BarrowDate.AutoSize = True
        Me.lbl_BarrowDate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BarrowDate.Location = New System.Drawing.Point(21, 298)
        Me.lbl_BarrowDate.Name = "lbl_BarrowDate"
        Me.lbl_BarrowDate.Size = New System.Drawing.Size(77, 15)
        Me.lbl_BarrowDate.TabIndex = 4
        Me.lbl_BarrowDate.Text = "Barrow Date:"
        '
        'lbl_Author2
        '
        Me.lbl_Author2.AutoSize = True
        Me.lbl_Author2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Author2.Location = New System.Drawing.Point(21, 258)
        Me.lbl_Author2.Name = "lbl_Author2"
        Me.lbl_Author2.Size = New System.Drawing.Size(48, 15)
        Me.lbl_Author2.TabIndex = 3
        Me.lbl_Author2.Text = "Author:"
        '
        'lbl_Title2
        '
        Me.lbl_Title2.AutoSize = True
        Me.lbl_Title2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Title2.Location = New System.Drawing.Point(21, 224)
        Me.lbl_Title2.Name = "lbl_Title2"
        Me.lbl_Title2.Size = New System.Drawing.Size(37, 15)
        Me.lbl_Title2.TabIndex = 2
        Me.lbl_Title2.Text = "Title:"
        '
        'lbl_BookID2
        '
        Me.lbl_BookID2.AutoSize = True
        Me.lbl_BookID2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BookID2.Location = New System.Drawing.Point(21, 186)
        Me.lbl_BookID2.Name = "lbl_BookID2"
        Me.lbl_BookID2.Size = New System.Drawing.Size(54, 15)
        Me.lbl_BookID2.TabIndex = 1
        Me.lbl_BookID2.Text = "Book ID:"
        '
        'lbl_StudentID2
        '
        Me.lbl_StudentID2.AutoSize = True
        Me.lbl_StudentID2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_StudentID2.Location = New System.Drawing.Point(21, 146)
        Me.lbl_StudentID2.Name = "lbl_StudentID2"
        Me.lbl_StudentID2.Size = New System.Drawing.Size(69, 15)
        Me.lbl_StudentID2.TabIndex = 0
        Me.lbl_StudentID2.Text = "Student ID:"
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'DirectorySearcher2
        '
        Me.DirectorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'Tbl_InventoryTableAdapter
        '
        Me.Tbl_InventoryTableAdapter.ClearBeforeFill = True
        '
        'btn_history
        '
        Me.btn_history.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_history.Location = New System.Drawing.Point(629, 33)
        Me.btn_history.Name = "btn_history"
        Me.btn_history.Size = New System.Drawing.Size(75, 23)
        Me.btn_history.TabIndex = 2
        Me.btn_history.Text = "HISTORY"
        Me.btn_history.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LAST_INVENTORY.My.Resources.Resources.open_book
        Me.PictureBox1.Location = New System.Drawing.Point(62, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(723, 430)
        Me.Controls.Add(Me.btn_history)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAST_INVENTORYDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_Author2 As Label
    Friend WithEvents lbl_Title2 As Label
    Friend WithEvents lbl_BookID2 As Label
    Friend WithEvents lbl_StudentID2 As Label
    Friend WithEvents txt_BarrowDate As TextBox
    Friend WithEvents txt_Author As TextBox
    Friend WithEvents txt_Title As TextBox
    Friend WithEvents txt_BookID As TextBox
    Friend WithEvents txt_StudentID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_BarrowDate As Label
    Friend WithEvents btn_barrow As Button


    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents DirectorySearcher2 As DirectoryServices.DirectorySearcher
    Friend WithEvents LAST_INVENTORYDataSet As LAST_INVENTORYDataSet
    Friend WithEvents TblInventoryBindingSource As BindingSource
    Friend WithEvents Tbl_InventoryTableAdapter As LAST_INVENTORYDataSetTableAdapters.tbl_InventoryTableAdapter
    Friend WithEvents BookIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btn_history As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
