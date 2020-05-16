<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnIniciarDownload = New System.Windows.Forms.Button()
        Me.btnCancelarDownload = New System.Windows.Forms.Button()
        Me.txtOrigemDownload = New System.Windows.Forms.TextBox()
        Me.txtDestinoDownload = New System.Windows.Forms.TextBox()
        Me.lblOrigem = New System.Windows.Forms.Label()
        Me.lblDestino = New System.Windows.Forms.Label()
        Me.lblTamanho = New System.Windows.Forms.Label()
        Me.lblProgresso = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pgbarDownload = New System.Windows.Forms.ProgressBar()
        Me.lblBaixados = New System.Windows.Forms.Label()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.lblVelocidade = New System.Windows.Forms.Label()
        Me.lblVelocidadeKBits = New System.Windows.Forms.Label()
        Me.ttip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblTempoDecorrido = New System.Windows.Forms.Label()
        Me.btnAbrirArquivo = New System.Windows.Forms.Button()
        Me.lblMedia = New System.Windows.Forms.Label()
        Me.lblTempoRestante = New System.Windows.Forms.Label()
        Me.lblPingHost = New System.Windows.Forms.Label()
        Me.lblVelocidadeMaxima = New System.Windows.Forms.Label()
        Me.pnlControlesStatus = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnAddToList = New System.Windows.Forms.Button()
        Me.lvQueue = New System.Windows.Forms.ListView()
        Me.chDownloadPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDestinationPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDownloadStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlOrigemDestino = New System.Windows.Forms.Panel()
        Me.btnEncerrar = New System.Windows.Forms.Button()
        Me.pnlControlesStatus.SuspendLayout()
        Me.pnlOrigemDestino.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIniciarDownload
        '
        Me.btnIniciarDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIniciarDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIniciarDownload.Image = CType(resources.GetObject("btnIniciarDownload.Image"), System.Drawing.Image)
        Me.btnIniciarDownload.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnIniciarDownload.Location = New System.Drawing.Point(15, 300)
        Me.btnIniciarDownload.Name = "btnIniciarDownload"
        Me.btnIniciarDownload.Size = New System.Drawing.Size(174, 42)
        Me.btnIniciarDownload.TabIndex = 0
        Me.btnIniciarDownload.Text = "Iniciar Agora"
        Me.btnIniciarDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ttip.SetToolTip(Me.btnIniciarDownload, "Clique para iniciar o download a partir do endereço de origem para o destino indi" &
        "cado")
        Me.btnIniciarDownload.UseVisualStyleBackColor = False
        '
        'btnCancelarDownload
        '
        Me.btnCancelarDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancelarDownload.Enabled = False
        Me.btnCancelarDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelarDownload.Image = CType(resources.GetObject("btnCancelarDownload.Image"), System.Drawing.Image)
        Me.btnCancelarDownload.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnCancelarDownload.Location = New System.Drawing.Point(194, 300)
        Me.btnCancelarDownload.Name = "btnCancelarDownload"
        Me.btnCancelarDownload.Size = New System.Drawing.Size(176, 42)
        Me.btnCancelarDownload.TabIndex = 1
        Me.btnCancelarDownload.Text = "Cancelar"
        Me.btnCancelarDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ttip.SetToolTip(Me.btnCancelarDownload, "Cancela a operação de download realizada pela classe DownloadAsync ")
        Me.btnCancelarDownload.UseVisualStyleBackColor = False
        '
        'txtOrigemDownload
        '
        Me.txtOrigemDownload.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOrigemDownload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigemDownload.Location = New System.Drawing.Point(6, 22)
        Me.txtOrigemDownload.Name = "txtOrigemDownload"
        Me.txtOrigemDownload.Size = New System.Drawing.Size(960, 29)
        Me.txtOrigemDownload.TabIndex = 2
        Me.txtOrigemDownload.Text = "http://download.microsoft.com/download/8/4/A/84A35BF1-DAFE-4AE8-82AF-AD2AE20B6B14" &
    "/directx_Jun2010_redist.exe"
        Me.ttip.SetToolTip(Me.txtOrigemDownload, "Indica o endereço de origem do arquivo para download")
        Me.txtOrigemDownload.WordWrap = False
        '
        'txtDestinoDownload
        '
        Me.txtDestinoDownload.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDestinoDownload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDestinoDownload.Location = New System.Drawing.Point(6, 87)
        Me.txtDestinoDownload.Name = "txtDestinoDownload"
        Me.txtDestinoDownload.Size = New System.Drawing.Size(825, 29)
        Me.txtDestinoDownload.TabIndex = 3
        Me.txtDestinoDownload.Text = "c:\Dados\ArquivoDownload.exe"
        Me.ttip.SetToolTip(Me.txtDestinoDownload, "Indica o local no computador local onde o arquivo baixado será armazenado")
        '
        'lblOrigem
        '
        Me.lblOrigem.AutoSize = True
        Me.lblOrigem.Location = New System.Drawing.Point(3, 3)
        Me.lblOrigem.Name = "lblOrigem"
        Me.lblOrigem.Size = New System.Drawing.Size(152, 21)
        Me.lblOrigem.TabIndex = 4
        Me.lblOrigem.Text = "Endereço de Origem"
        '
        'lblDestino
        '
        Me.lblDestino.AutoSize = True
        Me.lblDestino.BackColor = System.Drawing.Color.Transparent
        Me.lblDestino.Location = New System.Drawing.Point(3, 66)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(124, 21)
        Me.lblDestino.TabIndex = 5
        Me.lblDestino.Text = "Local de Destino"
        '
        'lblTamanho
        '
        Me.lblTamanho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTamanho.AutoEllipsis = True
        Me.lblTamanho.Location = New System.Drawing.Point(702, 0)
        Me.lblTamanho.Name = "lblTamanho"
        Me.lblTamanho.Size = New System.Drawing.Size(258, 21)
        Me.lblTamanho.TabIndex = 6
        Me.lblTamanho.Text = "Tamanho : 0 KB"
        '
        'lblProgresso
        '
        Me.lblProgresso.AutoEllipsis = True
        Me.lblProgresso.Location = New System.Drawing.Point(12, 90)
        Me.lblProgresso.Name = "lblProgresso"
        Me.lblProgresso.Size = New System.Drawing.Size(251, 21)
        Me.lblProgresso.TabIndex = 7
        Me.lblProgresso.Text = "Progresso : 0%"
        Me.ttip.SetToolTip(Me.lblProgresso, "Shows how far along the download is based on a percentage value between 0 and 100" &
        "%")
        '
        'lblStatus
        '
        Me.lblStatus.AutoEllipsis = True
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(12, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(251, 21)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "Status: Idle"
        Me.ttip.SetToolTip(Me.lblStatus, "O status da aplicação")
        '
        'pgbarDownload
        '
        Me.pgbarDownload.Location = New System.Drawing.Point(15, 111)
        Me.pgbarDownload.Name = "pgbarDownload"
        Me.pgbarDownload.Size = New System.Drawing.Size(225, 24)
        Me.pgbarDownload.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgbarDownload.TabIndex = 9
        Me.ttip.SetToolTip(Me.pgbarDownload, "Exibe o percentual do download em execução")
        '
        'lblBaixados
        '
        Me.lblBaixados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBaixados.AutoEllipsis = True
        Me.lblBaixados.Location = New System.Drawing.Point(702, 21)
        Me.lblBaixados.Name = "lblBaixados"
        Me.lblBaixados.Size = New System.Drawing.Size(243, 21)
        Me.lblBaixados.TabIndex = 10
        Me.lblBaixados.Text = "Baixados : 0 KB"
        '
        'btnProcurar
        '
        Me.btnProcurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurar.AutoEllipsis = True
        Me.btnProcurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProcurar.Location = New System.Drawing.Point(837, 73)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(123, 45)
        Me.btnProcurar.TabIndex = 11
        Me.btnProcurar.Text = "Salvar Para ..."
        Me.ttip.SetToolTip(Me.btnProcurar, "Clique aqui para selecionar a pasta de destino do arquivo de download")
        Me.btnProcurar.UseVisualStyleBackColor = False
        '
        'lblVelocidade
        '
        Me.lblVelocidade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVelocidade.AutoEllipsis = True
        Me.lblVelocidade.Location = New System.Drawing.Point(702, 57)
        Me.lblVelocidade.Name = "lblVelocidade"
        Me.lblVelocidade.Size = New System.Drawing.Size(246, 21)
        Me.lblVelocidade.TabIndex = 13
        Me.lblVelocidade.Text = "Velocidade : 0 KB/s"
        Me.ttip.SetToolTip(Me.lblVelocidade, "A velocidade atual aproximada do download em Kilo-bytes por segundo (1KB=1000byte" &
        "s)")
        '
        'lblVelocidadeKBits
        '
        Me.lblVelocidadeKBits.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVelocidadeKBits.AutoEllipsis = True
        Me.lblVelocidadeKBits.Location = New System.Drawing.Point(702, 78)
        Me.lblVelocidadeKBits.Name = "lblVelocidadeKBits"
        Me.lblVelocidadeKBits.Size = New System.Drawing.Size(246, 21)
        Me.lblVelocidadeKBits.TabIndex = 14
        Me.lblVelocidadeKBits.Text = "Velocidade: 0 kb/s"
        Me.ttip.SetToolTip(Me.lblVelocidadeKBits, "The approximate current speed your downloading at in kilo-bits (8 bits in 1 Byte)" &
        " each second")
        '
        'lblTempoDecorrido
        '
        Me.lblTempoDecorrido.AutoEllipsis = True
        Me.lblTempoDecorrido.Location = New System.Drawing.Point(12, 36)
        Me.lblTempoDecorrido.Name = "lblTempoDecorrido"
        Me.lblTempoDecorrido.Size = New System.Drawing.Size(251, 21)
        Me.lblTempoDecorrido.TabIndex = 15
        Me.lblTempoDecorrido.Text = "Tempo decorrido: n/a"
        Me.ttip.SetToolTip(Me.lblTempoDecorrido, "O tempo que foi gasto desde que o download iniciou")
        '
        'btnAbrirArquivo
        '
        Me.btnAbrirArquivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAbrirArquivo.Enabled = False
        Me.btnAbrirArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAbrirArquivo.Image = CType(resources.GetObject("btnAbrirArquivo.Image"), System.Drawing.Image)
        Me.btnAbrirArquivo.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnAbrirArquivo.Location = New System.Drawing.Point(392, 300)
        Me.btnAbrirArquivo.Name = "btnAbrirArquivo"
        Me.btnAbrirArquivo.Size = New System.Drawing.Size(120, 42)
        Me.btnAbrirArquivo.TabIndex = 16
        Me.btnAbrirArquivo.Text = "Abrir"
        Me.btnAbrirArquivo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ttip.SetToolTip(Me.btnAbrirArquivo, "Abre o arquivo que foi baixado na pasta de destino")
        Me.btnAbrirArquivo.UseVisualStyleBackColor = False
        '
        'lblMedia
        '
        Me.lblMedia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Location = New System.Drawing.Point(702, 133)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(104, 21)
        Me.lblMedia.TabIndex = 18
        Me.lblMedia.Text = "Média: 0 KB/s"
        Me.ttip.SetToolTip(Me.lblMedia, "A velocidade média relativa para o download em progresso")
        '
        'lblTempoRestante
        '
        Me.lblTempoRestante.Location = New System.Drawing.Point(12, 57)
        Me.lblTempoRestante.Name = "lblTempoRestante"
        Me.lblTempoRestante.Size = New System.Drawing.Size(251, 21)
        Me.lblTempoRestante.TabIndex = 19
        Me.lblTempoRestante.Text = "Tempo restante: n/a"
        Me.ttip.SetToolTip(Me.lblTempoRestante, "O tempo restante aproximado para o download terminar")
        '
        'lblPingHost
        '
        Me.lblPingHost.Location = New System.Drawing.Point(15, 140)
        Me.lblPingHost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPingHost.Name = "lblPingHost"
        Me.lblPingHost.Size = New System.Drawing.Size(247, 22)
        Me.lblPingHost.TabIndex = 22
        Me.lblPingHost.Text = "Ping Host: n/a"
        Me.ttip.SetToolTip(Me.lblPingHost, "Se o ping retornar True então foi feito contato com o host para download" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Caso " &
        "contrário a conexão com o host falhou")
        '
        'lblVelocidadeMaxima
        '
        Me.lblVelocidadeMaxima.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVelocidadeMaxima.AutoSize = True
        Me.lblVelocidadeMaxima.Location = New System.Drawing.Point(702, 112)
        Me.lblVelocidadeMaxima.Name = "lblVelocidadeMaxima"
        Me.lblVelocidadeMaxima.Size = New System.Drawing.Size(117, 21)
        Me.lblVelocidadeMaxima.TabIndex = 20
        Me.lblVelocidadeMaxima.Text = "Maximo: 0 KB/s"
        Me.ttip.SetToolTip(Me.lblVelocidadeMaxima, "A velocidade máxima detectada em Kilo-bytes para o download atual")
        '
        'pnlControlesStatus
        '
        Me.pnlControlesStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlControlesStatus.BackColor = System.Drawing.Color.Transparent
        Me.pnlControlesStatus.Controls.Add(Me.lblPingHost)
        Me.pnlControlesStatus.Controls.Add(Me.btnClose)
        Me.pnlControlesStatus.Controls.Add(Me.lblTempoRestante)
        Me.pnlControlesStatus.Controls.Add(Me.lblVelocidadeMaxima)
        Me.pnlControlesStatus.Controls.Add(Me.lblMedia)
        Me.pnlControlesStatus.Controls.Add(Me.lblStatus)
        Me.pnlControlesStatus.Controls.Add(Me.lblTempoDecorrido)
        Me.pnlControlesStatus.Controls.Add(Me.lblBaixados)
        Me.pnlControlesStatus.Controls.Add(Me.lblVelocidadeKBits)
        Me.pnlControlesStatus.Controls.Add(Me.pgbarDownload)
        Me.pnlControlesStatus.Controls.Add(Me.lblProgresso)
        Me.pnlControlesStatus.Controls.Add(Me.lblTamanho)
        Me.pnlControlesStatus.Controls.Add(Me.lblVelocidade)
        Me.pnlControlesStatus.Location = New System.Drawing.Point(0, 127)
        Me.pnlControlesStatus.Name = "pnlControlesStatus"
        Me.pnlControlesStatus.Size = New System.Drawing.Size(970, 167)
        Me.pnlControlesStatus.TabIndex = 16
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(309, 225)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(0, 0)
        Me.btnClose.TabIndex = 21
        Me.btnClose.TabStop = False
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpar.Location = New System.Drawing.Point(706, 300)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(129, 42)
        Me.btnLimpar.TabIndex = 20
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        Me.btnLimpar.Visible = False
        '
        'btnAddToList
        '
        Me.btnAddToList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddToList.AutoEllipsis = True
        Me.btnAddToList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddToList.Location = New System.Drawing.Point(464, 482)
        Me.btnAddToList.Name = "btnAddToList"
        Me.btnAddToList.Size = New System.Drawing.Size(123, 45)
        Me.btnAddToList.TabIndex = 17
        Me.btnAddToList.Text = "Add to List"
        Me.btnAddToList.UseVisualStyleBackColor = True
        '
        'lvQueue
        '
        Me.lvQueue.AllowColumnReorder = True
        Me.lvQueue.AutoArrange = False
        Me.lvQueue.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chDownloadPath, Me.chDestinationPath, Me.chDownloadStatus})
        Me.lvQueue.FullRowSelect = True
        Me.lvQueue.GridLines = True
        Me.lvQueue.HideSelection = False
        Me.lvQueue.LabelEdit = True
        Me.lvQueue.Location = New System.Drawing.Point(320, 487)
        Me.lvQueue.MultiSelect = False
        Me.lvQueue.Name = "lvQueue"
        Me.lvQueue.ShowGroups = False
        Me.lvQueue.ShowItemToolTips = True
        Me.lvQueue.Size = New System.Drawing.Size(28, 38)
        Me.lvQueue.TabIndex = 18
        Me.lvQueue.UseCompatibleStateImageBehavior = False
        Me.lvQueue.View = System.Windows.Forms.View.Details
        '
        'chDownloadPath
        '
        Me.chDownloadPath.Text = "Source Address"
        Me.chDownloadPath.Width = 196
        '
        'chDestinationPath
        '
        Me.chDestinationPath.Text = "Destination Path"
        Me.chDestinationPath.Width = 142
        '
        'chDownloadStatus
        '
        Me.chDownloadStatus.Text = "Status"
        '
        'pnlOrigemDestino
        '
        Me.pnlOrigemDestino.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOrigemDestino.BackColor = System.Drawing.Color.Transparent
        Me.pnlOrigemDestino.Controls.Add(Me.txtOrigemDownload)
        Me.pnlOrigemDestino.Controls.Add(Me.txtDestinoDownload)
        Me.pnlOrigemDestino.Controls.Add(Me.lblOrigem)
        Me.pnlOrigemDestino.Controls.Add(Me.lblDestino)
        Me.pnlOrigemDestino.Controls.Add(Me.btnProcurar)
        Me.pnlOrigemDestino.Location = New System.Drawing.Point(0, 0)
        Me.pnlOrigemDestino.Name = "pnlOrigemDestino"
        Me.pnlOrigemDestino.Size = New System.Drawing.Size(970, 122)
        Me.pnlOrigemDestino.TabIndex = 19
        '
        'btnEncerrar
        '
        Me.btnEncerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEncerrar.Location = New System.Drawing.Point(843, 301)
        Me.btnEncerrar.Name = "btnEncerrar"
        Me.btnEncerrar.Size = New System.Drawing.Size(123, 41)
        Me.btnEncerrar.TabIndex = 21
        Me.btnEncerrar.Text = "Encerrar"
        Me.btnEncerrar.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnIniciarDownload
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(972, 347)
        Me.Controls.Add(Me.btnEncerrar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.pnlOrigemDestino)
        Me.Controls.Add(Me.lvQueue)
        Me.Controls.Add(Me.btnAddToList)
        Me.Controls.Add(Me.pnlControlesStatus)
        Me.Controls.Add(Me.btnIniciarDownload)
        Me.Controls.Add(Me.btnCancelarDownload)
        Me.Controls.Add(Me.btnAbrirArquivo)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Download de Arquivos"
        Me.pnlControlesStatus.ResumeLayout(False)
        Me.pnlControlesStatus.PerformLayout()
        Me.pnlOrigemDestino.ResumeLayout(False)
        Me.pnlOrigemDestino.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnIniciarDownload As System.Windows.Forms.Button
    Friend WithEvents btnCancelarDownload As System.Windows.Forms.Button
    Friend WithEvents txtOrigemDownload As System.Windows.Forms.TextBox
    Friend WithEvents txtDestinoDownload As System.Windows.Forms.TextBox
    Friend WithEvents lblOrigem As System.Windows.Forms.Label
    Friend WithEvents lblDestino As System.Windows.Forms.Label
    Friend WithEvents lblTamanho As System.Windows.Forms.Label
    Friend WithEvents lblProgresso As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents pgbarDownload As System.Windows.Forms.ProgressBar
    Friend WithEvents lblBaixados As System.Windows.Forms.Label
    Friend WithEvents btnProcurar As System.Windows.Forms.Button
    Friend WithEvents lblVelocidade As System.Windows.Forms.Label
    Friend WithEvents lblVelocidadeKBits As System.Windows.Forms.Label
    Friend WithEvents ttip As System.Windows.Forms.ToolTip
    Friend WithEvents lblTempoDecorrido As System.Windows.Forms.Label
    Friend WithEvents pnlControlesStatus As System.Windows.Forms.Panel
    Friend WithEvents btnAbrirArquivo As System.Windows.Forms.Button
    Friend WithEvents btnAddToList As System.Windows.Forms.Button
    Friend WithEvents lvQueue As System.Windows.Forms.ListView
    Friend WithEvents chDownloadPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDestinationPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblMedia As System.Windows.Forms.Label
    Friend WithEvents lblVelocidadeMaxima As System.Windows.Forms.Label
    Friend WithEvents lblTempoRestante As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents chDownloadStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlOrigemDestino As System.Windows.Forms.Panel
    Friend WithEvents lblPingHost As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnEncerrar As System.Windows.Forms.Button

End Class
