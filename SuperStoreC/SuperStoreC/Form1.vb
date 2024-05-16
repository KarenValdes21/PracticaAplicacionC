Public Class Form1
    Dim query As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        ' Add any initialization after the InitializeComponent() call.
        'Create a new instance of the Connection class

        query = "select id, Estado from Estado"
        cboEstado.DataSource = Connection.SelectQuery(query)
        cboEstado.DisplayMember = "Estado"
        cboEstado.ValueMember = "id"

    End Sub
    'Al correr el progama es importante recordar que no todos los estados contienen clientes.
    'Un ejemplo que si contiene clientes es Oregon
    Private Sub cboEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstado.SelectedIndexChanged
        query = "select id, Ciudad from [dbo].[Ciudad] where idEstado=" & cboEstado.SelectedValue
        CbCiudad.DataSource = Connection.SelectQuery(query)
        CbCiudad.DisplayMember = "Ciudad"
        CbCiudad.ValueMember = "id"
    End Sub

    Private Sub CbCiudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCiudad.SelectedIndexChanged

        If cboEstado.Text Is Nothing Then
            Exit Sub
        End If
        query = "select * from VW_DatosSuperMarket1 where [NombreCiudad]='" & CbCiudad.Text & "'"
        DataGridView1.DataSource = Connection.SelectQuery(query)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel2.Hide()

    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        Panel2.Show()

    End Sub
End Class
