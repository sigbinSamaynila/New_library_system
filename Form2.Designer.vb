<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.BorrowIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblBorrowedBooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAST_INVENTORYDataSet1 = New LAST_INVENTORY.LAST_INVENTORYDataSet1()
        Me.lbl_BookID = New System.Windows.Forms.Label()
        Me.txt_BookID = New System.Windows.Forms.TextBox()
        Me.btn_Return = New System.Windows.Forms.Button()
        Me.Tbl_BorrowedBooksTableAdapter = New LAST_INVENTORY.LAST_INVENTORYDataSet1TableAdapters.tbl_BorrowedBooksTableAdapter()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBorrowedBooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAST_INVENTORYDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BorrowIDDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn, Me.BookIDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.BorrowDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblBorrowedBooksBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(85, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(642, 256)
        Me.DataGridView1.TabIndex = 2
        '
        'BorrowIDDataGridViewTextBoxColumn
        '
        Me.BorrowIDDataGridViewTextBoxColumn.DataPropertyName = "BorrowID"
        Me.BorrowIDDataGridViewTextBoxColumn.HeaderText = "BorrowID"
        Me.BorrowIDDataGridViewTextBoxColumn.Name = "BorrowIDDataGridViewTextBoxColumn"
        Me.BorrowIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
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
        'BorrowDateDataGridViewTextBoxColumn
        '
        Me.BorrowDateDataGridViewTextBoxColumn.DataPropertyName = "BorrowDate"
        Me.BorrowDateDataGridViewTextBoxColumn.HeaderText = "BorrowDate"
        Me.BorrowDateDataGridViewTextBoxColumn.Name = "BorrowDateDataGridViewTextBoxColumn"
        '
        'TblBorrowedBooksBindingSource
        '
        Me.TblBorrowedBooksBindingSource.DataMember = "tbl_BorrowedBooks"
        Me.TblBorrowedBooksBindingSource.DataSource = Me.LAST_INVENTORYDataSet1
        '
        'LAST_INVENTORYDataSet1
        '
        Me.LAST_INVENTORYDataSet1.DataSetName = "LAST_INVENTORYDataSet1"
        Me.LAST_INVENTORYDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_BookID
        '
        Me.lbl_BookID.AutoSize = True
        Me.lbl_BookID.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BookID.Location = New System.Drawing.Point(230, 371)
        Me.lbl_BookID.Name = "lbl_BookID"
        Me.lbl_BookID.Size = New System.Drawing.Size(56, 15)
        Me.lbl_BookID.TabIndex = 1
        Me.lbl_BookID.Text = "Book ID:"
        '
        'txt_BookID
        '
        Me.txt_BookID.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BookID.Location = New System.Drawing.Point(316, 367)
        Me.txt_BookID.Name = "txt_BookID"
        Me.txt_BookID.Size = New System.Drawing.Size(102, 22)
        Me.txt_BookID.TabIndex = 7
        '
        'btn_Return
        '
        Me.btn_Return.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Return.Location = New System.Drawing.Point(452, 367)
        Me.btn_Return.Name = "btn_Return"
        Me.btn_Return.Size = New System.Drawing.Size(94, 23)
        Me.btn_Return.TabIndex = 11
        Me.btn_Return.Text = "RETURN"
        Me.btn_Return.UseVisualStyleBackColor = True
        '
        'Tbl_BorrowedBooksTableAdapter
        '
        Me.Tbl_BorrowedBooksTableAdapter.ClearBeforeFill = True
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(23, 22)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 34)
        Me.btn_back.TabIndex = 12
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_BookID)
        Me.Controls.Add(Me.txt_BookID)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_Return)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBorrowedBooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAST_INVENTORYDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_BookID As Label
    Friend WithEvents txt_BookID As TextBox
    Friend WithEvents btn_Return As Button
    Friend WithEvents LAST_INVENTORYDataSet1 As LAST_INVENTORYDataSet1
    Friend WithEvents TblBorrowedBooksBindingSource As BindingSource
    Friend WithEvents Tbl_BorrowedBooksTableAdapter As LAST_INVENTORYDataSet1TableAdapters.tbl_BorrowedBooksTableAdapter
    Friend WithEvents BorrowIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btn_back As Button
End Class
