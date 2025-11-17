Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Form1

    Private Const connectionString As String = "Data Source=DESKTOP-C5VF1NO\SQLEXPRESS01;Initial Catalog=LAST INVENTORY;Integrated Security=True"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False

        LoadInventory()
    End Sub


    Public Sub LoadInventory()
        Using conn As New SqlConnection(connectionString)
            Dim sql As String = "SELECT BookID, Title, Author, Status FROM tbl_Inventory WHERE Status = 'Available'"
            Using da As New SqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                Try
                    conn.Open()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show("Error loading Available Inventory: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub


    Private Sub txt_BookID_TextChanged(sender As Object, e As EventArgs) Handles txt_BookID.TextChanged
        Dim bookID As String = txt_BookID.Text.Trim()

        If bookID.Length = 0 Then
            txt_Title.Clear()
            txt_Author.Clear()
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Dim sql As String = "SELECT Title, Author, Status FROM tbl_Inventory WHERE BookID = @BookID"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@BookID", bookID)
                Try
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            If reader("Status").ToString() = "Available" Then
                                txt_Title.Text = reader("Title").ToString()
                                txt_Author.Text = reader("Author").ToString()
                            Else
                                MessageBox.Show("The selected book is currently NOT Available (Borrowed).", "Book Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                txt_Title.Clear()
                                txt_Author.Clear()
                            End If
                        Else
                            txt_Title.Clear()
                            txt_Author.Clear()
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error finding Book ID: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub


    Private Sub btn_barrow_Click(sender As Object, e As EventArgs) Handles btn_barrow.Click
        Dim studentID As String = txt_StudentID.Text.Trim()
        Dim bookID As String = txt_BookID.Text.Trim()
        Dim title As String = txt_Title.Text.Trim()
        Dim borrowDate As String = txt_BarrowDate.Text.Trim()

        If String.IsNullOrEmpty(studentID) OrElse String.IsNullOrEmpty(bookID) OrElse String.IsNullOrEmpty(title) OrElse String.IsNullOrEmpty(borrowDate) Then
            MessageBox.Show("Please fill up all required fields for borrowing.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()

                Using transaction As SqlTransaction = conn.BeginTransaction()

                    Dim updateInvSql As String = "UPDATE tbl_Inventory SET Status = 'Borrowed' WHERE BookID = @BookID AND Status = 'Available'"
                    Using updateInvCmd As New SqlCommand(updateInvSql, conn, transaction)
                        updateInvCmd.Parameters.AddWithValue("@BookID", bookID)
                        Dim rowsAffected As Integer = updateInvCmd.ExecuteNonQuery()

                        If rowsAffected = 0 Then
                            transaction.Rollback()
                            MessageBox.Show("Borrow failed. The book is either already borrowed or the ID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                    End Using

                    Dim insertBorrSql As String = "INSERT INTO tbl_BorrowedBooks (StudentID, BookID, Title, Author, BorrowDate) VALUES (@StudentID, @BookID, @Title, @Author, @BorrowDate)"
                    Using insertBorrCmd As New SqlCommand(insertBorrSql, conn, transaction)
                        insertBorrCmd.Parameters.AddWithValue("@StudentID", studentID)
                        insertBorrCmd.Parameters.AddWithValue("@BookID", bookID)
                        insertBorrCmd.Parameters.AddWithValue("@Title", title)
                        insertBorrCmd.Parameters.AddWithValue("@Author", txt_Author.Text.Trim())
                        insertBorrCmd.Parameters.AddWithValue("@BorrowDate", borrowDate)
                        insertBorrCmd.ExecuteNonQuery()
                    End Using

                    transaction.Commit()
                    MessageBox.Show("Book successfully borrowed and inventory updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ClearBarrowForm()
                    LoadInventory()

                    If Application.OpenForms().OfType(Of Form2)().Any() Then
                        Application.OpenForms().OfType(Of Form2)().First().LoadBorrowedBooks()
                    End If


                End Using

            Catch ex As Exception
                MessageBox.Show("Borrowing Error: " & ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ClearBarrowForm()
        txt_StudentID.Clear()
        txt_BookID.Clear()
        txt_Title.Clear()
        txt_Author.Clear()
        txt_BarrowDate.Clear()
    End Sub

    Private Sub txt_Title_Leave(sender As Object, e As EventArgs) Handles txt_Title.Leave
        txt_Title.ReadOnly = True
    End Sub

    Private Sub txt_Author_Leave(sender As Object, e As EventArgs) Handles txt_Author.Leave
        txt_Author.ReadOnly = True
    End Sub

    Private Sub btn_History_Click(sender As Object, e As EventArgs) Handles btn_history.Click
        Dim form2 As Form2 = Application.OpenForms().OfType(Of Form2)().FirstOrDefault()

        If IsNothing(form2) Then
            form2 = New Form2()
            form2.Show()
        Else
            form2.Show()
            form2.BringToFront()
            form2.LoadBorrowedBooks()
        End If

        Me.Hide()
    End Sub

End Class