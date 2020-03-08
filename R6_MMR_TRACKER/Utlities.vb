Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module siegeTracker

    Private _platform As String = "psn"

    Public Property platform As String
        Get
            Return _platform
        End Get
        Set(value As String)
            _platform = value
        End Set
    End Property

    Public Team1Players() As String
    Public Team2Players() As String

    Function retrievePlayerData(ByVal playerName As String, ByVal Optional returnPlayer As Boolean = False)

        Dim player As New SiegePlayer(playerName)

        Dim details(8) As String
        details(0) = player.level
        details(1) = player.mmr
        details(2) = player.rank
        details(3) = player.kd.ToString("0.00")
        details(4) = player.wlr.ToString("0.00")
        details(5) = player.wlc.ToString("0.00")
        details(6) = player.wlt.ToString("0.00")
        details(7) = If(player.found, "found", "notfound")
        details(8) = player.name

        If returnPlayer Then
            Return player
        Else
            Return details
        End If


    End Function

    Private Function getRequest(ByVal type As Integer, ByVal nameUUID As String, Optional ByVal raw As Boolean = False)

        Dim requestURL As String

        If type = 1 Then
            requestURL = "https://r6tab.com/api/search.php?platform=" & platform & "&search=" & nameUUID
        ElseIf type = 2 Then
            requestURL = "https://r6tab.com/api/player.php?p_id=" & nameUUID
        End If


        Dim request As HttpWebRequest = WebRequest.Create(requestURL)
        Dim tempResponse As HttpWebResponse = request.GetResponse()

        Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
        Dim loResponseStream As StreamReader = New StreamReader(tempResponse.GetResponseStream(), enc)
        Dim Response As String = loResponseStream.ReadToEnd()
        Dim jss As JavaScriptSerializer = New JavaScriptSerializer()
        Dim results As Object = jss.Deserialize(Of Dictionary(Of String, Object))(Response)
        loResponseStream.Close()

        If raw Then
            Return Response
        End If

        Return results

    End Function

    Class SiegePlayer
        Private _uuid, _rank As String
        Private _receievedDetails As Object
        Public name, rank As String
        Public mmr, level As Integer
        Public wlc, wlr, wlt, kd As Decimal
        Public found As Boolean = False

        Sub New(ByVal playerName As String)
            name = playerName
            retrieveUUID()
            If _uuid <> "NOresultsFOUND" Then
                parseDetails()
                found = True
            Else
                MsgBox("PLAYER NOT FOUND")
            End If
        End Sub

        Sub retrieveUUID()

            Dim tempDict As Dictionary(Of String, Object)
            tempDict = getRequest(1, name)

            If tempDict("totalresults") = 0 Then
                _uuid = "NOresultsFOUND"
            Else
                Dim tempArrayList As ArrayList
                tempArrayList = tempDict("results")
                _receievedDetails = tempArrayList(0)
                _uuid = _receievedDetails("p_id")
                name = _receievedDetails("p_name")
                mmr = _receievedDetails("p_currentmmr")

            End If

        End Sub

        Function parseDetails()

            Dim tempDict As Dictionary(Of String, Object)
            tempDict = getRequest(2, _uuid)
            'mmr = tempDict("p_currentmmr")
            level = tempDict("p_level")

            wlr = calculateWinLoss(tempDict, 1)
            wlc = calculateWinLoss(tempDict, 2)
            wlt = calculateWinLoss(tempDict, 3)
            kd = (tempDict("kd") / 100)

            rank = calculateRank(mmr)

            _receievedDetails = getRequest(2, _uuid, True)

        End Function

        Function getPrettyDetails()

            Dim parsedJson As JToken = JToken.Parse(_receievedDetails)
            Dim beautified As String = parsedJson.ToString(Formatting.Indented)

            Return beautified

        End Function

        Private Function calculateWinLoss(ByVal tempDict As Dictionary(Of String, Object), ByVal type As Integer) As Decimal
            Dim data As ArrayList = tempDict("data")
            If data(4) = 0 Then
                data(4) = 1
            End If
            If data(9) = 0 Then
                data(9) = 1
            End If
            If type = 1 Then
                Return data(3) / data(4)
            ElseIf type = 2 Then
                Return data(8) / data(9)
            ElseIf type = 3 Then
                Return (data(3) + data(8)) / (data(4) + data(9))
            End If

        End Function

        Function calculateRank(ByVal value As Integer)
            If value >= 5000 Then
                _rank = "Champ"
            ElseIf value >= 4400 Then
                _rank = "Diamond"

            ElseIf value >= 4000 Then
                _rank = "Plat 1"
            ElseIf value >= 3600 Then
                _rank = "Plat 2"
            ElseIf value >= 3200 Then
                _rank = "Plat 3"

            ElseIf value >= 3000 Then
                _rank = "Gold 1"
            ElseIf value >= 2800 Then
                _rank = "Gold 2"
            ElseIf value >= 2600 Then
                _rank = "Gold 3"

            ElseIf value >= 2501 Then
                _rank = "Silver 1"
                '##########################
            ElseIf value = 2500 Then
                _rank = "Reset"
                '##########################
            ElseIf value >= 2400 Then
                _rank = "Silver 2"
            ElseIf value >= 2300 Then
                _rank = "Silver 3"
            ElseIf value >= 2200 Then
                _rank = "Silver 4"
            ElseIf value >= 2100 Then
                _rank = "Silver 5"

            ElseIf value >= 2000 Then
                _rank = "Bronze 1"
            ElseIf value >= 1900 Then
                _rank = "Bronze 2"
            ElseIf value >= 1800 Then
                _rank = "Bronze 3"
            ElseIf value >= 1700 Then
                _rank = "Bronze 4"
            ElseIf value >= 1600 Then
                _rank = "Bronze 5"

            ElseIf value >= 1500 Then
                _rank = "Copper 1"
            ElseIf value >= 1400 Then
                _rank = "Copper 2"
            ElseIf value >= 1300 Then
                _rank = "Copper 3"
            ElseIf value >= 1200 Then
                _rank = "Copper 4"
            ElseIf value >= 1100 Then
                _rank = "Copper 5"
            Else
                _rank = "N/A"

            End If

            Return _rank
        End Function

    End Class

    Sub closeForms(ByRef theForm As Form)

    End Sub

End Module