﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_viewProduct_a172423
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_product_name = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_battery = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_material = New System.Windows.Forms.Label()
        Me.lbl_createdAt = New System.Windows.Forms.Label()
        Me.lbl_updatedAt = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_material = New System.Windows.Forms.TextBox()
        Me.txt_battery = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_created_at = New System.Windows.Forms.TextBox()
        Me.txt_updated_at = New System.Windows.Forms.TextBox()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(357, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(203, 56)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Product"
        '
        'pic_product
        '
        Me.pic_product.Location = New System.Drawing.Point(33, 117)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(226, 161)
        Me.pic_product.TabIndex = 1
        Me.pic_product.TabStop = False
        '
        'lbl_product_name
        '
        Me.lbl_product_name.AutoSize = True
        Me.lbl_product_name.Location = New System.Drawing.Point(308, 122)
        Me.lbl_product_name.Name = "lbl_product_name"
        Me.lbl_product_name.Size = New System.Drawing.Size(35, 13)
        Me.lbl_product_name.TabIndex = 2
        Me.lbl_product_name.Text = "Name"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(622, 122)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(31, 13)
        Me.lbl_price.TabIndex = 3
        Me.lbl_price.Text = "Price"
        '
        'lbl_battery
        '
        Me.lbl_battery.AutoSize = True
        Me.lbl_battery.Location = New System.Drawing.Point(622, 216)
        Me.lbl_battery.Name = "lbl_battery"
        Me.lbl_battery.Size = New System.Drawing.Size(74, 13)
        Me.lbl_battery.TabIndex = 4
        Me.lbl_battery.Text = "Power Source"
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Location = New System.Drawing.Point(308, 168)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(46, 13)
        Me.lbl_quantity.TabIndex = 5
        Me.lbl_quantity.Text = "Quantity"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Location = New System.Drawing.Point(622, 168)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(31, 13)
        Me.lbl_type.TabIndex = 6
        Me.lbl_type.Text = "Type"
        '
        'lbl_material
        '
        Me.lbl_material.AutoSize = True
        Me.lbl_material.Location = New System.Drawing.Point(308, 216)
        Me.lbl_material.Name = "lbl_material"
        Me.lbl_material.Size = New System.Drawing.Size(44, 13)
        Me.lbl_material.TabIndex = 7
        Me.lbl_material.Text = "Material"
        '
        'lbl_createdAt
        '
        Me.lbl_createdAt.AutoSize = True
        Me.lbl_createdAt.Location = New System.Drawing.Point(308, 261)
        Me.lbl_createdAt.Name = "lbl_createdAt"
        Me.lbl_createdAt.Size = New System.Drawing.Size(57, 13)
        Me.lbl_createdAt.TabIndex = 8
        Me.lbl_createdAt.Text = "Created At"
        '
        'lbl_updatedAt
        '
        Me.lbl_updatedAt.AutoSize = True
        Me.lbl_updatedAt.Location = New System.Drawing.Point(622, 261)
        Me.lbl_updatedAt.Name = "lbl_updatedAt"
        Me.lbl_updatedAt.Size = New System.Drawing.Size(61, 13)
        Me.lbl_updatedAt.TabIndex = 9
        Me.lbl_updatedAt.Text = "Updated At"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(381, 122)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(124, 20)
        Me.txt_name.TabIndex = 10
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(381, 165)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(124, 20)
        Me.txt_quantity.TabIndex = 11
        '
        'txt_material
        '
        Me.txt_material.Location = New System.Drawing.Point(381, 213)
        Me.txt_material.Name = "txt_material"
        Me.txt_material.Size = New System.Drawing.Size(124, 20)
        Me.txt_material.TabIndex = 12
        '
        'txt_battery
        '
        Me.txt_battery.Location = New System.Drawing.Point(702, 213)
        Me.txt_battery.Name = "txt_battery"
        Me.txt_battery.Size = New System.Drawing.Size(100, 20)
        Me.txt_battery.TabIndex = 15
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(702, 119)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(100, 20)
        Me.txt_price.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Label1"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(599, 352)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 20
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Location = New System.Drawing.Point(423, 352)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 21
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Crimson
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(259, 352)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 19
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'txt_created_at
        '
        Me.txt_created_at.Location = New System.Drawing.Point(381, 258)
        Me.txt_created_at.Name = "txt_created_at"
        Me.txt_created_at.ReadOnly = True
        Me.txt_created_at.Size = New System.Drawing.Size(124, 20)
        Me.txt_created_at.TabIndex = 22
        '
        'txt_updated_at
        '
        Me.txt_updated_at.Location = New System.Drawing.Point(702, 258)
        Me.txt_updated_at.Name = "txt_updated_at"
        Me.txt_updated_at.ReadOnly = True
        Me.txt_updated_at.Size = New System.Drawing.Size(100, 20)
        Me.txt_updated_at.TabIndex = 23
        '
        'cmb_type
        '
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(702, 165)
        Me.cmb_type.MaxDropDownItems = 3
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(100, 21)
        Me.cmb_type.TabIndex = 24
        '
        'frm_viewProduct_a172423
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.ClientSize = New System.Drawing.Size(930, 407)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.txt_updated_at)
        Me.Controls.Add(Me.txt_created_at)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_battery)
        Me.Controls.Add(Me.txt_material)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_updatedAt)
        Me.Controls.Add(Me.lbl_createdAt)
        Me.Controls.Add(Me.lbl_material)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.lbl_battery)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_product_name)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_viewProduct_a172423"
        Me.Text = "Product Detail"
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_product_name As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_battery As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_material As Label
    Friend WithEvents lbl_createdAt As Label
    Friend WithEvents lbl_updatedAt As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents txt_material As TextBox
    Friend WithEvents txt_battery As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_created_at As TextBox
    Friend WithEvents txt_updated_at As TextBox
    Friend WithEvents cmb_type As ComboBox
End Class
