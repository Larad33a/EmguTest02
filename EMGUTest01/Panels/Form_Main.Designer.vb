﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TC2_Bilder = New System.Windows.Forms.TabControl()
        Me.P1_NewImg = New System.Windows.Forms.TabPage()
        Me.ib_new_Depth = New Emgu.CV.UI.ImageBox()
        Me.ib_new_Color = New Emgu.CV.UI.ImageBox()
        Me.P2_Result = New System.Windows.Forms.TabPage()
        Me.ib_res_02 = New Emgu.CV.UI.ImageBox()
        Me.ib_res_01 = New Emgu.CV.UI.ImageBox()
        Me.P3_Rev = New System.Windows.Forms.TabPage()
        Me.ib_rev_Depth = New Emgu.CV.UI.ImageBox()
        Me.ib_rev_Color = New Emgu.CV.UI.ImageBox()
        Me.P5_ResultSearchObj = New System.Windows.Forms.TabPage()
        Me.lbl_Found_Depth = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lbl_FoundWidth = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lbl_Found_Rot = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lbl_FoundZent = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lbl_FoundObj = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ib_Found = New Emgu.CV.UI.ImageBox()
        Me.P4_DepthZ16 = New System.Windows.Forms.TabPage()
        Me.ib_depth_01 = New Emgu.CV.UI.ImageBox()
        Me.P6_Sub_IOI = New System.Windows.Forms.TabPage()
        Me.ib_ImOfIn_02 = New Emgu.CV.UI.ImageBox()
        Me.ib_ImOfIn_01 = New Emgu.CV.UI.ImageBox()
        Me.P7_Sub_Laplace = New System.Windows.Forms.TabPage()
        Me.ib_laplace_02 = New Emgu.CV.UI.ImageBox()
        Me.ib_laplace_01 = New Emgu.CV.UI.ImageBox()
        Me.P8_Sub_DistImg = New System.Windows.Forms.TabPage()
        Me.ib_Dist02 = New Emgu.CV.UI.ImageBox()
        Me.ib_Dist01 = New Emgu.CV.UI.ImageBox()
        Me.P9_Sub_Mask = New System.Windows.Forms.TabPage()
        Me.ib_mask_02 = New Emgu.CV.UI.ImageBox()
        Me.ib_mask_01 = New Emgu.CV.UI.ImageBox()
        Me.P10_Sub_Points = New System.Windows.Forms.TabPage()
        Me.ib_points_02 = New Emgu.CV.UI.ImageBox()
        Me.ib_points_01 = New Emgu.CV.UI.ImageBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lb_Info = New System.Windows.Forms.ListBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btn_Konf_Col = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comb_Konf_Col_FPS = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comb_Konf_Col_Auflösung = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comb_Konf_Col_Format = New System.Windows.Forms.ComboBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.T1_CamRestart = New System.Windows.Forms.Timer(Me.components)
        Me.T2_CamBoot = New System.Windows.Forms.Timer(Me.components)
        Me.TC1_Menue = New System.Windows.Forms.TabControl()
        Me.P1_Steuerung = New System.Windows.Forms.TabPage()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.btn_LoadSearch = New System.Windows.Forms.Button()
        Me.btn_SaveSearch = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Num_SearchToleranz = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.btn_AddSearchObj = New System.Windows.Forms.Button()
        Me.tb_searchObjName = New System.Windows.Forms.TextBox()
        Me.num_newSearchObjT = New System.Windows.Forms.NumericUpDown()
        Me.num_newSearchObjB = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.num_newSearchObjH = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.lbl_InfoMaase = New System.Windows.Forms.Label()
        Me.lbl_InfoName = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_SearchObj = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.num_SearchObj = New System.Windows.Forms.NumericUpDown()
        Me.lb_SearchObjList = New System.Windows.Forms.ListBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.cb_debug = New System.Windows.Forms.CheckBox()
        Me.cb_DrawPoint = New System.Windows.Forms.CheckBox()
        Me.btn_NewImg = New System.Windows.Forms.Button()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.btn_Analyse = New System.Windows.Forms.Button()
        Me.btn_RefImg = New System.Windows.Forms.Button()
        Me.P2_Konfig = New System.Windows.Forms.TabPage()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.num_RoboOffsety = New System.Windows.Forms.NumericUpDown()
        Me.num_RoboOffsetX = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.num_pixmmB_faktor = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.num_pixmmH_faktor = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.btn_CamOffset_Reset = New System.Windows.Forms.Button()
        Me.num_CamOffset = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_Konf_Depth = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.comb_Konf_Dep_FPS = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.comb_Konf_Dep_Auflösung = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.comb_Konf_Dep_Format = New System.Windows.Forms.ComboBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cb_Tiefe_aktMaske = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_pointMax = New System.Windows.Forms.Label()
        Me.lbl_pointMin = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_tiefe = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_pos = New System.Windows.Forms.Button()
        Me.num_MaskH = New System.Windows.Forms.NumericUpDown()
        Me.num_MaskV = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.P4_Auswertung = New System.Windows.Forms.TabPage()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.cb_Watershed_Filter = New System.Windows.Forms.CheckBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.num_WTS_MinT = New System.Windows.Forms.NumericUpDown()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.num_WTS_MinB = New System.Windows.Forms.NumericUpDown()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.num_WTS_MinH = New System.Windows.Forms.NumericUpDown()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.rb_Auswertung_Color = New System.Windows.Forms.RadioButton()
        Me.rb_Auswertung_Kombi = New System.Windows.Forms.RadioButton()
        Me.rb_Auswertung_Depth = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cb_ioi_Gaus = New System.Windows.Forms.CheckBox()
        Me.cb_ioi_Mask = New System.Windows.Forms.CheckBox()
        Me.cb_ioi_Differenz = New System.Windows.Forms.CheckBox()
        Me.cb_ioi_Depth = New System.Windows.Forms.CheckBox()
        Me.num_ThreshTief = New System.Windows.Forms.NumericUpDown()
        Me.num_ThreshHoch = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.P5_Conection = New System.Windows.Forms.TabPage()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.dgv_TCPVariableViewer = New System.Windows.Forms.DataGridView()
        Me.btn_TCPVariable_Del = New System.Windows.Forms.Button()
        Me.btn_TCPVariable_Set = New System.Windows.Forms.Button()
        Me.btn_TCPVariable_New = New System.Windows.Forms.Button()
        Me.num_TCPVariable_Wert = New System.Windows.Forms.NumericUpDown()
        Me.tb_TCPVarible_Name = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.lbl_TCP_Status = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btn_TCP_Connect = New System.Windows.Forms.Button()
        Me.num_TCP_Port = New System.Windows.Forms.NumericUpDown()
        Me.tb_TCP_HOST = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.P6_test = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_TestVerschieben = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cb_refdcTaken = New System.Windows.Forms.CheckBox()
        Me.cb_colortaken = New System.Windows.Forms.CheckBox()
        Me.cb_depthcTaken = New System.Windows.Forms.CheckBox()
        Me.cb_refdTaken = New System.Windows.Forms.CheckBox()
        Me.cb_depthtaken = New System.Windows.Forms.CheckBox()
        Me.cb_refcTaken = New System.Windows.Forms.CheckBox()
        Me.TC3_ObjLists = New System.Windows.Forms.TabControl()
        Me.P1_All = New System.Windows.Forms.TabPage()
        Me.LB_obj = New System.Windows.Forms.ListBox()
        Me.P2_Found = New System.Windows.Forms.TabPage()
        Me.lb_Found = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.TC2_Bilder.SuspendLayout()
        Me.P1_NewImg.SuspendLayout()
        CType(Me.ib_new_Depth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ib_new_Color, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P2_Result.SuspendLayout()
        CType(Me.ib_res_02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ib_res_01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P3_Rev.SuspendLayout()
        CType(Me.ib_rev_Depth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ib_rev_Color, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P5_ResultSearchObj.SuspendLayout()
        CType(Me.ib_Found, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P4_DepthZ16.SuspendLayout()
        CType(Me.ib_depth_01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P6_Sub_IOI.SuspendLayout()
        CType(Me.ib_ImOfIn_02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ib_ImOfIn_01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P7_Sub_Laplace.SuspendLayout()
        CType(Me.ib_laplace_02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ib_laplace_01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P8_Sub_DistImg.SuspendLayout()
        CType(Me.ib_Dist02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ib_Dist01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P9_Sub_Mask.SuspendLayout()
        CType(Me.ib_mask_02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ib_mask_01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P10_Sub_Points.SuspendLayout()
        CType(Me.ib_points_02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ib_points_01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TC1_Menue.SuspendLayout()
        Me.P1_Steuerung.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.Num_SearchToleranz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox14.SuspendLayout()
        CType(Me.num_newSearchObjT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_newSearchObjB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_newSearchObjH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox13.SuspendLayout()
        CType(Me.num_SearchObj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.P2_Konfig.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        CType(Me.num_RoboOffsety, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_RoboOffsetX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        CType(Me.num_pixmmB_faktor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_pixmmH_faktor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox12.SuspendLayout()
        CType(Me.num_CamOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.num_MaskH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_MaskV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P4_Auswertung.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.num_WTS_MinT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_WTS_MinB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_WTS_MinH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox18.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.num_ThreshTief, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_ThreshHoch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P5_Conection.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        CType(Me.dgv_TCPVariableViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_TCPVariable_Wert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox16.SuspendLayout()
        CType(Me.num_TCP_Port, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P6_test.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TC3_ObjLists.SuspendLayout()
        Me.P1_All.SuspendLayout()
        Me.P2_Found.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TC2_Bilder)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1317, 549)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bilder:"
        '
        'TC2_Bilder
        '
        Me.TC2_Bilder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TC2_Bilder.Controls.Add(Me.P1_NewImg)
        Me.TC2_Bilder.Controls.Add(Me.P2_Result)
        Me.TC2_Bilder.Controls.Add(Me.P3_Rev)
        Me.TC2_Bilder.Controls.Add(Me.P5_ResultSearchObj)
        Me.TC2_Bilder.Controls.Add(Me.P4_DepthZ16)
        Me.TC2_Bilder.Controls.Add(Me.P6_Sub_IOI)
        Me.TC2_Bilder.Controls.Add(Me.P7_Sub_Laplace)
        Me.TC2_Bilder.Controls.Add(Me.P8_Sub_DistImg)
        Me.TC2_Bilder.Controls.Add(Me.P9_Sub_Mask)
        Me.TC2_Bilder.Controls.Add(Me.P10_Sub_Points)
        Me.TC2_Bilder.Location = New System.Drawing.Point(6, 25)
        Me.TC2_Bilder.Name = "TC2_Bilder"
        Me.TC2_Bilder.SelectedIndex = 0
        Me.TC2_Bilder.Size = New System.Drawing.Size(1304, 518)
        Me.TC2_Bilder.TabIndex = 8
        '
        'P1_NewImg
        '
        Me.P1_NewImg.Controls.Add(Me.ib_new_Depth)
        Me.P1_NewImg.Controls.Add(Me.ib_new_Color)
        Me.P1_NewImg.Location = New System.Drawing.Point(4, 25)
        Me.P1_NewImg.Name = "P1_NewImg"
        Me.P1_NewImg.Padding = New System.Windows.Forms.Padding(3)
        Me.P1_NewImg.Size = New System.Drawing.Size(1296, 489)
        Me.P1_NewImg.TabIndex = 0
        Me.P1_NewImg.Text = "Neues Bild"
        Me.P1_NewImg.UseVisualStyleBackColor = True
        '
        'ib_new_Depth
        '
        Me.ib_new_Depth.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_new_Depth.Location = New System.Drawing.Point(655, 6)
        Me.ib_new_Depth.Name = "ib_new_Depth"
        Me.ib_new_Depth.Size = New System.Drawing.Size(640, 480)
        Me.ib_new_Depth.TabIndex = 9
        Me.ib_new_Depth.TabStop = False
        '
        'ib_new_Color
        '
        Me.ib_new_Color.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_new_Color.Location = New System.Drawing.Point(6, 6)
        Me.ib_new_Color.Name = "ib_new_Color"
        Me.ib_new_Color.Size = New System.Drawing.Size(640, 480)
        Me.ib_new_Color.TabIndex = 8
        Me.ib_new_Color.TabStop = False
        '
        'P2_Result
        '
        Me.P2_Result.Controls.Add(Me.ib_res_02)
        Me.P2_Result.Controls.Add(Me.ib_res_01)
        Me.P2_Result.Location = New System.Drawing.Point(4, 25)
        Me.P2_Result.Name = "P2_Result"
        Me.P2_Result.Padding = New System.Windows.Forms.Padding(3)
        Me.P2_Result.Size = New System.Drawing.Size(1296, 489)
        Me.P2_Result.TabIndex = 1
        Me.P2_Result.Text = "Ergebnis"
        Me.P2_Result.UseVisualStyleBackColor = True
        '
        'ib_res_02
        '
        Me.ib_res_02.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_res_02.Location = New System.Drawing.Point(655, 6)
        Me.ib_res_02.Name = "ib_res_02"
        Me.ib_res_02.Size = New System.Drawing.Size(640, 480)
        Me.ib_res_02.TabIndex = 22
        Me.ib_res_02.TabStop = False
        '
        'ib_res_01
        '
        Me.ib_res_01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_res_01.Location = New System.Drawing.Point(6, 6)
        Me.ib_res_01.Name = "ib_res_01"
        Me.ib_res_01.Size = New System.Drawing.Size(640, 480)
        Me.ib_res_01.TabIndex = 21
        Me.ib_res_01.TabStop = False
        '
        'P3_Rev
        '
        Me.P3_Rev.Controls.Add(Me.ib_rev_Depth)
        Me.P3_Rev.Controls.Add(Me.ib_rev_Color)
        Me.P3_Rev.Location = New System.Drawing.Point(4, 25)
        Me.P3_Rev.Name = "P3_Rev"
        Me.P3_Rev.Size = New System.Drawing.Size(1296, 489)
        Me.P3_Rev.TabIndex = 2
        Me.P3_Rev.Text = "Reverenz"
        Me.P3_Rev.UseVisualStyleBackColor = True
        '
        'ib_rev_Depth
        '
        Me.ib_rev_Depth.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_rev_Depth.Location = New System.Drawing.Point(655, 6)
        Me.ib_rev_Depth.Name = "ib_rev_Depth"
        Me.ib_rev_Depth.Size = New System.Drawing.Size(640, 480)
        Me.ib_rev_Depth.TabIndex = 11
        Me.ib_rev_Depth.TabStop = False
        '
        'ib_rev_Color
        '
        Me.ib_rev_Color.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_rev_Color.Location = New System.Drawing.Point(6, 6)
        Me.ib_rev_Color.Name = "ib_rev_Color"
        Me.ib_rev_Color.Size = New System.Drawing.Size(640, 480)
        Me.ib_rev_Color.TabIndex = 10
        Me.ib_rev_Color.TabStop = False
        '
        'P5_ResultSearchObj
        '
        Me.P5_ResultSearchObj.Controls.Add(Me.lbl_Found_Depth)
        Me.P5_ResultSearchObj.Controls.Add(Me.Label40)
        Me.P5_ResultSearchObj.Controls.Add(Me.lbl_FoundWidth)
        Me.P5_ResultSearchObj.Controls.Add(Me.Label28)
        Me.P5_ResultSearchObj.Controls.Add(Me.lbl_Found_Rot)
        Me.P5_ResultSearchObj.Controls.Add(Me.Label26)
        Me.P5_ResultSearchObj.Controls.Add(Me.lbl_FoundZent)
        Me.P5_ResultSearchObj.Controls.Add(Me.Label24)
        Me.P5_ResultSearchObj.Controls.Add(Me.lbl_FoundObj)
        Me.P5_ResultSearchObj.Controls.Add(Me.Label22)
        Me.P5_ResultSearchObj.Controls.Add(Me.ib_Found)
        Me.P5_ResultSearchObj.Location = New System.Drawing.Point(4, 25)
        Me.P5_ResultSearchObj.Name = "P5_ResultSearchObj"
        Me.P5_ResultSearchObj.Size = New System.Drawing.Size(1296, 489)
        Me.P5_ResultSearchObj.TabIndex = 4
        Me.P5_ResultSearchObj.Text = "Gefundene Objekte"
        Me.P5_ResultSearchObj.UseVisualStyleBackColor = True
        '
        'lbl_Found_Depth
        '
        Me.lbl_Found_Depth.AutoSize = True
        Me.lbl_Found_Depth.Location = New System.Drawing.Point(780, 226)
        Me.lbl_Found_Depth.Name = "lbl_Found_Depth"
        Me.lbl_Found_Depth.Size = New System.Drawing.Size(13, 17)
        Me.lbl_Found_Depth.TabIndex = 19
        Me.lbl_Found_Depth.Text = "-"
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(670, 226)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(100, 17)
        Me.Label40.TabIndex = 18
        Me.Label40.Text = "Tiefe:"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_FoundWidth
        '
        Me.lbl_FoundWidth.AutoSize = True
        Me.lbl_FoundWidth.Location = New System.Drawing.Point(780, 80)
        Me.lbl_FoundWidth.Name = "lbl_FoundWidth"
        Me.lbl_FoundWidth.Size = New System.Drawing.Size(13, 17)
        Me.lbl_FoundWidth.TabIndex = 17
        Me.lbl_FoundWidth.Text = "-"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(670, 80)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(100, 17)
        Me.Label28.TabIndex = 16
        Me.Label28.Text = "Breite: "
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_Found_Rot
        '
        Me.lbl_Found_Rot.AutoSize = True
        Me.lbl_Found_Rot.Location = New System.Drawing.Point(780, 183)
        Me.lbl_Found_Rot.Name = "lbl_Found_Rot"
        Me.lbl_Found_Rot.Size = New System.Drawing.Size(13, 17)
        Me.lbl_Found_Rot.TabIndex = 15
        Me.lbl_Found_Rot.Text = "-"
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(670, 183)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(100, 17)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "Winkel p|r|j: "
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_FoundZent
        '
        Me.lbl_FoundZent.AutoSize = True
        Me.lbl_FoundZent.Location = New System.Drawing.Point(780, 130)
        Me.lbl_FoundZent.Name = "lbl_FoundZent"
        Me.lbl_FoundZent.Size = New System.Drawing.Size(13, 17)
        Me.lbl_FoundZent.TabIndex = 13
        Me.lbl_FoundZent.Text = "-"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(670, 130)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(100, 17)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "Zentrum x|y|z: "
        '
        'lbl_FoundObj
        '
        Me.lbl_FoundObj.AutoSize = True
        Me.lbl_FoundObj.Location = New System.Drawing.Point(780, 34)
        Me.lbl_FoundObj.Name = "lbl_FoundObj"
        Me.lbl_FoundObj.Size = New System.Drawing.Size(13, 17)
        Me.lbl_FoundObj.TabIndex = 11
        Me.lbl_FoundObj.Text = "-"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(670, 34)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 23)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Objekt: "
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ib_Found
        '
        Me.ib_Found.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_Found.Location = New System.Drawing.Point(6, 6)
        Me.ib_Found.Name = "ib_Found"
        Me.ib_Found.Size = New System.Drawing.Size(640, 480)
        Me.ib_Found.TabIndex = 9
        Me.ib_Found.TabStop = False
        '
        'P4_DepthZ16
        '
        Me.P4_DepthZ16.AutoScroll = True
        Me.P4_DepthZ16.Controls.Add(Me.ib_depth_01)
        Me.P4_DepthZ16.Location = New System.Drawing.Point(4, 25)
        Me.P4_DepthZ16.Name = "P4_DepthZ16"
        Me.P4_DepthZ16.Size = New System.Drawing.Size(1296, 489)
        Me.P4_DepthZ16.TabIndex = 3
        Me.P4_DepthZ16.Text = "Z16 Tiefenbild"
        Me.P4_DepthZ16.UseVisualStyleBackColor = True
        '
        'ib_depth_01
        '
        Me.ib_depth_01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_depth_01.Location = New System.Drawing.Point(6, 6)
        Me.ib_depth_01.Name = "ib_depth_01"
        Me.ib_depth_01.Size = New System.Drawing.Size(1280, 480)
        Me.ib_depth_01.TabIndex = 9
        Me.ib_depth_01.TabStop = False
        '
        'P6_Sub_IOI
        '
        Me.P6_Sub_IOI.Controls.Add(Me.ib_ImOfIn_02)
        Me.P6_Sub_IOI.Controls.Add(Me.ib_ImOfIn_01)
        Me.P6_Sub_IOI.Location = New System.Drawing.Point(4, 25)
        Me.P6_Sub_IOI.Name = "P6_Sub_IOI"
        Me.P6_Sub_IOI.Size = New System.Drawing.Size(1296, 489)
        Me.P6_Sub_IOI.TabIndex = 5
        Me.P6_Sub_IOI.Text = "Sub_ImageOfInterest"
        Me.P6_Sub_IOI.UseVisualStyleBackColor = True
        '
        'ib_ImOfIn_02
        '
        Me.ib_ImOfIn_02.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_ImOfIn_02.Location = New System.Drawing.Point(653, 4)
        Me.ib_ImOfIn_02.Name = "ib_ImOfIn_02"
        Me.ib_ImOfIn_02.Size = New System.Drawing.Size(640, 480)
        Me.ib_ImOfIn_02.TabIndex = 11
        Me.ib_ImOfIn_02.TabStop = False
        '
        'ib_ImOfIn_01
        '
        Me.ib_ImOfIn_01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_ImOfIn_01.Location = New System.Drawing.Point(4, 4)
        Me.ib_ImOfIn_01.Name = "ib_ImOfIn_01"
        Me.ib_ImOfIn_01.Size = New System.Drawing.Size(640, 480)
        Me.ib_ImOfIn_01.TabIndex = 10
        Me.ib_ImOfIn_01.TabStop = False
        '
        'P7_Sub_Laplace
        '
        Me.P7_Sub_Laplace.Controls.Add(Me.ib_laplace_02)
        Me.P7_Sub_Laplace.Controls.Add(Me.ib_laplace_01)
        Me.P7_Sub_Laplace.Location = New System.Drawing.Point(4, 25)
        Me.P7_Sub_Laplace.Name = "P7_Sub_Laplace"
        Me.P7_Sub_Laplace.Size = New System.Drawing.Size(1296, 489)
        Me.P7_Sub_Laplace.TabIndex = 6
        Me.P7_Sub_Laplace.Text = "Sub_LaplaceSharped"
        Me.P7_Sub_Laplace.UseVisualStyleBackColor = True
        '
        'ib_laplace_02
        '
        Me.ib_laplace_02.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_laplace_02.Location = New System.Drawing.Point(653, 4)
        Me.ib_laplace_02.Name = "ib_laplace_02"
        Me.ib_laplace_02.Size = New System.Drawing.Size(640, 480)
        Me.ib_laplace_02.TabIndex = 13
        Me.ib_laplace_02.TabStop = False
        '
        'ib_laplace_01
        '
        Me.ib_laplace_01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_laplace_01.Location = New System.Drawing.Point(4, 4)
        Me.ib_laplace_01.Name = "ib_laplace_01"
        Me.ib_laplace_01.Size = New System.Drawing.Size(640, 480)
        Me.ib_laplace_01.TabIndex = 12
        Me.ib_laplace_01.TabStop = False
        '
        'P8_Sub_DistImg
        '
        Me.P8_Sub_DistImg.Controls.Add(Me.ib_Dist02)
        Me.P8_Sub_DistImg.Controls.Add(Me.ib_Dist01)
        Me.P8_Sub_DistImg.Location = New System.Drawing.Point(4, 25)
        Me.P8_Sub_DistImg.Name = "P8_Sub_DistImg"
        Me.P8_Sub_DistImg.Size = New System.Drawing.Size(1296, 489)
        Me.P8_Sub_DistImg.TabIndex = 9
        Me.P8_Sub_DistImg.Text = "Sub_DistanceImg"
        Me.P8_Sub_DistImg.UseVisualStyleBackColor = True
        '
        'ib_Dist02
        '
        Me.ib_Dist02.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_Dist02.Location = New System.Drawing.Point(653, 4)
        Me.ib_Dist02.Name = "ib_Dist02"
        Me.ib_Dist02.Size = New System.Drawing.Size(640, 480)
        Me.ib_Dist02.TabIndex = 11
        Me.ib_Dist02.TabStop = False
        '
        'ib_Dist01
        '
        Me.ib_Dist01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_Dist01.Location = New System.Drawing.Point(4, 4)
        Me.ib_Dist01.Name = "ib_Dist01"
        Me.ib_Dist01.Size = New System.Drawing.Size(640, 480)
        Me.ib_Dist01.TabIndex = 10
        Me.ib_Dist01.TabStop = False
        '
        'P9_Sub_Mask
        '
        Me.P9_Sub_Mask.Controls.Add(Me.ib_mask_02)
        Me.P9_Sub_Mask.Controls.Add(Me.ib_mask_01)
        Me.P9_Sub_Mask.Location = New System.Drawing.Point(4, 25)
        Me.P9_Sub_Mask.Name = "P9_Sub_Mask"
        Me.P9_Sub_Mask.Size = New System.Drawing.Size(1296, 489)
        Me.P9_Sub_Mask.TabIndex = 7
        Me.P9_Sub_Mask.Text = "Sub_Maske"
        Me.P9_Sub_Mask.UseVisualStyleBackColor = True
        '
        'ib_mask_02
        '
        Me.ib_mask_02.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_mask_02.Location = New System.Drawing.Point(653, 4)
        Me.ib_mask_02.Name = "ib_mask_02"
        Me.ib_mask_02.Size = New System.Drawing.Size(640, 480)
        Me.ib_mask_02.TabIndex = 13
        Me.ib_mask_02.TabStop = False
        '
        'ib_mask_01
        '
        Me.ib_mask_01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_mask_01.Location = New System.Drawing.Point(4, 4)
        Me.ib_mask_01.Name = "ib_mask_01"
        Me.ib_mask_01.Size = New System.Drawing.Size(640, 480)
        Me.ib_mask_01.TabIndex = 12
        Me.ib_mask_01.TabStop = False
        '
        'P10_Sub_Points
        '
        Me.P10_Sub_Points.Controls.Add(Me.ib_points_02)
        Me.P10_Sub_Points.Controls.Add(Me.ib_points_01)
        Me.P10_Sub_Points.Location = New System.Drawing.Point(4, 25)
        Me.P10_Sub_Points.Name = "P10_Sub_Points"
        Me.P10_Sub_Points.Size = New System.Drawing.Size(1296, 489)
        Me.P10_Sub_Points.TabIndex = 8
        Me.P10_Sub_Points.Text = "Sub_Punkte"
        Me.P10_Sub_Points.UseVisualStyleBackColor = True
        '
        'ib_points_02
        '
        Me.ib_points_02.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_points_02.Location = New System.Drawing.Point(653, 4)
        Me.ib_points_02.Name = "ib_points_02"
        Me.ib_points_02.Size = New System.Drawing.Size(640, 480)
        Me.ib_points_02.TabIndex = 13
        Me.ib_points_02.TabStop = False
        '
        'ib_points_01
        '
        Me.ib_points_01.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ib_points_01.Location = New System.Drawing.Point(4, 4)
        Me.ib_points_01.Name = "ib_points_01"
        Me.ib_points_01.Size = New System.Drawing.Size(640, 480)
        Me.ib_points_01.TabIndex = 12
        Me.ib_points_01.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.lb_Info)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 745)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1880, 55)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Info:"
        '
        'lb_Info
        '
        Me.lb_Info.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_Info.FormattingEnabled = True
        Me.lb_Info.ItemHeight = 16
        Me.lb_Info.Location = New System.Drawing.Point(34, 21)
        Me.lb_Info.Name = "lb_Info"
        Me.lb_Info.Size = New System.Drawing.Size(1840, 20)
        Me.lb_Info.TabIndex = 6
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btn_Konf_Col)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.comb_Konf_Col_FPS)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.comb_Konf_Col_Auflösung)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.comb_Konf_Col_Format)
        Me.GroupBox6.Location = New System.Drawing.Point(515, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(315, 147)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Kamera Color"
        '
        'btn_Konf_Col
        '
        Me.btn_Konf_Col.Location = New System.Drawing.Point(9, 108)
        Me.btn_Konf_Col.Name = "btn_Konf_Col"
        Me.btn_Konf_Col.Size = New System.Drawing.Size(289, 34)
        Me.btn_Konf_Col.TabIndex = 11
        Me.btn_Konf_Col.Text = "Übernehmen"
        Me.btn_Konf_Col.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Frames:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'comb_Konf_Col_FPS
        '
        Me.comb_Konf_Col_FPS.FormattingEnabled = True
        Me.comb_Konf_Col_FPS.Items.AddRange(New Object() {"6", "15", "30", "60"})
        Me.comb_Konf_Col_FPS.Location = New System.Drawing.Point(87, 18)
        Me.comb_Konf_Col_FPS.MaxDropDownItems = 4
        Me.comb_Konf_Col_FPS.Name = "comb_Konf_Col_FPS"
        Me.comb_Konf_Col_FPS.Size = New System.Drawing.Size(211, 24)
        Me.comb_Konf_Col_FPS.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Auflösung:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'comb_Konf_Col_Auflösung
        '
        Me.comb_Konf_Col_Auflösung.FormattingEnabled = True
        Me.comb_Konf_Col_Auflösung.Items.AddRange(New Object() {"424x240", "640x360", "640x480", "848x480", "1280x720", "1920x1080"})
        Me.comb_Konf_Col_Auflösung.Location = New System.Drawing.Point(87, 78)
        Me.comb_Konf_Col_Auflösung.MaxDropDownItems = 4
        Me.comb_Konf_Col_Auflösung.Name = "comb_Konf_Col_Auflösung"
        Me.comb_Konf_Col_Auflösung.Size = New System.Drawing.Size(211, 24)
        Me.comb_Konf_Col_Auflösung.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Format:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'comb_Konf_Col_Format
        '
        Me.comb_Konf_Col_Format.FormattingEnabled = True
        Me.comb_Konf_Col_Format.Items.AddRange(New Object() {"YUYV", "BGR8", "RGBA8", "BGRA8", "Y16", "RGB8"})
        Me.comb_Konf_Col_Format.Location = New System.Drawing.Point(87, 48)
        Me.comb_Konf_Col_Format.MaxDropDownItems = 4
        Me.comb_Konf_Col_Format.Name = "comb_Konf_Col_Format"
        Me.comb_Konf_Col_Format.Size = New System.Drawing.Size(211, 24)
        Me.comb_Konf_Col_Format.TabIndex = 1
        '
        'T1_CamRestart
        '
        Me.T1_CamRestart.Enabled = True
        Me.T1_CamRestart.Interval = 200
        '
        'T2_CamBoot
        '
        Me.T2_CamBoot.Enabled = True
        Me.T2_CamBoot.Interval = 3000
        '
        'TC1_Menue
        '
        Me.TC1_Menue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TC1_Menue.Controls.Add(Me.P1_Steuerung)
        Me.TC1_Menue.Controls.Add(Me.P2_Konfig)
        Me.TC1_Menue.Controls.Add(Me.P4_Auswertung)
        Me.TC1_Menue.Controls.Add(Me.P5_Conection)
        Me.TC1_Menue.Controls.Add(Me.P6_test)
        Me.TC1_Menue.Location = New System.Drawing.Point(3, 3)
        Me.TC1_Menue.Name = "TC1_Menue"
        Me.TC1_Menue.SelectedIndex = 0
        Me.TC1_Menue.Size = New System.Drawing.Size(1676, 185)
        Me.TC1_Menue.TabIndex = 20
        '
        'P1_Steuerung
        '
        Me.P1_Steuerung.Controls.Add(Me.GroupBox10)
        Me.P1_Steuerung.Controls.Add(Me.GroupBox9)
        Me.P1_Steuerung.Controls.Add(Me.btn_NewImg)
        Me.P1_Steuerung.Controls.Add(Me.btn_Reset)
        Me.P1_Steuerung.Controls.Add(Me.btn_Analyse)
        Me.P1_Steuerung.Controls.Add(Me.btn_RefImg)
        Me.P1_Steuerung.Location = New System.Drawing.Point(4, 25)
        Me.P1_Steuerung.Name = "P1_Steuerung"
        Me.P1_Steuerung.Padding = New System.Windows.Forms.Padding(3)
        Me.P1_Steuerung.Size = New System.Drawing.Size(1668, 156)
        Me.P1_Steuerung.TabIndex = 0
        Me.P1_Steuerung.Text = "Steuerung"
        Me.P1_Steuerung.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.btn_LoadSearch)
        Me.GroupBox10.Controls.Add(Me.btn_SaveSearch)
        Me.GroupBox10.Controls.Add(Me.Label17)
        Me.GroupBox10.Controls.Add(Me.Num_SearchToleranz)
        Me.GroupBox10.Controls.Add(Me.Label15)
        Me.GroupBox10.Controls.Add(Me.GroupBox14)
        Me.GroupBox10.Controls.Add(Me.GroupBox13)
        Me.GroupBox10.Controls.Add(Me.Label14)
        Me.GroupBox10.Controls.Add(Me.btn_SearchObj)
        Me.GroupBox10.Controls.Add(Me.Label13)
        Me.GroupBox10.Controls.Add(Me.num_SearchObj)
        Me.GroupBox10.Controls.Add(Me.lb_SearchObjList)
        Me.GroupBox10.Location = New System.Drawing.Point(665, 6)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(997, 144)
        Me.GroupBox10.TabIndex = 9
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Objekte"
        '
        'btn_LoadSearch
        '
        Me.btn_LoadSearch.Location = New System.Drawing.Point(527, 111)
        Me.btn_LoadSearch.Name = "btn_LoadSearch"
        Me.btn_LoadSearch.Size = New System.Drawing.Size(114, 23)
        Me.btn_LoadSearch.TabIndex = 13
        Me.btn_LoadSearch.Text = "Laden"
        Me.btn_LoadSearch.UseVisualStyleBackColor = True
        '
        'btn_SaveSearch
        '
        Me.btn_SaveSearch.Location = New System.Drawing.Point(361, 111)
        Me.btn_SaveSearch.Name = "btn_SaveSearch"
        Me.btn_SaveSearch.Size = New System.Drawing.Size(114, 23)
        Me.btn_SaveSearch.TabIndex = 12
        Me.btn_SaveSearch.Text = "Speichern"
        Me.btn_SaveSearch.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(304, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 17)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "%"
        '
        'Num_SearchToleranz
        '
        Me.Num_SearchToleranz.Location = New System.Drawing.Point(240, 104)
        Me.Num_SearchToleranz.Name = "Num_SearchToleranz"
        Me.Num_SearchToleranz.Size = New System.Drawing.Size(58, 22)
        Me.Num_SearchToleranz.TabIndex = 10
        Me.Num_SearchToleranz.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(166, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 17)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Toleranz:"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.btn_AddSearchObj)
        Me.GroupBox14.Controls.Add(Me.tb_searchObjName)
        Me.GroupBox14.Controls.Add(Me.num_newSearchObjT)
        Me.GroupBox14.Controls.Add(Me.num_newSearchObjB)
        Me.GroupBox14.Controls.Add(Me.Label21)
        Me.GroupBox14.Controls.Add(Me.Label19)
        Me.GroupBox14.Controls.Add(Me.num_newSearchObjH)
        Me.GroupBox14.Controls.Add(Me.Label16)
        Me.GroupBox14.Controls.Add(Me.Label18)
        Me.GroupBox14.Controls.Add(Me.Label20)
        Me.GroupBox14.Location = New System.Drawing.Point(647, 7)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(350, 131)
        Me.GroupBox14.TabIndex = 6
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Neues Objekt"
        '
        'btn_AddSearchObj
        '
        Me.btn_AddSearchObj.Location = New System.Drawing.Point(235, 26)
        Me.btn_AddSearchObj.Name = "btn_AddSearchObj"
        Me.btn_AddSearchObj.Size = New System.Drawing.Size(109, 23)
        Me.btn_AddSearchObj.TabIndex = 7
        Me.btn_AddSearchObj.Text = "Anlegen"
        Me.btn_AddSearchObj.UseVisualStyleBackColor = True
        '
        'tb_searchObjName
        '
        Me.tb_searchObjName.Location = New System.Drawing.Point(61, 26)
        Me.tb_searchObjName.Name = "tb_searchObjName"
        Me.tb_searchObjName.Size = New System.Drawing.Size(158, 22)
        Me.tb_searchObjName.TabIndex = 9
        '
        'num_newSearchObjT
        '
        Me.num_newSearchObjT.Location = New System.Drawing.Point(241, 95)
        Me.num_newSearchObjT.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
        Me.num_newSearchObjT.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.num_newSearchObjT.Name = "num_newSearchObjT"
        Me.num_newSearchObjT.Size = New System.Drawing.Size(88, 22)
        Me.num_newSearchObjT.TabIndex = 8
        Me.num_newSearchObjT.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'num_newSearchObjB
        '
        Me.num_newSearchObjB.Location = New System.Drawing.Point(124, 96)
        Me.num_newSearchObjB.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
        Me.num_newSearchObjB.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.num_newSearchObjB.Name = "num_newSearchObjB"
        Me.num_newSearchObjB.Size = New System.Drawing.Size(88, 22)
        Me.num_newSearchObjB.TabIndex = 6
        Me.num_newSearchObjB.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(238, 76)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 17)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Tiefer (mm):"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(121, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 17)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Breite (mm):"
        '
        'num_newSearchObjH
        '
        Me.num_newSearchObjH.Location = New System.Drawing.Point(9, 93)
        Me.num_newSearchObjH.Maximum = New Decimal(New Integer() {1500, 0, 0, 0})
        Me.num_newSearchObjH.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.num_newSearchObjH.Name = "num_newSearchObjH"
        Me.num_newSearchObjH.Size = New System.Drawing.Size(88, 22)
        Me.num_newSearchObjH.TabIndex = 4
        Me.num_newSearchObjH.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 17)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Höhe (mm):"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 17)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Abmase:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 17)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Name:"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.lbl_InfoMaase)
        Me.GroupBox13.Controls.Add(Me.lbl_InfoName)
        Me.GroupBox13.Location = New System.Drawing.Point(166, 7)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(189, 80)
        Me.GroupBox13.TabIndex = 5
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Info"
        '
        'lbl_InfoMaase
        '
        Me.lbl_InfoMaase.AutoSize = True
        Me.lbl_InfoMaase.Location = New System.Drawing.Point(6, 54)
        Me.lbl_InfoMaase.Name = "lbl_InfoMaase"
        Me.lbl_InfoMaase.Size = New System.Drawing.Size(13, 17)
        Me.lbl_InfoMaase.TabIndex = 3
        Me.lbl_InfoMaase.Text = "-"
        '
        'lbl_InfoName
        '
        Me.lbl_InfoName.AutoSize = True
        Me.lbl_InfoName.Location = New System.Drawing.Point(6, 23)
        Me.lbl_InfoName.Name = "lbl_InfoName"
        Me.lbl_InfoName.Size = New System.Drawing.Size(13, 17)
        Me.lbl_InfoName.TabIndex = 1
        Me.lbl_InfoName.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(369, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 17)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Objekte"
        '
        'btn_SearchObj
        '
        Me.btn_SearchObj.Location = New System.Drawing.Point(13, 102)
        Me.btn_SearchObj.Name = "btn_SearchObj"
        Me.btn_SearchObj.Size = New System.Drawing.Size(147, 23)
        Me.btn_SearchObj.TabIndex = 3
        Me.btn_SearchObj.Text = "Suchen"
        Me.btn_SearchObj.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(10, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 42)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "ID des zu suchenden Objekts:"
        '
        'num_SearchObj
        '
        Me.num_SearchObj.Location = New System.Drawing.Point(13, 65)
        Me.num_SearchObj.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_SearchObj.Name = "num_SearchObj"
        Me.num_SearchObj.Size = New System.Drawing.Size(147, 22)
        Me.num_SearchObj.TabIndex = 1
        Me.num_SearchObj.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lb_SearchObjList
        '
        Me.lb_SearchObjList.FormattingEnabled = True
        Me.lb_SearchObjList.ItemHeight = 16
        Me.lb_SearchObjList.Location = New System.Drawing.Point(361, 21)
        Me.lb_SearchObjList.Name = "lb_SearchObjList"
        Me.lb_SearchObjList.ScrollAlwaysVisible = True
        Me.lb_SearchObjList.Size = New System.Drawing.Size(280, 84)
        Me.lb_SearchObjList.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.cb_debug)
        Me.GroupBox9.Controls.Add(Me.cb_DrawPoint)
        Me.GroupBox9.Location = New System.Drawing.Point(474, 6)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(185, 144)
        Me.GroupBox9.TabIndex = 8
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Anzeige"
        '
        'cb_debug
        '
        Me.cb_debug.AutoSize = True
        Me.cb_debug.Checked = True
        Me.cb_debug.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_debug.Location = New System.Drawing.Point(6, 22)
        Me.cb_debug.Name = "cb_debug"
        Me.cb_debug.Size = New System.Drawing.Size(72, 21)
        Me.cb_debug.TabIndex = 6
        Me.cb_debug.Text = "Debug"
        Me.cb_debug.UseVisualStyleBackColor = True
        '
        'cb_DrawPoint
        '
        Me.cb_DrawPoint.AutoSize = True
        Me.cb_DrawPoint.Checked = True
        Me.cb_DrawPoint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_DrawPoint.Location = New System.Drawing.Point(6, 49)
        Me.cb_DrawPoint.Name = "cb_DrawPoint"
        Me.cb_DrawPoint.Size = New System.Drawing.Size(101, 21)
        Me.cb_DrawPoint.TabIndex = 19
        Me.cb_DrawPoint.Text = "DrawPoints"
        Me.cb_DrawPoint.UseVisualStyleBackColor = True
        '
        'btn_NewImg
        '
        Me.btn_NewImg.Enabled = False
        Me.btn_NewImg.Location = New System.Drawing.Point(162, 13)
        Me.btn_NewImg.Name = "btn_NewImg"
        Me.btn_NewImg.Size = New System.Drawing.Size(150, 62)
        Me.btn_NewImg.TabIndex = 1
        Me.btn_NewImg.Text = "Neues Bild"
        Me.btn_NewImg.UseVisualStyleBackColor = True
        '
        'btn_Reset
        '
        Me.btn_Reset.Location = New System.Drawing.Point(318, 13)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(150, 62)
        Me.btn_Reset.TabIndex = 2
        Me.btn_Reset.Text = "Cam Reset"
        Me.btn_Reset.UseVisualStyleBackColor = True
        '
        'btn_Analyse
        '
        Me.btn_Analyse.Location = New System.Drawing.Point(6, 13)
        Me.btn_Analyse.Name = "btn_Analyse"
        Me.btn_Analyse.Size = New System.Drawing.Size(150, 137)
        Me.btn_Analyse.TabIndex = 3
        Me.btn_Analyse.Text = "Bild Auswerten"
        Me.btn_Analyse.UseVisualStyleBackColor = True
        '
        'btn_RefImg
        '
        Me.btn_RefImg.Enabled = False
        Me.btn_RefImg.Location = New System.Drawing.Point(162, 88)
        Me.btn_RefImg.Name = "btn_RefImg"
        Me.btn_RefImg.Size = New System.Drawing.Size(150, 62)
        Me.btn_RefImg.TabIndex = 4
        Me.btn_RefImg.Text = "Referenz Bild"
        Me.btn_RefImg.UseVisualStyleBackColor = True
        '
        'P2_Konfig
        '
        Me.P2_Konfig.Controls.Add(Me.GroupBox19)
        Me.P2_Konfig.Controls.Add(Me.GroupBox15)
        Me.P2_Konfig.Controls.Add(Me.GroupBox12)
        Me.P2_Konfig.Controls.Add(Me.GroupBox4)
        Me.P2_Konfig.Controls.Add(Me.GroupBox6)
        Me.P2_Konfig.Controls.Add(Me.GroupBox7)
        Me.P2_Konfig.Controls.Add(Me.GroupBox2)
        Me.P2_Konfig.Location = New System.Drawing.Point(4, 25)
        Me.P2_Konfig.Name = "P2_Konfig"
        Me.P2_Konfig.Padding = New System.Windows.Forms.Padding(3)
        Me.P2_Konfig.Size = New System.Drawing.Size(1668, 156)
        Me.P2_Konfig.TabIndex = 1
        Me.P2_Konfig.Text = "Konfiguration"
        Me.P2_Konfig.UseVisualStyleBackColor = True
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.Label41)
        Me.GroupBox19.Controls.Add(Me.Label39)
        Me.GroupBox19.Controls.Add(Me.num_RoboOffsety)
        Me.GroupBox19.Controls.Add(Me.num_RoboOffsetX)
        Me.GroupBox19.Location = New System.Drawing.Point(1437, 6)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(193, 147)
        Me.GroupBox19.TabIndex = 14
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "Robo Offsets"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(10, 62)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(21, 17)
        Me.Label41.TabIndex = 3
        Me.Label41.Text = "Y:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(10, 22)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(21, 17)
        Me.Label39.TabIndex = 2
        Me.Label39.Text = "X:"
        '
        'num_RoboOffsety
        '
        Me.num_RoboOffsety.DecimalPlaces = 2
        Me.num_RoboOffsety.Location = New System.Drawing.Point(34, 60)
        Me.num_RoboOffsety.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.num_RoboOffsety.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.num_RoboOffsety.Name = "num_RoboOffsety"
        Me.num_RoboOffsety.Size = New System.Drawing.Size(120, 22)
        Me.num_RoboOffsety.TabIndex = 1
        Me.num_RoboOffsety.Value = New Decimal(New Integer() {105, 0, 0, 131072})
        '
        'num_RoboOffsetX
        '
        Me.num_RoboOffsetX.DecimalPlaces = 2
        Me.num_RoboOffsetX.Location = New System.Drawing.Point(34, 21)
        Me.num_RoboOffsetX.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.num_RoboOffsetX.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.num_RoboOffsetX.Name = "num_RoboOffsetX"
        Me.num_RoboOffsetX.Size = New System.Drawing.Size(120, 22)
        Me.num_RoboOffsetX.TabIndex = 0
        Me.num_RoboOffsetX.Value = New Decimal(New Integer() {95, 0, 0, 131072})
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.Label25)
        Me.GroupBox15.Controls.Add(Me.num_pixmmB_faktor)
        Me.GroupBox15.Controls.Add(Me.Label23)
        Me.GroupBox15.Controls.Add(Me.num_pixmmH_faktor)
        Me.GroupBox15.Location = New System.Drawing.Point(1297, 9)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(134, 147)
        Me.GroupBox15.TabIndex = 14
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Faktor pixel /mm"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(0, 82)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 17)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "Breite"
        '
        'num_pixmmB_faktor
        '
        Me.num_pixmmB_faktor.DecimalPlaces = 5
        Me.num_pixmmB_faktor.Location = New System.Drawing.Point(6, 105)
        Me.num_pixmmB_faktor.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.num_pixmmB_faktor.Name = "num_pixmmB_faktor"
        Me.num_pixmmB_faktor.Size = New System.Drawing.Size(120, 22)
        Me.num_pixmmB_faktor.TabIndex = 2
        Me.num_pixmmB_faktor.Value = New Decimal(New Integer() {137462, 0, 0, 327680})
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(0, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 17)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Höhe"
        '
        'num_pixmmH_faktor
        '
        Me.num_pixmmH_faktor.DecimalPlaces = 5
        Me.num_pixmmH_faktor.Location = New System.Drawing.Point(0, 50)
        Me.num_pixmmH_faktor.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.num_pixmmH_faktor.Name = "num_pixmmH_faktor"
        Me.num_pixmmH_faktor.Size = New System.Drawing.Size(120, 22)
        Me.num_pixmmH_faktor.TabIndex = 0
        Me.num_pixmmH_faktor.Value = New Decimal(New Integer() {137462, 0, 0, 327680})
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.btn_CamOffset_Reset)
        Me.GroupBox12.Controls.Add(Me.num_CamOffset)
        Me.GroupBox12.Location = New System.Drawing.Point(1157, 6)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(134, 147)
        Me.GroupBox12.TabIndex = 13
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Mask Offset"
        '
        'btn_CamOffset_Reset
        '
        Me.btn_CamOffset_Reset.Location = New System.Drawing.Point(6, 53)
        Me.btn_CamOffset_Reset.Name = "btn_CamOffset_Reset"
        Me.btn_CamOffset_Reset.Size = New System.Drawing.Size(120, 34)
        Me.btn_CamOffset_Reset.TabIndex = 12
        Me.btn_CamOffset_Reset.Text = "Reset"
        Me.btn_CamOffset_Reset.UseVisualStyleBackColor = True
        '
        'num_CamOffset
        '
        Me.num_CamOffset.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.num_CamOffset.Location = New System.Drawing.Point(6, 24)
        Me.num_CamOffset.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.num_CamOffset.Minimum = New Decimal(New Integer() {255, 0, 0, -2147483648})
        Me.num_CamOffset.Name = "num_CamOffset"
        Me.num_CamOffset.Size = New System.Drawing.Size(120, 22)
        Me.num_CamOffset.TabIndex = 0
        Me.num_CamOffset.Value = New Decimal(New Integer() {40, 0, 0, -2147483648})
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_Konf_Depth)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.comb_Konf_Dep_FPS)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.comb_Konf_Dep_Auflösung)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.comb_Konf_Dep_Format)
        Me.GroupBox4.Location = New System.Drawing.Point(836, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(315, 147)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Kamera Depth"
        '
        'btn_Konf_Depth
        '
        Me.btn_Konf_Depth.Location = New System.Drawing.Point(9, 108)
        Me.btn_Konf_Depth.Name = "btn_Konf_Depth"
        Me.btn_Konf_Depth.Size = New System.Drawing.Size(289, 34)
        Me.btn_Konf_Depth.TabIndex = 12
        Me.btn_Konf_Depth.Text = "Übernehmen"
        Me.btn_Konf_Depth.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 24)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Frames:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'comb_Konf_Dep_FPS
        '
        Me.comb_Konf_Dep_FPS.FormattingEnabled = True
        Me.comb_Konf_Dep_FPS.Items.AddRange(New Object() {"6", "15", "13", "60", "90"})
        Me.comb_Konf_Dep_FPS.Location = New System.Drawing.Point(87, 18)
        Me.comb_Konf_Dep_FPS.MaxDropDownItems = 4
        Me.comb_Konf_Dep_FPS.Name = "comb_Konf_Dep_FPS"
        Me.comb_Konf_Dep_FPS.Size = New System.Drawing.Size(211, 24)
        Me.comb_Konf_Dep_FPS.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(6, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 24)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Auflösung:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'comb_Konf_Dep_Auflösung
        '
        Me.comb_Konf_Dep_Auflösung.FormattingEnabled = True
        Me.comb_Konf_Dep_Auflösung.Items.AddRange(New Object() {"424x240", "640x360", "640x480", "848x480", "1280x720"})
        Me.comb_Konf_Dep_Auflösung.Location = New System.Drawing.Point(87, 78)
        Me.comb_Konf_Dep_Auflösung.MaxDropDownItems = 4
        Me.comb_Konf_Dep_Auflösung.Name = "comb_Konf_Dep_Auflösung"
        Me.comb_Konf_Dep_Auflösung.Size = New System.Drawing.Size(211, 24)
        Me.comb_Konf_Dep_Auflösung.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 24)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Format:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'comb_Konf_Dep_Format
        '
        Me.comb_Konf_Dep_Format.FormattingEnabled = True
        Me.comb_Konf_Dep_Format.Items.AddRange(New Object() {"Z16"})
        Me.comb_Konf_Dep_Format.Location = New System.Drawing.Point(87, 48)
        Me.comb_Konf_Dep_Format.MaxDropDownItems = 4
        Me.comb_Konf_Dep_Format.Name = "comb_Konf_Dep_Format"
        Me.comb_Konf_Dep_Format.Size = New System.Drawing.Size(211, 24)
        Me.comb_Konf_Dep_Format.TabIndex = 1
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cb_Tiefe_aktMaske)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.lbl_pointMax)
        Me.GroupBox7.Controls.Add(Me.lbl_pointMin)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.btn_tiefe)
        Me.GroupBox7.Location = New System.Drawing.Point(226, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(283, 147)
        Me.GroupBox7.TabIndex = 20
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Tiefen Analyse"
        '
        'cb_Tiefe_aktMaske
        '
        Me.cb_Tiefe_aktMaske.AutoSize = True
        Me.cb_Tiefe_aktMaske.Checked = True
        Me.cb_Tiefe_aktMaske.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_Tiefe_aktMaske.Location = New System.Drawing.Point(184, 38)
        Me.cb_Tiefe_aktMaske.Name = "cb_Tiefe_aktMaske"
        Me.cb_Tiefe_aktMaske.Size = New System.Drawing.Size(93, 21)
        Me.cb_Tiefe_aktMaske.TabIndex = 11
        Me.cb_Tiefe_aktMaske.Text = "Mit Maske"
        Me.cb_Tiefe_aktMaske.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tiefste:"
        '
        'lbl_pointMax
        '
        Me.lbl_pointMax.AutoSize = True
        Me.lbl_pointMax.Location = New System.Drawing.Point(67, 114)
        Me.lbl_pointMax.Name = "lbl_pointMax"
        Me.lbl_pointMax.Size = New System.Drawing.Size(13, 17)
        Me.lbl_pointMax.TabIndex = 10
        Me.lbl_pointMax.Text = "-"
        '
        'lbl_pointMin
        '
        Me.lbl_pointMin.AutoSize = True
        Me.lbl_pointMin.Location = New System.Drawing.Point(67, 88)
        Me.lbl_pointMin.Name = "lbl_pointMin"
        Me.lbl_pointMin.Size = New System.Drawing.Size(13, 17)
        Me.lbl_pointMin.TabIndex = 9
        Me.lbl_pointMin.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Höchste:"
        '
        'btn_tiefe
        '
        Me.btn_tiefe.Location = New System.Drawing.Point(6, 24)
        Me.btn_tiefe.Name = "btn_tiefe"
        Me.btn_tiefe.Size = New System.Drawing.Size(150, 46)
        Me.btn_tiefe.TabIndex = 6
        Me.btn_tiefe.Text = "Tiefen Analyse"
        Me.btn_tiefe.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_pos)
        Me.GroupBox2.Controls.Add(Me.num_MaskH)
        Me.GroupBox2.Controls.Add(Me.num_MaskV)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 147)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Maskierung"
        '
        'btn_pos
        '
        Me.btn_pos.Location = New System.Drawing.Point(6, 24)
        Me.btn_pos.Name = "btn_pos"
        Me.btn_pos.Size = New System.Drawing.Size(150, 46)
        Me.btn_pos.TabIndex = 5
        Me.btn_pos.Text = "Positionieren"
        Me.btn_pos.UseVisualStyleBackColor = True
        '
        'num_MaskH
        '
        Me.num_MaskH.Location = New System.Drawing.Point(77, 87)
        Me.num_MaskH.Maximum = New Decimal(New Integer() {1280, 0, 0, 0})
        Me.num_MaskH.Name = "num_MaskH"
        Me.num_MaskH.Size = New System.Drawing.Size(120, 22)
        Me.num_MaskH.TabIndex = 17
        Me.num_MaskH.Value = New Decimal(New Integer() {120, 0, 0, 0})
        '
        'num_MaskV
        '
        Me.num_MaskV.Location = New System.Drawing.Point(77, 115)
        Me.num_MaskV.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.num_MaskV.Name = "num_MaskV"
        Me.num_MaskV.Size = New System.Drawing.Size(120, 22)
        Me.num_MaskV.TabIndex = 18
        Me.num_MaskV.Value = New Decimal(New Integer() {250, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Maske H"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Maske V"
        '
        'P4_Auswertung
        '
        Me.P4_Auswertung.Controls.Add(Me.GroupBox11)
        Me.P4_Auswertung.Controls.Add(Me.GroupBox18)
        Me.P4_Auswertung.Controls.Add(Me.GroupBox5)
        Me.P4_Auswertung.Location = New System.Drawing.Point(4, 25)
        Me.P4_Auswertung.Name = "P4_Auswertung"
        Me.P4_Auswertung.Size = New System.Drawing.Size(1668, 156)
        Me.P4_Auswertung.TabIndex = 2
        Me.P4_Auswertung.Text = "Auswertung"
        Me.P4_Auswertung.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.cb_Watershed_Filter)
        Me.GroupBox11.Controls.Add(Me.Label37)
        Me.GroupBox11.Controls.Add(Me.num_WTS_MinT)
        Me.GroupBox11.Controls.Add(Me.Label38)
        Me.GroupBox11.Controls.Add(Me.Label33)
        Me.GroupBox11.Controls.Add(Me.num_WTS_MinB)
        Me.GroupBox11.Controls.Add(Me.Label36)
        Me.GroupBox11.Controls.Add(Me.Label32)
        Me.GroupBox11.Controls.Add(Me.num_WTS_MinH)
        Me.GroupBox11.Controls.Add(Me.Label31)
        Me.GroupBox11.Location = New System.Drawing.Point(595, 10)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(221, 150)
        Me.GroupBox11.TabIndex = 25
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Mindest Objektgröße"
        '
        'cb_Watershed_Filter
        '
        Me.cb_Watershed_Filter.AccessibleDescription = "Ausfiltern von zu Tiefen oder Zu hohen  Regionen (gut führ Tiefenauswertung)"
        Me.cb_Watershed_Filter.AutoSize = True
        Me.cb_Watershed_Filter.Checked = True
        Me.cb_Watershed_Filter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_Watershed_Filter.Location = New System.Drawing.Point(58, 116)
        Me.cb_Watershed_Filter.Name = "cb_Watershed_Filter"
        Me.cb_Watershed_Filter.Size = New System.Drawing.Size(69, 21)
        Me.cb_Watershed_Filter.TabIndex = 24
        Me.cb_Watershed_Filter.Text = "Filtern"
        Me.cb_Watershed_Filter.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(184, 90)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(30, 17)
        Me.Label37.TabIndex = 32
        Me.Label37.Text = "mm"
        '
        'num_WTS_MinT
        '
        Me.num_WTS_MinT.Location = New System.Drawing.Point(58, 88)
        Me.num_WTS_MinT.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.num_WTS_MinT.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.num_WTS_MinT.Name = "num_WTS_MinT"
        Me.num_WTS_MinT.Size = New System.Drawing.Size(120, 22)
        Me.num_WTS_MinT.TabIndex = 30
        Me.num_WTS_MinT.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(6, 90)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(44, 17)
        Me.Label38.TabIndex = 31
        Me.Label38.Text = "Tiefe:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(184, 62)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(30, 17)
        Me.Label33.TabIndex = 29
        Me.Label33.Text = "mm"
        '
        'num_WTS_MinB
        '
        Me.num_WTS_MinB.Location = New System.Drawing.Point(58, 60)
        Me.num_WTS_MinB.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.num_WTS_MinB.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.num_WTS_MinB.Name = "num_WTS_MinB"
        Me.num_WTS_MinB.Size = New System.Drawing.Size(120, 22)
        Me.num_WTS_MinB.TabIndex = 27
        Me.num_WTS_MinB.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(6, 62)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(49, 17)
        Me.Label36.TabIndex = 28
        Me.Label36.Text = "Breite:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(184, 34)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(30, 17)
        Me.Label32.TabIndex = 26
        Me.Label32.Text = "mm"
        '
        'num_WTS_MinH
        '
        Me.num_WTS_MinH.Location = New System.Drawing.Point(58, 32)
        Me.num_WTS_MinH.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.num_WTS_MinH.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.num_WTS_MinH.Name = "num_WTS_MinH"
        Me.num_WTS_MinH.Size = New System.Drawing.Size(120, 22)
        Me.num_WTS_MinH.TabIndex = 24
        Me.num_WTS_MinH.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 34)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(46, 17)
        Me.Label31.TabIndex = 25
        Me.Label31.Text = "Höhe:"
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.rb_Auswertung_Color)
        Me.GroupBox18.Controls.Add(Me.rb_Auswertung_Kombi)
        Me.GroupBox18.Controls.Add(Me.rb_Auswertung_Depth)
        Me.GroupBox18.Location = New System.Drawing.Point(5, 10)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(165, 150)
        Me.GroupBox18.TabIndex = 24
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Auswertung"
        '
        'rb_Auswertung_Color
        '
        Me.rb_Auswertung_Color.AutoSize = True
        Me.rb_Auswertung_Color.Location = New System.Drawing.Point(6, 28)
        Me.rb_Auswertung_Color.Name = "rb_Auswertung_Color"
        Me.rb_Auswertung_Color.Size = New System.Drawing.Size(136, 21)
        Me.rb_Auswertung_Color.TabIndex = 21
        Me.rb_Auswertung_Color.Text = "Farb Auswertung"
        Me.rb_Auswertung_Color.UseVisualStyleBackColor = True
        '
        'rb_Auswertung_Kombi
        '
        Me.rb_Auswertung_Kombi.AutoSize = True
        Me.rb_Auswertung_Kombi.Location = New System.Drawing.Point(6, 82)
        Me.rb_Auswertung_Kombi.Name = "rb_Auswertung_Kombi"
        Me.rb_Auswertung_Kombi.Size = New System.Drawing.Size(146, 21)
        Me.rb_Auswertung_Kombi.TabIndex = 23
        Me.rb_Auswertung_Kombi.Text = "Kombi Auswertung"
        Me.rb_Auswertung_Kombi.UseVisualStyleBackColor = True
        '
        'rb_Auswertung_Depth
        '
        Me.rb_Auswertung_Depth.AutoSize = True
        Me.rb_Auswertung_Depth.Checked = True
        Me.rb_Auswertung_Depth.Location = New System.Drawing.Point(6, 55)
        Me.rb_Auswertung_Depth.Name = "rb_Auswertung_Depth"
        Me.rb_Auswertung_Depth.Size = New System.Drawing.Size(147, 21)
        Me.rb_Auswertung_Depth.TabIndex = 22
        Me.rb_Auswertung_Depth.TabStop = True
        Me.rb_Auswertung_Depth.Text = "Tiefen Auswertung"
        Me.rb_Auswertung_Depth.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cb_ioi_Gaus)
        Me.GroupBox5.Controls.Add(Me.cb_ioi_Mask)
        Me.GroupBox5.Controls.Add(Me.cb_ioi_Differenz)
        Me.GroupBox5.Controls.Add(Me.cb_ioi_Depth)
        Me.GroupBox5.Controls.Add(Me.num_ThreshTief)
        Me.GroupBox5.Controls.Add(Me.num_ThreshHoch)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(176, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(413, 150)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ImgOfInterest"
        '
        'cb_ioi_Gaus
        '
        Me.cb_ioi_Gaus.AccessibleDescription = "Bild wird mittels GaussianBlur optimiert (entfernen von Löschern)"
        Me.cb_ioi_Gaus.AutoSize = True
        Me.cb_ioi_Gaus.Checked = True
        Me.cb_ioi_Gaus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_ioi_Gaus.Location = New System.Drawing.Point(6, 108)
        Me.cb_ioi_Gaus.Name = "cb_ioi_Gaus"
        Me.cb_ioi_Gaus.Size = New System.Drawing.Size(106, 21)
        Me.cb_ioi_Gaus.TabIndex = 23
        Me.cb_ioi_Gaus.Text = "Bereinigung"
        Me.cb_ioi_Gaus.UseVisualStyleBackColor = True
        '
        'cb_ioi_Mask
        '
        Me.cb_ioi_Mask.AccessibleDescription = "Einstellungen Siehe Konfiguratons Tab -> Positionierung"
        Me.cb_ioi_Mask.AutoSize = True
        Me.cb_ioi_Mask.Checked = True
        Me.cb_ioi_Mask.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_ioi_Mask.Location = New System.Drawing.Point(6, 81)
        Me.cb_ioi_Mask.Name = "cb_ioi_Mask"
        Me.cb_ioi_Mask.Size = New System.Drawing.Size(103, 21)
        Me.cb_ioi_Mask.TabIndex = 22
        Me.cb_ioi_Mask.Text = "Maskierung"
        Me.cb_ioi_Mask.UseVisualStyleBackColor = True
        '
        'cb_ioi_Differenz
        '
        Me.cb_ioi_Differenz.AccessibleDescription = "Differenz zu Referenzbild (gut führ Farbauswertung) "
        Me.cb_ioi_Differenz.AutoSize = True
        Me.cb_ioi_Differenz.Location = New System.Drawing.Point(6, 27)
        Me.cb_ioi_Differenz.Name = "cb_ioi_Differenz"
        Me.cb_ioi_Differenz.Size = New System.Drawing.Size(160, 21)
        Me.cb_ioi_Differenz.TabIndex = 20
        Me.cb_ioi_Differenz.Text = "Differenz Erkennung"
        Me.cb_ioi_Differenz.UseVisualStyleBackColor = True
        '
        'cb_ioi_Depth
        '
        Me.cb_ioi_Depth.AccessibleDescription = "Ausfiltern von zu Tiefen oder Zu hohen  Regionen (gut führ Tiefenauswertung)"
        Me.cb_ioi_Depth.AutoSize = True
        Me.cb_ioi_Depth.Checked = True
        Me.cb_ioi_Depth.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_ioi_Depth.Location = New System.Drawing.Point(6, 54)
        Me.cb_ioi_Depth.Name = "cb_ioi_Depth"
        Me.cb_ioi_Depth.Size = New System.Drawing.Size(133, 21)
        Me.cb_ioi_Depth.TabIndex = 21
        Me.cb_ioi_Depth.Text = "Tiefen Filderung"
        Me.cb_ioi_Depth.UseVisualStyleBackColor = True
        '
        'num_ThreshTief
        '
        Me.num_ThreshTief.Location = New System.Drawing.Point(287, 27)
        Me.num_ThreshTief.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.num_ThreshTief.Name = "num_ThreshTief"
        Me.num_ThreshTief.Size = New System.Drawing.Size(120, 22)
        Me.num_ThreshTief.TabIndex = 11
        Me.num_ThreshTief.Value = New Decimal(New Integer() {685, 0, 0, 0})
        '
        'num_ThreshHoch
        '
        Me.num_ThreshHoch.Location = New System.Drawing.Point(287, 55)
        Me.num_ThreshHoch.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.num_ThreshHoch.Name = "num_ThreshHoch"
        Me.num_ThreshHoch.Size = New System.Drawing.Size(120, 22)
        Me.num_ThreshHoch.TabIndex = 12
        Me.num_ThreshHoch.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(172, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "tiefste Region:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(172, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "höchste Region:"
        '
        'P5_Conection
        '
        Me.P5_Conection.Controls.Add(Me.GroupBox17)
        Me.P5_Conection.Controls.Add(Me.GroupBox16)
        Me.P5_Conection.Location = New System.Drawing.Point(4, 25)
        Me.P5_Conection.Name = "P5_Conection"
        Me.P5_Conection.Size = New System.Drawing.Size(1668, 156)
        Me.P5_Conection.TabIndex = 3
        Me.P5_Conection.Text = "TCP Variablen"
        Me.P5_Conection.UseVisualStyleBackColor = True
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.dgv_TCPVariableViewer)
        Me.GroupBox17.Controls.Add(Me.btn_TCPVariable_Del)
        Me.GroupBox17.Controls.Add(Me.btn_TCPVariable_Set)
        Me.GroupBox17.Controls.Add(Me.btn_TCPVariable_New)
        Me.GroupBox17.Controls.Add(Me.num_TCPVariable_Wert)
        Me.GroupBox17.Controls.Add(Me.tb_TCPVarible_Name)
        Me.GroupBox17.Controls.Add(Me.Label34)
        Me.GroupBox17.Controls.Add(Me.Label35)
        Me.GroupBox17.Location = New System.Drawing.Point(359, 3)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(615, 150)
        Me.GroupBox17.TabIndex = 8
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Variablen"
        '
        'dgv_TCPVariableViewer
        '
        Me.dgv_TCPVariableViewer.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_TCPVariableViewer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_TCPVariableViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_TCPVariableViewer.Location = New System.Drawing.Point(350, 10)
        Me.dgv_TCPVariableViewer.Name = "dgv_TCPVariableViewer"
        Me.dgv_TCPVariableViewer.RowTemplate.Height = 24
        Me.dgv_TCPVariableViewer.Size = New System.Drawing.Size(250, 140)
        Me.dgv_TCPVariableViewer.TabIndex = 9
        '
        'btn_TCPVariable_Del
        '
        Me.btn_TCPVariable_Del.Location = New System.Drawing.Point(242, 114)
        Me.btn_TCPVariable_Del.Name = "btn_TCPVariable_Del"
        Me.btn_TCPVariable_Del.Size = New System.Drawing.Size(92, 30)
        Me.btn_TCPVariable_Del.TabIndex = 7
        Me.btn_TCPVariable_Del.Text = "Löschen"
        Me.btn_TCPVariable_Del.UseVisualStyleBackColor = True
        '
        'btn_TCPVariable_Set
        '
        Me.btn_TCPVariable_Set.Location = New System.Drawing.Point(107, 114)
        Me.btn_TCPVariable_Set.Name = "btn_TCPVariable_Set"
        Me.btn_TCPVariable_Set.Size = New System.Drawing.Size(116, 30)
        Me.btn_TCPVariable_Set.TabIndex = 6
        Me.btn_TCPVariable_Set.Text = "Wert zuweisen"
        Me.btn_TCPVariable_Set.UseVisualStyleBackColor = True
        '
        'btn_TCPVariable_New
        '
        Me.btn_TCPVariable_New.Location = New System.Drawing.Point(9, 114)
        Me.btn_TCPVariable_New.Name = "btn_TCPVariable_New"
        Me.btn_TCPVariable_New.Size = New System.Drawing.Size(92, 30)
        Me.btn_TCPVariable_New.TabIndex = 5
        Me.btn_TCPVariable_New.Text = "Anlegen"
        Me.btn_TCPVariable_New.UseVisualStyleBackColor = True
        '
        'num_TCPVariable_Wert
        '
        Me.num_TCPVariable_Wert.Location = New System.Drawing.Point(53, 68)
        Me.num_TCPVariable_Wert.Name = "num_TCPVariable_Wert"
        Me.num_TCPVariable_Wert.Size = New System.Drawing.Size(116, 22)
        Me.num_TCPVariable_Wert.TabIndex = 4
        '
        'tb_TCPVarible_Name
        '
        Me.tb_TCPVarible_Name.Location = New System.Drawing.Point(53, 31)
        Me.tb_TCPVarible_Name.Name = "tb_TCPVarible_Name"
        Me.tb_TCPVarible_Name.Size = New System.Drawing.Size(271, 22)
        Me.tb_TCPVarible_Name.TabIndex = 3
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(6, 68)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(42, 17)
        Me.Label34.TabIndex = 2
        Me.Label34.Text = "Wert:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(6, 34)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(49, 17)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "Name:"
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.lbl_TCP_Status)
        Me.GroupBox16.Controls.Add(Me.Label30)
        Me.GroupBox16.Controls.Add(Me.btn_TCP_Connect)
        Me.GroupBox16.Controls.Add(Me.num_TCP_Port)
        Me.GroupBox16.Controls.Add(Me.tb_TCP_HOST)
        Me.GroupBox16.Controls.Add(Me.Label29)
        Me.GroupBox16.Controls.Add(Me.Label27)
        Me.GroupBox16.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(350, 150)
        Me.GroupBox16.TabIndex = 1
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Verbindung"
        '
        'lbl_TCP_Status
        '
        Me.lbl_TCP_Status.AutoSize = True
        Me.lbl_TCP_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TCP_Status.Location = New System.Drawing.Point(238, 114)
        Me.lbl_TCP_Status.Name = "lbl_TCP_Status"
        Me.lbl_TCP_Status.Size = New System.Drawing.Size(19, 25)
        Me.lbl_TCP_Status.TabIndex = 7
        Me.lbl_TCP_Status.Text = "-"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(176, 121)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 17)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "Status: "
        '
        'btn_TCP_Connect
        '
        Me.btn_TCP_Connect.Location = New System.Drawing.Point(9, 114)
        Me.btn_TCP_Connect.Name = "btn_TCP_Connect"
        Me.btn_TCP_Connect.Size = New System.Drawing.Size(161, 30)
        Me.btn_TCP_Connect.TabIndex = 5
        Me.btn_TCP_Connect.Text = "Verbinden"
        Me.btn_TCP_Connect.UseVisualStyleBackColor = True
        '
        'num_TCP_Port
        '
        Me.num_TCP_Port.Location = New System.Drawing.Point(53, 60)
        Me.num_TCP_Port.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.num_TCP_Port.Name = "num_TCP_Port"
        Me.num_TCP_Port.Size = New System.Drawing.Size(116, 22)
        Me.num_TCP_Port.TabIndex = 4
        Me.num_TCP_Port.Value = New Decimal(New Integer() {2019, 0, 0, 0})
        '
        'tb_TCP_HOST
        '
        Me.tb_TCP_HOST.Location = New System.Drawing.Point(53, 34)
        Me.tb_TCP_HOST.Name = "tb_TCP_HOST"
        Me.tb_TCP_HOST.Size = New System.Drawing.Size(271, 22)
        Me.tb_TCP_HOST.TabIndex = 3
        Me.tb_TCP_HOST.Text = "192.168.43.14"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 65)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(38, 17)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Port:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 37)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(41, 17)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Host:"
        '
        'P6_test
        '
        Me.P6_test.Controls.Add(Me.Button1)
        Me.P6_test.Controls.Add(Me.btn_TestVerschieben)
        Me.P6_test.Location = New System.Drawing.Point(4, 25)
        Me.P6_test.Name = "P6_test"
        Me.P6_test.Size = New System.Drawing.Size(1668, 156)
        Me.P6_test.TabIndex = 4
        Me.P6_test.Text = "Test"
        Me.P6_test.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(195, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "TestAuwertung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_TestVerschieben
        '
        Me.btn_TestVerschieben.Location = New System.Drawing.Point(47, 40)
        Me.btn_TestVerschieben.Name = "btn_TestVerschieben"
        Me.btn_TestVerschieben.Size = New System.Drawing.Size(75, 23)
        Me.btn_TestVerschieben.TabIndex = 0
        Me.btn_TestVerschieben.Text = "TestVeschieben"
        Me.btn_TestVerschieben.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.cb_refdcTaken)
        Me.GroupBox8.Controls.Add(Me.cb_colortaken)
        Me.GroupBox8.Controls.Add(Me.cb_depthcTaken)
        Me.GroupBox8.Controls.Add(Me.cb_refdTaken)
        Me.GroupBox8.Controls.Add(Me.cb_depthtaken)
        Me.GroupBox8.Controls.Add(Me.cb_refcTaken)
        Me.GroupBox8.Location = New System.Drawing.Point(1679, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(214, 185)
        Me.GroupBox8.TabIndex = 22
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Aufnahmen"
        '
        'cb_refdcTaken
        '
        Me.cb_refdcTaken.AutoSize = True
        Me.cb_refdcTaken.Location = New System.Drawing.Point(128, 92)
        Me.cb_refdcTaken.Name = "cb_refdcTaken"
        Me.cb_refdcTaken.Size = New System.Drawing.Size(77, 21)
        Me.cb_refdcTaken.TabIndex = 12
        Me.cb_refdcTaken.Text = "Ref_Dc"
        Me.cb_refdcTaken.UseVisualStyleBackColor = True
        '
        'cb_colortaken
        '
        Me.cb_colortaken.AutoSize = True
        Me.cb_colortaken.Location = New System.Drawing.Point(6, 38)
        Me.cb_colortaken.Name = "cb_colortaken"
        Me.cb_colortaken.Size = New System.Drawing.Size(63, 21)
        Me.cb_colortaken.TabIndex = 7
        Me.cb_colortaken.Text = "Color"
        Me.cb_colortaken.UseVisualStyleBackColor = True
        '
        'cb_depthcTaken
        '
        Me.cb_depthcTaken.AutoSize = True
        Me.cb_depthcTaken.Location = New System.Drawing.Point(6, 92)
        Me.cb_depthcTaken.Name = "cb_depthcTaken"
        Me.cb_depthcTaken.Size = New System.Drawing.Size(77, 21)
        Me.cb_depthcTaken.TabIndex = 9
        Me.cb_depthcTaken.Text = "DepthC"
        Me.cb_depthcTaken.UseVisualStyleBackColor = True
        '
        'cb_refdTaken
        '
        Me.cb_refdTaken.AutoSize = True
        Me.cb_refdTaken.Location = New System.Drawing.Point(128, 65)
        Me.cb_refdTaken.Name = "cb_refdTaken"
        Me.cb_refdTaken.Size = New System.Drawing.Size(70, 21)
        Me.cb_refdTaken.TabIndex = 11
        Me.cb_refdTaken.Text = "Ref_D"
        Me.cb_refdTaken.UseVisualStyleBackColor = True
        '
        'cb_depthtaken
        '
        Me.cb_depthtaken.AutoSize = True
        Me.cb_depthtaken.Location = New System.Drawing.Point(6, 65)
        Me.cb_depthtaken.Name = "cb_depthtaken"
        Me.cb_depthtaken.Size = New System.Drawing.Size(68, 21)
        Me.cb_depthtaken.TabIndex = 8
        Me.cb_depthtaken.Text = "Depth"
        Me.cb_depthtaken.UseVisualStyleBackColor = True
        '
        'cb_refcTaken
        '
        Me.cb_refcTaken.AutoSize = True
        Me.cb_refcTaken.Cursor = System.Windows.Forms.Cursors.Default
        Me.cb_refcTaken.Location = New System.Drawing.Point(128, 38)
        Me.cb_refcTaken.Name = "cb_refcTaken"
        Me.cb_refcTaken.Size = New System.Drawing.Size(69, 21)
        Me.cb_refcTaken.TabIndex = 10
        Me.cb_refcTaken.Text = "Ref_C"
        Me.cb_refcTaken.UseVisualStyleBackColor = True
        '
        'TC3_ObjLists
        '
        Me.TC3_ObjLists.Controls.Add(Me.P1_All)
        Me.TC3_ObjLists.Controls.Add(Me.P2_Found)
        Me.TC3_ObjLists.Location = New System.Drawing.Point(1345, 194)
        Me.TC3_ObjLists.Name = "TC3_ObjLists"
        Me.TC3_ObjLists.SelectedIndex = 0
        Me.TC3_ObjLists.Size = New System.Drawing.Size(548, 545)
        Me.TC3_ObjLists.TabIndex = 23
        '
        'P1_All
        '
        Me.P1_All.Controls.Add(Me.LB_obj)
        Me.P1_All.Location = New System.Drawing.Point(4, 25)
        Me.P1_All.Name = "P1_All"
        Me.P1_All.Padding = New System.Windows.Forms.Padding(3)
        Me.P1_All.Size = New System.Drawing.Size(540, 516)
        Me.P1_All.TabIndex = 0
        Me.P1_All.Text = "Alle Objekte"
        Me.P1_All.UseVisualStyleBackColor = True
        '
        'LB_obj
        '
        Me.LB_obj.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_obj.FormattingEnabled = True
        Me.LB_obj.HorizontalScrollbar = True
        Me.LB_obj.ItemHeight = 16
        Me.LB_obj.Location = New System.Drawing.Point(3, 3)
        Me.LB_obj.Name = "LB_obj"
        Me.LB_obj.Size = New System.Drawing.Size(534, 516)
        Me.LB_obj.TabIndex = 7
        '
        'P2_Found
        '
        Me.P2_Found.Controls.Add(Me.lb_Found)
        Me.P2_Found.Location = New System.Drawing.Point(4, 25)
        Me.P2_Found.Name = "P2_Found"
        Me.P2_Found.Padding = New System.Windows.Forms.Padding(3)
        Me.P2_Found.Size = New System.Drawing.Size(540, 516)
        Me.P2_Found.TabIndex = 1
        Me.P2_Found.Text = "Passende Objekte"
        Me.P2_Found.UseVisualStyleBackColor = True
        '
        'lb_Found
        '
        Me.lb_Found.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_Found.FormattingEnabled = True
        Me.lb_Found.HorizontalScrollbar = True
        Me.lb_Found.ItemHeight = 16
        Me.lb_Found.Location = New System.Drawing.Point(3, 0)
        Me.lb_Found.Name = "lb_Found"
        Me.lb_Found.Size = New System.Drawing.Size(534, 516)
        Me.lb_Found.TabIndex = 8
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 803)
        Me.Controls.Add(Me.TC3_ObjLists)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.TC1_Menue)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Main"
        Me.Text = "Bildauswertung"
        Me.GroupBox1.ResumeLayout(False)
        Me.TC2_Bilder.ResumeLayout(False)
        Me.P1_NewImg.ResumeLayout(False)
        CType(Me.ib_new_Depth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ib_new_Color, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P2_Result.ResumeLayout(False)
        CType(Me.ib_res_02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ib_res_01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P3_Rev.ResumeLayout(False)
        CType(Me.ib_rev_Depth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ib_rev_Color, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P5_ResultSearchObj.ResumeLayout(False)
        Me.P5_ResultSearchObj.PerformLayout()
        CType(Me.ib_Found, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P4_DepthZ16.ResumeLayout(False)
        CType(Me.ib_depth_01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P6_Sub_IOI.ResumeLayout(False)
        CType(Me.ib_ImOfIn_02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ib_ImOfIn_01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P7_Sub_Laplace.ResumeLayout(False)
        CType(Me.ib_laplace_02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ib_laplace_01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P8_Sub_DistImg.ResumeLayout(False)
        CType(Me.ib_Dist02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ib_Dist01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P9_Sub_Mask.ResumeLayout(False)
        CType(Me.ib_mask_02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ib_mask_01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P10_Sub_Points.ResumeLayout(False)
        CType(Me.ib_points_02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ib_points_01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TC1_Menue.ResumeLayout(False)
        Me.P1_Steuerung.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.Num_SearchToleranz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        CType(Me.num_newSearchObjT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_newSearchObjB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_newSearchObjH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        CType(Me.num_SearchObj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.P2_Konfig.ResumeLayout(False)
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        CType(Me.num_RoboOffsety, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_RoboOffsetX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        CType(Me.num_pixmmB_faktor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_pixmmH_faktor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.num_CamOffset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.num_MaskH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_MaskV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P4_Auswertung.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.num_WTS_MinT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_WTS_MinB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_WTS_MinH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.num_ThreshTief, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_ThreshHoch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P5_Conection.ResumeLayout(False)
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        CType(Me.dgv_TCPVariableViewer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_TCPVariable_Wert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        CType(Me.num_TCP_Port, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P6_test.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.TC3_ObjLists.ResumeLayout(False)
        Me.P1_All.ResumeLayout(False)
        Me.P2_Found.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents comb_Konf_Col_FPS As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents comb_Konf_Col_Auflösung As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comb_Konf_Col_Format As ComboBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents lb_Info As ListBox
    Friend WithEvents T1_CamRestart As Timer
    Friend WithEvents T2_CamBoot As Timer
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_pointMax As Label
    Friend WithEvents lbl_pointMin As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_tiefe As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_pos As Button
    Friend WithEvents num_MaskH As NumericUpDown
    Friend WithEvents num_MaskV As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TC1_Menue As TabControl
    Friend WithEvents P1_Steuerung As TabPage
    Friend WithEvents cb_DrawPoint As CheckBox
    Friend WithEvents btn_NewImg As Button
    Friend WithEvents btn_Reset As Button
    Friend WithEvents btn_Analyse As Button
    Friend WithEvents btn_RefImg As Button
    Friend WithEvents cb_debug As CheckBox
    Friend WithEvents P2_Konfig As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents comb_Konf_Dep_FPS As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents comb_Konf_Dep_Auflösung As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents comb_Konf_Dep_Format As ComboBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents TC2_Bilder As TabControl
    Friend WithEvents P1_NewImg As TabPage
    Friend WithEvents P2_Result As TabPage
    Friend WithEvents ib_new_Depth As Emgu.CV.UI.ImageBox
    Friend WithEvents ib_new_Color As Emgu.CV.UI.ImageBox
    Friend WithEvents P3_Rev As TabPage
    Friend WithEvents ib_res_02 As Emgu.CV.UI.ImageBox
    Friend WithEvents ib_res_01 As Emgu.CV.UI.ImageBox
    Friend WithEvents ib_rev_Depth As Emgu.CV.UI.ImageBox
    Friend WithEvents ib_rev_Color As Emgu.CV.UI.ImageBox
    Friend WithEvents P4_DepthZ16 As TabPage
    Friend WithEvents ib_depth_01 As Emgu.CV.UI.ImageBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents cb_refdcTaken As CheckBox
    Friend WithEvents cb_colortaken As CheckBox
    Friend WithEvents cb_depthcTaken As CheckBox
    Friend WithEvents cb_refdTaken As CheckBox
    Friend WithEvents cb_depthtaken As CheckBox
    Friend WithEvents cb_refcTaken As CheckBox
    Friend WithEvents btn_Konf_Col As Button
    Friend WithEvents btn_Konf_Depth As Button
    Friend WithEvents cb_Tiefe_aktMaske As CheckBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents num_CamOffset As NumericUpDown
    Friend WithEvents btn_CamOffset_Reset As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents btn_AddSearchObj As Button
    Friend WithEvents tb_searchObjName As TextBox
    Friend WithEvents num_newSearchObjT As NumericUpDown
    Friend WithEvents num_newSearchObjB As NumericUpDown
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents num_newSearchObjH As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents lbl_InfoMaase As Label
    Friend WithEvents lbl_InfoName As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_SearchObj As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents num_SearchObj As NumericUpDown
    Friend WithEvents lb_SearchObjList As ListBox
    Friend WithEvents P4_Auswertung As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cb_ioi_Gaus As CheckBox
    Friend WithEvents cb_ioi_Mask As CheckBox
    Friend WithEvents cb_ioi_Differenz As CheckBox
    Friend WithEvents cb_ioi_Depth As CheckBox
    Friend WithEvents num_ThreshTief As NumericUpDown
    Friend WithEvents num_ThreshHoch As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Num_SearchToleranz As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents P5_ResultSearchObj As TabPage
    Friend WithEvents lbl_FoundWidth As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents lbl_Found_Rot As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lbl_FoundZent As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lbl_FoundObj As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents ib_Found As Emgu.CV.UI.ImageBox
    Friend WithEvents P5_Conection As TabPage
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents num_pixmmH_faktor As NumericUpDown
    Friend WithEvents Label25 As Label
    Friend WithEvents num_pixmmB_faktor As NumericUpDown
    Friend WithEvents Label23 As Label
    Friend WithEvents P6_test As TabPage
    Friend WithEvents btn_TestVerschieben As Button
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents lbl_TCP_Status As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents btn_TCP_Connect As Button
    Friend WithEvents num_TCP_Port As NumericUpDown
    Friend WithEvents tb_TCP_HOST As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents btn_TCPVariable_New As Button
    Friend WithEvents num_TCPVariable_Wert As NumericUpDown
    Friend WithEvents tb_TCPVarible_Name As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents btn_TCPVariable_Del As Button
    Friend WithEvents btn_TCPVariable_Set As Button
    Friend WithEvents dgv_TCPVariableViewer As DataGridView
    Friend WithEvents P6_Sub_IOI As TabPage
    Friend WithEvents ib_ImOfIn_02 As Emgu.CV.UI.ImageBox
    Friend WithEvents ib_ImOfIn_01 As Emgu.CV.UI.ImageBox
    Friend WithEvents P7_Sub_Laplace As TabPage
    Friend WithEvents ib_laplace_02 As Emgu.CV.UI.ImageBox
    Friend WithEvents ib_laplace_01 As Emgu.CV.UI.ImageBox
    Friend WithEvents P9_Sub_Mask As TabPage
    Friend WithEvents ib_mask_02 As Emgu.CV.UI.ImageBox
    Friend WithEvents ib_mask_01 As Emgu.CV.UI.ImageBox
    Friend WithEvents P10_Sub_Points As TabPage
    Friend WithEvents ib_points_02 As Emgu.CV.UI.ImageBox
    Friend WithEvents ib_points_01 As Emgu.CV.UI.ImageBox
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents rb_Auswertung_Color As RadioButton
    Friend WithEvents rb_Auswertung_Kombi As RadioButton
    Friend WithEvents rb_Auswertung_Depth As RadioButton
    Friend WithEvents P8_Sub_DistImg As TabPage
    Friend WithEvents ib_Dist02 As Emgu.CV.UI.ImageBox
    Friend WithEvents ib_Dist01 As Emgu.CV.UI.ImageBox
    Friend WithEvents TC3_ObjLists As TabControl
    Friend WithEvents P1_All As TabPage
    Friend WithEvents LB_obj As ListBox
    Friend WithEvents P2_Found As TabPage
    Friend WithEvents lb_Found As ListBox
    Friend WithEvents btn_LoadSearch As Button
    Friend WithEvents btn_SaveSearch As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Label37 As Label
    Friend WithEvents num_WTS_MinT As NumericUpDown
    Friend WithEvents Label38 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents num_WTS_MinB As NumericUpDown
    Friend WithEvents Label36 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents num_WTS_MinH As NumericUpDown
    Friend WithEvents Label31 As Label
    Friend WithEvents cb_Watershed_Filter As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_depthOffset As Button
    Friend WithEvents lbl_Found_Depth As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents GroupBox19 As GroupBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents num_RoboOffsety As NumericUpDown
    Friend WithEvents num_RoboOffsetX As NumericUpDown
End Class
