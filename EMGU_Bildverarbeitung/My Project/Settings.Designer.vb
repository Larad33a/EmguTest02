﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.42000
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Automatische My.Settings-Speicherfunktion"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("20")>  _
        Public Property Steur_Tolreanz() As Integer
            Get
                Return CType(Me("Steur_Tolreanz"),Integer)
            End Get
            Set
                Me("Steur_Tolreanz") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("120")>  _
        Public Property Konf_MaskeH() As Integer
            Get
                Return CType(Me("Konf_MaskeH"),Integer)
            End Get
            Set
                Me("Konf_MaskeH") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("250")>  _
        Public Property Konf_MaskeV() As Integer
            Get
                Return CType(Me("Konf_MaskeV"),Integer)
            End Get
            Set
                Me("Konf_MaskeV") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-40")>  _
        Public Property Konf_KameraOffset() As Integer
            Get
                Return CType(Me("Konf_KameraOffset"),Integer)
            End Get
            Set
                Me("Konf_KameraOffset") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1.37462")>  _
        Public Property Konv_FaktorPixMilH() As Double
            Get
                Return CType(Me("Konv_FaktorPixMilH"),Double)
            End Get
            Set
                Me("Konv_FaktorPixMilH") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1.37462")>  _
        Public Property Konv_FaktorPixMilB() As Double
            Get
                Return CType(Me("Konv_FaktorPixMilB"),Double)
            End Get
            Set
                Me("Konv_FaktorPixMilB") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0.95")>  _
        Public Property Konv_RoboOffsetX() As Double
            Get
                Return CType(Me("Konv_RoboOffsetX"),Double)
            End Get
            Set
                Me("Konv_RoboOffsetX") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1.05")>  _
        Public Property Konv_RoboOffsetY() As Double
            Get
                Return CType(Me("Konv_RoboOffsetY"),Double)
            End Get
            Set
                Me("Konv_RoboOffsetY") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("710")>  _
        Public Property Ausw_TiefsteReg() As Integer
            Get
                Return CType(Me("Ausw_TiefsteReg"),Integer)
            End Get
            Set
                Me("Ausw_TiefsteReg") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300")>  _
        Public Property Ausw_HöchsteReg() As Integer
            Get
                Return CType(Me("Ausw_HöchsteReg"),Integer)
            End Get
            Set
                Me("Ausw_HöchsteReg") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public Property Ausw_MindestObjH() As Integer
            Get
                Return CType(Me("Ausw_MindestObjH"),Integer)
            End Get
            Set
                Me("Ausw_MindestObjH") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public Property Ausw_MindestObjB() As Integer
            Get
                Return CType(Me("Ausw_MindestObjB"),Integer)
            End Get
            Set
                Me("Ausw_MindestObjB") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("10")>  _
        Public Property Ausw_MindestObjT() As Integer
            Get
                Return CType(Me("Ausw_MindestObjT"),Integer)
            End Get
            Set
                Me("Ausw_MindestObjT") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("192.168.43.14")>  _
        Public Property TCP_Host() As String
            Get
                Return CType(Me("TCP_Host"),String)
            End Get
            Set
                Me("TCP_Host") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2019")>  _
        Public Property TCP_Port() As Integer
            Get
                Return CType(Me("TCP_Port"),Integer)
            End Get
            Set
                Me("TCP_Port") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property Konf_KameraColorOffset() As Integer
            Get
                Return CType(Me("Konf_KameraColorOffset"),Integer)
            End Get
            Set
                Me("Konf_KameraColorOffset") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0.0011098")>  _
        Public Property Rever_FaktorX() As Double
            Get
                Return CType(Me("Rever_FaktorX"),Double)
            End Get
            Set
                Me("Rever_FaktorX") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-0.0010708")>  _
        Public Property Rever_FaktorY() As Double
            Get
                Return CType(Me("Rever_FaktorY"),Double)
            End Get
            Set
                Me("Rever_FaktorY") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-566.75")>  _
        Public Property Rever_OffsetX() As Double
            Get
                Return CType(Me("Rever_OffsetX"),Double)
            End Get
            Set
                Me("Rever_OffsetX") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("688.25")>  _
        Public Property Rever_OffsetY() As Double
            Get
                Return CType(Me("Rever_OffsetY"),Double)
            End Get
            Set
                Me("Rever_OffsetY") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Rever_FaktorZ() As Double
            Get
                Return CType(Me("Rever_FaktorZ"),Double)
            End Get
            Set
                Me("Rever_FaktorZ") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Rever_FaktorPosX() As Double
            Get
                Return CType(Me("Rever_FaktorPosX"),Double)
            End Get
            Set
                Me("Rever_FaktorPosX") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Rever_FaktorPosY() As Double
            Get
                Return CType(Me("Rever_FaktorPosY"),Double)
            End Get
            Set
                Me("Rever_FaktorPosY") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.EMGUBildverarbeitung.My.MySettings
            Get
                Return Global.EMGUBildverarbeitung.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
