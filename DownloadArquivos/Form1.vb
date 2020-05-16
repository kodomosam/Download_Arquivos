Imports Microsoft.Win32

Public Class frmMain
    'usado para configurar a uril de download
    Dim uriOrigem As Uri
    '
    Dim arquivoDestino As String
    '
    'Cria uma nova instância da classe WebClient
    Dim downloading As New Net.WebClient
    '
    'Usada para gerenciar a API Timer para calcular a velocidade aproximada do download
    '
    'Contém o ID do timer
    Dim timerID As IntPtr = 0
    '
    'trata o valor calculado da  velocidade de download
    Dim velocidadeDownload As Integer = 0
    '
    'Usado para tratar as velocidades de download maxima e media
    Dim velocidadeMaxima As Integer = 1
    Dim velocidadeMedia As Integer = 2
    '
    'usadas para ajusr a calcular a velocidade média
    Dim contadorLoop As Integer = 0
    Dim contadorByte As Integer = 0
    '
    ' usada para aproximar a velocidade de download
    Dim BytesAtuais As Long
    Dim BytesAnteriores As Long
    '
    Dim tamanhoDownload As Long = 0
    '
    'usado para fornecer o tempo decorrido desde o inicio do download
    Dim tempoInicio As Long
    Dim tempoDecorrido As TimeSpan
    '
    ' tenta calcular o tempo restante
    Dim tempoRestante As TimeSpan
    Dim tempoRestanteMedia As Double
    ' Configura o tratamento de eventos do programa
    Sub DefineTratamentoEventos()
        Try
            'pegaDownloadEmProgresso será disparada sempre que o método DownloadAsync atualizar o status do download do arquivo
            AddHandler downloading.DownloadProgressChanged, AddressOf pegaDownloadEmProgresso
            AddHandler downloading.DownloadFileCompleted, AddressOf DownloadTerminou
            '
            'configura o tratmento da api timer
            AddHandler SystemEvents.TimerElapsed, AddressOf AtualizaDownload

        Catch exc As Exception
            MessageBox.Show(exc.Message, "  Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    '
    'Metodo chamado quando o evento TimeElapsed quando a API Timer for executada
    Sub AtualizaDownload(ByVal sender As Object, ByVal e As Microsoft.Win32.TimerElapsedEventArgs)
        'Calcula a velocidade aproxima de download
        Try
            'total de bytes que foram processados desde a áultima vez que o valor foii checado (1 segundo atrás)
            velocidadeDownload = (BytesAtuais - BytesAnteriores)
            'Exibe o tempo que foi decorrido desde que o download iniciou
            tempoDecorrido = TimeSpan.FromTicks((Now.Ticks - tempoInicio))
            lblTempoDecorrido.Text = "Tempo Decorrido : " & String.Format("{0:00}:{1:00}:{2:00}", tempoDecorrido.TotalHours, tempoDecorrido.Minutes, tempoDecorrido.Seconds)
            If velocidadeDownload < 1 Then
                lblVelocidade.Text = "Velocidade : < 1 KB/s"
                lblVelocidadeKBits.Text = "Velocidade : < 1 Kb/s"
            Else
                'Exibe a velocidade em Kilo-BYTEs speed. 
                lblVelocidade.Text = "Velocidade : " & FormatNumber(velocidadeDownload / 1024, 2).ToString & " KB/s"
                lblVelocidadeKBits.Text = "Velocidade : " & FormatNumber((velocidadeDownload / 1024) * 8, 2).ToString & " Kb/s"
            End If
            'Numeros abaixo de um não vão ser exibidos
            If Not velocidadeDownload < 1 Then
                contadorLoop += 1
                contadorByte += velocidadeDownload
                velocidadeMedia = (contadorByte / contadorLoop) / 1024
                lblMedia.Text = "Média : " & FormatNumber((contadorByte / contadorLoop) / 1024, 2) & " KB/s"
                '
            End If
            If velocidadeDownload > velocidadeMaxima Then
                velocidadeMaxima = velocidadeDownload
                lblVelocidadeMaxima.Text = "Máximo : " & FormatNumber(velocidadeMaxima / 1024, 2) & " KB/s"
            End If
            'Calcula o tempo restante para o download
            If Not velocidadeDownload < 1 Then
                tempoRestanteMedia = CDbl(tempoDecorrido.TotalSeconds / BytesAtuais)
                tempoRestante = TimeSpan.FromSeconds(tempoRestanteMedia * (tamanhoDownload - BytesAtuais))

                lblTempoRestante.Text = "Tempo Restante : " & String.Format("{0:00}:{1:00}:{2:00}", tempoRestante.TotalHours, tempoRestante.Minutes, tempoRestante.Seconds)
            End If
            'mantem o valor anterior para recalcular  velocidade quando o time alcança 1 segundo novamente
            BytesAnteriores = BytesAtuais
        Catch exc As Exception
            MessageBox.Show(exc.Message, "  Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    'Esta sub contém o código que faz o download
    Sub FazDownload()
        Try
            arquivoDestino = txtDestinoDownload.Text
            'Usnado a versão Assincrona do método DownloadFile your applications thread won't be focused on the 
            downloading.DownloadFileAsync(uriOrigem, arquivoDestino)
            btnCancelarDownload.Enabled = True
            btnIniciarDownload.Enabled = False
        Catch exc As Exception
            MessageBox.Show(exc.Message, "  Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    'É disparada quando o download terminar
    Sub DownloadTerminou(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Try
            If e.Cancelled Then
                lblStatus.Text = "Status: Cancelado."
                btnAbrirArquivo.Enabled = False
            Else
                lblStatus.Text = "Status: Concluído !"
                btnAbrirArquivo.Enabled = True
            End If
            btnCancelarDownload.Enabled = False
            btnIniciarDownload.Enabled = True
            '
            If timerID.ToInt32 > 0 Then
                SystemEvents.KillTimer(timerID)
                timerID = Nothing
            End If
        Catch exc As Exception
            MessageBox.Show(e.Error.Message, "  Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    'Será disparada quando o evento DownloadProgress atuar
    Sub pegaDownloadEmProgresso(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
        Try
            'atualiza o percental da progressbar
            pgbarDownload.Value = e.ProgressPercentage
            lblProgresso.Text = "Progresso : " & e.ProgressPercentage.ToString & "%"
            tamanhoDownload = e.TotalBytesToReceive
            lblBaixados.Text = "Baixados : " & FormatNumber(e.BytesReceived / 1024, 2).ToString & " KB"
            lblTamanho.Text = "Tamanho  : " & FormatNumber(e.TotalBytesToReceive / 1024, 2).ToString & " KB"
            BytesAtuais = e.BytesReceived
        Catch exc As Exception
            MessageBox.Show(exc.Message, "  Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciarDownload.Click
        Try
            'limpa os valores
            BytesAtuais = 0
            BytesAnteriores = 0
            velocidadeDownload = 0
            velocidadeMaxima = 0
            velocidadeMedia = 0
            contadorLoop = 0
            contadorByte = 0
            pgbarDownload.Value = 0
            '
            'Define um novo Uniform Resource Identifier.
            uriOrigem = New Uri(txtOrigemDownload.Text)
            '
            ' é feito uma Ping no host antes do Download
            lblPingHost.Text = "Ping Host: " & My.Computer.Network.Ping(uriOrigem.Host)

            'Inicia o timer para a cada segundo pegar o id o qual esta sendo usado quando for matar o timer
            timerID = SystemEvents.CreateTimer((1000))
            FazDownload()
            tempoInicio = Now.Ticks
            lblStatus.Text = "Status: Iniciado."
        Catch exc As Exception
            MessageBox.Show(exc.Message, "  Download !", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    'método para cancelar o download
    Private Sub btnCancelarDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarDownload.Click
        Try
            If timerID.ToInt32 > 0 Then
                SystemEvents.KillTimer(timerID)
                timerID = Nothing
            End If
            downloading.CancelAsync()
            lblPingHost.Text = "Ping Host: n/a"
        Catch exc As Exception
            MessageBox.Show(exc.Message, "  Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub btnProcurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcurar.Click

        Dim saveDLG As New SaveFileDialog
        Dim ext As String = "|Exe(*.exe)|*.exe"
        saveDLG.Filter = "Todos Arqs. (*.*)|*.*" & ext '"Exe (*.exe)|*.exe"
        saveDLG.Title = "Selecione o caminho e nome do arquivo para salvar o arquivo baixado." & vbNewLine & vbNewLine & "Inclua a extensão do arquivo."
        If saveDLG.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtDestinoDownload.Text = saveDLG.FileName
        End If
    End Sub
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If downloading.IsBusy Then
            btnCancelarDownload.PerformClick()
        End If
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DefineTratamentoEventos()
        Catch exc As Exception
            MessageBox.Show(exc.Message, "  Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub btnAbrirArquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirArquivo.Click
        Try
            'Tenta executar o arquivo que foi baixado
            If My.Computer.FileSystem.FileExists(txtDestinoDownload.Text) Then
                Process.Start(txtDestinoDownload.Text)
            Else
                MessageBox.Show("O arquivo indicado parece que não exite no lcoal de destino." & vbNewLine &
                    vbNewLine & "Verifique se o arquivo foi baixado e salvo com sucesso.", " Arquivo não pode ser aberto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch exc As Exception
            MessageBox.Show(exc.Message, "  Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        txtOrigemDownload.Clear()
        txtOrigemDownload.Paste(Clipboard.GetText)
    End Sub
    Private Sub btnEncerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnEncerrar.Click
        'descarrega os formuláros e recurso da aplicação
        btnCancelarDownload.PerformClick()
        Application.Exit()
    End Sub
End Class