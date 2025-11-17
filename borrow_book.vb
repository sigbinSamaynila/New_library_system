Imports System.Net
Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity.Client.Platforms.Shared

Public Class borrow_book

    Dim connectionString As String = "Data Source=DESKTOP-9R7NK8N;Initial Catalog=books;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;"

    Private Sub borrow_book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooksData()
    End Sub

    Private Sub LoadBooksData()
        ' ✅ Connection string that matches your SSMS database:
        Dim connectionString As String = "Data Source=DESKTOP-9R7NK8N;Initial Catalog=books;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;"

        Try
            Using connection As New SqlConnection(connectionString)
                ' ✅ Query to match your table
                Dim query As String = "SELECT [Book Id], Title, Author, Genre, [Date Added] FROM dbo.books1"

                Using adapter As New SqlDataAdapter(query, connection)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridView1.DataSource = table
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading books data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click

        Try
            If String.IsNullOrWhiteSpace(txt_book_id.Text) Then
                MessageBox.Show("Please select a book first!")
                Return
            End If

            Dim bookId As Integer
            Dim command As New SqlCommand
            Dim query As String = "WHERE [Book Id] = @BookId" ' No underscore
            command.Parameters.AddWithValue("@BookId", bookId)    ' No underscore
            If Not Integer.TryParse(txt_book_id.Text, bookId) Then
                MessageBox.Show("Please enter a valid Book ID!")
                Return
            End If

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' DEBUG: Show what we're trying to do
                MessageBox.Show($"Attempting to borrow book with ID: {bookId}")

                ' SIMPLE TEST QUERY - Use this first to identify the issue
                Dim testQuery As String = "SELECT COUNT(*) FROM books1 WHERE [Book Id] = @BookId"
                MessageBox.Show($"Executing query: {testQuery}")

                Using testCmd As New SqlCommand(testQuery, connection)
                    testCmd.Parameters.AddWithValue("@BookId", bookId)
                    Dim count As Integer = Convert.ToInt32(testCmd.ExecuteScalar())
                    MessageBox.Show($"Books found: {count}")
                End Using

                ' If the above works, then try the insert
                Dim insertQuery As String = "INSERT INTO inventory1 ([Id], [Title], [Author], [Genre], [Borrowed], [Borrow Date]) 
                                       SELECT [Book Id], [Title], [Author], [Genre], 'Yes', GETDATE() 
                                       FROM books1 WHERE [Book Id] = @BookId"

                MessageBox.Show($"Executing insert query: {insertQuery}")

                Using insertCmd As New SqlCommand(insertQuery, connection)
                    insertCmd.Parameters.AddWithValue("@BookId", bookId)
                    Dim rowsAffected As Integer = insertCmd.ExecuteNonQuery()
                    MessageBox.Show($"Rows affected: {rowsAffected}")

                    If rowsAffected > 0 Then
                        MessageBox.Show("Book borrowed successfully!")
                    Else
                        MessageBox.Show("No book was borrowed. Please check if the book exists.")
                    End If
                End Using

            End Using


            LoadBooksData()

        Catch ex As Exception
            MessageBox.Show($"Error borrowing book: {ex.Message}" & vbCrLf & $"Stack: {ex.StackTrace}")
        End Try
    End Sub
End Class