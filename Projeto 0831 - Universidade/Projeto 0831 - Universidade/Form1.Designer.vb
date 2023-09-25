<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnnovo = New System.Windows.Forms.ToolStripButton()
        Me.btnsalvar = New System.Windows.Forms.ToolStripButton()
        Me.btnalterar = New System.Windows.Forms.ToolStripButton()
        Me.btnexcluir = New System.Windows.Forms.ToolStripButton()
        Me.btnlocalizar = New System.Windows.Forms.ToolStripButton()
        Me.btnajuda = New System.Windows.Forms.ToolStripButton()
        Me.btnsair = New System.Windows.Forms.ToolStripButton()
        Me.gbxdadosaluno = New System.Windows.Forms.GroupBox()
        Me.lblidade = New System.Windows.Forms.Label()
        Me.lblidd = New System.Windows.Forms.Label()
        Me.rbtmasc = New System.Windows.Forms.RadioButton()
        Me.rbtfem = New System.Windows.Forms.RadioButton()
        Me.mskdatanasc = New System.Windows.Forms.MaskedTextBox()
        Me.lblsexo = New System.Windows.Forms.Label()
        Me.cbocid = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.lblcdd = New System.Windows.Forms.Label()
        Me.lblnomealuno = New System.Windows.Forms.Label()
        Me.gbxdadoscurso = New System.Windows.Forms.GroupBox()
        Me.rbano = New System.Windows.Forms.RadioButton()
        Me.rbsem = New System.Windows.Forms.RadioButton()
        Me.cboarea = New System.Windows.Forms.ComboBox()
        Me.cbodurac = New System.Windows.Forms.ComboBox()
        Me.cbonc = New System.Windows.Forms.ComboBox()
        Me.lblarea = New System.Windows.Forms.Label()
        Me.lbldurac = New System.Windows.Forms.Label()
        Me.lblnomecurso = New System.Windows.Forms.Label()
        Me.gbxvalores = New System.Windows.Forms.GroupBox()
        Me.lblpagm = New System.Windows.Forms.Label()
        Me.lbldesct = New System.Windows.Forms.Label()
        Me.lblvalor = New System.Windows.Forms.Label()
        Me.lblms = New System.Windows.Forms.Label()
        Me.lblpagamento = New System.Windows.Forms.Label()
        Me.cbobolsa = New System.Windows.Forms.ComboBox()
        Me.lblmens = New System.Windows.Forms.Label()
        Me.lbldesconto = New System.Windows.Forms.Label()
        Me.lblvl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        Me.gbxdadosaluno.SuspendLayout()
        Me.gbxdadoscurso.SuspendLayout()
        Me.gbxvalores.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnovo, Me.btnsalvar, Me.btnalterar, Me.btnexcluir, Me.btnlocalizar, Me.btnajuda, Me.btnsair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(750, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnnovo
        '
        Me.btnnovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnnovo.Image = CType(resources.GetObject("btnnovo.Image"), System.Drawing.Image)
        Me.btnnovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnovo.Name = "btnnovo"
        Me.btnnovo.Size = New System.Drawing.Size(23, 22)
        Me.btnnovo.Text = "Novo"
        '
        'btnsalvar
        '
        Me.btnsalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnsalvar.Image = CType(resources.GetObject("btnsalvar.Image"), System.Drawing.Image)
        Me.btnsalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(23, 22)
        Me.btnsalvar.Text = "Salvar"
        '
        'btnalterar
        '
        Me.btnalterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnalterar.Image = CType(resources.GetObject("btnalterar.Image"), System.Drawing.Image)
        Me.btnalterar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnalterar.Name = "btnalterar"
        Me.btnalterar.Size = New System.Drawing.Size(23, 22)
        Me.btnalterar.Text = "Alterar"
        '
        'btnexcluir
        '
        Me.btnexcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnexcluir.Image = CType(resources.GetObject("btnexcluir.Image"), System.Drawing.Image)
        Me.btnexcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnexcluir.Name = "btnexcluir"
        Me.btnexcluir.Size = New System.Drawing.Size(23, 22)
        Me.btnexcluir.Text = "Excluir"
        '
        'btnlocalizar
        '
        Me.btnlocalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnlocalizar.Image = CType(resources.GetObject("btnlocalizar.Image"), System.Drawing.Image)
        Me.btnlocalizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnlocalizar.Name = "btnlocalizar"
        Me.btnlocalizar.Size = New System.Drawing.Size(23, 22)
        Me.btnlocalizar.Text = "Localizar"
        '
        'btnajuda
        '
        Me.btnajuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnajuda.Image = CType(resources.GetObject("btnajuda.Image"), System.Drawing.Image)
        Me.btnajuda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnajuda.Name = "btnajuda"
        Me.btnajuda.Size = New System.Drawing.Size(23, 22)
        Me.btnajuda.Text = "Ajuda"
        '
        'btnsair
        '
        Me.btnsair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnsair.Image = CType(resources.GetObject("btnsair.Image"), System.Drawing.Image)
        Me.btnsair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(23, 22)
        Me.btnsair.Text = "Sair"
        '
        'gbxdadosaluno
        '
        Me.gbxdadosaluno.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gbxdadosaluno.Controls.Add(Me.lblidade)
        Me.gbxdadosaluno.Controls.Add(Me.lblidd)
        Me.gbxdadosaluno.Controls.Add(Me.rbtmasc)
        Me.gbxdadosaluno.Controls.Add(Me.rbtfem)
        Me.gbxdadosaluno.Controls.Add(Me.mskdatanasc)
        Me.gbxdadosaluno.Controls.Add(Me.lblsexo)
        Me.gbxdadosaluno.Controls.Add(Me.cbocid)
        Me.gbxdadosaluno.Controls.Add(Me.Label2)
        Me.gbxdadosaluno.Controls.Add(Me.txtnome)
        Me.gbxdadosaluno.Controls.Add(Me.lblcdd)
        Me.gbxdadosaluno.Controls.Add(Me.lblnomealuno)
        Me.gbxdadosaluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxdadosaluno.Location = New System.Drawing.Point(21, 53)
        Me.gbxdadosaluno.Name = "gbxdadosaluno"
        Me.gbxdadosaluno.Size = New System.Drawing.Size(706, 142)
        Me.gbxdadosaluno.TabIndex = 1
        Me.gbxdadosaluno.TabStop = False
        Me.gbxdadosaluno.Text = "Dados do Aluno"
        '
        'lblidade
        '
        Me.lblidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidade.Location = New System.Drawing.Point(545, 101)
        Me.lblidade.Name = "lblidade"
        Me.lblidade.Size = New System.Drawing.Size(143, 29)
        Me.lblidade.TabIndex = 8
        '
        'lblidd
        '
        Me.lblidd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidd.Location = New System.Drawing.Point(465, 102)
        Me.lblidd.Name = "lblidd"
        Me.lblidd.Size = New System.Drawing.Size(62, 28)
        Me.lblidd.TabIndex = 7
        Me.lblidd.Text = "Idade"
        '
        'rbtmasc
        '
        Me.rbtmasc.AutoSize = True
        Me.rbtmasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtmasc.Location = New System.Drawing.Point(225, 102)
        Me.rbtmasc.Name = "rbtmasc"
        Me.rbtmasc.Size = New System.Drawing.Size(123, 28)
        Me.rbtmasc.TabIndex = 6
        Me.rbtmasc.TabStop = True
        Me.rbtmasc.Text = "Masculino"
        Me.rbtmasc.UseVisualStyleBackColor = True
        '
        'rbtfem
        '
        Me.rbtfem.AutoSize = True
        Me.rbtfem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtfem.Location = New System.Drawing.Point(107, 102)
        Me.rbtfem.Name = "rbtfem"
        Me.rbtfem.Size = New System.Drawing.Size(116, 28)
        Me.rbtfem.TabIndex = 5
        Me.rbtfem.TabStop = True
        Me.rbtfem.Text = "Feminino"
        Me.rbtfem.UseVisualStyleBackColor = True
        '
        'mskdatanasc
        '
        Me.mskdatanasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskdatanasc.Location = New System.Drawing.Point(545, 61)
        Me.mskdatanasc.Mask = "##/##/####"
        Me.mskdatanasc.Name = "mskdatanasc"
        Me.mskdatanasc.Size = New System.Drawing.Size(143, 26)
        Me.mskdatanasc.TabIndex = 4
        '
        'lblsexo
        '
        Me.lblsexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsexo.Location = New System.Drawing.Point(26, 104)
        Me.lblsexo.Name = "lblsexo"
        Me.lblsexo.Size = New System.Drawing.Size(85, 28)
        Me.lblsexo.TabIndex = 3
        Me.lblsexo.Text = "Sexo"
        '
        'cbocid
        '
        Me.cbocid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocid.FormattingEnabled = True
        Me.cbocid.Location = New System.Drawing.Point(107, 61)
        Me.cbocid.Name = "cbocid"
        Me.cbocid.Size = New System.Drawing.Size(225, 26)
        Me.cbocid.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(338, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Data de Nascimento"
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(107, 32)
        Me.txtnome.MaxLength = 40
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(581, 29)
        Me.txtnome.TabIndex = 2
        '
        'lblcdd
        '
        Me.lblcdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcdd.Location = New System.Drawing.Point(16, 61)
        Me.lblcdd.Name = "lblcdd"
        Me.lblcdd.Size = New System.Drawing.Size(85, 28)
        Me.lblcdd.TabIndex = 1
        Me.lblcdd.Text = "Cidade"
        '
        'lblnomealuno
        '
        Me.lblnomealuno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomealuno.Location = New System.Drawing.Point(16, 33)
        Me.lblnomealuno.Name = "lblnomealuno"
        Me.lblnomealuno.Size = New System.Drawing.Size(85, 28)
        Me.lblnomealuno.TabIndex = 0
        Me.lblnomealuno.Text = "Nome"
        '
        'gbxdadoscurso
        '
        Me.gbxdadoscurso.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gbxdadoscurso.Controls.Add(Me.rbano)
        Me.gbxdadoscurso.Controls.Add(Me.rbsem)
        Me.gbxdadoscurso.Controls.Add(Me.cboarea)
        Me.gbxdadoscurso.Controls.Add(Me.cbodurac)
        Me.gbxdadoscurso.Controls.Add(Me.cbonc)
        Me.gbxdadoscurso.Controls.Add(Me.lblarea)
        Me.gbxdadoscurso.Controls.Add(Me.lbldurac)
        Me.gbxdadoscurso.Controls.Add(Me.lblnomecurso)
        Me.gbxdadoscurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxdadoscurso.Location = New System.Drawing.Point(21, 201)
        Me.gbxdadoscurso.Name = "gbxdadoscurso"
        Me.gbxdadoscurso.Size = New System.Drawing.Size(706, 122)
        Me.gbxdadoscurso.TabIndex = 2
        Me.gbxdadoscurso.TabStop = False
        Me.gbxdadoscurso.Text = "Dados do Curso"
        '
        'rbano
        '
        Me.rbano.AutoSize = True
        Me.rbano.Location = New System.Drawing.Point(415, 68)
        Me.rbano.Name = "rbano"
        Me.rbano.Size = New System.Drawing.Size(82, 28)
        Me.rbano.TabIndex = 13
        Me.rbano.TabStop = True
        Me.rbano.Text = "Anual"
        Me.rbano.UseVisualStyleBackColor = True
        '
        'rbsem
        '
        Me.rbsem.AutoSize = True
        Me.rbsem.Location = New System.Drawing.Point(289, 68)
        Me.rbsem.Name = "rbsem"
        Me.rbsem.Size = New System.Drawing.Size(120, 28)
        Me.rbsem.TabIndex = 12
        Me.rbsem.TabStop = True
        Me.rbsem.Text = "Semestral"
        Me.rbsem.UseVisualStyleBackColor = True
        '
        'cboarea
        '
        Me.cboarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboarea.FormattingEnabled = True
        Me.cboarea.Location = New System.Drawing.Point(545, 32)
        Me.cboarea.Name = "cboarea"
        Me.cboarea.Size = New System.Drawing.Size(144, 26)
        Me.cboarea.TabIndex = 11
        '
        'cbodurac
        '
        Me.cbodurac.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodurac.FormattingEnabled = True
        Me.cbodurac.Location = New System.Drawing.Point(107, 68)
        Me.cbodurac.Name = "cbodurac"
        Me.cbodurac.Size = New System.Drawing.Size(133, 26)
        Me.cbodurac.TabIndex = 10
        '
        'cbonc
        '
        Me.cbonc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbonc.FormattingEnabled = True
        Me.cbonc.Location = New System.Drawing.Point(107, 39)
        Me.cbonc.Name = "cbonc"
        Me.cbonc.Size = New System.Drawing.Size(241, 26)
        Me.cbonc.TabIndex = 9
        '
        'lblarea
        '
        Me.lblarea.Location = New System.Drawing.Point(475, 32)
        Me.lblarea.Name = "lblarea"
        Me.lblarea.Size = New System.Drawing.Size(85, 28)
        Me.lblarea.TabIndex = 6
        Me.lblarea.Text = "Área"
        '
        'lbldurac
        '
        Me.lbldurac.Location = New System.Drawing.Point(6, 68)
        Me.lbldurac.Name = "lbldurac"
        Me.lbldurac.Size = New System.Drawing.Size(104, 28)
        Me.lbldurac.TabIndex = 5
        Me.lbldurac.Text = "Duração"
        '
        'lblnomecurso
        '
        Me.lblnomecurso.Location = New System.Drawing.Point(25, 40)
        Me.lblnomecurso.Name = "lblnomecurso"
        Me.lblnomecurso.Size = New System.Drawing.Size(85, 28)
        Me.lblnomecurso.TabIndex = 4
        Me.lblnomecurso.Text = "Nome"
        '
        'gbxvalores
        '
        Me.gbxvalores.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gbxvalores.Controls.Add(Me.lblpagm)
        Me.gbxvalores.Controls.Add(Me.lbldesct)
        Me.gbxvalores.Controls.Add(Me.lblvalor)
        Me.gbxvalores.Controls.Add(Me.lblms)
        Me.gbxvalores.Controls.Add(Me.lblpagamento)
        Me.gbxvalores.Controls.Add(Me.cbobolsa)
        Me.gbxvalores.Controls.Add(Me.lblmens)
        Me.gbxvalores.Controls.Add(Me.lbldesconto)
        Me.gbxvalores.Controls.Add(Me.lblvl)
        Me.gbxvalores.Controls.Add(Me.Label8)
        Me.gbxvalores.Controls.Add(Me.PictureBox1)
        Me.gbxvalores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxvalores.Location = New System.Drawing.Point(21, 329)
        Me.gbxvalores.Name = "gbxvalores"
        Me.gbxvalores.Size = New System.Drawing.Size(706, 172)
        Me.gbxvalores.TabIndex = 2
        Me.gbxvalores.TabStop = False
        Me.gbxvalores.Text = "Valores"
        '
        'lblpagm
        '
        Me.lblpagm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpagm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpagm.Location = New System.Drawing.Point(545, 109)
        Me.lblpagm.Name = "lblpagm"
        Me.lblpagm.Size = New System.Drawing.Size(143, 28)
        Me.lblpagm.TabIndex = 10
        '
        'lbldesct
        '
        Me.lbldesct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldesct.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesct.Location = New System.Drawing.Point(545, 81)
        Me.lbldesct.Name = "lbldesct"
        Me.lbldesct.Size = New System.Drawing.Size(143, 28)
        Me.lbldesct.TabIndex = 11
        '
        'lblvalor
        '
        Me.lblvalor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblvalor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalor.Location = New System.Drawing.Point(545, 53)
        Me.lblvalor.Name = "lblvalor"
        Me.lblvalor.Size = New System.Drawing.Size(143, 28)
        Me.lblvalor.TabIndex = 12
        '
        'lblms
        '
        Me.lblms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblms.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblms.Location = New System.Drawing.Point(545, 24)
        Me.lblms.Name = "lblms"
        Me.lblms.Size = New System.Drawing.Size(143, 28)
        Me.lblms.TabIndex = 13
        '
        'lblpagamento
        '
        Me.lblpagamento.Location = New System.Drawing.Point(411, 109)
        Me.lblpagamento.Name = "lblpagamento"
        Me.lblpagamento.Size = New System.Drawing.Size(116, 28)
        Me.lblpagamento.TabIndex = 18
        Me.lblpagamento.Text = "Pagamento"
        '
        'cbobolsa
        '
        Me.cbobolsa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbobolsa.FormattingEnabled = True
        Me.cbobolsa.Location = New System.Drawing.Point(260, 55)
        Me.cbobolsa.Name = "cbobolsa"
        Me.cbobolsa.Size = New System.Drawing.Size(84, 26)
        Me.cbobolsa.TabIndex = 14
        '
        'lblmens
        '
        Me.lblmens.Location = New System.Drawing.Point(393, 25)
        Me.lblmens.Name = "lblmens"
        Me.lblmens.Size = New System.Drawing.Size(134, 28)
        Me.lblmens.TabIndex = 14
        Me.lblmens.Text = "Mensalidade"
        '
        'lbldesconto
        '
        Me.lbldesconto.Location = New System.Drawing.Point(423, 81)
        Me.lbldesconto.Name = "lbldesconto"
        Me.lbldesconto.Size = New System.Drawing.Size(104, 28)
        Me.lbldesconto.TabIndex = 15
        Me.lbldesconto.Text = "Desconto"
        '
        'lblvl
        '
        Me.lblvl.Location = New System.Drawing.Point(465, 53)
        Me.lblvl.Name = "lblvl"
        Me.lblvl.Size = New System.Drawing.Size(62, 28)
        Me.lblvl.TabIndex = 16
        Me.lblvl.Text = "Valor"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(256, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 28)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Bolsa %"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 129)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(750, 530)
        Me.Controls.Add(Me.gbxvalores)
        Me.Controls.Add(Me.gbxdadoscurso)
        Me.Controls.Add(Me.gbxdadosaluno)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbxdadosaluno.ResumeLayout(False)
        Me.gbxdadosaluno.PerformLayout()
        Me.gbxdadoscurso.ResumeLayout(False)
        Me.gbxdadoscurso.PerformLayout()
        Me.gbxvalores.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents gbxdadosaluno As System.Windows.Forms.GroupBox
    Friend WithEvents lblidade As System.Windows.Forms.Label
    Friend WithEvents lblidd As System.Windows.Forms.Label
    Friend WithEvents rbtmasc As System.Windows.Forms.RadioButton
    Friend WithEvents rbtfem As System.Windows.Forms.RadioButton
    Friend WithEvents mskdatanasc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblsexo As System.Windows.Forms.Label
    Friend WithEvents cbocid As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents lblcdd As System.Windows.Forms.Label
    Friend WithEvents lblnomealuno As System.Windows.Forms.Label
    Friend WithEvents gbxdadoscurso As System.Windows.Forms.GroupBox
    Friend WithEvents rbano As System.Windows.Forms.RadioButton
    Friend WithEvents rbsem As System.Windows.Forms.RadioButton
    Friend WithEvents cboarea As System.Windows.Forms.ComboBox
    Friend WithEvents cbodurac As System.Windows.Forms.ComboBox
    Friend WithEvents cbonc As System.Windows.Forms.ComboBox
    Friend WithEvents lblarea As System.Windows.Forms.Label
    Friend WithEvents lbldurac As System.Windows.Forms.Label
    Friend WithEvents lblnomecurso As System.Windows.Forms.Label
    Friend WithEvents gbxvalores As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblvl As System.Windows.Forms.Label
    Friend WithEvents lbldesconto As System.Windows.Forms.Label
    Friend WithEvents lblmens As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblpagm As System.Windows.Forms.Label
    Friend WithEvents lbldesct As System.Windows.Forms.Label
    Friend WithEvents lblvalor As System.Windows.Forms.Label
    Friend WithEvents lblms As System.Windows.Forms.Label
    Friend WithEvents lblpagamento As System.Windows.Forms.Label
    Friend WithEvents cbobolsa As System.Windows.Forms.ComboBox
    Friend WithEvents btnnovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnsalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnalterar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnexcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnlocalizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnajuda As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnsair As System.Windows.Forms.ToolStripButton

End Class
