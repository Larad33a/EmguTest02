﻿Public Class MyRefObjekt
    Public Property PunktRobo As PointF
    Public Property PunktCam As PointF
    Public Property ZinMM As Int32
    Public Property ZinUnits As Int32

    'XY
    Sub New(robo As PointF, kamera As PointF)
        _PunktRobo = robo
        _PunktCam = kamera
    End Sub
    Sub New(robox As Single, roboy As Single, kamerax As Single, kameray As Single, kameraZ As Int32)
        _PunktRobo = New PointF(robox, roboy)
        _PunktCam = New PointF(kamerax, kameray)
        _ZinUnits = kameraZ
    End Sub
    'Z
    Sub New(zinmm As Int32)
        _ZinMM = zinmm
    End Sub
    Sub New(zinmm As Int32, zinunits As Int32)
        _ZinMM = zinmm
        _ZinUnits = zinunits
    End Sub
    'Xr = Mx*Xc+Bx
    'Yr = My*Yc+By

    Public Overrides Function ToString() As String
        Return ($"R:({_PunktRobo.ToString(),5:n2}) | K:({_PunktCam.ToString(),5:n2})")
    End Function
End Class
