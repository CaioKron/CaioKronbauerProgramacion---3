Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim cadenaconexion As String = "server=127.0.0.1;database=db_Merendero; user id=root;password=123456789;port=3306;"
    Dim conexion1 As New MySqlConnection(cadenaconexion)
    Dim comando As MySqlCommand

    Private Sub buscar()
        Dim midataset As New DataSet
        Dim sw As Boolean = False
        Dim misql As String
        Dim miAdapter As New MySqlDataAdapter
        Dim miDt As DataTable
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open() 'Abrimos la Base de datos
        End If
        Try
            If RadioButton1.Checked = True Then
                misql = "Select * From tb_Alumnos where Nombre like '%" & TextBox1.Text + "%'"
            ElseIf RadioButton2.Checked = True Then
                misql = "Select * From tb_Alumnos where Apellido like '%" & TextBox1.Text + "%'"
            Else
                misql = "Select * From tb_Alumnos"
            End If
            miAdapter = New MySqlDataAdapter(misql, conexion1)
            midataset = New DataSet
            miAdapter.Fill(midataset, "tb_Alumnos")
            DataGridView1.DataSource = midataset
            DataGridView1.DataMember = "tb_Alumnos"
        Catch ex As Exception
            MsgBox("Error al llenar la grilla" & ex.Message)
        End Try
        conexion1.Close() 'Cerramos la Base de Datos
    End Sub
    Private Sub mostrar()
        Dim midataset As New DataSet
        Dim sw As Boolean = False
        Dim misql As String
        Dim miAdapter As New MySqlDataAdapter
        Dim miDt As DataTable
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open() 'Abrimos la Base de datos
        End If
        Try
            misql = "Select * From tb_Alumnos"
            miAdapter = New MySqlDataAdapter(misql, conexion1)
            midataset = New DataSet
            miAdapter.Fill(midataset, "tb_Alumnos")
            DataGridView1.DataSource = midataset
            DataGridView1.DataMember = "tb_Alumnos"
        Catch ex As Exception
            MsgBox("Error al llenar la grilla" & ex.Message)
        End Try
        conexion1.Close() 'Cerramos la Base de Datos
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtDNI.Text = "" Then
            MsgBox("Debe agregar el DNI")
        End If
        If txtDNI.Text.Trim.Length > 9 Then
            MsgBox("El DNI debe contener 9 dígitos o menos")
        End If
        If txtApellido.Text = "" Then
            MsgBox("Debe agregar el apellido")
        End If
        If txtNombre.Text = "" Then
            MsgBox("Debe agregar el nombre")
        End If
        If txtDireccion.Text = "" Then
            MsgBox("Debe agregar la dirección")
        End If
        If txtCurso.Text = "" Then
            MsgBox("Debe agregar el curso")
        End If
        If txtDivision.Text = "" Then
            MsgBox("Debe agregar el division")
        End If
        If cboxEstadoAgregar.Text = "" Then
            MsgBox("Debe agregar el estado del alumno")
        End If
        conexion1.Open()
        comando = New MySqlCommand("INSERT INTO tb_Alumnos(DNI, Apellido, Nombre, Direccion, Curso, Division, Estado) VALUES (?DNI,?Apellido,?Nombre,?Direccion,?Curso,?Division,?Estado)")
        comando.Parameters.Add("?DNI", MySqlDbType.Int32)
        comando.Parameters("?DNI").Value = txtDNI.Text
        comando.Parameters.Add("?Apellido", MySqlDbType.VarChar)
        comando.Parameters("?Apellido").Value = txtApellido.Text
        comando.Parameters.Add("?Nombre", MySqlDbType.VarChar)
        comando.Parameters("?Nombre").Value = txtNombre.Text
        comando.Parameters.Add("?Direccion", MySqlDbType.VarChar)
        comando.Parameters("?Direccion").Value = txtDireccion.Text
        comando.Parameters.Add("?Curso", MySqlDbType.VarChar)
        comando.Parameters("?Curso").Value = txtCurso.Text
        comando.Parameters.Add("?Division", MySqlDbType.VarChar)
        comando.Parameters("?Division").Value = txtDivision.Text
        comando.Parameters.Add("?Estado", MySqlDbType.VarChar)
        comando.Parameters("?Estado").Value = cboxEstadoAgregar.Text
        comando.Connection = conexion1
        comando.ExecuteNonQuery()
        conexion1.Close()
        mostrar()

        txtDNI.Enabled = False
        txtApellido.Enabled = False
        txtNombre.Enabled = False
        txtDireccion.Enabled = False
        txtCurso.Enabled = False
        txtDivision.Enabled = False
        cboxEstadoAgregar.Enabled = False

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        mostrar()
    End Sub

    Private Sub btnCancelar2_Click(sender As Object, e As EventArgs) Handles btnCancelar2.Click 'cancelar de agregar
        txtDNI.Enabled = False
        txtApellido.Enabled = False
        txtNombre.Enabled = False
        txtDireccion.Enabled = False
        txtCurso.Enabled = False
        txtDivision.Enabled = False
        cboxEstadoAgregar.Enabled = False
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.CellContentClick
        Dim DNI2 = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Dim Apellido2 = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Dim Nombre2 = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        Dim Direccion2 = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        Dim Curso2 = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        Dim Division2 = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
        Dim Estado2 = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
        txtDni2.Text = DNI2
        txtApellido2.Text = Apellido2
        txtNombre2.Text = Nombre2
        txtDireccion2.Text = Direccion2
        txtCurso2.Text = Curso2
        txtDivision2.Text = Division2
        cboxEstadoModificar.Text = Estado2
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        txtDNI.Enabled = True
        txtApellido.Enabled = True
        txtNombre.Enabled = True
        txtDireccion.Enabled = True
        txtCurso.Enabled = True
        txtDivision.Enabled = True
        cboxEstadoAgregar.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click 'cancelar del modificar
        txtDni2.Enabled = False
        txtApellido2.Enabled = False
        txtNombre2.Enabled = False
        txtDireccion2.Enabled = False
        txtCurso2.Enabled = False
        txtDivision2.Enabled = False
        cboxEstadoModificar.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtDni2.Enabled = False
        txtApellido2.Enabled = True
        txtNombre2.Enabled = True
        txtDireccion2.Enabled = True
        txtCurso2.Enabled = True
        txtDivision2.Enabled = True
        cboxEstadoModificar.Enabled = True
    End Sub

    Private Sub btnGuardar2_Click(sender As Object, e As EventArgs) Handles btnGuardar2.Click
        conexion1.Open()
        comando = New MySqlCommand("UPDATE tb_Alumnos set Apellido=?Apellido,Nombre=?Nombre,Direccion=?Direccion,Curso=?Curso,Division=?Division,Estado=?Estado where DNI=?DNI")
        comando.Parameters.Add("?DNI", MySqlDbType.Int32)
        comando.Parameters("?DNI").Value = txtDni2.Text

        comando.Parameters.Add("?Apellido", MySqlDbType.VarChar)
        comando.Parameters("?Apellido").Value = txtApellido2.Text

        comando.Parameters.Add("?Nombre", MySqlDbType.VarChar)
        comando.Parameters("?Nombre").Value = txtNombre2.Text

        comando.Parameters.Add("?Direccion", MySqlDbType.VarChar)
        comando.Parameters("?Direccion").Value = txtDireccion2.Text

        comando.Parameters.Add("?Curso", MySqlDbType.VarChar)
        comando.Parameters("?Curso").Value = txtCurso2.Text

        comando.Parameters.Add("?Division", MySqlDbType.VarChar)
        comando.Parameters("?Division").Value = txtDivision2.Text

        comando.Parameters.Add("?Estado", MySqlDbType.VarChar)
        comando.Parameters("?Estado").Value = cboxEstadoModificar.Text

        comando.Connection = conexion1
        comando.ExecuteNonQuery()

        conexion1.Close()

        txtDni2.Enabled = False
        txtApellido2.Enabled = False
        txtNombre2.Enabled = False
        txtDireccion2.Enabled = False
        txtCurso2.Enabled = False
        txtDivision2.Enabled = False
        cboxEstadoModificar.Enabled = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnMostrarAlumnos_Click(sender As Object, e As EventArgs) Handles btnMostrarAlumnos.Click
        Dim midataset As New DataSet
        Dim sw As Boolean = False
        Dim misql As String
        Dim miAdapter As New MySqlDataAdapter
        Dim miDt As DataTable
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open() 'Abrimos la Base de datos
        End If
        Try
            misql = "Select * From tb_Alumnos where Estado like 'Regular'"
            miAdapter = New MySqlDataAdapter(misql, conexion1)
            midataset = New DataSet
            miAdapter.Fill(midataset, "tb_Alumnos")
            DataGridView1.DataSource = midataset
            DataGridView1.DataMember = "tb_Alumnos"
        Catch ex As Exception
            MsgBox("Error al llenar la grilla" & ex.Message)
        End Try
        conexion1.Close() 'Cerramos la Base de Datos

    End Sub

    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView1.CellContentClick
        Dim DNI3 = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        txtDNI3.Text = DNI3
    End Sub

    Private Sub btnGuardar3_Click(sender As Object, e As EventArgs) Handles btnGuardar3.Click
        conexion1.Open()
        comando = New MySqlCommand("INSERT INTO tb_Asistencias(dniAlumno, fecha, asistencia) VALUES (?dniAlumno,?fecha,?asistencia)")

        comando.Parameters.Add("?dniAlumno", MySqlDbType.Int32)
        comando.Parameters("?dniAlumno").Value = txtDNI3.Text

        comando.Parameters.Add("?fecha", MySqlDbType.Date)
        comando.Parameters("?fecha").Value = DateTimePicker1.Value


        comando.Parameters.Add("?asistencia", MySqlDbType.VarChar)
        comando.Parameters("?asistencia").Value = cboxAsistencia.Text

        comando.Connection = conexion1
        comando.ExecuteNonQuery()
        conexion1.Close()
        mostrar2()

        txtDNI3.Enabled = False
        cboxAsistencia.Enabled = True
    End Sub

    Private Sub mostrar2()
        Dim midataset As New DataSet
        Dim sw As Boolean = False
        Dim misql As String
        Dim miAdapter As New MySqlDataAdapter
        Dim miDt As DataTable
        If conexion1.State = ConnectionState.Closed Then
            conexion1.Open() 'Abrimos la Base de datos
        End If
        Try
            misql = "Select * From tb_Asistencias"
            miAdapter = New MySqlDataAdapter(misql, conexion1)
            midataset = New DataSet
            miAdapter.Fill(midataset, "tb_Asistencias")
            DataGridView2.DataSource = midataset
            DataGridView2.DataMember = "tb_Asistencias"
        Catch ex As Exception
            MsgBox("Error al llenar la grilla de asistencia" & ex.Message)
        End Try
        conexion1.Close() 'Cerramos la Base de Datos


    End Sub

    Private Sub btnCancelar3_Click(sender As Object, e As EventArgs) Handles btnCancelar3.Click
        txtDNI3.Clear()
        cboxAsistencia.ResetText()
    End Sub
End Class