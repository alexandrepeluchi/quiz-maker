<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EscolhaMateria
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btnComecar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Escolha a matéria"
        '
        'btnVoltar
        '
        Me.btnVoltar.Location = New System.Drawing.Point(76, 348)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.btnVoltar.TabIndex = 1
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = True
        '
        'btnComecar
        '
        Me.btnComecar.Location = New System.Drawing.Point(250, 348)
        Me.btnComecar.Name = "btnComecar"
        Me.btnComecar.Size = New System.Drawing.Size(75, 23)
        Me.btnComecar.TabIndex = 2
        Me.btnComecar.Text = "Começar"
        Me.btnComecar.UseVisualStyleBackColor = True
        '
        'EscolhaMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 431)
        Me.Controls.Add(Me.btnComecar)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EscolhaMateria"
        Me.Text = "EscolhaMateria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnVoltar As Button
    Friend WithEvents btnComecar As Button
End Class
