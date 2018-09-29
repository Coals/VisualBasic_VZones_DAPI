Public Class VZonesDAPI
    Public Declare Function DapiStart Lib "vzdapi.dll"(AppName As String) As Boolean
    Public Declare Function DapiStop Lib "vzdapi.dll"() As Integer
    Public Declare Function DapiIsVZThere Lib "vzdapi.dll"() As Boolean
    Public Declare Function DapiGetText Lib "vzdapi.dll"(Buffer As String, length As Integer, Timeout As Integer) _
        As String
    Public Declare Function DapiSpeak Lib "vzdapi.dll"(txt As String, Timeout As Integer) As Boolean
    Public Declare Function DapiThink Lib "vzdapi.dll"(txt As String, Timeout As Integer) As Boolean
    Public Declare Function DapiESP Lib "vzdapi.dll"(Avatar As String, txt As String, Timeout As Integer) As Boolean
    Public Declare Function DapiPressButton Lib "vzdapi.dll"(ButtonNumber As Short) As Boolean
    Public Declare Function DapiIsButtonActive Lib "vzdapi.dll"(ButtonNumber As Short) As Boolean

    Public Const VZ_BUTTON_LEFT As Short = 1
    Public Const VZ_BUTTON_UP As Short = 2
    Public Const VZ_BUTTON_DOWN As Short = 3
    Public Const VZ_BUTTON_RIGHT As Short = 4
    Public Const VZ_BUTTON_GHOST As Short = 5
    Public Const VZ_BUTTON_NORMAL As Short = 6
    Public Const VZ_BUTTON_HAPPY As Short = 7
    Public Const VZ_BUTTON_SAD As Short = 8
    Public Const VZ_BUTTON_MAD As Short = 9
    Public Const VZ_BUTTON_WAVE As Short = 10
    Public Const VZ_BUTTON_BOW As Short = 11
    Public Const VZ_BUTTON_SHRUG As Short = 12
    Public Const VZ_BUTTON_PRESENT As Short = 13
    Public Const VZ_BUTTON_JUMP As Short = 14
    Public Const VZ_BUTTON_REACT As Short = 15
    Public Const VZ_BUTTON_TLEFT As Short = 16
    Public Const VZ_BUTTON_TRIGHT As Short = 17
    Public Const VZ_BUTTON_TAROUND As Short = 18
End Class