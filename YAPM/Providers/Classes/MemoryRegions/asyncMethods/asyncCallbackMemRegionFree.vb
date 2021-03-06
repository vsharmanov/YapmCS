﻿' =======================================================
' Yet Another (remote) Process Monitor (YAPM)
' Copyright (c) 2008-2009 Alain Descotes (violent_ken)
' https://sourceforge.net/projects/yaprocmon/
' =======================================================


' YAPM is free software; you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation; either version 3 of the License, or
' (at your option) any later version.
'
' YAPM is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with YAPM; if not, see http://www.gnu.org/licenses/.


Option Strict On

Imports System.Runtime.InteropServices
Imports System.Text

Public Class asyncCallbackMemRegionFree

    Private con As cMemRegionConnection
    Private _deg As HasFreed

    Public Delegate Sub HasFreed(ByVal Success As Boolean, ByVal pid As Integer, ByVal address As IntPtr, ByVal msg As String, ByVal actionNumber As Integer)

    Public Sub New(ByVal deg As HasFreed, ByRef memConnection As cMemRegionConnection)
        _deg = deg
        con = memConnection
    End Sub

    Public Structure poolObj
        Public pid As Integer
        Public address As IntPtr
        Public size As IntPtr
        Public type As Native.Api.NativeEnums.MemoryState
        Public newAction As Integer
        Public Sub New(ByVal pi As Integer, _
                       ByVal ad As IntPtr, _
                       ByVal siz As IntPtr, _
                       ByVal typ As Native.Api.NativeEnums.MemoryState, _
                       ByVal act As Integer)
            address = ad
            newAction = act
            size = siz
            type = typ
            pid = pi
        End Sub
    End Structure

    Public Sub Process(ByVal thePoolObj As Object)

        Dim pObj As poolObj = DirectCast(thePoolObj, poolObj)
        If con.ConnectionObj.IsConnected = False Then
            Exit Sub
        End If

        Select Case con.ConnectionObj.ConnectionType
            Case cConnection.TypeOfConnection.RemoteConnectionViaSocket
                Try
                    Dim cDat As New cSocketData(cSocketData.DataType.Order, cSocketData.OrderType.MemoryFree, pObj.pid, pObj.address, pObj.size, pObj.type)
                    con.ConnectionObj.Socket.Send(cDat)
                Catch ex As Exception
                    Misc.ShowError(ex, "Unable to send request to server")
                End Try

            Case cConnection.TypeOfConnection.RemoteConnectionViaWMI

            Case Else
                ' Local
                Dim ret As Boolean = Native.Objects.MemRegion.FreeMemory(pObj.pid, _
                                                    pObj.address, pObj.size, pObj.type)
                _deg.Invoke(ret, pObj.pid, pObj.address, Native.Api.Win32.GetLastError, pObj.newAction)
        End Select
    End Sub

End Class
