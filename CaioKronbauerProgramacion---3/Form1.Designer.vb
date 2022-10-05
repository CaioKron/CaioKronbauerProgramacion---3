<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabAsistencia = New System.Windows.Forms.TabPage()
        Me.cboxAsistencia = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDNI3 = New System.Windows.Forms.TextBox()
        Me.btnGuardar3 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnMostrarAlumnos = New System.Windows.Forms.Button()
        Me.btnCancelar3 = New System.Windows.Forms.Button()
        Me.TabBuscar = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.TabModificar = New System.Windows.Forms.TabPage()
        Me.cboxEstadoModificar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDni2 = New System.Windows.Forms.TextBox()
        Me.txtDivision2 = New System.Windows.Forms.TextBox()
        Me.txtCurso2 = New System.Windows.Forms.TextBox()
        Me.txtDireccion2 = New System.Windows.Forms.TextBox()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar2 = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.TabAgregar = New System.Windows.Forms.TabPage()
        Me.cboxEstadoAgregar = New System.Windows.Forms.ComboBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtDivision = New System.Windows.Forms.TextBox()
        Me.txtCurso = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblDivision = New System.Windows.Forms.Label()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar2 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TabMostrar = New System.Windows.Forms.TabControl()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAsistencia.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabBuscar.SuspendLayout()
        Me.TabModificar.SuspendLayout()
        Me.TabAgregar.SuspendLayout()
        Me.TabMostrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(251, 176)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(721, 278)
        Me.DataGridView1.TabIndex = 47
        '
        'TabAsistencia
        '
        Me.TabAsistencia.BackColor = System.Drawing.Color.SkyBlue
        Me.TabAsistencia.BackgroundImage = CType(resources.GetObject("TabAsistencia.BackgroundImage"), System.Drawing.Image)
        Me.TabAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabAsistencia.Controls.Add(Me.cboxAsistencia)
        Me.TabAsistencia.Controls.Add(Me.Label16)
        Me.TabAsistencia.Controls.Add(Me.Label14)
        Me.TabAsistencia.Controls.Add(Me.txtDNI3)
        Me.TabAsistencia.Controls.Add(Me.btnGuardar3)
        Me.TabAsistencia.Controls.Add(Me.DataGridView2)
        Me.TabAsistencia.Controls.Add(Me.Label1)
        Me.TabAsistencia.Controls.Add(Me.DateTimePicker1)
        Me.TabAsistencia.Controls.Add(Me.btnMostrarAlumnos)
        Me.TabAsistencia.Controls.Add(Me.btnCancelar3)
        Me.TabAsistencia.Location = New System.Drawing.Point(4, 22)
        Me.TabAsistencia.Name = "TabAsistencia"
        Me.TabAsistencia.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAsistencia.Size = New System.Drawing.Size(965, 526)
        Me.TabAsistencia.TabIndex = 4
        Me.TabAsistencia.Text = "Asistencia"
        '
        'cboxAsistencia
        '
        Me.cboxAsistencia.FormattingEnabled = True
        Me.cboxAsistencia.Items.AddRange(New Object() {"Presente", "Ausente"})
        Me.cboxAsistencia.Location = New System.Drawing.Point(79, 69)
        Me.cboxAsistencia.Name = "cboxAsistencia"
        Me.cboxAsistencia.Size = New System.Drawing.Size(110, 21)
        Me.cboxAsistencia.TabIndex = 58
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(18, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Asistencia"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "DNI"
        '
        'txtDNI3
        '
        Me.txtDNI3.Location = New System.Drawing.Point(79, 37)
        Me.txtDNI3.Name = "txtDNI3"
        Me.txtDNI3.Size = New System.Drawing.Size(110, 20)
        Me.txtDNI3.TabIndex = 51
        '
        'btnGuardar3
        '
        Me.btnGuardar3.Location = New System.Drawing.Point(21, 183)
        Me.btnGuardar3.Name = "btnGuardar3"
        Me.btnGuardar3.Size = New System.Drawing.Size(116, 32)
        Me.btnGuardar3.TabIndex = 50
        Me.btnGuardar3.Text = "Guardar Asistencia"
        Me.btnGuardar3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(282, 13)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(677, 123)
        Me.DataGridView2.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Fecha"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(79, 11)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(198, 20)
        Me.DateTimePicker1.TabIndex = 45
        '
        'btnMostrarAlumnos
        '
        Me.btnMostrarAlumnos.Location = New System.Drawing.Point(21, 130)
        Me.btnMostrarAlumnos.Name = "btnMostrarAlumnos"
        Me.btnMostrarAlumnos.Size = New System.Drawing.Size(171, 35)
        Me.btnMostrarAlumnos.TabIndex = 8
        Me.btnMostrarAlumnos.Text = "Mostrar Alumnos Regulares"
        Me.btnMostrarAlumnos.UseVisualStyleBackColor = True
        '
        'btnCancelar3
        '
        Me.btnCancelar3.Location = New System.Drawing.Point(21, 230)
        Me.btnCancelar3.Name = "btnCancelar3"
        Me.btnCancelar3.Size = New System.Drawing.Size(116, 33)
        Me.btnCancelar3.TabIndex = 7
        Me.btnCancelar3.Text = "Cancelar"
        Me.btnCancelar3.UseVisualStyleBackColor = True
        '
        'TabBuscar
        '
        Me.TabBuscar.BackColor = System.Drawing.Color.SkyBlue
        Me.TabBuscar.BackgroundImage = CType(resources.GetObject("TabBuscar.BackgroundImage"), System.Drawing.Image)
        Me.TabBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabBuscar.Controls.Add(Me.Label10)
        Me.TabBuscar.Controls.Add(Me.TextBox1)
        Me.TabBuscar.Controls.Add(Me.RadioButton2)
        Me.TabBuscar.Controls.Add(Me.RadioButton1)
        Me.TabBuscar.Controls.Add(Me.btnBuscar)
        Me.TabBuscar.Location = New System.Drawing.Point(4, 22)
        Me.TabBuscar.Name = "TabBuscar"
        Me.TabBuscar.Size = New System.Drawing.Size(965, 526)
        Me.TabBuscar.TabIndex = 3
        Me.TabBuscar.Text = "Buscar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Buscar Alumnos Por:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 107)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(233, 20)
        Me.TextBox1.TabIndex = 3
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(3, 61)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(81, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Por Apellido"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(3, 38)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(81, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Por Nombre"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(3, 142)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(81, 39)
        Me.btnBuscar.TabIndex = 0
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'TabModificar
        '
        Me.TabModificar.BackColor = System.Drawing.Color.SkyBlue
        Me.TabModificar.BackgroundImage = CType(resources.GetObject("TabModificar.BackgroundImage"), System.Drawing.Image)
        Me.TabModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabModificar.Controls.Add(Me.cboxEstadoModificar)
        Me.TabModificar.Controls.Add(Me.Label2)
        Me.TabModificar.Controls.Add(Me.txtDni2)
        Me.TabModificar.Controls.Add(Me.txtDivision2)
        Me.TabModificar.Controls.Add(Me.txtCurso2)
        Me.TabModificar.Controls.Add(Me.txtDireccion2)
        Me.TabModificar.Controls.Add(Me.txtNombre2)
        Me.TabModificar.Controls.Add(Me.txtApellido2)
        Me.TabModificar.Controls.Add(Me.Label3)
        Me.TabModificar.Controls.Add(Me.Label4)
        Me.TabModificar.Controls.Add(Me.Label5)
        Me.TabModificar.Controls.Add(Me.Label6)
        Me.TabModificar.Controls.Add(Me.Label7)
        Me.TabModificar.Controls.Add(Me.Label8)
        Me.TabModificar.Controls.Add(Me.Label9)
        Me.TabModificar.Controls.Add(Me.btnCancelar)
        Me.TabModificar.Controls.Add(Me.btnGuardar2)
        Me.TabModificar.Controls.Add(Me.btnModificar)
        Me.TabModificar.Location = New System.Drawing.Point(4, 22)
        Me.TabModificar.Name = "TabModificar"
        Me.TabModificar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabModificar.Size = New System.Drawing.Size(965, 526)
        Me.TabModificar.TabIndex = 1
        Me.TabModificar.Text = "Modificar"
        '
        'cboxEstadoModificar
        '
        Me.cboxEstadoModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxEstadoModificar.FormattingEnabled = True
        Me.cboxEstadoModificar.Items.AddRange(New Object() {"Regular", "Egresó de la Institución", "Baja por Pase"})
        Me.cboxEstadoModificar.Location = New System.Drawing.Point(79, 342)
        Me.cboxEstadoModificar.Name = "cboxEstadoModificar"
        Me.cboxEstadoModificar.Size = New System.Drawing.Size(142, 21)
        Me.cboxEstadoModificar.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 438)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 57
        '
        'txtDni2
        '
        Me.txtDni2.Location = New System.Drawing.Point(100, 24)
        Me.txtDni2.Name = "txtDni2"
        Me.txtDni2.Size = New System.Drawing.Size(100, 20)
        Me.txtDni2.TabIndex = 55
        '
        'txtDivision2
        '
        Me.txtDivision2.Location = New System.Drawing.Point(100, 270)
        Me.txtDivision2.Name = "txtDivision2"
        Me.txtDivision2.Size = New System.Drawing.Size(100, 20)
        Me.txtDivision2.TabIndex = 53
        '
        'txtCurso2
        '
        Me.txtCurso2.Location = New System.Drawing.Point(100, 213)
        Me.txtCurso2.Name = "txtCurso2"
        Me.txtCurso2.Size = New System.Drawing.Size(100, 20)
        Me.txtCurso2.TabIndex = 52
        '
        'txtDireccion2
        '
        Me.txtDireccion2.Location = New System.Drawing.Point(100, 164)
        Me.txtDireccion2.Name = "txtDireccion2"
        Me.txtDireccion2.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion2.TabIndex = 51
        '
        'txtNombre2
        '
        Me.txtNombre2.Location = New System.Drawing.Point(100, 111)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre2.TabIndex = 50
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(100, 62)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido2.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Division"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Curso"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Direccion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Apellido"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "DNI"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(121, 383)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 37)
        Me.btnCancelar.TabIndex = 23
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar2
        '
        Me.btnGuardar2.Location = New System.Drawing.Point(3, 383)
        Me.btnGuardar2.Name = "btnGuardar2"
        Me.btnGuardar2.Size = New System.Drawing.Size(85, 37)
        Me.btnGuardar2.TabIndex = 22
        Me.btnGuardar2.Text = "Guardar"
        Me.btnGuardar2.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(235, 27)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(136, 22)
        Me.btnModificar.TabIndex = 21
        Me.btnModificar.Text = "Modificar Alumno"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'TabAgregar
        '
        Me.TabAgregar.BackColor = System.Drawing.Color.SkyBlue
        Me.TabAgregar.BackgroundImage = CType(resources.GetObject("TabAgregar.BackgroundImage"), System.Drawing.Image)
        Me.TabAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabAgregar.Controls.Add(Me.cboxEstadoAgregar)
        Me.TabAgregar.Controls.Add(Me.txtDNI)
        Me.TabAgregar.Controls.Add(Me.txtDivision)
        Me.TabAgregar.Controls.Add(Me.txtCurso)
        Me.TabAgregar.Controls.Add(Me.txtDireccion)
        Me.TabAgregar.Controls.Add(Me.txtNombre)
        Me.TabAgregar.Controls.Add(Me.txtApellido)
        Me.TabAgregar.Controls.Add(Me.lblEstado)
        Me.TabAgregar.Controls.Add(Me.lblDivision)
        Me.TabAgregar.Controls.Add(Me.lblCurso)
        Me.TabAgregar.Controls.Add(Me.lblDireccion)
        Me.TabAgregar.Controls.Add(Me.lblNombre)
        Me.TabAgregar.Controls.Add(Me.lblApellido)
        Me.TabAgregar.Controls.Add(Me.lblDNI)
        Me.TabAgregar.Controls.Add(Me.btnAgregar)
        Me.TabAgregar.Controls.Add(Me.btnCancelar2)
        Me.TabAgregar.Controls.Add(Me.btnGuardar)
        Me.TabAgregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabAgregar.Location = New System.Drawing.Point(4, 22)
        Me.TabAgregar.Name = "TabAgregar"
        Me.TabAgregar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAgregar.Size = New System.Drawing.Size(965, 526)
        Me.TabAgregar.TabIndex = 0
        Me.TabAgregar.Text = "Agregar"
        '
        'cboxEstadoAgregar
        '
        Me.cboxEstadoAgregar.FormattingEnabled = True
        Me.cboxEstadoAgregar.Items.AddRange(New Object() {"Regular", "Egresó de la Institución", "Baja por Pase"})
        Me.cboxEstadoAgregar.Location = New System.Drawing.Point(64, 330)
        Me.cboxEstadoAgregar.Name = "cboxEstadoAgregar"
        Me.cboxEstadoAgregar.Size = New System.Drawing.Size(165, 21)
        Me.cboxEstadoAgregar.TabIndex = 42
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(107, 17)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 39
        '
        'txtDivision
        '
        Me.txtDivision.Location = New System.Drawing.Point(107, 263)
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.Size = New System.Drawing.Size(100, 20)
        Me.txtDivision.TabIndex = 37
        '
        'txtCurso
        '
        Me.txtCurso.Location = New System.Drawing.Point(107, 206)
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(100, 20)
        Me.txtCurso.TabIndex = 36
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(107, 157)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 35
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(107, 104)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 34
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(107, 55)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 33
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(9, 338)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 32
        Me.lblEstado.Text = "Estado"
        '
        'lblDivision
        '
        Me.lblDivision.AutoSize = True
        Me.lblDivision.Location = New System.Drawing.Point(9, 270)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(44, 13)
        Me.lblDivision.TabIndex = 31
        Me.lblDivision.Text = "Division"
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Location = New System.Drawing.Point(12, 213)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblCurso.Size = New System.Drawing.Size(34, 13)
        Me.lblCurso.TabIndex = 30
        Me.lblCurso.Text = "Curso"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(9, 164)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 29
        Me.lblDireccion.Text = "Direccion"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(9, 111)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 28
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(9, 62)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 27
        Me.lblApellido.Text = "Apellido"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(9, 24)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(26, 13)
        Me.lblDNI.TabIndex = 26
        Me.lblDNI.Text = "DNI"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(252, 14)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(113, 23)
        Me.btnAgregar.TabIndex = 25
        Me.btnAgregar.Text = "Volver a habilitar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar2
        '
        Me.btnCancelar2.Location = New System.Drawing.Point(107, 375)
        Me.btnCancelar2.Name = "btnCancelar2"
        Me.btnCancelar2.Size = New System.Drawing.Size(122, 34)
        Me.btnCancelar2.TabIndex = 24
        Me.btnCancelar2.Text = "Cancelar"
        Me.btnCancelar2.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(0, 375)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(88, 34)
        Me.btnGuardar.TabIndex = 23
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'TabMostrar
        '
        Me.TabMostrar.AccessibleDescription = "Mostrar"
        Me.TabMostrar.AccessibleName = "Mostrar"
        Me.TabMostrar.Controls.Add(Me.TabAgregar)
        Me.TabMostrar.Controls.Add(Me.TabModificar)
        Me.TabMostrar.Controls.Add(Me.TabBuscar)
        Me.TabMostrar.Controls.Add(Me.TabAsistencia)
        Me.TabMostrar.Location = New System.Drawing.Point(12, 12)
        Me.TabMostrar.Name = "TabMostrar"
        Me.TabMostrar.SelectedIndex = 0
        Me.TabMostrar.Size = New System.Drawing.Size(973, 552)
        Me.TabMostrar.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(984, 564)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TabMostrar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAsistencia.ResumeLayout(False)
        Me.TabAsistencia.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabBuscar.ResumeLayout(False)
        Me.TabBuscar.PerformLayout()
        Me.TabModificar.ResumeLayout(False)
        Me.TabModificar.PerformLayout()
        Me.TabAgregar.ResumeLayout(False)
        Me.TabAgregar.PerformLayout()
        Me.TabMostrar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents TabAsistencia As Windows.Forms.TabPage
    Friend WithEvents cboxAsistencia As Windows.Forms.ComboBox
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents txtDNI3 As Windows.Forms.TextBox
    Friend WithEvents btnGuardar3 As Windows.Forms.Button
    Friend WithEvents DataGridView2 As Windows.Forms.DataGridView
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As Windows.Forms.DateTimePicker
    Friend WithEvents btnMostrarAlumnos As Windows.Forms.Button
    Friend WithEvents btnCancelar3 As Windows.Forms.Button
    Friend WithEvents TabBuscar As Windows.Forms.TabPage
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As Windows.Forms.RadioButton
    Friend WithEvents btnBuscar As Windows.Forms.Button
    Friend WithEvents TabModificar As Windows.Forms.TabPage
    Friend WithEvents cboxEstadoModificar As Windows.Forms.ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtDni2 As Windows.Forms.TextBox
    Friend WithEvents txtDivision2 As Windows.Forms.TextBox
    Friend WithEvents txtCurso2 As Windows.Forms.TextBox
    Friend WithEvents txtDireccion2 As Windows.Forms.TextBox
    Friend WithEvents txtNombre2 As Windows.Forms.TextBox
    Friend WithEvents txtApellido2 As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents btnCancelar As Windows.Forms.Button
    Friend WithEvents btnGuardar2 As Windows.Forms.Button
    Friend WithEvents btnModificar As Windows.Forms.Button
    Friend WithEvents TabAgregar As Windows.Forms.TabPage
    Friend WithEvents cboxEstadoAgregar As Windows.Forms.ComboBox
    Friend WithEvents txtDNI As Windows.Forms.TextBox
    Friend WithEvents txtDivision As Windows.Forms.TextBox
    Friend WithEvents txtCurso As Windows.Forms.TextBox
    Friend WithEvents txtDireccion As Windows.Forms.TextBox
    Friend WithEvents txtNombre As Windows.Forms.TextBox
    Friend WithEvents txtApellido As Windows.Forms.TextBox
    Friend WithEvents lblEstado As Windows.Forms.Label
    Friend WithEvents lblDivision As Windows.Forms.Label
    Friend WithEvents lblCurso As Windows.Forms.Label
    Friend WithEvents lblDireccion As Windows.Forms.Label
    Friend WithEvents lblNombre As Windows.Forms.Label
    Friend WithEvents lblApellido As Windows.Forms.Label
    Friend WithEvents lblDNI As Windows.Forms.Label
    Friend WithEvents btnAgregar As Windows.Forms.Button
    Friend WithEvents btnCancelar2 As Windows.Forms.Button
    Friend WithEvents btnGuardar As Windows.Forms.Button
    Friend WithEvents TabMostrar As Windows.Forms.TabControl
    Friend WithEvents Label10 As Windows.Forms.Label
End Class
