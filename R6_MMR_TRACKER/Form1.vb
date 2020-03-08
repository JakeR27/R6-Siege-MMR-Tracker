Public Class Form1

    Private playerDetails(10) As String
    Private Sub btn_set_p1_Click(sender As Object, e As EventArgs) Handles btn_t1_p1_set.Click, btn_t1_search.Click
        Dim player As SiegePlayer = siegeTracker.retrievePlayerData(txtbx_p1_name.Text, True)

        If (If(player.found, "found", "notfound")) = "found" Then
            lbl_Level.Text = player.level
            lbl_MMR.Text = player.mmr
            lbl_Rank.Text = player.rank
            lbl_KD.Text = player.kd.ToString("0.00")
            lbl_WLR.Text = player.wlr.ToString("0.00")
            lbl_WLC.Text = player.wlc.ToString("0.00")
            lbl_WLT.Text = player.wlt.ToString("0.00")

            txtbx_p1_name.Text = player.name

            playerDetails(1) = player.getPrettyDetails

        End If

    End Sub

    Private Sub btn_t1_p2_set_Click(sender As Object, e As EventArgs) Handles btn_t1_p2_set.Click, btn_t1_search.Click
        Dim playerDetails() As String = siegeTracker.retrievePlayerData(TextBox1.Text)

        If playerDetails(7) = "found" Then
            Label9.Text = playerDetails(0)
            Label8.Text = playerDetails(1)
            Label7.Text = playerDetails(2)
            Label6.Text = playerDetails(3)
            Label5.Text = playerDetails(4)
            Label3.Text = playerDetails(5)
            Label1.Text = playerDetails(6)

            TextBox1.Text = playerDetails(8)
        End If
    End Sub

    Private Sub btn_t1_p3_set_Click(sender As Object, e As EventArgs) Handles btn_t1_p3_set.Click, btn_t1_search.Click
        Dim playerDetails() As String = siegeTracker.retrievePlayerData(TextBox3.Text)

        If playerDetails(7) = "found" Then
            Label37.Text = playerDetails(0)
            Label36.Text = playerDetails(1)
            Label35.Text = playerDetails(2)
            Label34.Text = playerDetails(3)
            Label33.Text = playerDetails(4)
            Label31.Text = playerDetails(5)
            Label29.Text = playerDetails(6)

            TextBox3.Text = playerDetails(8)
        End If
    End Sub

    Private Sub btn_t1_p4_set_Click(sender As Object, e As EventArgs) Handles btn_t1_p4_set.Click, btn_t1_search.Click
        Dim playerDetails() As String = siegeTracker.retrievePlayerData(TextBox2.Text)

        If playerDetails(7) = "found" Then
            Label23.Text = playerDetails(0)
            Label22.Text = playerDetails(1)
            Label21.Text = playerDetails(2)
            Label20.Text = playerDetails(3)
            Label19.Text = playerDetails(4)
            Label17.Text = playerDetails(5)
            Label15.Text = playerDetails(6)

            TextBox2.Text = playerDetails(8)
        End If
    End Sub

    Private Sub btn_t1_p5_set_Click(sender As Object, e As EventArgs) Handles btn_t1_p5_set.Click, btn_t1_search.Click
        Dim playerDetails() As String = siegeTracker.retrievePlayerData(TextBox4.Text)

        If playerDetails(7) = "found" Then
            Label51.Text = playerDetails(0)
            Label50.Text = playerDetails(1)
            Label49.Text = playerDetails(2)
            Label48.Text = playerDetails(3)
            Label47.Text = playerDetails(4)
            Label45.Text = playerDetails(5)
            Label43.Text = playerDetails(6)

            TextBox4.Text = playerDetails(8)
        End If
    End Sub

    'TEAM 2###################################################################################################

    Private Sub btn_t2_p1_set_Click(sender As Object, e As EventArgs) Handles btn_t2_p1_set.Click, btn_t2_search.Click
        Dim playerDetails() As String = siegeTracker.retrievePlayerData(TextBox5.Text)

        If playerDetails(7) = "found" Then
            Label65.Text = playerDetails(0)
            Label64.Text = playerDetails(1)
            Label63.Text = playerDetails(2)
            Label62.Text = playerDetails(3)
            Label61.Text = playerDetails(4)
            Label59.Text = playerDetails(5)
            Label57.Text = playerDetails(6)

            TextBox5.Text = playerDetails(8)
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btn_t2_p2set.Click, btn_t2_search.Click
        Dim playerDetails() As String = siegeTracker.retrievePlayerData(TextBox6.Text)

        If playerDetails(7) = "found" Then
            Label79.Text = playerDetails(0)
            Label78.Text = playerDetails(1)
            Label77.Text = playerDetails(2)
            Label76.Text = playerDetails(3)
            Label75.Text = playerDetails(4)
            Label73.Text = playerDetails(5)
            Label71.Text = playerDetails(6)

            TextBox6.Text = playerDetails(8)
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles btn_t2_p3set.Click, btn_t2_search.Click
        Dim playerDetails() As String = siegeTracker.retrievePlayerData(TextBox7.Text)

        If playerDetails(7) = "found" Then
            Label93.Text = playerDetails(0)
            Label92.Text = playerDetails(1)
            Label91.Text = playerDetails(2)
            Label90.Text = playerDetails(3)
            Label89.Text = playerDetails(4)
            Label87.Text = playerDetails(5)
            Label85.Text = playerDetails(6)

            TextBox7.Text = playerDetails(8)
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles btn_t2_p4set.Click, btn_t2_search.Click
        Dim playerDetails() As String = siegeTracker.retrievePlayerData(TextBox8.Text)

        If playerDetails(7) = "found" Then
            Label107.Text = playerDetails(0)
            Label106.Text = playerDetails(1)
            Label105.Text = playerDetails(2)
            Label104.Text = playerDetails(3)
            Label103.Text = playerDetails(4)
            Label101.Text = playerDetails(5)
            Label99.Text = playerDetails(6)

            TextBox8.Text = playerDetails(8)
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles btn_t2_p5set.Click, btn_t2_search.Click
        Dim playerDetails() As String = siegeTracker.retrievePlayerData(TextBox9.Text)

        If playerDetails(7) = "found" Then
            Label121.Text = playerDetails(0)
            Label120.Text = playerDetails(1)
            Label119.Text = playerDetails(2)
            Label118.Text = playerDetails(3)
            Label117.Text = playerDetails(4)
            Label115.Text = playerDetails(5)
            Label113.Text = playerDetails(6)

            TextBox9.Text = playerDetails(8)
        End If
    End Sub

    Private Sub showDetailsButton_Click(sender As Object, e As EventArgs)
        DetailsForm.showData()
        DetailsForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Me.FormClosing
        DetailsForm.Close()

    End Sub

    Private Sub btn_p1_showDetails_Click(sender As Object, e As EventArgs) Handles btn_p1_showDetails.Click
        DetailsForm.theDataToShow = playerDetails(1)
        DetailsForm.showData()
        DetailsForm.Show()
    End Sub

    Private Sub btn_p2_showDetails_Click(sender As Object, e As EventArgs) Handles btn_p2_showDetails.Click
        DetailsForm.theDataToShow = playerDetails(2)
        DetailsForm.showData()
        DetailsForm.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DetailsForm.theDataToShow = playerDetails(3)
        DetailsForm.showData()
        DetailsForm.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DetailsForm.theDataToShow = playerDetails(4)
        DetailsForm.showData()
        DetailsForm.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        DetailsForm.theDataToShow = playerDetails(5)
        DetailsForm.showData()
        DetailsForm.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        DetailsForm.theDataToShow = playerDetails(6)
        DetailsForm.showData()
        DetailsForm.Show()
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        DetailsForm.theDataToShow = playerDetails(7)
        DetailsForm.showData()
        DetailsForm.Show()
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        DetailsForm.theDataToShow = playerDetails(8)
        DetailsForm.showData()
        DetailsForm.Show()
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        DetailsForm.theDataToShow = playerDetails(9)
        DetailsForm.showData()
        DetailsForm.Show()
    End Sub

    Private Sub Button18_Click_1(sender As Object, e As EventArgs) Handles Button18.Click
        DetailsForm.theDataToShow = playerDetails(10)
        DetailsForm.showData()
        DetailsForm.Show()
    End Sub
End Class
