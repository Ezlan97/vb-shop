﻿Public Class frm_mainmenu_a172423
    Private Sub frm_mainmenu_a172423_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_date.Text = today
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_customer_a172423.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_orders_a172423.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staff_a172423.Show()
        Me.Hide()
    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        frm_product_a172423.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub
End Class
