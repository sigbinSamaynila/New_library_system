Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Form2

    Private Const connectionString As String = "Data Source=DESKTOP-C5VF1NO\SQLEXPRESS01;Initial Catalog=LAST INVENTORY;Integrated Security=True"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBorrowedBooks()
    End Sub


    Public Sub LoadBorrowedBooks()
        Using conn As New SqlConnection(connectionString)
            Dim sql As String = "SELECT BorrowID, StudentID, BookID, Title, BorrowDate FROM tbl_BorrowedBooks"
            Using da As New SqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                Try
                    conn.Open()
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show("Error loading Borrowed Books: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub


    Private Sub btn_Return_Click(sender As Object, e As EventArgs) Handles btn_Return.Click
        Dim borrowID As Integer

        If Not Integer.TryParse(txt_BookID.Text, borrowID) Then
            MessageBox.Show("Please enter a valid Borrow ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bookIDToReturn As String = ""

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()

                Using transaction As SqlTransaction = conn.BeginTransaction()

                    Dim getBookIDSql As String = "SELECT BookID FROM tbl_BorrowedBooks WHERE BorrowID = @BorrowID"
                    Using getBookIDCmd As New SqlCommand(getBookIDSql, conn, transaction)
                        getBookIDCmd.Parameters.AddWithValue("@BorrowID", borrowID)
                        Dim result As Object = getBookIDCmd.ExecuteScalar()

                        If IsNothing(result) Then
                            transaction.Rollback()
                            MessageBox.Show("Borrow ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                        bookIDToReturn = result.ToString()
                    End Using


                    Dim deleteSql As String = "DELETE FROM tbl_BorrowedBooks WHERE BorrowID = @BorrowID"
                    Using deleteCmd As New SqlCommand(deleteSql, conn, transaction)
                        deleteCmd.Parameters.AddWithValue("@BorrowID", borrowID)
                        deleteCmd.ExecuteNonQuery()
                    End Using


                    Dim updateInvSql As String = "UPDATE tbl_Inventory SET Status = 'Available' WHERE BookID = @BookID"
                    Using updateInvCmd As New SqlCommand(updateInvSql, conn, transaction)
                        updateInvCmd.Parameters.AddWithValue("@BookID", bookIDToReturn)
                        updateInvCmd.ExecuteNonQuery()
                    End Using

                    transaction.Commit()
                    MessageBox.Show("Book successfully returned! Inventory updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    txt_BookID.Clear()
                    LoadBorrowedBooks()


                    If Application.OpenForms().OfType(Of Form1)().Any() Then
                        Application.OpenForms().OfType(Of Form1)().First().LoadInventory()
                    End If


                End Using

            Catch ex As Exception
                MessageBox.Show("Returning Error: " & ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim form1 As Form1 = Application.OpenForms().OfType(Of Form1)().FirstOrDefault()

        If IsNothing(form1) Then
            form1 = New Form1()
            form1.Show()
        Else
            form1.Show()
            form1.BringToFront()
            form1.LoadInventory()
        End If

        Me.Hide()
    End Sub

End Class