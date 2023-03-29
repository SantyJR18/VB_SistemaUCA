<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DptFecha = New System.Windows.Forms.DateTimePicker()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.LblBievenida = New System.Windows.Forms.Label()
        Me.TmrAux = New System.Windows.Forms.Timer(Me.components)
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.TxtVisita = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblVisita = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaUCA.My.Resources.Resources.logoUCA
        Me.PictureBox1.Location = New System.Drawing.Point(459, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DptFecha)
        Me.GroupBox1.Controls.Add(Me.LblHora)
        Me.GroupBox1.Controls.Add(Me.LblBievenida)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 141)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'DptFecha
        '
        Me.DptFecha.Location = New System.Drawing.Point(23, 83)
        Me.DptFecha.Name = "DptFecha"
        Me.DptFecha.Size = New System.Drawing.Size(297, 20)
        Me.DptFecha.TabIndex = 2
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.Location = New System.Drawing.Point(338, 35)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(71, 20)
        Me.LblHora.TabIndex = 1
        Me.LblHora.Text = "00:00:00"
        Me.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblBievenida
        '
        Me.LblBievenida.AutoSize = True
        Me.LblBievenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBievenida.Location = New System.Drawing.Point(19, 35)
        Me.LblBievenida.Name = "LblBievenida"
        Me.LblBievenida.Size = New System.Drawing.Size(301, 20)
        Me.LblBievenida.TabIndex = 0
        Me.LblBievenida.Text = "Bienvenido al Sistema de Registros UCA "
        Me.LblBievenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TmrAux
        '
        Me.TmrAux.Interval = 1000
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.BtnLimpiar)
        Me.GbDatos.Controls.Add(Me.BtnAgregar)
        Me.GbDatos.Controls.Add(Me.TxtVisita)
        Me.GbDatos.Controls.Add(Me.TxtApellido)
        Me.GbDatos.Controls.Add(Me.TxtNombre)
        Me.GbDatos.Controls.Add(Me.LblVisita)
        Me.GbDatos.Controls.Add(Me.LblApellido)
        Me.GbDatos.Controls.Add(Me.LblNombre)
        Me.GbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDatos.Location = New System.Drawing.Point(30, 185)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(601, 252)
        Me.GbDatos.TabIndex = 2
        Me.GbDatos.TabStop = False
        Me.GbDatos.Text = "Datos Generales"
        '
        'TxtVisita
        '
        Me.TxtVisita.Location = New System.Drawing.Point(161, 110)
        Me.TxtVisita.Multiline = True
        Me.TxtVisita.Name = "TxtVisita"
        Me.TxtVisita.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtVisita.Size = New System.Drawing.Size(230, 122)
        Me.TxtVisita.TabIndex = 5
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(161, 71)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(230, 22)
        Me.TxtApellido.TabIndex = 4
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(161, 36)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(230, 22)
        Me.TxtNombre.TabIndex = 3
        '
        'LblVisita
        '
        Me.LblVisita.AutoSize = True
        Me.LblVisita.Location = New System.Drawing.Point(37, 113)
        Me.LblVisita.Name = "LblVisita"
        Me.LblVisita.Size = New System.Drawing.Size(109, 16)
        Me.LblVisita.TabIndex = 2
        Me.LblVisita.Text = "Motivo de Visita: "
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(69, 74)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(68, 16)
        Me.LblApellido.TabIndex = 1
        Me.LblApellido.Text = "Apellidos:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(69, 39)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(67, 16)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombres:"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(455, 71)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 32)
        Me.BtnAgregar.TabIndex = 6
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(455, 109)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 32)
        Me.BtnLimpiar.TabIndex = 7
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(663, 442)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.Text = "Sistema UCA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblHora As Label
    Friend WithEvents LblBievenida As Label
    Friend WithEvents DptFecha As DateTimePicker
    Friend WithEvents TmrAux As Timer
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblVisita As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtVisita As TextBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnAgregar As Button
End Class
